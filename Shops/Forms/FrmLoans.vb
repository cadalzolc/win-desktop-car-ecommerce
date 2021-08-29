Imports System.Text

Public Class FrmLoans

#Region " Load Grid "

    Sub LoadGrid()
        Dim Sb_Query As New StringBuilder()

        Sb_Query.Append(String.Format("SELECT * FROM VW_Loans WHERE Customer_ID = {0} ORDER BY Trans_Date DESC", Session.CurrentUser.Customer_ID))

        Dim DT = DB.ToData(Sb_Query.ToString())

        GrdList.DataSource = Nothing
        GrdList.DataSource = DT

        For Each Col As DataGridViewColumn In GrdList.Columns
            Select Case Col.Name.ToUpper()
                Case "PRODUCT"
                    Col.Visible = True
                    Col.Width = 150
                Case "YEARS", "MONTHS"
                    Col.Visible = True
                    Col.Width = 60
                    Col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Case "AMORTIZATION", "TOTAL", "PAYMENT", "BALANCE"
                    Col.Visible = True
                    Col.Width = 110
                    Col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                    Col.DefaultCellStyle.Format = "P #, ##0.00"
                Case "TRANS_DATE"
                    Col.Visible = True
                    Col.Width = 130
                    Col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                Case "MONTHS_REMAINING"
                    Col.Visible = True
                    Col.Width = 80
                    Col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    Col.HeaderText = "Remaining"
                Case Else
                    Col.Visible = False
            End Select
            Col.HeaderText = Col.HeaderText.Replace("_", " ").ToUpper()
        Next
    End Sub

#End Region

#Region " Events - Form "

    Private Sub FrmLoans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadGrid()
    End Sub

#End Region

#Region " Events - Button "

    Private Sub BtnPay_Click(sender As Object, e As EventArgs) Handles BtnPay.Click
        LoadGrid()
    End Sub

#End Region

End Class