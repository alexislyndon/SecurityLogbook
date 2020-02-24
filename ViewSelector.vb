Public Class ViewSelector
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dash.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        backForm.Show()
        Me.Hide()
    End Sub
End Class