Public Class FrmShop

#Region " Load Data "

    Sub LoadCars()

        Dim DT_Cars = DB.ToRows("SELECT * FROM VW_Products WHERE Visible = True ORDER BY Name ASC")
        Dim Card_X As Integer = 5
        Dim Card_Y As Integer = 5

        For Each Row In DT_Cars

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

            AddHandler Card.BuyClick, AddressOf Card_Click

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

#End Region

#Region " Events - Form "

    Private Sub FrmShop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblUser.Text = String.Format("Hi {0}, Welcome Back", Session.CurrentUser.Username).ToUpper()
        LoadCars()
    End Sub

#End Region

#Region " Events - TextBox "

#End Region

#Region " Events - Button "

    Private Sub BtnLoans_Click(sender As Object, e As EventArgs) Handles BtnLoans.Click

    End Sub

    Private Sub BtnOrder_Click(sender As Object, e As EventArgs) Handles BtnOrder.Click

    End Sub

    Private Sub BtnAccount_Click(sender As Object, e As EventArgs) Handles BtnAccount.Click

    End Sub

    Private Sub BtnLogout_Click(sender As Object, e As EventArgs) Handles BtnLogout.Click
        Dim Res = Toast.Question("Are your sure you want to logout?")
        If Not Res = DialogResult.Yes Then Exit Sub
        Close()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click

    End Sub

#End Region

#Region " Events - Card "

    Private Sub Card_Click(sender As Object, e As EventArgs) Handles BtnLoans.Click

        Dim Card = CType(sender, Cards)

        MessageBox.Show(Card.Product.Item("Name"))

    End Sub


#End Region

End Class
