Public Class FrmOrdersDialog

#Region " Properties "

    Private PVT_Order As Dictionary(Of String, String)
    Public Property Shipments() As Dictionary(Of String, String)
        Get
            Return PVT_Order
        End Get
        Set(ByVal value As Dictionary(Of String, String))
            PVT_Order = value
        End Set
    End Property

#End Region

#Region " Events - Form "

    Private Sub FrmOrdersDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtOrderNo.Text = Shipments.Item("Order_No")
        TxtOrderDate.Text = Convert.ToDateTime(Shipments.Item("Trans_Date")).ToString("MMM, dd yyyy")
        TxtProduct.Text = Shipments.Item("Product")
        dtpDate.Value = Date.Now
        TxtCustomer.Text = Shipments.Item("Customer")
        TxtAddress.Text = Shipments.Item("Address")
        TxtCity.Text = Shipments.Item("City")
        TxtProvince.Text = Shipments.Item("Province")
        TxtCountry.Text = Shipments.Item("Country")
        TxtZip_Code.Text = Shipments.Item("Zip_Code")
    End Sub

#End Region

#Region " Events - Button  "

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If IsComplete().Equals(False) Then Exit Sub

        If Save().Equals(False) Then Exit Sub

        Toast.Message("Order was successfuly updated!")

        DialogResult = DialogResult.OK
        Close()
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

#Region " Save "

    Function Save() As Boolean
        Using Con = DB.Connection
            Dim Trans = Con.BeginTransaction()
            Try

                Using Cmd = DB.Command("UPDATE Orders SET Delivered=True WHERE ID=@ID", Con, Trans)
                    Cmd.Parameters.AddWithValue("@ID", Shipments.Item("ID"))
                    Cmd.ExecuteNonQuery()
                End Using

                Using Cmd = DB.Command("UPDATE Orders_Shipment SET Stamp=@Stamp WHERE ID=@ID", Con, Trans)
                    Cmd.Parameters.AddWithValue("@Stamp", dtpDate.Value.ToString("yyyy-MM-dd"))
                    Cmd.Parameters.AddWithValue("@ID", Shipments.Item("Shipment_ID"))
                    Cmd.ExecuteNonQuery()
                End Using

                Trans.Commit()
                Return True
            Catch ex As Exception
                Trans.Rollback()
                Toast.Error(ex.Message)
                Return False
            End Try
        End Using
    End Function

#End Region

End Class