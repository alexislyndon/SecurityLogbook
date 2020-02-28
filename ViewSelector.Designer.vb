<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSelector
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
        Me.mainbtn = New System.Windows.Forms.Button()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.adminbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'mainbtn
        '
        Me.mainbtn.Location = New System.Drawing.Point(117, 67)
        Me.mainbtn.Name = "mainbtn"
        Me.mainbtn.Size = New System.Drawing.Size(75, 23)
        Me.mainbtn.TabIndex = 1
        Me.mainbtn.Text = "Main"
        Me.mainbtn.UseVisualStyleBackColor = True
        '
        'backbtn
        '
        Me.backbtn.Location = New System.Drawing.Point(117, 115)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(75, 23)
        Me.backbtn.TabIndex = 2
        Me.backbtn.Text = "Back"
        Me.backbtn.UseVisualStyleBackColor = True
        '
        'adminbtn
        '
        Me.adminbtn.Location = New System.Drawing.Point(117, 156)
        Me.adminbtn.Name = "adminbtn"
        Me.adminbtn.Size = New System.Drawing.Size(75, 23)
        Me.adminbtn.TabIndex = 3
        Me.adminbtn.Text = "Admin"
        Me.adminbtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Development Purposes Only"
        '
        'ViewSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 267)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.adminbtn)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.mainbtn)
        Me.Name = "ViewSelector"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mainbtn As Button
    Friend WithEvents backbtn As Button
    Friend WithEvents adminbtn As Button
    Friend WithEvents Label1 As Label
End Class
