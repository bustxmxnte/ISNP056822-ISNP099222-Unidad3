Public Class Alumno

    'Declaramos propiedades
    Private codigo As String
    Private nombre As String
    Private apellido As String
    Private dui As String
    Private genero As String
    Private edad As String
    Private correo As String
    Private carrera As String

    'Indicador de cumplemento de datos
    Private datos_completos As Boolean

    'Metodos de la clase

    ''Metodo para nombre
    Public Property nombre_alumno As String
        Get
            Return nombre
        End Get
        Set(value As String)
            nombre = value
        End Set
    End Property

    ''Metodo para apellido
    Public Property apellido_alumno As String
        Get
            Return apellido
        End Get
        Set(value As String)
            apellido = value
        End Set
    End Property

    ''Metodo para dui
    Public Property dui_alumno As String
        Get
            Return dui
        End Get
        Set(value As String)
            dui = value
        End Set
    End Property

    ''Metodo para genero
    Public Property genero_alumno As String
        Get
            Return genero
        End Get
        Set(value As String)
            genero = value
        End Set
    End Property

    ''Metodo para edad
    Public Property edad_alumno As String
        Get
            Return edad
        End Get
        Set(value As String)
            edad = value
        End Set
    End Property

    ''Metodo para correo
    Public Property correo_alumno As String
        Get
            Return correo
        End Get
        Set(value As String)
            correo = value
        End Set
    End Property

    ''Metodo para carrera
    Public Property carrera_alumno As String
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
    Public Sub datos_alumnos(ByVal codigo As String,
                             ByVal nombre As String,
                             ByVal apellido As String,
                             ByVal dui As String,
                             ByVal edad As String,
                             ByVal correo As String,
                             ByVal carrera As String
                            )

        datos_completos = False


        If nombre.Length = 0 Then
            MsgBox("Debe agregar uno o dos nombres")
        Else
            nombre = nombre
        End If

        If apellido.Length = 0 Then
            MsgBox("Debe agregar uno o dos apellidos")
        Else
            apellido = apellido
        End If

        If dui.Length = 0 Then
            MsgBox("Debe ingresar un número de DUI")
        Else
            dui = dui
        End If

        If edad.Length = 0 Then
            MsgBox("Debe agregar un nombre")
        Else
            edad = edad
        End If

        If correo.Length = 0 Then
            MsgBox("Debe agregar un nombre")
        Else
            correo = correo
        End If

        If carrera.Length = 0 Then
            MsgBox("Debe agregar un nombre")
        Else
            carrera = carrera
        End If

    End Sub


    Public Function generar_codigo()

        Dim valor1 As String
        Dim valor2 As String
        Dim numero As Single

        valor1 = UCase(Left(nombre, 1))
        valor2 = UCase(Left(apellido, 1))
        numero = Int(Rnd() * 1000) + 77

        Return valor1 & valor2 & numero
    End Function
End Class
