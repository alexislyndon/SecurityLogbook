
Public Class REGISTER
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then
            MessageBox.Show("Error! Please input data's in the textbox")

        Else
            Me.UsersTableAdapter.RegisterNewUser(UsernameTextBox.Text, PasswordTextBox.Text, DesignationComboBox.Text)
            Me.UsersTableAdapter.Fill(DB1DataSet.users)
            MessageBox.Show("SUCCESSFULLY ADDED INTO THE USER")
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()

        End If

    End Sub

    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB1DataSet)


    End Sub

    Private Sub DesignationLabel_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub REGISTER_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB1DataSet.EnforceConstraints = False
        Me.UsersTableAdapter.Fill(DB1DataSet.users)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim Dialog As DialogResult

        Dialog = MessageBox.Show("Do you really want to Delete?", "Deleted", MessageBoxButtons.YesNo)
        If Dialog = DialogResult.No Then
            MessageBox.Show("Cancelled")
        Else
            Me.UsersTableAdapter.DeleteQuery(UsernameTextBox.Text, PasswordTextBox.Text, DesignationComboBox.Text)
            MessageBox.Show("SUCCESSFULLY DELETED")
            Me.UsersTableAdapter.Fill(DB1DataSet.users)
        End If

    End Sub

    Private Sub update_btn_Click(sender As Object, e As EventArgs) Handles update_btn.Click
        Me.UsersTableAdapter.UpdateQuery(UsernameTextBox.Text, PasswordTextBox.Text, DesignationComboBox.Text)
        Me.UsersTableAdapter.Fill(DB1DataSet.users)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click



        If Me.UsersBindingSource.Filter = "username LIKE'" & TextBox1.Text & "%'" = False Then
            MessageBox.Show("Username Not Found")
        Else
            Me.UsersBindingSource.Filter = "username LIKE'" & TextBox1.Text & "%'"
        End If

    End Sub

    Private Sub TextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles TextBox1.MouseClick
        TextBox1.Clear()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        UsernameTextBox.Clear()
        PasswordTextBox.Clear()

    End Sub
End Class
