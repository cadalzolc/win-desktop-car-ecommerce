Public Class App

    Shared Sub Main()

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        Dim Login As New FrmLogin()

        If Not FrmLogin.ShowDialog() = DialogResult.OK Then Exit Sub

        Application.Run(New FrmDashboard())

    End Sub

End Class