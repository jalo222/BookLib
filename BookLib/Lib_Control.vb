Imports MySql.Data.MySqlClient

Public Class Lib_Control
    '    Private Sub Lib_controlBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.Lib_controlBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.BooklibDataSet)

    '    End Sub

    Private Sub Lib_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CntRows As Integer

        Me.CenterToScreen()

        'TODO: This line of code loads data into the 'BooklibDataSet.lib_control' table. You can move, or remove it, as needed.
        Me.Lib_controlTableAdapter.Connection = Conn
        Me.Lib_controlTableAdapter.Fill(Me.BooklibDataSet.lib_control)
        Dim cmd As New MySqlCommand("select count(*) from lib_control", Conn)
        CntRows = cmd.ExecuteScalar()
        If CntRows > 0 Then
            Me.Lib_controlBindingSource.MoveFirst()
        Else
            Me.Lib_controlBindingSource.AddNew()
        End If

    End Sub

    Private Sub btnBrowseNewDir_Click(sender As Object, e As EventArgs) Handles btnBrowseNewDir.Click
        If FolderBrowserDialog.ShowDialog() = DialogResult.OK Then
            Me.New_Book_DirTextBox.Text = FolderBrowserDialog.SelectedPath
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class