Public Class Form5
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String
        str = "당신은" & Chr(13) & Chr(10)
        If RadioButton1.Checked = True Then str = str & RadioButton1.Text & "성"
        If RadioButton2.Checked = True Then str = str & RadioButton2.Text & "성"

        str = str & Chr(13) & Chr(10) & Chr(13) & Chr(10) & "좋아하는 동물은" & Chr(13) & Chr(10)
        If CheckBox1.Checked = True Then str = str & CheckBox1.Text & Chr(13) & Chr(10)
        If CheckBox2.Checked = True Then str = str & CheckBox2.Text & Chr(13) & Chr(10)
        If CheckBox3.Checked = True Then str = str & CheckBox3.Text & Chr(13) & Chr(10)
        If CheckBox4.Checked = True Then str = str & CheckBox4.Text & Chr(13) & Chr(10)
        If CheckBox5.Checked = True Then str = str & CheckBox5.Text & Chr(13) & Chr(10)
        If CheckBox6.Checked = True Then str = str & CheckBox6.Text & Chr(13) & Chr(10)

        str = str & "입니다"
        Label1.Text = str
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class