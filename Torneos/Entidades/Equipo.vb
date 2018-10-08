﻿Public Class Equipo

    Private _nombre As String
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Length > 0 And value.Length <= 30 Then
                _nombre = value
            End If
        End Set
    End Property

    Private _jugadores As List(Of Jugador)

    Sub New(nombre As String)
        Me.Nombre = nombre
    End Sub

    Public Overrides Function ToString() As String
        Return Nombre
    End Function

    Public Sub ComprarJugador(jugador As Jugador)
        _jugadores.Add(jugador)
    End Sub

    Public Sub LiberarJugador(jugador)
        _jugadores.Remove(jugador)
    End Sub

    Public Sub VenderJugador(jugador As Jugador, equipodestino As Equipo)

        _jugadores.Remove(jugador)
        equipodestino._jugadores.Add(jugador)
    End Sub

End Class
