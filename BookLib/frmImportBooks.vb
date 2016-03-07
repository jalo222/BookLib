Public Class frmImportBooks
    Dim vBook_FExt As String
    Dim vCover_FExt As String
    Dim v_BookName As String

    Private Sub BooksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.BooksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BooklibDataSet)

    End Sub

    Private Sub frmImportBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        Dim CoverFType As New DataTable("File_Types")
        BooklibDataSet.Tables.Add(CoverFType)
        Me.TableAdapterManager.Connection = Conn
        Me.BooksTableAdapter.Connection = Conn
        Me.AuthorsTableAdapter.Connection = Conn
        Me.File_typesTableAdapter.Connection = Conn
        Me.File_types_copyTableAdapter.Connection = Conn
        Me.Book_coversTableAdapter.Connection = Conn
        Me.File_types_copyTableAdapter.Connection = Conn
        Me.File_types_copyTableAdapter.Fill(Me.BooklibDataSet.file_types_copy)
        Me.File_typesTableAdapter.Fill(Me.BooklibDataSet.file_types)
        Me.Book_coversTableAdapter.Fill(Me.BooklibDataSet.book_covers)
        Me.File_types_copyTableAdapter.Fill(Me.BooklibDataSet.file_types_copy)
        Me.AuthorsTableAdapter.Fill(Me.BooklibDataSet.authors)
        Me.BooksTableAdapter.Fill(Me.BooklibDataSet.books)

    End Sub
    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim vFName As String
        Dim vFext As String
        For Each directory In FileSystemTree2.GetSelectedDirectories()
            For Each ImpFile In directory.GetFiles()
                vFName = ImpFile.Name
                vFext = Mid(ImpFile.Extension, 2)
                If vFExt = "mobi" Or vFExt = "epub" Then
                    vBook_FExt = vFext
                    Me.txtBookRef.Text = vFName
                    v_BookName = Mid(txtBookRef.Text, 1, InStr(txtBookRef.Text, "-") - 2)
                    Dim vAuth As String = Trim(Mid(txtBookRef.Text, InStr(txtBookRef.Text, "-") + 1))
                    txtAuthor.Text = Mid(vAuth, 1, InStr(vAuth, ".") - 1)
                End If
                If vFext = "jpg" Then
                    vCover_FExt = vFext
                    Me.PictureBox1.Image = Image.FromFile(directory.FullName + "\" + vFName)
                    txtCoverFileName.Text = vFName
                End If
            Next
            ChkBook()
            ChkAuthor()
            ChkFileTypeBook()
            ChkFileTypeCover()
        Next
    End Sub
    Private Sub ChkBook()
        Dim v_BookTbl As New DataTable
        v_BookTbl = Cl_MySql.TblLookup("books", "*", "BookName = '" & v_BookName & "'")
        If v_BookTbl.Rows.Count = 0 Then
            Me.BooksBindingSource.AddNew()
            Me.Book_coversBindingSource.AddNew()
            Me.BookNameTextBox.Text = v_BookName
            Me.CoverBookID.Text = Me.BookIDTextBox.Text
        Else
            Me.BooksBindingSource.Filter = "bookID = " & v_BookTbl.Rows(0).Item("bookID")
        End If
    End Sub

    Private Sub ChkAuthor()
        Dim vWrds() As String = Split(Trim(Me.txtAuthor.Text))
        Dim v_AuthTbl As New DataTable
        v_AuthTbl = Cl_MySql.TblLookup("authors", "*", "AuthorSurname = '" & vWrds(vWrds.Length - 1) & "' and AuthorName = '" & vWrds(0) & "'")
        If v_AuthTbl.Rows.Count = 0 Then
            Me.AuthorsBindingSource.AddNew()
            Me.AuthorNameTextBox.Text = vWrds(0) 'v_FirstName.Text
            Me.AuthorSurnameTextBox.Text = vWrds(vWrds.Length - 1) 'v_Surname.Text
            Me.AuthorFullNameTextBox.Text = Me.AuthorNameTextBox.Text & " " & Me.AuthorSurnameTextBox.Text
            Me.BookAuthorIDTextBox.Text = Me.AuthorIDTextBox.Text
        Else
            Me.AuthorsBindingSource.Filter = "AuthorID = " & v_AuthTbl.Rows(0).Item("AuthorID")
        End If
    End Sub

    Private Sub ChkFileTypeBook()
        Dim v_FtypeTbl As New DataTable
        v_FtypeTbl = Cl_MySql.TblLookup("file_types", "*", "FileExtension = '" & vBook_FExt & "'")
        If v_FtypeTbl.Rows.Count = 0 Then
            Me.File_typesBindingSource.AddNew()
            Me.FileExtensionBookTextBox.Text = vBook_FExt
            'Me.BookFileTypeIDTextBox.Text = FileTypeIDBookTextBox.Text
        Else
            Me.File_typesBindingSource.Filter = "FileTypeID = " & v_FtypeTbl.Rows(0).Item("FileTypeID")
        End If
        Me.BookFileTypeIDTextBox.Text = FileTypeIDBookTextBox.Text
    End Sub

    Private Sub ChkFileTypeCover()
        Dim v_FtypeTbl As New DataTable
        v_FtypeTbl = Cl_MySql.TblLookup("file_types", "*", "FileExtension = '" & vCover_FExt & "'")
        If v_FtypeTbl.Rows.Count = 0 Then
            Me.File_types_copyBindingSource.AddNew()
            Me.FileExtensionCoverTextBox.Text = vCover_FExt
            'Me.CoverFileTypeID.Text = FileTypeIDCoverTextBox.Text
        Else
            Me.File_typesBindingSource.Filter = "FileTypeID = " & v_FtypeTbl.Rows(0).Item("FileTypeID")
        End If
        Me.CoverFileTypeID.Text = FileTypeIDCoverTextBox.Text
    End Sub

    Private Sub cmdSave()
        Me.Validate()
        Me.AuthorsBindingSource.EndEdit()
        Me.File_typesBindingSource.EndEdit()
        Me.BooksBindingSource.EndEdit()
        Me.File_types_copyBindingSource.EndEdit()
        Me.Book_coversBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BooklibDataSet)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        cmdSave()
    End Sub
End Class