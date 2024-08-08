Public Class Form1
    Private Sub Multiply()
        ' Clear the items in listBox2
        ListBox2.Items.Clear()

        ' Iterate through each item in listBox1
        For i As Integer = 0 To ListBox1.Items.Count - 1
            Dim value As Integer = Convert.ToInt32(ListBox1.Items(i).ToString())

            Dim result As Integer = value * value

            ListBox2.Items.Add(result)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Multiply()
    End Sub
End Class
