Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim iSutja As Integer
        Dim dSum_Odd, dSum_Even As Double

        iSutja = TextBox1.Text

        TextBox2.Text = ""
        TextBox3.Text = ""

        For i = 1 To iSutja Step 1
            If i Mod 2 = 0 Then '짝수인 경우
                dSum_Even = dSum_Even + i
                If i = iSutja Or i = iSutja - 1 Then
                    TextBox3.Text = TextBox3.Text & i & " = "
                Else
                    TextBox3.Text = TextBox3.Text & i & " + "
                End If

            Else '홀수인 경우
                dSum_Odd = dSum_Odd + i
                If i = iSutja Or i = iSutja - 1 Then
                    TextBox2.Text = TextBox2.Text & i & " = "
                Else
                    TextBox2.Text = TextBox2.Text & i & " + "
                End If
            End If

        Next
        TextBox2.Text = TextBox2.Text & dSum_Odd
        TextBox3.Text = TextBox3.Text & dSum_Even
    End Sub
End Class