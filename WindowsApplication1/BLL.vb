Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging

Public Class BLL
    Public Shared n_empresa As String

    Public Class Admin_only 
        Public Class Login
            Shared Function return_p_r(ByVal nome_de_utilizador As String) As ArrayList
                Dim p As New ArrayList
                p.Add(New SqlParameter("@user", nome_de_utilizador))
                Return DAL.ExecuteQuery("Select Pergunta_S, Resposta_S,Password from utilizadores where convert(varbinary,Nome_Util) = convert(varbinary,@user) and Active=1", p)
            End Function
            Shared Sub remove_login(ByVal id As String)
                Dim p As New ArrayList
                p.Add(New SqlParameter("@user", id))
                DAL.ExecuteNonQuery("Update Utilizadores set Active=0 where N_Técnico=@user", p)
            End Sub
            Shared Sub restore_login(ByVal id As String)
                Dim p As New ArrayList
                p.Add(New SqlParameter("@user", id))
                DAL.ExecuteNonQuery("Update Utilizadores set Active=1 where N_Técnico=@user", p)
            End Sub
            Shared Function check_exist(ByVal nome As String) As Object
                Dim check As Integer
                Dim p As New ArrayList
                p.Add(New SqlParameter("@nome", nome))
                check = DAL.ExecuteScalar("Select Cod_Utilizador FROM Utilizadores where Nome_util=@Nome", p)
                If check <> 0 Then
                    Return 1
                Else
                    Return 0
                End If
            End Function
            Shared Function carregar_dados_codutilizador(ByRef Cod_Utilizador As String, ByRef ativo As Boolean) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@Cod_Utilizador", Cod_Utilizador))
                p.Add(New SqlParameter("@ativo", ativo))
                If Cod_Utilizador = "" Then
                    Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, N_Técnico, Nome_Util,Password,Pergunta_S,Resposta_S, Admin, Active FROM Utilizadores Where Active=@ativo", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, N_Técnico, Nome_Util,Password,Pergunta_S,Resposta_S, Admin, Active FROM Utilizadores where Cod_Utilizador = @Cod_Utilizador AND Active=@ativo", p)
                End If
            End Function
            
            Shared Function carregar_users() As DataTable
                Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador,N_Técnico,Nome_Util,Admin FROM Utilizadores where Active=1", Nothing)
            End Function
            Shared Function Add_login_tecnico(ByVal pergunta_s As String, ByVal resposta_s As String, ByVal n_tecnico As String, ByRef user As String, ByRef pass As String)
                Dim p As New ArrayList
                p.Add(New SqlParameter("@user", user))
                p.Add(New SqlParameter("@password", pass))
                p.Add(New SqlParameter("@tecnico", n_tecnico))
                p.Add(New SqlParameter("@pergunta_s", pergunta_s))
                p.Add(New SqlParameter("@resposta_s", resposta_s))
                p.Add(New SqlParameter("@admin", False))
                Return DAL.ExecuteNonQuery("Insert into Utilizadores(N_Técnico,Nome_Util,Password,Pergunta_S,Resposta_S,Admin,Active) VALUES (@tecnico,@user,@password,@pergunta_s,@resposta_s,@admin,1)", p)
            End Function
            Shared Function Add_login_non_student_admin(ByVal pergunta_s As String, ByVal resposta_s As String, ByRef user As String, ByRef pass As String)
                Dim p As New ArrayList
                p.Add(New SqlParameter("@user", user))
                p.Add(New SqlParameter("@password", pass))
                p.Add(New SqlParameter("@pergunta_s", pergunta_s))
                p.Add(New SqlParameter("@resposta_s", resposta_s))
                p.Add(New SqlParameter("@admin", True))
                Return DAL.ExecuteNonQuery("Insert into Utilizadores(Nome_Util,Password,Pergunta_S,Resposta_S,Admin,Active) VALUES (@user,@password,@pergunta_s,@resposta_s,@admin,1)", p)
            End Function
            Shared Function alterar_login_tecnico(ByVal cod_utilizador As String, ByVal pergunta_s As String, ByVal resposta_s As String, ByVal n_tecnico As String, ByRef user As String, ByRef pass As String)
                Dim p As New ArrayList
                p.Add(New SqlParameter("@id", cod_utilizador))
                p.Add(New SqlParameter("@user", user))
                p.Add(New SqlParameter("@password", pass))
                p.Add(New SqlParameter("@tecnico", n_tecnico))
                p.Add(New SqlParameter("@pergunta_s", pergunta_s))
                p.Add(New SqlParameter("@resposta_s", resposta_s))
                p.Add(New SqlParameter("@admin", False))
                Return DAL.ExecuteNonQuery("Update Utilizadores set Pergunta_S=@pergunta_s, Resposta_S=@resposta_s, N_Técnico=@tecnico , Nome_Util=@user , Password=@password , Admin = @admin where Cod_Utilizador=@id", p)
            End Function
            Shared Function alterar_login_non_student(ByVal pergunta_s As String, ByVal resposta_s As String, ByVal id As String, ByRef user As String, ByRef pass As String)
                Dim p As New ArrayList
                p.Add(New SqlParameter("@id", id))
                p.Add(New SqlParameter("@user", user))
                p.Add(New SqlParameter("@password", pass))
                p.Add(New SqlParameter("@pergunta_s", pergunta_s))
                p.Add(New SqlParameter("@resposta_s", resposta_s))
                Return DAL.ExecuteNonQuery("Update Utilizadores set Pergunta_S=@pergunta_s, Resposta_S=@resposta_s, Nome_Util=@user, Password=@password where Cod_Utilizador=@id", p)
            End Function
            Shared Function remove_login_empresa(ByVal empresa As String)
                Dim p As New ArrayList
                p.Add(New SqlParameter("n_empresa", empresa))
                Return DAL.ExecuteNonQuery("Delete From Utilizadores where NºEmpresa=@n_empresa", p)
            End Function
            
        End Class
        Public Class Empresas
            Shared Function check_exist(ByVal nome As String) As Object
                Dim check As Integer
                Dim p As New ArrayList
                p.Add(New SqlParameter("@nome", nome))
                check = DAL.ExecuteScalar("Select NºEmpresa FROM Empresas where Nome=@Nome", p)
                If check <> 0 Then
                    Return 1
                Else
                    Return 0
                End If
            End Function
            Shared Function return_pic() As Object

                Dim p As New ArrayList
                p.Add(New SqlParameter("@NºEmpresa", n_empresa))
                Dim bitPic() As Byte = DAL.ExecuteScalar("Select Logo from Empresas where NºEmpresa=@NºEmpresa", p)
                Dim mStream As MemoryStream = New MemoryStream(bitPic)
                Dim img As Image = Image.FromStream(mStream)
                Return img
            End Function
            Shared Function carregar_max() As Integer
                Return DAL.ExecuteScalar("Select Max(NºEmpresa) FROM Empresas", Nothing)
            End Function
            Shared Function carregar(ByRef ativo As Boolean) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@ativo", ativo))
                Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade,Alunos,Email,Site,Contacto_F FROM Empresas where Ativo=@ativo", p)
            End Function
            Shared Function carregar_dados_numempresa(ByRef n_empresa As String, ByRef ativo As Boolean) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@n_empresa", n_empresa))
                p.Add(New SqlParameter("@ativo", ativo))
                If n_empresa = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade,Alunos,Email,Site,Contacto_F FROM Empresas where Ativo=@ativo", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade,Alunos,Email,Site,Contacto_F FROM Empresas where NºEmpresa=@n_empresa AND Ativo=@ativo", p)
                End If
            End Function
            Shared Sub inserir(ByVal alunos As Boolean, ByVal Nome As String, ByVal Morada As String, ByVal NIF As String, ByVal Cod_Postal As String, ByVal Localidade As String, ByVal Logo As Image, ByVal Email As String, ByVal Site As String, ByVal Contacto_Fix As String, ByVal Ativo As Boolean)
                Dim p As New ArrayList
                Dim img_save As New SqlParameter("@img", SqlDbType.Image)
                p.Add(New SqlParameter("@Nome", Nome))
                p.Add(New SqlParameter("@Morada", Morada))
                p.Add(New SqlParameter("@NIF", NIF))
                p.Add(New SqlParameter("@Cod_Postal", Cod_Postal))
                p.Add(New SqlParameter("@Localidade", Localidade))
                p.Add(New SqlParameter("@Alunos", alunos))
                p.Add(New SqlParameter("@Email", Email))
                p.Add(New SqlParameter("@Site", Site))
                p.Add(New SqlParameter("@Contacto_F", Contacto_Fix))
                Dim mStream As MemoryStream = New MemoryStream()
                Logo.Save(mStream, ImageFormat.Png)
                img_save.SqlValue = mStream.GetBuffer
                p.Add(img_save)
                p.Add(New SqlParameter("@Ativo", Ativo))
                DAL.ExecuteNonQuery("Insert into Empresas(Nome,Morada,NIF,Cod_Postal,Localidade,Logo,Alunos,Email,Site,Contacto_F,Ativo) VALUES (@nome, @morada, @NIF, @cod_postal,@Localidade,@img,@Alunos,@Email,@Site,@Contacto_F,1)", p)
            End Sub
            Shared Sub alterar(ByVal NºEmpresa As Integer, ByVal Nome As String, ByVal Morada As String, ByVal NIF As String, ByVal Cod_Postal As String, ByVal Localidade As String, ByVal Logo As Image, ByVal Email As String, ByVal Site As String, ByVal Contacto_Fix As String, ByVal ativo As Boolean)
                Dim p As New ArrayList
                Dim img_save As New SqlParameter("@Logo", SqlDbType.Image)
                p.Add(New SqlParameter("@Nome", Nome))
                p.Add(New SqlParameter("@Morada", Morada))
                p.Add(New SqlParameter("@NIF", NIF))
                p.Add(New SqlParameter("@Cod_Postal", Cod_Postal))
                p.Add(New SqlParameter("@Localidade", Localidade))
                p.Add(New SqlParameter("@Email", Email))
                p.Add(New SqlParameter("@Site", Site))
                p.Add(New SqlParameter("@Contacto_F", Contacto_Fix))
                Dim mStream As MemoryStream = New MemoryStream()
                Logo.Save(mStream, ImageFormat.Png)
                img_save.SqlValue = mStream.GetBuffer
                p.Add(img_save)
                p.Add(New SqlParameter("@Ativo", ativo))
                Try
                    DAL.ExecuteNonQuery("Update Empresas set Nome = @Nome, Norada = @Morada, NIF= @NIF, Cod_Postal= @Cod_Postal, Localidade= @Localidade, Logo= @Logo, Email= @Email, Site= @Site, Contacto_F= @Contacto_F, Ativo= @Ativo where NºEmpresa=@NºEmpresa", p)
                Catch e As Exception
                    MsgBox("Erro ao editar os dados: " & e.Message)
                Finally
                    MsgBox("Empresa editada com sucesso")
                End Try
            End Sub
        End Class
        
    End Class
    Public Class Login
        'Shared Function remover_empresas(ByVal empresa As String)
        '    Dim p As New ArrayList
        '    p.Add(New SqlParameter("@empresa", empresa))
        '    DAL.ExecuteNonQuery("UPDATE Utilizadores set ativo=0 where nºempresa=@empresa", p)
        'End Function
        Shared Function check_exist(ByVal nome As String) As Object
            Dim check As Integer
            Dim p As New ArrayList
            p.Add(New SqlParameter("@nome", nome))
            check = DAL.ExecuteScalar("Select Cod_Utilizador FROM Utilizadores where Nome_util=@Nome", p)
            If check <> 0 Then
                Return True
            Else
                Return False
            End If
        End Function
        Shared Function verificar_admin(ByVal id As Integer) As Boolean
            Dim p As New ArrayList
            p.Add(New SqlParameter("@user", id))
            Return DAL.ExecuteScalar("Select Admin FROM Utilizadores where Cod_Utilizador=@user AND Active=1", p)
        End Function
        Shared Function verificar_aluno(ByVal id As Integer) As Boolean
            Dim p As New ArrayList
            p.Add(New SqlParameter("@user", id))
            Return DAL.ExecuteScalar("Select Alunos FROM Empresas where NºEmpresa=@user AND Ativo=1", p)
        End Function
        Shared Function carregar_dados_ntecnico(ByVal id As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@user", id))
            p.Add(New SqlParameter("@n_empresa", BLL.n_empresa))
            If id <> "" Then
                Return DAL.ExecuteQueryDT("Select Cod_Utilizador,nome_util,password,admin FROM Utilizadores where NºEmpresa=@n_empresa AND Nºtécnico=@user AND Active=1", p)
            Else
                Return DAL.ExecuteQueryDT("Select Cod_Utilizador,nome_util,password,admin FROM Utilizadores where NºEmpresa=@n_empresa AND Active=1", p)
            End If
        End Function
        Shared Function Carregar_empresas() As ArrayList
            Return DAL.ExecuteQuery("Select Nome From empresas where Ativo=1", Nothing)
        End Function
        Shared Function return_n_empresa(ByVal nome As String) As Object
            Dim p As New ArrayList
            p.Add(New SqlParameter("@Nome", nome))
            Dim returnint As Integer
            returnint = DAL.ExecuteScalar("Select NºEmpresa FROM Empresas where Nome=@Nome and Ativo=1", p)
            Return returnint
        End Function
        Shared Sub alterar(ByVal Cod_Utilizador As Integer, ByVal NºTécnico As Integer, ByVal Nome_Util As String, ByVal Password As String, ByVal Admin As Boolean, ByVal Ativo As Boolean, ByVal NºEmpresa As Integer)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NºTécnico", NºTécnico))
            p.Add(New SqlParameter("@Nome_Util", Nome_Util))
            p.Add(New SqlParameter("@Password", Password))
            p.Add(New SqlParameter("@Admin", Admin))
            p.Add(New SqlParameter("@Ativo", Ativo))
            p.Add(New SqlParameter("@NºEmpresa", NºEmpresa))
            DAL.ExecuteNonQuery("Update Utilizadores set NºTécnico = @NºTécnico, Nome_Util= @Nome_Util, Password= @Password. Admin= @Admin, Active= @Ativo, NºEmpresa= @NºEmpresa where Cod_Utilizador=@Cod_Utilizador", p)
        End Sub
        Shared Function Verificar_Login(ByRef user As String, ByRef pass As String, ByRef empresa As String) As Integer
            Dim sqlparams As New ArrayList
            sqlparams.Add(New SqlParameter("@user", user))
            sqlparams.Add(New SqlParameter("@password", pass))
            Dim resultado1 As ArrayList
            Dim resultado2 As Integer
            resultado1 = DAL.ExecuteQuery("select Cod_Utilizador,N_Técnico from Utilizadores where convert(varbinary,Nome_Util) = convert(varbinary,@user) AND convert(varbinary,password) = convert(varbinary,@password) AND Active=1", sqlparams)
            If resultado1.Count <> 0 Then
                resultado2 = resultado1.Item(0)
                BLL.n_empresa = empresa
                Try
                    Dim teste As DBNull
                    If resultado1.Item(1) <> teste Then
                        If BLL.Tecnicos.carregar_dados(resultado1.Item(1), True).Rows(0).Item("NºTécnico").ToString <> 0 Then
                            Return resultado2
                        Else
                            Return 0
                        End If
                    End If
                Catch
                    Return resultado2
                End Try
            Else
                Return 0
            End If
        End Function

    End Class
    Public Class Clientes
        Shared Function carregar_percentagem() As Integer
            Dim total, por, alunos As Integer
            total = DAL.ExecuteScalar("SELECT Count(NºCliente) From Clientes", Nothing)
            alunos = DAL.ExecuteScalar("SELECT Count(NºCliente) From Clientes inner join TipoAluno On Clientes.NºCliente = TipoAluno.N_Cliente where NºAluno <> 0", Nothing)
            por = alunos * 100 / total
            Return por
        End Function
        'Shared Sub remover_empresas(ByVal empresa As String)
        '    Dim p As New ArrayList
        '    p.Add(New SqlParameter("@empresa", empresa))
        '    DAL.ExecuteNonQuery("UPDATE Clientes set ativo=0 where nºempresa=@empresa", p)
        'End Sub
        Shared Function carregar_max(ByRef ativo As Boolean) As Integer
            Dim p As New ArrayList
            p.Add(New SqlParameter("@num_empresa", n_empresa))
            p.Add(New SqlParameter("@ativo", ativo))
            Return DAL.ExecuteScalar("Select MAX(NºCliente) from clientes where NºEmpresa=@num_empresa and ativo=@ativo", p)
        End Function
        Shared Function carregar_alunos(ByRef ativo As Boolean) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_empresa", BLL.n_empresa))
            p.Add(New SqlParameter("@ativo", ativo))
            Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Localidade,Cod_Postal,Email,NIF,Contacto_M,Contacto_F,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno ON Clientes.NºCliente=TipoAluno.N_Cliente where Ativo=@ativo AND NºEmpresa=@n_empresa", p)
        End Function
        Shared Function procura_dados_alunos(ByRef query As String, ByRef ativo As Boolean) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_empresa", BLL.n_empresa))
            p.Add(New SqlParameter("@ativo", ativo))
            If IsNumeric(query) = True Then
                Dim backup As String = query
                query = "%" & backup & "%"
                p.Add(New SqlParameter("@query", query))
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Localidade,Cod_Postal,Email,NIF,Contacto_M,Contacto_F,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno ON Clientes.NºCliente=TipoAluno.N_Cliente where (NºCliente like @query or NºAluno like @query or NIF like @query or nºturma like @query) and Ativo=@ativo AND NºEmpresa=@n_empresa", p)
            Else
                Dim backup As String = query
                query = "%" & backup & "%"
                p.Add(New SqlParameter("@query", query))
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Localidade,Cod_Postal,Email,NIF,Contacto_M,Contacto_F,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno ON Clientes.NºCliente=TipoAluno.N_Cliente where (nome like @query OR Morada like @query or email like @query or localidade like @query or cod_postal like @query or contacto_m like @query or contacto_f like @query or nºturma like @query) AND Ativo=@ativo AND NºEmpresa=@n_empresa", p)
            End If
        End Function
        Shared Function carregar_dados_numcliente_alunos(ByRef num_cliente As String, ByRef ativo As Boolean) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_empresa", BLL.n_empresa))
            p.Add(New SqlParameter("@NºCliente", num_cliente))
            p.Add(New SqlParameter("@ativo", ativo))
            If num_cliente = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Localidade,Cod_Postal,Email,Contacto_M,Contacto_F,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno ON Clientes.NºCliente=TipoAluno.N_Cliente where Ativo=@ativo AND NºEmpresa=@n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Localidade,Cod_Postal,Email,Contacto_M,Contacto_F,NºAluno,NºTurma FROM Clientes INNER JOIN TipoAluno ON Clientes.NºCliente=TipoAluno.N_Cliente where NºCliente=@NºCliente AND Ativo=@ativo AND NºEmpresa=@n_empresa", p)
            End If
        End Function
        Shared Function inserir_aluno(ByVal n_aluno As String, ByVal turma As String, ByVal NIF As String, ByVal localidade As String, ByVal nome As String, ByVal morada As String, ByVal cod_postal As String, ByVal email As String, ByVal ativo As Boolean, ByVal contacto_mov As String, ByVal contacto_fix As String)
            Dim p As New ArrayList
            Dim c As New ArrayList
            Dim a As New ArrayList
            Dim check(1) As Integer
            p.Add(New SqlParameter("@Nome", nome))
            p.Add(New SqlParameter("@Morada", morada))
            p.Add(New SqlParameter("@NIF", NIF))
            p.Add(New SqlParameter("@Cod_Postal", cod_postal))
            p.Add(New SqlParameter("@Localidade", localidade))
            p.Add(New SqlParameter("@Email", email))
            p.Add(New SqlParameter("@Ativo", ativo))
            a.Add(New SqlParameter("@naluno", n_aluno))
            a.Add(New SqlParameter("@turma", turma))
            p.Add(New SqlParameter("@contacto_m", contacto_mov))
            p.Add(New SqlParameter("@contacto_f", contacto_fix))
            p.Add(New SqlParameter("@n_empresa", BLL.n_empresa))
            c.Add(New SqlParameter("@company", BLL.n_empresa))
            check(0) = DAL.ExecuteNonQuery("Insert into Clientes(Nome,Morada,NIF,Localidade,Cod_Postal,Email,Ativo,NºEmpresa,Contacto_M,Contacto_F) VALUES (@nome, @morada, @NIF,@Localidade, @cod_postal,@email,@ativo,@n_empresa,@contacto_m,@contacto_f)", p)
            check(1) = DAL.ExecuteScalar("Select MAX(NºCliente) from Clientes where NºEmpresa=@company", c)
            a.Add(New SqlParameter("@NºCliente", check(1)))
            DAL.ExecuteNonQuery("Insert into TipoAluno(N_Cliente,NºAluno,NºTurma) VALUES (@NºCliente,@naluno,@turma)", a)
            Return check
        End Function
        Shared Function alterar_aluno(ByVal n_aluno As String, ByVal turma As String, ByVal numcliente As Integer, ByVal localidade As String, ByVal NIF As String, ByVal nome As String, ByVal morada As String, ByVal cod_postal As String, ByVal email As String, ByVal ativo As Boolean, ByVal contacto_m As String, ByVal contacto_f As String)
            Dim p As New ArrayList
            Dim c As New ArrayList
            Dim check(1) As Integer
            p.Add(New SqlParameter("@numcliente", numcliente))
            p.Add(New SqlParameter("@Nome", nome))
            p.Add(New SqlParameter("@Morada", morada))
            p.Add(New SqlParameter("@NIF", NIF))
            p.Add(New SqlParameter("@Localidade", localidade))
            p.Add(New SqlParameter("@Cod_Postal", cod_postal))
            p.Add(New SqlParameter("@Email", email))
            c.Add(New SqlParameter("@N_Aluno", n_aluno))
            c.Add(New SqlParameter("@turma", turma))
            c.Add(New SqlParameter("@n_cliente", numcliente))
            p.Add(New SqlParameter("@Ativo", ativo))
            p.Add(New SqlParameter("@Contacto_m", contacto_m))
            p.Add(New SqlParameter("@Contacto_f", contacto_f))
            check(0) = DAL.ExecuteNonQuery("Update Clientes set Localidade=@Localidade, Contacto_M = @contacto_m, Contacto_F = @contacto_f, nome = @nome, morada = @morada, NIF= @NIF, Cod_Postal= @cod_postal, Email= @email, Ativo=@Ativo where NºCliente=@numcliente", p)
            DAL.ExecuteNonQuery("Update TipoAluno set NºAluno=@N_Aluno,NºTurma=@turma where N_Cliente=@n_cliente", c)
            Return check
        End Function
        Shared Function carregar(ByVal ativo As Boolean) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_empresa", BLL.n_empresa))
            p.Add(New SqlParameter("@ativo", ativo))
            Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Localidade,Cod_Postal,Email,NIF,Contacto_M,Contacto_F FROM Clientes where Ativo=@ativo AND NºEmpresa=@n_empresa", p)
        End Function
        Shared Function procura_dados(ByRef query As String, ByRef ativo As Boolean) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_empresa", BLL.n_empresa))
            p.Add(New SqlParameter("@ativo", ativo))
            If IsNumeric(query) = True Then
                Dim backup As String = query
                query = "%" & backup & "%"
                p.Add(New SqlParameter("@query", query))
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Localidade,Cod_Postal,Email,Contacto_M,Contacto_F FROM Clientes where (NºCliente like @query or NIF like @query) and Ativo=@ativo AND NºEmpresa=@n_empresa", p)
            Else
                Dim backup As String = query
                query = "%" & backup & "%"
                p.Add(New SqlParameter("@query", query))
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Localidade,Cod_Postal,Email,Contacto_M,Contacto_F FROM Clientes where (nome like @query OR Morada like @query or email like @query or localidade like @query or cod_postal like @query or contacto_m like @query or contacto_f like @query) AND Ativo=@ativo AND NºEmpresa=@n_empresa", p)
            End If
        End Function
        Shared Function carregar_dados_numcliente(ByRef num_cliente As String, ByRef ativo As Boolean) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_empresa", BLL.n_empresa))
            p.Add(New SqlParameter("@NºCliente", num_cliente))
            p.Add(New SqlParameter("@ativo", ativo))
            If num_cliente = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Localidade,Cod_Postal,Email,Contacto_M,Contacto_F FROM Clientes where Ativo=@ativo AND NºEmpresa=@n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Localidade,Cod_Postal,Email,Contacto_M,Contacto_F FROM Clientes where NºCliente=@NºCliente AND Ativo=@ativo AND NºEmpresa=@n_empresa", p)
            End If
        End Function     
        Shared Function inserir(ByVal NIF As String, ByVal localidade As String, ByVal nome As String, ByVal morada As String, ByVal cod_postal As String, ByVal email As String, ByVal ativo As Boolean, ByVal contacto_mov As String, ByVal contacto_fix As String)
            Dim p As New ArrayList
            Dim c As New ArrayList
            Dim check(1) As Integer
            p.Add(New SqlParameter("@Nome", nome))
            p.Add(New SqlParameter("@Morada", morada))
            p.Add(New SqlParameter("@NIF", NIF))
            p.Add(New SqlParameter("@Cod_Postal", cod_postal))
            p.Add(New SqlParameter("@Localidade", localidade))
            p.Add(New SqlParameter("@Email", email))
            p.Add(New SqlParameter("@Ativo", ativo))
            p.Add(New SqlParameter("@contacto_m", contacto_mov))
            p.Add(New SqlParameter("@contacto_f", contacto_fix))
            p.Add(New SqlParameter("@n_empresa", BLL.n_empresa))
            check(0) = DAL.ExecuteNonQuery("Insert into Clientes(Nome,Morada,NIF,Localidade,Cod_Postal,Email,Ativo,NºEmpresa,Contacto_M,Contacto_F) VALUES (@nome, @morada, @NIF,@Localidade, @cod_postal,@email,1,@n_empresa,@contacto_m,@contacto_f)", p)
            Return check
        End Function
        Shared Function alterar(ByVal numcliente As Integer, ByVal localidade As String, ByVal NIF As String, ByVal nome As String, ByVal morada As String, ByVal cod_postal As String, ByVal email As String, ByVal ativo As Boolean, ByVal contacto_m As String, ByVal contacto_f As String)
            Dim p As New ArrayList
            Dim c As New ArrayList
            Dim check(1) As Integer
            p.Add(New SqlParameter("@numcliente", numcliente))
            p.Add(New SqlParameter("@Nome", nome))
            p.Add(New SqlParameter("@Morada", morada))
            p.Add(New SqlParameter("@NIF", NIF))
            p.Add(New SqlParameter("@Localidade", localidade))
            p.Add(New SqlParameter("@Cod_Postal", cod_postal))
            p.Add(New SqlParameter("@Email", email))
            p.Add(New SqlParameter("@Ativo", ativo))
            p.Add(New SqlParameter("@Contacto_m", contacto_m))
            p.Add(New SqlParameter("@Contacto_f", contacto_f))
            check(0) = DAL.ExecuteNonQuery("Update Clientes set Localidade=@Localidade, Contacto_M = @contacto_m, Contacto_F = @contacto_f, nome = @nome, morada = @morada, NIF= @NIF, Cod_Postal= @cod_postal, Email= @email, Ativo=@Ativo where NºCliente=@numcliente", p)
            Return check
        End Function
        Shared Sub apagar(ByVal N_Cliente As String)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NºCliente", N_Cliente))
            If N_Cliente <> Nothing Or N_Cliente <> "" Then
                DAL.ExecuteNonQuery("Update Clientes set Ativo=0 where NºCliente = @NºCliente", p)
                DAL.ExecuteNonQuery("Update Artigos set Ativo=0 where NºCliente=@NºCliente", p)
            End If
        End Sub
        Shared Function reativar_cliente(ByVal N_Cliente As String)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_cliente", N_Cliente))
            Return DAL.ExecuteNonQuery("Update Clientes set Ativo=1 where NºCliente = @n_Cliente", p)
        End Function
    End Class
    Public Class Artigos
        'Shared Sub remover_empresas(ByVal empresa As String)
        '    Dim p As New ArrayList
        '    p.Add(New SqlParameter("@empresa", empresa))
        '    DAL.ExecuteNonQuery("UPDATE Artigos set ativo=0 where nºempresa=@empresa", p)
        'End Sub
        Shared Function check_exist(ByVal numartigo As Integer) As Boolean
            Dim p As New ArrayList
            p.Add(New SqlParameter("@num_empresa", n_empresa))
            p.Add(New SqlParameter("@num_artigo", numartigo))
            Dim check As String = DAL.ExecuteScalar("Select Marca from Artigos where NºEmpresa=@num_empresa and NºArtigo=@num_artigo", p)
            If check <> "" Then
                Return True
            Else
                Return False
            End If
        End Function
        Shared Function carregar(ByRef ativo As Boolean) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            p.Add(New SqlParameter("@ativo", ativo))
            Return DAL.ExecuteQueryDT("SELECT NºArtigo,NºCliente,Marca,Modelo,NºSérie, Observações, Tipo_Artigo FROM Artigos where Ativo=@ativo AND NºEmpresa=@n_empresa", p)
        End Function
        Shared Function procura_dados(ByRef query As String, ByRef n_cliente As String, ByRef ativo As Boolean) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            p.Add(New SqlParameter("@ativo", ativo))
            p.Add(New SqlParameter("@n_cliente", n_cliente))
            If IsNumeric(query) = True Then
                Dim backup As String = query
                query = "%" + backup + "%"
                p.Add(New SqlParameter("@query", query))
                Return DAL.ExecuteQueryDT("SELECT NºArtigo,NºCliente,Marca,Modelo,NºSérie,Observações,Tipo_Artigo FROM Artigos where Ativo=@ativo AND NºEmpresa=@n_empresa AND (NºArtigo like @query) and NºCliente=@n_cliente", p)
            Else
                Dim backup As String = query
                query = "%" + backup + "%"
                p.Add(New SqlParameter("@query", query))
                Return DAL.ExecuteQueryDT("SELECT NºArtigo,NºCliente,Marca,Modelo,NºSérie,Observações,Tipo_Artigo FROM Artigos where Ativo=@ativo AND NºEmpresa=@n_empresa AND (Marca like @query OR Modelo like @query OR NºSérie like @query OR Observações like @query OR Tipo_Artigo like @query) and NºCliente=@n_cliente", p)
            End If
        End Function
        Shared Function carregar_dados_numartigo(ByRef NºArtigo As String, ByRef ativo As Boolean) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_artigo", NºArtigo))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            p.Add(New SqlParameter("@ativo", ativo))
            If NºArtigo = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºArtigo,NºCliente,Marca,Modelo,NºSérie,Observações,Tipo_Artigo FROM Artigos where Ativo=@ativo AND NºEmpresa=@n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºArtigo,NºCliente,Marca,Modelo,NºSérie,Observações,Tipo_Artigo FROM Artigos where NºArtigo=@n_artigo AND Ativo=@ativo AND NºEmpresa=@n_empresa", p)
            End If
        End Function
        Shared Function carregar_dados_numcliente(ByRef NºCliente As String, ativo As Boolean) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_cliente", NºCliente))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            p.Add(New SqlParameter("@ativo", ativo))
            If NºCliente = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºArtigo,NºCliente,Marca,Modelo,NºSérie,Observações,Tipo_Artigo FROM Artigos where Ativo=@ativo AND NºEmpresa=@n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºArtigo,NºCliente,Marca,Modelo,NºSérie,Observações,Tipo_Artigo FROM Artigos where NºCliente=@n_cliente AND Ativo=@ativo AND NºEmpresa=@n_empresa", p)
            End If
        End Function
        Shared Function inserir(ByVal NºCliente As String, ByVal Marca As String, ByVal Modelo As String, ByVal NºSérie As String, ByVal Observações As String, ByVal Tipo_Artigo As String)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NºCliente", NºCliente))
            p.Add(New SqlParameter("@Marca", Marca))
            p.Add(New SqlParameter("@Modelo", Modelo))
            p.Add(New SqlParameter("@NºSérie", NºSérie))
            p.Add(New SqlParameter("@Observações", Observações))
            p.Add(New SqlParameter("@Tipo_Artigo", Tipo_Artigo))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            Return DAL.ExecuteNonQuery("Insert into Artigos(NºCliente,Marca,Modelo,NºSérie,Observações,Tipo_Artigo,NºEmpresa,Ativo) VALUES (@NºCliente, @Marca, @Modelo, @NºSérie,@Observações,@Tipo_Artigo,@n_empresa,1)", p)
        End Function
        Shared Function alterar(ByVal NºArtigo As String, ByVal n_cliente As String, ByVal Marca As String, ByVal Modelo As String, ByVal NºSérie As String, ByVal Observações As String, ByVal Tipo_Artigo As String)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_artigo", NºArtigo))
            p.Add(New SqlParameter("@n_cliente", n_cliente))
            p.Add(New SqlParameter("@Marca", Marca))
            p.Add(New SqlParameter("@Modelo", Modelo))
            p.Add(New SqlParameter("@NºSérie", NºSérie))
            p.Add(New SqlParameter("@Observações", Observações))
            p.Add(New SqlParameter("@Tipo_Artigo", Tipo_Artigo))
            Return DAL.ExecuteNonQuery("Update Artigos set NºCliente = @n_cliente, Marca = @Marca, Modelo= @Modelo, NºSérie= @NºSérie, Observações= @Observações, Tipo_Artigo = @Tipo_Artigo where NºArtigo=@n_artigo", p)
        End Function
        Shared Function apagar(ByVal NºArtigo As String, ByVal NºCliente As String)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NºArtigo", NºArtigo))
            p.Add(New SqlParameter("@NºCliente", NºCliente))
            If NºArtigo <> "" Then
                Return DAL.ExecuteNonQuery("Update Artigos set Ativo=0 where NºArtigo = @NºArtigo", p)
            ElseIf NºCliente <> "" Then
                Return DAL.ExecuteNonQuery("Update Artigos set Ativo=0 where NºCliente = @NºCliente", p)
            Else
                Return -1
            End If
        End Function
        Shared Function restaurar(ByVal NºArtigo As String, ByVal NºCliente As String)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NºArtigo", NºArtigo))
            p.Add(New SqlParameter("@NºCliente", NºCliente))
            If NºArtigo <> "" Then
                Return DAL.ExecuteNonQuery("Update Artigos set Ativo=1 where NºArtigo = @NºArtigo", p)
            ElseIf NºCliente <> "" Then
                Return DAL.ExecuteNonQuery("Update Artigos set Ativo=1 where NºCliente = @NºCliente", p)
            Else
                Return -1
            End If
        End Function
    End Class
    Public Class Reparacoes
        'Shared Sub remover_empresas(ByVal empresa As String)
        '    Dim p As New ArrayList
        '    p.Add(New SqlParameter("@empresa", empresa))
        '    DAL.ExecuteNonQuery("UPDATE Reparações set ativo=0 where nºempresa=@empresa", p)
        'End Sub
        Shared Function carregar(ByRef ativo As Boolean) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            p.Add(New SqlParameter("@ativo", ativo))
            Return DAL.ExecuteQueryDT("SELECT NºReparação,NºArtigo,TemporealReparação,DescAvaria,DIRepar,DFRepar,Preço From Reparações where NºEmpresa=@n_empresa AND Ativo=@ativo", p)
        End Function
        Shared Function procura_dados(ByRef query As String, ByRef ativo As Boolean) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            p.Add(New SqlParameter("@ativo", ativo))
            If IsNumeric(query) = True Then
                Dim backup As String = query
                query = "%" & backup & "%"
                p.Add(New SqlParameter("@query", query))
                Dim check As Boolean = False
                For i = 0 To query.Length - 1
                    If query.Chars(i) = "." Or query.Chars(i) = "," Then
                        check = True
                    End If
                Next
                If check = True Then
                    Return DAL.ExecuteQueryDT("SELECT NºReparação,NºArtigo,TemporealReparação,DescAvaria,DIRepar,DFRepar,Preço from Reparações where (Preço like @query) and NºEmpresa=@n_empresa and Ativo=@ativo", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºReparação,NºArtigo,TemporealReparação,DescAvaria,DIRepar,DFRepar,Preço From Reparações where (NºReparação like @query OR NºArtigo like @query) and NºEmpresa=@n_empresa AND Ativo=@ativo", p)
                End If
            ElseIf IsDate(query) = True Then
                Dim backup As String = query
                query = "%" & backup & "%"
                p.Add(New SqlParameter("@query", query))
                Return DAL.ExecuteQueryDT("SELECT NºReparação,NºArtigo,TemporealReparação,DescAvaria,DIRepar,DFRepar,Preço From Reparações where (DIRepar like @query OR DFRepar like @query) and NºEmpresa=@n_empresa AND Ativo=@ativo", p)
            Else
                Dim backup As String = query
                query = "%" & backup & "%"
                p.Add(New SqlParameter("@query", query))
                p.Add(New SqlParameter("@query", query))
                Return DAL.ExecuteQueryDT("SELECT NºReparação,NºArtigo,TemporealReparação,DescAvaria,DIRepar,DFRepar,Preço From Reparações where DescAvaria like @query AND NºEmpresa=@n_empresa AND Ativo=@ativo", p)
            End If
        End Function
        Shared Function carregar_dados_numreparação(ByRef NºReparação As String, ByRef ativo As Boolean) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_reparação", NºReparação))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            p.Add(New SqlParameter("@ativo", ativo))
            If NºReparação = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºReparação,NºArtigo,TemporealReparação,DescAvaria,DIRepar,DFRepar,Preço From Reparações where NºEmpresa=@n_empresa AND Ativo=@ativo", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºReparação,NºArtigo,TemporealReparação,DescAvaria,DIRepar,DFRepar,Preço From Reparações where NºReparação=@n_reparação AND NºEmpresa=@n_empresa AND Ativo=@ativo", p)
            End If
        End Function
        Shared Function carregar_dados_numartigo(ByRef NºArtigo As String, ByRef ativo As Boolean) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_artigo", NºArtigo))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            p.Add(New SqlParameter("@ativo", ativo))
            If NºArtigo = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºReparação,NºArtigo,TemporealReparação,DescAvaria,DIRepar,DFRepar,Preço From Reparações where NºEmpresa=@n_empresa AND Ativo=@ativo", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºReparação,NºArtigo,TemporealReparação,DescAvaria,DIRepar,DFRepar,Preço From Reparações where NºArtigo=@n_artigo AND NºEmpresa=@n_empresa AND Ativo=@ativo", p)
            End If
        End Function
        Shared Sub inserir(ByVal NºArtigo As Integer, ByVal DescAvaria As String, ByVal DIRepar As DateTime)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_artigo", NºArtigo))
            p.Add(New SqlParameter("@DescAvaria", DescAvaria))
            p.Add(New SqlParameter("@DIRepar", DIRepar))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            DAL.ExecuteNonQuery("Insert into Reparações(NºArtigo,DescAvaria,DIRepar,NºEmpresa,Ativo) VALUES (@n_artigo,@DescAvaria,@DIRepar,@n_empresa,1)", p)
        End Sub
        Shared Sub alterar_datafim(ByVal NºReparação As Integer, ByVal NºArtigo As Integer, ByVal TempoRealReparação As String, ByVal DescAvaria As String, ByVal DIRepar As DateTime, ByVal DFRepar As DateTime, ByVal Preço As String)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NºReparação", NºReparação))
            p.Add(New SqlParameter("@NºArtigo", NºArtigo))
            p.Add(New SqlParameter("@TempoRealReparação", TempoRealReparação))
            p.Add(New SqlParameter("@DescAvaria", DescAvaria))
            p.Add(New SqlParameter("@DIRepar", DIRepar))
            p.Add(New SqlParameter("@DFRepar", DFRepar))
            p.Add(New SqlParameter("@Preço", Preço))

            DAL.ExecuteNonQuery("Update Reparações set NºArtigo = @NºArtigo, TempoRealReparação= @TempoRealReparação, DescAvaria= @DescAvaria, DIRepar = @DIRepar, DFRepar = @DFRepar, Preço = @Preço where NºReparação=@NºReparação", p)
        End Sub
        Shared Function apagar(ByVal id As Integer, ByVal modo As Integer) As String
            Dim p As New ArrayList
            p.Add(New SqlParameter("@id", id))
            If modo = 1 Then
                DAL.ExecuteNonQuery("Update Reparações set Ativo=0 where NºReparação = @id", p)
                Return 1
            ElseIf modo = 2 Then
                DAL.ExecuteNonQuery("Update Reparações set Ativo=0 where NºArtigo = @id", p)
                Return 1
            End If
            Return "Erro ao Apagar da Base-de-Dados"
        End Function
        Shared Function restaurar(ByVal id As Integer, ByVal modo As Integer) As String
            Dim p As New ArrayList
            p.Add(New SqlParameter("@id", id))
            If modo = 1 Then
                DAL.ExecuteNonQuery("Update Reparações set Ativo=1 where NºReparação = @id", p)
                Return 1
            ElseIf modo = 2 Then
                DAL.ExecuteNonQuery("Update Reparações set Ativo=1 where NºArtigo = @id", p)
                Return 1
            End If
            Return "Erro ao Apagar da Base-de-Dados"
        End Function
        Shared Function add_datafim(ByVal DFRepar As DateTime, ByVal Temporeal As String, ByVal n_repar As String)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@DFRepar", DFRepar))
            p.Add(New SqlParameter("@Temporeal", Temporeal))
            p.Add(New SqlParameter("@n_repar", n_repar))
            Return DAL.ExecuteNonQuery("Update Reparações set DFRepar=@DFRepar, TempoRealReparação=@Temporeal where NºReparação=@n_repar", p)
        End Function
    End Class
    Public Class Tecnicos
        'Shared Sub remover_empresas(ByVal empresa As String)
        '    Dim p As New ArrayList
        '    p.Add(New SqlParameter("@empresa", empresa))
        '    DAL.ExecuteNonQuery("UPDATE Técnicos set ativo=0 where nºempresa=@empresa", p)
        'End Sub
        Shared Function check_exist(ByVal nome As String) As Object
            Dim check As Integer
            Dim p As New ArrayList
            p.Add(New SqlParameter("@nome", nome))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            check = DAL.ExecuteScalar("Select NºTécnico FROM Técnicos where Nome=@Nome AND NºEmpresa=@n_empresa", p)
            If check <> 0 Then
                Return 1
            Else
                Return 0
            End If
        End Function
        Public Class Alunos
            Shared Function carregar(ByRef ativo As Boolean) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@n_empresa", n_empresa))
                p.Add(New SqlParameter("@ativo", ativo))
                Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Contacto_M,Contacto_F,Localidade,Cod_Postal,Turma,NºAluno FROM Técnicos where Ativo=@ativo AND NºEmpresa=@n_empresa", p)
            End Function
            Shared Function procura_dados(ByRef query As String, ByRef ativo As Boolean) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@ativo", ativo))
                p.Add(New SqlParameter("@n_empresa", n_empresa))
                If IsNumeric(query) = True Then
                    Dim backup As String = query
                    query = "%" & backup & "%"
                    p.Add(New SqlParameter("@query", query))
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Contacto_M,Contacto_F,Localidade,Cod_Postal,Turma,NºAluno FROM Técnicos where (NºTécnico like @query or Turma like @query or NºAluno like @query) and Ativo=@ativo AND NºEmpresa=@n_empresa", p)
                Else
                    Dim backup As String = query
                    query = "%" & backup & "%"
                    p.Add(New SqlParameter("@query", query))
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Contacto_M,Contacto_F,Localidade,Cod_Postal,Turma,NºAluno FROM Técnicos where (Nome like @query or Morada like @query or Localidade like @query or Contacto_m like @query or contacto_f like @query or cod_postal like @query) AND Ativo=@ativo AND NºEmpresa=@n_empresa", p)
                End If
            End Function  
            Shared Function carregar_dados(ByRef n_tecnico As String, ByRef ativo As Boolean) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@n_tecnico", n_tecnico))
                p.Add(New SqlParameter("@n_empresa", n_empresa))
                p.Add(New SqlParameter("@ativo", ativo))
                If n_tecnico = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Contacto_M,Contacto_F,Localidade,Cod_Postal,Turma,NºAluno,Nome_util,password,pergunta_S,resposta_S FROM Técnicos INNER JOIN utilizadores ON Técnicos.NºTécnico=Utilizadores.N_Técnico where Ativo=@ativo AND NºEmpresa=@n_empresa", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Contacto_M,Contacto_F,Localidade,Cod_Postal,Turma,NºAluno,Nome_util,password,pergunta_S,resposta_S FROM Técnicos INNER JOIN utilizadores ON Técnicos.NºTécnico=Utilizadores.N_Técnico where NºTécnico = @n_tecnico AND Ativo=@ativo AND NºEmpresa=@n_empresa", p)
                End If
            End Function
            Shared Sub inserir(ByVal localidade As String, ByVal cod_postal As String, ByVal contacto_m As String, ByVal contacto_f As String, ByVal Nome As String, ByRef img As Image, ByVal n_aluno As Integer, ByVal turma As String)
                Dim p As New ArrayList
                Dim img_save As New SqlParameter("@fotografia", SqlDbType.Image)
                p.Add(New SqlParameter("@nome", Nome))
                p.Add(New SqlParameter("@localidade", localidade))
                p.Add(New SqlParameter("@cod_postal", cod_postal))
                p.Add(New SqlParameter("@contacto_m", contacto_m))
                p.Add(New SqlParameter("@contacto_f", contacto_f))
                p.Add(New SqlParameter("@turma", turma))
                p.Add(New SqlParameter("@n_aluno", n_aluno))
                Dim mStream As MemoryStream = New MemoryStream()
                img.Save(mStream, ImageFormat.Png)
                img_save.SqlValue = mStream.GetBuffer
                p.Add(img_save)
                p.Add(New SqlParameter("@n_empresa", n_empresa))
                DAL.ExecuteNonQuery("Insert into Técnicos(Nome,Localidade,Cod_Postal,Contacto_M,Contacto_F,Turma,Fotografia,NºAluno,Ativo,NºEmpresa) VALUES (@nome,@localidade,@cod_postal,@contacto_m,@contacto_f,@turma,@fotografia,@n_aluno,1,@n_empresa)", p)
            End Sub
            Shared Sub alterar(ByVal localidade As String, ByVal cod_postal As String, ByVal contacto_m As String, ByVal contacto_f As String, ByVal Nome As String, ByVal n_aluno As Integer, ByVal turma As String, ByVal n_tecnico As Integer)
                Dim p As New ArrayList
                p.Add(New SqlParameter("@nome", Nome))
                p.Add(New SqlParameter("@localidade", localidade))
                p.Add(New SqlParameter("@cod_postal", cod_postal))
                p.Add(New SqlParameter("@contacto_m", contacto_m))
                p.Add(New SqlParameter("@contacto_f", contacto_f))
                p.Add(New SqlParameter("@turma", turma))
                p.Add(New SqlParameter("@n_aluno", n_aluno))
                p.Add(New SqlParameter("@n_tecnico", n_tecnico))
                DAL.ExecuteNonQuery("Update Técnicos set Localidade=@localidade, Cod_Postal=@cod_postal, Contacto_M=@contacto_m, Contacto_F=@contacto_f, Nome = @Nome, Turma=@turma, NºAluno=@n_aluno where NºTécnico=@n_tecnico", p)
            End Sub
            Shared Sub apagar(ByVal n_aluno As String, ByVal n_tecnico As Integer)
                Dim p As New ArrayList
                p.Add(New SqlParameter("@n_tecnico", n_tecnico))
                p.Add(New SqlParameter("@n_aluno", n_aluno))
                If n_tecnico <> "" Then
                    DAL.ExecuteNonQuery("Update Técnicos set Ativo=0 where NºTécnico = @n_tecnico", p)
                ElseIf n_aluno <> "" Then
                    DAL.ExecuteNonQuery("Update Técnicos set Ativo=0 where NºAluno = @n_aluno", p)
                End If
            End Sub
        End Class
        Shared Function carregar_tecnico() As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Técnicos where NºEmpresa=@n_empresa", p)
        End Function
        Shared Function carregar_max()
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            Return DAL.ExecuteScalar("SELECT MAX(NºTécnico) FROM Técnicos where NºEmpresa=@n_empresa", p)
        End Function
        Shared Function carregar(ByRef ativo As Boolean) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            p.Add(New SqlParameter("@ativo", ativo))
            Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Contacto_M,Contacto_F,Localidade,Cod_Postal FROM Técnicos where Ativo=@ativo AND NºEmpresa=@n_empresa", p)
        End Function
        Shared Function procura_dados(ByRef query As String, ByRef ativo As Boolean) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@ativo", ativo))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            If IsNumeric(query) = True Then
                Dim backup As String = query
                query = "%" & backup & "%"
                p.Add(New SqlParameter("@query", query))
                Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Contacto_M,Contacto_F,Localidade,Cod_Postal FROM Técnicos where (NºTécnico like @query) and Ativo=@ativo AND NºEmpresa=@n_empresa", p)
            Else
                Dim backup As String = query
                query = "%" & backup & "%"
                p.Add(New SqlParameter("@query", query))
                Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Contacto_M,Contacto_F,Localidade,Cod_Postal FROM Técnicos where (Nome like @query or Morada like @query or Localidade like @query or Contacto_m like @query or contacto_f like @query or cod_postal like @query) AND Ativo=@ativo AND NºEmpresa=@n_empresa", p)
            End If
        End Function
        Shared Function carregar_dados(ByRef n_tecnico As String, ByRef ativo As Boolean) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_tecnico", n_tecnico))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            p.Add(New SqlParameter("@ativo", ativo))
            If n_tecnico = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Contacto_M,Contacto_F,Localidade,Cod_Postal,Nome_util,password,pergunta_S,resposta_S FROM Técnicos INNER JOIN utilizadores ON Técnicos.NºTécnico=Utilizadores.N_Técnico where Ativo=@ativo AND NºEmpresa=@n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome,Contacto_M,Contacto_F,Localidade,Cod_Postal,Nome_util,password,pergunta_S,resposta_S FROM Técnicos INNER JOIN utilizadores ON Técnicos.NºTécnico=Utilizadores.N_Técnico where NºTécnico=@n_tecnico AND Ativo=@ativo AND NºEmpresa=@n_empresa", p)
            End If
        End Function
        Shared Sub inserir(ByVal localidade As String, ByVal cod_postal As String, ByVal contacto_m As String, ByVal contacto_f As String, ByVal Nome As String, ByRef img As Image)
            Dim p As New ArrayList
            Dim img_save As New SqlParameter("@fotografia", SqlDbType.Image)
            p.Add(New SqlParameter("@nome", Nome))
            p.Add(New SqlParameter("@localidade", localidade))
            p.Add(New SqlParameter("@cod_postal", cod_postal))
            p.Add(New SqlParameter("@contacto_m", contacto_m))
            p.Add(New SqlParameter("@contacto_f", contacto_f))
            Dim mStream As MemoryStream = New MemoryStream()
            img.Save(mStream, ImageFormat.Png)
            img_save.SqlValue = mStream.GetBuffer
            p.Add(img_save)
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            DAL.ExecuteNonQuery("Insert into Técnicos(Nome,Localidade,Cod_Postal,Contacto_M,Contacto_F,Fotografia,Ativo,NºEmpresa) VALUES (@nome,@localidade,@cod_postal,@contacto_m,@contacto_f,@fotografia,1,@n_empresa)", p)
        End Sub
        Shared Sub alterar(ByVal localidade As String, ByVal cod_postal As String, ByVal contacto_m As String, ByVal contacto_f As String, ByVal Nome As String, ByVal img As Image, ByVal n_tecnico As Integer)
            Dim p As New ArrayList
            Dim img_save As New SqlParameter("@Fotografia", SqlDbType.Image)
            p.Add(New SqlParameter("@nome", Nome))
            p.Add(New SqlParameter("@localidade", localidade))
            p.Add(New SqlParameter("@cod_postal", cod_postal))
            p.Add(New SqlParameter("@contacto_m", contacto_m))
            p.Add(New SqlParameter("@contacto_f", contacto_f))
            Dim mStream As MemoryStream = New MemoryStream()
            img.Save(mStream, ImageFormat.Png)
            img_save.SqlValue = mStream.GetBuffer
            p.Add(img_save)
            p.Add(New SqlParameter("@n_tecnico", n_tecnico))
            DAL.ExecuteNonQuery("Update Técnicos set Localidade=@localidade, Cod_Postal=@cod_postal, Contacto_M=,@contacto_m, Contacto_F=@contacto_f, Nome = @Nome, Fotografia=@Fotografia where NºTécnico=@n_tecnico", p)
        End Sub
        Shared Function apagar(ByVal n_tecnico As String)
            Dim p As New ArrayList
            Dim C As New ArrayList
            Dim D As New ArrayList
            p.Add(New SqlParameter("@n_tecnico", n_tecnico))
            C.Add(New SqlParameter("@ntecnico", n_tecnico))
            D.Add(New SqlParameter("@tecnico", n_tecnico))
            If n_tecnico <> "" Then
                If DAL.ExecuteScalar("Select Cod_Utilizador from Utilizadores where NºTécnico=@n_tecnico", p) <> Workspace.user Then
                    DAL.ExecuteNonQuery("Update Utilizadores set Ativo=0 where NºTécnico=@ntecnico", C)
                Else
                    MsgBox("Não foi possível desativar este Utilizador dado que é o que está currentemente em Sessão, mas removemos o seu estado como Técnico", vbOKOnly, "Erro!")
                End If
                Return DAL.ExecuteNonQuery("Update Técnicos set Ativo=0 where NºTécnico = @tecnico", D)
            Else
                MsgBox("Insira o ID do Técnico a Eliminar")
                Return -1
            End If
        End Function
        Shared Function restaurar(ByVal n_tecnico As String)
            Dim p As New ArrayList
            Dim c As New ArrayList
            p.Add(New SqlParameter("@n_tecnico", n_tecnico))
            c.Add(New SqlParameter("@ntecnico", n_tecnico))
            If n_tecnico <> "" Then
                DAL.ExecuteNonQuery("Update Utilizadores set Ativo=1 where NºTécnico=@ntecnico", c)
                MsgBox("O Utilizador deste técnico foi também ativado com o Técnico!", vbOKOnly, "Aviso!")
                Return DAL.ExecuteNonQuery("Update Técnicos set Ativo=1 where NºTécnico = @n_tecnico", p)
            Else
                MsgBox("Insira o ID do Técnico a Eliminar")
                Return -1
            End If
        End Function
    End Class
    Public Class Participacoes
        Shared Sub adicionar_part(ByVal n_tecnico As Integer, ByVal n_reparacao As Integer, ByVal nome As String)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_tecnico", n_tecnico))
            p.Add(New SqlParameter("@nome", nome))
            p.Add(New SqlParameter("@n_reparacao", n_reparacao))
            DAL.ExecuteNonQuery("Insert into Participações(NºReparação,NºTécnico,Nome) VALUES (@n_reparacao,@n_tecnico,@Nome)", p)
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
        Shared Function return_all()
            Return DAL.ExecuteScalar("SELECT Count(NºParticipação) FROM Participações", Nothing)
        End Function
        Shared Function procurar_part(ByVal n_repar As String)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NºReparação", n_repar))
            Return DAL.ExecuteQueryDT("SELECT NºTécnico,Nome FROM Participações where NºReparação=@NºReparação", p)
        End Function
    End Class
    Public Class Hardware
        Shared Sub adicionar_hardware(ByVal n_reparacao As String, tipo As String, preço As String, qtd As String)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_reparacao", n_reparacao))
            p.Add(New SqlParameter("@tipo", tipo))
            p.Add(New SqlParameter("@preço", preço))
            p.Add(New SqlParameter("@qtd", qtd))
            DAL.ExecuteNonQuery("Insert into Hardware(NºReparação,Tipo,preço,qtd) values (@n_reparacao,@tipo,@preço,@qtd)", p)
        End Sub
        Shared Function return_hardware(ByVal n_reparacao As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NºReparação", n_reparacao))
            Return DAL.ExecuteQueryDT("Select Tipo,Qtd,Preço FROM Hardware where NºReparação=@NºReparação", p)
        End Function
        Shared Function delete_hardware(ByVal n_reparacao As String) As String
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NºReparação", n_reparacao))
            Return DAL.ExecuteNonQuery("Delete from Hardware where NºReparação=@NºReparação", p)
        End Function
        Shared Function return_all()
            Return DAL.ExecuteScalar("SELECT Count(NºHardware) FROM Hardware", Nothing)
        End Function
    End Class
    Public Class Software
        Shared Sub adicionar_software(ByVal n_reparacao As String, tipo As String, preço As String)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@n_reparacao", n_reparacao))
            p.Add(New SqlParameter("@tipo", tipo))
            p.Add(New SqlParameter("@preço", preço))
            DAL.ExecuteNonQuery("Insert into Software(NºReparação,Tipo,preço) values (@n_reparacao,@tipo,@preço)", p)
        End Sub
        Shared Function return_software(ByVal n_reparacao As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NºReparação", n_reparacao))
            Return DAL.ExecuteQueryDT("Select Tipo, Preço FROM Software where NºReparação=@NºReparação", p)
        End Function
        Shared Function delete_software(ByVal n_reparacao As String) As String
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NºReparação", n_reparacao))
            Return DAL.ExecuteNonQuery("Delete from Software where NºReparação=@NºReparação", p)
        End Function
        Shared Function return_all()
            Return DAL.ExecuteScalar("SELECT Count(NºSoftware) FROM Software", Nothing)
        End Function
    End Class
End Class


