Public Class Test
    Private Sub BooksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BooksBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BooksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BooklibDataSet)

    End Sub

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BooklibDataSet.file_types' table. You can move, or remove it, as needed.
        Me.File_typesTableAdapter.Fill(Me.BooklibDataSet.file_types)
        'TODO: This line of code loads data into the 'BooklibDataSet.authors' table. You can move, or remove it, as needed.
        Me.AuthorsTableAdapter.Fill(Me.BooklibDataSet.authors)
        'TODO: This line of code loads data into the 'BooklibDataSet.books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.BooklibDataSet.books)

    End Sub

    Private Sub FileTypeIDLabel_Click(sender As Object, e As EventArgs)
    End Sub


    Private Sub BookNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles BookNameTextBox.TextChanged
        Me.AuthorIDComboBox.SelectedItem = 16

    End Sub
End Class