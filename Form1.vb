Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim Input As Double

        If Double.TryParse(TextBox1.Text, Input) Then
            If Input < 4.9 Then
                TextBox2.Text = "No damage"
            ElseIf Input >= 4.9 AndAlso Input <= 5.5 Then
                TextBox2.Text = "Some damage"
            ElseIf Input > 5.5 AndAlso Input <= 6.5 Then
                TextBox2.Text = "Serious Damage"
            ElseIf Input >= 6.5 AndAlso Input < 7.5 Then
                TextBox2.Text = "Disaster"
            Else
                TextBox2.Text = "Catastrophe"
            End If
        Else
            MessageBox.Show("Letters is not allowed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        ' Check if the key pressed is not a digit, a control character (like Backspace), or a decimal point
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            ' If it is not, then suppress the key press event
            e.Handled = True
        End If

        ' Ensure that only one decimal point is allowed
        If e.KeyChar = "." AndAlso CType(sender, TextBox).Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub
End Class
