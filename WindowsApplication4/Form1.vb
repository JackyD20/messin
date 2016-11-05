Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim name As String = Nothing
        name = Interaction.InputBox("what is your name?")
        MessageBox.Show("hello, " & name)

    End Sub
End Class
