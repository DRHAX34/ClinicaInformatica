Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class BLL
    Dim c As Integer
    Public Class Login
        Shared Function Verificar_Login(ByRef user As String, ByRef pass As String)
            Dim sqlparams As New ArrayList
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

        Shared Sub Add_login(ByVal img As Image, ByRef num_tecnico As Integer, ByRef num_aluno As Integer, ByRef user As String, ByRef pass As String)
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_aluno", num_aluno))
            p.Add(New SqlParameter("n_tecnico", num_tecnico))
            p.Add(New SqlParameter("fotografia", SqlDbType.Image))
            Dim mStream As MemoryStream = New MemoryStream()
            img.Save(mStream, ImageFormat.Png)
            p(3).SqlValue = mStream.GetBuffer
            p.Add(New SqlParameter("user", user))
            p.Add(New SqlParameter("password", pass))
            DAL.ExecuteNonQuery("Insert into Utilizadores(NºAluno,MºTécnico,Fotografia,Nome_Util,Password,Admin,Ativo) VALUES (@n_aluno, @n_tecnico, @fotografia, @user,@pass,@admin,1)", p)
        End Sub
    End Class
End Class
