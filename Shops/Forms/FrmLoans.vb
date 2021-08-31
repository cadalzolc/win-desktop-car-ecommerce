Imports System.Text

Public Class FrmLoans

    Public Loan_Selected As New Dictionary(Of String, String)

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

        If Loan_Selected.Count().Equals(0) Then
            Toast.Required("No loan selectedtion was selected")
            Exit Sub
        End If

        Dim Frm As New FrmLoansPayment()
        Frm.Loan = Loan_Selected

        If Not Frm.ShowDialog() = DialogResult.OK Then Exit Sub

        LoadGrid()
    End Sub

#End Region

#Region " Events - Grid "

    Private Sub GrdList_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles GrdList.CellMouseClick

        Loan_Selected.Clear()

        If e.RowIndex < 0 Then Exit Sub

        Dim HasRemMonth As Integer = GrdList.Rows(e.RowIndex).Cells("Months_Remaining").Value

        If HasRemMonth.Equals(0) Then
            BtnPay.Enabled = False
            Exit Sub
        End If

        Loan_Selected.Add("ID", GrdList.Rows(e.RowIndex).Cells("ID").Value)
        Loan_Selected.Add("Order_ID", GrdList.Rows(e.RowIndex).Cells("Order_ID").Value)
        Loan_Selected.Add("Product", GrdList.Rows(e.RowIndex).Cells("Product").Value)
        Loan_Selected.Add("First_Name", GrdList.Rows(e.RowIndex).Cells("First_Name").Value)
        Loan_Selected.Add("Last_Name", GrdList.Rows(e.RowIndex).Cells("Last_Name").Value)
        Loan_Selected.Add("Amortization", GrdList.Rows(e.RowIndex).Cells("Amortization").Value)
        Loan_Selected.Add("Total", GrdList.Rows(e.RowIndex).Cells("Total").Value)
        Loan_Selected.Add("Payment", GrdList.Rows(e.RowIndex).Cells("Payment").Value)
        Loan_Selected.Add("Balance", GrdList.Rows(e.RowIndex).Cells("Balance").Value)
        Loan_Selected.Add("Months_Remaining", GrdList.Rows(e.RowIndex).Cells("Months_Remaining").Value)
        BtnPay.Enabled = True
    End Sub

#End Region

End Class