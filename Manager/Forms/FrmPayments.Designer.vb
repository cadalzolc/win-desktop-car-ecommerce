﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPayments
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
        Me.PnlHead = New System.Windows.Forms.Panel()
        Me.PnlForm = New System.Windows.Forms.Panel()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.PnlContent = New System.Windows.Forms.Panel()
        Me.PnllBody = New System.Windows.Forms.Panel()
        Me.GrdList = New System.Windows.Forms.DataGridView()
        Me.PnlFooter = New System.Windows.Forms.Panel()
        Me.LblTotal = New System.Windows.Forms.Label()
        Me.LblRecords = New System.Windows.Forms.Label()
        Me.PnlHead.SuspendLayout()
        Me.PnlForm.SuspendLayout()
        Me.PnlContent.SuspendLayout()
        Me.PnllBody.SuspendLayout()
        CType(Me.GrdList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlFooter.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlHead
        '
        Me.PnlHead.Controls.Add(Me.PnlForm)
        Me.PnlHead.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnlHead.Location = New System.Drawing.Point(6, 5)
        Me.PnlHead.Name = "PnlHead"
        Me.PnlHead.Size = New System.Drawing.Size(788, 33)
        Me.PnlHead.TabIndex = 0
        '
        'PnlForm
        '
        Me.PnlForm.Controls.Add(Me.BtnSearch)
        Me.PnlForm.Controls.Add(Me.TxtSearch)
        Me.PnlForm.Dock = System.Windows.Forms.DockStyle.Right
        Me.PnlForm.Location = New System.Drawing.Point(475, 0)
        Me.PnlForm.Name = "PnlForm"
        Me.PnlForm.Size = New System.Drawing.Size(313, 33)
        Me.PnlForm.TabIndex = 0
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
        Me.PnlContent.Size = New System.Drawing.Size(800, 450)
        Me.PnlContent.TabIndex = 5
        '
        'PnllBody
        '
        Me.PnllBody.BackColor = System.Drawing.Color.Silver
        Me.PnllBody.Controls.Add(Me.GrdList)
        Me.PnllBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnllBody.Location = New System.Drawing.Point(6, 38)
        Me.PnllBody.Name = "PnllBody"
        Me.PnllBody.Padding = New System.Windows.Forms.Padding(1)
        Me.PnllBody.Size = New System.Drawing.Size(788, 375)
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
        Me.GrdList.Size = New System.Drawing.Size(786, 373)
        Me.GrdList.TabIndex = 0
        '
        'PnlFooter
        '
        Me.PnlFooter.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PnlFooter.Controls.Add(Me.LblTotal)
        Me.PnlFooter.Controls.Add(Me.LblRecords)
        Me.PnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlFooter.Location = New System.Drawing.Point(6, 413)
        Me.PnlFooter.Name = "PnlFooter"
        Me.PnlFooter.Size = New System.Drawing.Size(788, 32)
        Me.PnlFooter.TabIndex = 0
        '
        'LblTotal
        '
        Me.LblTotal.Dock = System.Windows.Forms.DockStyle.Right
        Me.LblTotal.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotal.Location = New System.Drawing.Point(475, 0)
        Me.LblTotal.Name = "LblTotal"
        Me.LblTotal.Size = New System.Drawing.Size(313, 32)
        Me.LblTotal.TabIndex = 1
        Me.LblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        'FrmPayments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PnlContent)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmPayments"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Payments"
        Me.PnlHead.ResumeLayout(False)
        Me.PnlForm.ResumeLayout(False)
        Me.PnlForm.PerformLayout()
        Me.PnlContent.ResumeLayout(False)
        Me.PnllBody.ResumeLayout(False)
        CType(Me.GrdList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlFooter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlHead As Panel
    Friend WithEvents PnlForm As Panel
    Friend WithEvents BtnSearch As Button
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents PnlContent As Panel
    Friend WithEvents PnllBody As Panel
    Friend WithEvents GrdList As DataGridView
    Friend WithEvents PnlFooter As Panel
    Friend WithEvents LblTotal As Label
    Friend WithEvents LblRecords As Label
End Class
