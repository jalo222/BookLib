Public Class clsGenFunc

    Public Shared Function fnCopyDir(P_FromDir As String, P_ToDir As String, P_Overwrite As Boolean)
        Dim ResultMsg As String = ""
        Dim Result As Integer = 0
        Dim v_FromDir As String = ""
        Dim v_ToDir As String = ""
        Dim v_Style = vbOKOnly Or vbCritical
        Dim v_Title = "Directory copy error!"

        v_FromDir = P_FromDir
        v_ToDir = P_ToDir
        Try
            My.Computer.FileSystem.CopyDirectory(v_FromDir, v_ToDir)
        Catch ex As Exception
            Result = 1
            ResultMsg = "Source directory: " & P_FromDir & Chr(13) & Chr(10) _
                & "Destination Directory: " & P_ToDir & Chr(13) & Chr(10) _
                & ex.Message
            MsgBox(ResultMsg, v_Style, v_Title)
        End Try
        Return Result
    End Function

    Public Shared Function fnDelDir(P_FromDir As String)
        Dim ResultMsg As String = ""
        Dim Result As Integer = 0
        Dim v_FromDir As String = ""
        Dim v_Style = vbOKOnly Or vbCritical
        Dim v_Title = "Directory deletion error!"

        v_FromDir = P_FromDir
        Try
            My.Computer.FileSystem.DeleteDirectory(v_FromDir, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.SendToRecycleBin)
        Catch ex As Exception
            Result = 2
            ResultMsg = "Directory: " & P_FromDir & Chr(13) & Chr(10) _
            & ex.Message
            MsgBox(ResultMsg, v_Style, v_Title)
        End Try

        Return Result
    End Function

    Public Shared Function fnMoveDir(P_FromDir As String, P_ToDir As String)
        Dim ResultMsg As String = ""
        Dim Result As Integer = 0
        Dim v_FromDir As String = ""
        Dim v_ToDir As String = ""
        Dim v_Style = vbOKOnly Or vbCritical
        Dim v_Title = "Directory move error!"

        v_FromDir = P_FromDir
        v_ToDir = P_ToDir
        Try
            My.Computer.FileSystem.MoveDirectory(v_FromDir, v_ToDir)
        Catch ex As Exception
            Result = 2
            ResultMsg = "From Directory: " & P_FromDir & Chr(13) & Chr(10) _
                & "To Directory: " & P_ToDir & Chr(13) & Chr(10) _
                & P_ToDir & Chr(13) & Chr(10) _
                & ex.Message
            MsgBox(ResultMsg, v_Style, v_Title)
        End Try

        Return Result
    End Function

    Public Shared Function fnCreateDir(P_DirPath As String)
        Dim ResultMsg As String = ""
        Dim Result As Integer = 0
        Dim v_Path As String = ""
        Dim v_Style = vbOKOnly Or vbCritical
        Dim v_Title = "Error creating Directory!"

        v_Path = P_DirPath
        Try
            My.Computer.FileSystem.CreateDirectory(v_Path)
        Catch ex As Exception
            Result = 1
            ResultMsg = "Directory: " & v_Path & Chr(13) & Chr(10) _
            & ex.Message
            MsgBox(ResultMsg, v_Style, v_Title)
        End Try

        Return Result

    End Function

End Class
