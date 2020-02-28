Public Class Dash
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        Login.Close()
    End Sub

    Private Sub Add_visitor_btn_Click(sender As Object, e As EventArgs) Handles Add_visitor_btn.Click
        Add_Visitor1.Visible = True
        Add_Vehicle1.Visible = False
        View_Checked_in1.Visible = False
        View_Checked_in_Vehicles1.Visible = False
        Add_Visitor1.ErrorProvider1.Clear()
    End Sub

    Private Sub view_checkin_btn_Click(sender As Object, e As EventArgs) Handles view_checkin_btn.Click
        'VIEW CHECKED IN PEOPLE
        Add_Visitor1.Visible = False
        Add_Vehicle1.Visible = False
        View_Checked_in1.Visible = True
        View_Checked_in_Vehicles1.Visible = False
        Add_Visitor1.ErrorProvider1.Clear()

    End Sub

    Private Sub add_vehicle_btn_Click(sender As Object, e As EventArgs) Handles add_vehicle_btn.Click
        Add_Visitor1.Visible = False
        Add_Vehicle1.Visible = True
        View_Checked_in1.Visible = False
        View_Checked_in_Vehicles1.Visible = False
        Add_Vehicle1.ErrorProvider1.Clear()

    End Sub

    Private Sub view_checkedin_btn_Click(sender As Object, e As EventArgs) Handles view_checkedin_btn.Click
        Add_Visitor1.Visible = False
        Add_Vehicle1.Visible = False
        View_Checked_in1.Visible = False
        View_Checked_in_Vehicles1.Visible = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = Date.Now.ToString("dddd") & vbCrLf & vbCrLf & Date.Now.ToString("dd - MMM - yyyy")
        'Label1.Text = Format(Now, "Long Date")
        Label3.Text = Date.Now.ToString(" HH:mm:ss")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles LogOutBtn.Click
        Dim dialog As DialogResult

        dialog = MessageBox.Show("Do you really want to log out?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            Me.Show()
        Else
            endsession()
            Me.Hide()
            Login.Show()
            ViewSelector.Hide()

        End If
        ' Me.Hide() 
        'Login.Show()
    End Sub
End Class