Public Class Form3
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("TextBox1.Text에 점수를 입력하세요^^", "경고1")
            TextBox1.Focus()
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            MessageBox.Show("TextBox2.Text에 점수를 입력하세요^^", "경고2")
            TextBox2.Focus()
            Exit Sub
        End If
        If TextBox3.Text = "" Then
            MessageBox.Show("TextBox3.Text에 점수를 입력하세요^^", "경고3")
            TextBox3.Focus()
            Exit Sub
        End If

        If TextBox4.Text = "" Then
            MessageBox.Show("TextBox4.Text에 점수를 입력하세요^^", "경고4")
            TextBox4.Focus()
            Exit Sub
        End If
        If TextBox5.Text = "" Then
            MessageBox.Show("TextBox5.Text에 점수를 입력하세요^^", "경고5")
            TextBox5.Focus()
            Exit Sub
        End If



        If TextBox6.Text = "" Then
            MessageBox.Show("TextBox6.Text에 점수를 입력하세요^^", "경고6")
            TextBox6.Focus()
            Exit Sub
        End If


        If TextBox7.Text = "" Then
            MessageBox.Show("TextBox7.Text에 점수를 입력하세요^^", "경고7")
            TextBox7.Focus()
            Exit Sub
        End If



        If TextBox8.Text = "" Then
            MessageBox.Show("TextBox8.Text에 점수를 입력하세요^^", "경고8")
            TextBox8.Focus()
            Exit Sub
        End If

        If TextBox9.Text = "" Then
            MessageBox.Show("TextBox9.Text에 점수를 입력하세요^^", "경고9")
            TextBox9.Focus()
            Exit Sub
        End If


        Dim iJumsu(9) As Integer '배열변수 iJumsu(0), iJumsu(1)...iJumsu(8)를 선언
        Dim sHakjum(9) As String '배열변수 sHakjum(0),....sHakjum(8)를 선언

        iJumsu(0) = Val(TextBox1.Text)
        iJumsu(1) = Val(TextBox2.Text)
        iJumsu(2) = Val(TextBox3.Text)
        iJumsu(3) = Val(TextBox4.Text)
        iJumsu(4) = Val(TextBox5.Text)
        iJumsu(5) = Val(TextBox6.Text)
        iJumsu(6) = Val(TextBox7.Text)
        iJumsu(7) = Val(TextBox8.Text)
        iJumsu(8) = Val(TextBox9.Text)

        For j = 0 To 8
            If iJumsu(j) > 100 Or iJumsu(j) < 0 Then
                MessageBox.Show("TextBox" & j + 1 & "에 0부터 100사이의 값을 입력하세요^^", "경고 10")
                Exit Sub
            End If
        Next

        For j = 0 To 8
            If iJumsu(j) >= 96 Then
                sHakjum(j) = "A+"
            ElseIf iJumsu(j) >= 91 Then
                sHakjum(j) = "A+"
            ElseIf iJumsu(j) >= 86 Then
                sHakjum(j) = "B+"
            ElseIf iJumsu(j) >= 81 Then
                sHakjum(j) = "B0"
            ElseIf iJumsu(j) >= 76 Then
                sHakjum(j) = "C+"
            ElseIf iJumsu(j) >= 71 Then
                sHakjum(j) = "C0"
            ElseIf iJumsu(j) >= 66 Then
                sHakjum(j) = "D+"
            ElseIf iJumsu(j) >= 60 Then
                sHakjum(j) = "D0"
            Else
                sHakjum(j) = "F! 재수강 ㅠㅠ"
            End If
        Next

        TextBox10.Text = sHakjum(0)
        TextBox11.Text = sHakjum(1)
        TextBox12.Text = sHakjum(2)
        TextBox13.Text = sHakjum(3)
        TextBox14.Text = sHakjum(4)
        TextBox15.Text = sHakjum(5)
        TextBox16.Text = sHakjum(6)
        TextBox17.Text = sHakjum(7)
        TextBox18.Text = sHakjum(8)

    End Sub
End Class