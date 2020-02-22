
Imports System.IO
Public Class Add_Visitor 'checks in visitor


    Shared av As New Add_Visitor
    Dim sextoDB As String

    Private Sub Add_Visitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        v_id.Text = VisitorsTableAdapter.MaxID() + 1
    End Sub

    Private Sub CheckIn_Click(sender As Object, e As EventArgs) Handles CheckIn.Click
        Dim sex As String = ComboBox2.Text
        Select Case sex
            Case "Male"
                sextoDB = "m"
            Case "Female"
                sextoDB = "f"
            Case Else
                sextoDB = "o"
        End Select
        VisitorsTableAdapter.CheckIn(First_NameTextBox.Text.Trim, Middle_NameTextBox.Text.Trim, Last_NameTextBox.Text.Trim, sextoDB, "m", destinationbox.Text, purposebox.Text, idbadge.Text, imgtobyte(PictureBox1.Image), imgtobyte(PictureBox2.Image), ComboBox3.Text, Phone_NumberTextBox.Text)
    End Sub


    Function imgtobyte(img) As Byte()
        Return imgToByteConverter(img)
    End Function

    Public Shared Function imgToByteConverter(ByVal inImg As Image) As Byte()
        Dim imgCon As New ImageConverter()
        Return DirectCast(imgCon.ConvertTo(inImg, GetType(Byte())), Byte())
    End Function
    Private Sub captureID_Click(sender As Object, e As EventArgs) Handles capidbtn.Click
        PictureBox2.Image = Nothing
        Dim cid As New captureID(Me)
        cid.Show()
    End Sub

    Private Sub portrait_Click(sender As Object, e As EventArgs) Handles capportraitbtn.Click
        PictureBox1.Image = Nothing
        Dim cp As New capturePortrait(Me)
        cp.Show()
    End Sub

    Public Sub setportraitpic(img As Image)
        PictureBox1.Image = img
    End Sub
    Public Sub setidpic(img As Image)
        PictureBox2.Image = img
    End Sub

    Public Function byteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Using mStream As New MemoryStream(byteArrayIn)
            Return Image.FromStream(mStream)
        End Using
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Image = byteArrayToImage(VisitorsTableAdapter.ViewPortrait(TextBox1.Text))
    End Sub
End Class
