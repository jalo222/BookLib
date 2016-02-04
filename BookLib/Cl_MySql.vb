Imports MySql.Data.MySqlClient

Public Class Cl_MySql

    Shared Function Connect()
        Dim MyConn As New MySqlConnection
        MyConn.ConnectionString = String.Format("server=localhost; user id=root; password=root; database=booklib; pooling=false")
        MyConn.Open()
        Return MyConn
    End Function
End Class
