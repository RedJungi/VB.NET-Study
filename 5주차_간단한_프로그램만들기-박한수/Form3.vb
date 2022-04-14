Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = ""
        For iDan = 1 To 9 Step 3
            For i = 1 To 9
                For iTab = 0 To 2
                    TextBox1.Text = TextBox1.Text & (iDan + iTab) & " X " & i & " = " & ((iDan _
                        + iTab) * i) & "       "
                Next
                TextBox1.Text = TextBox1.Text & vbCrLf
            Next
            TextBox1.Text = TextBox1.Text & vbCrLf
        Next
    End Sub
End Class