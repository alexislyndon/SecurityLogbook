Public Class View_Checked_in
    Private Sub VisitorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VisitorsBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.DB1DataSet1)

    End Sub

    Private Sub View_Checked_in_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TableAdapterManager1.UpdateAll(Me.DB1DataSet1)
    End Sub
End Class
