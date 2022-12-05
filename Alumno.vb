Public Class Alumno

    'Declaramos propiedades
    Private nombre As String
    Private apellido As String
    Private dui As String
    Private genero As String
    Private edad As String
    Private correo As String
    Private carrera As String
    Private Codigo As String


    'Indicador de cumplemento de datos
    Private datos_completos As Boolean

    'Metodos de la clase

    ''Metodo para nombre
    Public Property nombre_alumno() As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    ''Metodo para apellido
    Public Property apellido_alumno() As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property

    ''Metodo para dui
    Public Property dui_alumno() As String
        Get
            Return dui
        End Get
        Set(value As String)
            dui = value
        End Set
    End Property

    ''Metodo para genero
    Public Property genero_alumno() As String
        Get
            Return genero
        End Get
        Set(value As String)
            genero = value
        End Set
    End Property

    ''Metodo para edad
    Public Property edad_alumno() As String
        Get
            Return edad
        End Get
        Set(value As String)
            edad = value
        End Set
    End Property

    ''Metodo para correo
    Public Property correo_alumno() As String
        Get
            Return correo
        End Get
        Set(value As String)
            correo = value
        End Set
    End Property

    ''Metodo para carrera
    Public Property carrera_alumno() As String
        Get
            Return carrera
        End Get
        Set(value As String)
            carrera = value
        End Set
    End Property

    'Metodo para datos aceptados
    Public ReadOnly Property datos_aceptados() As Boolean
        Get
            Return datos_completos
        End Get

    End Property

    'Constructor de la clase
    Public Sub New()
        datos_completos = False

    End Sub


    'Atributos de clase
    Public Sub datos_alumnos(ByVal codigoA As String,
                             ByVal nombreA As String,
                             ByVal apellidoA As String,
                             ByVal duiA As String,
                             ByVal generoA As String,
                             ByVal edadA As String,
                             ByVal correoA As String,
                             ByVal carreraA As String)

        datos_completos = False

        If codigoA.Length = 0 Then
            MsgBox("Debe generar el codigo")
        Else
            Codigo = codigoA

        End If
        If nombreA.Length = 0 Then
            MsgBox("Debe agregar uno o dos nombres")
        Else
            nombre = nombreA
        End If

        If apellidoA.Length = 0 Then
            MsgBox("Debe agregar uno o dos apellidos")
        Else
            apellido = apellidoA
        End If

        If duiA.Length > 0 And duiA.Length < 10 Then
            MsgBox("Debe agregar dui de formato 00000000-0")
        Else
            dui = duiA
        End If
        If generoA.Length = 0 Then
            MsgBox("Debe de agregar genero")
        Else
            genero = generoA

        End If
        If edadA.Length = 0 Then
            MsgBox("Debe agregar un nombre")
        Else
            edad = edadA
        End If

        If correoA.Length = 0 Then
            MsgBox("Debe agregar un nombre")
        Else
            correo = correoA
        End If

        If carreraA.Length = 0 Then
            MsgBox("Debe agregar un nombre")
        Else
            carrera = carreraA
        End If

    End Sub


    Public Function generarCodigo(ByVal nombre As String)

        Dim valor1 As String
        Dim valor2 As String
        Dim numero As Single

        valor1 = UCase(Left(nombre, 1))
        valor2 = Right(nombre, 2)
        numero = Int(Rnd() * 1000) + 65

        Return valor1 & numero & valor2
    End Function
End Class
