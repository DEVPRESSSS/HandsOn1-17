<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        ListBox1 = New ListBox()
        ListBox2 = New ListBox()
        Button1 = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(ListBox2)
        Panel1.Controls.Add(ListBox1)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 450)
        Panel1.TabIndex = 0
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 25
        ListBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5"})
        ListBox1.Location = New Point(178, 106)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(192, 229)
        ListBox1.TabIndex = 0
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 25
        ListBox2.Location = New Point(408, 106)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(192, 229)
        ListBox2.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(178, 66)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 2
        Button1.Text = "Run"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox1 As ListBox

End Class
