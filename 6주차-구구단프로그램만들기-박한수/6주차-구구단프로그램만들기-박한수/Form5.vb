Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iDan As Integer
        Dim i As Integer = 1

        iDan = TextBox1.Text

        TextBox2.Text = ""  'Clear의 의미
        Do
            TextBox2.Text = TextBox2.Text & iDan & " X " & i _
                 & " = " & iDan * i & vbCrLf
            i = i + 1
        Loop While i <= 9
    End Sub
End Class