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

    Private Sub Refreshbtn_Click(sender As Object, e As EventArgs) Handles Refreshbtn.Click
        Me.VisitorsTableAdapter1.FillCheckedIn(Me.DB1DataSet1.Visitors)
    End Sub

    Public Sub refresher()
        TextBox1.Text = "Filter by Badge"
        Me.VisitorsTableAdapter1.FillCheckedIn(Me.DB1DataSet1.Visitors)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Filter by badge - click search button
        If TextBox1.Text = "" Then
            Me.VisitorsTableAdapter1.FillCheckedIn(Me.DB1DataSet1.Visitors)
        Else
            Me.VisitorsTableAdapter1.FilterbyBadge(Me.DB1DataSet1.Visitors, TextBox1.Text.Trim)
        End If
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        Dim id As Integer = VisitorsDataGridView.SelectedCells.Item(0).Value
        Dim pv As New PopView(id, vciObj)
        pv.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim selectedcells As DataGridViewSelectedCellCollection = VisitorsDataGridView.SelectedCells

        testestest(selectedcells)
    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.GotFocus
        TextBox1.Clear()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            If TextBox1.Text = "" Then
                Me.VisitorsTableAdapter1.FillCheckedIn(Me.DB1DataSet1.Visitors)
            Else
                Me.VisitorsTableAdapter1.FilterbyBadge(Me.DB1DataSet1.Visitors, TextBox1.Text.Trim)
                e.Handled = True
            End If
        End If
    End Sub

End Class
