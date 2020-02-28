Public Class UserControl1
    Private Sub VehiclesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VehiclesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB1DataSet)

    End Sub

    Private Sub UserControl1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.VisitorsTableAdapter.Fill(Me.DB1DataSet.Visitors)
        CheckBox1.CheckState = True
    End Sub

    Private Sub filterbox_TextChanged(sender As Object, e As EventArgs) Handles filterbox.TextChanged
        If filterbyCbox.Text = "Family Name" Then

        End If
        If filterbyCbox.Text = "First Name" Then

        End If
        'Me.VisitorsTableAdapter.Fill(Me.DB1DataSet.Visitors)
    End Sub
End Class
