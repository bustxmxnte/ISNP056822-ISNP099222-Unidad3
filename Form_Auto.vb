Public Class Form_Auto
    Dim Marca As New Auto
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub grpCodigo_Enter(sender As Object, e As EventArgs) Handles grpCodigo.Enter

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub datosAlumno_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datosauto.CellContentClick

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Marca.Datos_auto(Txtmarca.Text, txtmodelo.Text, txtaño.Text, txtcolor.Text, txtclase.Text, txtchasis.Text, txtmotor.Text)

        datosauto.Rows.Add(Txtcodigo.Text,
                             Marca.Marca_auto,
                             Marca.Modelo_auto,
                              Marca.Año_auto,
                             Marca.Color_auto,
                             Marca.Clase_auto,
                             Marca.Chasis_auto,
                             Marca.Motor_auto)

        If Marca.Datos_auto_aceptados Then
            MsgBox("Datos de " & Marca.Marca_auto & "Registrados con Éxito")

        End If
        Txtmarca.Text = ""
        txtmodelo.Text = ""
        txtaño.Text = ""
        txtcolor.Text = ""
        txtclase.Text = ""
        txtchasis.Text = ""
        txtmotor.Text = ""

    End Sub

    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click

        If Txtmarca.Text = "" Then
            MsgBox("Debe agregar una marca")

        Else
            Txtmarca.Text = Marca.Generarplaca(Txtmarca.Text)
        End If
    End Sub
End Class
