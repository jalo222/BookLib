Public Class frmCategories
    '    Private Sub CategoriesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.CategoriesBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.BooklibDataSet)

    '    End Sub

    Private Sub Categories_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BooklibDataSet.categories' table. You can move, or remove it, as needed.
        Me.CategoriesTableAdapter.Connection = Conn
        Me.CategoriesTableAdapter.Fill(Me.BooklibDataSet.categories)
        Me.CategoriesBindingSource.Sort = "categoryname asc"
        Me.btnCancel.Visible = False
        Me.btnSave.Visible = False
        Me.btnAdd.Visible = True

    End Sub

    Private Sub Save_DataSet()
        MsgBox("Saving")
        Me.Validate()
        Me.CategoriesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BooklibDataSet)
        Me.btnCancel.Visible = False
        Me.btnSave.Visible = False
        Me.btnAdd.Visible = True
        Me.btnDelete.Visible = True
        Me.ListBox1.Refresh()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Save_DataSet()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.CategoriesBindingSource.AddNew()
        Me.btnCancel.Visible = True
        Me.btnSave.Visible = True
        Me.btnAdd.Visible = False
        Me.btnDelete.Visible = False
        Me.CategoryNameTextBox.Focus()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Me.btnAdd.Visible = False
        Me.btnDelete.Visible = False
        Select Case MessageBox.Show("Do you want to delete category " + Me.CategoryNameTextBox.Text + "? ", "Delete", MessageBoxButtons.OKCancel)
            Case MsgBoxResult.Cancel
                MessageBox.Show("The entry has not been deleted!")
                Me.btnAdd.Visible = True
                Me.btnDelete.Visible = True
            Case MsgBoxResult.Ok
                Me.CategoriesBindingSource.RemoveCurrent()
                Save_DataSet()
        End Select
    End Sub
End Class