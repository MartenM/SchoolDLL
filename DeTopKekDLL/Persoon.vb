Public Class Persoon
    Private _id As Integer
    Private _voornaam As String
    Private _achternaam As String
    Private _leeftijd As Integer

    Public Persoon



    Public Property voornaam() As String
        Get
            Return _voornaam
        End Get
        Set(value As String)
            _voornaam = value
        End Set
    End Property

    Public Property achternaam() As String
        Get
            Return _achternaam
        End Get
        Set(value As String)
            _achternaam = value
        End Set
    End Property

    Public Property leeftijd As Integer
        Get
            Return leeftijd
        End Get
        Set(value As Integer)
            _leeftijd = value
        End Set
    End Property

    Public ReadOnly Property id() As Integer
        Get
            Return id
        End Get
    End Property

    Public ReadOnly Property isVolwassen() As Boolean
        Get
            Return (_leeftijd > 18)
        End Get
    End Property
End Class
