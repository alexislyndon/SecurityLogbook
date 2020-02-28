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
        Me.CapturePor = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(360, 240)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Start
        '
        Me.Start.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Start.Location = New System.Drawing.Point(70, 262)
        Me.Start.Name = "Start"
        Me.Start.Size = New System.Drawing.Size(61, 23)
        Me.Start.TabIndex = 1
        Me.Start.Text = "Unfreeze"
        Me.Start.UseVisualStyleBackColor = False
        '
        'CapturePor
        '
        Me.CapturePor.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CapturePor.Location = New System.Drawing.Point(12, 262)
        Me.CapturePor.Name = "CapturePor"
        Me.CapturePor.Size = New System.Drawing.Size(52, 23)
        Me.CapturePor.TabIndex = 2
        Me.CapturePor.Text = "Freeze"
        Me.CapturePor.UseVisualStyleBackColor = False
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Save.ForeColor = System.Drawing.Color.White
        Me.Save.Location = New System.Drawing.Point(297, 258)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(75, 30)
        Me.Save.TabIndex = 3
        Me.Save.Text = "Save"
        Me.Save.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        '
        'capturePortrait
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 291)
        Me.Controls.Add(Me.Save)
        Me.Controls.Add(Me.CapturePor)
        Me.Controls.Add(Me.Start)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "capturePortrait"
        Me.Text = "Capture Portrait"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Start As Button
    Friend WithEvents CapturePor As Button
    Friend WithEvents Save As Button
    Friend WithEvents Timer1 As Timer
End Class
