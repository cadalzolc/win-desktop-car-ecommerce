<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCustomers
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
        Me.PnlContent = New System.Windows.Forms.Panel()
        Me.PnllBody = New System.Windows.Forms.Panel()
        Me.GrdList = New System.Windows.Forms.DataGridView()
        Me.PnlFooter = New System.Windows.Forms.Panel()
        Me.LblRecords = New System.Windows.Forms.Label()
        Me.PnlHead = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.PnlContent.SuspendLayout()
        Me.PnllBody.SuspendLayout()
        CType(Me.GrdList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlFooter.SuspendLayout()
        Me.PnlHead.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlContent
        '
        Me.PnlContent.BackColor = System.Drawing.Color.White
        Me.PnlContent.Controls.Add(Me.PnllBody)
        Me.PnlContent.Controls.Add(Me.PnlFooter)
        Me.PnlContent.Controls.Add(Me.PnlHead)
        Me.PnlContent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlContent.Location = New System.Drawing.Point(0, 0)
        Me.PnlContent.Name = "PnlContent"
        Me.PnlContent.Padding = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.PnlContent.Size = New System.Drawing.Size(800, 550)
        Me.PnlContent.TabIndex = 3
        '
        'PnllBody
        '
        Me.PnllBody.BackColor = System.Drawing.Color.Silver
        Me.PnllBody.Controls.Add(Me.GrdList)
        Me.PnllBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnllBody.Location = New System.Drawing.Point(6, 38)
        Me.PnllBody.Name = "PnllBody"
        Me.PnllBody.Padding = New System.Windows.Forms.Padding(1)
        Me.PnllBody.Size = New System.Drawing.Size(788, 475)
        Me.PnllBody.TabIndex = 3
        '
        'GrdList
        '
        Me.GrdList.AllowUserToAddRows = False
        Me.GrdList.AllowUserToDeleteRows = False
        Me.GrdList.AllowUserToResizeRows = False
        Me.GrdList.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.GrdList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GrdList.ColumnHeadersHeight = 24
        Me.GrdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.GrdList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdList.Location = New System.Drawing.Point(1, 1)
        Me.GrdList.MultiSelect = False
        Me.GrdList.Name = "GrdList"
        Me.GrdList.ReadOnly = True
        Me.GrdList.RowHeadersWidth = 24
        Me.GrdList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.GrdList.RowTemplate.Height = 24
        Me.GrdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrdList.Size = New System.Drawing.Size(786, 473)
        Me.GrdList.TabIndex = 0
        '
        'PnlFooter
        '
        Me.PnlFooter.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlFooter.Controls.Add(Me.LblRecords)
        Me.PnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlFooter.Location = New System.Drawing.Point(6, 513)
        Me.PnlFooter.Name = "PnlFooter"
        Me.PnlFooter.Size = New System.Drawing.Size(788, 32)
        Me.PnlFooter.TabIndex = 0
        '
        'LblRecords
        '
        Me.LblRecords.Dock = System.Windows.Forms.DockStyle.Left
        Me.LblRecords.Location = New System.Drawing.Point(0, 0)
        Me.LblRecords.Name = "LblRecords"
        Me.LblRecords.Size = New System.Drawing.Size(157, 32)
        Me.LblRecords.TabIndex = 0
        Me.LblRecords.Text = "Records Found: "
        Me.LblRecords.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlHead
        '
        Me.PnlHead.Controls.Add(Me.Panel2)
        Me.PnlHead.Controls.Add(Me.Panel1)
        Me.PnlHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHead.Location = New System.Drawing.Point(6, 5)
        Me.PnlHead.Name = "PnlHead"
        Me.PnlHead.Size = New System.Drawing.Size(788, 33)
        Me.PnlHead.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnUpdate)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(219, 33)
        Me.Panel2.TabIndex = 1
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(0, 1)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(70, 31)
        Me.BtnUpdate.TabIndex = 1
        Me.BtnUpdate.Text = "UPDATE"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        Me.BtnUpdate.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnSearch)
        Me.Panel1.Controls.Add(Me.TxtSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(475, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(313, 33)
        Me.Panel1.TabIndex = 0
        '
        'BtnSearch
        '
        Me.BtnSearch.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.Location = New System.Drawing.Point(224, 1)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(89, 30)
        Me.BtnSearch.TabIndex = 1
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'TxtSearch
        '
        Me.TxtSearch.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(2, 2)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(221, 27)
        Me.TxtSearch.TabIndex = 0
        '
        'FrmCustomers
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 550)
        Me.Controls.Add(Me.PnlContent)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCustomers"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCustomers"
        Me.PnlContent.ResumeLayout(False)
        Me.PnllBody.ResumeLayout(False)
        CType(Me.GrdList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlFooter.ResumeLayout(False)
        Me.PnlHead.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlContent As Panel
    Friend WithEvents PnllBody As Panel
    Friend WithEvents GrdList As DataGridView
    Friend WithEvents PnlFooter As Panel
    Friend WithEvents LblRecords As Label
    Friend WithEvents PnlHead As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TxtSearch As TextBox
End Class
