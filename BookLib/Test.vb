Public Class Test
    Private Sub AuthorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BooklibDataSet.file_types' table. You can move, or remove it, as needed.
        Me.File_typesTableAdapter.Fill(Me.BooklibDataSet.file_types)
        Me.AuthorsTableAdapter.Fill(Me.BooklibDataSet.authors)
        Me.BooksTableAdapter.Fill(Me.BooklibDataSet.books)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.AuthorsBindingSource.AddNew()
        Me.BooksBindingSource.AddNew()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Validate()
        Me.AuthorsBindingSource.EndEdit()
        Me.File_typesBindingSource.EndEdit()
        Me.BooksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BooklibDataSet)

    End Sub
End Class