
Public Class Form1


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        EnterText()
    End Sub

    Private Sub EnterText()

        ListBox1.Items.Clear()
        Dim input As String = TextBox1.Text


        ListBox1.Items.Add(input)
        TextBox1.Clear()



    End Sub
End Class
