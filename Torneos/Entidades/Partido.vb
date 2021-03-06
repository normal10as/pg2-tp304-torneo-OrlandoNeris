﻿Public Class Partido

    Private _finalizado As Boolean

    Private _refereePartido As Referee
    Public Property RefereePartido As Referee
        Get
            Return _refereePartido
        End Get
        Set(value As Referee)
            _refereePartido = value
        End Set
    End Property

    Private _equipoLocal As Equipo
    Public Property EquipoLocal As Equipo
        Get
            Return _equipoLocal
        End Get
        Set(value As Equipo)
            If Not _finalizado Then
                _equipoLocal = value
            End If
        End Set
    End Property

    Private _equipoVisitante As Equipo
    Public Property EquipoVisitante As Equipo
        Get
            Return _equipoVisitante
        End Get
        Set(value As Equipo)
            If Not _finalizado Then
                _equipoVisitante = value
            End If
        End Set
    End Property

    Private _jornada As Byte
    Public Property Jornada As Byte
        Get
            Return _jornada
        End Get
        Set(value As Byte)
            If Not _finalizado Then
                _jornada = value
            End If
        End Set
    End Property

    Private _golesLocal As Byte
    Public ReadOnly Property GolesLocal As Byte
        Get
            Return _golesLocal
        End Get
    End Property

    Private _golesVisitantes As Byte
    Public ReadOnly Property GolesVisitantes As Byte
        Get
            Return _golesVisitantes
        End Get
    End Property

    Private _minutosGolesLocales As List(Of Byte)
    Public ReadOnly Property MinutosGolesLocales As List(Of Byte)
        Get
            Return _minutosGolesLocales
        End Get
    End Property

    Private _minutosGolesVisitantes As List(Of Byte)
    Public ReadOnly Property MinutosGolesVisitantes As List(Of Byte)
        Get
            Return _minutosGolesVisitantes
        End Get
    End Property

    Sub New(jornada, equipoLocal, equipoVisitante)
        Me.Jornada = jornada
        Me.EquipoLocal = equipoLocal
        Me.EquipoVisitante = equipoVisitante
        _finalizado = False
    End Sub

    Sub New(jornada As Byte, equipolocal As Equipo, equipovisitante As Equipo, goleslocal As Byte, golesvisitante As Byte)
        Me.New(jornada, equipolocal, equipovisitante)
        Finalizado()
        _golesLocal = goleslocal
        _golesVisitantes = golesvisitante
    End Sub

    Public Sub NuevoGolLocal(minutos As UShort)
        If _finalizado = False Then
            _golesLocal += 1
            _minutosGolesVisitantes.Add(minutos)
        End If
    End Sub

    Public Sub NuevoGolVisitante(minutos As UShort)
        If _finalizado = False Then
            _golesVisitantes += 1
            _minutosGolesVisitantes.Add(minutos)
        End If
    End Sub

    Public Overrides Function ToString() As String
        Return "Local: " & EquipoLocal.ToString & "( " & GolesLocal & " ) Goles   Visitante: " & EquipoVisitante.ToString & "( " & GolesVisitantes & " ) Goles."
    End Function

    Public Sub Finalizado()
        _finalizado = True
    End Sub

End Class
