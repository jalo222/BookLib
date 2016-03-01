Public Class Test
    Private Sub BooksBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BooksBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.BooksBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BooklibDataSet)

    End Sub

    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Conn = Cl_MySql.Connect()
        'TODO: This line of code loads data into the 'BooklibDataSet.authors' table. You can move, or remove it, as needed.
        Me.AuthorsTableAdapter.Fill(Me.BooklibDataSet.authors)
        'TODO: This line of code loads data into the 'BooklibDataSet.books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.BooklibDataSet.books)
        Me.AuthorsBindingSource.AddNew()

    End Sub
End Class