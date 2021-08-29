<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmShop
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmShop))
        Me.PnlBody = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnLoans = New System.Windows.Forms.Button()
        Me.BtnLogout = New System.Windows.Forms.Button()
        Me.BtnOrder = New System.Windows.Forms.Button()
        Me.BtnAccount = New System.Windows.Forms.Button()
        Me.LblUser = New System.Windows.Forms.Label()
        Me.PnlTop = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.PnlTop.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBody
        '
        Me.PnlBody.AutoScroll = True
        Me.PnlBody.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlBody.Location = New System.Drawing.Point(0, 42)
        Me.PnlBody.Name = "PnlBody"
        Me.PnlBody.Padding = New System.Windows.Forms.Padding(3)
        Me.PnlBody.Size = New System.Drawing.Size(784, 423)
        Me.PnlBody.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.BtnLoans)
        Me.Panel1.Controls.Add(Me.BtnLogout)
        Me.Panel1.Controls.Add(Me.BtnOrder)
        Me.Panel1.Controls.Add(Me.BtnAccount)
        Me.Panel1.Controls.Add(Me.LblUser)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 465)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(784, 46)
        Me.Panel1.TabIndex = 0
        '
        'BtnLoans
        '
        Me.BtnLoans.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLoans.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLoans.Location = New System.Drawing.Point(352, 5)
        Me.BtnLoans.Name = "BtnLoans"
        Me.BtnLoans.Size = New System.Drawing.Size(106, 35)
        Me.BtnLoans.TabIndex = 0
        Me.BtnLoans.Text = "Loans"
        Me.BtnLoans.UseVisualStyleBackColor = True
        '
        'BtnLogout
        '
        Me.BtnLogout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogout.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogout.Location = New System.Drawing.Point(673, 5)
        Me.BtnLogout.Name = "BtnLogout"
        Me.BtnLogout.Size = New System.Drawing.Size(106, 35)
        Me.BtnLogout.TabIndex = 3
        Me.BtnLogout.Text = "Logout"
        Me.BtnLogout.UseVisualStyleBackColor = True
        '
        'BtnOrder
        '
        Me.BtnOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOrder.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOrder.Location = New System.Drawing.Point(459, 5)
        Me.BtnOrder.Name = "BtnOrder"
        Me.BtnOrder.Size = New System.Drawing.Size(106, 35)
        Me.BtnOrder.TabIndex = 1
        Me.BtnOrder.Text = "Orders History"
        Me.BtnOrder.UseVisualStyleBackColor = True
        '
        'BtnAccount
        '
        Me.BtnAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAccount.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAccount.Location = New System.Drawing.Point(566, 5)
        Me.BtnAccount.Name = "BtnAccount"
        Me.BtnAccount.Size = New System.Drawing.Size(106, 37)
        Me.BtnAccount.TabIndex = 2
        Me.BtnAccount.Text = "Account"
        Me.BtnAccount.UseVisualStyleBackColor = True
        '
        'LblUser
        '
        Me.LblUser.Dock = System.Windows.Forms.DockStyle.Left
        Me.LblUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUser.Location = New System.Drawing.Point(0, 0)
        Me.LblUser.Name = "LblUser"
        Me.LblUser.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.LblUser.Size = New System.Drawing.Size(308, 46)
        Me.LblUser.TabIndex = 0
        Me.LblUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlTop
        '
        Me.PnlTop.BackColor = System.Drawing.Color.Gainsboro
        Me.PnlTop.Controls.Add(Me.Label3)
        Me.PnlTop.Controls.Add(Me.Panel2)
        Me.PnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlTop.Location = New System.Drawing.Point(0, 0)
        Me.PnlTop.Name = "PnlTop"
        Me.PnlTop.Size = New System.Drawing.Size(784, 42)
        Me.PnlTop.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.Label3.Size = New System.Drawing.Size(259, 42)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Car Listing"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnSearch)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(375, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(409, 42)
        Me.Panel2.TabIndex = 2
        '
        'BtnSearch
        '
        Me.BtnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.Location = New System.Drawing.Point(300, 5)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(105, 33)
        Me.BtnSearch.TabIndex = 1
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(5, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(291, 28)
        Me.TextBox1.TabIndex = 0
        '
        'FrmShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 511)
        Me.Controls.Add(Me.PnlBody)
        Me.Controls.Add(Me.PnlTop)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 550)
        Me.Name = "FrmShop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Online Car Dealer"
        Me.Panel1.ResumeLayout(False)
        Me.PnlTop.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlBody As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PnlTop As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnLoans As Button
    Friend WithEvents BtnLogout As Button
    Friend WithEvents BtnOrder As Button
    Friend WithEvents BtnAccount As Button
    Friend WithEvents LblUser As Label
End Class
