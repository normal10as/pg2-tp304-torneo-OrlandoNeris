Public MustInherit Class Persona

    Private _fechaNac As Date
    Public Property FechaNac As Date
        Get
            Return _fechaNac
        End Get
        Set(value As Date)
            If calcularEdad() >= 16 Then
                _fechaNac = value
            End If
        End Set
    End Property

    Public ReadOnly Property Edad As UShort
        Get
            Return calcularEdad()
        End Get
    End Property

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

    Sub New(nombre, fechanacimiento)
        Me.Nombre = nombre
        FechaNac = fechanacimiento
    End Sub

    Public Overrides Function ToString() As String
        Return Nombre
    End Function

    Public Function calcularEdad() As UShort
        Return Now.Year - FechaNac.Year
    End Function

End Class
