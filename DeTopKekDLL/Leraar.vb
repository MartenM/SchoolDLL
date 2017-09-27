Public Class Leraar

    Private _vak As String
    Public Property vak() As String
        Get
            Return _vak
        End Get
        Set(value As String)
            _vak = value
        End Set
    End Property
End Class
