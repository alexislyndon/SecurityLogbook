<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class captureID
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(captureID))
        Me.UnfreezeBtn = New System.Windows.Forms.Button()
        Me.FreezeBtn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.frontbtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.backbtn = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.save = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UnfreezeBtn
        '
        Me.UnfreezeBtn.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.UnfreezeBtn.Location = New System.Drawing.Point(63, 258)
        Me.UnfreezeBtn.Name = "UnfreezeBtn"
        Me.UnfreezeBtn.Size = New System.Drawing.Size(60, 23)
        Me.UnfreezeBtn.TabIndex = 1
        Me.UnfreezeBtn.Text = "Unfreeze"
        Me.UnfreezeBtn.UseVisualStyleBackColor = False
        '
        'FreezeBtn
        '
        Me.FreezeBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.FreezeBtn.Location = New System.Drawing.Point(10, 258)
        Me.FreezeBtn.Name = "FreezeBtn"
        Me.FreezeBtn.Size = New System.Drawing.Size(47, 23)
        Me.FreezeBtn.TabIndex = 2
        Me.FreezeBtn.Text = "Freeze"
        Me.FreezeBtn.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "datetime"
        '
        'frontbtn
        '
        Me.frontbtn.BackColor = System.Drawing.SystemColors.Control
        Me.frontbtn.Location = New System.Drawing.Point(161, 258)
        Me.frontbtn.Name = "frontbtn"
        Me.frontbtn.Size = New System.Drawing.Size(75, 23)
        Me.frontbtn.TabIndex = 4
        Me.frontbtn.Text = "Frontside"
        Me.frontbtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(12, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 240)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'backbtn
        '
        Me.backbtn.BackColor = System.Drawing.SystemColors.Control
        Me.backbtn.Location = New System.Drawing.Point(257, 258)
        Me.backbtn.Name = "backbtn"
        Me.backbtn.Size = New System.Drawing.Size(75, 23)
        Me.backbtn.TabIndex = 4
        Me.backbtn.Text = "Backside"
        Me.backbtn.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.InitialImage = Global.Security_Logbook.My.Resources.Resources.blankid
        Me.PictureBox2.Location = New System.Drawing.Point(363, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(160, 120)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.InitialImage = CType(resources.GetObject("PictureBox3.InitialImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(363, 132)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(160, 120)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'save
        '
        Me.save.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.save.ForeColor = System.Drawing.Color.White
        Me.save.Location = New System.Drawing.Point(418, 258)
        Me.save.Name = "save"
        Me.save.Size = New System.Drawing.Size(104, 34)
        Me.save.TabIndex = 4
        Me.save.Text = "Save and Close"
        Me.save.UseVisualStyleBackColor = False
        '
        'captureID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 296)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.save)
        Me.Controls.Add(Me.backbtn)
        Me.Controls.Add(Me.frontbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FreezeBtn)
        Me.Controls.Add(Me.UnfreezeBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "captureID"
        Me.Text = "Take a photo of the ID Card"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UnfreezeBtn As Button
    Friend WithEvents FreezeBtn As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents frontbtn As Button
    Friend WithEvents backbtn As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents save As Button
End Class
