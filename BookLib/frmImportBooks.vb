Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Runtime.InteropServices
Imports System.ComponentModel

Public Class frmImportBooks

    Dim vBook_FExt As String
    Dim vCover_FExt As String
    Dim v_BookName As String
    Dim v_SourceDir As String
    Dim v_SourceParentDir As String
    Dim vCoverName As String
    Dim vReviewFileName As String
    Dim CoverBytes As Byte
    Dim vFromDoc As String
    Dim vToRTF As String

    Dim word As New Microsoft.Office.Interop.Word.Application
    'Dim doc As Microsoft.Office.Interop.Word.Document

    Private Sub PopulateTreeView()
        Dim rootNode As TreeNode

        Dim info As New DirectoryInfo(PrmNewBookDir)
        If info.Exists Then
            rootNode = New TreeNode(info.Name)
            rootNode.Tag = info
            GetDirectories(info.GetDirectories(), rootNode)
            TreeView1.Nodes.Add(rootNode)
        End If

    End Sub

    Private Sub GetDirectories(ByVal subDirs() As DirectoryInfo,
    ByVal nodeToAddTo As TreeNode)

        Dim aNode As TreeNode
        Dim subSubDirs() As DirectoryInfo
        Dim subDir As DirectoryInfo
        For Each subDir In subDirs
            aNode = New TreeNode(subDir.Name, 0, 0)
            aNode.Tag = subDir
            aNode.ImageKey = "folder"
            subSubDirs = subDir.GetDirectories()
            If subSubDirs.Length <> 0 Then
                GetDirectories(subSubDirs, aNode)
            End If
            nodeToAddTo.Nodes.Add(aNode)
        Next subDir

    End Sub


    Private Function fnCheckDir(P_Dir As IO.DirectoryInfo)
        Dim Return_Val As Integer = 0

        If P_Dir.GetDirectories.Count > 0 Then
            MsgBox("Directory " & P_Dir.FullName & " contains sub-directories. Please choose the lowest level directory for importing.")
            Return_Val = 1
        Else
            If P_Dir.GetFiles.Count = 0 Then
                MsgBox("The directory " & P_Dir.FullName & " Is empty. Import has been aborted.")
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
        Me.BooksBindingSource.Filter = "bookID = 0"
        Me.AuthorsBindingSource.Filter = "AuthorID = 0"
        Me.Book_coversBindingSource.Filter = "BookID = 0"
        Me.File_typesBindingSource.Filter = "FileTypeID = 0"
        Me.File_types_copyBindingSource.Filter = "FileTypeID = 0"

        PopulateTreeView()

    End Sub
    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim vFName As String
        Dim vFext As String
        Dim vPath As String
        Dim Retval As Integer = 0
        Dim CurrDir As System.IO.DirectoryInfo
        Dim DirArr() As String
        Dim ImpFile As System.IO.FileInfo

        vCoverName = "No Cover"
        DirArr = PrmNewBookDir.Split("\")
        DirArr(UBound(DirArr)) = ""
        vPath = String.Join("\", DirArr) & TreeView1.SelectedNode.FullPath
        CurrDir = My.Computer.FileSystem.GetDirectoryInfo(vPath)
        v_SourceDir = CurrDir.FullName
        v_SourceParentDir = CurrDir.Parent.FullName
        Retval = fnCheckDir(CurrDir)
        If Retval = 0 Then
            For Each ImpFile In CurrDir.GetFiles()
                vFName = ImpFile.Name
                vFext = Mid(ImpFile.Extension, 2)
                If vFext = "mobi" Or vFext = "epub" Then
                    vBook_FExt = vFext
                    Me.txtBookRef.Text = vFName
                    v_BookName = Mid(txtBookRef.Text, 1, InStr(txtBookRef.Text, "-") - 2)
                    Dim vAuth As String = Trim(Mid(txtBookRef.Text, InStr(txtBookRef.Text, "-") + 1))
                    txtBook.Text = v_BookName
                    txtAuthor.Text = Mid(vAuth, 1, InStr(vAuth, ".") - 1)
                End If
                If vFext = "jpg" Then
                    vCover_FExt = vFext
                    txtCoverFileName.Text = vFName
                    vCoverName = CurrDir.FullName & "\" & vFName
                End If
                If vFext = "docx" Then
                    vReviewFileName = Mid(CurrDir.FullName & "\" & vFName, 1, InStr(CurrDir.FullName & "\" & vFName, ImpFile.Extension) - 1)
                End If
            Next
            Me.BooksBindingSource.RemoveFilter()
            Me.AuthorsBindingSource.RemoveFilter()
            Me.Book_coversBindingSource.RemoveFilter()
            Me.File_typesBindingSource.RemoveFilter()
            Me.File_types_copyBindingSource.RemoveFilter()

            vFromDoc = vReviewFileName & ".docx"
            vToRTF = vReviewFileName & ".rtf"

            Me.TabControl1.SelectedIndex = 1

            ChkBook()
            ChkBookCover()
            ChkAuthor()
            ChkFileTypeBook()
            ChkFileTypeCover()
            MakeRTF()
        End If
    End Sub
    Private Sub MakeRTF()
        'Dim word As New Microsoft.Office.Interop.Word.Application
        Dim doc As Microsoft.Office.Interop.Word.Document

        Try
            doc = word.Documents.Open(vFromDoc)
            word.ActiveDocument.SaveAs(FileName:=vToRTF, FileFormat:=Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatRTF)
            MsgBox("RTF File " & vToRTF & " has been created.")
            '            word.Quit()
            word.ActiveDocument.Close()
        Catch ex As COMException
            MessageBox.Show(ex.ErrorCode & ": " & ex.Message & " Error accessing Word document.")

        End Try
    End Sub

    Private Sub ChkBook()
        Dim v_BookTbl As New DataTable
        v_BookTbl = Cl_MySql.TblLookup("books", "*", "BookName = '" & v_BookName & "'")
        If v_BookTbl.Rows.Count = 0 Then
            Me.BooksBindingSource.AddNew()
            Me.BookNameTextBox.Text = v_BookName
        Else
            Me.BooksBindingSource.Filter = "bookID = " & v_BookTbl.Rows(0).Item("bookID")
        End If
    End Sub

    Private Sub ChkBookCover()
        Dim v_BookCoverTbl As New DataTable
        v_BookCoverTbl = Cl_MySql.TblLookup("book_covers", "*", "BookID = " & Me.BooksBindingSource.Current("BookID").ToString)
        If v_BookCoverTbl.Rows.Count = 0 Then
            Me.Book_coversBindingSource.AddNew()
            Dim Coverbytes = My.Computer.FileSystem.ReadAllBytes(vCoverName)
            If vCoverName <> "No Cover" Then
                PictureBox1.Image = Image.FromStream(New IO.MemoryStream(Coverbytes))
            Else
                PictureBox1.Image = Image.FromFile(PrmNoFileImage)
            End If
        Else
            Me.Book_coversBindingSource.Filter = "bookID = " & Me.BooksBindingSource.Current("BookID").ToString
        End If
        Me.Book_coversBindingSource.Current("BookID") = Me.BooksBindingSource.Current("BookID")
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
            Me.BooksBindingSource.Current("AuthorID") = Me.AuthorsBindingSource.Current("AuthorID")
        Else
            Me.BooksBindingSource.Current("AuthorID") = v_AuthTbl.Rows(0).Item("AuthorID")
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
        Me.BooksBindingSource.Current("FileTypeID") = Me.File_typesBindingSource.Current("FileTypeID")
    End Sub

    Private Sub ChkFileTypeCover()
        Dim v_FtypeTbl As New DataTable
        v_FtypeTbl = Cl_MySql.TblLookup("file_types", "*", "FileExtension = '" & vCover_FExt & "'")
        If v_FtypeTbl.Rows.Count = 0 Then
            Me.File_types_copyBindingSource.AddNew()
            Me.FileExtensionCoverTextBox.Text = vCover_FExt
        Else
            Me.File_types_copyBindingSource.Filter = "FileTypeID = " & v_FtypeTbl.Rows(0).Item("FileTypeID")
        End If
        Me.Book_coversBindingSource.Current("FileTypeID") = Me.File_types_copyBindingSource.Current("FileTypeID")
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

    Private Sub frmImportBooks_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        word.Quit()
        MsgBox("WORD Closed")
    End Sub
End Class