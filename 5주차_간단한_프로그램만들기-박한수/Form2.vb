Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        For iDan = 1 To 9
            For i = 1 To 9
                TextBox1.Text = TextBox1.Text & iDan & " X " & i & " = " & iDan * i & vbCrLf
            Next
            TextBox1.Text = TextBox1.Text & vbCrLf
        Next
    End Sub
End Class