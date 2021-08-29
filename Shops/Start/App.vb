Imports System.Drawing.Imaging

Public Class App

    Shared Sub Main()

        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)

        If Not FrmLogin.ShowDialog() = DialogResult.OK Then Exit Sub

        Application.Run(New FrmShop())

    End Sub

End Class