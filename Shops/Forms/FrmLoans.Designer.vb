<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLoans
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLoans))
        Me.PnlGrid = New System.Windows.Forms.Panel()
        Me.GrdList = New System.Windows.Forms.DataGridView()
        Me.BtnPay = New System.Windows.Forms.Button()
        Me.PnlGrid.SuspendLayout()
        CType(Me.GrdList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PnlGrid
        '
        Me.PnlGrid.BackColor = System.Drawing.Color.Silver
        Me.PnlGrid.Controls.Add(Me.GrdList)
        Me.PnlGrid.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlGrid.Location = New System.Drawing.Point(0, 45)
        Me.PnlGrid.Name = "PnlGrid"
        Me.PnlGrid.Padding = New System.Windows.Forms.Padding(1)
        Me.PnlGrid.Size = New System.Drawing.Size(784, 366)
        Me.PnlGrid.TabIndex = 0
        '
        'GrdList
        '
        Me.GrdList.AllowUserToAddRows = False
        Me.GrdList.AllowUserToDeleteRows = False
        Me.GrdList.AllowUserToResizeRows = False
        Me.GrdList.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.GrdList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GrdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.GrdList.DefaultCellStyle = DataGridViewCellStyle1
        Me.GrdList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdList.Location = New System.Drawing.Point(1, 1)
        Me.GrdList.MultiSelect = False
        Me.GrdList.Name = "GrdList"
        Me.GrdList.ReadOnly = True
        Me.GrdList.RowHeadersWidth = 30
        Me.GrdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrdList.Size = New System.Drawing.Size(782, 364)
        Me.GrdList.TabIndex = 8
        '
        'BtnPay
        '
        Me.BtnPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPay.Location = New System.Drawing.Point(3, 5)
        Me.BtnPay.Name = "BtnPay"
        Me.BtnPay.Size = New System.Drawing.Size(115, 35)
        Me.BtnPay.TabIndex = 1
        Me.BtnPay.Text = "Make Payment"
        Me.BtnPay.UseVisualStyleBackColor = True
        '
        'FrmLoans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.BtnPay)
        Me.Controls.Add(Me.PnlGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLoans"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Loans"
        Me.PnlGrid.ResumeLayout(False)
        CType(Me.GrdList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlGrid As Panel
    Friend WithEvents GrdList As DataGridView
    Friend WithEvents BtnPay As Button
End Class
