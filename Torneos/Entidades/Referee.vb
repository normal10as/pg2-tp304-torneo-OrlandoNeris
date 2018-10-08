Public Class Referee
    Inherits Persona

    Private _internacional As Boolean
    Public Property Internacional As Boolean
        Get
            Return _internacional
        End Get
        Set(value As Boolean)
            _internacional = value
        End Set
    End Property

    Sub New(nombre As String, fechanacimiento As Date, internacional As Boolean)
        MyBase.New(nombre, fechanacimiento)
        Me.Internacional = internacional
    End Sub

    Public Overrides Function ToString() As String
        Return Nombre & If(_internacional, "( " & "i" & " )", "")
    End Function

End Class
