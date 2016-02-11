Public Class frmFileTypes

    Private Sub File_typesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles File_typesBindingNavigatorSaveItem.Click
        subSave()
    End Sub

    Private Sub subSave()
        Me.Validate()
        Me.File_typesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BooklibDataSet)

    End Sub
    Private Sub frmFileTypes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BooklibDataSet.file_types' table. You can move, or remove it, as needed.
        Me.File_typesTableAdapter.Fill(Me.BooklibDataSet.file_types)

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        subSave()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.File_typesBindingSource.AddNew()
    End Sub
End Class