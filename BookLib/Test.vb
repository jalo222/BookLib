Imports System.Runtime.InteropServices

'Imports Microsoft.Office.Interop.Word
'Imports System.IO

Public Class Test
    Private Sub Test_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    '   Public Class Form1

    'Inherits System.Windows.Forms.Form

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Dim strFileName As String
        Dim word As New Microsoft.Office.Interop.Word.Application
        Dim doc As Microsoft.Office.Interop.Word.Document
        Try
            MsgBox("Opening")
            doc = word.Documents.Open("C:\Test\New Books\Books to read\Antony Moore\The Swap (6077)\Review - The Swap - Antony Moore.docx")
            MsgBox("Opened")
            'doc.SaveAs("C:\Test\New Books\Books to read\Antony Moore\The Swap (6077)\Review - The Swap - Antony Moore.rtf", wdFormatRTF)
            'Private Sub cmdSaveDoc_Click(sender As System.Object, e As System.EventArgs) Handles cmdSaveDoc.Click
            MsgBox("Saving")
            word.ActiveDocument.SaveAs(FileName:="C:\Test\New Books\Books to read\Antony Moore\The Swap (6077)\Review - The Swap - Antony Moore.rtf", FileFormat:=Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatRTF)
            MsgBox("Saved")
            word.Quit()
        Catch ex As COMException
            MessageBox.Show("Error accessing Word document.")

            End Try

        End Sub

    '    End Class



    '    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    '    End Sub
End Class