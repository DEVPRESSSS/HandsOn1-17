Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PerformCalculation(AddressOf Subtraction)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PerformCalculation(AddressOf Addition)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PerformCalculation(AddressOf Multiplication)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PerformCalculation(AddressOf Division)
    End Sub

    Private Sub PerformCalculation(calcMethod As Func(Of Double, Double, Double))
        Dim fn As Double
        Dim sn As Double
        Dim rs As Double

        If Double.TryParse(TextBox1.Text, fn) AndAlso Double.TryParse(TextBox2.Text, sn) Then
            Try
                rs = calcMethod(fn, sn)
                TextBox3.Text = rs.ToString()
            Catch ex As DivideByZeroException
                MessageBox.Show("Cannot divide by zero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            MessageBox.Show("Invalid input. Please enter numeric values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function Addition(x As Double, y As Double) As Double
        Return x + y
    End Function

    Private Function Subtraction(x As Double, y As Double) As Double
        Return x - y
    End Function

    Private Function Multiplication(x As Double, y As Double) As Double
        Return x * y
    End Function

    Private Function Division(x As Double, y As Double) As Double
        If y = 0 Then
            Throw New DivideByZeroException()
        End If
        Return x / y
    End Function
End Class
