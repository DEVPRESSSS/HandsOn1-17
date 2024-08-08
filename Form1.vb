
Public Class Form1


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        EnterText()
    End Sub

    Private Sub EnterText()



        Dim index As Integer = ListBox1.SelectedIndex

        If index <> -1 Then
            ListBox1.Items.RemoveAt(index)
        End If




    End Sub
End Class
