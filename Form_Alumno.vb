Public Class Form_Alumnos
    Dim alumno As New Alumno

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click


        If Txtnombre.Text = "" Then
            MsgBox("Debe agregar un nombre")

        Else
            Txtcodigo.Text = alumno.generarCodigo(Txtnombre.Text)
        End If
    End Sub

    Private Sub grpCodigo_Enter(sender As Object, e As EventArgs) Handles grpCodigo.Enter




    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click


        alumno.datos_alumnos(Txtcodigo.Text, Txtnombre.Text, Txtapellido.Text, Txtgenero.Text, Txtdui.Text, Txtedad.Text, Txtcorreo.Text, Txtcarrera.Text)

        datosAlumno.Rows.Add(Txtcodigo.Text,
                             alumno.nombre_alumno,
                             alumno.apellido_alumno,
                             alumno.dui_alumno,
                             alumno.genero_alumno,
                             alumno.edad_alumno,
                             alumno.correo_alumno,
                             alumno.carrera_alumno)

        If alumno.datos_aceptados Then
            MsgBox("Datos de " & alumno.nombre_alumno & "Registrados con Éxito")

        End If
        Txtcodigo.Text = ""
        Txtnombre.Text = ""
        Txtapellido.Text = ""
        Txtdui.Text = ""
        Txtgenero.Text = ""
        Txtedad.Text = ""
        Txtcorreo.Text = ""
        Txtcarrera.Text = ""
    End Sub

    Private Sub datosAlumno_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datosAlumno.CellContentClick

    End Sub
End Class
