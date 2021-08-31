Public Class FrmShop

    Dim DicCars As New Dictionary(Of String, String)
    Dim DicBrands As New Dictionary(Of String, String)
    Dim RowsProduct As IEnumerable(Of DataRow)

#Region " Load Data "

    Sub LoadCars(Optional Filter As String = "")
        Dim StrQuery = String.Format("SELECT * FROM VW_Products WHERE Visible = True AND Name LIKE '%{0}%' ORDER BY Name ASC", Filter.Replace("'", "''").Replace(";", "").Replace("&", ""))

        RowsProduct = DB.ToRows(StrQuery)

        Dim Card_X As Integer = 5
        Dim Card_Y As Integer = 5

        PnlBody.Controls.Clear()
        DicBrands.Clear()
        DicCars.Clear()

        For Each Row In RowsProduct.AsEnumerable()

            Dim Card As New Cards With {
                .Location = New Point(Card_X, Card_Y),
                .Width = 250,
                .Height = 205
            }

            Card.Product.Add("ID", Row("ID"))
            Card.Product.Add("Name", Row("Name"))
            Card.Product.Add("Price", Row("Price"))
            Card.Product.Add("Stock", Row("Stock"))
            Card.Product.Add("Brand_Name", Row("Brand_Name"))
            Card.Product.Add("Color_Name", Row("Color_Name"))
            Card.Product.Add("Image", Row("Image"))

            AddHandler Card.OnBuyClick, AddressOf Card_Click

            PnlBody.Controls.Add(Card)
            PnlBody.Refresh()

            Dim FreeWidth = PnlBody.Width - (Card_X + 250)

            If FreeWidth <= 255 Then
                Card_Y += 210
                Card_X = 5
            Else
                Card_X += 255
            End If

        Next

        Application.DoEvents()

    End Sub

    Sub AddBrand(BrandID As Integer, BrandName As String)
        If DicBrands.ContainsKey(BrandID).Equals(True) Then Exit Sub
        DicBrands.Add(BrandID, BrandName)
    End Sub

    Sub LoadTree()
        Dim Rows = DB.ToRows("SELECT * FROM VW_Products WHERE Visible = True ORDER BY Name ASC")

        If IsNothing(Rows) Then Exit Sub

        For Each Row In Rows
            AddBrand(Row("Brand_ID"), Row("Brand_Name"))
        Next

        If IsNothing(RowsProduct) Then Exit Sub

        TreBrand.Nodes.Clear()

        For Each NodeBrand In DicBrands
            Dim NodeCars = TreBrand.Nodes.Add(NodeBrand.Key, NodeBrand.Value)
            Dim RowCars = RowsProduct.Where(Function(Car) Car("Brand_Name").Equals(NodeBrand.Value)).AsEnumerable()

            If RowCars.Count().Equals(0) Then Continue For

            For Each Car In RowCars
                If NodeCars.Nodes.ContainsKey(Car("Car_ID")) Then Continue For
                NodeCars.Nodes.Add(Car("Car_ID"), Car("Car_Name"))
            Next
        Next
    End Sub

#End Region

#Region " Events - Form "

    Private Sub FrmShop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblUser.Text = String.Format("Hi {0}, Welcome Back", Session.CurrentUser.Name).ToUpper()
        LoadCars()
        LoadTree()
    End Sub

    Private Sub FrmShop_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        LoadCars(TxtSearch.Text)
    End Sub

#End Region

#Region " Events - Button "

    Private Sub BtnLoans_Click(sender As Object, e As EventArgs) Handles BtnLoans.Click
        Dim Frm As New FrmLoans()
        Frm.ShowDialog()
    End Sub

    Private Sub BtnOrder_Click(sender As Object, e As EventArgs) Handles BtnOrder.Click
        Dim Frm As New FrmOrderHistory()
        Frm.ShowDialog()
    End Sub

    Private Sub BtnAccount_Click(sender As Object, e As EventArgs) Handles BtnAccount.Click
        Dim Frm As New FrmAccount()
        Frm.ShowDialog()
    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Dim Res = Toast.Question("Are your sure you want to logout?")
        If Not Res = DialogResult.Yes Then Exit Sub
        Close()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        LoadCars(TxtSearch.Text)
    End Sub

#End Region

#Region " Events - Card "

    Private Sub Card_Click(sender As Object, e As EventArgs)

        Dim Card = CType(sender, Cards)
        Dim Frm As New FrmOrder With {
            .Product = Card.Product
        }
        If Frm.ShowDialog() = DialogResult.OK Then

            Dim FrmReport As New FrmReportViewer()
            Dim Params As New Dictionary(Of String, Object) From {
                {"@ID", Frm.Return_ID}
            }

            FrmReport.ShowReport("RPT_Order", Params)
            LoadCars()
        End If
    End Sub

#End Region

End Class
