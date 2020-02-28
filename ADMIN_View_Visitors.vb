Public Class ADMIN_View_Visitors
    Private Sub VisitorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VisitorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB1DataSet)

    End Sub

    Private Sub VisitorsDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles VisitorsDataGridView.CellDoubleClick
        Dim id As Integer = VisitorsDataGridView.SelectedCells.Item(0).Value
        Dim pv As New PopView(id)
        pv.Show()
    End Sub
    Private Sub ADMIN_View_Visitors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB1DataSet.EnforceConstraints = False
        Me.VisitorsTableAdapter.Fill(Me.DB1DataSet.Visitors)
    End Sub
End Class
