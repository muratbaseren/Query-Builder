Public Class myDateTimePicker
    Inherits DateTimePicker

    Private _Kosul As String
    Private _IsNullable As Boolean
    Private _OrginalValue As String

    Public Property OrginalValue() As String
        Get
            Return Me._OrginalValue
        End Get
        Set(ByVal Value As String)
            Me._OrginalValue = Value
        End Set
    End Property

    Public Property Kosul() As String
        Get
            Return Me._Kosul
        End Get
        Set(ByVal Value As String)
            Me._Kosul = Value
        End Set
    End Property

    Public Property IsNullable() As Boolean
        Get
            Return Me._IsNullable
        End Get
        Set(ByVal Value As Boolean)
            Me._IsNullable = Value
        End Set
    End Property
End Class
