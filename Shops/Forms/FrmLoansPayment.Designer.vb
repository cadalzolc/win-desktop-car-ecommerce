<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLoansPayment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLoansPayment))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtLast_Name = New System.Windows.Forms.TextBox()
        Me.TxtFirst_Name = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GrpPayment = New System.Windows.Forms.GroupBox()
        Me.NumAmount = New System.Windows.Forms.NumericUpDown()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CboCard_Alias = New System.Windows.Forms.ComboBox()
        Me.TxtCard_Type = New System.Windows.Forms.TextBox()
        Me.TxtCard_Expiry = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtCard_Pin = New System.Windows.Forms.TextBox()
        Me.TxtCard_No = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtBalance = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtAmount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtMonths = New System.Windows.Forms.TextBox()
        Me.TxtProduct = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnConfirm = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GrpPayment.SuspendLayout()
        CType(Me.NumAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtLast_Name)
        Me.GroupBox1.Controls.Add(Me.TxtFirst_Name)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(318, 80)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Personal Info"
        '
        'TxtLast_Name
        '
        Me.TxtLast_Name.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtLast_Name.Location = New System.Drawing.Point(103, 49)
        Me.TxtLast_Name.MaxLength = 35
        Me.TxtLast_Name.Name = "TxtLast_Name"
        Me.TxtLast_Name.Size = New System.Drawing.Size(200, 20)
        Me.TxtLast_Name.TabIndex = 1
        '
        'TxtFirst_Name
        '
        Me.TxtFirst_Name.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtFirst_Name.Location = New System.Drawing.Point(103, 23)
        Me.TxtFirst_Name.MaxLength = 35
        Me.TxtFirst_Name.Name = "TxtFirst_Name"
        Me.TxtFirst_Name.Size = New System.Drawing.Size(200, 20)
        Me.TxtFirst_Name.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 49)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Last Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(15, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(67, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "First Name"
        '
        'GrpPayment
        '
        Me.GrpPayment.Controls.Add(Me.NumAmount)
        Me.GrpPayment.Controls.Add(Me.Label21)
        Me.GrpPayment.Controls.Add(Me.CboCard_Alias)
        Me.GrpPayment.Controls.Add(Me.TxtCard_Type)
        Me.GrpPayment.Controls.Add(Me.TxtCard_Expiry)
        Me.GrpPayment.Controls.Add(Me.Label16)
        Me.GrpPayment.Controls.Add(Me.Label17)
        Me.GrpPayment.Controls.Add(Me.TxtCard_Pin)
        Me.GrpPayment.Controls.Add(Me.TxtCard_No)
        Me.GrpPayment.Controls.Add(Me.Label18)
        Me.GrpPayment.Controls.Add(Me.Label19)
        Me.GrpPayment.Controls.Add(Me.Label20)
        Me.GrpPayment.Location = New System.Drawing.Point(6, 224)
        Me.GrpPayment.Name = "GrpPayment"
        Me.GrpPayment.Size = New System.Drawing.Size(318, 201)
        Me.GrpPayment.TabIndex = 2
        Me.GrpPayment.TabStop = False
        Me.GrpPayment.Text = "Payment Method"
        '
        'NumAmount
        '
        Me.NumAmount.DecimalPlaces = 2
        Me.NumAmount.Increment = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumAmount.Location = New System.Drawing.Point(103, 168)
        Me.NumAmount.Maximum = New Decimal(New Integer() {9999999, 0, 0, 0})
        Me.NumAmount.Name = "NumAmount"
        Me.NumAmount.Size = New System.Drawing.Size(200, 20)
        Me.NumAmount.TabIndex = 5
        Me.NumAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.NumAmount.ThousandsSeparator = True
        Me.NumAmount.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(15, 170)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 13)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "Amount"
        '
        'CboCard_Alias
        '
        Me.CboCard_Alias.AccessibleDescription = "Required"
        Me.CboCard_Alias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCard_Alias.FormattingEnabled = True
        Me.CboCard_Alias.Location = New System.Drawing.Point(103, 27)
        Me.CboCard_Alias.Name = "CboCard_Alias"
        Me.CboCard_Alias.Size = New System.Drawing.Size(200, 21)
        Me.CboCard_Alias.TabIndex = 0
        '
        'TxtCard_Type
        '
        Me.TxtCard_Type.AccessibleDescription = "Required"
        Me.TxtCard_Type.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtCard_Type.Location = New System.Drawing.Point(103, 55)
        Me.TxtCard_Type.MaxLength = 20
        Me.TxtCard_Type.Name = "TxtCard_Type"
        Me.TxtCard_Type.ReadOnly = True
        Me.TxtCard_Type.Size = New System.Drawing.Size(200, 20)
        Me.TxtCard_Type.TabIndex = 1
        '
        'TxtCard_Expiry
        '
        Me.TxtCard_Expiry.AccessibleDescription = "Required"
        Me.TxtCard_Expiry.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtCard_Expiry.Location = New System.Drawing.Point(103, 83)
        Me.TxtCard_Expiry.MaxLength = 6
        Me.TxtCard_Expiry.Name = "TxtCard_Expiry"
        Me.TxtCard_Expiry.ReadOnly = True
        Me.TxtCard_Expiry.Size = New System.Drawing.Size(200, 20)
        Me.TxtCard_Expiry.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(15, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 13)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Card Alias"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(15, 84)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 13)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Card Expiry"
        '
        'TxtCard_Pin
        '
        Me.TxtCard_Pin.AccessibleDescription = "Required"
        Me.TxtCard_Pin.BackColor = System.Drawing.Color.White
        Me.TxtCard_Pin.Location = New System.Drawing.Point(103, 139)
        Me.TxtCard_Pin.MaxLength = 6
        Me.TxtCard_Pin.Name = "TxtCard_Pin"
        Me.TxtCard_Pin.Size = New System.Drawing.Size(100, 20)
        Me.TxtCard_Pin.TabIndex = 4
        Me.TxtCard_Pin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCard_Pin.UseSystemPasswordChar = True
        '
        'TxtCard_No
        '
        Me.TxtCard_No.AccessibleDescription = "Required"
        Me.TxtCard_No.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtCard_No.Location = New System.Drawing.Point(103, 111)
        Me.TxtCard_No.MaxLength = 20
        Me.TxtCard_No.Name = "TxtCard_No"
        Me.TxtCard_No.ReadOnly = True
        Me.TxtCard_No.Size = New System.Drawing.Size(200, 20)
        Me.TxtCard_No.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(15, 112)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 13)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Card No"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(15, 140)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(58, 13)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Card PIN"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(15, 56)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 13)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Card Type"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtBalance)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtAmount)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtMonths)
        Me.GroupBox2.Controls.Add(Me.TxtProduct)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(318, 137)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Loan Info"
        '
        'TxtBalance
        '
        Me.TxtBalance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtBalance.Location = New System.Drawing.Point(103, 75)
        Me.TxtBalance.MaxLength = 35
        Me.TxtBalance.Name = "TxtBalance"
        Me.TxtBalance.Size = New System.Drawing.Size(200, 20)
        Me.TxtBalance.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Balance"
        '
        'TxtAmount
        '
        Me.TxtAmount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtAmount.Location = New System.Drawing.Point(103, 101)
        Me.TxtAmount.MaxLength = 35
        Me.TxtAmount.Name = "TxtAmount"
        Me.TxtAmount.Size = New System.Drawing.Size(200, 20)
        Me.TxtAmount.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Amount"
        '
        'TxtMonths
        '
        Me.TxtMonths.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtMonths.Location = New System.Drawing.Point(103, 49)
        Me.TxtMonths.MaxLength = 35
        Me.TxtMonths.Name = "TxtMonths"
        Me.TxtMonths.Size = New System.Drawing.Size(100, 20)
        Me.TxtMonths.TabIndex = 1
        '
        'TxtProduct
        '
        Me.TxtProduct.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtProduct.Location = New System.Drawing.Point(103, 23)
        Me.TxtProduct.MaxLength = 35
        Me.TxtProduct.Name = "TxtProduct"
        Me.TxtProduct.Size = New System.Drawing.Size(200, 20)
        Me.TxtProduct.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Months"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Product"
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(127, 431)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(88, 36)
        Me.BtnCancel.TabIndex = 4
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'BtnConfirm
        '
        Me.BtnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConfirm.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirm.Location = New System.Drawing.Point(221, 431)
        Me.BtnConfirm.Name = "BtnConfirm"
        Me.BtnConfirm.Size = New System.Drawing.Size(88, 36)
        Me.BtnConfirm.TabIndex = 3
        Me.BtnConfirm.Text = "Payment"
        Me.BtnConfirm.UseVisualStyleBackColor = True
        '
        'FrmLoansPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(332, 476)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnConfirm)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GrpPayment)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmLoansPayment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loans Payment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GrpPayment.ResumeLayout(False)
        Me.GrpPayment.PerformLayout()
        CType(Me.NumAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TxtLast_Name As TextBox
    Friend WithEvents TxtFirst_Name As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GrpPayment As GroupBox
    Friend WithEvents NumAmount As NumericUpDown
    Friend WithEvents Label21 As Label
    Friend WithEvents CboCard_Alias As ComboBox
    Friend WithEvents TxtCard_Type As TextBox
    Friend WithEvents TxtCard_Expiry As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtCard_Pin As TextBox
    Friend WithEvents TxtCard_No As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtAmount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtMonths As TextBox
    Friend WithEvents TxtProduct As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBalance As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnConfirm As Button
End Class
