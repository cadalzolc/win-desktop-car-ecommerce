Public Class App

    Shared Sub Main()

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        'Dim Login As New FrmLogin()

        'If Not FrmLogin.ShowDialog() = DialogResult.OK Then Exit Sub

        Session.CurrentUser = New User With {
            .Username = "admin",
            .Password = "admin",
            .ID = 1
        }

        Application.Run(New FrmDashboard())

    End Sub

End Class