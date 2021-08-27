<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProductsDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProductsDialog))
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtProductNo = New System.Windows.Forms.TextBox()
        Me.CboCar = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtProductName = New System.Windows.Forms.TextBox()
        Me.CboColor = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ChkVisible = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(185, 228)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(105, 35)
        Me.BtnSave.TabIndex = 7
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product No :"
        '
        'TxtProductNo
        '
        Me.TxtProductNo.Location = New System.Drawing.Point(136, 33)
        Me.TxtProductNo.Name = "TxtProductNo"
        Me.TxtProductNo.ReadOnly = True
        Me.TxtProductNo.Size = New System.Drawing.Size(154, 22)
        Me.TxtProductNo.TabIndex = 30
        Me.TxtProductNo.TabStop = False
        Me.TxtProductNo.Text = "AUTO"
        '
        'CboCar
        '
        Me.CboCar.FormattingEnabled = True
        Me.CboCar.Location = New System.Drawing.Point(136, 88)
        Me.CboCar.Name = "CboCar"
        Me.CboCar.Size = New System.Drawing.Size(154, 22)
        Me.CboCar.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Product Name :"
        '
        'TxtProductName
        '
        Me.TxtProductName.Location = New System.Drawing.Point(136, 60)
        Me.TxtProductName.Name = "TxtProductName"
        Me.TxtProductName.Size = New System.Drawing.Size(154, 22)
        Me.TxtProductName.TabIndex = 1
        '
        'CboColor
        '
        Me.CboColor.FormattingEnabled = True
        Me.CboColor.Location = New System.Drawing.Point(136, 116)
        Me.CboColor.Name = "CboColor"
        Me.CboColor.Size = New System.Drawing.Size(154, 22)
        Me.CboColor.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 14)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Car Info :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 14)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Color :"
        '
        'TxtPrice
        '
        Me.TxtPrice.Location = New System.Drawing.Point(136, 173)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.Size = New System.Drawing.Size(154, 22)
        Me.TxtPrice.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 14)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Price :"
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(136, 144)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(154, 22)
        Me.TxtStock.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 14)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Stock :"
        '
        'ChkVisible
        '
        Me.ChkVisible.AutoSize = True
        Me.ChkVisible.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkVisible.Location = New System.Drawing.Point(18, 245)
        Me.ChkVisible.Name = "ChkVisible"
        Me.ChkVisible.Size = New System.Drawing.Size(64, 18)
        Me.ChkVisible.TabIndex = 15
        Me.ChkVisible.Text = "Visible"
        Me.ChkVisible.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtProductNo)
        Me.GroupBox1.Controls.Add(Me.BtnSave)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ChkVisible)
        Me.GroupBox1.Controls.Add(Me.CboCar)
        Me.GroupBox1.Controls.Add(Me.TxtStock)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtProductName)
        Me.GroupBox1.Controls.Add(Me.TxtPrice)
        Me.GroupBox1.Controls.Add(Me.CboColor)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 283)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Information"
        '
        'FrmProductsDialog
        '
        Me.AcceptButton = Me.BtnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 294)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmProductsDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Product Info"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSave As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtProductNo As TextBox
    Friend WithEvents CboCar As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtProductName As TextBox
    Friend WithEvents CboColor As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtPrice As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ChkVisible As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
