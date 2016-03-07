Partial Class booklibDataSet
    Partial Public Class book_coversDataTable
        Private Sub book_coversDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.BookIDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class
End Class

Namespace booklibDataSetTableAdapters

    Partial Public Class file_types_copyTableAdapter
    End Class
End Namespace
