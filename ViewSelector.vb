Public Class ViewSelector
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles mainbtn.Click
        Dash.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        backForm.Show()
        Me.Hide()
    End Sub

    Private Sub adminbtn_Click(sender As Object, e As EventArgs) Handles adminbtn.Click
        Form1.Show()
        Me.Hide()
    End Sub
End Class