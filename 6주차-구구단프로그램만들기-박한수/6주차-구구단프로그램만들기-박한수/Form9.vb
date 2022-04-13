Public Class Form9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iDan As Integer = 1
        Dim i As Integer = 1

        TextBox2.Text = ""  'Clear의 의미
        Do
            Do
                TextBox2.Text = TextBox2.Text & iDan & " X " & i _
                     & " = " & iDan * i & vbCrLf
                i = i + 1
            Loop While i <= 9
            i = 1
            iDan = iDan + 1
            TextBox2.AppendText(vbCrLf)
        Loop While iDan <= 9
    End Sub
End Class