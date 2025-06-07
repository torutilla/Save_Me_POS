Imports Mysql.Data.MySqlCLient
Module Module2
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public data As New DataSet
    Public adapter As New MySqlDataAdapter
    Public connectString As String = "server=localhost;username=root;password=;database=dbpos"
    Public conn As New MySqlConnection(connectString)
    Public username As String
    Public Cashier As String
    Public discount As Double
    Public tax As Double
    Public cash As Double
    Public change As Double
    Public allTotal As Double


    Function sqlconnect()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        Return True
    End Function


End Module
