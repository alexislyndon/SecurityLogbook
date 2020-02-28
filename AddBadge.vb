Public Class AddBadge
    Private Sub BadgesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) 
        Me.Validate()
        Me.BadgesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB1DataSet)

    End Sub
End Class
