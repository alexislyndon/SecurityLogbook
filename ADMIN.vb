Public Class ADMIN
    Private Sub Add_User_Click(sender As Object, e As EventArgs) Handles Add_User.Click
        Register1.Visible = True
        View_visitors1.Visible = False
        View_Vehicles1.Visible = False
    End Sub



    Private Sub LogOutBtn_Click(sender As Object, e As EventArgs) Handles LogOutBtn.Click
        Dim Dialog As DialogResult

        Dialog = MessageBox.Show("Do you really want to log out?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            Me.Show()
        Else
            Me.Hide()
            Login.Show()
            ViewSelector.Hide()

        End If
    End Sub

    Private Sub view_visitors_btn_Click(sender As Object, e As EventArgs) Handles view_visitors_btn.Click
        Register1.Visible = False
        View_visitors1.Visible = True
        View_Vehicles1.Visible = False
    End Sub

    Private Sub view_checkedin_btn_Click(sender As Object, e As EventArgs) Handles view_checkedin_btn.Click
        Register1.Visible = False
        View_visitors1.Visible = False
        View_Vehicles1.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = Date.Now.ToString("dddd") & vbCrLf & vbCrLf & Date.Now.ToString("dd - MMM - yyyy")
        'Label1.Text = Format(Now, "Long Date")
        Label3.Text = Date.Now.ToString(" HH:mm:ss")
    End Sub
End Class