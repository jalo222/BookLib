Public Class frmImportBooks
    Dim vFExt As String
    Dim v_BookName As String

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim vFName As String
        For Each directory In FileSystemTree2.GetSelectedDirectories()
            For Each ImpFile In directory.GetFiles()
                vFName = ImpFile.Name
                ' MsgBox("Name = " & vFName)
                vFExt = ImpFile.Extension
                If vFExt = ".mobi" Or vFExt = ".epub" Then
                    Me.v_FileType.Text = vFExt
                    Me.txtBookRef.Text = vFName
                    v_BookName = Mid(txtBookRef.Text, 1, InStr(txtBookRef.Text, "-") - 2)
                    Dim vAuth As String = Trim(Mid(txtBookRef.Text, InStr(txtBookRef.Text, "-") + 1))
                    txtAuthor.Text = Mid(vAuth, 1, InStr(vAuth, ".") - 1)
                End If
                If vFExt = ".jpg" Then
                    Me.PictureBox1.Image = Image.FromFile(directory.FullName + "\" + vFName)
                    txtCoverFileName.Text = vFName
                End If
            Next
            ChkBook()
            ChkAuthor()
            ChkFileType()
        Next
    End Sub
    Private Sub ChkBook()
        Dim v_BookTbl As New DataTable
        v_BookTbl = Cl_MySql.TblLookup("books", "*", "BookName = '" & Me.txtBookName.Text & "'")
        MsgBox("book cnt = " & v_BookTbl.Rows.Count)
        If v_BookTbl.Rows.Count = 0 Then
            Me.BooksBindingSource.AddNew()
            Me.txtBookName.Text = v_BookName
        Else
            Me.BooksBindingSource.Filter = "bookID = " & v_BookTbl.Rows(0).Item("bookID")
        End If
    End Sub

    Private Sub ChkAuthor()
        'Dim NewAuthID As Integer
        Dim vWrds() As String = Split(Trim(Me.txtAuthor.Text))
        Me.v_FirstName.Text = vWrds(0)
        Me.v_Surname.Text = vWrds(vWrds.Length - 1)
        Dim v_AuthTbl As New DataTable
        v_AuthTbl = Cl_MySql.TblLookup("authors", "*", "AuthorSurname = '" & v_Surname.Text & "' and AuthorName = '" & v_FirstName.Text & "'")
        If v_AuthTbl.Rows.Count = 0 Then
            Me.AuthorsBindingSource.AddNew()
            Me.txtAuthorName.Text = v_FirstName.Text
            Me.txtAuthorSurname.Text = v_Surname.Text
        Else
            'NewAuthID = v_AuthTbl.Rows(0).Item("AuthorID")
            Me.AuthorsBindingSource.Filter = "AuthorID = " & v_AuthTbl.Rows(0).Item("AuthorID")
        End If
        '        Me.txtBookAuthID.Text = Me.txtAuthorID.Text
    End Sub

    Private Sub ChkFileType()
        Dim v_FtypeTbl As New DataTable
        v_FtypeTbl = Cl_MySql.TblLookup("file_types", "*", "FileExtension = '" & v_FileType.Text & "'")
        If v_FtypeTbl.Rows.Count = 0 Then
            Me.File_typesBindingSource.AddNew()
            Me.txtFileExtension.Text = v_FileType.Text
        Else
            Me.File_typesBindingSource.Filter = "FileTypeID = " & v_FtypeTbl.Rows(0).Item("FileTypeID")
        End If
        '        Me.txtBookFileTypeID.Text = txtFileTypeID.Text
    End Sub

    Private Sub Book_coversBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        cmdSave()
    End Sub

    Private Sub frmImportBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BooksTableAdapter.Connection = Conn
        Me.BooksBindingSource.Filter = "BookID = null"
        Me.BooksTableAdapter.Fill(Me.BooklibDataSet.books)
        Me.AuthorsBindingSource.Filter = "AuthorID = null"
        Me.AuthorsTableAdapter.Connection = Conn
        Me.AuthorsTableAdapter.Fill(Me.BooklibDataSet.authors)
        Me.File_typesBindingSource.Filter = "FileTypeID = null"
        Me.File_typesTableAdapter.Connection = Conn
        Me.File_typesTableAdapter.Fill(Me.BooklibDataSet.file_types)

    End Sub

    Private Sub cmdSave()
        Me.Validate()
        Me.BooksBindingSource.EndEdit()
        Me.AuthorsBindingSource.EndEdit()
        Me.File_typesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BooklibDataSet)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        cmdSave()
    End Sub



    Private Sub txtBookRef_TextChanged(sender As Object, e As EventArgs) Handles txtBookRef.TextChanged
        'txtBookName.Text = Mid(txtBookRef.Text, 1, InStr(txtBookRef.Text, "-") - 2)
        'Dim vAuth As String = Trim(Mid(txtBookRef.Text, InStr(txtBookRef.Text, "-") + 1))
        'txtAuthor.Text = Mid(vAuth, 1, InStr(vAuth, ".") - 1)
    End Sub



    Private Sub txtFileTypeID_TextChanged(sender As Object, e As EventArgs) Handles txtFileTypeID.TextChanged

    End Sub
End Class