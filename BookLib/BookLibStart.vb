Imports MySql.Data.MySqlClient

Public Class BookLibStart
    Public MyConn As New MySqlConnection
    Public MyCmd As New MySqlCommand


    Private Sub BookLibStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cntBooks As Integer
        Dim cntAuthors As Integer

        Me.CenterToScreen()
        Conn = Cl_MySql.Connect()
        MyCmd.Connection = Conn
        MyCmd.CommandText = "select count(*) from books"
        cntBooks = MyCmd.ExecuteScalar
        MyCmd.CommandText = "select count(*) from authors"
        cntAuthors = MyCmd.ExecuteScalar
        '        MsgBox("books = " + Str(cntBooks) + ",  Authors = " + Str(cntAuthors))

    End Sub

    Private Sub CategoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriesToolStripMenuItem.Click
        Dim frmCategories As New Categories
        frmCategories.Show()
    End Sub

    Private Sub ControlFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlFileToolStripMenuItem.Click
        Dim frmLib_Control As New Lib_Control
        frmLib_Control.Show()
    End Sub

    Private Sub ImportReviewedBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportReviewedBooksToolStripMenuItem.Click
        Dim frmImpBookRev As New frmImportBooks
        frmImpBookRev.Show()
    End Sub
End Class
