Public Class Jugador
    Inherits Persona

    Private _numero As UShort
    Public Property Numero As UShort
        Get
            Return _numero
        End Get
        Set(value As UShort)
            If value > 0 And value < 99 Then
                _numero = value
            End If
        End Set
    End Property

    Sub New(nombre, fechanac, numero)
        MyBase.New(nombre, fechanac)
        Me.Numero = numero
    End Sub

    Public Overrides Function ToString() As String
        Return Nombre & " ( " & Numero & " )"
    End Function

End Class
