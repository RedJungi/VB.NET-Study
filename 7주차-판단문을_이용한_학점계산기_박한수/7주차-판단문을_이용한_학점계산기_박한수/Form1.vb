Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iJumsu As Integer : Dim sHakjum As String
        If TextBox1.Text = "" Then
            MessageBox.Show("점수를 입력하세요^^", "경고 1")
            TextBox1.Focus()
            Exit Sub
        End If
        iJumsu = Val(TextBox1.Text) ' Val은 실수로 알파벳을 입력할 경우 죽지 않게 만듬 영어로 쓰면 0으로 값을 가져옴
        If iJumsu > 100 Or iJumsu < 0 Then
            MessageBox.Show("0부터 100사이의 값을 입력하세요^^", "경고2")
            TextBox1.Focus() : Exit Sub
        End If
        If iJumsu >= 96 And iJumsu <= 100 Then 'And iJumsu <= 100 생략가능
            sHakjum = "A+"
        ElseIf iJumsu >= 91 Then
            sHakjum = "A0"
        ElseIf iJumsu >= 86 Then
            sHakjum = "B+"
        ElseIf iJumsu >= 81 Then
            sHakjum = "B0"
        ElseIf iJumsu >= 76 Then
            sHakjum = "C+"
        ElseIf iJumsu >= 71 Then
            sHakjum = "C0"
        ElseIf iJumsu >= 66 Then
            sHakjum = "D+"
        ElseIf iJumsu >= 60 Then
            sHakjum = "D0"
        Else
            sHakjum = "F : 재수강 당첨^^"
        End If
        TextBox2.Text = sHakjum '변수에 담긴 문자를 textbox2에 출력
    End Sub
End Class
