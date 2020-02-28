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
        Else
            Return Nothing
        End If
    End Function

    Public Sub clear(obj)
        For Each ctrl In obj.Controls
            Dim tb = TryCast(ctrl, TextBox)
            Dim cb = TryCast(ctrl, ComboBox)
            'Dim pb = TryCast(ctrl, PictureBox)

            If tb IsNot Nothing Then
                tb.Clear()
            End If

            If cb IsNot Nothing Then
                'cb.Text = ""
                cb.SelectedIndex = -1
            End If

            'If True Then
            '    If pb.Name = "Picturebox1" Then
            '        pb.Image = Image.FromFile("X:\1902\VB.net\Security Logbook\img\portrait.jpg")
            '    End If
            '    If pb.Name = "Picturebox2" Then
            '        pb.Image = Image.FromFile("X:\1902\VB.net\Security Logbook\img\blankid.jpg")
            '    End If
            '    If pb.Name = "Picturebox3" Then
            '        pb.Image = Image.FromFile("X:\1902\VB.net\Security Logbook\img\backside.jpg")
            '    End If
            'End If
        Next
    End Sub

    Public Function CheckOutMsg(selectedrows As DataGridViewSelectedRowCollection)
        Dim cnt As Integer = selectedrows.Count()
        Dim cols As Integer = 3
        Dim arr(cnt, cols)
        Dim str As String = "Check out: " & vbCrLf & vbCrLf
        For i = 0 To cnt - 1 'populate the array | badge | name |
            For j = 1 To cols - 1
                arr(i, j) = selectedrows.Item(i).Cells.Item(j).Value
            Next
        Next
        For i = 0 To cnt - 1
            For j = 1 To cols - 1
                Dim helper As String = ""
                If j = 1 Then
                    helper = "Badge: "
                    helper += arr(i, j) & " "
                    str += helper
                End If
                If j = 2 Then
                    helper = "Name: "
                    helper += arr(i, j) & vbCrLf
                    str += helper
                End If
            Next
        Next


        Return MessageBox.Show(str,
                    "Confirm Checkout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
    End Function

    Public Sub SuccessMsg()
        MessageBox.Show("Checkout Success." & vbCrLf,
               "Checkout Success.", MessageBoxButtons.OK, MessageBoxIcon.Information
               )
    End Sub
    Public Function byeSpace(str As String) As String 'removes extra spaces
        Dim rgx As New Regex("\s+")
        Return rgx.Replace(str, " ").Trim
    End Function

    Public Sub refreshAll()
        Dash.View_Checked_in1.refresher()
        Dash.View_Checked_in_Vehicles1.refresher()
    End Sub


End Module
