﻿Public Class Login
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Me.Close()
    End Sub

    Private Sub loginbtn_Click(sender As Object, e As EventArgs) Handles loginbtn.Click
        If TextBox1.Text = "Username" Or TextBox2.Text = "Password" Then
            MsgBox("Please fill in username and password.")
        Else
            Try
                Dim u As String = TextBox1.Text.Trim
                Dim p As String = TextBox2.Text.Trim
                Dim udt As DB1DataSet.usersDataTable = UsersTableAdapter.GetDesignationQuery(u, p)
                Dim id As Integer
                Dim designation, name As String
                id = udt.Rows(0).Item(0)
                designation = udt.Rows(0).Item("designation")
                name = udt.Rows(0).Item("name")

                If designation = "admin" Then
                    'append userid to session and logs
                    'show the admin panel
                    startsession(id)
                    Form1.Show()
                    Me.Hide()

                ElseIf designation = "main" Then
                    startsession(id)
                    Dash.Show()
                    Me.Hide()
                ElseIf designation = "back" Then
                    startsession(id)
                    backForm.Show()
                    Me.Show()
                End If
                Me.Hide()
            Catch ex As Exception
                MsgBox("Wrong username or password.")
                'MsgBox(ex.ToString)

            End Try

        End If


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
