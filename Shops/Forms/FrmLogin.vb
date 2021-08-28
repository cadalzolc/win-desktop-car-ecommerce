Public Class FrmLogin

#Region " Event - Button "

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click

        If TxtUsername.Equals("") Then
            Toast.Required("Please input username!")
            Exit Sub
        End If

        If TxtPassword.Equals("") Then
            Toast.Required("Please input password!")
            Exit Sub
        End If

        If ValidateUser().Equals(False) Then Exit Sub

        DialogResult = DialogResult.OK

        Close()
    End Sub

    Private Sub BtnRegister_Click(sender As Object, e As EventArgs) Handles BtnRegister.Click
        Dim FrmReg As New FrmRegister()
        FrmReg.ShowDialog()
    End Sub

#End Region

#Region " Function - Login "

    Function ValidateUser() As Boolean
        Try
            Using Con = DB.Connection
                Using Cmd = DB.Command("SELECT * FROM Customers_Account WHERE Username=@Username AND Password=@Password", Con)
                    Cmd.Parameters.AddWithValue("@Username", TxtUsername.Text)
                    Cmd.Parameters.AddWithValue("@Password", TxtPassword.Text)
                    Cmd.ExecuteNonQuery()

                    Dim Row = DB.ToRow(Cmd)

                    If IsNothing(Row) Then
                        Toast.Message("Invalid/Username Password")
                        Return False
                    End If

                    Session.CurrentUser = New User With {
                        .Username = Row("Username"),
                        .Password = Row("Password"),
                        .ID = Row("ID")
                    }
                    Return True
                End Using
            End Using
        Catch ex As Exception
            Toast.Error(ex.Message)
            Return False
        End Try
    End Function

#End Region

End Class