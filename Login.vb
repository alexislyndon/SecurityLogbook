Public Class Login
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dash.Show()
        Me.Hide()
    End Sub
End Class
