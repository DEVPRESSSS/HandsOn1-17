Imports System.Data
Imports Microsoft.Data.SqlClient

Public Class Form1

    Dim connectionString As String = "Server=REJIE\SQLEXPRESS;Database=cafe;Trusted_Connection=True;TrustServerCertificate=True;"


    Dim Names As String

    Dim Program As String
    Dim Id As Integer
    Private Const MaxLength As Integer = 50


    Private Sub Button1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Add()

        Names = TextBox1.Text
        Program = TextBox2.Text
        Dim query As String = "INSERT INTO Student (Name, Program) VALUES (@Name, @Program)"

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@Name", Names)
                    command.Parameters.AddWithValue("@Program", Program)

                    command.ExecuteNonQuery()
                End Using

                MessageBox.Show("Data inserted successfully!")
                Clear()
                LoadData()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Update()
        Names = TextBox1.Text
        Program = TextBox2.Text
        Id = TextBox3.Text
        If Id > 0 Then
            Dim query As String = "UPDATE Student SET Name = @Name, Program = @Program WHERE Id = @Id"

            Using connection As New SqlConnection(connectionString)
                Try
                    connection.Open()
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Name", Names)
                        command.Parameters.AddWithValue("@Program", Program)
                        command.Parameters.AddWithValue("@Id", Id)

                        Dim rowsAffected As Integer = command.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("Record updated successfully!")
                            Clear()
                            LoadData()
                        Else
                            MessageBox.Show("No record was updated.")
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Please select a record to update.")
        End If

    End Sub


    Private Sub Delete()
        Dim Id As Integer
        If Integer.TryParse(TextBox3.Text, Id) AndAlso Id > 0 Then
            Dim query As String = "DELETE FROM Student WHERE Id = @Id"

            Using connection As New SqlConnection(connectionString)
                Try
                    connection.Open()
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Id", Id)


                        Dim rowsAffected As Integer = command.ExecuteNonQuery()
                        If rowsAffected > 0 Then
                            MessageBox.Show("Record deleted successfully!")
                            Clear()
                            LoadData()
                        Else
                            MessageBox.Show("No record was deleted.")
                        End If
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message)
                End Try
            End Using
        Else
            MessageBox.Show("Please select a valid record to delete.")
        End If
    End Sub

    Private Sub LoadData()

        Dim query As String = "SELECT * FROM Student"

        Dim dataTable As New DataTable()

        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                Using adapter As New SqlDataAdapter(query, connection)
                    adapter.Fill(dataTable)
                End Using

                DataGridView1.DataSource = dataTable
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)

            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Add()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadData()
    End Sub



    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length > MaxLength Then
            TextBox1.Text = TextBox1.Text.Substring(0, MaxLength)
            TextBox1.SelectionStart = TextBox1.Text.Length
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            Dim name As String = row.Cells("Name").Value.ToString()
            Dim program As String = row.Cells("Program").Value.ToString()
            Dim Id As Integer = row.Cells("Id").Value.ToString()

            TextBox1.Text = name
            TextBox2.Text = program
            TextBox3.Text = Id
        End If
    End Sub
    Private Sub Clear()

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Update()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Delete()
    End Sub
End Class
