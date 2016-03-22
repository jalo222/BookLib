Imports MySql.Data.MySqlClient

Public Class frmImportBooks

    Dim vBook_FExt As String
    Dim vCover_FExt As String
    Dim v_BookName As String
    Dim v_SourceDir As String
    Dim v_SourceParentDir As String

    Private Function fnCheckDir(P_Dir As IO.DirectoryInfo)
        Dim Return_Val As Integer = 0

        If P_Dir.GetDirectories.Count > 0 Then
            MsgBox("Directory " & P_Dir.FullName & " contains sub-directories. Please choose the lowest level directory for importing.")
            Return_Val = 1
        Else
            If P_Dir.GetFiles.Count = 0 Then
                MsgBox("The directory " & P_Dir.FullName & " is empty. Import has been aborted.")
                Return_Val = 1
            End If
        End If

        Return Return_Val
    End Function

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
        Dim Retval As Integer = 0

        For Each directory In FileSystemTree2.GetSelectedDirectories()
            v_SourceDir = directory.FullName
            v_SourceParentDir = directory.Parent.FullName
            'MsgBox("Parent dir = " & v_SourceParentDir)
            Retval = fnCheckDir(directory)
            If Retval = 0 Then
                For Each ImpFile In directory.GetFiles()
                    vFName = ImpFile.Name
                    vFext = Mid(ImpFile.Extension, 2)
                    If vFext = "mobi" Or vFext = "epub" Then
                        vBook_FExt = vFext
                        Me.txtBookRef.Text = vFName
                        v_BookName = Mid(txtBookRef.Text, 1, InStr(txtBookRef.Text, "-") - 2)
                        Dim vAuth As String = Trim(Mid(txtBookRef.Text, InStr(txtBookRef.Text, "-") + 1))
                        txtAuthor.Text = Mid(vAuth, 1, InStr(vAuth, ".") - 1)
                    End If
                    If vFext = "jpg" Then
                        vCover_FExt = vFext
                        txtCoverFileName.Text = vFName
                        Dim bytes = My.Computer.FileSystem.ReadAllBytes(directory.FullName & "\" & vFName)
                        PictureBox1.Image = Image.FromStream(New IO.MemoryStream(bytes))
                    End If
                Next
                ChkBook()
                ChkAuthor()
                ChkFileTypeBook()
                ChkFileTypeCover()
            End If
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
        MoveBookDir()

    End Sub

    Private Sub MoveBookDir()
        Dim v_DestParentDir As String
        Dim v_DestBookDir As String

        v_DestParentDir = Me.AuthorsBindingSource.Current("AuthorFullName")
        v_DestBookDir = Me.BooksBindingSource.Current("BookName")
        'MsgBox("Move from: " & Me.AuthorsBindingSource.Current("AuthorFullName") & Chr(13) & Chr(10) & Chr(13) & Chr(10) _
        '    & "Move to: " & Me.BooksBindingSource.Current("BookName"))
        clsGenFunc.fnMoveDir(v_SourceDir, PrmReviewedBookDir & "\" & v_DestParentDir & "\" & v_DestBookDir)
        Dim ChkDir As New System.IO.DirectoryInfo(v_SourceParentDir)
        If ChkDir.GetDirectories.Count = 0 Then
            If ChkDir.GetFiles.Count = 0 Then
                clsGenFunc.fnDelDir(v_SourceParentDir)
            Else
                MsgBox("Directory " & v_SourceParentDir & " contains " & Str(ChkDir.GetFiles.Count) & " files")
            End If
        Else
            MsgBox("Directory " & v_SourceParentDir & " contains " & Str(ChkDir.GetDirectories.Count) & " directories")

        End If

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        cmdSave()
    End Sub

End Class