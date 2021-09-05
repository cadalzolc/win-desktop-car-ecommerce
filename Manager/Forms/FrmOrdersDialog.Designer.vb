<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmOrdersDialog
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
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtOrderNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtOrderDate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtProduct = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TxtCity = New System.Windows.Forms.TextBox()
        Me.TxtCustomer = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtProvince = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCountry = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtZip_Code = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(196, 367)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(105, 35)
        Me.BtnSave.TabIndex = 2
        Me.BtnSave.Text = "Confirm Delivery"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TxtProduct)
        Me.GroupBox1.Controls.Add(Me.TxtOrderNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtOrderDate)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 121)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Order Details"
        '
        'TxtOrderNo
        '
        Me.TxtOrderNo.Location = New System.Drawing.Point(121, 26)
        Me.TxtOrderNo.Name = "TxtOrderNo"
        Me.TxtOrderNo.ReadOnly = True
        Me.TxtOrderNo.Size = New System.Drawing.Size(154, 20)
        Me.TxtOrderNo.TabIndex = 0
        Me.TxtOrderNo.TabStop = False
        Me.TxtOrderNo.Text = "AUTO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Order No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Order Date"
        '
        'TxtOrderDate
        '
        Me.TxtOrderDate.AccessibleDescription = "Required"
        Me.TxtOrderDate.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtOrderDate.Location = New System.Drawing.Point(121, 53)
        Me.TxtOrderDate.Name = "TxtOrderDate"
        Me.TxtOrderDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtOrderDate.Size = New System.Drawing.Size(154, 20)
        Me.TxtOrderDate.TabIndex = 1
        Me.TxtOrderDate.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Product"
        '
        'TxtProduct
        '
        Me.TxtProduct.AccessibleDescription = "Required"
        Me.TxtProduct.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtProduct.Location = New System.Drawing.Point(121, 79)
        Me.TxtProduct.Name = "TxtProduct"
        Me.TxtProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtProduct.Size = New System.Drawing.Size(154, 20)
        Me.TxtProduct.TabIndex = 2
        Me.TxtProduct.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpDate)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.TxtZip_Code)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.TxtCountry)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.TxtProvince)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.TxtCity)
        Me.GroupBox2.Controls.Add(Me.TxtCustomer)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtAddress)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 139)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(290, 222)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Shipment Details"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 14)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "City"
        '
        'TxtCity
        '
        Me.TxtCity.AccessibleDescription = "Required"
        Me.TxtCity.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtCity.Location = New System.Drawing.Point(121, 112)
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtCity.Size = New System.Drawing.Size(154, 20)
        Me.TxtCity.TabIndex = 3
        '
        'TxtCustomer
        '
        Me.TxtCustomer.Location = New System.Drawing.Point(121, 59)
        Me.TxtCustomer.Name = "TxtCustomer"
        Me.TxtCustomer.ReadOnly = True
        Me.TxtCustomer.Size = New System.Drawing.Size(154, 20)
        Me.TxtCustomer.TabIndex = 1
        Me.TxtCustomer.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(15, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(66, 14)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Customer"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(15, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 14)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Address"
        '
        'TxtAddress
        '
        Me.TxtAddress.AccessibleDescription = "Required"
        Me.TxtAddress.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtAddress.Location = New System.Drawing.Point(121, 86)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtAddress.Size = New System.Drawing.Size(154, 20)
        Me.TxtAddress.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 14)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Povince"
        '
        'TxtProvince
        '
        Me.TxtProvince.AccessibleDescription = "Required"
        Me.TxtProvince.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtProvince.Location = New System.Drawing.Point(121, 138)
        Me.TxtProvince.Name = "TxtProvince"
        Me.TxtProvince.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtProvince.Size = New System.Drawing.Size(154, 20)
        Me.TxtProvince.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 164)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 14)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Country"
        '
        'TxtCountry
        '
        Me.TxtCountry.AccessibleDescription = "Required"
        Me.TxtCountry.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtCountry.Location = New System.Drawing.Point(121, 164)
        Me.TxtCountry.Name = "TxtCountry"
        Me.TxtCountry.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtCountry.Size = New System.Drawing.Size(154, 20)
        Me.TxtCountry.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(15, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 14)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Zip Code"
        '
        'TxtZip_Code
        '
        Me.TxtZip_Code.AccessibleDescription = "Required"
        Me.TxtZip_Code.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtZip_Code.Location = New System.Drawing.Point(121, 190)
        Me.TxtZip_Code.Name = "TxtZip_Code"
        Me.TxtZip_Code.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TxtZip_Code.Size = New System.Drawing.Size(154, 20)
        Me.TxtZip_Code.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(15, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(36, 14)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Date"
        '
        'dtpDate
        '
        Me.dtpDate.CustomFormat = "yyyy-MM-dd"
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDate.Location = New System.Drawing.Point(121, 33)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(154, 20)
        Me.dtpDate.TabIndex = 0
        '
        'FrmOrdersDialog
        '
        Me.AcceptButton = Me.BtnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(313, 412)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmOrdersDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Order Delivery"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnSave As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtProduct As TextBox
    Friend WithEvents TxtOrderNo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtOrderDate As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TxtZip_Code As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TxtCountry As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TxtProvince As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtCity As TextBox
    Friend WithEvents TxtCustomer As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtAddress As TextBox
End Class
