Imports System.Data.SqlClient

Module Connections
    Public ReadOnly ConnectionString As String = _
        "Server=DESKTOP-GO\SQLEXPRESS; Database=memberInfo; Trusted_Connection=True;"

    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(ConnectionString)
    End Function
End Module