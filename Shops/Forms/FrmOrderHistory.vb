Imports System.Text

Public Class FrmOrderHistory

#Region " Load Grid "

    Sub LoadGrid()
        Dim Sb_Query As New StringBuilder()

        Sb_Query.Append(String.Format("SELECT * FROM VW_Orders WHERE Customer_ID = {0} ORDER BY Trans_Date DESC", Session.CurrentUser.Customer_ID))

        Dim DT = DB.ToData(Sb_Query.ToString())

        GrdHistory.DataSource = Nothing
        GrdHistory.DataSource = DT

        For Each Col As DataGridViewColumn In GrdHistory.Columns
            Select Case Col.Name.ToUpper()
                Case "NAME"
                    Col.Visible = True
                    Col.Width = 150
                    Col.HeaderText = "Product"
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
    End Sub

#End Region

#Region " Events - Form "

    Private Sub FrmOrderHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub

#End Region

#Region " Events - Button "

    Private Sub BtnApply_Click(sender As Object, e As EventArgs) Handles BtnApply.Click
        LoadGrid()
    End Sub

#End Region

End Class