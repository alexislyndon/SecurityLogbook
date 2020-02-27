Imports Emgu.CV
Imports Emgu.CV.UI
Imports Emgu.CV.Structure
Imports System.IO
Public Class capturePortrait

    Dim fileName = String.Format("D:\secu\P_{0:yyyyMMddHHmmss}.txt", Date.Now)
    Dim avobj As Add_Visitor
    Dim cap As New Capture() 'first line
    Dim rotated As Boolean = False
    Public Sub New(av As Add_Visitor)
        cap.FlipHorizontal = True
        cap.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, 320) '424
        cap.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, 240) '240
        avobj = av
        InitializeComponent()
        Timer1.Start()
    End Sub

    Dim addvisitorsObj As Add_Visitor

    Private Sub capturepic(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapturePor.Click
        If Not rotated Then
            rotate()
        End If
        Timer1.Stop()
        'cap.Dispose()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PictureBox1.Image = cap.QueryFrame.ToBitmap() 'Second line
        'Label1.Text = Date.Now.ToString("ddMMMyyyyddd") & vbCrLf & Date.Now.ToString("HH:mm:ss")
        'Label1.Text = Date.Now.ToString("yyyy:MMM:dd:hh:mm:ss")
    End Sub

    Private Sub StartCapture(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Start.Click
        Timer1.Start()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cap.FlipHorizontal = True
        cap.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_WIDTH, 320) '424
        cap.SetCaptureProperty(Emgu.CV.CvEnum.CAP_PROP.CV_CAP_PROP_FRAME_HEIGHT, 240) '240
    End Sub

    Private Sub Save_Click(sender As Object, e As EventArgs) Handles Save.Click 'SAAAAAAAAAAAAAAAAAAAVE
        If Not rotated Then
            rotate()
        End If
        PictureBox1.Image.Save(fileName, Imaging.ImageFormat.Jpeg)
        avobj.setportraitpic(PictureBox1.Image)
        cap.Dispose()
        Me.Dispose()
        avobj.hadcappor = True
    End Sub
    Private Sub rotate()
        If Not rotated Then
            PictureBox1.Image.RotateFlip(RotateFlipType.RotateNoneFlipX)
            rotated = True
        End If
    End Sub
End Class