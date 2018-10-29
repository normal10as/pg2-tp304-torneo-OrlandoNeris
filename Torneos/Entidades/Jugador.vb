Public Class Jugador
    Inherits Persona

    Private _equipo As Equipo
    Public Property Equipo As Equipo
        Get
            Return _equipo
        End Get
        Friend Set(value As Equipo)
            _equipo = value
        End Set
    End Property

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

    Sub New(nombre As String, fechanac As Date, numero As Byte)
        MyBase.New(nombre, fechanac)
        Me.Numero = numero
    End Sub

    Public Overrides Function ToString() As String
        Return Nombre & " ( " & Numero & " )"
    End Function

End Class
