Public Class Auto
    'declaracion de propiedades
    Private Marca As String
    Private Modelo As String
    Private Año As String
    Private Color As String
    Private Clase As String
    Private Chasis As String
    Private Motor As String
    Private Placa As String

    'cumplimiento de datos
    Private auto_completo As Boolean

    'metodos de la marca

    Public Property Marca_auto As String
        Get
            Return Marca
        End Get
        Set(value As String)
            Marca = value
        End Set
    End Property

    ''Metodo para el modelo
    Public Property Modelo_auto As String
        Get
            Return Modelo
        End Get
        Set(value As String)
            Modelo = value
        End Set
    End Property

    ''Metodo para el año
    Public Property Año_auto As String
        Get
            Return Año
        End Get
        Set(value As String)
            Año = value
        End Set
    End Property

    ''Metodo para el color
    Public Property Color_auto As String
        Get
            Return Color
        End Get
        Set(value As String)
            Color = value
        End Set
    End Property

    ''Metodo para la clase
    Public Property Clase_auto As String
        Get
            Return Clase
        End Get
        Set(value As String)
            Clase = value
        End Set
    End Property

    ''Metodo para número de chasis
    Public Property Chasis_auto As String
        Get
            Return Chasis
        End Get
        Set(value As String)
            Chasis = value
        End Set
    End Property

    ''Metodo para número de motor
    Public Property Motor_auto As String
        Get
            Return Motor
        End Get
        Set(value As String)
            Motor = value
        End Set
    End Property

    Public ReadOnly Property Datos_auto_aceptados() As Boolean
        Get
            Return Datos_auto_aceptados
        End Get

    End Property

    'Constructor de la clase
    Public Sub New()

        auto_completo = False

    End Sub


    'Atributos de clase
    Public Sub Datos_auto(ByVal marcaA As String,
                             ByVal modeloA As String,
                             ByVal añoA As String,
                             ByVal colorA As String,
                             ByVal claseA As String,
                             ByVal chasisA As String,
                             ByVal motorA As String)

        auto_completo = False


        If marcaA.Length = 0 Then
            MsgBox("Debe agregar uno o dos nombres")
        Else
            marca = marcaA
        End If

        If modeloA.Length = 0 Then
            MsgBox("Debe agregar uno o dos apellidos")
        Else
            modelo = modeloA
        End If

        If añoA.Length = 0 Then
            MsgBox("Debe ingresar un número de DUI")
        Else
            año = añoA
        End If

        If colorA.Length = 0 Then
            MsgBox("Debe agregar un nombre")
        Else
            color = colorA
        End If

        If claseA.Length = 0 Then
            MsgBox("Debe agregar un nombre")
        Else
            clase = claseA
        End If

        If chasisA.Length = 0 Then
            MsgBox("Debe agregar un nombre")
        Else
            chasis = chasisA
        End If

        If motorA.Length = 0 Then
            MsgBox("Debe agregar un nombre")
        Else
            motor = motorA
        End If

    End Sub

    Public Function Generarplaca(ByVal marca As String)

        Dim valor1 As String
        Dim valor2 As String
        Dim numero As Single

        valor1 = UCase(Left(marca, 1))
        valor2 = UCase(Left(marca, 2))
        numero = Int(Rnd() * 1000) + 65

        Return valor1 & numero & valor2
    End Function
End Class
