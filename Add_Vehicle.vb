
Imports System.Text.RegularExpressions
Public Class Add_Vehicle
    Dim platergx As New Regex("^[a-zA-Z0-9-]+$")
    Dim gtg As Boolean = True
    Private Sub CheckIn_Click(sender As Object, e As EventArgs) Handles CheckIn.Click

        For Each ctrl In Me.Controls
            ctrl.Text = byeSpace(ctrl.Text)
        Next

        If Not platergx.IsMatch(Plate.Text) Then 'plate
            gtg = False
            ErrorProvider1.SetError(Plate, "Only letters, numbers, and dashes are allowed. No spaces.")
        End If

        If make.Text = "" Then 'make
            gtg = False
            ErrorProvider1.SetError(make, "Please fill out this field")
        End If

        If model.Text = "" Then 'model
            gtg = False
            ErrorProvider1.SetError(model, "Please fill out this field")
        End If

        If color.Text = "" Then 'color
            gtg = False
            ErrorProvider1.SetError(color, "Please fill out this field")
        End If

        If typecombobox.Text = "" Then 'type
            gtg = False
            ErrorProvider1.SetError(typecombobox, "Please fill out this field")
        End If

        If gtg Then
            VehiclesTableAdapter.InsertVehicle(make.Text, model.Text, color.Text, Plate.Text, typecombobox.Text)
            MsgBox("Successfully Checked in visitor!")
            clear(Me)
        End If
    End Sub


End Class
