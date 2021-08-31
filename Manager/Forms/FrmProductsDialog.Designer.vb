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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ChkVisible = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PicCar = New System.Windows.Forms.PictureBox()
        Me.NumStock = New System.Windows.Forms.NumericUpDown()
        Me.NumPrice = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PicCar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumStock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumPrice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(207, 402)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(105, 35)
        Me.BtnSave.TabIndex = 1
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
        Me.TxtProductNo.Location = New System.Drawing.Point(121, 33)
        Me.TxtProductNo.Name = "TxtProductNo"
        Me.TxtProductNo.ReadOnly = True
        Me.TxtProductNo.Size = New System.Drawing.Size(154, 22)
        Me.TxtProductNo.TabIndex = 0
        Me.TxtProductNo.TabStop = False
        Me.TxtProductNo.Text = "AUTO"
        '
        'CboCar
        '
        Me.CboCar.AccessibleDescription = "Required"
        Me.CboCar.FormattingEnabled = True
        Me.CboCar.Location = New System.Drawing.Point(121, 88)
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
        Me.TxtProductName.AccessibleDescription = "Required"
        Me.TxtProductName.Location = New System.Drawing.Point(121, 60)
        Me.TxtProductName.Name = "TxtProductName"
        Me.TxtProductName.Size = New System.Drawing.Size(154, 22)
        Me.TxtProductName.TabIndex = 1
        '
        'CboColor
        '
        Me.CboColor.AccessibleDescription = "Required"
        Me.CboColor.FormattingEnabled = True
        Me.CboColor.Location = New System.Drawing.Point(121, 116)
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
        Me.ChkVisible.Checked = True
        Me.ChkVisible.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ChkVisible.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChkVisible.Location = New System.Drawing.Point(121, 201)
        Me.ChkVisible.Name = "ChkVisible"
        Me.ChkVisible.Size = New System.Drawing.Size(64, 18)
        Me.ChkVisible.TabIndex = 6
        Me.ChkVisible.Text = "Visible"
        Me.ChkVisible.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.NumPrice)
        Me.GroupBox1.Controls.Add(Me.NumStock)
        Me.GroupBox1.Controls.Add(Me.TxtProductNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ChkVisible)
        Me.GroupBox1.Controls.Add(Me.CboCar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtProductName)
        Me.GroupBox1.Controls.Add(Me.CboColor)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 168)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(300, 228)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Product Information"
        '
        'PicCar
        '
        Me.PicCar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PicCar.Image = CType(resources.GetObject("PicCar.Image"), System.Drawing.Image)
        Me.PicCar.Location = New System.Drawing.Point(12, 12)
        Me.PicCar.Name = "PicCar"
        Me.PicCar.Size = New System.Drawing.Size(300, 150)
        Me.PicCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicCar.TabIndex = 1
        Me.PicCar.TabStop = False
        '
        'NumStock
        '
        Me.NumStock.AccessibleDescription = "Required"
        Me.NumStock.Location = New System.Drawing.Point(121, 144)
        Me.NumStock.Name = "NumStock"
        Me.NumStock.Size = New System.Drawing.Size(154, 22)
        Me.NumStock.TabIndex = 4
        Me.NumStock.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumStock.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        Me.NumStock.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NumPrice
        '
        Me.NumPrice.AccessibleDescription = "Required"
        Me.NumPrice.DecimalPlaces = 2
        Me.NumPrice.Increment = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.NumPrice.Location = New System.Drawing.Point(121, 173)
        Me.NumPrice.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.NumPrice.Name = "NumPrice"
        Me.NumPrice.Size = New System.Drawing.Size(154, 22)
        Me.NumPrice.TabIndex = 5
        Me.NumPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumPrice.ThousandsSeparator = True
        Me.NumPrice.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'FrmProductsDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(326, 446)
        Me.Controls.Add(Me.PicCar)
        Me.Controls.Add(Me.BtnSave)
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
        CType(Me.PicCar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumStock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumPrice, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ChkVisible As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PicCar As PictureBox
    Friend WithEvents NumPrice As NumericUpDown
    Friend WithEvents NumStock As NumericUpDown
End Class
