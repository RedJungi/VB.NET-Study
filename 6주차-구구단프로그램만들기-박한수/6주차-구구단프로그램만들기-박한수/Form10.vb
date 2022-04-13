Public Class Form10
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iDan As Integer = 1
        Dim i As Integer = 1

        TextBox2.Text = ""  'Clear의 의미
        Do Until iDan > 9
            Do Until i > 9
                TextBox2.Text = TextBox2.Text & iDan & " X " & i _
                     & " = " & iDan * i & vbCrLf
                i = i + 1
            Loop
            i = 1
            iDan = iDan + 1
            TextBox2.AppendText(vbCrLf)
        Loop
    End Sub
End Class