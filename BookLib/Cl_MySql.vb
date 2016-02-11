Imports MySql.Data.MySqlClient

Public Class Cl_MySql

    Shared Function Connect()
        Dim MyConn As New MySqlConnection
        MyConn.ConnectionString = String.Format("server=localhost; user id=root; password=root; database=booklib; pooling=false")
        'MyConn.ConnectionString = String.Format("server=localhost; user id=johan; password=root; database=booklib; pooling=false")
        MyConn.Open()
        Return MyConn
    End Function

    Shared Function fnSearchAuthName(pSurname As String, pName As String)
        Dim MyCmd As New MySqlCommand
        Dim result As Integer

        MyCmd.Connection = Conn
        MyCmd.CommandText = "select count(*) from authors where AuthorSurname = '" + pSurname _
          + "' and AuthorName = '" + pName + "'"
        result = MyCmd.ExecuteScalar()
        Return result
    End Function

End Class
