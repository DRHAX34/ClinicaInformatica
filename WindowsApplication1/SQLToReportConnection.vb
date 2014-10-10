

Partial Class SQLToReportConnection
    Partial Class ReparaçõesDataTable

        Private Sub ReparaçõesDataTable_ColumnChanging(sender As Object, e As DataColumnChangeEventArgs) Handles Me.ColumnChanging
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
