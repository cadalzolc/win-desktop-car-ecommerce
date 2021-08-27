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
        Me.MenuHeader = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintenanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MnuCars = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuFooter = New System.Windows.Forms.StatusStrip()
        Me.MnuEncoder = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TabBody = New System.Windows.Forms.TabControl()
        Me.TabDashboard = New System.Windows.Forms.TabPage()
        Me.BtnDashboard = New System.Windows.Forms.Button()
        Me.PnlLeft = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnCustomers = New System.Windows.Forms.Button()
        Me.BtnProducts = New System.Windows.Forms.Button()
        Me.BtnPayments = New System.Windows.Forms.Button()
        Me.MnuStamp = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TmrStamp = New System.Windows.Forms.Timer(Me.components)
        Me.BtnOrders = New System.Windows.Forms.Button()
        Me.PnlBody = New System.Windows.Forms.Panel()
        Me.MenuHeader.SuspendLayout()
        Me.MenuFooter.SuspendLayout()
        Me.TabBody.SuspendLayout()
        Me.PnlLeft.SuspendLayout()
        Me.PnlBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuHeader
        '
        Me.MenuHeader.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.MaintenanceToolStripMenuItem})
        Me.MenuHeader.Location = New System.Drawing.Point(0, 0)
        Me.MenuHeader.Name = "MenuHeader"
        Me.MenuHeader.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuHeader.Size = New System.Drawing.Size(915, 24)
        Me.MenuHeader.TabIndex = 0
        Me.MenuHeader.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'MenuExit
        '
        Me.MenuExit.Name = "MenuExit"
        Me.MenuExit.Size = New System.Drawing.Size(180, 22)
        Me.MenuExit.Text = "&Exit"
        '
        'MaintenanceToolStripMenuItem
        '
        Me.MaintenanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuCars})
        Me.MaintenanceToolStripMenuItem.Name = "MaintenanceToolStripMenuItem"
        Me.MaintenanceToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.MaintenanceToolStripMenuItem.Text = "&Maintenance"
        '
        'MnuCars
        '
        Me.MnuCars.Name = "MnuCars"
        Me.MnuCars.Size = New System.Drawing.Size(180, 22)
        Me.MnuCars.Text = "&Cars"
        '
        'MenuFooter
        '
        Me.MenuFooter.AutoSize = False
        Me.MenuFooter.BackColor = System.Drawing.Color.Gainsboro
        Me.MenuFooter.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MnuEncoder, Me.ToolStripStatusLabel1, Me.MnuStamp})
        Me.MenuFooter.Location = New System.Drawing.Point(0, 518)
        Me.MenuFooter.Name = "MenuFooter"
        Me.MenuFooter.Padding = New System.Windows.Forms.Padding(1, 0, 16, 0)
        Me.MenuFooter.ShowItemToolTips = True
        Me.MenuFooter.Size = New System.Drawing.Size(915, 32)
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
        'TabBody
        '
        Me.TabBody.Controls.Add(Me.TabDashboard)
        Me.TabBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabBody.Location = New System.Drawing.Point(2, 2)
        Me.TabBody.Name = "TabBody"
        Me.TabBody.SelectedIndex = 0
        Me.TabBody.Size = New System.Drawing.Size(732, 490)
        Me.TabBody.TabIndex = 3
        '
        'TabDashboard
        '
        Me.TabDashboard.Location = New System.Drawing.Point(4, 23)
        Me.TabDashboard.Name = "TabDashboard"
        Me.TabDashboard.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDashboard.Size = New System.Drawing.Size(724, 463)
        Me.TabDashboard.TabIndex = 0
        Me.TabDashboard.Text = "Dashboard"
        Me.TabDashboard.UseVisualStyleBackColor = True
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
        Me.PnlLeft.Location = New System.Drawing.Point(0, 24)
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
        Me.PnlLeft.Size = New System.Drawing.Size(179, 494)
        Me.PnlLeft.TabIndex = 4
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
        'MnuStamp
        '
        Me.MnuStamp.Name = "MnuStamp"
        Me.MnuStamp.Size = New System.Drawing.Size(90, 27)
        Me.MnuStamp.Text = "Current Stamp: "
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(50, 27)
        '
        'TmrStamp
        '
        Me.TmrStamp.Enabled = True
        Me.TmrStamp.Interval = 500
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
        'PnlBody
        '
        Me.PnlBody.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlBody.Controls.Add(Me.TabBody)
        Me.PnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlBody.Location = New System.Drawing.Point(179, 24)
        Me.PnlBody.Name = "PnlBody"
        Me.PnlBody.Padding = New System.Windows.Forms.Padding(2)
        Me.PnlBody.Size = New System.Drawing.Size(736, 494)
        Me.PnlBody.TabIndex = 5
        '
        'FrmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(915, 550)
        Me.Controls.Add(Me.PnlBody)
        Me.Controls.Add(Me.PnlLeft)
        Me.Controls.Add(Me.MenuFooter)
        Me.Controls.Add(Me.MenuHeader)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuHeader
        Me.Name = "FrmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.MenuHeader.ResumeLayout(False)
        Me.MenuHeader.PerformLayout()
        Me.MenuFooter.ResumeLayout(False)
        Me.MenuFooter.PerformLayout()
        Me.TabBody.ResumeLayout(False)
        Me.PnlLeft.ResumeLayout(False)
        Me.PnlBody.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuHeader As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaintenanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuFooter As StatusStrip
    Friend WithEvents TabBody As TabControl
    Friend WithEvents TabDashboard As TabPage
    Friend WithEvents BtnDashboard As Button
    Friend WithEvents PnlLeft As TableLayoutPanel
    Friend WithEvents BtnCustomers As Button
    Friend WithEvents BtnProducts As Button
    Friend WithEvents BtnPayments As Button
    Friend WithEvents MenuExit As ToolStripMenuItem
    Friend WithEvents MnuCars As ToolStripMenuItem
    Friend WithEvents MnuEncoder As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents MnuStamp As ToolStripStatusLabel
    Friend WithEvents TmrStamp As Timer
    Friend WithEvents BtnOrders As Button
    Friend WithEvents PnlBody As Panel
End Class
