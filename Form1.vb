Public Class Form1
    Private Sub Add_visitor_btn_Click(sender As Object, e As EventArgs) Handles Add_visitor_btn.Click

    End Sub

    Private Sub view_checkin_btn_Click(sender As Object, e As EventArgs) Handles view_checkin_btn.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label4.Text = Date.Now.ToString("dddd") & vbCrLf & vbCrLf & Date.Now.ToString("dd - MMM - yyyy")
        'Label1.Text = Format(Now, "Long Date")
        Label3.Text = Date.Now.ToString(" HH:mm:ss")
    End Sub
End Class