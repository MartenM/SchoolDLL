Public Class Student
    Inherits Persoon

    Private _klas As String
    Private _mentor As String

    Public Property klas As String
        Get
            Return _klas
        End Get
        Set(value As String)
            _klas = value
        End Set
    End Property

    Public Property mentor() As String
        Get
            Return _klas
        End Get
        Set(value As String)
            _klas = value
        End Set
    End Property
End Class
