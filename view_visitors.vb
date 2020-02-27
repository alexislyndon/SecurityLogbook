Public Class view_visitors
    Private Sub VisitorsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.VisitorsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DB1DataSet)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Me.VisitorsBindingSource.Filter = "surname LIKE'" & TextBox1.Text & "%'" = False Then
            MessageBox.Show("Not Found")
        Else
            Me.VisitorsBindingSource.Filter = "surname LIKE'" & TextBox1.Text & "%'"
        End If
    End Sub
End Class
