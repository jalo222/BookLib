Public Class frmImpNewBookReview
    Private Sub FileSystemTree1_Load(sender As Object, e As EventArgs) Handles FileSystemTree1.Load
        Me.FileSystemTree1.RootDrive = "C:\Users\Johan\Documents\EBooks1"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.FileSystemTree1.RootDrive = "C:\Users\Johan\Documents\EBooks1"
    End Sub
End Class