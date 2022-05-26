Public Class Form1
    Dim Nombre, Apellido As String
    Dim Edad As Integer
    Dim Sueldo As Double
    Dim Hombre, Mujer As Integer

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Me.Close()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtnombre.Clear()
        txtApellido.Clear()
        txtEdad.Clear()
        txtSueldo.Clear()
        DgvDatos.Rows.Clear()
        lblHombres.Text = ""
        lblMujeres.Text = ""
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        Nombre = txtnombre.Text
        Apellido = txtApellido.Text
        Edad = txtEdad.Text
        Sueldo = txtSueldo.Text
        If rdbHombre.Checked Then
            If Edad >= 18 Then
                DgvDatos.Rows.Add(Nombre, Apellido, Edad, "Hombre", Sueldo, "Mayor Edad")
                Hombre = Hombre + 1
            Else
                DgvDatos.Rows.Add(Nombre, Apellido, Edad, "Hombre", Sueldo, "Menor Edad")
                Hombre = Hombre + 1
            End If
        ElseIf rdbMujer.Checked Then
            If Edad >= 18 Then
                DgvDatos.Rows.Add(Nombre, Apellido, Edad, "Mujer", Sueldo, "Mayor Edad")
                Mujer = Mujer + 1
            Else
                DgvDatos.Rows.Add(Nombre, Apellido, Edad, "Mujer", Sueldo, "Menor Edad")
                Mujer = Mujer + 1
            End If
        End If
        txtnombre.Clear()
        txtApellido.Clear()
        txtEdad.Clear()
        txtSueldo.Clear()

        lblHombres.Text = Hombre
        lblMujeres.Text = Mujer
    End Sub
End Class
