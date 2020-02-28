Public Class PopView
    Public visitID As Integer

    Public Sub New(visitID As Integer)
        Me.visitID = visitID
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Visitor Info"
        'TODO: This line of code loads data into the 'DB1DataSet1.Visitors' table. You can move, or remove it, as needed.

        Me.VisitorsTableAdapter.View(Me.DB1DataSet1.Visitors, visitID)
        'MsgBox(DB1DataSet1.Tables(0).Rows(0).Item("firstname"))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim checkout As String
        checkout = MessageBox.Show("Are you sure you want to check out Visitor #" & visitID & vbCrLf &
                     DB1DataSet1.Tables(0).Rows(0).Item("FullName") & vbCrLf &
                     "with Badge Number: " & DB1DataSet1.Tables(0).Rows(0).Item("badge_number") & "?",
                     "Please Confirm Checkout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If checkout = vbYes Then
            Me.VisitorsTableAdapter.CHECKOUT(visitID)

            MessageBox.Show("Checkout Success." & vbCrLf,
               "Checkout Success.", MessageBoxButtons.OK, MessageBoxIcon.Information
               )
            refreshAll()
            Me.Dispose()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
End Class