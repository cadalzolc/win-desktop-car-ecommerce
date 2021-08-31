Imports System.Drawing.Imaging
Imports System.Text

Public Class FrmProductsDialog

#Region " Properties "

    Private PVT_Infos As New Dictionary(Of String, String)
    Public Property Infos() As Dictionary(Of String, String)
        Get
            Return PVT_Infos
        End Get
        Set(ByVal value As Dictionary(Of String, String))
            PVT_Infos = value
        End Set
    End Property

    Private IsUpdate As Boolean = False

    Private DT_Car As New DataTable()
    Private DT_Color As New DataTable()

#End Region

#Region " Load - Data "

    Sub LoadCombo()
        DT_Car = DB.ToData("SELECT * FROM Cars ORDER BY Name ASC")
        DT_Color = DB.ToData("SELECT * FROM Colors ORDER BY Name ASC")

        Filler.Load(CboCar, DT_Car, "Name", "ID")
        Filler.Load(CboColor, DT_Color, "Name", "ID")
    End Sub

    Sub LoadInfo()
        IsUpdate = True

        Text = String.Format("{0}-{1}", Convert.ToInt32(Infos.Item("ID")).ToString("D8"), Infos.Item("Name"))

        TxtProductNo.Text = String.Format("{0,8}", Convert.ToInt32(Infos.Item("ID")).ToString("D8"))
        TxtProductName.Text = Infos.Item("Name")
        NumStock.Value = Infos.Item("Stock")
        NumPrice.Value = Infos.Item("Price")

        CboCar.SelectedValue = Infos.Item("Car_ID")
        CboColor.SelectedValue = Infos.Item("Color_ID")

        ChkVisible.Checked = Convert.ToBoolean(Infos.Item("Visible"))

        PicCar.Image = Util.Base64Image(Infos.Item("Image"))
    End Sub

#End Region

#Region " Events - Form "

    Private Sub FrmProductsDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCombo()
        If Not Infos.Count.Equals(0) Then LoadInfo()
    End Sub

#End Region

#Region " Events - PictureBox "

    Private Sub PicCar_Click(sender As Object, e As EventArgs) Handles PicCar.Click
        Dim OFD As New OpenFileDialog With {
            .Title = "Locate Image",
            .FileName = "",
            .Filter = "Image Files|*.jpg;"
        }
        OFD.ShowDialog()
        If OFD.FileName.Equals("") Then Exit Sub
        Dim Img = Image.FromFile(OFD.FileName)
        PicCar.Image = Img
    End Sub

#End Region

#Region " Validation "

    Function IsComplete() As Boolean
        Dim Rows = Util.Controls(Me).OrderBy(Function(r) r.Control_Index).AsEnumerable()
        For Each Row In Rows
            Dim Ctl = Row.Control_Type
            Select Case TypeName(Ctl)
                Case "TextBox"
                    If Ctl.Text.Equals("") Then
                        Toast.Required(String.Format("Please input {0}", Ctl.Name.Replace("Txt", "").Replace("_", " ")))
                        Ctl.Focus()
                        Return False
                    End If
                Case "ComboBox"
                    If Ctl.Text.Equals("") Then
                        Toast.Required(String.Format("Please select {0}", Ctl.Name.Replace("Cbo", "").Replace("_", " ")))
                        Ctl.Focus()
                        Return False
                    End If
            End Select
        Next
        Return True
    End Function

#End Region

#Region " Events  - Button "

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If IsComplete().Equals(False) Then Exit Sub

        If Save().Equals(False) Then Exit Sub

        Toast.Message("Product was successfully saved.")

        DialogResult = DialogResult.OK

        Close()
    End Sub

#End Region

#Region " Save "

    Function Save() As Boolean
        Using Con = DB.Connection
            Try

                Dim Img = Util.ImageToBase64(PicCar.Image, ImageFormat.Jpeg)
                Dim Sb As New StringBuilder()

                If IsUpdate.Equals(True) Then
                    Sb.Append("UPDATE Products SET [Car_ID] = @Car_ID, [Color_ID] = @Color_ID, [Name] = @Name, [Price] = @Price, [Stock] = @Stock, [Visible] = @Visible, [Image] = @Image WHERE [ID] = @ID")
                Else
                    Sb.Append("INSERT INTO Products ([Car_ID], [Color_ID], [Name], [Price], [Stock], [Visible], [Image]) ")
                    Sb.Append("VALUES (@Car_ID, @Color_ID, @Name, @Price, @Stock, @Visible, @Image)")
                End If

                Using Cmd = DB.Command(Sb.ToString(), Con)
                    Cmd.Parameters.AddWithValue("@Car_ID", CboCar.SelectedValue)
                    Cmd.Parameters.AddWithValue("@Color_ID", CboColor.SelectedValue)
                    Cmd.Parameters.AddWithValue("@Name", TxtProductName.Text)
                    Cmd.Parameters.AddWithValue("@Price", NumPrice.Value)
                    Cmd.Parameters.AddWithValue("@Stock", NumStock.Value)
                    Cmd.Parameters.AddWithValue("@Visible", ChkVisible.Checked)
                    Cmd.Parameters.AddWithValue("@Image", Img)

                    If IsUpdate.Equals(True) Then
                        Cmd.Parameters.AddWithValue("@ID", Infos.Item("ID"))
                    End If

                    Cmd.ExecuteNonQuery()
                End Using

                Return True
            Catch ex As Exception
                Toast.Error(ex.Message)
                Return False
            End Try
        End Using
    End Function

#End Region

End Class