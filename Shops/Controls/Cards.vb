Public Class Cards

#Region " Properties "

    Private PVT_Product As New Dictionary(Of String, String)
    Public Property Product() As Dictionary(Of String, String)
        Get
            Return PVT_Product
        End Get
        Set(ByVal value As Dictionary(Of String, String))
            PVT_Product = value
        End Set
    End Property

    Public Custom Event OnBuyClick As EventHandler
        AddHandler(value As EventHandler)
            Events.AddHandler("BuyClick", value)
        End AddHandler
        RemoveHandler(value As EventHandler)
            Events.RemoveHandler("BuyClick", value)
        End RemoveHandler
        RaiseEvent(sender As Object, e As EventArgs)
            CType(Events("BuyClick"), EventHandler).Invoke(sender, e)
        End RaiseEvent
    End Event

#End Region

#Region " Events - Button  "

    Private Sub BtnBuyNow_Click(sender As Object, e As EventArgs) Handles BtnBuyNow.Click
        RaiseEvent OnBuyClick(Me, e)
    End Sub

#End Region

#Region " Events - Conrtol "

    Private Sub Cards_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If (Product.Count().Equals(0)) Then Exit Sub

        Dim Tips = Product.Item("Name")

        LblName.Text = String.Format("{0}{1}{2}", Product.Item("Name"), Environment.NewLine, Product.Item("Price").ToDouble().ToString("P #, ###.00"))
        PicCar.Image = Util.Base64Image(Product.Item("Image"))

        TipMain.SetToolTip(BtnBuyNow, Tips)
        TipMain.SetToolTip(PicCar, Tips)
        TipMain.SetToolTip(Me, Tips)
    End Sub

#End Region

End Class
