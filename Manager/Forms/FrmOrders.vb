Imports System.Text

Public Class FrmOrders

    Dim DT_Prod As New DataTable
    Dim SL_Item As New Dictionary(Of String, String)

#Region " Load Grid "

    Sub LoadGrid(Optional Search As String = "")
        Dim Sb_Query As New StringBuilder()

        Sb_Query.Append(String.Format("SELECT * FROM VW_Orders ORDER BY Trans_Date DESC"))

        Dim DT = DB.ToData(Sb_Query.ToString())

        GrdList.DataSource = Nothing
        GrdList.DataSource = DT

        For Each Col As DataGridViewColumn In GrdList.Columns
            Select Case Col.Name.ToUpper()
                Case "NAME"
                    Col.Visible = True
                    Col.Width = 150
                    Col.HeaderText = "Product"
                Case "NAME", "FIRST_NAME", "LAST_NAME"
                    Col.Visible = True
                    Col.Width = 150
                Case "PAYMENT_MODE"
                    Col.Visible = True
                    Col.Width = 60
                    Col.HeaderText = "Mode"
                    Col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Case "AMOUNT"
                    Col.Visible = True
                    Col.Width = 120
                    Col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    Col.DefaultCellStyle.Format = "P #, ##0.00"
                Case "AMOUNT_PAID"
                    Col.Visible = True
                    Col.Width = 120
                    Col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    Col.DefaultCellStyle.Format = "P #, ##0.00"
                    Col.HeaderText = "Paid"
                Case "TRANS_DATE"
                    Col.Visible = True
                    Col.Width = 135
                    Col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Case "DELIVERED"
                    Col.Visible = True
                    Col.Width = 70
                    Col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Case Else
                    Col.Visible = False
            End Select
            Col.HeaderText = Col.HeaderText.Replace("_", " ").ToUpper()
        Next

        If Not IsNothing(DT) Then
            LblRecords.Text = String.Format("Records Found: {0}", DT.Rows.Count())
            LblTotal.Text = String.Format("Total Sales: {0:P #, ##0.00}", DT.AsEnumerable.Sum(Function(Row) Row("AMOUNT")))
        End If

        Application.DoEvents()
    End Sub

#End Region

#Region " Events - Form "

    Private Sub FrmOrders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub

#End Region

#Region " Events - Button "

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles BtnSearch.Click
        LoadGrid(TxtSearch.Text)
    End Sub


#End Region

#Region " Events - Grid "

    Private Sub GrdList_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles GrdList.CellMouseClick

    End Sub

#End Region

End Class