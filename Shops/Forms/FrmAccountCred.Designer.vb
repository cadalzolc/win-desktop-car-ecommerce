<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAccountCred
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
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtPasswordNew = New System.Windows.Forms.TextBox()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.TxtPasswordConfirm = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnConfirm = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtPasswordConfirm)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.TxtPasswordNew)
        Me.GroupBox4.Controls.Add(Me.TxtUsername)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Location = New System.Drawing.Point(5, 1)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(324, 124)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Credentials"
        '
        'TxtPasswordNew
        '
        Me.TxtPasswordNew.Location = New System.Drawing.Point(127, 59)
        Me.TxtPasswordNew.MaxLength = 35
        Me.TxtPasswordNew.Name = "TxtPasswordNew"
        Me.TxtPasswordNew.Size = New System.Drawing.Size(181, 20)
        Me.TxtPasswordNew.TabIndex = 1
        Me.TxtPasswordNew.UseSystemPasswordChar = True
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(127, 30)
        Me.TxtUsername.MaxLength = 35
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.ReadOnly = True
        Me.TxtUsername.Size = New System.Drawing.Size(181, 20)
        Me.TxtUsername.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(10, 59)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(90, 13)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "New Password"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(10, 30)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(63, 13)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Username"
        '
        'TxtPasswordConfirm
        '
        Me.TxtPasswordConfirm.Location = New System.Drawing.Point(127, 85)
        Me.TxtPasswordConfirm.MaxLength = 35
        Me.TxtPasswordConfirm.Name = "TxtPasswordConfirm"
        Me.TxtPasswordConfirm.Size = New System.Drawing.Size(181, 20)
        Me.TxtPasswordConfirm.TabIndex = 5
        Me.TxtPasswordConfirm.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Confirm Password"
        '
        'BtnConfirm
        '
        Me.BtnConfirm.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirm.Location = New System.Drawing.Point(242, 131)
        Me.BtnConfirm.Name = "BtnConfirm"
        Me.BtnConfirm.Size = New System.Drawing.Size(87, 30)
        Me.BtnConfirm.TabIndex = 5
        Me.BtnConfirm.Text = "Submit"
        Me.BtnConfirm.UseVisualStyleBackColor = True
        '
        'FrmAccountCred
        '
        Me.AcceptButton = Me.BtnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 171)
        Me.Controls.Add(Me.BtnConfirm)
        Me.Controls.Add(Me.GroupBox4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAccountCred"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Credentials"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtPasswordConfirm As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtPasswordNew As TextBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents BtnConfirm As Button
End Class
