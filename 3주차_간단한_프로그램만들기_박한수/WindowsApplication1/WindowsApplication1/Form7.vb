Public Class Form7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Add(TextBox1.Text)
        TextBox1.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Add("장동건")
        ListBox1.Items.Add("이동건")
        ListBox1.Items.Add("정우성")
        ListBox1.Items.Add("조인성")
        ListBox1.Items.Add("박보검")


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndex <> -1 Then
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub
End Class