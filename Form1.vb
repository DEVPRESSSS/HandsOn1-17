Public Class Form1
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim Input As Double

        If Double.TryParse(TextBox1.Text, Input) Then

            If Input >= 98 AndAlso Input <= 100 Then
                TextBox2.Text = "1.00"
            ElseIf Input >= 95 AndAlso Input <= 97 Then
                TextBox2.Text = "1.25"
            ElseIf Input >= 92 AndAlso Input <= 94 Then
                TextBox2.Text = "1.50"
            ElseIf Input >= 89 AndAlso Input <= 91 Then
                TextBox2.Text = "1.75"
            ElseIf Input >= 85 AndAlso Input <= 88 Then
                TextBox2.Text = "2.00"
            ElseIf Input >= 82 AndAlso Input <= 84 Then
                TextBox2.Text = "2.25"
            ElseIf Input >= 80 AndAlso Input <= 81 Then
                TextBox2.Text = "2.50"
            ElseIf Input >= 77 AndAlso Input <= 79 Then
                TextBox2.Text = "2.75"
            ElseIf Input >= 75 AndAlso Input <= 76 Then
                TextBox2.Text = "3.00"
            ElseIf Input >= 0 AndAlso Input <= 74 Then
                TextBox2.Text = "Failed"
            Else
                TextBox2.Text = "Invalid grade"
            End If
        Else
            TextBox2.Text = ""
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso e.KeyChar <> "." Then
            e.Handled = True
        End If

        If e.KeyChar = "." AndAlso CType(sender, TextBox).Text.Contains(".") Then
            e.Handled = True
        End If
    End Sub
End Class
