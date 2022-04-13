Public Class Form4

    Dim tTextBox_Input(9) As TextBox
    Dim tTextBox_Output(9) As TextBox
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tTextBox_Input(0) = TextBox1
        tTextBox_Input(1) = TextBox2
        tTextBox_Input(2) = TextBox3
        tTextBox_Input(3) = TextBox4
        tTextBox_Input(4) = TextBox5
        tTextBox_Input(5) = TextBox6
        tTextBox_Input(6) = TextBox7
        tTextBox_Input(7) = TextBox8
        tTextBox_Input(8) = TextBox9

        tTextBox_Output(0) = TextBox10
        tTextBox_Output(1) = TextBox11
        tTextBox_Output(2) = TextBox12
        tTextBox_Output(3) = TextBox13
        tTextBox_Output(4) = TextBox14
        tTextBox_Output(5) = TextBox15
        tTextBox_Output(6) = TextBox16
        tTextBox_Output(7) = TextBox17
        tTextBox_Output(8) = TextBox18
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i = 0 To 8
            If tTextBox_Input(i).Text = "" Then
                MessageBox.Show("TextBox" & i + 1 & ".Text에 점수를 입력하세요 ^^", "경고 1-" & i + i)
                tTextBox_Input(i).Focus()
                Exit Sub
            End If
        Next

        Dim iJumsu(9) As Integer
        Dim sHakjum(9) As String

        For i = 0 To 8
            iJumsu(i) = Val(tTextBox_Input(i).Text)
        Next

        For i = 0 To 8
            If iJumsu(i) > 100 Or iJumsu(i) < 0 Then
                MessageBox.Show("TextBox" & i + 1 & "에 0부터 100 사이의 값을 입력하세요", "경고 2-" & i + 1)
                tTextBox_Input(i).Focus()
                Exit Sub
            End If
        Next

        For i = 0 To 8
            Select Case iJumsu(i)
                Case Is >= 96
                    sHakjum(i) = "A+"
                Case Is >= 91
                    sHakjum(i) = "A0"
                Case Is >= 86
                    sHakjum(i) = "B+"
                Case Is >= 81
                    sHakjum(i) = "B0"
                Case Is >= 76
                    sHakjum(i) = "C+"
                Case Is >= 71
                    sHakjum(i) = "C0"
                Case Is >= 66
                    sHakjum(i) = "D+"
                Case Is >= 60
                    sHakjum(i) = "D0"
                Case Else
                    sHakjum(i) = "F! 재수강 ㅠㅠ"
            End Select
        Next

        For i = 0 To 8
            tTextBox_Output(i).Text = sHakjum(i)
        Next
    End Sub
End Class