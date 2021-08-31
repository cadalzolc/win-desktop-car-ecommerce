Imports System.Text

Public Class FrmLoansPayment

    Public Modes As New List(Of Payment_Mode)

#Region " Properties "

    Private PVT_Loan As Dictionary(Of String, String)
    Private IsLoad As Boolean = True

    Public Property Loan() As Dictionary(Of String, String)
        Get
            Return PVT_Loan
        End Get
        Set(ByVal value As Dictionary(Of String, String))
            PVT_Loan = value
        End Set
    End Property


#End Region

#Region " Load - Data "

    Sub LoadCombo()
        Dim DT = DB.ToData(String.Format("SELECT * FROM VW_Customers_Card_Type WHERE Customer_ID = {0}", Session.CurrentUser.Customer_ID))

        Filler.Load(CboCard_Alias, DT, "Name", "ID")

        Modes = DT.AsEnumerable().Select(
            Function(Row)
                Return New Payment_Mode(Row("ID"), Row("Name"), Row("Card_Type"), Row("Card_No"), Row("Card_Pin"), Row("Card_Expiry"))
            End Function).ToList()

        IsLoad = False
    End Sub

    Sub LoadData()

        TxtFirst_Name.Text = Loan.Item("First_Name")
        TxtLast_Name.Text = Loan.Item("Last_Name")
        TxtProduct.Text = Loan.Item("Product")
        TxtMonths.Text = Loan.Item("Months_Remaining")
        TxtBalance.Text = Loan.Item("Balance")
        TxtAmount.Text = Loan.Item("Amortization").ToDouble().ToString("P #, ##0.00")

    End Sub

#End Region

#Region " Events - Form "

    Private Sub FrmLoansPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCombo()
        LoadData()
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

#Region " Events - Button "

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click

        If IsNothing(CboCard_Alias.SelectedValue) Then
            Toast.Required("Please select payment method.")
            Exit Sub
        End If

        If Not TxtCard_Pin.Text.Equals(TxtCard_Pin.Tag) Then
            Toast.Required("Invalid PIN Number. Please try again")
            Exit Sub
        End If

        Dim Amortization = Loan.Item("Amortization").ToDouble()
        Dim Payment = NumAmount.Value.ToDouble()
        Dim IsMatched = Payment.Equals(Amortization)

        If IsMatched.Equals(False) Then
            Toast.Required(String.Format("Please pay an exact amount of {0}", Amortization.ToString("P #, ##0.00")))
            Exit Sub
        End If

        If SavePayment().Equals(False) Then Exit Sub

        DialogResult = DialogResult.OK

        Close()
    End Sub

#End Region

#Region " Save "

    Function SavePayment() As Boolean
        Using Con = DB.Connection
            Dim Trans = Con.BeginTransaction
            Try

                Dim Mode = 1
                Dim Loan_ID As Integer = Loan.Item("ID").ToInt()
                Dim Order_ID As Integer = Loan.Item("Order_ID").ToInt()
                Dim Trans_Date = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")
                Dim Trans_No = String.Format("PRN{0,8}", Order_ID.ToString("D8"))
                Dim Cmd_Text As New StringBuilder()
                Dim Amount = NumAmount.Value.ToDouble()
                Dim Payment = Loan.Item("Payment").ToDouble() + Amount
                Dim Balance = Loan.Item("Balance").ToDouble() - Amount
                Dim Month_Rem = Loan.Item("Months_Remaining").ToInt() - 1

                Cmd_Text.Clear()
                Cmd_Text.Append("INSERT INTO Orders_Payment (Order_ID, Method_ID, Payment_No, Payment_Date, Amount) ")
                Cmd_Text.Append("VALUES (@Order_ID, @Method_ID, @Payment_No, @Payment_Date, @Amount)")

                Using Cmd = DB.Command(Cmd_Text.ToString(), Con, Trans)
                    Cmd.Parameters.AddWithValue("@Order_ID", Order_ID)
                    Cmd.Parameters.AddWithValue("@Method_ID", Mode)
                    Cmd.Parameters.AddWithValue("@Payment_No", Trans_No)
                    Cmd.Parameters.AddWithValue("@Payment_Date", Trans_Date)
                    Cmd.Parameters.AddWithValue("@Amount", Amount)
                    Cmd.ExecuteNonQuery()
                End Using

                Using Cmd = DB.Command("UPDATE Loans SET Payment = @Payment, Balance = @Balance, Months_Remaining = @Months_Remaining WHERE [ID] = @ID", Con, Trans)
                    Cmd.Parameters.AddWithValue("@Payment", Payment)
                    Cmd.Parameters.AddWithValue("@Balance", Balance)
                    Cmd.Parameters.AddWithValue("@Months_Remaining", Month_Rem)
                    Cmd.Parameters.AddWithValue("@ID", Loan_ID)
                    Cmd.ExecuteNonQuery()
                End Using

                Using Cmd = DB.Command("UPDATE Orders SET Amount_Paid = @Amount_Paid WHERE [ID] = @ID", Con, Trans)

                    Cmd.Parameters.AddWithValue("@Amount_Paid", Payment)
                    Cmd.Parameters.AddWithValue("@ID", Order_ID)
                    Cmd.ExecuteNonQuery()
                End Using

                Trans.Commit()
                Toast.Message("Your payment was successfully processed!")
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