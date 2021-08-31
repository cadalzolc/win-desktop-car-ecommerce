<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cards
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cards))
        Me.BtnBuyNow = New System.Windows.Forms.Button()
        Me.LblName = New System.Windows.Forms.Label()
        Me.PicCar = New System.Windows.Forms.PictureBox()
        Me.PnlBody = New System.Windows.Forms.Panel()
        Me.TipMain = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.PicCar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlBody.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnBuyNow
        '
        Me.BtnBuyNow.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnBuyNow.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBuyNow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBuyNow.Location = New System.Drawing.Point(3, 169)
        Me.BtnBuyNow.Name = "BtnBuyNow"
        Me.BtnBuyNow.Size = New System.Drawing.Size(250, 37)
        Me.BtnBuyNow.TabIndex = 0
        Me.BtnBuyNow.TabStop = False
        Me.BtnBuyNow.Text = "Buy Now"
        Me.BtnBuyNow.UseVisualStyleBackColor = True
        '
        'LblName
        '
        Me.LblName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.Location = New System.Drawing.Point(3, 126)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(250, 43)
        Me.LblName.TabIndex = 1
        Me.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PicCar
        '
        Me.PicCar.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PicCar.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PicCar.Image = CType(resources.GetObject("PicCar.Image"), System.Drawing.Image)
        Me.PicCar.Location = New System.Drawing.Point(3, 3)
        Me.PicCar.Name = "PicCar"
        Me.PicCar.Size = New System.Drawing.Size(250, 123)
        Me.PicCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicCar.TabIndex = 2
        Me.PicCar.TabStop = False
        '
        'PnlBody
        '
        Me.PnlBody.BackColor = System.Drawing.Color.White
        Me.PnlBody.Controls.Add(Me.PicCar)
        Me.PnlBody.Controls.Add(Me.LblName)
        Me.PnlBody.Controls.Add(Me.BtnBuyNow)
        Me.PnlBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlBody.Location = New System.Drawing.Point(1, 1)
        Me.PnlBody.Name = "PnlBody"
        Me.PnlBody.Size = New System.Drawing.Size(256, 209)
        Me.PnlBody.TabIndex = 3
        '
        'Cards
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.Controls.Add(Me.PnlBody)
        Me.Name = "Cards"
        Me.Padding = New System.Windows.Forms.Padding(1)
        Me.Size = New System.Drawing.Size(258, 211)
        CType(Me.PicCar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlBody.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents BtnBuyNow As Button
    Friend WithEvents LblName As Label
    Friend WithEvents PicCar As PictureBox
    Friend WithEvents PnlBody As Panel
    Friend WithEvents TipMain As ToolTip
End Class
