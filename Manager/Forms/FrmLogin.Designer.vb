<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnLogin
        '
        Me.BtnLogin.Location = New System.Drawing.Point(215, 149)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(87, 32)
        Me.BtnLogin.TabIndex = 2
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = True
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(109, 87)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(193, 22)
        Me.TxtUsername.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(109, 118)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(193, 22)
        Me.TxtPassword.TabIndex = 1
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "WELCOME TO MANAGEMENT"
        '
        'FrmLogin
        '
        Me.AcceptButton = Me.BtnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(333, 206)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.BtnLogin)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnLogin As Button
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents Label3 As Label
End Class
