Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("hi how are you?")
        Dim answer = InputBox("Well?")
        Label1.text = answer
    End Sub
End Class
