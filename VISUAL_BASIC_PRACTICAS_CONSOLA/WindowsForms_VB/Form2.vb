Public Class Form2
#Region "COMO MOSTRAR DIAS DE LA SEMANA"
    Private Sub btnDias_Click(sender As Object, e As EventArgs) Handles btnDias.Click

        Dim semana() As String = {"Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo"}
        Dim dia As String
        For Each dia In semana
            ListBox1.Items.Add(dia)

        Next
    End Sub
#End Region
End Class