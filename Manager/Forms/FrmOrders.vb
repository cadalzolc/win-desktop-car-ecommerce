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

    Private Sub BtnShipment_Click(sender As Object, e As EventArgs) Handles BtnShipment.Click
        If SL_Item.Count().Equals(0) Then
            Toast.Required("Please select order")
            Exit Sub
        End If

        Dim Frm As New FrmOrdersDialog With {
            .Shipments = SL_Item
        }
        If Not Frm.ShowDialog() = DialogResult.OK Then Exit Sub

        BtnShipment.Visible = False
        LoadGrid()

    End Sub


#End Region

#Region " Events - Grid "

    Private Sub GrdList_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles GrdList.CellMouseClick
        SL_Item.Clear()
        BtnShipment.Visible = False

        If e.RowIndex < 0 Then Exit Sub

        Dim IsDelivered = Convert.ToBoolean(GrdList.Rows(e.RowIndex).Cells("Delivered").Value)

        If IsDelivered.Equals(True) Then Exit Sub

        SL_Item.Add("ID", GrdList.Rows(e.RowIndex).Cells("ID").Value)
        SL_Item.Add("Order_No", GrdList.Rows(e.RowIndex).Cells("Order_No").Value)
        SL_Item.Add("Trans_Date", GrdList.Rows(e.RowIndex).Cells("Trans_Date").Value)
        SL_Item.Add("Product", GrdList.Rows(e.RowIndex).Cells("Name").Value)
        SL_Item.Add("Customer", String.Format("{0} {1}", GrdList.Rows(e.RowIndex).Cells("First_Name").Value, GrdList.Rows(e.RowIndex).Cells("Last_Name").Value))
        SL_Item.Add("Address", GrdList.Rows(e.RowIndex).Cells("Address").Value)
        SL_Item.Add("City", GrdList.Rows(e.RowIndex).Cells("City").Value)
        SL_Item.Add("Province", GrdList.Rows(e.RowIndex).Cells("State").Value)
        SL_Item.Add("Country", GrdList.Rows(e.RowIndex).Cells("Country").Value)
        SL_Item.Add("Zip_Code", GrdList.Rows(e.RowIndex).Cells("Zip_Code").Value)
        SL_Item.Add("Shipment_ID", GrdList.Rows(e.RowIndex).Cells("Shipment_ID").Value)

        BtnShipment.Visible = True
    End Sub

#End Region

End Class