
Imports System.Text.RegularExpressions
Public Class Add_Vehicle
    Dim platergx As New Regex("^[a-zA-Z0-9-]+$")
    Dim gtg As Boolean = True
    Private Sub CheckIn_Click(sender As Object, e As EventArgs) Handles checkinbtn.Click

        For Each ctrl In Me.Controls
            ctrl.Text = byeSpace(ctrl.Text)
        Next

        If Not platergx.IsMatch(platebox.Text) Then 'plate
            gtg = False
            ErrorProvider1.SetError(platebox, "Only letters, numbers, and dashes are allowed. No spaces.")
        End If

        If makeCbox.Text = "" Then 'make
            gtg = False
            ErrorProvider1.SetError(makeCbox, "Please fill out this field")
        End If

        If modelbox.Text = "" Then 'model
            gtg = False
            ErrorProvider1.SetError(modelbox, "Please fill out this field")
        End If

        If colorbox.Text = "" Then 'color
            gtg = False
            ErrorProvider1.SetError(colorbox, "Please fill out this field")
        End If

        If typeCbox.Text = "" Then 'type
            gtg = False
            ErrorProvider1.SetError(typeCbox, "Please fill out this field")
        End If

        If gtg Then
            Try
                VehiclesTableAdapter.InsertVehicle(makeCbox.Text, modelbox.Text, colorbox.Text, platebox.Text, typeCbox.Text, getsessionid)
                MsgBox("Successfully Checked in visitor!")
                refreshAll()
                clear(Me)

            Catch ex As Exception
                MsgBox(ex)
            End Try
        End If
    End Sub


End Class
