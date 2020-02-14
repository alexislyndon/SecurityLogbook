
Public Class Add_Visitor

    Private Sub Add_Visitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckIn_Click(sender As Object, e As EventArgs) Handles CheckIn.Click, portrait.Click, captureID.Click, cam.Click
        webcamcap.Show()
    End Sub
End Class
