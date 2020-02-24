<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class capturePortrait
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Start = New System.Windows.Forms.Button()
        Me.Capture = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(360, 360)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Start
        '
        Me.Start.Location = New System.Drawing.Point(378, 12)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(75, 23)
        Me.Start.TabIndex = 1
        Me.Start.Text = "Start"
        Me.Start.UseVisualStyleBackColor = True
        '
        'Capture
        '
        Me.Capture.Location = New System.Drawing.Point(378, 41)
        Me.Capture.Name = "Capture"
        Me.Capture.Size = New System.Drawing.Size(75, 23)
        Me.Capture.TabIndex = 2
        Me.Capture.Text = "Capture"
        Me.Capture.UseVisualStyleBackColor = True
        '
        'Save
        '
        Me.Save.Location = New System.Drawing.Point(378, 201)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(75, 23)
        Me.Save.TabIndex = 3
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'capturePortrait
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 382)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.Capture)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "capturePortrait"
        Me.Text = "Capture Portrait"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Start As Button
    Friend WithEvents Capture As Button
    Friend WithEvents Save As Button
    Friend WithEvents Timer1 As Timer
End Class
