Imports System.Data.SqlClient
Imports System.IO
Imports System.Drawing.Imaging

Public Class BLL
    Public Shared n_empresa As String
    Public Class Admin_only
        Public Class Cliente
            Shared Function carregar() As DataTable
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,NºEmpresa FROM Clientes where Ativo=1", Nothing)
            End Function
            Shared Function carregar_eliminados() As DataTable
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,NºEmpresa FROM Clientes where Ativo=0", Nothing)
            End Function
            Shared Function procura_dados_nome(ByRef nome As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@Nome", nome))
                If nome = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF FROM Clientes where Ativo=1", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF FROM Clientes where nome like @nome AND Ativo=1", p)
                End If
            End Function
            Shared Function procura_dados_nome_desativados(ByRef nome As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@Nome", nome))
                If nome = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,NºEmpresa FROM Clientes where Ativo=0", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF,NºEmpresa FROM Clientes where nome like @nome AND Ativo=0", p)
                End If
            End Function
            Shared Function procura_dados_nif(ByRef nif As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@NIF", nif))
                If nif = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa FROM Clientes where Ativo=1", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa FROM Clientes where NIF= @NIF AND Ativo=1", p)
                End If
            End Function
            Shared Function procura_dados_nif_desativados(ByRef nif As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@NIF", nif))
                If nif = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa FROM Clientes where Ativo=0", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa FROM Clientes where NIF like @NIF AND Ativo=0", p)
                End If
            End Function
            Shared Function procura_dados_numcliente(ByRef num_cliente As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@NºCliente", num_cliente))
                If num_cliente = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa FROM Clientes where Ativo=1", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa FROM Clientes where NºCliente=@NºCliente AND Ativo=1", p)
                End If
            End Function
            Shared Function procura_dados_numcliente_desativados(ByRef num_cliente As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@NºCliente", num_cliente))
                If num_cliente = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa FROM Clientes where Ativo=0", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa FROM Clientes where NºCliente=@NºCliente AND Ativo=0", p)
                End If
            End Function
            Shared Function procura_dados_nempresa(ByRef n_empresa As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@NºEmpresa", n_empresa))
                If n_empresa = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa FROM Clientes where Ativo=1", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa FROM Clientes where NºEmpresa=@Empresa AND Ativo=1", p)
                End If
            End Function
            Shared Function procura_dados_nempresa_desativados(ByRef n_empresa As String) As DataTable
                Dim p As New ArrayList
                p.Add(New SqlParameter("@NºEmpresa", n_empresa))
                If n_empresa = "" Then
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa FROM Clientes where Ativo=0", p)
                Else
                    Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email,NºEmpresa FROM Clientes where NºEmpresa=@Empresa AND Ativo=0", p)
                End If
            End Function
            Shared Function remover_empresa(ByRef n_empresa As String) As Integer
                Dim p As New ArrayList
                p.Add(New SqlParameter("n_empresa", n_empresa))
                Return DAL.ExecuteNonQuery("Delete FROM Clientes where NºEmpresa=@n_empresa", p)
                Return DAL.ExecuteNonQuery("Delete FROM Contactos where NºEmpresa=@n_empresa", p)
            End Function
        End Class
        Public Class Login
            Shared Function carregar_users() As DataTable
                Return DAL.ExecuteQueryDT("SELECT NºAluno,MºTécnico,Fotografia,Nome_Util,Password,Admin,NºEmpresa FROM Clientes where Ativo=1", Nothing)
            End Function
            Shared Function carregar_users_eliminados() As DataTable
                Return DAL.ExecuteQueryDT("SELECT NºAluno,MºTécnico,Fotografia,Nome_Util,Password,Admin,NºEmpresa FROM Clientes where Ativo=0", Nothing)
            End Function
            Shared Function Add_login(ByVal admin_geral As Boolean, ByVal admin As Boolean, ByVal img As Image, ByRef num_tecnico As Integer, ByRef num_aluno As Integer, ByRef user As String, ByRef pass As String, ByVal n_empresa As String)
                Dim p As New ArrayList
                Dim img_save As New SqlParameter("fotografia", SqlDbType.Image)
                p.Add(New SqlParameter("n_aluno", num_aluno))
                p.Add(New SqlParameter("n_tecnico", num_tecnico))
                Dim mStream As MemoryStream = New MemoryStream()
                img.Save(mStream, ImageFormat.Png)
                img_save.SqlValue = mStream.GetBuffer
                p.Add(img_save)
                p.Add(New SqlParameter("user", user))
                p.Add(New SqlParameter("password", pass))
                p.Add(New SqlParameter("n_empresa", n_empresa))
                p.Add(New SqlParameter("admin", admin))
                p.Add(New SqlParameter("admin_geral", admin_geral))
                Return DAL.ExecuteNonQuery("Insert into Utilizadores(NºAluno,MºTécnico,Fotografia,Nome_Util,Password,Admin_Geral,Admin,Ativo,NºEmpresa) VALUES (@n_aluno, @n_tecnico, @fotografia, @user,@pass,@Admin_Geral,@admin,1,NºEmpresa)", p)
            End Function
            Shared Function remove_login_empresa(ByVal n_empresa As String)
                Dim p As ArrayList
                p.Add(New SqlParameter("n_empresa", n_empresa))
                Return DAL.ExecuteNonQuery("Delete From Utilizadores where NºEmpresa=@n_empresa", p)
            End Function
        End Class
    End Class
    Public Class Login
        Shared Function Verificar_Login(ByRef user As String, ByRef pass As String, ByRef empresa As Integer) As Integer
            Dim sqlparams As New ArrayList
            Dim data1 As DataTable
            sqlparams.Add(New SqlParameter("user", user))
            sqlparams.Add(New SqlParameter("password", pass))
            sqlparams.Add(New SqlParameter("n_empresa", empresa))
            data1 = DAL.ExecuteQueryDT("select * from Utilizadores where Nome_util=@user AND Password=@password AND where NºEmpresa=@n_empresa", sqlparams)
            If data1.Rows.Count <> 0 Then
                Return 1
            Else
                Return 0
            End If
        End Function

        Shared Function Add_login(ByVal img As Image, ByRef num_tecnico As Integer, ByRef num_aluno As Integer, ByRef user As String, ByRef pass As String, ByRef empresa As String) As Integer
            Dim p As New ArrayList
            Dim img_save As New SqlParameter("fotografia", SqlDbType.Image)
            p.Add(New SqlParameter("n_aluno", num_aluno))
            p.Add(New SqlParameter("n_tecnico", num_tecnico))
            Dim mStream As MemoryStream = New MemoryStream()
            img.Save(mStream, ImageFormat.Png)
            img_save.SqlValue = mStream.GetBuffer
            p.Add(img_save)
            p.Add(New SqlParameter("user", user))
            p.Add(New SqlParameter("password", pass))
            p.Add(New SqlParameter("n_empresa", n_empresa))
            Return DAL.ExecuteNonQuery("Insert into Utilizadores(NºAluno,MºTécnico,Fotografia,Nome_Util,Password,Admin,Ativo,NºEmpresa) VALUES (@n_aluno, @n_tecnico, @fotografia, @user,@pass,@admin,1,NºEmpresa)", p)
        End Function
        Shared Function Remove_Login(ByVal n_user As Integer) As Integer
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_user", n_user))
            Return DAL.ExecuteNonQuery("Update Utilizadores set Ativo=0 where Cod_Utilizador=@n_user", p)
        End Function
        Shared Function carregar_users(ByRef empresa As Integer) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", empresa))
            Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email FROM Clientes where Ativo=1 AND NºEmpresa=@n_empresa", p)
        End Function
        Shared Function carregar_users_eliminados(ByRef empresa As Integer) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", empresa))
            Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email FROM Clientes where Ativo=0 AND NºEmpresa=@n_empresa", p)
        End Function
    End Class
    Public Class Clientes
        Shared Function carregar() As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", n_empresa))
            Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF FROM Clientes where Ativo=1 AND NºEmpresa=n_empresa", Nothing)
        End Function
        Shared Function carregar_eliminados() As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", n_empresa))
            Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF FROM Clientes where Ativo=0 AND NºEmpresa=n_empresa", Nothing)
        End Function
        Shared Function procura_dados_nome(ByRef nome As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", n_empresa))
            p.Add(New SqlParameter("@Nome", nome))
            If nome = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF FROM Clientes where Ativo=1 AND NºEmpresa=n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF FROM Clientes where nome like @nome AND Ativo=1 AND NºEmpresa=n_empresa", p)
            End If
        End Function
        Shared Function procura_dados_nome_desativados(ByRef nome As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", n_empresa))
            p.Add(New SqlParameter("@Nome", nome))
            If nome = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF FROM Clientes where Ativo=0 AND NºEmpresa=n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,Cod_Postal,Email,NIF FROM Clientes where nome like @nome AND Ativo=0 AND NºEmpresa=n_empresa", p)
            End If
        End Function
        Shared Function procura_dados_nif(ByRef nif As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", n_empresa))
            p.Add(New SqlParameter("@NIF", nif))
            If nif = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email FROM Clientes where Ativo=1 AND NºEmpresa=n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email FROM Clientes where NIF= @NIF AND Ativo=1 AND NºEmpresa=n_empresa", p)
            End If
        End Function
        Shared Function procura_dados_nif_desativados(ByRef nif As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", n_empresa))
            p.Add(New SqlParameter("@NIF", nif))
            If nif = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email FROM Clientes where Ativo=0 AND NºEmpresa=n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email FROM Clientes where NIF= @NIF AND Ativo=0 AND NºEmpresa=n_empresa", p)
            End If
        End Function
        Shared Function procura_dados_numcliente(ByRef num_cliente As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", n_empresa))
            p.Add(New SqlParameter("@NºCliente", num_cliente))
            If num_cliente = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email FROM Clientes where Ativo=1 AND NºEmpresa=n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email FROM Clientes where NºCliente=@NºCliente AND Ativo=1 AND NºEmpresa=n_empresa", p)
            End If
        End Function
        Shared Function procura_dados_numcliente_desativados(ByRef num_cliente As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("n_empresa", n_empresa))
            p.Add(New SqlParameter("@NºCliente", num_cliente))
            If num_cliente = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email FROM Clientes where Ativo=0 AND NºEmpresa=n_empresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºCliente,Nome,Morada,NIF,Cod_Postal,Email FROM Clientes where NºCliente=@NºCliente AND Ativo=0 AND NºEmpresa=n_empresa", p)
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
            c.Add(New SqlParameter("@Contacto_m", contacto_mov))
            c.Add(New SqlParameter("@Contacto_f", contacto_fix))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            c.Add(New SqlParameter("@n_empresa", n_empresa))
            check(0) = DAL.ExecuteNonQuery("Insert into Clientes(Nome,Morada,NIF,Cod_Postal,Email,Ativo,NºEmpresa) VALUES (@nome, @morada, @NIF, @cod_postal,@email,1,@n_empresa)", p)
            check(1) = DAL.ExecuteNonQuery("Insert into Contactos(NºCliente,Contacto Móvel,Contacto Fixo,NºEmpresa) VALUES ((Select Max(NºCliente) from Clientes),@Contacto_m,@Contacto_f,@n_empresa)", c)
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
            c.Add(New SqlParameter("@Contacto_m", contacto_m))
            c.Add(New SqlParameter("@Contacto_f", contacto_f))
            c.Add(New SqlParameter("@NºCliente", numcliente))
            p.Add(New SqlParameter("@n_empresa", n_empresa))
            c.Add(New SqlParameter("@n_empresa", n_empresa))
            check(0) = DAL.ExecuteNonQuery("Update Clientes set nome = @nome, morada = @morada, NIF= @NIF, Cod_Postal= @cod_postal, Email= @email where NºCliente=@numcliente AND NºEmpresa=@n_empresa", p)
            check(1) = DAL.ExecuteNonQuery("Update Contactos set Contacto Móvel = @contacto_m, Contacto Fixo = @contacto_f where NºCliente = @numcliente AND NºEmpresa=@n_empresa", c)
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
                DAL.ExecuteNonQuery("Update Dispositivos set Ativo=0 where NºDispositivo = @NºDispositivo", p)
            ElseIf NºCliente <> "" Then
                DAL.ExecuteNonQuery("Update Dispositivos set Ativo=0 where NºCliente = @NºCliente", p)
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
                Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar From Reparações where NºEmpresa=@NºEmpresa", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºReparação,NºDispositivo,Categoria,NºTécnico,TemporealReparação,DescAvaria,DIRepar,DFRepar From Reparações where NºReparação=@NºReparação AND NºEmpresa=@NºEmpresa", p)
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
            DAL.ExecuteNonQuery("Insert into Reparações(NºReparação,NºDispositivo,Categoria,NºTécnico,TempoRealReparação,DescAvaria,DIRepar,DFRepar,NºEmpresa,Ativo) VALUES (@NºReparação, @NºDispositivo, @Categoria, @NºTécnico,@TempoRealReparação,@DIRepar,@DFRepar,@NºEmpresa,1)", p)
            DAL.ExecuteNonQuery("Insert into Software(NºSoftware,NºReparação,Tipo) VALUES ((Select Max(NºReparação) from Reparações),@NºSoftware,@Tipo", s)
            DAL.ExecuteNonQuery("Insert into Hardware(NºHardware,NºReparação,Tipo) VALUES ((Select Max(NºReparação) From Reparações),@NºHarware,@Tipo", h)
        End Sub
        Shared Sub alterar(ByVal NºReparação As Integer, ByVal NºDispositivo As Integer, ByVal Categoria As String, ByVal NºTécnico As Integer, ByVal TempoRealReparação As String, ByVal DescAvaria As String, ByVal DIRepar As String, ByVal DFRepar As String, ByVal NºEmpresa As Integer, ByVal tipo_hard As String, ByVal tipo_soft As String)
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
            s.Add(New SqlParameter("@NºReparação", NºReparação))
            s.Add(New SqlParameter("@Tipo_hard", tipo_hard))
            h.Add(New SqlParameter("@NºReparação", NºReparação))
            h.Add(New SqlParameter("@Tipo_soft", tipo_soft))
            Try
                DAL.ExecuteNonQuery("Update Reparações set NºDispositivo = @NºDispositivo, Categoria = @Categoria, NºTécnico= @NºTécnico, TempoRealReparação= @TempoRealReparação, DescAvaria= @DescAvaria, DIRepar = @DIRepar, DFRepar = @DFRepar where NºReparação=@NºReparação", p)
                DAL.ExecuteNonQuery("Update Software set Tipo = @Tipo_soft where NºReparação = @NºReparação", s)
                DAL.ExecuteNonQuery("Update Hardware set Tipo = @Tipo_hard where NºReparação = @NºReparação", h)
            Catch e As Exception
                MsgBox("Erro ao editar os dados: " & e.Message)
            Finally
                MsgBox("Reparação editada com sucesso")
            End Try
        End Sub
        Shared Function apagar(ByVal NºReparação As Integer, ByVal NºDispositivo As Integer) As String
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NºReparação", NºReparação))
            p.Add(New SqlParameter("@NºDispositivo", NºDispositivo))
            Try
                If NºReparação <> "" Then
                    DAL.ExecuteNonQuery("Delete from Reparações where NºReparação = @NºReparação", p)
                    DAL.ExecuteNonQuery("Delete from Software where NºReparação=@NºReparação", p)
                    DAL.ExecuteNonQuery("Delete from Hardware where NºReparação=@NºReparação", p)
                    Return 1
                ElseIf NºDispositivo <> "" Then
                    DAL.ExecuteNonQuery("Delete from Reparações where NºDispositivo = @NºDispositivo", p)
                    Return 1
                Else
                    Return "Insira algum dado"
                End If
            Catch e As Exception
                Return "Erro ao Apagar da Base-de-Dados"
            End Try
        End Function
    End Class
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
        Shared Function procura_dados_nutilizador_ativados(ByRef Nome_Util As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@Nome_Util", Nome_Util))
            If Nome_Util = "" Then
                Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, NºAluno, NºTécnico, Fotografia, Nome_Util, Password, Admin, Admin_Geral, Ativo, NºEmpresa FROM Utilizadores Where Ativo=1", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, NºAluno, NºTécnico, Fotografia, Nome_Util, Password, Admin, Admin_Geral, Ativo, NºEmpresa FROM Utilizadores where Nome_Util like @Nome_Util AND Ativo=1", p)
            End If
        End Function
        Shared Function procura_dados_codutilizador_desativados(ByRef Cod_Utilizador As Integer) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@Cod_Utilizador", Cod_Utilizador))
            If Cod_Utilizador = "" Then
                Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, NºAluno, NºTécnico, Fotografia, Nome_Util, Password, Admin, Admin_Geral, Ativo, NºEmpresa FROM Utilizadores Where Ativo=0", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, NºAluno, NºTécnico, Fotografia, Nome_Util, Password, Admin, Admin_Geral, Ativo, NºEmpresa FROM Utilizadores where Cod_Utilizador= @Cod_Utilizador AND Ativo=0", p)
            End If
        End Function
        Shared Function procura_dados_codutilizador_ativados(ByRef Cod_Utilizador As Integer) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@Cod_Utilizador", Cod_Utilizador))
            If Cod_Utilizador = "" Then
                Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, NºAluno, NºTécnico, Fotografia, Nome_Util, Password, Admin, Admin_Geral, Ativo, NºEmpresa FROM Utilizadores Where Ativo=1", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, NºAluno, NºTécnico, Fotografia, Nome_Util, Password, Admin, Admin_Geral, Ativo, NºEmpresa FROM Utilizadores where Cod_Utilizador= @Cod_Utilizador AND Ativo=1", p)
            End If
        End Function
        Shared Function procura_dados_naluno_desativados(ByRef NºAluno As Integer) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NºAluno", NºAluno))
            If NºAluno = "" Then
                Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, NºAluno, NºTécnico, Fotografia, Nome_Util, Password, Admin, Admin_Geral, Ativo, NºEmpresa FROM Utilizadores where Ativo=0", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, NºAluno, NºTécnico, Fotografia, Nome_Util, Password, Admin, Admin_Geral, Ativo, NºEmpresa FROM Utilizadores where NºAluno=@NºAluno AND Ativo=0", p)
            End If
        End Function
        Shared Function procura_dados_naluno_ativados(ByRef NºAluno As Integer) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NºAluno", NºAluno))
            If NºAluno = "" Then
                Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, NºAluno, NºTécnico, Fotografia, Nome_Util, Password, Admin, Admin_Geral, Ativo, NºEmpresa FROM Utilizadores where Ativo=1", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT Cod_Utilizador, NºAluno, NºTécnico, Fotografia, Nome_Util, Password, Admin, Admin_Geral, Ativo, NºEmpresa FROM Utilizadores where NºAluno=@NºAluno AND Ativo=1", p)
            End If
        End Function
        Shared Sub inserir(ByVal NºAluno As Integer, ByVal NºTécnico As Integer, ByVal Fotografia As Image, ByVal Nome_Util As String, ByVal Password As String, ByVal Admin As Boolean, ByVal Admin_Geral As Boolean, ByVal Ativo As Boolean, ByVal NºEmpresa As Integer)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NºAluno", NºAluno))
            p.Add(New SqlParameter("@NºTécnico", NºTécnico))
            p.Add(New SqlParameter("@Fotografia", Fotografia))
            p.Add(New SqlParameter("@Nome_Util", Nome_Util))
            p.Add(New SqlParameter("@Password", Password))
            p.Add(New SqlParameter("@Admin", Admin))
            p.Add(New SqlParameter("@Admin_Geral", Admin_Geral))
            p.Add(New SqlParameter("@Ativo", Ativo))
            p.Add(New SqlParameter("@NºEmpresa", NºEmpresa))
            DAL.ExecuteNonQuery("Insert into Utilizadores(NºAluno,NºTécnico,Fotografia,Nome_Util,Password,Admin,Admin_Geral,Ativo,NºEmpresa) VALUES (@NºAluno, @NºTécnico, @Fotografia, @Nome_Util,@Password,@Admin,@Admin_Geral,1,@NºEmpresa)", p)
        End Sub
        Shared Sub alterar(ByVal Cod_Utilizador As Integer, ByVal NºAluno As Integer, ByVal NºTécnico As Integer, ByVal Fotografia As Image, ByVal Nome_Util As String, ByVal Password As String, ByVal Admin As Boolean, ByVal Admin_Geral As Boolean, ByVal Ativo As Boolean, ByVal NºEmpresa As Integer)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NºAluno", NºAluno))
            p.Add(New SqlParameter("@NºTécnico", NºTécnico))
            p.Add(New SqlParameter("@Fotografia", Fotografia))
            p.Add(New SqlParameter("@Nome_Util", Nome_Util))
            p.Add(New SqlParameter("@Password", Password))
            p.Add(New SqlParameter("@Admin", Admin))
            p.Add(New SqlParameter("@Admin_Geral", Admin_Geral))
            p.Add(New SqlParameter("@Ativo", Ativo))
            p.Add(New SqlParameter("@NºEmpresa", NºEmpresa))
            Try
                DAL.ExecuteNonQuery("Update Utilizadores set NºAluno = @NºAluno, NºTécnico = @NºTécnico, Fotografia= @Fotografia, Nome_Util= @Nome_Util, Password= @Password. Admin= @Admin, Admin_Geral= @Admin_Geral, Ativo= @Ativo, NºEmpresa= @NºEmpresa where Cod_Utilizador=@Cod_Utilizador", p)
            Catch e As Exception
                MsgBox("Erro ao editar os dados: " & e.Message)
            Finally
                MsgBox("Utilizador editado com sucesso")
            End Try
        End Sub
        Shared Sub apagar(ByVal Cod_Utilizador As Integer, ByVal Nome_Util As String)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@Cod_Utilizador", Cod_Utilizador))
            p.Add(New SqlParameter("@Nome_Util", Nome_Util))
            If Cod_Utilizador <> "" Then
                DAL.ExecuteNonQuery("Update Utilizadores set Ativo=0 where Cod_Utilizador = @Cod_Utilizador", p)
            ElseIf Nome_Util <> "" Then
                DAL.ExecuteNonQuery("Update Utilizadores set Ativo=0 where Nome_Util = @Nome_Util", p)
            End If
        End Sub
    End Class
    Public Class Empresas
        Shared Function carregar() As DataTable
            Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade,Logo FROM Empresas where Ativo=1", Nothing)
        End Function
        Shared Function carregar_eliminados() As DataTable
            Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade,Logo FROM Empresas where Ativo=0", Nothing)
        End Function
        Shared Function procura_dados_Nome_desativados(ByRef Nome As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@Nome", Nome))
            If Nome = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade,Logo FROM Empresas where Ativo=0", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade,Logo FROM Empresas where Nome like @Nome AND Ativo=0", p)
            End If
        End Function
        Shared Function procura_dados_Nome_ativados(ByRef Nome As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@Nome", Nome))
            If Nome = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade,Logo FROM Empresas where Ativo=1", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade,Logo FROM Empresas where Nome like @Nome AND Ativo=1", p)
            End If
        End Function
        Shared Function procura_dados_nif_desativados(ByRef NIF As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NIF", NIF))
            If NIF = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade,Logo FROM Empresas where Ativo=0", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade,Logo FROM Empresas where NIF= @NIF AND Ativo=0", p)
            End If
        End Function
        Shared Function procura_dados_nif_ativados(ByRef NIF As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NIF", NIF))
            If NIF = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade,Logo FROM Empresas where Ativo=1", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade,Logo FROM Empresas where NIF= @NIF AND Ativo=1", p)
            End If
        End Function
        Shared Function procura_dados_numempresa_desativados(ByRef NºEmpresa As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NºEmpresa", NºEmpresa))
            If NºEmpresa = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade,Logo FROM Empresas where Ativo=0", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade,Logo FROM Empresas where NºCliente=@NºCliente AND Ativo=0", p)
            End If
        End Function
        Shared Function procura_dados_numempresa_ativados(ByRef NºEmpresa As String) As DataTable
            Dim p As New ArrayList
            p.Add(New SqlParameter("@NºEmpresa", NºEmpresa))
            If NºEmpresa = "" Then
                Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade,Logo FROM Empresas where Ativo=1", p)
            Else
                Return DAL.ExecuteQueryDT("SELECT NºEmpresa,Nome,Morada,NIF,Cod_Postal,Localidade,Logo FROM Empresas where NºCliente=@NºCliente AND Ativo=1", p)
            End If
        End Function
        Shared Sub inserir(ByVal Nome As String, ByVal Morada As String, ByVal NIF As String, ByVal Cod_Postal As String, ByVal Localidade As String, ByVal Logo As Image, ByVal Ativo As Boolean)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@Nome", Nome))
            p.Add(New SqlParameter("@Morada", Morada))
            p.Add(New SqlParameter("@NIF", NIF))
            p.Add(New SqlParameter("@Cod_Postal", Cod_Postal))
            p.Add(New SqlParameter("@Localidade", Localidade))
            p.Add(New SqlParameter("@Logo", Logo))
            p.Add(New SqlParameter("@Ativo", Ativo))
            DAL.ExecuteNonQuery("Insert into Empresas(Nome,Morada,NIF,Cod_Postal,Localidade,Logo,Ativo) VALUES (@nome, @morada, @NIF, @cod_postal,@Localidade,@Logo,1)", p)
        End Sub
        Shared Sub alterar(ByVal NºEmpresa As Integer, ByVal Nome As String, ByVal Morada As String, ByVal NIF As String, ByVal Cod_Postal As String, ByVal Localidade As String, ByVal Logo As Image, ByVal ativo As Boolean)
            Dim p As New ArrayList
            p.Add(New SqlParameter("@Nome", Nome))
            p.Add(New SqlParameter("@Morada", Morada))
            p.Add(New SqlParameter("@NIF", NIF))
            p.Add(New SqlParameter("@Cod_Postal", Cod_Postal))
            p.Add(New SqlParameter("@Localidade", Localidade))
            p.Add(New SqlParameter("@Logo", Logo))
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


End Class


