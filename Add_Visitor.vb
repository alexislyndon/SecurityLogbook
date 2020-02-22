
Imports System.IO
Public Class Add_Visitor 'checks in visitor
    Dim sex As String = ComboBox2.Text
    Dim sextoDB As String
    Dim portraitpath As String = "D:\portraittemp.jpg"
    Dim idpath As String = "D:\IDtemp.jpg"

    Private Sub Add_Visitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckIn_Click(sender As Object, e As EventArgs) Handles CheckIn.Click
        Select Case sex
            Case "Male"
                sextoDB = "m"
            Case "Female"
                sextoDB = "f"
            Case Else
                sextoDB = "o"
        End Select
        'path: "D:\IDtemp.jpg"
        'path: "D:\portraittemp.jpg"
        VisitorsTableAdapter.CheckIn(First_NameTextBox.Text.Trim, Middle_NameTextBox.Text.Trim, Last_NameTextBox.Text.Trim, sextoDB, "main", destinationbox.Text, purposebox.Text, idbadge.Text, imgtobyte(portraitpath), imgtobyte(idpath), ComboBox3.Text, Phone_NumberTextBox.Text)
    End Sub

    Private Sub captureID_Click(sender As Object, e As EventArgs) Handles capidbtn.Click
        captureID.Show()
    End Sub

    Function imgtobyte(imgpath) As Byte()
        Dim img As Image = Image.FromFile(imgpath)
        Return imgToByteConverter(img)
    End Function

    Public Shared Function imgToByteConverter(ByVal inImg As Image) As Byte()
        Dim imgCon As New ImageConverter()
        Return DirectCast(imgCon.ConvertTo(inImg, GetType(Byte())), Byte())
    End Function

    Private Sub portrait_Click(sender As Object, e As EventArgs) Handles capportraitbtn.Click
        capturePortrait.Show()
    End Sub
End Class
