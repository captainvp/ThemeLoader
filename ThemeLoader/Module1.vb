Imports System.Diagnostics

Module Module1

    Sub Main()
        Try
            Dim pr As Process = Process.Start(My.Settings.THEME_FILE)
            Threading.Thread.Sleep(1000)
            Try
                Dim p As Process() = Process.GetProcessesByName("SystemSettings")
                For i = 0 To p.Length - 1
                    p(i).Kill()
                Next
            Catch ex As Exception
                Logger.LogEntry(ex.Message + vbCrLf + ex.StackTrace)
            End Try
        Catch ex As Exception
            Logger.LogEntry(ex.Message + vbCrLf + ex.StackTrace)
        End Try

    End Sub

End Module
