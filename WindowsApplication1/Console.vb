Public Class Console
    Shared Sub RunCommandCom(command As String, arguments As String, permanent As Boolean)
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.Arguments = " " + command + " " + arguments
        pi.FileName = "taskkill.exe"
        pi.WindowStyle = ProcessWindowStyle.Hidden
        p.StartInfo = pi
        p.Start()
    End Sub
End Class
