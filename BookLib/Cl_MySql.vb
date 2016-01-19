Imports MySql.Data.MySqlClient

Public Class Cl_MySql

    Shared Function Connect()
        Dim MyConn As New MySqlConnection
        MyConn.ConnectionString = String.Format("server=localhost; user id=johan_fj; password=johan; database=booklib; pooling=false")
        MyConn.Open()
        Return MyConn
    End Function
End Class
