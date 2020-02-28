Public Class adduser
    Private Sub UsersBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.UsersBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB1DataSet)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = " " Or NameTextBox.Text = "" Then
            MessageBox.Show("Error")


        Else

            UsersTableAdapter.RegisterNewUser(UsernameTextBox.Text, PasswordTextBox.Text, DesignationComboBox.Text)
            Me.UsersTableAdapter.Fill(DB1DataSet.users)
            MessageBox.Show("Inserted")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clear(Me)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        UsersTableAdapter.DeleteQuery(UsernameTextBox.Text, PasswordTextBox.Text, DesignationComboBox.Text, NameTextBox.Text)
        Me.UsersTableAdapter.Fill(DB1DataSet.users)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        UsersTableAdapter.UpdateQuery(UsernameTextBox.Text, PasswordTextBox.Text, DesignationComboBox.Text, NameTextBox.Text)
    End Sub

    Private Sub adduser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.UsersTableAdapter.Fill(DB1DataSet.users)
    End Sub
End Class
