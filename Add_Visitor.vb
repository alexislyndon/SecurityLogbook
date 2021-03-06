﻿
Imports System.Text.RegularExpressions
Public Class Add_Visitor 'checks in visitor

    Dim names As New Regex("^[a-zA-z\s]+$")
    Dim phonenumber As New Regex("^\+?[\d]+$")
    Dim goodtogo As Boolean = True
    Public hadcappor As Boolean = False 'had captured a portrait
    Public hadcapid As Boolean = False 'had captured id 
    Public hadcapback As Boolean = False 'had captured id 
    Dim boo As Boolean = False
    Dim gtg As Boolean = True

    Dim maxid As Integer
    Dim sextoDB As String

    Private Sub Add_Visitor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.BadgesTableAdapter1.FillBadge(Me.DB1DataSet2.Badges)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        PictureBox2.Visible = True
        PictureBox3.Visible = False
        If VisitorsTableAdapter.MaxID() Is Nothing Then
            maxid = 1
        Else
            maxid = VisitorsTableAdapter.MaxID() + 1
        End If
        ErrorProvider1.Clear()
        v_id.Text = maxid
    End Sub

    Private Sub CheckIn_Click(sender As Object, e As EventArgs) Handles CheckIn.Click
        ''''///// CHECK IN HERE ///// ''''
        Dim sex As String = sexcbox.Text
        gtg = True
        Select Case sex
            Case "Male"
                sextoDB = "m"
            Case "Female"
                sextoDB = "f"
            Case Else
                sextoDB = "o"
        End Select

        For Each ctrl In Me.Controls
            ctrl.Text = byeSpace(ctrl.Text)
        Next

        If Not names.IsMatch(Last_NameTextBox.Text) Then 'lastname
            gtg = False
            ErrorProvider1.SetError(Last_NameTextBox, "Only Letters and Spaces allowed")
        End If
        If Not names.IsMatch(First_NameTextBox.Text) Then 'firstname
            gtg = False
            ErrorProvider1.SetError(First_NameTextBox, "Only Letters and Spaces allowed")
        End If
        If Not names.IsMatch(Middle_NameTextBox.Text) Then 'middlename
            gtg = False
            ErrorProvider1.SetError(Middle_NameTextBox, "Only Letters and Spaces allowed")
        End If
        If sexcbox.SelectedIndex = -1 Then 'sex
            gtg = False
            ErrorProvider1.SetError(sexcbox, "Please Select Sex.")
        End If
        If Not phonenumber.IsMatch(Phone_NumberTextBox.Text) Then 'phone
            gtg = False
            ErrorProvider1.SetError(Phone_NumberTextBox, "Only numbers and/or a '+' at the beginning is allowed.")
        End If
        If destinationcbox.Text = "" Then 'destination
            gtg = False
            ErrorProvider1.SetError(destinationcbox, "Please fill out Destination Field.")
        End If
        If purposebox.Text = "" Then 'purpose
            gtg = False
            ErrorProvider1.SetError(purposebox, "Please fill out Purpose Field.")
        End If
        If surrenderedcbox.Text = "" Then 'id surrendered
            gtg = False
            ErrorProvider1.SetError(surrenderedcbox, "Please fill out this Field.")
        End If
        If BadgeComboBox.Text = "" Then 'badge
            gtg = False
            ErrorProvider1.SetError(BadgeComboBox, "Please fill out this Field.")
        End If


        If gtg Then
            Try
                VisitorsTableAdapter.CheckIn(First_NameTextBox.Text.Trim, Middle_NameTextBox.Text.Trim, Last_NameTextBox.Text.Trim,
            sextoDB, "m", destinationcbox.Text, purposebox.Text, BadgeComboBox.Text,
                                         imgtobyte(PictureBox1.Image, hadcappor), imgtobyte(PictureBox2.Image, hadcapid), surrenderedcbox.Text, imgtobyte(PictureBox3.Image, hadcapback), Phone_NumberTextBox.Text, getsessionid())
                BadgesTableAdapter1.TakeBadge(BadgeComboBox.Text)
                MsgBox("Successfully Checked in visitor!")
                ErrorProvider1.Clear()
                hadcapid = False
                hadcappor = False
                hadcapback = False
                PictureBox1.Image = Image.FromFile("X:\1902\VB.net\Security Logbook\img\portrait.jpg")
                PictureBox2.Image = Image.FromFile("X:\1902\VB.net\Security Logbook\img\blankid.jpg")
                PictureBox3.Image = Image.FromFile("X:\1902\VB.net\Security Logbook\img\backside.jpg")

                maxid = VisitorsTableAdapter.MaxID() + 1
                v_id.Text = maxid
                refreshAll()
                clear(Me)

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        Else
            MsgBox("Please fill out the form completely and correctly.")
        End If
    End Sub

    Private Sub captureID_Click(sender As Object, e As EventArgs) Handles capidbtn.Click
        'take picture of ID
        PictureBox2.Image = Nothing
        Dim cid As New captureID(Me)
        cid.Show()
    End Sub

    Private Sub portrait_Click(sender As Object, e As EventArgs) Handles capportraitbtn.Click
        'take picture of person
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
    Public Sub setidback(img As Image)
        PictureBox3.Image = img
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox2.Visible = False
        PictureBox3.Visible = True
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureBox3.Visible = False
        PictureBox2.Visible = True
    End Sub

    Private Sub AddNew_Click(sender As Object, e As EventArgs) Handles AddNew.Click
        clear(Me)
        PictureBox1.Image = Image.FromFile("X:\1902\VB.net\Security Logbook\img\portrait.jpg")
        PictureBox2.Image = Image.FromFile("X:\1902\VB.net\Security Logbook\img\blankid.jpg")
        PictureBox3.Image = Image.FromFile("X:\1902\VB.net\Security Logbook\img\backside.jpg")
    End Sub

    'Private Sub FillBadgeToolStripButton_Click(sender As Object, e As EventArgs) Handles FillBadgeToolStripButton.Click
    '    Try
    '        Me.BadgesTableAdapter1.FillBadge(Me.DB1DataSet2.Badges)
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub

    Private Sub BadgeComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles BadgeComboBox.GotFocus
        Try
            Me.BadgesTableAdapter1.FillBadge(Me.DB1DataSet2.Badges)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
