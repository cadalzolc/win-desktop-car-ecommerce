Public Class FrmAccountCred

#Region " Properties "

    Private PVT_Cred As Dictionary(Of String, String)
    Public Property Cred() As Dictionary(Of String, String)
        Get
            Return PVT_Cred
        End Get
        Set(ByVal value As Dictionary(Of String, String))
            PVT_Cred = value
        End Set
    End Property

#End Region

#Region " Events - Form "

    Private Sub FrmAccountCred_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtUsername.Text = Cred.Item("Username")
    End Sub

#End Region

#Region " Events - Button "

    Private Sub BtnConfirm_Click(sender As Object, e As EventArgs) Handles BtnConfirm.Click

        If TxtPasswordNew.Text.Equals("") Then
            Toast.Required("New password is required")
            TxtPasswordNew.Focus()
            Exit Sub
        End If

        If TxtPasswordConfirm.Text.Equals("") Then
            Toast.Required("Confirm password is required")
            TxtPasswordConfirm.Focus()
            Exit Sub
        End If

        If Not TxtPasswordNew.Text.Equals(TxtPasswordConfirm.Text) Then
            Toast.Required("Password does not matched!")
            TxtPasswordConfirm.Focus()
            Exit Sub
        End If

        If Save().Equals(False) Then Exit Sub

        Toast.Message("Credentials was successfuly updated")

        Close()
    End Sub

#End Region

#Region " Save "

    Function Save() As Boolean
        Using Con = DB.Connection
            Try

                Using Cmd = DB.Command("UPDATE Customers_Account SET [Password]=@Password WHERE ID=@ID", Con)
                    Cmd.Parameters.AddWithValue("@Password", TxtPasswordConfirm.Text)
                    Cmd.Parameters.AddWithValue("@ID", Cred.Item("ID"))
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