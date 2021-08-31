Public Class FrmDashboard

#Region " Properties "

#End Region

#Region " Load Data "

    Sub LoadSummary()
        Dim Row = DB.ToRow("SELECT * FROM VW_Summary")
        If IsNothing(Row) Then Exit Sub
        LblProduct.Text = Row("Products")
        LblStock.Text = Row("Stock")
        LblSold.Text = Row("Sold")
        LblCustomer.Text = Row("Customer")
        LblSales.Text = Row("Sales").ToString().ToDouble().ToString("P #, ##0.00")
        LblOrder.Text = Row("Sold")
    End Sub

#End Region

#Region " Events - Form "

    Private Sub FrmDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MnuEncoder.Text = String.Format("Logged In User: {0}", Session.CurrentUser.Username)
        LoadSummary()
    End Sub

    Private Sub FrmDashboard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Toast.Question("Are you sure you want to quit application?") = DialogResult.No Then e.Cancel = True
    End Sub

#End Region

#Region " Events - Timer"

    Private Sub TmrStamp_Tick(sender As Object, e As EventArgs) Handles TmrStamp.Tick
        MnuStamp.Text = String.Format("Current Stamp: {0}", Date.Now.ToString("MMM dd, yyyy hh:mm:ss tt"))
    End Sub

#End Region

#Region " Events - Menu "

    Private Sub MenuExit_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub MnuCars_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

#End Region

#Region " Events - Tab "

    Private Sub TabBody_MouseDown(sender As Object, e As MouseEventArgs) Handles TabBody.MouseDown
        If (TabBody.SelectedIndex <= 0) Then Exit Sub
        Dim Rect As Rectangle = TabBody.GetTabRect(TabBody.SelectedIndex)
        Dim TabClose As Rectangle = New Rectangle(Rect.Right - 15, Rect.Top + 4, 9, 7)
        If TabClose.Contains(e.Location) Then TabBody.TabPages.RemoveAt(TabBody.SelectedIndex)
    End Sub

#End Region

#Region " Events - Button "

    Private Sub BtnDashboard_Click(sender As Object, e As EventArgs) Handles BtnDashboard.Click
        TabBody.SelectedIndex = 0
    End Sub

    Private Sub BtnCustomers_Click(sender As Object, e As EventArgs) Handles BtnCustomers.Click
        TabShow("Customers   x", New FrmCustomers())
    End Sub

    Private Sub BtnProducts_Click(sender As Object, e As EventArgs) Handles BtnProducts.Click
        TabShow("Products   x", New FrmProducts())
    End Sub

    Private Sub BtnOrders_Click(sender As Object, e As EventArgs) Handles BtnOrders.Click
        TabShow("Orders   x", New FrmOrders())
    End Sub

    Private Sub BtnPayments_Click(sender As Object, e As EventArgs) Handles BtnPayments.Click
        TabShow("Payments   x", New FrmPayments())
    End Sub

#End Region

#Region " Method "

    Sub TabShow(Text As String, Frm As Form)
        Dim Tab As New TabPage(Text)

        Frm.TopMost = False
        Frm.TopLevel = False
        Frm.Visible = True
        Frm.Parent = Tab
        Frm.Location = New Point(0, 0)
        Frm.FormBorderStyle = FormBorderStyle.None
        Frm.Dock = DockStyle.Fill

        Tab.Controls.Add(Frm)

        TabBody.TabPages.Add(Tab)
        TabBody.SelectedTab = Tab
    End Sub

#End Region

End Class
