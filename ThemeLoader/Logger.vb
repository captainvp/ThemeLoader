Imports System.IO
Imports System.Windows.Forms

Public Class Logger
    Public Shared Function LogEntry(ByVal log_msg) As Boolean
        Try
            Dim fi As New FileInfo(Application.StartupPath + "\Error.log")
            Dim tw As StreamWriter = fi.AppendText()
            tw.WriteLine(DateTime.Now.ToString + ": " + log_msg)
            tw.Close()
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
