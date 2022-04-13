Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = ""  'Clear의 의미
        For iDan = 1 To 9 Step 3
            For i = 1 To 9
                For iTab = 0 To 2
                    TextBox2.Text = TextBox2.Text & (iDan + iTab) _
                        & " X " & i & " = " & (iDan + iTab) * i & "       "
                Next
                TextBox2.Text = TextBox2.Text & vbCrLf
            Next
            TextBox2.Text = TextBox2.Text & vbCrLf
        Next
    End Sub
End Class