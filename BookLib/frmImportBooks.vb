﻿Imports System.ComponentModel

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
                    'Me.v_FileType.Text = vFExt
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
            'ChkFileType()
        Next
    End Sub
    Private Sub ChkBook()
        Dim v_BookTbl As New DataTable
        v_BookTbl = Cl_MySql.TblLookup("books", "*", "BookName = '" & v_BookName & "'")
        If v_BookTbl.Rows.Count = 0 Then
            Me.BooksBindingSource.AddNew()
            Me.BookNameTextBox.Text = v_BookName
            MsgBox("Added new book")
        Else
            Me.BooksBindingSource.Filter = "bookID = " & v_BookTbl.Rows(0).Item("bookID")
        End If
        'Me.BookNameTextBox.Text = txtBookName.Text
        Me.FileTypeIDComboBox.SelectedValue = 14
        ChkAuthor()
        'Me.AuthorsBindingSource.EndEdit()
        '        Me.AuthorIDComboBox.Text = Me.AuthorsBindingSource.Item(0).ToString
    End Sub

    Private Sub ChkAuthor()
        'Dim NewAuthID As Integer
        Dim vWrds() As String = Split(Trim(Me.txtAuthor.Text))
        'Me.v_FirstName.Text = vWrds(0)
        'Me.v_Surname.Text = vWrds(vWrds.Length - 1)
        Dim v_AuthTbl As New DataTable
        v_AuthTbl = Cl_MySql.TblLookup("authors", "*", "AuthorSurname = '" & vWrds(vWrds.Length - 1) & "' and AuthorName = '" & vWrds(0) & "'")
        If v_AuthTbl.Rows.Count = 0 Then
            MsgBox("Add new author")
            Me.AuthorsBindingSource.AddNew()
            Me.AuthorNameTextBox.Text = vWrds(0) 'v_FirstName.Text
            Me.AuthorSurnameTextBox.Text = vWrds(vWrds.Length - 1) 'v_Surname.Text
            'MsgBox("endedit authors")
            Me.AuthorFullNameTextBox.Text = Me.AuthorSurnameTextBox.Text & " " & Me.AuthorNameTextBox.Text
            Me.AuthorsBindingSource.EndEdit()
            Me.AuthorIDComboBox.SelectedText = Me.AuthorFullNameTextBox.Text
        Else
            Me.AuthorsBindingSource.Filter = "AuthorID = " & v_AuthTbl.Rows(0).Item("AuthorID")
            Me.AuthorIDComboBox.SelectedValue = v_AuthTbl.Rows(0).Item("AuthorID")
        End If
    End Sub

    Private Sub ChkFileType()
        'Dim v_FtypeTbl As New DataTable
        'v_FtypeTbl = Cl_MySql.TblLookup("file_types", "*", "FileExtension = '" & v_FileType.Text & "'")
        'If v_FtypeTbl.Rows.Count = 0 Then
        'Me.File_typesBindingSource.AddNew()
        ''Me.txtFileExtension.Text = v_FileType.Text
        ' Else
        'Me.File_typesBindingSource.Filter = "FileTypeID = " & v_FtypeTbl.Rows(0).Item("FileTypeID")
        'End If
        '        Me.txtBookFileTypeID.Text = txtFileTypeID.Text
    End Sub

    Private Sub Book_coversBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        cmdSave()
    End Sub

    Private Sub frmImportBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BooklibDataSet.file_types' table. You can move, or remove it, as needed.
        Me.File_typesTableAdapter.Fill(Me.BooklibDataSet.file_types)
        Me.TableAdapterManager.Connection = Conn
        Me.BooksTableAdapter.Connection = Conn
        Me.AuthorsTableAdapter.Connection = Conn
        'Me.File_typesTableAdapter.Connection = Conn
        Me.BooksBindingSource.Filter = "BookID = null"
        Me.BooksTableAdapter.Fill(Me.BooklibDataSet.books)
        '        Me.AuthorsBindingSource.Filter = "AuthorID = null"
        Me.AuthorsTableAdapter.Fill(Me.BooklibDataSet.authors)
        'Me.File_typesBindingSource.Filter = "FileTypeID = null"
        'Me.File_typesTableAdapter.Fill(Me.BooklibDataSet.file_types)

    End Sub

    Private Sub cmdSave()
        Me.AuthorIDComboBox.Text = Me.AuthorIDTextBox.Text
        Me.Validate()
        Me.AuthorsBindingSource.EndEdit()
        'Me.File_typesBindingSource.EndEdit()
        Me.BooksBindingSource.EndEdit()
        Try
            MsgBox("Updating")
            TableAdapterManager.UpdateAll(BooklibDataSet)
        Catch
            MsgBox("Update error")
        End Try

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        cmdSave()
    End Sub

    Private Sub BooksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        'Me.Validate()
        'Me.BooksBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me.BooklibDataSet)

    End Sub

    Private Sub BooksBindingSource_AddingNew(sender As Object, e As AddingNewEventArgs) Handles BooksBindingSource.AddingNew
        'MsgBox("endedit authors")
        'Me.AuthorsBindingSource.EndEdit()
    End Sub

End Class