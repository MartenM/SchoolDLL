Public Class Leraar

    Inherits Persoon

    Private _vak As String 'Idk what else
    Public Property vak() As String
        Get
            Return _vak
        End Get
        Set(value As String)
            _vak = value
        End Set
    End Property

    Private _mentorklas As String = ""
    Public ReadOnly Property hasMentorKlas As Boolean
        Get
            Return _mentorklas IsNot ""
        End Get
    End Property
    Public Property mentorKlas As String
        Get
            Return _mentorklas
        End Get
        Set(value As String)
            _mentorklas = value
        End Set
    End Property

End Class
