﻿Imports System.Data.SqlClient
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
            DAL.ExecuteNonQuery("Update Dispositivos set NºCliente = @NºCliente, Marca = @Marca, Modelo= @Modelo, NºSérie= @NºSérie, Observações= @Observações where NºCliente=@NºCliente", p)
        Catch e As Exception
            MsgBox("Erro ao editar os dados: " & e.Message)
        Finally
            MsgBox("Dispositivo editado com sucesso")
        End Try
    End Sub
    Shared Sub apagar(ByVal NºDispositivo As String, ByVal NºCliente As String)
        Dim p As New ArrayList
        p.Add(New SqlParameter("@NºDispositivo", NºDispositivo))
        p.Add(New SqlParameter("@NºCliente", NºCliente))
        If NºDispositivo <> "" Then
            DAL.ExecuteNonQuery("Update Dispositivos where NºDispositivo = @NºDispositivo", p)
        ElseIf NºCliente <> "" Then
            DAL.ExecuteNonQuery("Update Dispositivos where NºCliente = @NºCliente", p)
        End If
    End Sub
End Class
Public Class Reparações
    Shared Function carregar() As DataTable
        Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar,NºEmpresa From Reparações", Nothing)
        Return DAL.ExecuteQueryDT("SELECT NºHardware,NºReparação,Tipo From Hardware", Nothing)
        Return DAL.ExecuteQueryDT("SELECT NºSoftware,NºReparação,Tipo From Software", Nothing)
    End Function
    Shared Function procura_dados_numdispositivo(ByRef NºDispositivo As Integer) As DataTable
        Dim p As New ArrayList
        p.Add(New SqlParameter("@NºDispositivo", NºDispositivo))
        If NºDispositivo = "" Then
            Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar,NºEmpresa From Reparações", p)
        Else
            Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar,NºEmpresa From Reparações where NºDispositivo like @NºDispositivo", p)
        End If
    End Function
    Shared Function procura_dados_numreparação(ByRef NºReparação As Integer) As DataTable
        Dim p As New ArrayList
        p.Add(New SqlParameter("@NºReparação", NºReparação))
        If NºReparação = "" Then
            Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar,NºEmpresa From Reparações", p)
        Else
            Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar,NºEmpresa From Reparações where NºReparação=@NºReparação", p)
        End If
    End Function
    Shared Sub inserir(ByVal NºReparação As Integer, ByVal NºDispositivo As Integer, ByVal Categoria As String, ByVal NºTécnico As Integer, ByVal TempoRealReparação As String, ByVal DescAvaria As String, ByVal DIRepar As String, ByVal DFRepar As String, ByVal NºEmpresa As Integer, ByVal NºSoftware As Integer, ByVal NºHardware As Integer, ByVal tipo As String)
        Dim p As New ArrayList
        Dim s As New ArrayList
        Dim h As New ArrayList
        p.Add(New SqlParameter("@NºReparação", NºReparação))
        p.Add(New SqlParameter("@NºDispositivo", NºDispositivo))
        p.Add(New SqlParameter("@Categoria", Categoria))
        p.Add(New SqlParameter("@NºTécnico", NºTécnico))
        p.Add(New SqlParameter("@TempoRealReparação", TempoRealReparação))
        p.Add(New SqlParameter("@DescAvaria", DescAvaria))
        p.Add(New SqlParameter("@DIRepar", DIRepar))
        p.Add(New SqlParameter("@DFRepar", DFRepar))
        p.Add(New SqlParameter("@NºEmpresa", NºEmpresa))
        s.Add(New SqlParameter("@NºSoftware", NºSoftware))
        s.Add(New SqlParameter("@NºReparação", NºReparação))
        s.Add(New SqlParameter("@Tipo", tipo))
        h.Add(New SqlParameter("@NºHardware", NºHardware))
        h.Add(New SqlParameter("@NºReparação", NºReparação))
        h.Add(New SqlParameter("@Tipo", tipo))
        DAL.ExecuteNonQuery("Insert into Reparações(NºReparação,NºDispositivo,Categoria,NºTécnico,TempoRealReparação,DescAvaria,DIRepar,DFRepar,NºEmpresa) VALUES (@NºReparação, @NºDispositivo, @Categoria, @NºTécnico,@TempoRealReparação,@DIRepar,@DFRepar,@NºEmpresa)", p)
        DAL.ExecuteNonQuery("Insert into Software(NºSoftware,NºReparação,Tipo) VALUES ((Select Max(NºReparação) from Reparações),@NºSoftware,@Tipo", s)
        DAL.ExecuteNonQuery("Insert into Hardware(NºHardware,NºReparação,Tipo) VALUES ((Select Max(NºReparação) From Reparações),@NºHarware,@Tipo", h)
    End Sub
    Shared Sub alterar(ByVal NºReparação As Integer, ByVal NºDispositivo As Integer, ByVal Categoria As String, ByVal NºTécnico As Integer, ByVal TempoRealReparação As String, ByVal DescAvaria As String, ByVal DIRepar As String, ByVal DFRepar As String, ByVal NºEmpresa As Integer, ByVal NºSoftware As Integer, ByVal NºHardware As Integer, ByVal tipo As String)
        Dim p As New ArrayList
        Dim s As New ArrayList
        Dim h As New ArrayList
        p.Add(New SqlParameter("@NºReparação", NºReparação))
        p.Add(New SqlParameter("@NºDispositivo", NºDispositivo))
        p.Add(New SqlParameter("@Categoria", Categoria))
        p.Add(New SqlParameter("@NºTécnico", NºTécnico))
        p.Add(New SqlParameter("@TempoRealReparação", TempoRealReparação))
        p.Add(New SqlParameter("@DescAvaria", DescAvaria))
        p.Add(New SqlParameter("@DIRepar", DIRepar))
        p.Add(New SqlParameter("@DFRepar", DFRepar))
        p.Add(New SqlParameter("@NºEmpresa", NºEmpresa))
        s.Add(New SqlParameter("@NºSoftware", NºSoftware))
        s.Add(New SqlParameter("@NºReparação", NºReparação))
        s.Add(New SqlParameter("@Tipo", tipo))
        h.Add(New SqlParameter("@NºHardware", NºHardware))
        h.Add(New SqlParameter("@NºReparação", NºReparação))
        h.Add(New SqlParameter("@Tipo", tipo))
        Try
            DAL.ExecuteNonQuery("Update Reparações set NºDispositivo = @NºDispositivo, Categoria = @Categoria, NºTécnico= @NºTécnico, TempoRealReparação= @TempoRealReparação, DescAvaria= @DescAvaria, DIRepar = @DIRepar, DFRepar = @DFRepar, NºEmpresa = @NºEmpresa where NºReparação=@NºReparação", p)
            DAL.ExecuteNonQuery("Update Software set NºSoftware = @NºSoftware, Tipo = @Tipo where NºReparação = @NºReparação", s)
            DAL.ExecuteNonQuery("Update Hardware set NºHardware = @NºHardware, Tipo = @Tipo where NºReparação = @NºReparação", h)
        Catch e As Exception
            MsgBox("Erro ao editar os dados: " & e.Message)
        Finally
            MsgBox("Reparação editada com sucesso")
        End Try
    End Sub
    Shared Sub apagar(ByVal NºReparação As String, ByVal NºDispositivo As String)
        Dim p As New ArrayList
        p.Add(New SqlParameter("@NºReparação", NºReparação))
        p.Add(New SqlParameter("@NºDispositivo", NºDispositivo))
        If NºReparação <> "" Then
            DAL.ExecuteNonQuery("Update Reparações where NºReparação = @NºReparação", p)
        ElseIf NºDispositivo <> "" Then
            DAL.ExecuteNonQuery("Update Reparações where NºDispositivo = @NºDispositivo", p)
        End If
    End Sub
    Public Class Utilizadores
        Shared Function carregar() As DataTable
            Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, NºAluno, NºTécnico, Fotografia, Nome_Util, Password, Admin, Admin_Geral, Ativo, NºEmpresa FROM Utilizadores Where Ativo=1", Nothing)
        End Function
        Shared Function carregar_eliminados() As DataTable
            Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, NºAluno, NºTécnico, Fotografia, Nome_Util, Password, Admin, Admin_Geral, Ativo, NºEmpresa FROM Utilizadores Where Ativo=0", Nothing)
        End Function
        Shared Function procura_dados_nutilizador_desativados(ByRef Nome_Util As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@Nome_Util", Nome_Util))
            If Nome_Util = "" Then
                Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, NºAluno, NºTécnico, Fotografia, Nome_Util, Password, Admin, Admin_Geral, Ativo, NºEmpresa FROM Utilizadores Where Ativo=0", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, NºAluno, NºTécnico, Fotografia, Nome_Util, Password, Admin, Admin_Geral, Ativo, NºEmpresa FROM Utilizadores where Nome_Util like @Nome_Util AND Ativo=0", p)
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
    End Class
End Class

