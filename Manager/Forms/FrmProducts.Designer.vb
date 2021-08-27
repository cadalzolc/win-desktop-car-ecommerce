<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProducts
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
        Me.PnlContent = New System.Windows.Forms.Panel()
        Me.PnlHead = New System.Windows.Forms.Panel()
        Me.GrdList = New System.Windows.Forms.DataGridView()
        Me.PnlFooter = New System.Windows.Forms.Panel()
        Me.PnllBody = New System.Windows.Forms.Panel()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnCreate = New System.Windows.Forms.Button()
        Me.BtnUpdate = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.LblRecords = New System.Windows.Forms.Label()
        Me.PnlContent.SuspendLayout()
        Me.PnlHead.SuspendLayout()
        CType(Me.GrdList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlFooter.SuspendLayout()
        Me.PnllBody.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
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
        Me.PnlContent.Size = New System.Drawing.Size(817, 431)
        Me.PnlContent.TabIndex = 2
        '
        'PnlHead
        '
        Me.PnlHead.Controls.Add(Me.Panel2)
        Me.PnlHead.Controls.Add(Me.Panel1)
        Me.PnlHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHead.Location = New System.Drawing.Point(6, 5)
        Me.PnlHead.Name = "PnlHead"
        Me.PnlHead.Size = New System.Drawing.Size(805, 33)
        Me.PnlHead.TabIndex = 0
        '
        'GrdList
        '
        Me.GrdList.AllowUserToAddRows = False
        Me.GrdList.AllowUserToDeleteRows = False
        Me.GrdList.AllowUserToResizeRows = False
        Me.GrdList.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.GrdList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GrdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GrdList.Location = New System.Drawing.Point(1, 1)
        Me.GrdList.Name = "GrdList"
        Me.GrdList.ReadOnly = True
        Me.GrdList.RowTemplate.Height = 30
        Me.GrdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrdList.Size = New System.Drawing.Size(803, 354)
        Me.GrdList.TabIndex = 0
        '
        'PnlFooter
        '
        Me.PnlFooter.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlFooter.Controls.Add(Me.LblRecords)
        Me.PnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlFooter.Location = New System.Drawing.Point(6, 394)
        Me.PnlFooter.Name = "PnlFooter"
        Me.PnlFooter.Size = New System.Drawing.Size(805, 32)
        Me.PnlFooter.TabIndex = 0
        '
        'PnllBody
        '
        Me.PnllBody.BackColor = System.Drawing.Color.Silver
        Me.PnllBody.Controls.Add(Me.GrdList)
        Me.PnllBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnllBody.Location = New System.Drawing.Point(6, 38)
        Me.PnllBody.Name = "PnllBody"
        Me.PnllBody.Padding = New System.Windows.Forms.Padding(1)
        Me.PnllBody.Size = New System.Drawing.Size(805, 356)
        Me.PnllBody.TabIndex = 3
        '
        'TxtSearch
        '
        Me.TxtSearch.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSearch.Location = New System.Drawing.Point(1, 1)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(284, 27)
        Me.TxtSearch.TabIndex = 0
        '
        'BtnSearch
        '
        Me.BtnSearch.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSearch.Location = New System.Drawing.Point(289, 0)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(89, 30)
        Me.BtnSearch.TabIndex = 1
        Me.BtnSearch.Text = "Search"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.BtnSearch)
        Me.Panel1.Controls.Add(Me.TxtSearch)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(427, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(378, 33)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtnDelete)
        Me.Panel2.Controls.Add(Me.BtnUpdate)
        Me.Panel2.Controls.Add(Me.BtnCreate)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(291, 33)
        Me.Panel2.TabIndex = 1
        '
        'BtnCreate
        '
        Me.BtnCreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCreate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCreate.Location = New System.Drawing.Point(-1, 0)
        Me.BtnCreate.Name = "BtnCreate"
        Me.BtnCreate.Size = New System.Drawing.Size(89, 30)
        Me.BtnCreate.TabIndex = 0
        Me.BtnCreate.Text = "CREATE"
        Me.BtnCreate.UseVisualStyleBackColor = True
        '
        'BtnUpdate
        '
        Me.BtnUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUpdate.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpdate.Location = New System.Drawing.Point(91, 0)
        Me.BtnUpdate.Name = "BtnUpdate"
        Me.BtnUpdate.Size = New System.Drawing.Size(89, 30)
        Me.BtnUpdate.TabIndex = 1
        Me.BtnUpdate.Text = "UPDATE"
        Me.BtnUpdate.UseVisualStyleBackColor = True
        Me.BtnUpdate.Visible = False
        '
        'BtnDelete
        '
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.Location = New System.Drawing.Point(184, 0)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(89, 30)
        Me.BtnDelete.TabIndex = 2
        Me.BtnDelete.Text = "DELETE"
        Me.BtnDelete.UseVisualStyleBackColor = True
        Me.BtnDelete.Visible = False
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
        'FrmProducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(817, 431)
        Me.Controls.Add(Me.PnlContent)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmProducts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmProducts"
        Me.PnlContent.ResumeLayout(False)
        Me.PnlHead.ResumeLayout(False)
        CType(Me.GrdList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlFooter.ResumeLayout(False)
        Me.PnllBody.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlContent As Panel
    Friend WithEvents PnllBody As Panel
    Friend WithEvents GrdList As DataGridView
    Friend WithEvents PnlFooter As Panel
    Friend WithEvents PnlHead As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnDelete As Button
    Friend WithEvents BtnUpdate As Button
    Friend WithEvents BtnCreate As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents LblRecords As Label
End Class
