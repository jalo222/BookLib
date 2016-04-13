Imports MySql.Data.MySqlClient

Public Class frmLib_Control
    '    Private Sub Lib_controlBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click, MyBaseBindingNavigatorSaveItem.Click
    '    Me.Validate()
    '    Me.Lib_controlBindingSource.EndEdit()
    '    Me.TableAdapterManager.UpdateAll(Me.BooklibDataSet)

    '    End Sub

    Private Sub Lib_Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CntRows As Integer

        Me.CenterToScreen()

        'Me.txtComputerName.Text = Environment.MachineName()
        Me.Lib_controlTableAdapter.Connection = Conn
        Me.Lib_controlTableAdapter.Fill(Me.BooklibDataSet.lib_control)
        Me.Lib_controlBindingSource.Filter = "ComputerName = '" & Environment.MachineName() & "'"
        Dim cmd As New MySqlCommand("select count(*) from lib_control where ComputerName = '" & Environment.MachineName() & "'", Conn)
        CntRows = cmd.ExecuteScalar()
        If CntRows > 0 Then
            Me.Lib_controlBindingSource.MoveFirst()
        Else
            Me.Lib_controlBindingSource.AddNew()
            Me.ComputerNameTextBox.Text = Environment.MachineName()
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

    Private Sub btnBrowseReviewDir_Click(sender As Object, e As EventArgs) Handles btnBrowseReviewDir.Click
        If FolderBrowserDialog.ShowDialog() = DialogResult.OK Then
            Me.Reviewed_Book_DirTextBox.Text = FolderBrowserDialog.SelectedPath
        End If

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.Lib_controlBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BooklibDataSet)

    End Sub

    Private Sub btnBrowseNoFile_Click(sender As Object, e As EventArgs) Handles btnBrowseNoFile.Click
        Using dialog As New OpenFileDialog
            If dialog.ShowDialog() <> DialogResult.OK Then Return
            Me.No_Image_FileTextBox.Text = dialog.FileName
        End Using

    End Sub
End Class