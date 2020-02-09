Public Class Dash
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
        Login.Close()
    End Sub

    Private Sub Add_visitor_btn_Click(sender As Object, e As EventArgs) Handles Add_visitor_btn.Click
        Add_Visitor1.Visible = True
        Add_Vehicle1.Visible = False
        Vehicles_History1.Visible = False
        Visitors_History1.Visible = False
        View_Checked_in1.Visible = False
        View_Checked_in_Vehicles1.Visible = False
    End Sub

    Private Sub view_checkin_btn_Click(sender As Object, e As EventArgs) Handles view_checkin_btn.Click
        Add_Visitor1.Visible = False
        Add_Vehicle1.Visible = False
        Vehicles_History1.Visible = False
        Visitors_History1.Visible = False
        View_Checked_in1.Visible = True
        View_Checked_in_Vehicles1.Visible = False
    End Sub

    Private Sub visitors_history_btn_Click(sender As Object, e As EventArgs) Handles visitors_history_btn.Click
        Add_Visitor1.Visible = False
        Add_Vehicle1.Visible = False
        Vehicles_History1.Visible = False
        Visitors_History1.Visible = True
        View_Checked_in1.Visible = False
        View_Checked_in_Vehicles1.Visible = False
    End Sub

    Private Sub add_vehicle_btn_Click(sender As Object, e As EventArgs) Handles add_vehicle_btn.Click
        Add_Visitor1.Visible = False
        Add_Vehicle1.Visible = True
        Vehicles_History1.Visible = False
        Visitors_History1.Visible = False
        View_Checked_in1.Visible = False
        View_Checked_in_Vehicles1.Visible = False
    End Sub

    Private Sub view_checkedin_btn_Click(sender As Object, e As EventArgs) Handles view_checkedin_btn.Click
        Add_Visitor1.Visible = False
        Add_Vehicle1.Visible = False
        Vehicles_History1.Visible = False
        Visitors_History1.Visible = False
        View_Checked_in1.Visible = False
        View_Checked_in_Vehicles1.Visible = True
    End Sub

    Private Sub vehicles_history_btn_Click(sender As Object, e As EventArgs) Handles vehicles_history_btn.Click
        Add_Visitor1.Visible = False
        Add_Vehicle1.Visible = False
        Vehicles_History1.Visible = True
        Visitors_History1.Visible = False
        View_Checked_in1.Visible = False
        View_Checked_in_Vehicles1.Visible = False
    End Sub
End Class