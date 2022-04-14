Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iJumsu As Integer : Dim sHakjum As String
        If TextBox1.Text = "" Then
            MessageBox.Show("점수를 입력하세요 ^^", "경고 1")
            GoTo Talcul
        End If
        iJumsu = Val(TextBox1.Text)
        If iJumsu > 100 Or iJumsu < 0 Then
            MessageBox.Show("0부터 100사이의 값을 입력하세요 ^^", "경고2")
            GoTo Talcul
        End If
        Select Case iJumsu
            Case 96 To 100
                sHakjum = "A+"
            Case 91 To 95
                sHakjum = "A0"
            Case 86 To 90
                sHakjum = "B+"
            Case 81 To 85
                sHakjum = "B0"
            Case 76 To 80
                sHakjum = "C+"
            Case 71 To 75
                sHakjum = "C0"
            Case 66 To 70
                sHakjum = "D+"
            Case 60 To 65
                sHakjum = "D0"
            Case Else
                sHakjum = "F! 재수강 ㅜㅜ"
        End Select
        TextBox2.Text = sHakjum
Talcul: TextBox1.Focus()
    End Sub
End Class