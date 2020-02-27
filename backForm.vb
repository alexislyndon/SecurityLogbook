Public Class backForm
    Private Sub Add_visitor_btn_Click(sender As Object, e As EventArgs) Handles Add_visitor_btn.Click
        Add_Visitor1.Visible = True
        View_Checked_in1.Visible = False
    End Sub

    Private Sub view_checkin_btn_Click(sender As Object, e As EventArgs) Handles view_checkin_btn.Click
        Add_Visitor1.Visible = False
        View_Checked_in1.Visible = True
    End Sub

    Private Sub LogOutBtn_Click(sender As Object, e As EventArgs) Handles LogOutBtn.Click
        Dim dialog As DialogResult

        dialog = MessageBox.Show("Do you really want to log out?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            Me.Show()
        Else
            Me.Hide()
            Login.Show()
            ViewSelector.Hide()

        End If
    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = Date.Now.ToString("dddd") & vbCrLf & vbCrLf & Date.Now.ToString("dd - MMM - yyyy")
        'Label1.Text = Format(Now, "Long Date")
        Label3.Text = Date.Now.ToString(" HH:mm:ss")
    End Sub


End Class