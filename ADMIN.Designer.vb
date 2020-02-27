<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ADMIN
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LogOutBtn = New System.Windows.Forms.Button()
        Me.view_checkedin_btn = New System.Windows.Forms.Button()
        Me.view_visitors_btn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Add_User = New System.Windows.Forms.Button()
        Me.View_Vehicles1 = New Security_Logbook.view_Vehicles()
        Me.View_visitors1 = New Security_Logbook.view_visitors()
        Me.Register1 = New Security_Logbook.REGISTER()
        Me.View_visitors2 = New Security_Logbook.view_visitors()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel1.Controls.Add(Me.View_visitors1)
        Me.Panel1.Controls.Add(Me.LogOutBtn)
        Me.Panel1.Controls.Add(Me.view_checkedin_btn)
        Me.Panel1.Controls.Add(Me.view_visitors_btn)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Add_User)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(252, 768)
        Me.Panel1.TabIndex = 5
        '
        'LogOutBtn
        '
        Me.LogOutBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.LogOutBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LogOutBtn.ForeColor = System.Drawing.Color.White
        Me.LogOutBtn.Location = New System.Drawing.Point(0, 709)
        Me.LogOutBtn.Name = "LogOutBtn"
        Me.LogOutBtn.Size = New System.Drawing.Size(252, 50)
        Me.LogOutBtn.TabIndex = 18
        Me.LogOutBtn.Text = "Log out"
        Me.LogOutBtn.UseVisualStyleBackColor = False
        '
        'view_checkedin_btn
        '
        Me.view_checkedin_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.view_checkedin_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.view_checkedin_btn.ForeColor = System.Drawing.Color.White
        Me.view_checkedin_btn.Location = New System.Drawing.Point(0, 256)
        Me.view_checkedin_btn.Name = "view_checkedin_btn"
        Me.view_checkedin_btn.Size = New System.Drawing.Size(252, 50)
        Me.view_checkedin_btn.TabIndex = 17
        Me.view_checkedin_btn.Text = "View Vehicles"
        Me.view_checkedin_btn.UseVisualStyleBackColor = False
        '
        'view_visitors_btn
        '
        Me.view_visitors_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.view_visitors_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.view_visitors_btn.ForeColor = System.Drawing.Color.White
        Me.view_visitors_btn.Location = New System.Drawing.Point(0, 208)
        Me.view_visitors_btn.Name = "view_visitors_btn"
        Me.view_visitors_btn.Size = New System.Drawing.Size(252, 50)
        Me.view_visitors_btn.TabIndex = 16
        Me.view_visitors_btn.Text = "View Visitors"
        Me.view_visitors_btn.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 31.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label3.Location = New System.Drawing.Point(21, 100)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 51)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "06:30:00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 3)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 31)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Date"
        '
        'Add_User
        '
        Me.Add_User.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Add_User.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_User.ForeColor = System.Drawing.Color.White
        Me.Add_User.Location = New System.Drawing.Point(0, 154)
        Me.Add_User.Name = "Add_User"
        Me.Add_User.Size = New System.Drawing.Size(252, 57)
        Me.Add_User.TabIndex = 7
        Me.Add_User.Text = "Add User"
        Me.Add_User.UseVisualStyleBackColor = False
        '
        'View_Vehicles1
        '
        Me.View_Vehicles1.Location = New System.Drawing.Point(250, 5)
        Me.View_Vehicles1.Name = "View_Vehicles1"
        Me.View_Vehicles1.Size = New System.Drawing.Size(1117, 763)
        Me.View_Vehicles1.TabIndex = 21
        '
        'View_visitors1
        '
        Me.View_visitors1.Location = New System.Drawing.Point(250, -4)
        Me.View_visitors1.Name = "View_visitors1"
        Me.View_visitors1.Size = New System.Drawing.Size(1117, 763)
        Me.View_visitors1.TabIndex = 19
        '
        'Register1
        '
        Me.Register1.Location = New System.Drawing.Point(250, -4)
        Me.Register1.Name = "Register1"
        Me.Register1.Size = New System.Drawing.Size(1117, 772)
        Me.Register1.TabIndex = 6
        '
        'View_visitors2
        '
        Me.View_visitors2.Location = New System.Drawing.Point(252, -2)
        Me.View_visitors2.Name = "View_visitors2"
        Me.View_visitors2.Size = New System.Drawing.Size(1149, 763)
        Me.View_visitors2.TabIndex = 20
        '
        'Timer1
        '
        '
        'ADMIN
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.View_Vehicles1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Register1)
        Me.Controls.Add(Me.View_visitors2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(249, -1)
        Me.Name = "ADMIN"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LogOutBtn As Button
    Friend WithEvents view_checkedin_btn As Button
    Friend WithEvents view_visitors_btn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Add_User As Button
    Friend WithEvents Register1 As REGISTER
    Friend WithEvents View_visitors1 As view_visitors
    Friend WithEvents View_visitors2 As view_visitors
    Friend WithEvents View_Vehicles1 As view_Vehicles
    Friend WithEvents Timer1 As Timer
End Class
