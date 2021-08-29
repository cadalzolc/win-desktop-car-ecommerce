<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmOrderHistory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOrderHistory))
        Me.GrdHistory = New System.Windows.Forms.DataGridView()
        Me.BtnApply = New System.Windows.Forms.Button()
        Me.DtpFrom = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DtpTo = New System.Windows.Forms.DateTimePicker()
        CType(Me.GrdHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrdHistory
        '
        Me.GrdHistory.AllowUserToAddRows = False
        Me.GrdHistory.AllowUserToDeleteRows = False
        Me.GrdHistory.AllowUserToResizeRows = False
        Me.GrdHistory.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.GrdHistory.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GrdHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdHistory.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GrdHistory.Location = New System.Drawing.Point(0, 41)
        Me.GrdHistory.MultiSelect = False
        Me.GrdHistory.Name = "GrdHistory"
        Me.GrdHistory.ReadOnly = True
        Me.GrdHistory.RowHeadersWidth = 30
        Me.GrdHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrdHistory.Size = New System.Drawing.Size(784, 370)
        Me.GrdHistory.TabIndex = 7
        '
        'BtnApply
        '
        Me.BtnApply.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnApply.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnApply.Location = New System.Drawing.Point(685, 3)
        Me.BtnApply.Name = "BtnApply"
        Me.BtnApply.Size = New System.Drawing.Size(94, 32)
        Me.BtnApply.TabIndex = 9
        Me.BtnApply.Text = "Apply"
        Me.BtnApply.UseVisualStyleBackColor = True
        '
        'DtpFrom
        '
        Me.DtpFrom.CalendarFont = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFrom.CustomFormat = "yyyy-MM-dd"
        Me.DtpFrom.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpFrom.Location = New System.Drawing.Point(329, 5)
        Me.DtpFrom.Name = "DtpFrom"
        Me.DtpFrom.ShowCheckBox = True
        Me.DtpFrom.Size = New System.Drawing.Size(152, 27)
        Me.DtpFrom.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(490, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 19)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "TO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(272, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "FROM"
        '
        'DtpTo
        '
        Me.DtpTo.CalendarFont = New System.Drawing.Font("Tahoma", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpTo.CustomFormat = "yyyy-MM-dd"
        Me.DtpTo.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DtpTo.Location = New System.Drawing.Point(527, 5)
        Me.DtpTo.Name = "DtpTo"
        Me.DtpTo.ShowCheckBox = True
        Me.DtpTo.Size = New System.Drawing.Size(152, 27)
        Me.DtpTo.TabIndex = 13
        '
        'FrmOrderHistory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.DtpTo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DtpFrom)
        Me.Controls.Add(Me.BtnApply)
        Me.Controls.Add(Me.GrdHistory)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOrderHistory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order History"
        CType(Me.GrdHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrdHistory As DataGridView
    Friend WithEvents BtnApply As Button
    Friend WithEvents DtpFrom As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DtpTo As DateTimePicker
End Class
