Imports System.Text

Public Class FrmOrder

    Public Modes As New List(Of Payment_Mode)
    Public Product As New Dictionary(Of String, String)
    Private IsLoad As Boolean = True
    Private Customer_ID As Integer = 0
    Private PVT_RetID As Integer = 0

    Public Property Return_ID() As Integer
        Get
            Return PVT_RetID
        End Get
        Set(ByVal value As Integer)
            PVT_RetID = value
        End Set
    End Property

#Region " Load Data "

    Sub LoadCombo()
        Dim DT = DB.ToData(String.Format("SELECT * FROM VW_Customers_Card_Type WHERE Customer_ID = {0}", Session.CurrentUser.Customer_ID))

        Filler.Load(CboCard_Alias, DT, "Name", "ID")

        Modes = DT.AsEnumerable().Select(
            Function(Row)
                Return New Payment_Mode(Row("ID"), Row("Name"), Row("Card_Type"), Row("Card_No"), Row("Card_Pin"), Row("Card_Expiry"))
            End Function).ToList()

        IsLoad = False
    End Sub

    Sub LoadShipping()
        Dim Row = DB.ToRow(String.Format("SELECT TOP 1 * FROM VW_Customers_Shipment WHERE Customer_ID = {0}", Session.CurrentUser.Customer_ID))

        If IsNothing(Row) Then Exit Sub

        TxtFirst_Name.Text = Row("First_Name")
        TxtMiddle_Name.Text = Row("Middle_Name")
        TxtLast_Name.Text = Row("Last_Name")
        TxtEmail.Text = Row("Email").ToString()
        TxtContact_No.Text = Row("Contact_No").ToString()
        TxtAddress.Text = Row("Address")
        TxtCity.Text = Row("City")
        TxtProvince.Text = Row("State")
        TxtCountry.Text = Row("Country")
        TxtZip_Code.Text = Row("Zip_Code")

        Customer_ID = Row("Customer_ID")

    End Sub

#End Region

#Region " Events - Forms "

    Private Sub FrmOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCombo()

        PicCar.Image = Util.Base64Image(Product.Item("Image"))
        TxtOrder_No.Text = "AUTO"
        TxtOrder_Date.Text = Date.Now.ToString("MMM dd, yyyy")
        TxtName.Text = Product.Item("Name")
        TxtPrice.Text = Product.Item("Price").ToDouble().ToString("P #, ##0.00")
        TxtStock.Text = Product.Item("Stock")

        If Product.Item("Stock").ToInt() <= 0 Then
            BtnConfirm.Enabled = False
            GrpPayment.Enabled = False
            LblStock.Visible = True
        End If

        LoadShipping()
    End Sub

#End Region

#Region " Events - Button "

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Close()
    End Sub

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click

        If IsComplete().Equals(False) Then Exit Sub

        If Not TxtCard_Pin.Text.Equals(TxtCard_Pin.Tag) Then
            Toast.Required("Invalid PIN Number. Please try again")
            Exit Sub
        End If

        Dim Rates = Math.Round(Convert.ToDouble(TxtRate.Tag), 2)
        Dim Price = Convert.ToDouble(Product.Item("Price"))
        Dim Payment = NumAmount.Value.ToDouble()
        Dim IsMatched = IIf(RbtLoan.Checked.Equals(True), Payment.Equals(Rates), Payment.Equals(Price))

        If IsMatched.Equals(False) Then
            Toast.Required(String.Format("Please pay an exact amount of {0}", IIf(RbtLoan.Checked.Equals(True), Rates.ToString("P #, ##0.00"), Price.ToString("P #, ##0.00"))))
            Exit Sub
        End If

        If SaveOrder().Equals(False) Then Exit Sub

        DialogResult = DialogResult.OK
        Close()
    End Sub

#End Region

#Region " Events - Radio "

    Private Sub RbtCash_CheckedChanged(sender As Object, e As EventArgs) Handles RbtCash.CheckedChanged
        GrpLoan.Enabled = False
        TxtRate.Text = "0"
        TxtRate.Tag = "0"
        NumYears.Value = 1
        TxtMonth.Text = "12"
    End Sub

    Private Sub RbtLoan_CheckedChanged(sender As Object, e As EventArgs) Handles RbtLoan.CheckedChanged
        GrpLoan.Enabled = True
        ComputeRate()
    End Sub

#End Region

#Region " Events - Numeric Number "

    Private Sub NumYears_ValueChanged(sender As Object, e As EventArgs) Handles NumYears.ValueChanged
        If IsLoad.Equals(True) Then Exit Sub
        ComputeRate()
    End Sub

    Sub ComputeRate()
        Dim Amortization = Math.Round((Product.Item("Price").ToDouble() / (NumYears.Value * 12)), 2)
        TxtRate.Tag = Amortization
        TxtRate.Text = Amortization.ToString("P #, ##0.00")
        TxtMonth.Text = NumYears.Value * 12
    End Sub

#End Region

#Region " Events - ComboBox "

    Private Sub CboCard_SelectedValueChanged(sender As Object, e As EventArgs) Handles CboCard_Alias.SelectedValueChanged
        If IsLoad.Equals(True) Then Exit Sub
        Dim CardInfo = Modes.Where(Function(Row) Row.ID.Equals(CboCard_Alias.SelectedValue.ToString())).SingleOrDefault()
        TxtCard_Type.Text = CardInfo.Card_Type
        TxtCard_No.Text = CardInfo.Card_No
        TxtCard_Pin.Tag = CardInfo.Card_Pin
        TxtCard_Expiry.Text = CardInfo.Card_Expiry
    End Sub

#End Region

#Region " Validation "

    Function IsComplete() As Boolean
        Dim Rows = Util.Controls(Me, "Required").OrderBy(Function(r) r.Control_Index).AsEnumerable()
        For Each Row In Rows
            Dim Ctl = Row.Control_Type
            Select Case TypeName(Ctl)
                Case "TextBox"
                    If Ctl.Text.Equals("") Then
                        Toast.Required(String.Format("Please input {0}", Ctl.Name.Replace("Txt", "").Replace("_", " ")))
                        Ctl.Focus()
                        Return False
                    End If
                Case "ComboBox"
                    If Ctl.Text.Equals("") Then
                        Toast.Required(String.Format("Please select {0}", Ctl.Name.Replace("Cbo", "").Replace("_", " ")))
                        Ctl.Focus()
                        Return False
                    End If
            End Select
        Next
        Return True
    End Function

#End Region

#Region " Save "

    Function SaveOrder() As Boolean
        Using Con = DB.Connection
            Dim Trans = Con.BeginTransaction
            Try

                Dim Order_ID As Integer = 0
                Dim Stamp = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
                Dim Mode = IIf(RbtLoan.Checked.Equals(True), 2, 1)
                Dim Cmd_Text As New StringBuilder()

                Cmd_Text.Append("INSERT INTO Orders (Trans_Date, Customer_ID, Product_ID, Payment_Mode_ID, Amount, Amount_Paid) ")
                Cmd_Text.Append("VALUES (@Trans_Date, @Customer_ID, @Product_ID, @Payment_Mode_ID, @Amount, @Amount_Paid)")

                Using Cmd = DB.Command(Cmd_Text.ToString(), Con, Trans)
                    With Cmd
                        .Parameters.AddWithValue("@Trans_Date", Stamp)
                        .Parameters.AddWithValue("@Customer_ID", Customer_ID)
                        .Parameters.AddWithValue("@Product_ID", Product.Item("ID").ToInt())
                        .Parameters.AddWithValue("@Payment_Mode_ID", Mode)
                        .Parameters.AddWithValue("@Amount", Product.Item("Price").ToDouble())
                        .Parameters.AddWithValue("@Amount_Paid", NumAmount.Value.ToDouble())
                        .ExecuteNonQuery()
                        .CommandText = "SELECT @@IDENTITY"
                    End With
                    Order_ID = Cmd.ExecuteScalar()
                End Using

                If Order_ID.Equals(0) Then
                    Trans.Rollback()
                    Toast.Error("Failed on processing your order!")
                    Return False
                End If

                Dim Trans_No = String.Format("PRN{0,8}", Order_ID.ToString("D8"))

                Cmd_Text.Clear()
                Cmd_Text.Append("INSERT INTO Orders_Payment (Order_ID, Method_ID, Payment_No, Payment_Date, Amount) ")
                Cmd_Text.Append("VALUES (@Order_ID, @Method_ID, @Payment_No, @Payment_Date, @Amount)")

                Using Cmd = DB.Command(Cmd_Text.ToString(), Con, Trans)
                    With Cmd
                        .Parameters.AddWithValue("@Order_ID", Order_ID)
                        .Parameters.AddWithValue("@Method_ID", Mode)
                        .Parameters.AddWithValue("@Payment_No", Trans_No)
                        .Parameters.AddWithValue("@Payment_Date", Stamp)
                        .Parameters.AddWithValue("@Amount", NumAmount.Value.ToDouble())
                        .ExecuteNonQuery()
                    End With
                End Using

                Cmd_Text.Clear()
                Cmd_Text.Append("INSERT INTO Orders_Shipment (Order_ID, Address, City, State, Country, Zip_Code) ")
                Cmd_Text.Append("VALUES (@Order_ID, @Address, @City, @State, @Country, @Zip_Code)")

                Using Cmd = DB.Command(Cmd_Text.ToString(), Con, Trans)
                    With Cmd
                        .Parameters.AddWithValue("@Order_ID", Order_ID)
                        .Parameters.AddWithValue("@Address", TxtAddress.Text)
                        .Parameters.AddWithValue("@City", TxtCity.Text)
                        .Parameters.AddWithValue("@State", TxtProvince.Text)
                        .Parameters.AddWithValue("@Country", TxtCountry.Text)
                        .Parameters.AddWithValue("@Zip_Code", TxtZip_Code.Text)
                        .ExecuteNonQuery()
                    End With
                End Using

                If RbtLoan.Checked.Equals(True) Then

                    Dim Loan_Total = Product.Item("Price").ToDouble()
                    Dim Loan_Year = NumYears.Value.ToInt()
                    Dim Loan_Month = Loan_Year * 12
                    Dim Loan_Amortization = Math.Round((Loan_Total / Loan_Month), 2)
                    Dim Loan_Payment = NumAmount.Value.ToDouble()
                    Dim Loan_Balance = Loan_Total - Loan_Payment
                    Dim Lina_Month_Rem = Loan_Month - 1

                    Cmd_Text.Clear()
                    Cmd_Text.Append("INSERT INTO Loans (Order_ID, Customer_ID, Years, Months, Amortization, Total, Payment, Balance, Months_Remaining) ")
                    Cmd_Text.Append("VALUES (@Order_ID, @Customer_ID, @Years, @Months, @Amortization, @Total, @Payment, @Balance, @Months_Remaining)")

                    Using Cmd = DB.Command(Cmd_Text.ToString(), Con, Trans)
                        With Cmd
                            .Parameters.AddWithValue("@Order_ID", Order_ID)
                            .Parameters.AddWithValue("@Customer_ID", Customer_ID)
                            .Parameters.AddWithValue("@Months", Loan_Year)
                            .Parameters.AddWithValue("@Months", Loan_Month)
                            .Parameters.AddWithValue("@Amortization", Loan_Amortization)
                            .Parameters.AddWithValue("@Total", Loan_Total)
                            .Parameters.AddWithValue("@Payment", Loan_Payment)
                            .Parameters.AddWithValue("@Balance", Loan_Balance)
                            .Parameters.AddWithValue("@Months_Remaining", Lina_Month_Rem)
                            .ExecuteNonQuery()
                        End With
                    End Using

                End If

                Using Cmd = DB.Command(String.Format("UPDATE Products SET Stock = Stock - 1 WHERE ID = {0}", Product.Item("ID").ToInt()), Con, Trans)
                    Cmd.ExecuteNonQuery()
                End Using

                PVT_RetID = Order_ID

                Trans.Commit()
                Toast.Message("Your order was successfully processed!")
                Return True
            Catch ex As Exception
                Trans.Rollback()
                Toast.Error(ex.Message)
                Return False
            End Try
        End Using
    End Function

#End Region

End Class