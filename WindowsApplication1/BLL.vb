Imports System.Data.SqlClient
Imports System.IO
Public Class BLL
    Dim c As Integer
    Public Class Login
        Shared Function Verificar_Login(ByRef user As String, ByRef pass As Byte())
            Dim sqlparams As ArrayList
            Dim data1 As DataTable
            sqlparams.Add(New SqlParameter("user", user))
            sqlparams.Add(New SqlParameter("password", pass))
            data1 = DAL.ExecuteQueryDT("select * from Utilizadores where Nome_util=@user AND Password=@password", sqlparams)
            If data1.Rows.Count <> 0 Then
                Return 1
            Else
                Return 0
            End If
        End Function
    End Class
End Class
