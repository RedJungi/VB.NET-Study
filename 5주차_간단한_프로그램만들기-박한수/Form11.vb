Public Class Form11
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iDan As Integer = 1
        Dim i As Integer = 1

        TextBox2.Text = ""
        Do
            Do
                TextBox2.Text = TextBox2.Text & iDan & " X " & i & " = " & iDan * i & vbCrLf
                i += 1
            Loop Until i > 9
            i = 1
            iDan = iDan + 1
            TextBox2.AppendText(vbCrLf)
        Loop Until iDan > 9
    End Sub
End Class