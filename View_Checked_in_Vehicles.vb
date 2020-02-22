Public Class View_Checked_in_Vehicles
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub VisitorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.VisitorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB1DataSet)

    End Sub
End Class
