Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With ComboBox2
            .Items.Add("일남")
            .Items.Add("일녀")
            .Items.Add("이남")
            .Items.Add("이남")
            .Items.Add("이녀")
            .Items.Add("삼남")
            .Items.Add("삼녀")
            .Items.Add("막내")
            .Text = .Items(0)
        End With
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show(TextBox1.Text & "님은" + ComboBox1.Text + "이고" + vbCrLf + "자녀중에" & ComboBox2.Text & "입니당", "가족관계")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class