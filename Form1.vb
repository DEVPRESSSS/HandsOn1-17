Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


        Dim Number As Integer



        Number = TextBox1.Text

        If Integer.TryParse(TextBox1.Text, Number) Then


            Try


                If Number <= 499 Then

                    TextBox2.Text = "Bird"

                ElseIf Number >= 500 AndAlso Number <= 1100 Then

                    TextBox2.Text = "Military"

                Else


                    TextBox2.Text = "Civilian"


                End If



            Catch ex As Exception
                MessageBox.Show("Invalid input. Please enter numeric values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        Else
            TextBox2.Text = ""

        End If


    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            ' If the character is not a control key or digit, cancel the key press
            e.Handled = True
        End If
    End Sub
End Class
