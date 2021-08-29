<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOrder))
        Me.PicCar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtOrder_No = New System.Windows.Forms.TextBox()
        Me.TxtOrder_Date = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPrice = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtContact_No = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtLast_Name = New System.Windows.Forms.TextBox()
        Me.TxtMiddle_Name = New System.Windows.Forms.TextBox()
        Me.TxtFirst_Name = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtProvince = New System.Windows.Forms.TextBox()
        Me.TxtCity = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtZip_Code = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TxtCountry = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RbtLoan = New System.Windows.Forms.RadioButton()
        Me.RbtCash = New System.Windows.Forms.RadioButton()
        Me.GrpPayment = New System.Windows.Forms.GroupBox()
        Me.TxtAmount = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.CboCard = New System.Windows.Forms.ComboBox()
        Me.TxtCard_Type = New System.Windows.Forms.TextBox()
        Me.TxtCard_Expiry = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TxtCard_Pin = New System.Windows.Forms.TextBox()
        Me.TxtCard_No = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.BtnConfirm = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.LblStock = New System.Windows.Forms.Label()
        Me.GrpLoan = New System.Windows.Forms.GroupBox()
        Me.TxtRate = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.NumYears = New System.Windows.Forms.NumericUpDown()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.TxtMonth = New System.Windows.Forms.TextBox()
        CType(Me.PicCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GrpPayment.SuspendLayout()
        Me.GrpLoan.SuspendLayout()
        CType(Me.NumYears, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PicCar
        '
        Me.PicCar.BackColor = System.Drawing.Color.White
        Me.PicCar.Location = New System.Drawing.Point(14, 10)
        Me.PicCar.Name = "PicCar"
        Me.PicCar.Size = New System.Drawing.Size(261, 135)
        Me.PicCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicCar.TabIndex = 0
        Me.PicCar.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(297, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Order No."
        '
        'TxtOrder_No
        '
        Me.TxtOrder_No.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtOrder_No.Location = New System.Drawing.Point(393, 10)
        Me.TxtOrder_No.Name = "TxtOrder_No"
        Me.TxtOrder_No.ReadOnly = True
        Me.TxtOrder_No.Size = New System.Drawing.Size(133, 22)
        Me.TxtOrder_No.TabIndex = 5
        Me.TxtOrder_No.Text = "Auto"
        '
        'TxtOrder_Date
        '
        Me.TxtOrder_Date.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtOrder_Date.Location = New System.Drawing.Point(393, 38)
        Me.TxtOrder_Date.Name = "TxtOrder_Date"
        Me.TxtOrder_Date.ReadOnly = True
        Me.TxtOrder_Date.Size = New System.Drawing.Size(133, 22)
        Me.TxtOrder_Date.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(297, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Order Date"
        '
        'TxtName
        '
        Me.TxtName.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtName.Location = New System.Drawing.Point(393, 66)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.ReadOnly = True
        Me.TxtName.Size = New System.Drawing.Size(240, 22)
        Me.TxtName.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(297, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 14)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Item Name"
        '
        'TxtPrice
        '
        Me.TxtPrice.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtPrice.Location = New System.Drawing.Point(393, 94)
        Me.TxtPrice.Name = "TxtPrice"
        Me.TxtPrice.ReadOnly = True
        Me.TxtPrice.Size = New System.Drawing.Size(133, 22)
        Me.TxtPrice.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(297, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 14)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Item Price"
        '
        'TxtStock
        '
        Me.TxtStock.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtStock.Location = New System.Drawing.Point(393, 123)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.ReadOnly = True
        Me.TxtStock.Size = New System.Drawing.Size(70, 22)
        Me.TxtStock.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(297, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 14)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Item Stock"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtContact_No)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtEmail)
        Me.GroupBox1.Controls.Add(Me.TxtLast_Name)
        Me.GroupBox1.Controls.Add(Me.TxtMiddle_Name)
        Me.GroupBox1.Controls.Add(Me.TxtFirst_Name)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 154)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 173)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Info"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 136)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Contact No."
        '
        'TxtContact_No
        '
        Me.TxtContact_No.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtContact_No.Location = New System.Drawing.Point(103, 136)
        Me.TxtContact_No.MaxLength = 35
        Me.TxtContact_No.Name = "TxtContact_No"
        Me.TxtContact_No.ReadOnly = True
        Me.TxtContact_No.Size = New System.Drawing.Size(200, 22)
        Me.TxtContact_No.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 108)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Email"
        '
        'TxtEmail
        '
        Me.TxtEmail.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtEmail.Location = New System.Drawing.Point(103, 108)
        Me.TxtEmail.MaxLength = 35
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.ReadOnly = True
        Me.TxtEmail.Size = New System.Drawing.Size(200, 22)
        Me.TxtEmail.TabIndex = 3
        '
        'TxtLast_Name
        '
        Me.TxtLast_Name.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtLast_Name.Location = New System.Drawing.Point(103, 80)
        Me.TxtLast_Name.MaxLength = 35
        Me.TxtLast_Name.Name = "TxtLast_Name"
        Me.TxtLast_Name.ReadOnly = True
        Me.TxtLast_Name.Size = New System.Drawing.Size(200, 22)
        Me.TxtLast_Name.TabIndex = 2
        '
        'TxtMiddle_Name
        '
        Me.TxtMiddle_Name.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtMiddle_Name.Location = New System.Drawing.Point(103, 52)
        Me.TxtMiddle_Name.MaxLength = 35
        Me.TxtMiddle_Name.Name = "TxtMiddle_Name"
        Me.TxtMiddle_Name.ReadOnly = True
        Me.TxtMiddle_Name.Size = New System.Drawing.Size(200, 22)
        Me.TxtMiddle_Name.TabIndex = 1
        '
        'TxtFirst_Name
        '
        Me.TxtFirst_Name.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtFirst_Name.Location = New System.Drawing.Point(103, 23)
        Me.TxtFirst_Name.MaxLength = 35
        Me.TxtFirst_Name.Name = "TxtFirst_Name"
        Me.TxtFirst_Name.ReadOnly = True
        Me.TxtFirst_Name.Size = New System.Drawing.Size(200, 22)
        Me.TxtFirst_Name.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 13)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Middle Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 80)
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtProvince)
        Me.GroupBox2.Controls.Add(Me.TxtCity)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtZip_Code)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.TxtCountry)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.TxtAddress)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Location = New System.Drawing.Point(14, 329)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(326, 180)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Shipping Address"
        '
        'TxtProvince
        '
        Me.TxtProvince.BackColor = System.Drawing.Color.White
        Me.TxtProvince.Location = New System.Drawing.Point(103, 88)
        Me.TxtProvince.MaxLength = 35
        Me.TxtProvince.Name = "TxtProvince"
        Me.TxtProvince.Size = New System.Drawing.Size(200, 22)
        Me.TxtProvince.TabIndex = 2
        '
        'TxtCity
        '
        Me.TxtCity.BackColor = System.Drawing.Color.White
        Me.TxtCity.Location = New System.Drawing.Point(103, 60)
        Me.TxtCity.MaxLength = 35
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.Size = New System.Drawing.Size(200, 22)
        Me.TxtCity.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Zip Code"
        '
        'TxtZip_Code
        '
        Me.TxtZip_Code.BackColor = System.Drawing.Color.White
        Me.TxtZip_Code.Location = New System.Drawing.Point(103, 144)
        Me.TxtZip_Code.MaxLength = 10
        Me.TxtZip_Code.Name = "TxtZip_Code"
        Me.TxtZip_Code.Size = New System.Drawing.Size(107, 22)
        Me.TxtZip_Code.TabIndex = 4
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(15, 116)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(50, 13)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Country"
        '
        'TxtCountry
        '
        Me.TxtCountry.BackColor = System.Drawing.Color.White
        Me.TxtCountry.Location = New System.Drawing.Point(103, 116)
        Me.TxtCountry.MaxLength = 35
        Me.TxtCountry.Name = "TxtCountry"
        Me.TxtCountry.Size = New System.Drawing.Size(200, 22)
        Me.TxtCountry.TabIndex = 3
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 8
        Me.Label13.Text = "Province"
        '
        'TxtAddress
        '
        Me.TxtAddress.BackColor = System.Drawing.Color.White
        Me.TxtAddress.Location = New System.Drawing.Point(103, 31)
        Me.TxtAddress.MaxLength = 35
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(200, 22)
        Me.TxtAddress.TabIndex = 0
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(15, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(28, 13)
        Me.Label14.TabIndex = 4
        Me.Label14.Text = "City"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(15, 31)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(52, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Address"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RbtLoan)
        Me.GroupBox3.Controls.Add(Me.RbtCash)
        Me.GroupBox3.Location = New System.Drawing.Point(349, 154)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(284, 63)
        Me.GroupBox3.TabIndex = 12
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Payment Mode"
        '
        'RbtLoan
        '
        Me.RbtLoan.AutoSize = True
        Me.RbtLoan.Location = New System.Drawing.Point(154, 25)
        Me.RbtLoan.Name = "RbtLoan"
        Me.RbtLoan.Size = New System.Drawing.Size(51, 18)
        Me.RbtLoan.TabIndex = 1
        Me.RbtLoan.Text = "Loan"
        Me.RbtLoan.UseVisualStyleBackColor = True
        '
        'RbtCash
        '
        Me.RbtCash.AutoSize = True
        Me.RbtCash.Checked = True
        Me.RbtCash.Location = New System.Drawing.Point(23, 25)
        Me.RbtCash.Name = "RbtCash"
        Me.RbtCash.Size = New System.Drawing.Size(50, 18)
        Me.RbtCash.TabIndex = 0
        Me.RbtCash.TabStop = True
        Me.RbtCash.Text = "Cash"
        Me.RbtCash.UseVisualStyleBackColor = True
        '
        'GrpPayment
        '
        Me.GrpPayment.Controls.Add(Me.TxtAmount)
        Me.GrpPayment.Controls.Add(Me.Label21)
        Me.GrpPayment.Controls.Add(Me.CboCard)
        Me.GrpPayment.Controls.Add(Me.TxtCard_Type)
        Me.GrpPayment.Controls.Add(Me.TxtCard_Expiry)
        Me.GrpPayment.Controls.Add(Me.Label16)
        Me.GrpPayment.Controls.Add(Me.Label17)
        Me.GrpPayment.Controls.Add(Me.TxtCard_Pin)
        Me.GrpPayment.Controls.Add(Me.TxtCard_No)
        Me.GrpPayment.Controls.Add(Me.Label18)
        Me.GrpPayment.Controls.Add(Me.Label19)
        Me.GrpPayment.Controls.Add(Me.Label20)
        Me.GrpPayment.Location = New System.Drawing.Point(349, 308)
        Me.GrpPayment.Name = "GrpPayment"
        Me.GrpPayment.Size = New System.Drawing.Size(284, 201)
        Me.GrpPayment.TabIndex = 14
        Me.GrpPayment.TabStop = False
        Me.GrpPayment.Text = "Payment Method"
        '
        'TxtAmount
        '
        Me.TxtAmount.BackColor = System.Drawing.Color.White
        Me.TxtAmount.Location = New System.Drawing.Point(114, 169)
        Me.TxtAmount.MaxLength = 35
        Me.TxtAmount.Name = "TxtAmount"
        Me.TxtAmount.Size = New System.Drawing.Size(146, 22)
        Me.TxtAmount.TabIndex = 5
        Me.TxtAmount.Text = "0"
        Me.TxtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(26, 169)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 13)
        Me.Label21.TabIndex = 26
        Me.Label21.Text = "Amount"
        '
        'CboCard
        '
        Me.CboCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCard.FormattingEnabled = True
        Me.CboCard.Location = New System.Drawing.Point(114, 27)
        Me.CboCard.Name = "CboCard"
        Me.CboCard.Size = New System.Drawing.Size(146, 22)
        Me.CboCard.TabIndex = 0
        '
        'TxtCard_Type
        '
        Me.TxtCard_Type.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtCard_Type.Location = New System.Drawing.Point(114, 55)
        Me.TxtCard_Type.MaxLength = 20
        Me.TxtCard_Type.Name = "TxtCard_Type"
        Me.TxtCard_Type.ReadOnly = True
        Me.TxtCard_Type.Size = New System.Drawing.Size(146, 22)
        Me.TxtCard_Type.TabIndex = 1
        '
        'TxtCard_Expiry
        '
        Me.TxtCard_Expiry.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtCard_Expiry.Location = New System.Drawing.Point(114, 83)
        Me.TxtCard_Expiry.MaxLength = 6
        Me.TxtCard_Expiry.Name = "TxtCard_Expiry"
        Me.TxtCard_Expiry.ReadOnly = True
        Me.TxtCard_Expiry.Size = New System.Drawing.Size(146, 22)
        Me.TxtCard_Expiry.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(26, 26)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 13)
        Me.Label16.TabIndex = 16
        Me.Label16.Text = "Card Alias"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(26, 83)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(71, 13)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Card Expiry"
        '
        'TxtCard_Pin
        '
        Me.TxtCard_Pin.BackColor = System.Drawing.Color.White
        Me.TxtCard_Pin.Location = New System.Drawing.Point(114, 139)
        Me.TxtCard_Pin.MaxLength = 6
        Me.TxtCard_Pin.Name = "TxtCard_Pin"
        Me.TxtCard_Pin.Size = New System.Drawing.Size(88, 22)
        Me.TxtCard_Pin.TabIndex = 4
        Me.TxtCard_Pin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TxtCard_Pin.UseSystemPasswordChar = True
        '
        'TxtCard_No
        '
        Me.TxtCard_No.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtCard_No.Location = New System.Drawing.Point(114, 111)
        Me.TxtCard_No.MaxLength = 20
        Me.TxtCard_No.Name = "TxtCard_No"
        Me.TxtCard_No.ReadOnly = True
        Me.TxtCard_No.Size = New System.Drawing.Size(146, 22)
        Me.TxtCard_No.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(26, 111)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(53, 13)
        Me.Label18.TabIndex = 4
        Me.Label18.Text = "Card No"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(26, 139)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(58, 13)
        Me.Label19.TabIndex = 3
        Me.Label19.Text = "Card PIN"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(26, 55)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 13)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "Card Type"
        '
        'BtnConfirm
        '
        Me.BtnConfirm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnConfirm.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnConfirm.Location = New System.Drawing.Point(545, 515)
        Me.BtnConfirm.Name = "BtnConfirm"
        Me.BtnConfirm.Size = New System.Drawing.Size(88, 36)
        Me.BtnConfirm.TabIndex = 11
        Me.BtnConfirm.Text = "Purchase"
        Me.BtnConfirm.UseVisualStyleBackColor = True
        '
        'BtnCancel
        '
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnCancel.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.Location = New System.Drawing.Point(451, 515)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(88, 36)
        Me.BtnCancel.TabIndex = 10
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = True
        '
        'LblStock
        '
        Me.LblStock.AutoSize = True
        Me.LblStock.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblStock.Location = New System.Drawing.Point(540, 10)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(93, 19)
        Me.LblStock.TabIndex = 12
        Me.LblStock.Text = "NO STOCK"
        Me.LblStock.Visible = False
        '
        'GrpLoan
        '
        Me.GrpLoan.Controls.Add(Me.TxtMonth)
        Me.GrpLoan.Controls.Add(Me.TxtRate)
        Me.GrpLoan.Controls.Add(Me.Label23)
        Me.GrpLoan.Controls.Add(Me.NumYears)
        Me.GrpLoan.Controls.Add(Me.Label22)
        Me.GrpLoan.Enabled = False
        Me.GrpLoan.Location = New System.Drawing.Point(349, 220)
        Me.GrpLoan.Name = "GrpLoan"
        Me.GrpLoan.Size = New System.Drawing.Size(284, 82)
        Me.GrpLoan.TabIndex = 13
        Me.GrpLoan.TabStop = False
        Me.GrpLoan.Text = "Loan Amortization (Monthly)"
        '
        'TxtRate
        '
        Me.TxtRate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtRate.Location = New System.Drawing.Point(111, 52)
        Me.TxtRate.MaxLength = 6
        Me.TxtRate.Name = "TxtRate"
        Me.TxtRate.ReadOnly = True
        Me.TxtRate.Size = New System.Drawing.Size(146, 22)
        Me.TxtRate.TabIndex = 20
        Me.TxtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(23, 52)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(82, 13)
        Me.Label23.TabIndex = 21
        Me.Label23.Text = "Monthly Rate"
        '
        'NumYears
        '
        Me.NumYears.Location = New System.Drawing.Point(111, 24)
        Me.NumYears.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumYears.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumYears.Name = "NumYears"
        Me.NumYears.Size = New System.Drawing.Size(91, 22)
        Me.NumYears.TabIndex = 19
        Me.NumYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.NumYears.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(23, 25)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(39, 13)
        Me.Label22.TabIndex = 18
        Me.Label22.Text = "Years"
        '
        'TxtMonth
        '
        Me.TxtMonth.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtMonth.Location = New System.Drawing.Point(208, 25)
        Me.TxtMonth.Name = "TxtMonth"
        Me.TxtMonth.ReadOnly = True
        Me.TxtMonth.Size = New System.Drawing.Size(49, 22)
        Me.TxtMonth.TabIndex = 22
        '
        'FrmOrder
        '
        Me.AcceptButton = Me.BtnConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CancelButton = Me.BtnCancel
        Me.ClientSize = New System.Drawing.Size(648, 561)
        Me.Controls.Add(Me.LblStock)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnConfirm)
        Me.Controls.Add(Me.GrpPayment)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtPrice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtOrder_Date)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtOrder_No)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PicCar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GrpLoan)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOrder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Form"
        CType(Me.PicCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GrpPayment.ResumeLayout(False)
        Me.GrpPayment.PerformLayout()
        Me.GrpLoan.ResumeLayout(False)
        Me.GrpLoan.PerformLayout()
        CType(Me.NumYears, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PicCar As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtOrder_No As TextBox
    Friend WithEvents TxtOrder_Date As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPrice As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtContact_No As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents TxtLast_Name As TextBox
    Friend WithEvents TxtMiddle_Name As TextBox
    Friend WithEvents TxtFirst_Name As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtProvince As TextBox
    Friend WithEvents TxtCity As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtZip_Code As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TxtCountry As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RbtLoan As RadioButton
    Friend WithEvents RbtCash As RadioButton
    Friend WithEvents GrpPayment As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TxtAmount As TextBox
    Friend WithEvents CboCard As ComboBox
    Friend WithEvents TxtCard_Type As TextBox
    Friend WithEvents TxtCard_Expiry As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents TxtCard_Pin As TextBox
    Friend WithEvents TxtCard_No As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents BtnConfirm As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents LblStock As Label
    Friend WithEvents GrpLoan As GroupBox
    Friend WithEvents TxtRate As TextBox
    Friend WithEvents Label23 As Label
    Friend WithEvents NumYears As NumericUpDown
    Friend WithEvents Label22 As Label
    Friend WithEvents TxtMonth As TextBox
End Class
