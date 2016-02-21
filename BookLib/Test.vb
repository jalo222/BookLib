Public Class Test
    Private Sub BooksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BooksBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BooksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BooklibDataSet)

    End Sub

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BooklibDataSet.authors' table. You can move, or remove it, as needed.
        Me.AuthorsTableAdapter.Fill(Me.BooklibDataSet.authors)
        'TODO: This line of code loads data into the 'BooklibDataSet.books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.BooklibDataSet.books)

    End Sub

    Private Sub BindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveNextItem.Click
    End Sub

    Private Sub AuthorIDComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AuthorIDComboBox.SelectedIndexChanged
        If Me.AuthorIDComboBox.SelectedValue IsNot Nothing Then
            Me.AuthorIDComboBox1.SelectedValue = Me.AuthorIDComboBox.SelectedValue
            MsgBox("Auth id = " & (Me.AuthorIDComboBox.SelectedValue))
            Me.AuthorsBindingSource.Filter = "authorID = " & Me.AuthorIDComboBox.SelectedValue
        End If
    End Sub
End Class