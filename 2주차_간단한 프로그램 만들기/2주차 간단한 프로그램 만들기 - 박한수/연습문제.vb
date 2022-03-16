Public Class 연습문제
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox3.Text = TextBox1.Text & "님 ~~ " + vbCrLf + "당신의 학번은 " + vbCrLf + TextBox2.Text + vbCrLf + "입니다." + vbCrLf + "반갑습니다 ^^ "
        MessageBox.Show(TextBox1.Text & "~~님!" + vbCrLf + "당신의 학번은 " + vbCrLf + TextBox2.Text + vbCrLf + " 입니다^^", Chr(34) + "확인 사항" + Chr(34))
    End Sub

    Private Sub TextBox2_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class