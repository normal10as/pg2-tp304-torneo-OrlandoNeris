Public Class Partido

    Private _finalizado As Boolean

    Private _equipoLocal As Equipo
    Public Property EquipoLocal As Equipo
        Get
            Return _equipoLocal
        End Get
        Set(value As Equipo)
            _equipoLocal = value
        End Set
    End Property

    Private _equipoVisitante As Equipo
    Public Property EquipoVisitante As Equipo
        Get
            Return _equipoVisitante
        End Get
        Set(value As Equipo)
            _equipoVisitante = value
        End Set
    End Property

    Private _jornada As Byte
    Public Property Jornada As Byte
        Get
            Return _jornada
        End Get
        Set(value As Byte)
            _jornada = value
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
        Me.Jornada = jornada
        Me.EquipoLocal = equipolocal
        Me.EquipoVisitante = equipovisitante
        _golesLocal = goleslocal
        _golesVisitantes = golesvisitante
        Finalizado()
    End Sub

    Public Sub NuevoGolLocal(minutos As UShort)
        _golesLocal += 1
        _minutosGolesLocales.Add(Now.Minute)
    End Sub

    Public Sub NuevoGolVisitante(minutos As UShort)
        _golesVisitantes += 1
        _minutosGolesVisitantes.Add(Now.Minute)
    End Sub

    Public Overrides Function ToString() As String
        Return "Local: " & EquipoLocal.ToString & "( " & GolesLocal & " ) Goles   Visitante: " & EquipoVisitante.ToString & "( " & GolesVisitantes & " ) Goles."
    End Function

    Public Sub Finalizado()
        _finalizado = True
    End Sub

End Class
