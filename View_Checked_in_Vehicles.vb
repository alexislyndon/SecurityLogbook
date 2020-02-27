Public Class View_Checked_in_Vehicles
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles checkoutbtn.Click

    End Sub

    Private Sub VisitorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VisitorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB1DataSet)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles filterbox.GotFocus
        filterbox.Clear()
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles filterbox.LostFocus
        If filterbox.Text = "" Then
            filterbox.Text = "Filter by plate number"
        End If
    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles filterbox.TextChanged
        Me.VehiclesTableAdapter.FillVehicleFilter(Me.DB1DataSet.Vehicles, filterbox.Text.Trim)

    End Sub

    Private Sub View_Checked_in_Vehicles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresher()
    End Sub

    Public Sub Button3_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        'refresh
        refresher()
    End Sub

    Public Sub refresher()
        Me.VehiclesTableAdapter.Fill(Me.DB1DataSet.Vehicles)
    End Sub


End Class
