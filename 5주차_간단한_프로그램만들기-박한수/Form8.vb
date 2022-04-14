Public Class Form8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iDan As Integer = 1
        Dim i As Integer = 1

        TextBox2.Text = ""
        Do While iDan <= 9
            Do While i <= 9
                TextBox2.Text = TextBox2.Text & iDan & " X " & i & " = " & iDan * i & vbCrLf
                i += 1
            Loop
            i = 1
            iDan = iDan + 1
            TextBox2.AppendText(vbCrLf)
        Loop
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class