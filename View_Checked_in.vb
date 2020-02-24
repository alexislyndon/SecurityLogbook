Public Class View_Checked_in
    Private Sub VisitorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VisitorsBindingSource.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.DB1DataSet1)

    End Sub

End Class
