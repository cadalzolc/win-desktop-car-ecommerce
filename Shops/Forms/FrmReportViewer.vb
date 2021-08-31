Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class FrmReportViewer

#Region " Eevents - Form "

    Private Sub FrmReportViewer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RptViewer.ShowCloseButton = False
        RptViewer.ShowGroupTreeButton = False
        RptViewer.ShowRefreshButton = False
        RptViewer.ShowTextSearchButton = False
    End Sub

#End Region

#Region " Show Reprt "

    Public Sub ShowReport(ByVal ReportName As String, Optional Params As Dictionary(Of String, Object) = Nothing, Optional SubReportName As String = "")
        Try
            Dim ReportPath = String.Format("{0}\Reports\{1}.rpt", Application.StartupPath, ReportName)

            If Not PreviewReport(ReportPath, Params, SubReportName) Then Exit Sub

            Me.ShowDialog()
        Catch ex As Exception
            Toast.Error(ex.Message)
        End Try
    End Sub

#End Region

#Region " Preview - Reports "

    Function PreviewReport(ReportPath As String, Optional Params As Dictionary(Of String, Object) = Nothing, Optional SubReportName As String = "", Optional ReportTitle As String = "") As Boolean

        Text = IIf(ReportTitle = "", "Preview", ReportTitle)


        Dim RptDocs As New ReportDocument



        Dim crTable As Table
        Dim crTLogOnInfo As TableLogOnInfo
        Dim crConnInfo As New ConnectionInfo

        Try

            crConnInfo.DatabaseName = String.Format("Provider={0};Data Source={1};", Config.GetValue("Provider"), Config.GetValue("DB"))
            crConnInfo.UserID = ""
            crConnInfo.Password = ""
            crConnInfo.IntegratedSecurity = True

            RptDocs.Load(ReportPath)


            If Not IsNothing(Params) Then
                For Each Param In Params
                    RptDocs.SetParameterValue(Param.Key, Param.Value)
                Next
            End If


            For Each crTable In RptDocs.Database.Tables
                crTLogOnInfo = crTable.LogOnInfo
                crTLogOnInfo.ConnectionInfo = crConnInfo
                crTable.ApplyLogOnInfo(crTLogOnInfo)
            Next


            RptViewer.ReportSource = RptDocs
            RptViewer.ShowGroupTreeButton = False

            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return False
        End Try

    End Function

#End Region

End Class