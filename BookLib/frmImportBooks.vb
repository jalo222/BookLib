Public Class frmImportBooks
    Private Sub FileSystemTree2_Load(sender As Object, e As EventArgs) Handles FileSystemTree2.Load

    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim vPath As String
        For Each directory In FileSystemTree2.GetSelectedDirectories()
            'vPath = Me.FileSystemTree2.GetSelectedDirectories()
            MsgBox("Path name: " + directory.FullName)
            For Each ImpFile In My.Computer.FileSystem.GetFiles(directory.FullName)
                '                MsgBox("file: " + ImpFile + " - " + Mid(ImpFile, Len(ImpFile) - 2))
                If Mid(ImpFile, Len(ImpFile) - 2) = "jpg" Then
                    '                    MsgBox("file: " + ImpFile)
                    Me.PictureBox1.Image = Image.FromFile(ImpFile)
                End If
            Next
        Next
    End Sub
End Class