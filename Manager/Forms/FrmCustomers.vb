Public Class FrmCustomers

    Dim DT_Prod As New DataTable
    Dim SL_Item As New Dictionary(Of String, String)

#Region " Load Grid "

    Sub LoadGrid(Optional Search As String = "")
        SL_Item.Clear()

        DT_Prod = DB.ToData("SELECT * FROM Customers")
        GrdList.DataSource = Nothing
        GrdList.DataSource = DT_Prod

        For Each Col As DataGridViewColumn In GrdList.Columns
            Select Case Col.Name.ToUpper()
                Case "FIRST_NAME", "LAST_NAME", "MIDDLE_NAME"
                    Col.Visible = True
                    Col.Width = 110
                Case "GENDER"
                    Col.Visible = True
                    Col.Width = 65
                    Col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Case "EMAIL"
                    Col.Visible = True
                    Col.Width = 200
                Case "CONTACT_NO"
                    Col.Visible = True
                    Col.Width = 130
                Case Else
                    Col.Visible = False
            End Select
            Col.HeaderText = Col.HeaderText.Replace("_", " ").ToUpper()
        Next

        Application.DoEvents()
    End Sub

#End Region

#Region " Events - Form "

    Private Sub FrmCustomers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub

#End Region

#Region " Events - Button "

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles BtnUpdate.Click

    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        LoadGrid(TxtSearch.Text)
    End Sub

#End Region

#Region " Events - Grid "

    Private Sub GrdList_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles GrdList.CellMouseClick

    End Sub

#End Region

End Class