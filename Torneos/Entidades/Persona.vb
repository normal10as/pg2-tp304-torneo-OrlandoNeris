Public MustInherit Class Persona

    Private _fechaNacimiento As Date
    Public Property FechaNacimiento As Date
        Get
            Return _fechaNacimiento
        End Get
        Set(value As Date)
            If CalcularEdad(value) >= 16 Then
                _fechaNacimiento = value
            End If
        End Set
    End Property

    Public ReadOnly Property Edad As UShort
        Get
            Return CalcularEdad(FechaNacimiento)
        End Get
    End Property

    Private _nombre As String
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            If value.Length = 0 Then
                Throw New ArgumentException("Nombre no puede ser vacio")
            ElseIf value.Length > 30 Then
                Throw New ArgumentException("Nombre no puede superar los 30 caracteres")
            End If
            _nombre = value
        End Set
    End Property

    Sub New(nombre As String, fechanacimiento As Date)
        Me.Nombre = nombre
        Me.FechaNacimiento = fechanacimiento
    End Sub

    Public Overrides Function ToString() As String
        Return Nombre
    End Function

    Private Function CalcularEdad(fechanacimiento As Date) As UShort
        Return Now.Year - fechanacimiento.Year
    End Function

End Class
