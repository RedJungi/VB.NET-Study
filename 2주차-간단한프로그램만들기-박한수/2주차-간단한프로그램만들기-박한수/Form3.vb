Public Class Form3
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(TextBox1.Text & "님~~ " + vbCrLf + "당신의 학번은 " + vbCrLf +
            TextBox3.Text + "입니다. " + Chr(13) + Chr(10) + "반갑습니다^^", "요거까지 하면 집에 보내주지")
        TextBox2.Text = TextBox1.Text & "님~~ " + vbCrLf + "당신의 학번은 " + vbCrLf +
            TextBox3.Text + "입니다. " + Chr(13) + Chr(10) + "반갑습니다^^"

    End Sub
End Class