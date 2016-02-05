Public Class frmImportBooks

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim vFName As String
        Dim vFExt As String
        '        Me.Book_coversBindingSource.AddNew()
        For Each directory In FileSystemTree2.GetSelectedDirectories()
            'For Each ImpDir In My.Computer.FileSystem.GetFiles(directory.FullName)
            For Each ImpFile In directory.GetFiles()
                vFName = ImpFile.Name
                vFExt = ImpFile.Extension
                'MsgBox("file: " + vFName + "  Ext: " + vFExt + "  Fullname: " + directory.FullName + "\" + vFName)
                If vFExt = ".mobi" Then
                    Me.txtBookRef.Text = vFName
                End If
                If vFExt = ".jpg" Then
                    'Me.Book_coversBindingSource.AddNew()
                    Me.PictureBox1.Image = Image.FromFile(directory.FullName + "\" + vFName)
                    txtCoverFileName.Text = vFName
                End If
            Next
            'Next
        Next
End sub

    Private Sub Book_coversBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        cmdSave()
    End Sub

    Private Sub frmImportBooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BooklibDataSet.books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.BooklibDataSet.books)
        'TODO: This line of code loads data into the 'BooklibDataSet.authors' table. You can move, or remove it, as needed.
        Me.AuthorsTableAdapter.Fill(Me.BooklibDataSet.authors)
        '        Me.Book_coversTableAdapter.Connection = Conn
        '        Me.AuthorsTableAdapter.Connection = Conn
        'TODO: This line of code loads data into the 'BooklibDataSet1.authors' table. You can move, or remove it, as needed.
        '        Me.AuthorsTableAdapter.Fill(Me.BooklibDataSet.authors)
        'TODO: This line of code loads data into the 'BooklibDataSet1.book_covers' table. You can move, or remove it, as needed.
        '        Me.Book_coversTableAdapter.Fill(Me.BooklibDataSet.book_covers)

    End Sub

    Private Sub cmdSave()
        MsgBox("Saving")
        Me.Validate()
        '        Me.Book_coversBindingSource.EndEdit()
        '        Me.TableAdapterManager.UpdateAll(Me.BooklibDataSet)
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        cmdSave()
    End Sub



    Private Sub txtBookRef_TextChanged(sender As Object, e As EventArgs) Handles txtBookRef.TextChanged
        ' MsgBox("split text " + Str(InStr(Me.txtBookRef.Text, "-")) + "  " + Me.txtBookRef.Text)
        Me.BookNameTextBox.Text = Mid(Me.txtBookRef.Text, 1, InStr(Me.txtBookRef.Text, "-") - 2)
        Dim vAuth As String = Trim(Mid(Me.txtBookRef.Text, InStr(Me.txtBookRef.Text, "-") + 1))
        ' Me.txtAuthor.Text = Mid(Me.txtBookRef.Text, InStr(Me.txtBookRef.Text, "-") + 1)
        Me.txtAuthor.Text = Mid(vAuth, 1, InStr(vAuth, ".") - 1)
    End Sub


    Private Sub AuthorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AuthorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BooklibDataSet)

    End Sub

    Private Sub txtAuthor_TextChanged(sender As Object, e As EventArgs) Handles txtAuthor.TextChanged
        MsgBox("Name")
        Dim vWrds() As String = Split(Trim(Me.txtAuthor.Text))
        '       For i As Integer = 0 To vWrds.Length - 1
        '       MsgBox(Str(i) + " - " + vWrds(i))
        '       Next
        Me.v_FirstName.Text = vWrds(0)
    End Sub
End Class