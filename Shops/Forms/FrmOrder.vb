Public Class FrmOrder

    Public Modes As New List(Of Payment_Mode)
    Public Product As New Dictionary(Of String, String)
    Private IsLoad As Boolean = True

#Region " Load Data "

    Sub LoadCombo()
        Dim DT = DB.ToData(String.Format("SELECT * FROM VW_Customers_Card_Type WHERE Customer_ID = {0}", Session.CurrentUser.Customer_ID))

        Filler.Load(CboCard, DT, "Name", "ID")

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
        Close()
    End Sub

#End Region

#Region " Events - Radio "

    Private Sub RbtCash_CheckedChanged(sender As Object, e As EventArgs) Handles RbtCash.CheckedChanged
        GrpLoan.Enabled = False
        TxtRate.Text = ""
        TxtRate.Tag = ""
    End Sub

    Private Sub RbtLoan_CheckedChanged(sender As Object, e As EventArgs) Handles RbtLoan.CheckedChanged
        GrpLoan.Enabled = True
    End Sub

#End Region

#Region " Events - Numeric Number "

    Private Sub NumYears_ValueChanged(sender As Object, e As EventArgs) Handles NumYears.ValueChanged
        If IsLoad.Equals(True) Then Exit Sub
        Dim Amortization = (Product.Item("Price").ToDouble() / NumYears.Value)
        TxtRate.Tag = Amortization
        TxtRate.Text = Amortization.ToString("P #, ##0.00")
        TxtMonth.Text = NumYears.Value * 12
    End Sub

#End Region

#Region " Events - ComboBox "
    Private Sub CboCard_SelectedValueChanged(sender As Object, e As EventArgs) Handles CboCard.SelectedValueChanged
        If IsLoad.Equals(True) Then Exit Sub
        Dim CardInfo = Modes.Where(Function(Row) Row.ID.Equals(CboCard.SelectedValue.ToString())).SingleOrDefault()
        TxtCard_Type.Text = CardInfo.Card_Type
        TxtCard_No.Text = CardInfo.Card_No
        TxtCard_Pin.Tag = CardInfo.Card_Pin
        TxtCard_Expiry.Text = CardInfo.Card_Expiry
    End Sub

#End Region

#Region " Save "

#End Region

End Class