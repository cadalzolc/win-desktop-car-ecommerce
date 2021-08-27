Public Class FrmProductsDialog

#Region " Properties "

    Private PVT_Infos As New Dictionary(Of String, String)
    Public Property Infos() As Dictionary(Of String, String)
        Get
            Return PVT_Infos
        End Get
        Set(ByVal value As Dictionary(Of String, String))
            PVT_Infos = value
        End Set
    End Property

    Private IsUpdate As Boolean = False

    Private DT_Car As New DataTable()
    Private DT_Color As New DataTable()

#End Region

#Region " Load - Data "


    Sub LoadCombo()
        DT_Car = DB.ToData("SELECT * FROM Cars ORDER BY Name ASC")
        DT_Color = DB.ToData("SELECT * FROM Colors ORDER BY Name ASC")

        Filler.Load(CboCar, DT_Car, "Name", "ID")
        Filler.Load(CboColor, DT_Color, "Name", "ID")
    End Sub

    Sub LoadInfo()
        IsUpdate = True

        Text = String.Format("{0}-{1}", Convert.ToInt32(Infos.Item("ID")).ToString("D8"), Infos.Item("Name"))

        TxtProductNo.Text = String.Format("{0,8}", Convert.ToInt32(Infos.Item("ID")).ToString("D8"))
        TxtProductName.Text = Infos.Item("Name")
        TxtPrice.Text = Infos.Item("Price")
        TxtStock.Text = Infos.Item("Stock")

        CboCar.SelectedValue = Infos.Item("Car_ID")
        CboColor.SelectedValue = Infos.Item("Color_ID")

        ChkVisible.Checked = Convert.ToBoolean(Infos.Item("Visible"))
    End Sub

#End Region

#Region " Events - Form "

    Private Sub FrmProductsDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCombo()
        If Not Infos.Count.Equals(0) Then LoadInfo()
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        DialogResult = DialogResult.OK
        Close()
    End Sub

#End Region

#Region " Events  - Button "

#End Region

End Class