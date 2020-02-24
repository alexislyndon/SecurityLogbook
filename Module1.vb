Imports System.Text.RegularExpressions
Imports System.ComponentModel
Imports System.IO
Module Module1
    Dim path As String = My.Application.Info.DirectoryPath
    Function imgtobyte(img As Image, usedcamera As Boolean) As Byte()
        If usedcamera Then
            Return imgToByteConverter(img)
        Else
            Return Nothing
        End If
    End Function

    Public Function imgToByteConverter(ByVal inImg As Image) As Byte()
        Dim imgCon As New ImageConverter()
        Return DirectCast(imgCon.ConvertTo(inImg, GetType(Byte())), Byte())
    End Function

    Public Function byteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        If Not IsDBNull(byteArrayIn) Then
            Using mStream As New MemoryStream(byteArrayIn)
                Return Image.FromStream(mStream)
            End Using
        End If
    End Function

    Function isvalid(hehe As Add_Visitor) As Boolean

        Dim valid As Boolean = True
        For Each ctrl In hehe.Controls
            Dim tb = TryCast(ctrl, TextBox)
            Dim cb = TryCast(ctrl, ComboBox)
            If tb IsNot Nothing Then
                If tb.Text.Trim = "" Then
                    tb.BackColor = Color.Red
                    valid = False
                End If
            End If

            If cb IsNot Nothing Then
                If cb.SelectedIndex = -1 Or cb.Text.Trim = "" Then
                    cb.BackColor = Color.Red
                    valid = False
                End If
            End If
        Next
        Return valid
    End Function

    Public Sub clearer(obj As Add_Visitor)
        For Each ctrl In obj.Controls
            Dim tb = TryCast(ctrl, TextBox)
            Dim cb = TryCast(ctrl, ComboBox)
            If tb IsNot Nothing Then
                tb.Clear()
            End If

            If cb IsNot Nothing Then
                'cb.Text = ""
                cb.SelectedIndex = -1
            End If
        Next
        'obj.PictureBox1.Image = Image.FromFile("X:\1902\VB.net\Security Logbook\img\portrait.jpg")
        IO.Path.Combine(path, "\img\portrait.jpg")
        obj.PictureBox1.Image = Image.FromFile("X:\1902\VB.net\Security Logbook\img\portrait.jpg")
        obj.PictureBox2.Image = Image.FromFile("X:\1902\VB.net\Security Logbook\img\blankid.jpg")

    End Sub
End Module
