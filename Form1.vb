
Public Class Form1
    Private Sub MultiplicationOf3()

        For i As Integer = 1 To 8

            Dim result As Integer = i * 3
            ListBox1.Items.Add(result)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MultiplicationOf3()
    End Sub
End Class
