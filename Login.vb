﻿Public Class Login
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        Dim u As String = "alex"
        Dim p As String = "123"
        Dim udt As DB1DataSet.usersDataTable = UsersTableAdapter.GetDesignationQuery(u, p)
        Dim id As Integer
        Dim designation, name As String
        id = udt.Rows(0).Item(0)
        designation = udt.Rows(0).Item("designation")
        name = udt.Rows(0).Item("name")

        If designation = "admin" Then
            'append userid to session and logs
            'show the admin panel
            MsgBox("Please log in using a developer account.")
            startsession(id)
        ElseIf designation = "main" Then
            'append userid to session and logs
            'show main gate panel
            MsgBox("Please log in using a developer account.")
            startsession(id)
        ElseIf designation = "back" Then
            'append userid to session and logs
            'show main gate panel
            MsgBox("Please log in using a developer account.")
            startsession(id)
        ElseIf designation = "coder" Then
            ViewSelector.Show()
            Me.Hide()
            startsession(id)
        End If
        Me.Hide()
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.GotFocus
        'passwordbox
        TextBox2.Clear()
        TextBox2.PasswordChar = "*"
        TextBox2.ForeColor = Color.FromArgb(78, 184, 206)
        Panel2.BackColor = Color.FromArgb(78, 184, 206)
        Label3.Visible = False
        errorLbl.Text = ""
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        'username box
        TextBox1.Clear()
        TextBox1.ForeColor = Color.FromArgb(78, 184, 206)
        Panel1.BackColor = Color.FromArgb(78, 184, 206)
        Label3.Visible = False
        errorLbl.Text = ""
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles TextBox1.LostFocus
        'USERNAME NO FOCUS box
        If TextBox1.Text = "" Then
            TextBox1.Text = "Username"
            TextBox1.ForeColor = Color.Gray
            Panel1.BackColor = Color.Gray
        End If
    End Sub

    Private Sub TextBox2_LostFocus(sender As Object, e As EventArgs) Handles TextBox2.LostFocus
        'PASSWORD NO FOCUS box
        If TextBox2.Text = "" Then
            TextBox2.PasswordChar = ""
            TextBox2.Text = "Password"
            TextBox2.ForeColor = Color.Gray
            Panel2.BackColor = Color.Gray
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        errorLbl.Text = ""
    End Sub
End Class
