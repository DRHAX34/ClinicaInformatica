

Partial Class SQLToReportConnection
    Partial Class ArtigosDataTable

        Private Sub ArtigosDataTable_ArtigosRowChanging(sender As Object, e As ArtigosRowChangeEvent) Handles Me.ArtigosRowChanging

        End Sub

    End Class

    Partial Class ReparaçõesDataTable

        Private Sub ReparaçõesDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
        End Sub

        Private Sub ReparaçõesDataTable_ReparaçõesRowChanging(sender As Object, e As ReparaçõesRowChangeEvent) Handles Me.ReparaçõesRowChanging

        End Sub

    End Class

    Partial Class HardwareDataTable

        Private Sub HardwareDataTable_HardwareRowChanging(sender As Object, e As HardwareRowChangeEvent) Handles Me.HardwareRowChanging

        End Sub

    End Class

End Class

Namespace SQLToReportConnectionTableAdapters
    
    Partial Class SoftwareTableAdapter

    End Class

    Partial Public Class HardwareTableAdapter
    End Class
End Namespace
