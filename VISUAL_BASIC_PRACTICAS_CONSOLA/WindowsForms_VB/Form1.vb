Public Class Form1
#Region "VALIDACION DE LOS TEXBOX PARA QUE SOLO ACEPTEN LETRAS O NUMEROS"
    'VALIDACION DE TEXBOX PARA QUE SOLO ACEPTE LETRAS
    Sub SoloLetras(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Ingresar solo texto ", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
    End Sub
    'VALIDACION DE TEXBOX PARA QUE SOLO ACEPTE NUMEROS
    Sub SoloNumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo número", MsgBoxStyle.Exclamation, "Ingreso de Número")
        End If
    End Sub
    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        SoloLetras(e)
    End Sub
    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        SoloLetras(e)
    End Sub
    Private Sub txtEdad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEdad.KeyPress
        SoloNumeros(e)
    End Sub
    Private Sub txtSueldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSueldo.KeyPress
        SoloNumeros(e)
    End Sub
#End Region

#Region "VARIABLES DEFINIDAS"

    Dim Nombre, Apellido As String
    Dim Edad As Integer
    Dim Sueldo As Double
    Dim Hombre, Mujer As Integer
#End Region

#Region "TODO SOBRE EL BOTON MOSTRAR LOS DATOS AGREGADOS"
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
#End Region

#Region "TODO SOBRE EL BOTON LIMPIAR CAMPOS "
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        txtnombre.Clear()
        txtApellido.Clear()
        txtEdad.Clear()
        txtSueldo.Clear()
        DgvDatos.Rows.Clear()
        lblHombres.Text = ""
        lblMujeres.Text = ""
    End Sub
#End Region

#Region "TODO SOBRE EL BOTON ABRIR EL OTRO FORMULARIO"
    Private Sub btnOtroFormulario_Click(sender As Object, e As EventArgs) Handles btnOtroFormulario.Click
        Form2.Show()
    End Sub
#End Region

#Region "TODO SOBRE EL BOTON SALIR"
    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
#End Region

End Class
