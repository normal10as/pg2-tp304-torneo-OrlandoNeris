Public Class Jugador
    Inherits Persona

    Private _equipo As Equipo
    Public Property Equipo As Equipo
        Get
            Return _equipo
        End Get
        Friend Set(value As Equipo)
            If _equipo IsNot Nothing AndAlso _equipo.Equals(value) Then
                Throw New ArgumentException("El equipo es el mismo")
            End If
            _equipo = value
        End Set
    End Property

    Private _numero As UShort
    Public Property Numero As UShort
        Get
            Return _numero
        End Get
        Set(value As UShort)
            If value = 0 Or value > 99 Then
                Throw New ArgumentException("NUMERO FUERA DE RANGO")
            End If
            _numero = value
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
