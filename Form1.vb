Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim Letter As String = TextBox1.Text.Trim().ToLower()

        Try
            If String.IsNullOrEmpty(Letter) Then
                TextBox2.Text = ""
            ElseIf Letter = "b" Then
                TextBox2.Text = "Battleship"
            ElseIf Letter = "c" Then
                TextBox2.Text = "Cruiser"
            ElseIf Letter = "d" Then
                TextBox2.Text = "Destroyer"
            ElseIf Letter = "f" Then
                TextBox2.Text = "Frigate"
            Else
                TextBox2.Text = "No info"
            End If
        Catch ex As Exception
            MessageBox.Show("An unexpected error occurred: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

    End Sub
End Class
