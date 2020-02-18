Imports Emgu.CV
Imports Emgu.CV.UI
Imports Emgu.CV.Structure

Public Class webcamcap
    Dim cap As New Capture() 'first line

    Private Sub capturepic(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Capture.Click
        PictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
        PictureBox1.Image.Save("D:\axis.jpg")
        Timer1.Stop()
        'cap.Dispose()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PictureBox1.Image = cap.QueryFrame.ToBitmap() 'Second line
        Label1.Text = Date.Now.ToString("ddMMMyyyyddd") & vbCrLf & Date.Now.ToString("HH:mm:ss")
        'Label1.Text = Date.Now.ToString("yyyy:MMM:dd:hh:mm:ss")


    End Sub

    Private Sub StartCapture(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start.Click
        Timer1.Start()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cap.FlipHorizontal = True
        cap.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, 424) '424
        cap.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, 240) '240
    End Sub
End Class