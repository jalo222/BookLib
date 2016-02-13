Public Class frmImportBooks

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim vFName As String
        Dim vFExt As String
        For Each directory In FileSystemTree2.GetSelectedDirectories()
            For Each ImpFile In directory.GetFiles()
                vFName = ImpFile.Name
                vFExt = ImpFile.Extension
                If vFExt = ".mobi" Then
                    Me.txtBookRef.Text = vFName
                End If
                If vFExt = ".jpg" Then
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
        Me.BooksTableAdapter.Connection = Conn
        Me.BooksTableAdapter.Fill(Me.BooklibDataSet.books)
        Me.AuthorsTableAdapter.Connection = Conn
        Me.AuthorsTableAdapter.Fill(Me.BooklibDataSet.authors)

    End Sub

    Private Sub cmdSave()
        Me.Validate()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        cmdSave()
    End Sub



    Private Sub txtBookRef_TextChanged(sender As Object, e As EventArgs) Handles txtBookRef.TextChanged
        BookNameTextBox.Text = Mid(txtBookRef.Text, 1, InStr(txtBookRef.Text, "-") - 2)
        Dim vAuth As String = Trim(Mid(txtBookRef.Text, InStr(txtBookRef.Text, "-") + 1))
        txtAuthor.Text = Mid(vAuth, 1, InStr(vAuth, ".") - 1)
    End Sub


    Private Sub AuthorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.AuthorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BooklibDataSet)

    End Sub

    Private Sub txtAuthor_TextChanged(sender As Object, e As EventArgs) Handles txtAuthor.TextChanged
        Dim vWrds() As String = Split(Trim(Me.txtAuthor.Text))
        Me.v_FirstName.Text = vWrds(0)
        Me.v_Surname.Text = vWrds(vWrds.Length - 1)
        Dim v_AuthTbl As New DataTable
        v_AuthTbl = Cl_MySql.TblLookup("authors", "*", "AuthorSurname = '" & v_Surname.Text & "' and AuthorName = '" & v_FirstName.Text & "'")
        MsgBox("Found " + Str(v_AuthTbl.Rows.Count) + " author entries.")
        If v_AuthTbl.Rows.Count = 0 Then
            Me.AuthorsBindingSource.AddNew()
            Me.txtAuthorName.Text = v_FirstName.Text
            Me.txtAuthorSurname.Text = v_Surname.Text
        End If
    End Sub
End Class