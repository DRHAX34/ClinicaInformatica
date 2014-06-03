Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging

Public Class BLL
    Public Shared n_empresa As String
    Public Class Admin_only
        Shared Sub eliminar_empresa(ByVal nempresa As Integer)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_empresa", nempresa))
            DAL.ExecuteNonQuery("Delete FROM Utilizadores where NºEmpresa=@n_empresa", p)
            DAL.ExecuteNonQuery("Delete FROM Tecnicos where NºEmpresa=@n_empresa", p)
            DAL.ExecuteNonQuery("Delete FROM Cliente where NºEmpresa=@n_empresa", p)
            DAL.ExecuteNonQuery("Delete FROM Dispositivos where NºEmpresa=@n_empresa", p)
            DAL.ExecuteNonQuery("Delete FROM Reparações where NºEmpresa=@n_empresa", p)
            DAL.ExecuteNonQuery("Delete FROM Empresas where NºEmpresa=@n_empresa", p)
        End Sub
        Public Class Cliente
            Public Class Alunos
                Shared Function carregar() As DataTable
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where Ativo=1", Nothing)
                End Function
                Shared Function carregar_eliminados() As DataTable
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,NºEmpresa,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where Ativo=0", Nothing)
                End Function
                Shared Function procura_dados_nome(ByRef nome As String) As DataTable
                    Dim p As New ArrayList
                    p.Add(New SqlParameter("@Nome", nome))
                    If nome = "" Then
                        Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where Ativo=1", p)
                    Else
                        Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where nome like @nome AND Ativo=1", p)
                    End If
                End Function
                Shared Function procura_dados_nome_desativados(ByRef nome As String) As DataTable
                    Dim p As New ArrayList
                    p.Add(New SqlParameter("@Nome", nome))
                    If nome = "" Then
                        Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,NºEmpresa,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where Ativo=0", p)
                    Else
                        Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,NºEmpresa,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where nome like @nome AND Ativo=0", p)
                    End If
                End Function
                Shared Function procura_dados_nif(ByRef nif As String) As DataTable
                    Dim p As New ArrayList
                    p.Add(New SqlParameter("@NIF", nif))
                    If nif = "" Then
                        Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where Ativo=1", p)
                    Else
                        Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where NIF= @NIF AND Ativo=1", p)
                    End If
                End Function
                Shared Function procura_dados_nif_desativados(ByRef nif As String) As DataTable
                    Dim p As New ArrayList
                    p.Add(New SqlParameter("@NIF", nif))
                    If nif = "" Then
                        Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where Ativo=0", p)
                    Else
                        Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where NIF like @NIF AND Ativo=0", p)
                    End If
                End Function
                Shared Function procura_dados_numcliente(ByRef num_cliente As String) As DataTable
                    Dim p As New ArrayList
                    p.Add(New SqlParameter("@NºCliente", num_cliente))
                    If num_cliente = "" Then
                        Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where Ativo=1", p)
                    Else
                        Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where NºCliente=@NºCliente AND Ativo=1", p)
                    End If
                End Function
                Shared Function procura_dados_numcliente_desativados(ByRef num_cliente As String) As DataTable
                    Dim p As New ArrayList
                    p.Add(New SqlParameter("@NºCliente", num_cliente))
                    If num_cliente = "" Then
                        Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where Ativo=0", p)
                    Else
                        Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where NºCliente=@NºCliente AND Ativo=0", p)
                    End If
                End Function
                Shared Function procura_dados_nempresa(ByRef empresa As String) As DataTable
                    Dim p As New ArrayList
                    p.Add(New SqlParameter("@NºEmpresa", empresa))
                    If n_empresa = "" Then
                        Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where Ativo=1", p)
                    Else
                        Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where NºEmpresa=@Empresa AND Ativo=1", p)
                    End If
                End Function
                Shared Function procura_dados_nempresa_desativados(ByRef empresa As String) As DataTable
                    Dim p As New ArrayList
                    p.Add(New SqlParameter("@NºEmpresa", empresa))
                    If n_empresa = "" Then
                        Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where Ativo=0", p)
                    Else
                        Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where NºEmpresa=@Empresa AND Ativo=0", p)
                    End If
                End Function
            End Class
            Shared Function carregar() As DataTable
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,Contacto Móvel,Contacto Fixo FROM Clientes where Ativo=1", Nothing)
            End Function
            Shared Function carregar_eliminados() As DataTable
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,NºEmpresa,Contacto Móvel,Contacto Fixo FROM Clientes where Ativo=0", Nothing)
            End Function
            Shared Function procura_dados_nome(ByRef nome As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@Nome", nome))
                If nome = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,Contacto Móvel,Contacto Fixo FROM Clientes where Ativo=1", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,Contacto Móvel,Contacto Fixo FROM Clientes where nome like @nome AND Ativo=1", p)
                End If
            End Function
            Shared Function procura_dados_nome_desativados(ByRef nome As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@Nome", nome))
                If nome = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,NºEmpresa,Contacto Móvel,Contacto Fixo FROM Clientes where Ativo=0", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,NºEmpresa,Contacto Móvel,Contacto Fixo FROM Clientes where nome like @nome AND Ativo=0", p)
                End If
            End Function
            Shared Function procura_dados_nif(ByRef nif As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@NIF", nif))
                If nif = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa,Contacto Móvel,Contacto Fixo FROM Clientes where Ativo=1", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa,Contacto Móvel,Contacto Fixo FROM Clientes where NIF= @NIF AND Ativo=1", p)
                End If
            End Function
            Shared Function procura_dados_nif_desativados(ByRef nif As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@NIF", nif))
                If nif = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa,Contacto Móvel,Contacto Fixo FROM Clientes where Ativo=0", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa,Contacto Móvel,Contacto Fixo FROM Clientes where NIF like @NIF AND Ativo=0", p)
                End If
            End Function
            Shared Function procura_dados_numcliente(ByRef num_cliente As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@NºCliente", num_cliente))
                If num_cliente = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa,Contacto Móvel,Contacto Fixo FROM Clientes where Ativo=1", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa,Contacto Móvel,Contacto Fixo FROM Clientes where NºCliente=@NºCliente AND Ativo=1", p)
                End If
            End Function
            Shared Function procura_dados_numcliente_desativados(ByRef num_cliente As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@NºCliente", num_cliente))
                If num_cliente = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa,Contacto Móvel,Contacto Fixo FROM Clientes where Ativo=0", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa,Contacto Móvel,Contacto Fixo FROM Clientes where NºCliente=@NºCliente AND Ativo=0", p)
                End If
            End Function
            Shared Function procura_dados_nempresa(ByRef empresa As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@NºEmpresa", empresa))
                If n_empresa = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa,Contacto Móvel,Contacto Fixo FROM Clientes where Ativo=1", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa,Contacto Móvel,Contacto Fixo FROM Clientes where NºEmpresa=@Empresa AND Ativo=1", p)
                End If
            End Function
            Shared Function procura_dados_nempresa_desativados(ByRef empresa As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@NºEmpresa", empresa))
                If n_empresa = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa,Contacto Móvel,Contacto Fixo FROM Clientes where Ativo=0", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa,Contacto Móvel,Contacto Fixo FROM Clientes where NºEmpresa=@Empresa AND Ativo=0", p)
                End If
            End Function
        End Class
        Public Class Login
            Shared Function procura_dados_nutilizador_desativados(ByRef Nome_Util As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@Nome_Util", Nome_Util))
                If Nome_Util = "" Then
                    Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, NºAluno, NºTécnico, Nome_Util, Password, Admin, Admin_Geral, Ativo, NºEmpresa FROM Utilizadores Where Ativo=0", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, NºAluno, NºTécnico, Nome_Util, Password, Admin, Admin_Geral, Ativo, NºEmpresa FROM Utilizadores where Nome_Util like @Nome_Util AND Ativo=0", p)
                End If
            End Function
            Shared Function procura_dados_nutilizador_ativados(ByRef Nome_Util As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@Nome_Util", Nome_Util))
                If Nome_Util = "" Then
                    Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, NºAluno, NºTécnico, Nome_Util, Password, Admin, Admin_Geral, Ativo, NºEmpresa FROM Utilizadores Where Ativo=1", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, NºAluno, NºTécnico, Nome_Util, Password, Admin, Admin_Geral, Ativo, NºEmpresa FROM Utilizadores where Nome_Util like @Nome_Util AND Ativo=1", p)
                End If
            End Function
            Shared Function procura_dados_codutilizador_desativados(ByRef Cod_Utilizador As Integer) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@Cod_Utilizador", Cod_Utilizador))
                If Cod_Utilizador = "" Then
                    Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, NºAluno, NºTécnico, Nome_Util, Password, Admin, Admin_Geral, Ativo, NºEmpresa FROM Utilizadores Where Ativo=0", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, NºAluno, NºTécnico, Nome_Util, Password, Admin, Admin_Geral, Ativo, NºEmpresa FROM Utilizadores where Cod_Utilizador= @Cod_Utilizador AND Ativo=0", p)
                End If
            End Function
            Shared Function procura_dados_codutilizador_ativados(ByRef Cod_Utilizador As Integer) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@Cod_Utilizador", Cod_Utilizador))
                If Cod_Utilizador = "" Then
                    Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, NºAluno, NºTécnico, Nome_Util, Password, Admin, Admin_Geral, Ativo, NºEmpresa FROM Utilizadores Where Ativo=1", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, NºAluno, NºTécnico, Nome_Util, Password, Admin, Admin_Geral, Ativo, NºEmpresa FROM Utilizadores where Cod_Utilizador= @Cod_Utilizador AND Ativo=1", p)
                End If
            End Function
            Shared Function procura_dados_naluno_desativados(ByRef NºAluno As Integer) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@NºAluno", NºAluno))
                If NºAluno = "" Then
                    Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, NºAluno, NºTécnico, Nome_Util, Password, Admin, Admin_Geral, Ativo, NºEmpresa FROM Utilizadores where Ativo=0", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, NºAluno, NºTécnico, Nome_Util, Password, Admin, Admin_Geral, Ativo, NºEmpresa FROM Utilizadores where NºAluno=@NºAluno AND Ativo=0", p)
                End If
            End Function
            Shared Function procura_dados_naluno_ativados(ByRef NºAluno As Integer) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@NºAluno", NºAluno))
                If NºAluno = "" Then
                    Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, NºAluno, NºTécnico, Nome_Util, Password, Admin, Admin_Geral, Ativo, NºEmpresa FROM Utilizadores where Ativo=1", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, NºAluno, NºTécnico, Nome_Util, Password, Admin, Admin_Geral, Ativo, NºEmpresa FROM Utilizadores where NºAluno=@NºAluno AND Ativo=1", p)
                End If
            End Function
            Shared Function carregar_users() As DataTable
                Return DAL.ExecuteQueryDT("SELECT NºAluno,MºTécnico,Nome_Util,Password,Admin,NºEmpresa FROM Clientes where Ativo=1", Nothing)
            End Function
            Shared Function carregar_users_eliminados() As DataTable
                Return DAL.ExecuteQueryDT("SELECT NºAluno,MºTécnico,Nome_Util,Password,Admin,NºEmpresa FROM Clientes where Ativo=0", Nothing)
            End Function
            Shared Function carregar_users_empresa(ByRef empresa As Integer) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("n_empresa", empresa))
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email FROM Clientes where Ativo=1 AND NºEmpresa=@n_empresa", p)
            End Function
            Shared Function carregar_users_eliminados_empresa(ByRef empresa As Integer) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("n_empresa", empresa))
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email FROM Clientes where Ativo=0 AND NºEmpresa=@n_empresa", p)
            End Function
            Shared Function Add_login(ByVal admin_geral As Boolean, ByVal admin As Boolean, ByRef user As String, ByRef pass As String)
                Dim p As New ArrayList
                p.Add(New SqlParameter("@user", user))
                p.Add(New SqlParameter("@password", pass))
                p.Add(New SqlParameter("@admin", admin))
                p.Add(New SqlParameter("@admin_geral", admin_geral))
                Return DAL.ExecuteNonQuery("Insert into Utilizadores(Nome_Util,Password,Admin_Geral,Admin,Ativo) VALUES (@user,@password,@Admin_Geral,@admin,1)", p)
            End Function
            Shared Function remove_login_empresa(ByVal empresa As String)
                Dim p As ArrayList
                p.Add(New SqlParameter("n_empresa", empresa))
                Return DAL.ExecuteNonQuery("Delete From Utilizadores where NºEmpresa=@n_empresa", p)
            End Function
            Shared Function Verificar_Login_admin(ByRef user As String, ByRef pass As String) As Integer
                Dim sqlparams As New ArrayList
                sqlparams.Add(New SqlParameter("@user", user))
                sqlparams.Add(New SqlParameter("@password", pass))
                Return DAL.ExecuteScalar("select Cod_Utilizador from Utilizadores where Nome_util=@user AND Password=@password AND Admin_Geral=1", sqlparams)
            End Function
        End Class
        Public Class Dispositivos
            Shared Function carregar() As DataTable
                Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie, Observações FROM Dispositivos where Ativo=1", Nothing)
            End Function
            Shared Function carregar_desativos() As DataTable
                Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie, Observações FROM Dispositivos where Ativo=1", Nothing)
            End Function
            Shared Function procura_dados_numdispositivo_desativo(ByRef NºDispositivo As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@n_dispositivo", NºDispositivo))
                If NºDispositivo = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie,Observações FROM Dispositivos where Ativo=0", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie,Observações FROM Dispositivos where NºDispositivo like @n_dispositivo AND Ativo=0", p)
                End If
            End Function
            Shared Function procura_dados_numdispositivo(ByRef NºDispositivo As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@n_dispositivo", NºDispositivo))
                If NºDispositivo = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie,Observações FROM Dispositivos where Ativo=1", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie,Observações FROM Dispositivos where NºDispositivo like @n_dispositivo AND Ativo=1", p)
                End If
            End Function
            Shared Function procura_dados_numcliente(ByRef NºCliente As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@NºCliente", NºCliente))
                If NºCliente = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie,Observações FROM Dispositivos where Ativo=1", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie,Observações FROM Dispositivos where NºCliente=@NºCliente AND Ativo=1", p)
                End If
            End Function
            Shared Function procura_dados_numcliente_desativo(ByRef NºCliente As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@NºCliente", NºCliente))
                If NºCliente = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie,Observações FROM Dispositivos where Ativo=0", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie,Observações FROM Dispositivos where NºCliente=@NºCliente AND Ativo=0", p)
                End If
            End Function
            Shared Function procura_dados_nempresa_desativo(ByRef nempresa As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@n_empresa", nempresa))
                If nempresa = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie,Observações FROM Dispositivos where Ativo=0", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie,Observações FROM Dispositivos where NºEmpresa=@n_empresa AND Ativo=0", p)
                End If
            End Function
            Shared Function procura_dados_nempresa(ByRef nempresa As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@n_empresa", nempresa))
                If nempresa = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie,Observações FROM Dispositivos where Ativo=1", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie,Observações FROM Dispositivos where NºEmpresa=@n_empresa AND Ativo=1", p)
                End If
            End Function
        End Class
        Public Class Reparacoes
            Shared Function carregar() As DataTable
                Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar From Reparações where Ativo=1", Nothing)
            End Function
            Shared Function carregar_desativos() As DataTable
                Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar From Reparações where Ativo=0", Nothing)
            End Function
            Shared Function procura_dados_numdispositivo(ByRef NºDispositivo As Integer) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@n_dispositivo", NºDispositivo))
                If NºDispositivo = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar,NºEmpresa From Reparações where Ativo=1", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar,NºEmpresa From Reparações where NºDispositivo like @n_dispositivo AND Ativo=1", p)
                End If
            End Function
            Shared Function procura_dados_numdispositivo_desativo(ByRef NºDispositivo As Integer) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@n_dispositivo", NºDispositivo))
                If NºDispositivo = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar,NºEmpresa From Reparações where AND Ativo=0", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar,NºEmpresa From Reparações where NºDispositivo like @n_dispositivo AND Ativo=0", p)
                End If
            End Function
            Shared Function procura_dados_numreparação(ByRef NºReparação As Integer) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@n_reparação", NºReparação))
                If NºReparação = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar From Reparações where Ativo=1", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar From Reparações where NºReparação=@n_reparação AND Ativo=1", p)
                End If
            End Function
            Shared Function procura_dados_numreparação_desativo(ByRef NºReparação As Integer) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@n_reparação", NºReparação))
                If NºReparação = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar From Reparações where Ativo=0", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar From Reparações where NºReparação=@n_reparação AND Ativo=0", p)
                End If
            End Function
            Shared Function procura_dados_numempresa_desativo(ByRef nempresa As Integer) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@n_empresa", nempresa))
                If nempresa = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar From Reparações where Ativo=0", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar From Reparações where NºEmpresa=@n_empresa AND Ativo=0", p)
                End If
            End Function
            Shared Function procura_dados_numempresa(ByRef nempresa As Integer) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@n_empresa", nempresa))
                If nempresa = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar From Reparações where Ativo=1", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar From Reparações where NºEmpresa=@n_empresa AND Ativo=1", p)
                End If
            End Function
        End Class
        Public Class Empresas
            Shared Function carregar_pic(ByVal empresa As Integer) As Object
                Return DAL.Load_Pic_Sql("Select Logo FROM Empresas where NºEmpresa=" & empresa)
            End Function
            Shared Function carregar_max() As Integer
                Return DAL.ExecuteScalar("Select Max(NºEmpresa) FROM Empresas", Nothing)
            End Function
            Shared Function carregar() As DataTable
                Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade FROM Empresas where Ativo=1", Nothing)
            End Function
            Shared Function carregar_eliminados() As DataTable
                Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade FROM Empresas where Ativo=0", Nothing)
            End Function
            Shared Function procura_dados_Nome_desativados(ByRef Nome As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@Nome", Nome))
                If Nome = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade FROM Empresas where Ativo=0", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade FROM Empresas where Nome like @Nome AND Ativo=0", p)
                End If
            End Function
            Shared Function procura_dados_Nome_ativados(ByRef Nome As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@Nome", Nome))
                If Nome = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade FROM Empresas where Ativo=1", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade FROM Empresas where Nome like @Nome AND Ativo=1", p)
                End If
            End Function
            Shared Function procura_dados_nif_desativados(ByRef NIF As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@NIF", NIF))
                If NIF = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade FROM Empresas where Ativo=0", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade FROM Empresas where NIF= @NIF AND Ativo=0", p)
                End If
            End Function
            Shared Function procura_dados_nif_ativados(ByRef NIF As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@NIF", NIF))
                If NIF = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade FROM Empresas where Ativo=1", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade FROM Empresas where NIF= @NIF AND Ativo=1", p)
                End If
            End Function
            Shared Function procura_dados_numempresa_desativados(ByRef n_empresa As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@n_empresa", n_empresa))
                If n_empresa = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade FROM Empresas where Ativo=0", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade FROM Empresas where NºEmpresa=@n_empresa AND Ativo=0", p)
                End If
            End Function
            Shared Function procura_dados_numempresa(ByRef n_empresa As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@n_empresa", n_empresa))
                If n_empresa = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade FROM Empresas where Ativo=1", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade FROM Empresas where NºEmpresa=@n_empresa AND Ativo=1", p)
                End If
            End Function
            Shared Sub inserir(ByVal Nome As String, ByVal Morada As String, ByVal NIF As String, ByVal Cod_Postal As String, ByVal Localidade As String, ByVal Logo As Image, ByVal Ativo As Boolean)
                Dim p As New ArrayList
                Dim img_save As New SqlParameter("@img", SqlDbType.Image)
                p.Add(New SqlParameter("@Nome", Nome))
                p.Add(New SqlParameter("@Morada", Morada))
                p.Add(New SqlParameter("@NIF", NIF))
                p.Add(New SqlParameter("@Cod_Postal", Cod_Postal))
                p.Add(New SqlParameter("@Localidade", Localidade))
                Dim mStream As MemoryStream = New MemoryStream()
                Logo.Save(mStream, ImageFormat.Png)
                img_save.SqlValue = mStream.GetBuffer
                p.Add(img_save)
                p.Add(New SqlParameter("@Ativo", Ativo))
                DAL.ExecuteNonQuery("Insert into Empresas(Nome,Morada,NIF,Cod_Postal,Localidade,Logo,Ativo) VALUES (@nome, @morada, @NIF, @cod_postal,@Localidade,@img,1)", p)
            End Sub
            Shared Sub alterar(ByVal NºEmpresa As Integer, ByVal Nome As String, ByVal Morada As String, ByVal NIF As String, ByVal Cod_Postal As String, ByVal Localidade As String, ByVal Logo As Image, ByVal ativo As Boolean)
                Dim p As New ArrayList
                Dim img_save As New SqlParameter("@Logo", SqlDbType.Image)
                p.Add(New SqlParameter("@Nome", Nome))
                p.Add(New SqlParameter("@Morada", Morada))
                p.Add(New SqlParameter("@NIF", NIF))
                p.Add(New SqlParameter("@Cod_Postal", Cod_Postal))
                p.Add(New SqlParameter("@Localidade", Localidade))
                Dim mStream As MemoryStream = New MemoryStream()
                Logo.Save(mStream, ImageFormat.Png)
                img_save.SqlValue = mStream.GetBuffer
                p.Add(img_save)
                p.Add(New SqlParameter("@Ativo", ativo))
                Try
                    DAL.ExecuteNonQuery("Update Empresas set Nome = @Nome, Norada = @Norada, NIF= @NIF, Cod_Postal= @Cod_Postal, Localidade= @Localidade, Logo= @Logo, Ativo= @Ativo where NºEmpresa=@NºEmpresa", p)
                Catch e As Exception
                    MsgBox("Erro ao editar os dados: " & e.Message)
                Finally
                    MsgBox("Empresa editada com sucesso")
                End Try
            End Sub
            Shared Sub apagar(ByVal NºEmpresa As String, ByVal NIF As String)
                Dim p As New ArrayList
                p.Add(New SqlParameter("@NIF", NIF))
                p.Add(New SqlParameter("@NºEmpresa", NºEmpresa))
                If NIF <> "" Then
                    DAL.ExecuteNonQuery("Update Empresas set Ativo=0 where NIF = @NIF", p)
                ElseIf NºEmpresa <> "" Then
                    DAL.ExecuteNonQuery("Update Empresas set Ativo=0 where NºEmpresa = @NºEmpresa", p)
                End If
            End Sub
        End Class
        Public Class Tecnicos
            Public Class alunos
                Shared Function carregar() As DataTable
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicos where Ativo=1", Nothing)
                End Function
                Shared Function carregar_eliminados() As DataTable
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicos where Ativo=0", Nothing)
                End Function
                Shared Function procura_dados_Nome_desativados(ByRef Nome As String) As DataTable
                    Dim p As New ArrayList
                    p.Add(New SqlParameter("@Nome", Nome))
                    If Nome = "" Then
                        Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicos where Ativo=0", p)
                    Else
                        Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicos where Nome like @Nome AND Ativo=0", p)
                    End If
                End Function
                Shared Function procura_dados_Nome_ativados(ByRef Nome As String) As DataTable
                    Dim p As New ArrayList
                    p.Add(New SqlParameter("@Nome", Nome))
                    If Nome = "" Then
                        Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicos where Ativo=1", p)
                    Else
                        Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicoswhere Nome like @Nome AND Ativo=1", p)
                    End If
                End Function
                Shared Function procura_dados_naluno_desativados(ByRef n_aluno As String) As DataTable
                    Dim p As New ArrayList
                    p.Add(New SqlParameter("@n_aluno", n_aluno))
                    If n_aluno = "" Then
                        Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicos where Ativo=0", p)
                    Else
                        Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicos where NºAluno= @n_aluno AND Ativo=0", p)
                    End If
                End Function
                Shared Function procura_dados_naluno_ativados(ByRef n_aluno As String) As DataTable
                    Dim p As New ArrayList
                    p.Add(New SqlParameter("@n_aluno", n_aluno))
                    If n_aluno = "" Then
                        Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicos where Ativo=1", p)
                    Else
                        Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicos where NºAluno= @n_aluno AND Ativo=1", p)
                    End If
                End Function
                Shared Function procura_dados_turma_desativados(ByRef turma As String) As DataTable
                    Dim p As New ArrayList
                    p.Add(New SqlParameter("@turma", turma))
                    If n_empresa = "" Then
                        Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicos where Ativo=0", p)
                    Else
                        Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicos where Ativo=0 AND Turma=@turma", p)
                    End If
                End Function
                Shared Function procura_dados_turma(ByRef turma As String) As DataTable
                    Dim p As New ArrayList
                    p.Add(New SqlParameter("@n_empresa", n_empresa))
                    p.Add(New SqlParameter("@turma", turma))
                    If n_empresa = "" Then
                        Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicos where Ativo=1", p)
                    Else
                        Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicos where Ativo=1 AND Turma=@turma", p)
                    End If
                End Function
            End Class
            Shared Function carregar() As DataTable
                Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where Ativo=1", Nothing)
            End Function
            Shared Function carregar_eliminados() As DataTable
                Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where Ativo=0", Nothing)
            End Function
            Shared Function procura_dados_Nome_desativados(ByRef Nome As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@Nome", Nome))
                If Nome = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where Ativo=0", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where Nome like @Nome AND Ativo=0", p)
                End If
            End Function
            Shared Function procura_dados_Nome_ativados(ByRef Nome As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@Nome", Nome))
                If Nome = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where Ativo=1", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicoswhere Nome like @Nome AND Ativo=1", p)
                End If
            End Function
            Shared Function procura_dados_naluno_desativados(ByRef n_aluno As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@n_aluno", n_aluno))
                If n_aluno = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where Ativo=0", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where NºAluno= @n_aluno AND Ativo=0", p)
                End If
            End Function
            Shared Function procura_dados_naluno_ativados(ByRef n_aluno As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@n_aluno", n_aluno))
                If n_aluno = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where Ativo=1", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where NºAluno= @n_aluno AND Ativo=1", p)
                End If
            End Function
            Shared Function procura_dados_turma_desativados(ByRef turma As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@turma", turma))
                If n_empresa = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where Ativo=0", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where Ativo=0 AND Turma=@turma", p)
                End If
            End Function
            Shared Function procura_dados_turma(ByRef turma As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@n_empresa", n_empresa))
                p.Add(New SqlParameter("@turma", turma))
                If n_empresa = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where Ativo=1", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where Ativo=1 AND Turma=@turma", p)
                End If
            End Function
        End Class
    End Class
    Public Class Login
        Shared Function verificar_admin(ByVal id As Integer) As Integer
            Dim p As ArrayList
            p.Add(New SqlParameter("@user", id))
            Return DAL.ExecuteScalar("Select Admin FROM Utilizadores where Cod_Utilizador=@user", p)
        End Function
        Shared Function verificar_aluno(ByVal id As Integer) As Integer
            Dim p As ArrayList
            p.Add(New SqlParameter("@user", id))
            Return DAL.ExecuteScalar("Select Alunos FROM Empresa where NºEmpresa=@user", p)
        End Function
        Shared Function Carregar_empresas() As ArrayList
            Return DAL.ExecuteQuery("Select Nome From empresas", Nothing)
        End Function
        Shared Function return_n_empresa(ByVal nome As String) As Object
            Dim p As New ArrayList
            p.Add(New SqlParameter("@Nome", nome))
            Return DAL.ExecuteScalar("Select NºEmpresa FROM Empresas where Nome=@Nome", p)
        End Function
        Shared Sub alterar(ByVal Cod_Utilizador As Integer, ByVal NºAluno As Integer, ByVal NºTécnico As Integer, ByVal Nome_Util As String, ByVal Password As String, ByVal Admin As Boolean, ByVal Admin_Geral As Boolean, ByVal Ativo As Boolean, ByVal NºEmpresa As Integer)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NºAluno", NºAluno))
            p.Add(New SqlParameter("@NºTécnico", NºTécnico))
            p.Add(New SqlParameter("@Nome_Util", Nome_Util))
            p.Add(New SqlParameter("@Password", Password))
            p.Add(New SqlParameter("@Admin", Admin))
            p.Add(New SqlParameter("@Admin_Geral", Admin_Geral))
            p.Add(New SqlParameter("@Ativo", Ativo))
            p.Add(New SqlParameter("@NºEmpresa", NºEmpresa))
            DAL.ExecuteNonQuery("Update Utilizadores set NºAluno = @NºAluno, NºTécnico = @NºTécnico, Nome_Util= @Nome_Util, Password= @Password. Admin= @Admin, Admin_Geral= @Admin_Geral, Ativo= @Ativo, NºEmpresa= @NºEmpresa where Cod_Utilizador=@Cod_Utilizador", p)
        End Sub
        Shared Function Verificar_Login(ByRef user As String, ByRef pass As String, ByRef empresa As Integer) As Integer
            Dim sqlparams As New ArrayList
            sqlparams.Add(New SqlParameter("@user", user))
            sqlparams.Add(New SqlParameter("@password", pass))
            sqlparams.Add(New SqlParameter("@n_empresa", empresa))
            Dim resultado As Integer
            resultado = DAL.ExecuteScalar("select Cod_Utilizador from Utilizadores where Nome_util=@user AND Password=@password AND NºEmpresa=@n_empresa", sqlparams)
        End Function
        Shared Function Add_login(ByRef admin As Boolean, ByRef num_tecnico As Integer, ByRef num_aluno As Integer, ByRef user As String, ByRef pass As String) As Integer
            Dim p As New ArrayList
            p.Add(New SqlParameter("@Admin", admin))
            p.Add(New SqlParameter("@n_aluno", num_aluno))
            p.Add(New SqlParameter("@n_tecnico", num_tecnico))
            p.Add(New SqlParameter("@user", user))
            p.Add(New SqlParameter("@password", pass))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            Return DAL.ExecuteNonQuery("Insert into Utilizadores(NºAluno,NºTécnico,Nome_Util,Password,Admin,Ativo,NºEmpresa) VALUES (@n_aluno, @n_tecnico, @user,@password,@admin,1,NºEmpresa)", p)
        End Function
        Shared Function Remove_Login(ByVal n_user As Integer) As Integer
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_user", n_user))
            Return DAL.ExecuteNonQuery("Update Utilizadores set Ativo=0 where Cod_Utilizador=@n_user", p)
        End Function
        Shared Function carregar_users() As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", n_empresa))
            Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email FROM Clientes where Ativo=1 AND NºEmpresa=@n_empresa", p)
        End Function
        Shared Function carregar_users_eliminados() As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", n_empresa))
            Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email FROM Clientes where Ativo=0 AND NºEmpresa=@n_empresa", p)
        End Function
    End Class
    Public Class Clientes
        Shared Function carregar_alunos() As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", n_empresa))
            Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where Ativo=1 AND NºEmpresa=n_empresa", Nothing)
        End Function
        Shared Function carregar_eliminados_alunos() As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", n_empresa))
            Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where Ativo=0 AND NºEmpresa=n_empresa", Nothing)
        End Function
        Shared Function procura_dados_nome_alunos(ByRef nome As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", n_empresa))
            p.Add(New SqlParameter("@Nome", nome))
            If nome = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where Ativo=1 AND NºEmpresa=n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where nome like @nome AND Ativo=1 AND NºEmpresa=n_empresa", p)
            End If
        End Function
        Shared Function procura_dados_nome_desativados_alunos(ByRef nome As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", n_empresa))
            p.Add(New SqlParameter("@Nome", nome))
            If nome = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where Ativo=0 AND NºEmpresa=n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where nome like @nome AND Ativo=0 AND NºEmpresa=n_empresa", p)
            End If
        End Function
        Shared Function procura_dados_nif_alunos(ByRef nif As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", n_empresa))
            p.Add(New SqlParameter("@NIF", nif))
            If nif = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where Ativo=1 AND NºEmpresa=n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where NIF= @NIF AND Ativo=1 AND NºEmpresa=n_empresa", p)
            End If
        End Function
        Shared Function procura_dados_nif_desativados_alunos(ByRef nif As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", n_empresa))
            p.Add(New SqlParameter("@NIF", nif))
            If nif = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where Ativo=0 AND NºEmpresa=n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where NIF= @NIF AND Ativo=0 AND NºEmpresa=n_empresa", p)
            End If
        End Function
        Shared Function procura_dados_numcliente_alunos(ByRef num_cliente As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", n_empresa))
            p.Add(New SqlParameter("@NºCliente", num_cliente))
            If num_cliente = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where Ativo=1 AND NºEmpresa=n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where NºCliente=@NºCliente AND Ativo=1 AND NºEmpresa=n_empresa", p)
            End If
        End Function
        Shared Function procura_dados_numcliente_desativados_alunos(ByRef num_cliente As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", n_empresa))
            p.Add(New SqlParameter("@NºCliente", num_cliente))
            If num_cliente = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where Ativo=0 AND NºEmpresa=n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,Contacto Móvel,Contacto Fixo,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno where NºCliente=@NºCliente AND Ativo=0 AND NºEmpresa=n_empresa", p)
            End If
        End Function
        Shared Function carregar() As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", n_empresa))
            Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,Contacto Móvel,Contacto Fixo FROM Clientes where Ativo=1 AND NºEmpresa=n_empresa", Nothing)
        End Function
        Shared Function carregar_eliminados() As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", n_empresa))
            Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,Contacto Móvel,Contacto Fixo FROM Clientes where Ativo=0 AND NºEmpresa=n_empresa", Nothing)
        End Function
        Shared Function procura_dados_nome(ByRef nome As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", n_empresa))
            p.Add(New SqlParameter("@Nome", nome))
            If nome = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,Contacto Móvel,Contacto Fixo FROM Clientes where Ativo=1 AND NºEmpresa=n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,Contacto Móvel,Contacto Fixo FROM Clientes where nome like @nome AND Ativo=1 AND NºEmpresa=n_empresa", p)
            End If
        End Function
        Shared Function procura_dados_nome_desativados(ByRef nome As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", n_empresa))
            p.Add(New SqlParameter("@Nome", nome))
            If nome = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,Contacto Móvel,Contacto Fixo FROM Clientes where Ativo=0 AND NºEmpresa=n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,Contacto Móvel,Contacto Fixo FROM Clientes where nome like @nome AND Ativo=0 AND NºEmpresa=n_empresa", p)
            End If
        End Function
        Shared Function procura_dados_nif(ByRef nif As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", n_empresa))
            p.Add(New SqlParameter("@NIF", nif))
            If nif = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,Contacto Móvel,Contacto Fixo FROM Clientes where Ativo=1 AND NºEmpresa=n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,Contacto Móvel,Contacto Fixo FROM Clientes where NIF= @NIF AND Ativo=1 AND NºEmpresa=n_empresa", p)
            End If
        End Function
        Shared Function procura_dados_nif_desativados(ByRef nif As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", n_empresa))
            p.Add(New SqlParameter("@NIF", nif))
            If nif = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,Contacto Móvel,Contacto Fixo FROM Clientes where Ativo=0 AND NºEmpresa=n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,Contacto Móvel,Contacto Fixo FROM Clientes where NIF= @NIF AND Ativo=0 AND NºEmpresa=n_empresa", p)
            End If
        End Function
        Shared Function procura_dados_numcliente(ByRef num_cliente As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", n_empresa))
            p.Add(New SqlParameter("@NºCliente", num_cliente))
            If num_cliente = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,Contacto Móvel,Contacto Fixo FROM Clientes where Ativo=1 AND NºEmpresa=n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,Contacto Móvel,Contacto Fixo FROM Clientes where NºCliente=@NºCliente AND Ativo=1 AND NºEmpresa=n_empresa", p)
            End If
        End Function
        Shared Function procura_dados_numcliente_desativados(ByRef num_cliente As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", n_empresa))
            p.Add(New SqlParameter("@NºCliente", num_cliente))
            If num_cliente = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,Contacto Móvel,Contacto Fixo FROM Clientes where Ativo=0 AND NºEmpresa=n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,Contacto Móvel,Contacto Fixo FROM Clientes where NºCliente=@NºCliente AND Ativo=0 AND NºEmpresa=n_empresa", p)
            End If
        End Function
        Shared Function inserir(ByVal NIF As String, ByVal nome As String, ByVal morada As String, ByVal cod_postal As String, ByVal email As String, ByVal ativo As Boolean, ByVal contacto_mov As String, ByVal contacto_fix As String)
            Dim p As New ArrayList
            Dim c As New ArrayList
            Dim check(1) As Integer
            p.Add(New SqlParameter("@Nome", nome))
            p.Add(New SqlParameter("@Morada", morada))
            p.Add(New SqlParameter("@NIF", NIF))
            p.Add(New SqlParameter("@Cod_Postal", cod_postal))
            p.Add(New SqlParameter("@Email", email))
            p.Add(New SqlParameter("@Ativo", ativo))
            p.Add(New SqlParameter("@contacto_m", contacto_mov))
            p.Add(New SqlParameter("@contacto_f", contacto_fix))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            check(0) = DAL.ExecuteNonQuery("Insert into Clientes(Nome,Morada,NIF,Cod_Postal,Email,Ativo,NºEmpresa,Contacto Móvel,Contacto Fixo) VALUES (@nome, @morada, @NIF, @cod_postal,@email,1,@n_empresa,@contacto_m,@contacto_f)", p)
            Return check
        End Function
        Shared Function alterar(ByVal numcliente As Integer, ByVal NIF As String, ByVal nome As String, ByVal morada As String, ByVal cod_postal As String, ByVal email As String, ByVal ativo As Boolean, ByVal contacto_m As String, ByVal contacto_f As String)
            Dim p As New ArrayList
            Dim c As New ArrayList
            Dim check(1) As Integer
            p.Add(New SqlParameter("@NºCliente", numcliente))
            p.Add(New SqlParameter("@Nome", nome))
            p.Add(New SqlParameter("@Morada", morada))
            p.Add(New SqlParameter("@NIF", NIF))
            p.Add(New SqlParameter("@Cod_Postal", cod_postal))
            p.Add(New SqlParameter("@Email", email))
            p.Add(New SqlParameter("@Ativo", ativo))
            p.Add(New SqlParameter("@Contacto_m", contacto_m))
            p.Add(New SqlParameter("@Contacto_f", contacto_f))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            check(0) = DAL.ExecuteNonQuery("Update Clientes set Contacto Móvel = @contacto_m, Contacto Fixo = @contacto_f nome = @nome, morada = @morada, NIF= @NIF, Cod_Postal= @cod_postal, Email= @email where NºCliente=@numcliente AND NºEmpresa=@n_empresa", p)
            Return check
        End Function
        Shared Function apagar(ByVal N_Cliente As String, ByVal NIF As String)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NIF", NIF))
            p.Add(New SqlParameter("@NºCliente", N_Cliente))
            If NIF <> "" Then
                Return DAL.ExecuteNonQuery("Update Clientes set Ativo=0 where NIF = @NIF", p)
            ElseIf N_Cliente <> "" Then
                Return DAL.ExecuteNonQuery("Update Clientes set Ativo=0 where NºCliente = @NºCliente", p)
            End If
        End Function
        Shared Function reativar_cliente(ByVal N_Cliente As String)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_cliente", N_Cliente))
            Return DAL.ExecuteNonQuery("Update Clientes set Ativo=1 where NºCliente = @NºCliente", p)
        End Function
    End Class
    Public Class Dispositivos
        Shared Function carregar() As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie, Observações FROM Dispositivos where Ativo=1 AND NºEmpresa=@n_empresa", Nothing)
        End Function
        Shared Function carregar_desativos() As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie, Observações FROM Dispositivos where Ativo=1 AND NºEmpresa=@n_empresa", Nothing)
        End Function
        Shared Function procura_dados_numdispositivo_desativo(ByRef NºDispositivo As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_dispositivo", NºDispositivo))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            If NºDispositivo = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie,Observações FROM Dispositivos where Ativo=0 AND NºEmpresa=@n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie,Observações FROM Dispositivos where NºDispositivo like @n_dispositivo AND Ativo=0 AND NºEmpresa=@n_empresa", p)
            End If
        End Function
        Shared Function procura_dados_numdispositivo(ByRef NºDispositivo As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_dispositivo", NºDispositivo))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            If NºDispositivo = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie,Observações FROM Dispositivos where Ativo=1 AND NºEmpresa=@n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie,Observações FROM Dispositivos where NºDispositivo like @n_dispositivo AND Ativo=1 AND NºEmpresa=@n_empresa", p)
            End If
        End Function
        Shared Function procura_dados_numcliente(ByRef NºCliente As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NºCliente", NºCliente))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            If NºCliente = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie,Observações FROM Dispositivos where Ativo=1 AND NºEmpresa=@n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie,Observações FROM Dispositivos where NºCliente=@NºCliente AND Ativo=1 AND NºEmpresa=@n_empresa", p)
            End If
        End Function
        Shared Function procura_dados_numcliente_desativo(ByRef NºCliente As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NºCliente", NºCliente))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            If NºCliente = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie,Observações FROM Dispositivos where Ativo=0 AND NºEmpresa=@n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºDispositivo,NºCliente,Marca,Modelo,NºSérie,Observações FROM Dispositivos where NºCliente=@NºCliente AND Ativo=0", p)
            End If
        End Function
        Shared Function inserir(ByVal NºCliente As Integer, ByVal Marca As String, ByVal Modelo As String, ByVal NºSérie As Integer, ByVal Observações As String)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NºCliente", NºCliente))
            p.Add(New SqlParameter("@Marca", Marca))
            p.Add(New SqlParameter("@Modelo", Modelo))
            p.Add(New SqlParameter("@NºSérie", NºSérie))
            p.Add(New SqlParameter("@Observações", Observações))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            Return DAL.ExecuteNonQuery("Insert into Dispositivos(NºCliente,Marca,Modelo,NºSérie,Observações,NºEmpresa) VALUES (@NºCliente, @Marca, @Modelo, @NºSérie,@Observações,@n_empresa)", p)
        End Function
        Shared Function alterar(ByVal n_dispositivo As String, ByVal n_cliente As String, ByVal Marca As String, ByVal Modelo As String, ByVal NºSérie As Integer, ByVal Observações As String)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_dispositivo", n_dispositivo))
            p.Add(New SqlParameter("@n_cliente", n_cliente))
            p.Add(New SqlParameter("@Marca", Marca))
            p.Add(New SqlParameter("@Modelo", Modelo))
            p.Add(New SqlParameter("@NºSérie", NºSérie))
            p.Add(New SqlParameter("@Observações", Observações))
            Return DAL.ExecuteNonQuery("Update Dispositivos set NºCliente = @n_cliente, Marca = @Marca, Modelo= @Modelo, NºSérie= @NºSérie, Observações= @Observações where NºDispositivo=@n_dispositivo", p)
        End Function
        Shared Function apagar(ByVal NºDispositivo As String, ByVal NºCliente As String)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NºDispositivo", NºDispositivo))
            p.Add(New SqlParameter("@NºCliente", NºCliente))
            If NºDispositivo <> "" Then
                Return DAL.ExecuteNonQuery("Update Dispositivos set Ativo=0 where NºDispositivo = @NºDispositivo", p)
            ElseIf NºCliente <> "" Then
                Return DAL.ExecuteNonQuery("Update Dispositivos set Ativo=0 where NºCliente = @NºCliente", p)
            End If
        End Function
    End Class
    Public Class Reparacoes
        Shared Function carregar() As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar From Reparações where NºEmpresa=@n_empresa AND Ativo=1", p)
        End Function
        Shared Function carregar_desativos() As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar From Reparações where NºEmpresa=@n_empresa AND Ativo=0", p)
        End Function
        Shared Function procura_dados_numdispositivo(ByRef NºDispositivo As Integer) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_dispositivo", NºDispositivo))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            If NºDispositivo = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar,NºEmpresa From Reparações where NºEmpresa=@n_empresa AND Ativo=1", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar,NºEmpresa From Reparações where NºDispositivo like @n_dispositivo AND NºEmpresa=@n_empresa AND Ativo=1", p)
            End If
        End Function
        Shared Function procura_dados_numdispositivo_desativo(ByRef NºDispositivo As Integer) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_dispositivo", NºDispositivo))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            If NºDispositivo = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar,NºEmpresa From Reparações where NºEmpresa=@n_empresa AND Ativo=0", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar,NºEmpresa From Reparações where NºDispositivo like @n_dispositivo AND NºEmpresa=@n_empresa AND Ativo=0", p)
            End If
        End Function
        Shared Function procura_dados_numreparação(ByRef NºReparação As Integer) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_reparação", NºReparação))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            If NºReparação = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar From Reparações where NºEmpresa=@n_empresa AND Ativo=1", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar From Reparações where NºReparação=@n_reparação AND NºEmpresa=@n_empresa AND Ativo=1", p)
            End If
        End Function
        Shared Function procura_dados_numreparação_desativo(ByRef NºReparação As Integer) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_reparação", NºReparação))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            If NºReparação = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar From Reparações where NºEmpresa=@n_empresa AND Ativo=0", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar From Reparações where NºReparação=@n_reparação AND NºEmpresa=@n_empresa AND Ativo=0", p)
            End If
        End Function
        Shared Sub inserir(ByVal n_dispositivo As Integer, ByVal Categoria As String, ByVal n_tecnico As Integer, ByVal TempoRealReparação As String, ByVal DescAvaria As String, ByVal DIRepar As String, ByVal DFRepar As String, ByVal n_empresa As Integer, ByVal n_software As Integer, ByVal n_hardware As Integer, ByVal tipo As String)
            Dim p As New ArrayList
            Dim s As New ArrayList
            Dim h As New ArrayList
            Dim rtrn As New ArrayList
            Dim n_reparacao As Integer
            p.Add(New SqlParameter("@n_dispositivo", n_dispositivo))
            p.Add(New SqlParameter("@Categoria", Categoria))
            p.Add(New SqlParameter("@n_tecnico", n_tecnico))
            p.Add(New SqlParameter("@TempoRealReparação", TempoRealReparação))
            p.Add(New SqlParameter("@DescAvaria", DescAvaria))
            p.Add(New SqlParameter("@DIRepar", DIRepar))
            p.Add(New SqlParameter("@DFRepar", DFRepar))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            DAL.ExecuteNonQuery("Insert into Reparações(NºDispositivo,Categoria,NºTécnico,TempoRealReparação,DescAvaria,DIRepar,DFRepar,NºEmpresa,Ativo) VALUES (@NºReparação, @NºDispositivo, @Categoria, @NºTécnico,@TempoRealReparação,@DIRepar,@DFRepar,@NºEmpresa,1)", p)
            rtrn = DAL.ExecuteScalar("Select Max(NºReparação) from Reparações", Nothing)
            n_reparacao = rtrn(0)
            s.Add(New SqlParameter("@n_reparacao", n_reparacao))
            s.Add(New SqlParameter("@Tipo", tipo))
            h.Add(New SqlParameter("@n_reparacao", n_reparacao))
            h.Add(New SqlParameter("@Tipo", tipo))
            DAL.ExecuteNonQuery("Insert into Software(NºReparação,Tipo) VALUES (@n_reparacao,@NºSoftware,@Tipo)", s)
            DAL.ExecuteNonQuery("Insert into Hardware(NºReparação,Tipo) VALUES (@n_reparacao,@NºHarware,@Tipo)", h)
        End Sub
        Shared Function alterar(ByVal NºReparação As Integer, ByVal NºDispositivo As Integer, ByVal Categoria As String, ByVal NºTécnico As Integer, ByVal TempoRealReparação As String, ByVal DescAvaria As String, ByVal DIRepar As String, ByVal DFRepar As String, ByVal NºEmpresa As Integer, ByVal tipo_hard As String, ByVal tipo_soft As String)
            Dim p As New ArrayList
            Dim s As New ArrayList
            Dim h As New ArrayList
            Dim rtrn As New ArrayList
            p.Add(New SqlParameter("@NºReparação", NºReparação))
            p.Add(New SqlParameter("@NºDispositivo", NºDispositivo))
            p.Add(New SqlParameter("@Categoria", Categoria))
            p.Add(New SqlParameter("@NºTécnico", NºTécnico))
            p.Add(New SqlParameter("@TempoRealReparação", TempoRealReparação))
            p.Add(New SqlParameter("@DescAvaria", DescAvaria))
            p.Add(New SqlParameter("@DIRepar", DIRepar))
            p.Add(New SqlParameter("@DFRepar", DFRepar))
            s.Add(New SqlParameter("@NºReparação", NºReparação))
            s.Add(New SqlParameter("@Tipo_hard", tipo_hard))
            h.Add(New SqlParameter("@NºReparação", NºReparação))
            h.Add(New SqlParameter("@Tipo_soft", tipo_soft))
            rtrn.Add(DAL.ExecuteNonQuery("Update Reparações set NºDispositivo = @NºDispositivo, Categoria = @Categoria, NºTécnico= @NºTécnico, TempoRealReparação= @TempoRealReparação, DescAvaria= @DescAvaria, DIRepar = @DIRepar, DFRepar = @DFRepar where NºReparação=@NºReparação", p))
            rtrn.Add(DAL.ExecuteNonQuery("Update Software set Tipo = @Tipo_soft where NºReparação = @NºReparação", s))
            rtrn.Add(DAL.ExecuteNonQuery("Update Hardware set Tipo = @Tipo_hard where NºReparação = @NºReparação", h))
            Return rtrn
        End Function
        Shared Function apagar(ByVal id As Integer, ByVal modo As String) As String
            Dim p As New ArrayList
            p.Add(New SqlParameter("@id", id))
            If modo = 1 Then
                DAL.ExecuteNonQuery("Update Reparações set Ativo=0 where NºReparação = @id", p)
                Return 1
            ElseIf modo = 2 Then
                DAL.ExecuteNonQuery("Update Reparações set Ativo=0 where NºDispositivo = @id", p)
                Return 1
            End If
            Return "Erro ao Apagar da Base-de-Dados"
        End Function
    End Class
    Public Class Tecnicos
        Public Class Alunos
            Shared Function carregar() As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@n_empresa", n_empresa))
                Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicos where Ativo=1 AND NºEmpresa=@n_empresa", p)
            End Function
            Shared Function carregar_eliminados() As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@n_empresa", n_empresa))
                Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicos where Ativo=0 AND NºEmpresa=@n_empresa", p)
            End Function
            Shared Function procura_dados_Nome_desativados(ByRef Nome As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@Nome", Nome))
                p.Add(New SqlParameter("@n_empresa", n_empresa))
                If Nome = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicos where Ativo=0 AND NºEmpresa=@n_empresa", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicos where Nome like @Nome AND Ativo=0 AND NºEmpresa=@n_empresa", p)
                End If
            End Function
            Shared Function procura_dados_Nome_ativados(ByRef Nome As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@Nome", Nome))
                p.Add(New SqlParameter("@n_empresa", n_empresa))
                If Nome = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicos where Ativo=1 AND NºEmpresa=@n_empresa", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicoswhere Nome like @Nome AND Ativo=1 AND NºEmpresa=@n_empresa", p)
                End If
            End Function
            Shared Function procura_dados_naluno_desativados(ByRef n_aluno As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@n_aluno", n_aluno))
                p.Add(New SqlParameter("@n_empresa", n_empresa))
                If n_aluno = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicos where Ativo=0 AND NºEmpresa=@n_empresa", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicos where NºAluno= @n_aluno AND Ativo=0 AND NºEmpresa=@n_empresa", p)
                End If
            End Function
            Shared Function procura_dados_naluno_ativados(ByRef n_aluno As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@n_aluno", n_aluno))
                p.Add(New SqlParameter("@n_empresa", n_empresa))
                If n_aluno = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicos where Ativo=1 AND NºEmpresa=@n_empresa", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicos where NºAluno= @n_aluno AND Ativo=1 AND NºEmpresa=@n_empresa", p)
                End If
            End Function
            Shared Function procura_dados_turma_desativados(ByRef turma As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@n_empresa", n_empresa))
                p.Add(New SqlParameter("@turma", turma))
                If n_empresa = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicos where Ativo=0 AND NºEmpresa=@n_empresa", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicos where NºEmpresa=@n_empresa AND Ativo=0 AND Turma=@turma", p)
                End If
            End Function
            Shared Function procura_dados_turma(ByRef turma As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@n_empresa", n_empresa))
                p.Add(New SqlParameter("@turma", turma))
                If n_empresa = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicos where Ativo=1 AND NºEmpresa=@n_empresa", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Turma,NºAluno FROM Técnicos where NºEmpresa=@n_empresa AND Ativo=1 AND Turma=@turma", p)
                End If
            End Function
            Shared Sub inserir(ByVal Nome As String, ByRef img As Image, ByVal n_aluno As Integer, ByVal turma As String)
                Dim p As New ArrayList
                Dim img_save As New SqlParameter("@fotografia", SqlDbType.Image)
                p.Add(New SqlParameter("@nome", Nome))
                p.Add(New SqlParameter("@turma", turma))
                p.Add(New SqlParameter("@n_aluno", n_aluno))
                Dim mStream As MemoryStream = New MemoryStream()
                img.Save(mStream, ImageFormat.Png)
                img_save.SqlValue = mStream.GetBuffer
                p.Add(img_save)
                p.Add(New SqlParameter("@n_empresa", n_empresa))
                DAL.ExecuteNonQuery("Insert into Técnico(Nome,Turma,Fotografia,NºAluno,Ativo,NºEmpresa) VALUES (@nome,@turma,@fotografia,@n_aluno,1,@n_empresa)", p)
            End Sub
            Shared Sub alterar(ByVal Nome As String, ByVal n_aluno As Integer, ByVal turma As String, ByVal n_tecnico As Integer)
                Dim p As New ArrayList
                p.Add(New SqlParameter("@nome", Nome))
                p.Add(New SqlParameter("@turma", turma))
                p.Add(New SqlParameter("@n_aluno", n_aluno))
                p.Add(New SqlParameter("@n_tecnico", n_tecnico))
                DAL.ExecuteNonQuery("Update Técnico set Nome = @Nome, Turma=@turma, NºAluno=@n_aluno where NºTécnico=@n_tecnico", p)
            End Sub
            Shared Sub apagar(ByVal n_aluno As String, ByVal n_tecnico As Integer)
                Dim p As New ArrayList
                p.Add(New SqlParameter("@n_tecnico", n_tecnico))
                p.Add(New SqlParameter("@n_aluno", n_aluno))
                If n_tecnico <> "" Then
                    DAL.ExecuteNonQuery("Update Técnico set Ativo=0 where NºTécnico = @n_tecnico", p)
                ElseIf n_aluno <> "" Then
                    DAL.ExecuteNonQuery("Update Técnico set Ativo=0 where NºAluno = @n_aluno", p)
                End If
            End Sub
        End Class
        Shared Function carregar() As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where Ativo=1 AND NºEmpresa=@n_empresa", p)
        End Function
        Shared Function carregar_eliminados() As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where Ativo=0 AND NºEmpresa=@n_empresa", p)
        End Function
        Shared Function procura_dados_Nome_desativados(ByRef Nome As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@Nome", Nome))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            If Nome = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where Ativo=0 AND NºEmpresa=@n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where Nome like @Nome AND Ativo=0 AND NºEmpresa=@n_empresa", p)
            End If
        End Function
        Shared Function procura_dados_Nome_ativados(ByRef Nome As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@Nome", Nome))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            If Nome = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where Ativo=1 AND NºEmpresa=@n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicoswhere Nome like @Nome AND Ativo=1 AND NºEmpresa=@n_empresa", p)
            End If
        End Function
        Shared Function procura_dados_naluno_desativados(ByRef n_aluno As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_aluno", n_aluno))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            If n_aluno = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where Ativo=0 AND NºEmpresa=@n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where NºAluno= @n_aluno AND Ativo=0 AND NºEmpresa=@n_empresa", p)
            End If
        End Function
        Shared Function procura_dados_naluno_ativados(ByRef n_aluno As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_aluno", n_aluno))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            If n_aluno = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where Ativo=1 AND NºEmpresa=@n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where NºAluno= @n_aluno AND Ativo=1 AND NºEmpresa=@n_empresa", p)
            End If
        End Function
        Shared Function procura_dados_turma_desativados(ByRef turma As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            p.Add(New SqlParameter("@turma", turma))
            If n_empresa = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where Ativo=0 AND NºEmpresa=@n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where NºEmpresa=@n_empresa AND Ativo=0 AND Turma=@turma", p)
            End If
        End Function
        Shared Function procura_dados_turma(ByRef turma As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            p.Add(New SqlParameter("@turma", turma))
            If n_empresa = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where Ativo=1 AND NºEmpresa=@n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where NºEmpresa=@n_empresa AND Ativo=1 AND Turma=@turma", p)
            End If
        End Function
        Shared Sub inserir(ByVal Nome As String, ByRef img As Image, ByVal n_aluno As Integer, ByVal turma As String)
            Dim p As New ArrayList
            Dim img_save As New SqlParameter("@fotografia", SqlDbType.Image)
            p.Add(New SqlParameter("@nome", Nome))
            Dim mStream As MemoryStream = New MemoryStream()
            img.Save(mStream, ImageFormat.Png)
            img_save.SqlValue = mStream.GetBuffer
            p.Add(img_save)
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            DAL.ExecuteNonQuery("Insert into Técnico(Nome,Fotografia,Ativo,NºEmpresa) VALUES (@nome,@fotografia,1,@n_empresa)", p)
        End Sub
        Shared Sub alterar(ByVal Nome As String, ByVal img As Image, ByVal n_tecnico As Integer)
            Dim p As New ArrayList
            Dim img_save As New SqlParameter("@Fotografia", SqlDbType.Image)
            p.Add(New SqlParameter("@nome", Nome))
            Dim mStream As MemoryStream = New MemoryStream()
            img.Save(mStream, ImageFormat.Png)
            img_save.SqlValue = mStream.GetBuffer
            p.Add(img_save)
            p.Add(New SqlParameter("@n_tecnico", n_tecnico))
            DAL.ExecuteNonQuery("Update Técnico set Nome = @Nome, Fotografia=@Fotografia where NºTécnico=@n_tecnico", p)
        End Sub
        Shared Function apagar(ByVal n_aluno As String, ByVal n_tecnico As Integer)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_tecnico", n_tecnico))
            If n_tecnico <> "" Then
                Return DAL.ExecuteNonQuery("Update Técnico set Ativo=0 where NºTécnico = @n_tecnico", p)
            Else
                MsgBox("Insira o ID do Técnico a Eliminar")
                Return -1
            End If
        End Function
    End Class
    Public Class Participacoes
        Shared Sub adicionar_part(ByVal n_tecnico As Integer, ByVal n_reparacao As Integer)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_tecnico", n_tecnico))
            p.Add(New SqlParameter("@n_reparacao", n_reparacao))
            DAL.ExecuteNonQuery("Insert into Participações(NºReparação,NºTécnico) VALUES (@n_reparacao,@n_tecnico)", p)
        End Sub
        Shared Sub remover_part(ByVal n_tecnico As Integer, ByVal n_reparacao As Integer)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_reparacao", n_reparacao))
            If n_reparacao <> 0 Then
                DAL.ExecuteNonQuery("Delete FROM Participações where NºReparação=@n_reparacao", p)
            Else
                p.Add(New SqlParameter("@n_tecnico", n_tecnico))
                p.Remove(New SqlParameter("@n_reparacao", n_reparacao))
                DAL.ExecuteNonQuery("Delete FROM Participações where NºTécnico=@n_tecnico", p)
            End If
        End Sub
        Shared Function procurar_part(ByVal n_repar As Integer)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NºReparação", n_repar))
            Return DAL.ExecuteQuery("SELECT NºTécnico FROM Participações where NºReparação=@NºReparação", p)
        End Function
    End Class
End Class


