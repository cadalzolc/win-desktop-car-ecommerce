<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAccount))
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
        Me.BtnUserChange = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GrdList = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.GrdList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.GroupBox2.Location = New System.Drawing.Point(393, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(376, 172)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Shipping Address"
        '
        'TxtProvince
        '
        Me.TxtProvince.Location = New System.Drawing.Point(124, 83)
        Me.TxtProvince.MaxLength = 35
        Me.TxtProvince.Name = "TxtProvince"
        Me.TxtProvince.Size = New System.Drawing.Size(233, 22)
        Me.TxtProvince.TabIndex = 2
        '
        'TxtCity
        '
        Me.TxtCity.Location = New System.Drawing.Point(124, 52)
        Me.TxtCity.MaxLength = 35
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.Size = New System.Drawing.Size(233, 22)
        Me.TxtCity.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Zip Code"
        '
        'TxtZip_Code
        '
        Me.TxtZip_Code.Location = New System.Drawing.Point(124, 143)
        Me.TxtZip_Code.MaxLength = 10
        Me.TxtZip_Code.Name = "TxtZip_Code"
        Me.TxtZip_Code.Size = New System.Drawing.Size(125, 22)
        Me.TxtZip_Code.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(21, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Country"
        '
        'TxtCountry
        '
        Me.TxtCountry.Location = New System.Drawing.Point(124, 113)
        Me.TxtCountry.MaxLength = 35
        Me.TxtCountry.Name = "TxtCountry"
        Me.TxtCountry.Size = New System.Drawing.Size(233, 22)
        Me.TxtCountry.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(21, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Province"
        '
        'TxtAddress
        '
        Me.TxtAddress.Location = New System.Drawing.Point(124, 21)
        Me.TxtAddress.MaxLength = 35
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(233, 22)
        Me.TxtAddress.TabIndex = 0
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 52)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(28, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "City"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(21, 21)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(52, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Address"
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
        Me.GroupBox1.Location = New System.Drawing.Point(8, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 210)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Info"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 175)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Contact No."
        '
        'TxtContact_No
        '
        Me.TxtContact_No.Location = New System.Drawing.Point(124, 175)
        Me.TxtContact_No.MaxLength = 35
        Me.TxtContact_No.Name = "TxtContact_No"
        Me.TxtContact_No.Size = New System.Drawing.Size(233, 22)
        Me.TxtContact_No.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Email"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(124, 145)
        Me.TxtEmail.MaxLength = 35
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(233, 22)
        Me.TxtEmail.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Gender"
        '
        'CboGender
        '
        Me.CboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CboGender.FormattingEnabled = True
        Me.CboGender.Location = New System.Drawing.Point(124, 115)
        Me.CboGender.Name = "CboGender"
        Me.CboGender.Size = New System.Drawing.Size(125, 22)
        Me.CboGender.TabIndex = 3
        '
        'TxtLast_Name
        '
        Me.TxtLast_Name.Location = New System.Drawing.Point(124, 85)
        Me.TxtLast_Name.MaxLength = 35
        Me.TxtLast_Name.Name = "TxtLast_Name"
        Me.TxtLast_Name.Size = New System.Drawing.Size(233, 22)
        Me.TxtLast_Name.TabIndex = 2
        '
        'TxtMiddle_Name
        '
        Me.TxtMiddle_Name.Location = New System.Drawing.Point(124, 54)
        Me.TxtMiddle_Name.MaxLength = 35
        Me.TxtMiddle_Name.Name = "TxtMiddle_Name"
        Me.TxtMiddle_Name.Size = New System.Drawing.Size(233, 22)
        Me.TxtMiddle_Name.TabIndex = 1
        '
        'TxtFirst_Name
        '
        Me.TxtFirst_Name.Location = New System.Drawing.Point(124, 23)
        Me.TxtFirst_Name.MaxLength = 35
        Me.TxtFirst_Name.Name = "TxtFirst_Name"
        Me.TxtFirst_Name.Size = New System.Drawing.Size(233, 22)
        Me.TxtFirst_Name.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Middle Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Last Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "First Name"
        '
        'BtnUserChange
        '
        Me.BtnUserChange.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnUserChange.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUserChange.Location = New System.Drawing.Point(392, 177)
        Me.BtnUserChange.Name = "BtnUserChange"
        Me.BtnUserChange.Size = New System.Drawing.Size(156, 37)
        Me.BtnUserChange.TabIndex = 5
        Me.BtnUserChange.Text = "Change Credentials"
        Me.BtnUserChange.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Location = New System.Drawing.Point(6, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 34)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GrdList)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 215)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(761, 228)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Payment Methods"
        '
        'GrdList
        '
        Me.GrdList.AllowUserToAddRows = False
        Me.GrdList.AllowUserToDeleteRows = False
        Me.GrdList.AllowUserToResizeRows = False
        Me.GrdList.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.GrdList.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GrdList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrdList.Location = New System.Drawing.Point(6, 61)
        Me.GrdList.MultiSelect = False
        Me.GrdList.Name = "GrdList"
        Me.GrdList.ReadOnly = True
        Me.GrdList.RowHeadersWidth = 30
        Me.GrdList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GrdList.Size = New System.Drawing.Size(750, 161)
        Me.GrdList.TabIndex = 10
        '
        'Button3
        '
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button3.Location = New System.Drawing.Point(196, 21)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(92, 34)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Update"
        Me.Button3.UseVisualStyleBackColor = True
        Me.Button3.Visible = False
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.Location = New System.Drawing.Point(101, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(92, 34)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Update"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'FrmAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 448)
        Me.Controls.Add(Me.BtnUserChange)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customer Account"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.GrdList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtProvince As TextBox
    Friend WithEvents TxtCity As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtZip_Code As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtCountry As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtContact_No As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CboGender As ComboBox
    Friend WithEvents TxtLast_Name As TextBox
    Friend WithEvents TxtMiddle_Name As TextBox
    Friend WithEvents TxtFirst_Name As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnUserChange As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GrdList As DataGridView
End Class
