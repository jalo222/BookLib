Imports MySql.Data.MySqlClient

Public Class Cl_MySql

    Shared Function Connect()
        Dim MyConn As New MySqlConnection
        MyConn.ConnectionString = String.Format("server=localhost; user id=root; password=root; database=booklib; pooling=false")
        MyConn.Open()
        Return MyConn
    End Function

    Shared Function FetchCatgories(P_VarList As String, P_Where As string)
        Dim myDataAdapter As New MySqlDataAdapter
        Dim cmd As New MySqlCommand("Select * From categories", Conn)
        Dim myDataTable As New DataTable
        Dim v_SqlTxt, v_Where As String

        'Set the select command on the DataAdapter
        If Len(P_Where) > 0 Then v_Where = " where " & P_Where Else v_where = ""
        v_SqlTxt = String.Join(" ", "Select", P_VarList, "from categories", v_Where)
        cmd.CommandText = v_SqlTxt
        myDataAdapter.SelectCommand = cmd

        'Fill the DataTable
        myDataAdapter.Fill(myDataTable)
        Return myDataTable
    End Function
End Class
