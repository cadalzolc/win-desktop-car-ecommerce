<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegister
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRegister))
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtContact_No = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CboGender = New System.Windows.Forms.ComboBox()
        Me.TxtLast_Name = New System.Windows.Forms.TextBox()
        Me.TxtMiddle_Name = New System.Windows.Forms.TextBox()
        Me.TxtFirst_Name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TxtProvince = New System.Windows.Forms.TextBox()
        Me.TxtCity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtZip_Code = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCountry = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtAlias = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dtpExpiry = New System.Windows.Forms.DateTimePicker()
        Me.CboCard_Type = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtCard_Pin = New System.Windows.Forms.TextBox()
        Me.TxtCard_No = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSubmit
        '
        Me.BtnSubmit.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSubmit.Location = New System.Drawing.Point(590, 394)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(87, 30)
        Me.BtnSubmit.TabIndex = 4
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TxtContact_No)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TxtEmail)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.CboGender)
        Me.GroupBox1.Controls.Add(Me.TxtLast_Name)
        Me.GroupBox1.Controls.Add(Me.TxtMiddle_Name)
        Me.GroupBox1.Controls.Add(Me.TxtFirst_Name)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(10, 7)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 218)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Info"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(26, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 17)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Contact No."
        '
        'TxtContact_No
        '
        Me.TxtContact_No.Location = New System.Drawing.Point(114, 183)
        Me.TxtContact_No.MaxLength = 35
        Me.TxtContact_No.Name = "TxtContact_No"
        Me.TxtContact_No.Size = New System.Drawing.Size(200, 26)
        Me.TxtContact_No.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(26, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Email"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(114, 155)
        Me.TxtEmail.MaxLength = 35
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(200, 26)
        Me.TxtEmail.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(26, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Gender"
        '
        'CboGender
        '
        Me.CboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboGender.FormattingEnabled = True
        Me.CboGender.Location = New System.Drawing.Point(114, 127)
        Me.CboGender.Name = "CboGender"
        Me.CboGender.Size = New System.Drawing.Size(108, 26)
        Me.CboGender.TabIndex = 3
        '
        'TxtLast_Name
        '
        Me.TxtLast_Name.Location = New System.Drawing.Point(114, 99)
        Me.TxtLast_Name.MaxLength = 35
        Me.TxtLast_Name.Name = "TxtLast_Name"
        Me.TxtLast_Name.Size = New System.Drawing.Size(200, 26)
        Me.TxtLast_Name.TabIndex = 2
        '
        'TxtMiddle_Name
        '
        Me.TxtMiddle_Name.Location = New System.Drawing.Point(114, 71)
        Me.TxtMiddle_Name.MaxLength = 35
        Me.TxtMiddle_Name.Name = "TxtMiddle_Name"
        Me.TxtMiddle_Name.Size = New System.Drawing.Size(200, 26)
        Me.TxtMiddle_Name.TabIndex = 1
        '
        'TxtFirst_Name
        '
        Me.TxtFirst_Name.Location = New System.Drawing.Point(114, 42)
        Me.TxtFirst_Name.MaxLength = 35
        Me.TxtFirst_Name.Name = "TxtFirst_Name"
        Me.TxtFirst_Name.Size = New System.Drawing.Size(200, 26)
        Me.TxtFirst_Name.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(26, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 17)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Middle Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(86, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "First Name"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TxtProvince)
        Me.GroupBox2.Controls.Add(Me.TxtCity)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TxtZip_Code)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtCountry)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TxtAddress)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 231)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(328, 193)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Shipping Address"
        '
        'TxtProvince
        '
        Me.TxtProvince.Location = New System.Drawing.Point(114, 99)
        Me.TxtProvince.MaxLength = 35
        Me.TxtProvince.Name = "TxtProvince"
        Me.TxtProvince.Size = New System.Drawing.Size(200, 26)
        Me.TxtProvince.TabIndex = 2
        '
        'TxtCity
        '
        Me.TxtCity.Location = New System.Drawing.Point(114, 71)
        Me.TxtCity.MaxLength = 35
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.Size = New System.Drawing.Size(200, 26)
        Me.TxtCity.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 155)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Zip Code"
        '
        'TxtZip_Code
        '
        Me.TxtZip_Code.Location = New System.Drawing.Point(114, 155)
        Me.TxtZip_Code.MaxLength = 10
        Me.TxtZip_Code.Name = "TxtZip_Code"
        Me.TxtZip_Code.Size = New System.Drawing.Size(108, 26)
        Me.TxtZip_Code.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(26, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 17)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Country"
        '
        'TxtCountry
        '
        Me.TxtCountry.Location = New System.Drawing.Point(114, 127)
        Me.TxtCountry.MaxLength = 35
        Me.TxtCountry.Name = "TxtCountry"
        Me.TxtCountry.Size = New System.Drawing.Size(200, 26)
        Me.TxtCountry.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(26, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Province"
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(114, 42)
        Me.TxtAddress.MaxLength = 35
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(200, 26)
        Me.TxtAddress.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(26, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 17)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "City"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(26, 42)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 17)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Address"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtAlias)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.dtpExpiry)
        Me.GroupBox3.Controls.Add(Me.CboCard_Type)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.TxtCard_Pin)
        Me.GroupBox3.Controls.Add(Me.TxtCard_No)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Location = New System.Drawing.Point(349, 7)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(328, 218)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Payment Method"
        '
        'TxtAlias
        '
        Me.TxtAlias.Location = New System.Drawing.Point(114, 42)
        Me.TxtAlias.MaxLength = 35
        Me.TxtAlias.Name = "TxtAlias"
        Me.TxtAlias.Size = New System.Drawing.Size(200, 26)
        Me.TxtAlias.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(26, 42)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 17)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Alias"
        '
        'dtpExpiry
        '
        Me.dtpExpiry.Location = New System.Drawing.Point(114, 156)
        Me.dtpExpiry.Name = "dtpExpiry"
        Me.dtpExpiry.Size = New System.Drawing.Size(200, 26)
        Me.dtpExpiry.TabIndex = 4
        '
        'CboCard_Type
        '
        Me.CboCard_Type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboCard_Type.FormattingEnabled = True
        Me.CboCard_Type.Location = New System.Drawing.Point(114, 71)
        Me.CboCard_Type.Name = "CboCard_Type"
        Me.CboCard_Type.Size = New System.Drawing.Size(200, 26)
        Me.CboCard_Type.TabIndex = 1
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(26, 156)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(52, 17)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "Expiry"
        '
        'TxtCard_Pin
        '
        Me.TxtCard_Pin.Location = New System.Drawing.Point(114, 128)
        Me.TxtCard_Pin.MaxLength = 6
        Me.TxtCard_Pin.Name = "TxtCard_Pin"
        Me.TxtCard_Pin.Size = New System.Drawing.Size(108, 26)
        Me.TxtCard_Pin.TabIndex = 3
        Me.TxtCard_Pin.UseSystemPasswordChar = True
        '
        'TxtCard_No
        '
        Me.TxtCard_No.Location = New System.Drawing.Point(114, 100)
        Me.TxtCard_No.MaxLength = 20
        Me.TxtCard_No.Name = "TxtCard_No"
        Me.TxtCard_No.Size = New System.Drawing.Size(200, 26)
        Me.TxtCard_No.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(26, 100)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 17)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Card No"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(26, 128)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 17)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Card PIN"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(26, 71)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(83, 17)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "Card Type"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TxtPassword)
        Me.GroupBox4.Controls.Add(Me.TxtUsername)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Location = New System.Drawing.Point(349, 231)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(328, 118)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Credentials"
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(114, 71)
        Me.TxtPassword.MaxLength = 35
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(200, 26)
        Me.TxtPassword.TabIndex = 1
        Me.TxtPassword.UseSystemPasswordChar = True
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(114, 42)
        Me.TxtUsername.MaxLength = 35
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(200, 26)
        Me.TxtUsername.TabIndex = 0
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(26, 71)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(77, 17)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Password"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(26, 42)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(81, 17)
        Me.Label23.TabIndex = 2
        Me.Label23.Text = "Username"
        '
        'FrmRegister
        '
        Me.AcceptButton = Me.BtnSubmit
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 433)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmRegister"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSubmit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CboGender As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtContact_No As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtLast_Name As TextBox
    Friend WithEvents TxtMiddle_Name As TextBox
    Friend WithEvents TxtFirst_Name As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtZip_Code As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtCountry As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtCard_Pin As TextBox
    Friend WithEvents TxtCard_No As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents TxtAlias As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents dtpExpiry As DateTimePicker
    Friend WithEvents CboCard_Type As ComboBox
    Friend WithEvents TxtProvince As TextBox
    Friend WithEvents TxtCity As TextBox
End Class
