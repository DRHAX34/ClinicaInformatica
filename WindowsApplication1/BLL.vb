Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging
Public Class BLL
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
    Public Class Clientes
        Shared Function carregar() As DataTable
            Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email FROM Clientes where Ativo=1", Nothing)
        End Function
        Shared Function carregar_eliminados() As DataTable
            Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email FROM Clientes where Ativo=0", Nothing)
        End Function
    End Class
    Shared Function procura_dados_nome_desativados(ByRef nome As String) As DataTable
        Dim p As New ArrayList
        p.Add(New SqlParameter("@Nome", nome))
        If nome = "" Then
            Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email FROM Clientes where Ativo=0", p)
        Else
            Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email FROM Clientes where nome like @nome AND Ativo=0", p)
        End If
    End Function
    Shared Function procura_dados_nif_desativados(ByRef nif As String) As DataTable
        Dim p As New ArrayList
        p.Add(New SqlParameter("@NIF", nif))
        If nif = "" Then
            Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email FROM Clientes where Ativo=0", p)
        Else
            Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email FROM Clientes where NIF= @NIF AND Ativo=0", p)
        End If
    End Function
    Shared Function procura_dados_numcliente(ByRef NºCliente As String) As DataTable
        Dim p As New ArrayList
        p.Add(New SqlParameter("@NºCliente", NºCliente))
        If NºCliente = "" Then
            Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email FROM Clientes where Ativo=1", p)
        Else
            Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email FROM Clientes where NºCliente=@NºCliente AND Ativo=1", p)
        End If
    End Function
    Shared Function procura_dados_numcliente_desativados(ByRef NºCliente As String) As DataTable
        Dim p As New ArrayList
        p.Add(New SqlParameter("@NºCliente", NºCliente))
        If NºCliente = "" Then
            Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email FROM Clientes where Ativo=0", p)
        Else
            Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email FROM Clientes where NºCliente=@NºCliente AND Ativo=0", p)
        End If
    End Function
    Shared Sub inserir(ByVal NIF As String, ByVal nome As String, ByVal morada As String, ByVal cod_postal As String, ByVal email As String, ByVal ativo As Boolean, ByVal contacto_mov As String, ByVal contacto_fix As String)
        Dim p As New ArrayList
        Dim c As New ArrayList
        p.Add(New SqlParameter("@Nome", nome))
        p.Add(New SqlParameter("@Morada", morada))
        p.Add(New SqlParameter("@NIF", NIF))
        p.Add(New SqlParameter("@Cod_Postal", cod_postal))
        p.Add(New SqlParameter("@Email", email))
        p.Add(New SqlParameter("@Ativo", ativo))
        c.Add(New SqlParameter("@Contacto_m", contacto_mov))
        c.Add(New SqlParameter("@Contacto_f", contacto_fix))
        DAL.ExecuteNonQuery("Insert into Clientes(Nome,Morada,NIF,Cod_Postal,Email,Ativo) VALUES (@nome, @morada, @NIF, @cod_postal,@email,1)", p)
        DAL.ExecuteNonQuery("Insert into Contactos(NºCliente,Contacto Móvel,Contacto Fixo) VALUES ((Select Max(NºCliente) from Clientes),@Contacto_m,@Contacto_f)", c)
    End Sub
    Shared Sub alterar(ByVal numcliente As Integer, ByVal NIF As String, ByVal nome As String, ByVal morada As String, ByVal cod_postal As String, ByVal email As String, ByVal ativo As Boolean, ByVal contacto_m As String, ByVal contacto_f As String)
        Dim p As New ArrayList
        Dim c As New ArrayList
        p.Add(New SqlParameter("@NºCliente", numcliente))
        p.Add(New SqlParameter("@Nome", nome))
        p.Add(New SqlParameter("@Morada", morada))
        p.Add(New SqlParameter("@NIF", NIF))
        p.Add(New SqlParameter("@Cod_Postal", cod_postal))
        p.Add(New SqlParameter("@Email", email))
        p.Add(New SqlParameter("@Ativo", ativo))
        c.Add(New SqlParameter("@Contacto_m", contacto_m))
        c.Add(New SqlParameter("@Contacto_f", contacto_f))
        c.Add(New SqlParameter("@NºCliente", numcliente))
        Try
            DAL.ExecuteNonQuery("Update Clientes set nome = @nome, morada = @morada, NIF= @NIF, Cod_Postal= @cod_postal, Email= @email where NºCliente=@numcliente", p)
            DAL.ExecuteNonQuery("Update Contactos set Contacto Móvel = @contacto_m, Contacto Fixo = @contacto_f where NºCliente = @numcliente", c)
        Catch e As Exception
            MsgBox("Erro ao editar os dados: " & e.Message)
        Finally
            MsgBox("Cliente editado com sucesso")
        End Try
    End Sub
    Shared Sub apagar(ByVal NºCliente As String, ByVal NIF As String)
        Dim p As New ArrayList
        p.Add(New SqlParameter("@NIF", NIF))
        p.Add(New SqlParameter("@NºCliente", NºCliente))
        If NIF <> "" Then
            DAL.ExecuteNonQuery("Update Clientes set Ativo=0 where NIF = @NIF", p)
        ElseIf NºCliente <> "" Then
            DAL.ExecuteNonQuery("Update Clientes set Ativo=0 where NºCliente = @NºCliente", p)
        End If
    End Sub
End Class
Public Class Dispositivos
    Shared Function carregar() As DataTable
        Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie, Observações FROM Dispositivos", Nothing)
    End Function
    Shared Function procura_dados_numdispositivo(ByRef NºDispositivo As String) As DataTable
        Dim p As New ArrayList
        p.Add(New SqlParameter("@NºDispositivo", NºDispositivo))
        If NºDispositivo = "" Then
            Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie,Observações FROM Dispositivos", p)
        Else
            Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie,Observações FROM Dispositivos where NºDispositivo like @NºDispositivo", p)
        End If
    End Function
    Shared Function procura_dados_numcliente(ByRef NºCliente As String) As DataTable
        Dim p As New ArrayList
        p.Add(New SqlParameter("@NºCliente", NºCliente))
        If NºCliente = "" Then
            Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie,Observações FROM Dispositivos", p)
        Else
            Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie,Observações FROM Dispositivos where NºCliente=@NºCliente", p)
        End If
    End Function
    Shared Sub inserir(ByVal NºCliente As Integer, ByVal Marca As String, ByVal Modelo As String, ByVal NºSérie As Integer, ByVal Observações As String)
        Dim p As New ArrayList
        p.Add(New SqlParameter("@NºCliente", NºCliente))
        p.Add(New SqlParameter("@Marca", Marca))
        p.Add(New SqlParameter("@Modelo", Modelo))
        p.Add(New SqlParameter("@NºSérie", NºSérie))
        p.Add(New SqlParameter("@Observações", Observações))
        DAL.ExecuteNonQuery("Insert into Dispositivos(NºCliente,Marca,Modelo,NºSérie,Observações) VALUES (@NºCliente, @Marca, @Modelo, @NºSérie,@Observações)", p)
    End Sub
    Shared Sub alterar(ByVal NºCliente As String, ByVal Marca As String, ByVal Modelo As String, ByVal NºSérie As Integer, ByVal Observações As String)
        Dim p As New ArrayList
        p.Add(New SqlParameter("@NºCliente", NºCliente))
        p.Add(New SqlParameter("@Marca", Marca))
        p.Add(New SqlParameter("@Modelo", Modelo))
        p.Add(New SqlParameter("@NºSérie", NºSérie))
        p.Add(New SqlParameter("@Observações", Observações))
        Try
            DAL.ExecuteNonQuery("Update Dispositivos set NºCliente = @NºCliente, Marca = @Marca, Modelo= @Modelo, Cod_Postal= @cod_postal, Email= @email where NºCliente=@numcliente", p)
        Catch e As Exception
            MsgBox("Erro ao editar os dados: " & e.Message)
        Finally
            MsgBox("Dispositivo editado com sucesso")
        End Try
    End Sub
    Shared Sub apagar(ByVal NºCliente As String, ByVal NIF As String)
        Dim p As New ArrayList
        p.Add(New SqlParameter("@NIF", NIF))
        p.Add(New SqlParameter("@NºCliente", NºCliente))
        If NIF <> "" Then
            DAL.ExecuteNonQuery("Update Clientes set Ativo=0 where NIF = @NIF", p)
        ElseIf NºCliente <> "" Then
            DAL.ExecuteNonQuery("Update Clientes set Ativo=0 where NºCliente = @NºCliente", p)
        End If
    End Sub
End Class
