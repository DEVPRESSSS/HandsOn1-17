Public Class Form1
    Private Sub Reverse()
        ListBox2.Items.Clear()

        For i As Integer = ListBox1.Items.Count - 1 To 0 Step -1
            ListBox2.Items.Add(ListBox1.Items(i))
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Reverse()
    End Sub
End Class
