Public Class Test
    Private Sub BooksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BooksBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BooksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BooklibDataSet)

    End Sub

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.File_typesTableAdapter.Fill(Me.BooklibDataSet.file_types)
        Me.AuthorsTableAdapter.Fill(Me.BooklibDataSet.authors)
        Me.BooksTableAdapter.Fill(Me.BooklibDataSet.books)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.AuthorsBindingSource.AddNew()
        Me.BooksBindingSource.AddNew()
    End Sub

    Private Sub Save()
        Me.Validate()
        Me.AuthorsBindingSource.EndEdit()
        Me.File_typesBindingSource.EndEdit()
        Me.BooksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BooklibDataSet)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Save()
    End Sub
End Class