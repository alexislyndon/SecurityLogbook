Public Class View_Checked_in
    Private Sub VisitorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VisitorsBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.DB1DataSet1)

    End Sub

    Private Sub View_Checked_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VisitorsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        DB1DataSet1.Visitors.Clear()
        DB1DataSet1.EnforceConstraints = False
        'Me.VisitorsTableAdapter1.Fill(Me.DB1DataSet1.Visitors)
        Me.VisitorsTableAdapter1.Fill(Me.DB1DataSet1.Visitors)
    End Sub

    Private Sub VisitorsDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles VisitorsDataGridView.CellDoubleClick
        Dim id As Integer = VisitorsDataGridView.SelectedCells.Item(0).Value
        Dim pv As New PopView(id)
        pv.Show()
    End Sub

End Class
