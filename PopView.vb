Public Class PopView
    Public visitID As Integer
    Private DS1 As New DataSet
    Dim vciobj As View_Checked_in

    Public Sub New(visitID As Integer, vci As View_Checked_in)
        Me.visitID = visitID
        vciobj = vci
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: This line of code loads data into the 'DB1DataSet1.Visitors' table. You can move, or remove it, as needed.

        Me.VisitorsTableAdapter.View(Me.DB1DataSet1.Visitors, visitID)
        'MsgBox(DB1DataSet1.Tables(0).Rows(0).Item("firstname"))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim checkout As String
        Dim undo As String
        checkout = MessageBox.Show("Are you sure you want to check out Visitor #" & visitID & vbCrLf &
                     DB1DataSet1.Tables(0).Rows(0).Item("FullName") & vbCrLf &
                     "with Badge Number: " & DB1DataSet1.Tables(0).Rows(0).Item("badge_number") & "?",
                     "Confirm Checkout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If checkout = vbYes Then
            Me.VisitorsTableAdapter.CHECKOUT(visitID)

            MessageBox.Show("Checkout Success." & vbCrLf,
               "Checkout Success.", MessageBoxButtons.OK, MessageBoxIcon.Information
               )
            vciobj.refresher()
            Me.Dispose()
        End If
    End Sub
End Class