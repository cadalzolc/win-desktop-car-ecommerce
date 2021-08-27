Public Class FrmProducts

    Dim DT_Prod As New DataTable
    Dim SL_Prod As New Dictionary(Of String, String)

#Region " Load Data "

    Sub LoadProducts()

        SL_Prod.Clear()

        DT_Prod = DB.ToData("SELECT * FROM VW_Products")
        GrdList.DataSource = Nothing
        GrdList.DataSource = DT_Prod

        For Each Col As DataGridViewColumn In GrdList.Columns
            Select Case Col.Name.ToUpper()
                Case "NAME"
                    Col.Visible = True
                    Col.Width = 250
                Case "PRICE"
                    Col.Visible = True
                    Col.Width = 120
                    Col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    Col.DefaultCellStyle.Format = "P #, ##0.00"
                Case "STOCK"
                    Col.Visible = True
                    Col.Width = 50
                    Col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Case Else
                    Col.Visible = False
            End Select
            Col.HeaderText = Col.HeaderText.Replace("_", " ").ToUpper()
        Next

        Application.DoEvents()
    End Sub

#End Region

#Region " Events - Form "

    Private Sub FrmProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadProducts()
    End Sub

#End Region

#Region " Events - Grid "

    Private Sub GrdList_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles GrdList.CellMouseClick
        If e.RowIndex < 0 Then Exit Sub

        SL_Prod.Clear()

        With GrdList.Rows(e.RowIndex)
            SL_Prod.Add("ID", .Cells("ID").Value)
            SL_Prod.Add("Name", .Cells("Name").Value)
            SL_Prod.Add("Car_ID", .Cells("Car_ID").Value)
            SL_Prod.Add("Brand_ID", .Cells("Brand_ID").Value)
            SL_Prod.Add("Brand_Name", .Cells("Brand_Name").Value)
            SL_Prod.Add("Color_ID", .Cells("Color_ID").Value)
            SL_Prod.Add("Color_Name", .Cells("Color_Name").Value)
            SL_Prod.Add("Price", .Cells("Price").Value)
            SL_Prod.Add("Stock", .Cells("Stock").Value)
            SL_Prod.Add("Visible", .Cells("Visible").Value)
        End With

        BtnUpdate.Visible = True
    End Sub

    Private Sub GrdList_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrdList.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        BtnUpdate.PerformClick()
    End Sub

#End Region

#Region " Events - Button "

    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        Dim Frm As New FrmProductsDialog()

        If Not Frm.ShowDialog() = DialogResult.OK Then Exit Sub

        LoadProducts()
    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        If SL_Prod.Count.Equals(0) Then
            Toast.Required("No reord was selected")
            BtnUpdate.Visible = False
            Exit Sub
        End If

        Dim Frm As New FrmProductsDialog With {
            .Infos = SL_Prod
        }

        If Not Frm.ShowDialog() = DialogResult.OK Then Exit Sub

        LoadProducts()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        LoadProducts()
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        LoadProducts()
    End Sub

#End Region

End Class