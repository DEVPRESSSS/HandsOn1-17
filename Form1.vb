Public Class Form1
    Private Peso As Double
    Private Result As Double

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Peso = TextBox1.Text
        Result = Peso * 56.5

        TextBox2.Text = Result

    End Sub
End Class
