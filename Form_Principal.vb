Public Class Form_Principal
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim btn_autos As New Form_Auto
        btn_autos.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim btn_alumnos As New Form_Alumnos
        btn_alumnos.Show()
    End Sub
End Class