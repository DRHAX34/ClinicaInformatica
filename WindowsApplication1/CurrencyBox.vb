Public Class CurrencyTextBox
    Inherits System.Windows.Forms.TextBox

    Const LOCATIONCODE As String = "en-PH"
    Const DECIMALPOINT As Integer = 46
    Const CURRFORM As String = ""

    Private mDecimalPeriod As Boolean = False
    Private mNumberFormat As System.Globalization.NumberFormatInfo = New System.Globalization.CultureInfo(LOCATIONCODE, False).NumberFormat
    Private mBuffer As String = ""

    Public Overrides Property Text As String
        Get
            Return MyBase.Text
        End Get
        Set(ByVal value As String)
            Try
                MyBase.Text = Decimal.Parse(value, Globalization.NumberStyles.Currency, mNumberFormat).ToString(CURRFORM, mNumberFormat)
            Catch ex As Exception
                MyBase.Text = "0"
            End Try
        End Set
    End Property

    Public ReadOnly Property Value As Decimal
        Get
            If MyBase.Text.Length = 0 Then
                MyBase.Text = "0"
            End If
            Return Decimal.Parse(MyBase.Text, Globalization.NumberStyles.Currency, mNumberFormat)
        End Get
    End Property

    Private Sub DecimalTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.GotFocus
        If MyBase.Text.Length = 0 Then
            MyBase.Text = "0"
        End If
        MyBase.Text = Decimal.Parse(MyBase.Text, Globalization.NumberStyles.Currency, mNumberFormat).ToString
    End Sub

    Private Sub DecimalTextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
        If MyBase.Text.Length = 0 Then
            MyBase.Text = "0"
        End If
        MyBase.Text = Decimal.Parse(MyBase.Text, Globalization.NumberStyles.Currency, mNumberFormat).ToString(CURRFORM, mNumberFormat)
        mDecimalPeriod = False
    End Sub

    Private Sub DecimalTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        mBuffer = MyBase.Text
        If e.KeyChar = Chr(8) Then
            If MyBase.Text.Length = 0 Then Exit Sub
            If MyBase.Text.Chars(MyBase.Text.Length - 1) = Chr(DECIMALPOINT) Then
                mDecimalPeriod = False
            End If
            Exit Sub
        ElseIf Char.IsNumber(e.KeyChar) = False Then
            If e.KeyChar = Chr(DECIMALPOINT) Then
                If MyBase.Text.Length = 0 And MyBase.SelectionLength = 0 Then
                    e.Handled = True
                    Exit Sub
                End If
                If mDecimalPeriod = False And MyBase.SelectionLength = 0 Then
                    mDecimalPeriod = True
                    Exit Sub
                Else
                    e.Handled = True
                End If
            End If
            e.Handled = True
            Exit Sub
        End If
        If IsNumber(Text) = False Then
            MyBase.Text = mBuffer
        End If
    End Sub

    Private Function IsNumber(ByVal str As String) As Boolean
        Dim iCounter As Integer
        Dim bValidator As Boolean
        For iCounter = 0 To str.Length - 1
            If Char.IsDigit(str.Chars(iCounter)) = False Then
                If str.Chars(iCounter) = Chr(DECIMALPOINT) And bValidator = False Then
                    bValidator = True
                Else
                    Return False
                    Exit Function
                End If
            End If
        Next

        Return True
    End Function

    Private Sub DecimalTextBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        MyBase.SelectAll()
    End Sub

    Private Sub DecimalTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.TextChanged
        If MyBase.Enabled = False Or MyBase.ReadOnly = True Then
            MyBase.Text = Decimal.Parse(MyBase.Text, Globalization.NumberStyles.Currency, mNumberFormat).ToString(CURRFORM, mNumberFormat)
        End If
    End Sub

End Class
