Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Public Class DAL
    Public Shared Connection As SqlConnection = Nothing
    Shared Function CreateConnection() As Integer
        Try
            Connection = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=G:\Users\Emanuel\Documents\Visual Studio 2013\Projects\WindowsApplication1\WindowsApplication1\Resources\BD-C.Alunos.mdf;Integrated Security=True")
            Return 0
        Catch e As Exception
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
            MessageBox.Show(ex.Message)
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
            MessageBox.Show(ex.Message)
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
            MessageBox.Show(ex.Message)
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
            MessageBox.Show(ex.Message)
            Return Nothing
        Finally
            cmdSQL.Dispose()
            CloseConnection()
        End Try
    End Function
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

'Falha no msgbox
' soluçao criar uma msgbox
