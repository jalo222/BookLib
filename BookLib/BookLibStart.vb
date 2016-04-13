Imports MySql.Data.MySqlClient

Public Class BookLibStart
    Public MyConn As New MySqlConnection
    Public MyCmd As New MySqlCommand


    Private Sub BookLibStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim cntBooks As Integer
        'Dim cntAuthors As Integer

        Me.CenterToScreen()
        Conn = Cl_MySql.Connect()
        MyCmd.Connection = Conn
        Cl_MySql.GetParms()
        'MsgBox("Image = " & PrmNoFileImage)

    End Sub

    Private Sub CategoriesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriesToolStripMenuItem.Click
        Dim frmCategories As New frmCategories
        frmCategories.Show()
    End Sub

    Private Sub ControlFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlFileToolStripMenuItem.Click
        Dim frmLib_Control As New frmLib_Control
        frmLib_Control.Show()
    End Sub

    Private Sub ImportReviewedBooksToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportReviewedBooksToolStripMenuItem.Click
        Dim frmImpBookRev As New frmImportBooks
        frmImpBookRev.Show()
    End Sub

    Private Sub FileTypesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileTypesToolStripMenuItem.Click
        Dim frmFileTypes As New frmFileTypes
        frmFileTypes.Show()
    End Sub

    Private Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem.Click
        Dim frmTest As New Test
        frmTest.Show()
    End Sub

End Class
