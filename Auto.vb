Public Class Auto
    'declaracion de propiedades
    Private marca As String
    Private modelo As String
    Private año As String
    Private color As String
    Private clase As String
    Private n_chasis As String
    Private n_motor As String
    Private n_placa As String

    'cumplimiento de datos
    Private auto_completo As Boolean

    'metodos de la marca

    Public Property marca_auto As String
        Get
            Return marca
        End Get
        Set(value As String)
            marca = value
        End Set
    End Property

    ''Metodo para el modelo
    Public Property modelo_auto As String
        Get
            Return modelo
        End Get
        Set(value As String)
            modelo = value
        End Set
    End Property

    ''Metodo para el año
    Public Property año_auto As String
        Get
            Return año
        End Get
        Set(value As String)
            año = value
        End Set
    End Property

    ''Metodo para el color
    Public Property color_auto As String
        Get
            Return color
        End Get
        Set(value As String)
            color = value
        End Set
    End Property

    ''Metodo para la clase
    Public Property clase_auto As String
        Get
            Return clase
        End Get
        Set(value As String)
            clase = value
        End Set
    End Property

    ''Metodo para número de chasis
    Public Property chasis_auto As String
        Get
            Return n_chasis
        End Get
        Set(value As String)
            n_chasis = value
        End Set
    End Property

    ''Metodo para número de motor
    Public Property motor_auto As String
        Get
            Return n_motor
        End Get
        Set(value As String)
            n_motor = value
        End Set
    End Property

    Public ReadOnly Property datos_auto_aceptados() As Boolean
        Get
            Return datos_auto_aceptados
        End Get

    End Property

    'Constructor de la clase
    Public Sub New()

        auto_completo = False

    End Sub


    'Atributos de clase
    Public Sub datos_alumnos(ByVal n_placa As String,
                             ByVal marca As String,
                             ByVal modelo As String,
                             ByVal año As String,
                             ByVal color As String,
                             ByVal clase As String,
                             ByVal n_chasis As String,
                             ByVal n_motor As String
                            )

        auto_completo = False


        If marca.Length = 0 Then
            MsgBox("Debe agregar uno o dos nombres")
        Else
            marca = marca
        End If

        If modelo.Length = 0 Then
            MsgBox("Debe agregar uno o dos apellidos")
        Else
            modelo = modelo
        End If

        If año.Length = 0 Then
            MsgBox("Debe ingresar un número de DUI")
        Else
            año = año
        End If

        If color.Length = 0 Then
            MsgBox("Debe agregar un nombre")
        Else
            color = color
        End If

        If clase.Length = 0 Then
            MsgBox("Debe agregar un nombre")
        Else
            clase = clase
        End If

        If n_chasis.Length = 0 Then
            MsgBox("Debe agregar un nombre")
        Else
            n_chasis = n_chasis
        End If

        If n_motor.Length = 0 Then
            MsgBox("Debe agregar un nombre")
        Else
            n_motor = n_motor
        End If

    End Sub

    Public Function generar_placa()

        Dim valor1 As String
        Dim valor2 As String
        Dim numero As Single

        valor1 = UCase(Left(clase, 1))
        valor2 = UCase(Left(n_chasis, 3))
        numero = Int(Rnd() * 1000) + 86

        Return valor1 & valor2 & numero
    End Function
End Class
