Public Class PopView
    Public visitID As Integer

    Public Sub New(visitID As Integer)
        Me.visitID = visitID
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DB1DataSet1.Visitors' table. You can move, or remove it, as needed.

        Me.VisitorsTableAdapter.Fill(Me.DB1DataSet1.Visitors)
        'Me.VisitorsTableAdapter.View(visitID)
    End Sub


End Class