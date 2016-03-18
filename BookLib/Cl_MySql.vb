Imports MySql.Data.MySqlClient

Public Class Cl_MySql

    Shared Function Connect()
        Dim MyConn As New MySqlConnection
        MyConn.ConnectionString = String.Format("server=localhost; user id=root; password=root; database=booklib; pooling=false")
        MyConn.Open()
        Return MyConn
    End Function

    Shared Function TblLookup(P_Table As String, P_VarList As String, P_Where As String)
        Dim myDataAdapter As New MySqlDataAdapter
        Dim cmd As New MySqlCommand
        cmd.Connection = Conn
        Dim myDataTable As New DataTable
        Dim v_SqlTxt, v_Where As String

        'Set the select command on the DataAdapter
        If Len(P_Where) > 0 Then v_Where = " where " & P_Where Else v_Where = ""
        v_SqlTxt = String.Join(" ", "Select", P_VarList, "from", P_Table, v_Where)
        cmd.CommandText = v_SqlTxt
        '        MsgBox(v_SqlTxt)
        myDataAdapter.SelectCommand = cmd

        'Fill the DataTable
        myDataAdapter.Fill(myDataTable)
        Return myDataTable
    End Function

    Shared Function fnInsertAuthor(P_Surname As String, P_Name As String)
        Dim cmd As New MySqlCommand("", Conn)
        Dim NewID As Integer

        cmd.CommandText = "insert into authors (AuthorSurname, AuthorName)" &
            " values (" &
            " '" & P_Surname & "' " &
            ", '" & P_Name & "')"
        MsgBox(cmd.CommandText)
        cmd.ExecuteScalar()
        cmd.CommandText = ("select last_insert_id()")
        NewID = cmd.ExecuteScalar()
        MsgBox("New Id: " & NewID)
        Return NewID
    End Function

    Shared Function GetParms()
        Dim PrmAdapter As New MySqlDataAdapter
        Dim PrmTable As New DataTable
        Dim Cmd As New MySqlCommand
        Dim CtlRecs As Integer = 0

        Cmd.Connection = Conn
        Cmd.CommandText = "select * from lib_control where ComputerName = '" & Environment.MachineName & "'"
        PrmAdapter.SelectCommand = Cmd
        While CtlRecs < 1
            PrmAdapter.Fill(PrmTable)
            CtlRecs = PrmTable.Rows.Count
            If PrmTable.Rows.Count < 1 Then
                Dim frmLib_Control As New frmLib_Control
                frmLib_Control.ShowDialog()
            End If
        End While
        For Each row In PrmTable.Rows
            PrmNewBookDir = row("new_book_dir")
            PrmReviewedBookDir = row("Reviewed_Book_Dir")
        Next

    End Function
End Class
