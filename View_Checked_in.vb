Public Class View_Checked_in
    Dim vciObj As View_Checked_in = Me
    'Dim vDT As DB1DataSet.VisitorsDataTable = Me.DB1DataSet1.Visitors 'vDT means visitorsdatatable

    Private Sub View_Checked_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'DB1DataSet1.Visitors.Clear()
        DB1DataSet1.EnforceConstraints = False
        'Me.VisitorsTableAdapter1.Fill(Me.DB1DataSet1.Visitors)
        Me.VisitorsTableAdapter1.FillCheckedIn(Me.DB1DataSet1.Visitors)
    End Sub

    Private Sub VisitorsDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles VisitorsDataGridView.CellDoubleClick
        Dim id As Integer = VisitorsDataGridView.SelectedCells.Item(0).Value
        Dim pv As New PopView(id, vciObj)
        pv.Show()
    End Sub

    Private Sub Refreshbtn_Click(sender As Object, e As EventArgs) Handles refreshbtn.Click
        Me.VisitorsTableAdapter1.FillCheckedIn(Me.DB1DataSet1.Visitors)
    End Sub

    Public Sub refresher()
        filterbox.Text = "Filter by Badge"
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
        Dim pv As New PopView(id, vciObj)
        pv.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles checkoutbtn.Click

        'big checkout button
        Dim selectedcells As DataGridViewSelectedCellCollection = VisitorsDataGridView.SelectedCells
        Dim id As Integer = selectedcells.Item(0).Value

        Dim checkout As String
        checkout = CheckOutMsg(selectedcells, DB1DataSet1)

        If checkout = vbYes Then
            Me.VisitorsTableAdapter1.CHECKOUT(id)

            SuccessMsg()
            refresher()
        End If
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles filterbox.GotFocus
        filterbox.Clear()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles filterbox.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            If filterbox.Text = "" Then
                Me.VisitorsTableAdapter1.FillCheckedIn(Me.DB1DataSet1.Visitors)
            Else
                Me.VisitorsTableAdapter1.FilterbyBadge(Me.DB1DataSet1.Visitors, filterbox.Text.Trim)
                e.Handled = True
            End If
        End If
    End Sub
End Class
