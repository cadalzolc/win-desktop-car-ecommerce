<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDashboard
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDashboard))
        Me.MenuFooter = New System.Windows.Forms.StatusStrip()
        Me.MnuEncoder = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MnuStamp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabBody = New System.Windows.Forms.TabControl()
        Me.TabDashboard = New System.Windows.Forms.TabPage()
        Me.LblStock = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblOrder = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LblCustomer = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblSales = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LblSold = New System.Windows.Forms.Label()
        Me.LblProduct = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnDashboard = New System.Windows.Forms.Button()
        Me.PnlLeft = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnPayments = New System.Windows.Forms.Button()
        Me.BtnCustomers = New System.Windows.Forms.Button()
        Me.BtnOrders = New System.Windows.Forms.Button()
        Me.BtnProducts = New System.Windows.Forms.Button()
        Me.TmrStamp = New System.Windows.Forms.Timer(Me.components)
        Me.PnlBody = New System.Windows.Forms.Panel()
        Me.MenuFooter.SuspendLayout()
        Me.TabBody.SuspendLayout()
        Me.TabDashboard.SuspendLayout()
        Me.PnlLeft.SuspendLayout()
        Me.PnlBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuFooter
        '
        Me.MenuFooter.AutoSize = False
        Me.MenuFooter.BackColor = System.Drawing.Color.Gainsboro
        Me.MenuFooter.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuEncoder, Me.ToolStripStatusLabel1, Me.MnuStamp})
        Me.MenuFooter.Location = New System.Drawing.Point(0, 479)
        Me.MenuFooter.Name = "MenuFooter"
        Me.MenuFooter.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.MenuFooter.ShowItemToolTips = True
        Me.MenuFooter.Size = New System.Drawing.Size(784, 32)
        Me.MenuFooter.SizingGrip = False
        Me.MenuFooter.Stretch = False
        Me.MenuFooter.TabIndex = 1
        '
        'MnuEncoder
        '
        Me.MnuEncoder.Name = "MnuEncoder"
        Me.MnuEncoder.Size = New System.Drawing.Size(89, 27)
        Me.MnuEncoder.Text = "Logged In User:"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(50, 27)
        '
        'MnuStamp
        '
        Me.MnuStamp.Name = "MnuStamp"
        Me.MnuStamp.Size = New System.Drawing.Size(90, 27)
        Me.MnuStamp.Text = "Current Stamp: "
        '
        'TabBody
        '
        Me.TabBody.Controls.Add(Me.TabDashboard)
        Me.TabBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabBody.Location = New System.Drawing.Point(2, 2)
        Me.TabBody.Name = "TabBody"
        Me.TabBody.SelectedIndex = 0
        Me.TabBody.Size = New System.Drawing.Size(601, 475)
        Me.TabBody.TabIndex = 3
        '
        'TabDashboard
        '
        Me.TabDashboard.Controls.Add(Me.LblStock)
        Me.TabDashboard.Controls.Add(Me.Label13)
        Me.TabDashboard.Controls.Add(Me.Label11)
        Me.TabDashboard.Controls.Add(Me.LblOrder)
        Me.TabDashboard.Controls.Add(Me.Label10)
        Me.TabDashboard.Controls.Add(Me.LblCustomer)
        Me.TabDashboard.Controls.Add(Me.Label7)
        Me.TabDashboard.Controls.Add(Me.LblSales)
        Me.TabDashboard.Controls.Add(Me.Label6)
        Me.TabDashboard.Controls.Add(Me.LblSold)
        Me.TabDashboard.Controls.Add(Me.LblProduct)
        Me.TabDashboard.Controls.Add(Me.Label2)
        Me.TabDashboard.Controls.Add(Me.Label1)
        Me.TabDashboard.Location = New System.Drawing.Point(4, 23)
        Me.TabDashboard.Name = "TabDashboard"
        Me.TabDashboard.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDashboard.Size = New System.Drawing.Size(593, 448)
        Me.TabDashboard.TabIndex = 0
        Me.TabDashboard.Text = "Dashboard"
        Me.TabDashboard.UseVisualStyleBackColor = True
        '
        'LblStock
        '
        Me.LblStock.AutoSize = True
        Me.LblStock.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStock.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblStock.Location = New System.Drawing.Point(159, 82)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(20, 23)
        Me.LblStock.TabIndex = 12
        Me.LblStock.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(17, 82)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 23)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "STOCK  :"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Firebrick
        Me.Label11.Location = New System.Drawing.Point(17, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(183, 23)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "REPORTS SUMMARY"
        '
        'LblOrder
        '
        Me.LblOrder.AutoSize = True
        Me.LblOrder.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblOrder.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblOrder.Location = New System.Drawing.Point(430, 80)
        Me.LblOrder.Name = "LblOrder"
        Me.LblOrder.Size = New System.Drawing.Size(20, 23)
        Me.LblOrder.TabIndex = 9
        Me.LblOrder.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(289, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 23)
        Me.Label10.TabIndex = 8
        Me.Label10.Text = "ORDERS :"
        '
        'LblCustomer
        '
        Me.LblCustomer.AutoSize = True
        Me.LblCustomer.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCustomer.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblCustomer.Location = New System.Drawing.Point(430, 54)
        Me.LblCustomer.Name = "LblCustomer"
        Me.LblCustomer.Size = New System.Drawing.Size(20, 23)
        Me.LblCustomer.TabIndex = 7
        Me.LblCustomer.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(289, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "CUSTOMERS :"
        '
        'LblSales
        '
        Me.LblSales.AutoSize = True
        Me.LblSales.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSales.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblSales.Location = New System.Drawing.Point(158, 132)
        Me.LblSales.Name = "LblSales"
        Me.LblSales.Size = New System.Drawing.Size(20, 23)
        Me.LblSales.TabIndex = 5
        Me.LblSales.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(17, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 23)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "SALES :"
        '
        'LblSold
        '
        Me.LblSold.AutoSize = True
        Me.LblSold.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSold.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblSold.Location = New System.Drawing.Point(159, 107)
        Me.LblSold.Name = "LblSold"
        Me.LblSold.Size = New System.Drawing.Size(20, 23)
        Me.LblSold.TabIndex = 3
        Me.LblSold.Text = "0"
        '
        'LblProduct
        '
        Me.LblProduct.AutoSize = True
        Me.LblProduct.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProduct.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.LblProduct.Location = New System.Drawing.Point(159, 54)
        Me.LblProduct.Name = "LblProduct"
        Me.LblProduct.Size = New System.Drawing.Size(20, 23)
        Me.LblProduct.TabIndex = 2
        Me.LblProduct.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SOLD :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PRODUCTS :"
        '
        'BtnDashboard
        '
        Me.BtnDashboard.BackColor = System.Drawing.Color.IndianRed
        Me.BtnDashboard.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDashboard.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.BtnDashboard.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral
        Me.BtnDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.BtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDashboard.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDashboard.ForeColor = System.Drawing.Color.White
        Me.BtnDashboard.Location = New System.Drawing.Point(9, 8)
        Me.BtnDashboard.Name = "BtnDashboard"
        Me.BtnDashboard.Padding = New System.Windows.Forms.Padding(5)
        Me.BtnDashboard.Size = New System.Drawing.Size(161, 44)
        Me.BtnDashboard.TabIndex = 0
        Me.BtnDashboard.Text = "Dashboard"
        Me.BtnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnDashboard.UseVisualStyleBackColor = False
        '
        'PnlLeft
        '
        Me.PnlLeft.BackColor = System.Drawing.Color.Firebrick
        Me.PnlLeft.ColumnCount = 1
        Me.PnlLeft.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.PnlLeft.Controls.Add(Me.BtnDashboard, 0, 0)
        Me.PnlLeft.Controls.Add(Me.BtnPayments, 0, 10)
        Me.PnlLeft.Controls.Add(Me.BtnCustomers, 0, 1)
        Me.PnlLeft.Controls.Add(Me.BtnOrders, 0, 9)
        Me.PnlLeft.Controls.Add(Me.BtnProducts, 0, 2)
        Me.PnlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnlLeft.Location = New System.Drawing.Point(0, 0)
        Me.PnlLeft.Name = "PnlLeft"
        Me.PnlLeft.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.PnlLeft.RowCount = 11
        Me.PnlLeft.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PnlLeft.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PnlLeft.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PnlLeft.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PnlLeft.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PnlLeft.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PnlLeft.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PnlLeft.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PnlLeft.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PnlLeft.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.PnlLeft.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52.0!))
        Me.PnlLeft.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.PnlLeft.Size = New System.Drawing.Size(179, 479)
        Me.PnlLeft.TabIndex = 4
        '
        'BtnPayments
        '
        Me.BtnPayments.BackColor = System.Drawing.Color.IndianRed
        Me.BtnPayments.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPayments.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.BtnPayments.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral
        Me.BtnPayments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.BtnPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPayments.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPayments.ForeColor = System.Drawing.Color.White
        Me.BtnPayments.Location = New System.Drawing.Point(9, 208)
        Me.BtnPayments.Name = "BtnPayments"
        Me.BtnPayments.Padding = New System.Windows.Forms.Padding(5)
        Me.BtnPayments.Size = New System.Drawing.Size(161, 44)
        Me.BtnPayments.TabIndex = 1
        Me.BtnPayments.Text = "Payments"
        Me.BtnPayments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnPayments.UseVisualStyleBackColor = False
        '
        'BtnCustomers
        '
        Me.BtnCustomers.BackColor = System.Drawing.Color.IndianRed
        Me.BtnCustomers.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCustomers.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.BtnCustomers.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral
        Me.BtnCustomers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.BtnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCustomers.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCustomers.ForeColor = System.Drawing.Color.White
        Me.BtnCustomers.Location = New System.Drawing.Point(9, 58)
        Me.BtnCustomers.Name = "BtnCustomers"
        Me.BtnCustomers.Padding = New System.Windows.Forms.Padding(5)
        Me.BtnCustomers.Size = New System.Drawing.Size(161, 44)
        Me.BtnCustomers.TabIndex = 4
        Me.BtnCustomers.Text = "Customers"
        Me.BtnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCustomers.UseVisualStyleBackColor = False
        '
        'BtnOrders
        '
        Me.BtnOrders.BackColor = System.Drawing.Color.IndianRed
        Me.BtnOrders.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOrders.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.BtnOrders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral
        Me.BtnOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.BtnOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOrders.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOrders.ForeColor = System.Drawing.Color.White
        Me.BtnOrders.Location = New System.Drawing.Point(9, 158)
        Me.BtnOrders.Name = "BtnOrders"
        Me.BtnOrders.Padding = New System.Windows.Forms.Padding(5)
        Me.BtnOrders.Size = New System.Drawing.Size(161, 44)
        Me.BtnOrders.TabIndex = 5
        Me.BtnOrders.Text = "Orders"
        Me.BtnOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnOrders.UseVisualStyleBackColor = False
        '
        'BtnProducts
        '
        Me.BtnProducts.BackColor = System.Drawing.Color.IndianRed
        Me.BtnProducts.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProducts.FlatAppearance.BorderColor = System.Drawing.Color.Firebrick
        Me.BtnProducts.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightCoral
        Me.BtnProducts.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightCoral
        Me.BtnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProducts.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProducts.ForeColor = System.Drawing.Color.White
        Me.BtnProducts.Location = New System.Drawing.Point(9, 108)
        Me.BtnProducts.Name = "BtnProducts"
        Me.BtnProducts.Padding = New System.Windows.Forms.Padding(5)
        Me.BtnProducts.Size = New System.Drawing.Size(161, 44)
        Me.BtnProducts.TabIndex = 2
        Me.BtnProducts.Text = "Products"
        Me.BtnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnProducts.UseVisualStyleBackColor = False
        '
        'TmrStamp
        '
        Me.TmrStamp.Enabled = True
        Me.TmrStamp.Interval = 500
        '
        'PnlBody
        '
        Me.PnlBody.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlBody.Controls.Add(Me.TabBody)
        Me.PnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlBody.Location = New System.Drawing.Point(179, 0)
        Me.PnlBody.Name = "PnlBody"
        Me.PnlBody.Padding = New System.Windows.Forms.Padding(2)
        Me.PnlBody.Size = New System.Drawing.Size(605, 479)
        Me.PnlBody.TabIndex = 5
        '
        'FrmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 511)
        Me.Controls.Add(Me.PnlBody)
        Me.Controls.Add(Me.PnlLeft)
        Me.Controls.Add(Me.MenuFooter)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MaximizeBox = False
        Me.Name = "FrmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.MenuFooter.ResumeLayout(False)
        Me.MenuFooter.PerformLayout()
        Me.TabBody.ResumeLayout(False)
        Me.TabDashboard.ResumeLayout(False)
        Me.TabDashboard.PerformLayout()
        Me.PnlLeft.ResumeLayout(False)
        Me.PnlBody.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuFooter As StatusStrip
    Friend WithEvents TabBody As TabControl
    Friend WithEvents TabDashboard As TabPage
    Friend WithEvents BtnDashboard As Button
    Friend WithEvents PnlLeft As TableLayoutPanel
    Friend WithEvents BtnCustomers As Button
    Friend WithEvents BtnProducts As Button
    Friend WithEvents BtnPayments As Button
    Friend WithEvents MnuEncoder As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents MnuStamp As ToolStripStatusLabel
    Friend WithEvents TmrStamp As Timer
    Friend WithEvents BtnOrders As Button
    Friend WithEvents PnlBody As Panel
    Friend WithEvents LblOrder As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LblCustomer As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LblSales As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LblSold As Label
    Friend WithEvents LblProduct As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents LblStock As Label
    Friend WithEvents Label13 As Label
End Class
