Public Class View_Checked_in

    Private Sub View_Checked_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DB1DataSet1.EnforceConstraints = False
        Me.VisitorsTableAdapter1.FillCheckedIn(Me.DB1DataSet1.Visitors)
    End Sub

    Private Sub VisitorsDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles VisitorsDataGridView.CellDoubleClick
        Dim id As Integer = VisitorsDataGridView.SelectedCells.Item(0).Value
        Dim pv As New PopView(id)
        pv.Show()
    End Sub

    Private Sub Refreshbtn_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        Me.VisitorsTableAdapter1.FillCheckedIn(Me.DB1DataSet1.Visitors)
    End Sub

    Public Sub refresher()
        Me.VisitorsTableAdapter1.FillCheckedIn(Me.DB1DataSet1.Visitors)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles searchbtn.Click
        'Filter by badge - click search button
        If filterbox.Text = "" Then
            Me.VisitorsTableAdapter1.FillCheckedIn(Me.DB1DataSet1.Visitors)
        Else
            Me.VisitorsTableAdapter1.FilterbyBadge(Me.DB1DataSet1.Visitors, filterbox.Text.Trim)
        End If
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        Dim id As Integer = VisitorsDataGridView.SelectedCells.Item(0).Value
        Dim pv As New PopView(id)
        pv.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles checkoutbtn.Click
        'BIG CHECKOUT BUTTON
        Dim selectedrows As DataGridViewSelectedRowCollection = VisitorsDataGridView.SelectedRows

        'For i = 0 To VisitorsDataGridView.SelectedRows.Count()
        '    Dim checkout As String
        '    checkout = CheckOutMsg(selectedrows, DB1DataSet1)
        '    Me.VisitorsTableAdapter1.CHECKOUT(selectedrows.Item(i).Cells.Item(0).Value)
        'Next
        Dim checkout = CheckOutMsg(selectedrows)


        'Dim id As Integer = selectedcells.Item(0).Value


        'Dim checkout As String
        'checkout = CheckOutMsg(selectedcells, DB1DataSet1)

        If checkout = vbYes Then
            For i = 0 To selectedrows.Count() - 1
                Me.VisitorsTableAdapter1.CHECKOUT(selectedrows.Item(i).Cells.Item(0).Value)
                BadgesTableAdapter1.ReturnBadge(selectedrows.Item(i).Cells.Item(1).Value)
            Next

            SuccessMsg()
            refreshAll()
            'Else
            '    MsgBox("No one was checked out.")
        End If
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles filterbox.GotFocus
        filterbox.Clear()
    End Sub

    Private Sub filterbox_TextChanged(sender As Object, e As EventArgs) Handles filterbox.TextChanged

        If filterbox.Text = "" Then
            Me.VisitorsTableAdapter1.FillCheckedIn(Me.DB1DataSet1.Visitors)
        Else
            Me.VisitorsTableAdapter1.FilterbyBadge(Me.DB1DataSet1.Visitors, filterbox.Text.Trim)
        End If
    End Sub
End Class
