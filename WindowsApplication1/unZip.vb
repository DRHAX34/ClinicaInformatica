Imports System
Imports System.IO
Imports System.IO.Compression

Module Module1

    Sub unzip()
        Dim Dir_Temp As String = "C:\Temp\BD.zip"
        Dim extractPath As String = Environment.GetEnvironmentVariable("APPDATA") & "\Clínica Informática\BD"
        If Not System.IO.Directory.Exists("C:\Temp") Then
            System.IO.Directory.CreateDirectory("C:\Temp")
        End If
        If Not System.IO.Directory.Exists(Environment.GetEnvironmentVariable("APPDATA") & "\Clínica Informática\BD") Then
            System.IO.Directory.CreateDirectory(Environment.GetEnvironmentVariable("APPDATA") & "\Clínica Informática\BD")
        End If
        System.IO.File.WriteAllBytes(Dir_Temp, My.Resources.BD)
        Using archive As ZipArchive = ZipFile.OpenRead(Dir_Temp)
            For Each entry As ZipArchiveEntry In archive.Entries
                If entry.FullName.EndsWith(".mdf", StringComparison.OrdinalIgnoreCase) Then
                    entry.ExtractToFile(Path.Combine(extractPath, entry.FullName))
                End If
            Next
        End Using
    End Sub

End Module

