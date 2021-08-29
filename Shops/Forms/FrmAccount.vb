Public Class FrmAccount

    Private Customer As DataRow
    Private Address As DataRow
    Private Account As DataRow

#Region " Load Info "

    Sub LoadCombo()
        Dim Genders = DB.ToData("SELECT * FROM Genders")

        Filler.Load(CboGender, Genders, "Name", "Name")
    End Sub

    Sub LoadInfo()
        Customer = DB.ToRow(String.Format("SELECT TOP 1 * FROM Customers WHERE ID = {0}", Session.CurrentUser.Customer_ID))
        Address = DB.ToRow(String.Format("SELECT TOP 1 * FROM Customers_Shipment WHERE Customer_ID = {0}", Session.CurrentUser.Customer_ID))
        Account = DB.ToRow(String.Format("SELECT TOP 1 * FROM Customers_Account WHERE Customer_ID = {0}", Session.CurrentUser.Customer_ID))

        If Not IsNothing(Customer) Then
            TxtFirst_Name.Text = Customer("First_Name")
            TxtMiddle_Name.Text = Customer("Middle_Name")
            TxtLast_Name.Text = Customer("Last_Name")
            TxtEmail.Text = Customer("Email").ToString()
            TxtContact_No.Text = Customer("Contact_No").ToString()
            CboGender.SelectedValue = Customer("Gender")
        End If

        If Not IsNothing(Address) Then
            TxtAddress.Text = Address("Address")
            TxtCity.Text = Address("City")
            TxtProvince.Text = Address("State")
            TxtCountry.Text = Address("Country")
            TxtZip_Code.Text = Address("Zip_Code")
        End If
    End Sub

    Sub LoadGrid()
        Dim DT = DB.ToData(String.Format("SELECT * FROM VW_Customers_Card_Type WHERE Customer_ID = {0}", Session.CurrentUser.Customer_ID))

        GrdList.DataSource = Nothing
        GrdList.DataSource = DT

        For Each Col As DataGridViewColumn In GrdList.Columns
            Select Case Col.Name.ToUpper()
                Case "CARD_TYPE"
                    Col.Visible = True
                    Col.Width = 120
                Case "NAME", "CARD_NO"
                    Col.Visible = True
                    Col.Width = 150
                Case "CARD_PIN", "MONTHS"
                    Col.Visible = True
                    Col.Width = 60
                    Col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Col.HeaderText = "PIN"
                Case "CARD_EXPIRY"
                    Col.Visible = True
                    Col.Width = 75
                    Col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Col.HeaderText = "EXPIRY"
                Case Else
                    Col.Visible = False
            End Select
            Col.HeaderText = Col.HeaderText.Replace("_", " ").ToUpper()
        Next
    End Sub

#End Region

#Region " Events - Form "

    Private Sub FrmAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCombo()
        LoadInfo()
        LoadGrid()
    End Sub

#End Region

#Region " Events - Button "



#End Region

#Region " Events - Grid "

#End Region

End Class