Public Class Login
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dash.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        'passwordbox
        TextBox2.Clear()
        TextBox2.PasswordChar = "*"
        TextBox2.ForeColor = Color.FromArgb(78, 184, 206)
        Panel2.BackColor = Color.FromArgb(78, 184, 206)
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        'username box
        TextBox1.Clear()
        TextBox1.ForeColor = Color.FromArgb(78, 184, 206)
        Panel1.BackColor = Color.FromArgb(78, 184, 206)
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        'USERNAME NO FOCUS box
        If TextBox1.Text = "" Then
            TextBox1.Text = "Username"
        End If
        TextBox1.ForeColor = Color.Gray
        Panel1.BackColor = Color.Gray
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        'PASSWORD NO FOCUS box
        TextBox2.ForeColor = Color.Gray
        Panel2.BackColor = Color.Gray
        If TextBox2.Text = "" Then
            TextBox2.PasswordChar = ""
            TextBox2.Text = "Password"
        End If

    End Sub

End Class
