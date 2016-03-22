﻿Imports MySql.Data.MySqlClient

Public Class BookLibStart
    Public MyConn As New MySqlConnection
    Public MyCmd As New MySqlCommand


    Private Sub BookLibStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cntBooks As Integer
        Dim cntAuthors As Integer

        Me.CenterToScreen()
        Conn = Cl_MySql.Connect()
        MyCmd.Connection = Conn
        Cl_MySql.GetParms()

        'MsgBox("Create Dir result = " & clsGenFunc.fnCreateDir("C:\Data\Test_Create_CopyDir"))
        'MsgBox("Move result = " & clsGenFunc.fnCopyDir("C:\Data\Test_CopyDir", "C:\Test", False))
        'MsgBox("move result = " & clsGenFunc.fnCopyDir("C:\", "C:\Data\Test_Dir\kkk", True))
        'MsgBox("Parm incoming = " & PrmNewBookDir & ", Store in " & PrmReviewedBookDir)
        'MyCmd.CommandText = "select count(*) from books"
        'cntBooks = MyCmd.ExecuteScalar
        'MyCmd.CommandText = "select count(*) from authors"
        'cntAuthors = MyCmd.ExecuteScalar
        '        MsgBox("books = " + Str(cntBooks) + ",  Authors = " + Str(cntAuthors))

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

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    '    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim xtab As New DataTable
    '    Dim coldata As String
    '
    '        xtab = Cl_MySql.TblLookup("authors", "*", "categoryname like 'We%'")
    '        MsgBox("Rows = " + Str(xtab.Rows.Count))
    '        coldata = ""
    '    For Each xt In xtab.Rows
    '    For Each col In xtab.Columns
    '                coldata = coldata & " -    " & ((col.ToString) & " " & (xt(col)))
    '    Next
    '            coldata = coldata + Chr(10) + Chr(13)
    '    Next
    '        MsgBox(coldata)
    '    End Sub
End Class
