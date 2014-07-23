Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.IO

Public Class DAL
    Public Shared Connection As SqlConnection = Nothing
    Shared Function CreateConnection() As Integer
        Try
            'Connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=" & Environment.GetEnvironmentVariable("APPDATA") & "\Clínica Informática\BD\BD-C.I.mdf" & ";Integrated Security=True;Connect Timeout=30")
            Connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=|DataDirectory|\Resources\BD-C.I.mdf;Integrated Security=True")
            Return 0
        Catch ex As Exception
            MessageBox.Show("Erro na base-de-dados: " & ex.Message)
            Workspace.Close()
            Return -1
        End Try
    End Function
    Shared Sub OpenConnection()
        If Connection.State <> ConnectionState.Open Then
            Connection.Open()
        End If
    End Sub
    Shared Sub CloseConnection()
        If Connection.State <> ConnectionState.Closed Then
            Connection.Close()
        End If
    End Sub
    Shared Sub TerminateConnection()
        If Connection.State <> ConnectionState.Closed Then
            Connection.Dispose()
        End If
    End Sub
    Shared Function ExecuteScalar(ByVal SQLText As String, ByRef Params As ArrayList) As Object
        Dim cmdSQL As New SqlCommand(SQLText, Connection)
        Try
            If Not (Params Is Nothing) Then
                For Each Param As SqlParameter In Params
                    cmdSQL.Parameters.Add(Param)
                Next
            End If
            OpenConnection()
            Return cmdSQL.ExecuteScalar
        Catch ex As Exception
            MessageBox.Show("Erro na base-de-dados: " & ex.Message)
            Workspace.Close()
            Return -1
        Finally
            cmdSQL.Dispose()
            CloseConnection()
        End Try
    End Function
    Shared Function ExecuteNonQuery(ByVal SQLText As String, ByRef Params As ArrayList) As Integer
        Dim cmdSQL As New SqlCommand(SQLText, Connection)
        Try
            If Params IsNot Nothing Then
                For Each Param As SqlParameter In Params
                    cmdSQL.Parameters.Add(Param)
                Next
            End If
            OpenConnection()
            Return CInt(cmdSQL.ExecuteNonQuery)
        Catch ex As Exception
            MessageBox.Show("Erro na base-de-dados: " & ex.Message)
            Workspace.Close()
            Return -1
        Finally
            CloseConnection()
            cmdSQL.Parameters.Clear()
            cmdSQL.Dispose()
        End Try
    End Function

    Shared Function ExecuteQuery(ByVal SQLText As String, ByRef Params As ArrayList) As ArrayList
        Dim cmdSQL As New SqlCommand(SQLText, Connection)
        Dim Result As New ArrayList
        Try
            If Not (Params Is Nothing) Then
                For Each Param As SqlParameter In Params
                    cmdSQL.Parameters.Add(Param)
                Next
            End If
            OpenConnection()
            Dim dr As SqlDataReader = cmdSQL.ExecuteReader
            While dr.Read()
                For i As Integer = 0 To dr.FieldCount - 1
                    Result.Add(dr(i))
                Next
            End While
            Return Result
        Catch ex As Exception
            MessageBox.Show("Erro na base-de-dados: " & ex.Message)
            Workspace.Close()
            Return Nothing
        Finally
            cmdSQL.Dispose()
            CloseConnection()
        End Try
    End Function
    Shared Function ExecuteQueryDT(ByVal SQLText As String, ByRef Params As ArrayList) As DataTable

        Dim cmdSQL As New SqlDataAdapter(SQLText, Connection)
        Dim Result As New DataTable
        Try
            If Not (Params Is Nothing) Then
                For Each Param As SqlParameter In Params
                    cmdSQL.SelectCommand.Parameters.Add(Param)
                Next
            End If

            OpenConnection()
            'Result.Clear()
            cmdSQL.AcceptChangesDuringFill = True
            cmdSQL.Fill(Result)
            Return Result
        Catch ex As Exception
            MessageBox.Show("Erro na base-de-dados: " & ex.Message)
            Workspace.Close()
            Return Nothing
        Finally
            cmdSQL.Dispose()
            CloseConnection()
        End Try
    End Function
    Shared Sub BackUpDB(ByVal backupfile As String)
        Try
            Dim bakadp As SqlDataAdapter
            Dim bakds As DataSet
            Dim dbname As String = DAL.ExecuteScalar("SELECT DB_NAME() AS DataBaseName", Nothing)
            Dim strbakSQLSentence As String = "BACKUP DATABASE [" & dbname & "] TO DISK = '" & backupfile & "'"
            strbakSQLSentence.Replace("'", Chr(34))
            bakadp = New SqlDataAdapter(strbakSQLSentence, Connection)
            Connection.Open()
            bakds = New DataSet
            bakadp.Fill(bakds)
            Connection.Close()
            MsgBox("Backup feito com êxito!", vbOKOnly, "Êxito!")
        Catch ex As Exception
            MsgBox("Erro ao fazer backup! " & ex.Message)
        Finally
            If Connection.State = ConnectionState.Open Then
                Connection.Close()
                Connection.Dispose()
            End If
        End Try
    End Sub
    Shared Sub RestoreDB(ByVal restorefile As String)
        Try
            Dim resCmd As SqlCommand
            Dim dbname As String = DAL.ExecuteScalar("SELECT DB_NAME() AS DataBaseName", Nothing)
            Dim strResSQLsentencia As String = "RESTORE DATABASE [" & dbname & "] FROM DISK = '" & restorefile & "'"
            connection.Open()
            resCmd = New SqlCommand("ALTER DATABASE [" & dbname & "] SET OFFLINE WITH ROLLBACK IMMEDIATE", connection)
            resCmd.ExecuteNonQuery()
            resCmd = New SqlCommand(strResSQLsentencia, Connection)
            resCmd.ExecuteNonQuery()
            resCmd = New SqlCommand("ALTER DATABASE [" & dbname & "] SET ONLINE", Connection)
            resCmd.ExecuteNonQuery()
            connection.Close()
            MsgBox("Backup restaurado com êxito!")
        Catch ex As Exception
            MsgBox("Não foi possível restaurar! " & ex.Message, vbOKOnly)
        Finally
            If Connection.State = ConnectionState.Open Then
                Connection.Close()
                Connection.Dispose()
            End If
        End Try

    End Sub



    'Shared Sub store_pic_Sql(ByVal img As Image, ByVal id As Integer)
    '    'for SQL 
    '    Dim sql As String = "insert into picture(id,image) values(@id,@imgData)"
    '    Dim command1 As SqlCommand = New SqlCommand(sql, Connection)
    '    Dim sqlpara As New SqlParameter("imgData", SqlDbType.Image)
    '    Dim sqlparaid As New SqlParameter("id", id)
    '    Dim mStream As MemoryStream = New MemoryStream()
    '    img.Save(mStream, ImageFormat.Png)
    '    sqlpara.SqlValue = mStream.GetBuffer
    '    command1.Parameters.Add(sqlpara)
    '    OpenConnection()
    '    command1.ExecuteNonQuery()
    '    CloseConnection()
    'End Sub

    'Shared Function Load_Pic_Sql(ByVal sql As String) As Image
    '    Try
    '        Dim command1 As SqlCommand = New SqlCommand(sql, Connection)
    '        command1.Connection.Open()
    '        Dim reader As SqlDataReader = command1.ExecuteReader
    '        reader.Read()

    '        command1.Connection.Close()
    '        Return img
    '    Catch ex As Exception
    '        MessageBox.Show("Erro na base-de-dados: " & ex.Message)
    '        Workspace.Close()
    '        Return Nothing
    '    End Try
    'End Function
    'Shared Function ExecuteQuery(ByVal SQLText As String, ByRef Params As ArrayList) As DataTable
    '    Dim cmdSQL As New OleDb.OleDbCommand(SQLText, Connection)
    '    Dim Result As New DataTable
    '    Try
    '        For Each Param As OleDb.OleDbParameter In Params
    '            cmdSQL.Parameters.Add(Param)
    '        Next
    '        OpenConnection()
    '        Dim dr As OleDbDataReader = cmdSQL.ExecuteQuery()
    '        If dr.Read() Then
    '            For i As Integer = 0 To dr.FieldCount - 1
    '                Result.Add(dr(i))
    '            Next
    '        End If
    '        Return Result
    '    Catch
    '        Return Nothing
    '    Finally
    '        cmdSQL.Dispose()
    '        CloseConnection()
    '    End Try
    'End Function

End Class