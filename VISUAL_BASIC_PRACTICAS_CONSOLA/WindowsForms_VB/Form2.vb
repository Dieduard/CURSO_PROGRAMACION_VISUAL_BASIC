Public Class Form2
    Dim PagNegra, PagColor, Efectivo, suma, Cambio As Double

#Region "COMO MOSTRAR DIAS DE LA SEMANA"
    Private Sub btnDias_Click(sender As Object, e As EventArgs) Handles btnDias.Click

        Dim semana() As String = {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"}
        Dim dia As String
        For Each dia In semana
            ListBox1.Items.Add(dia)
        Next
    End Sub


#End Region

#Region "TODO SOBRE EL BOTON PARA COBRAR PAGINA"
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Cantidad = Integer.Parse(TextBox1.Text)
        PagNegra = 0.05
        PagColor = 0.15
        If ComboBoxPaginas.SelectedIndex = 0 Then
            suma = Cantidad * PagNegra
            DataGridView1.Rows.Add(Cantidad, "Negra", PagNegra, suma)
        Else
            suma = Cantidad * PagColor
            DataGridView1.Rows.Add(Cantidad, "Color", PagColor, suma)
        End If

        Dim total As Double = 0
        For f = 0 To DataGridView1.Rows.Count - 1
            total = total + (DataGridView1.Rows(f).Cells(0).Value *
            DataGridView1.Rows(f).Cells(2).Value)
            TextBox2.Text = "$ " & total
        Next
    End Sub
#End Region

#Region "TODO SOBRE EL BOTON SALIR"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Close()
    End Sub
#End Region

#Region "COBRO DE PAGINAS OPCION UNO"
    Dim Cantidad As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cantidad = Integer.Parse(txtCantidad.Text)
        Efectivo = Double.Parse(txtEfectivo.Text)
        PagNegra = 0.05
        PagColor = 0.15
        If rdbPaginaNegra.Checked Then
            suma = Cantidad * PagNegra
            Cambio = Efectivo - suma
            txtCambio.Text = Cambio
            txtTotal.Text = suma
            txtCobrado.Text = suma
        ElseIf rdbPaginaColor.Checked Then
            suma = Cantidad * PagColor
            Cambio = Efectivo - suma
            txtCambio.Text = Cambio
            txtTotal.Text = suma
            txtCobrado.Text = suma
        End If


    End Sub
#End Region

End Class