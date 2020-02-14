<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dash
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.vehicles_history_btn = New System.Windows.Forms.Button()
        Me.view_checkedin_btn = New System.Windows.Forms.Button()
        Me.add_vehicle_btn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.visitors_history_btn = New System.Windows.Forms.Button()
        Me.view_checkin_btn = New System.Windows.Forms.Button()
        Me.Add_visitor_btn = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Add_Visitor1 = New Security_Logbook.Add_Visitor()
        Me.Visitors_History1 = New Security_Logbook.Visitors_History()
        Me.View_Checked_in_Vehicles1 = New Security_Logbook.View_Checked_in_Vehicles()
        Me.View_Checked_in1 = New Security_Logbook.View_Checked_in()
        Me.Vehicles_History1 = New Security_Logbook.Vehicles_History()
        Me.Add_Vehicle1 = New Security_Logbook.Add_Vehicle()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dashboard"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(1337, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "X"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel1.Controls.Add(Me.vehicles_history_btn)
        Me.Panel1.Controls.Add(Me.view_checkedin_btn)
        Me.Panel1.Controls.Add(Me.add_vehicle_btn)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.visitors_history_btn)
        Me.Panel1.Controls.Add(Me.view_checkin_btn)
        Me.Panel1.Controls.Add(Me.Add_visitor_btn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(252, 762)
        Me.Panel1.TabIndex = 4
        '
        'vehicles_history_btn
        '
        Me.vehicles_history_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.vehicles_history_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.vehicles_history_btn.ForeColor = System.Drawing.Color.White
        Me.vehicles_history_btn.Location = New System.Drawing.Point(0, 408)
        Me.vehicles_history_btn.Name = "vehicles_history_btn"
        Me.vehicles_history_btn.Size = New System.Drawing.Size(252, 50)
        Me.vehicles_history_btn.TabIndex = 18
        Me.vehicles_history_btn.Text = "Vehicles History"
        Me.vehicles_history_btn.UseVisualStyleBackColor = False
        '
        'view_checkedin_btn
        '
        Me.view_checkedin_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.view_checkedin_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.view_checkedin_btn.ForeColor = System.Drawing.Color.White
        Me.view_checkedin_btn.Location = New System.Drawing.Point(0, 358)
        Me.view_checkedin_btn.Name = "view_checkedin_btn"
        Me.view_checkedin_btn.Size = New System.Drawing.Size(252, 50)
        Me.view_checkedin_btn.TabIndex = 17
        Me.view_checkedin_btn.Text = "View Checked in Vehicle"
        Me.view_checkedin_btn.UseVisualStyleBackColor = False
        '
        'add_vehicle_btn
        '
        Me.add_vehicle_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.add_vehicle_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.add_vehicle_btn.ForeColor = System.Drawing.Color.White
        Me.add_vehicle_btn.Location = New System.Drawing.Point(0, 309)
        Me.add_vehicle_btn.Name = "add_vehicle_btn"
        Me.add_vehicle_btn.Size = New System.Drawing.Size(252, 50)
        Me.add_vehicle_btn.TabIndex = 16
        Me.add_vehicle_btn.Text = "Add Vehicle"
        Me.add_vehicle_btn.UseVisualStyleBackColor = False
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
        'visitors_history_btn
        '
        Me.visitors_history_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.visitors_history_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.visitors_history_btn.ForeColor = System.Drawing.Color.White
        Me.visitors_history_btn.Location = New System.Drawing.Point(0, 260)
        Me.visitors_history_btn.Name = "visitors_history_btn"
        Me.visitors_history_btn.Size = New System.Drawing.Size(252, 50)
        Me.visitors_history_btn.TabIndex = 9
        Me.visitors_history_btn.Text = "History"
        Me.visitors_history_btn.UseVisualStyleBackColor = False
        '
        'view_checkin_btn
        '
        Me.view_checkin_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.view_checkin_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.view_checkin_btn.ForeColor = System.Drawing.Color.White
        Me.view_checkin_btn.Location = New System.Drawing.Point(0, 210)
        Me.view_checkin_btn.Name = "view_checkin_btn"
        Me.view_checkin_btn.Size = New System.Drawing.Size(252, 51)
        Me.view_checkin_btn.TabIndex = 8
        Me.view_checkin_btn.Text = "View Checked in"
        Me.view_checkin_btn.UseVisualStyleBackColor = False
        '
        'Add_visitor_btn
        '
        Me.Add_visitor_btn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Add_visitor_btn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Add_visitor_btn.ForeColor = System.Drawing.Color.White
        Me.Add_visitor_btn.Location = New System.Drawing.Point(0, 154)
        Me.Add_visitor_btn.Name = "Add_visitor_btn"
        Me.Add_visitor_btn.Size = New System.Drawing.Size(252, 57)
        Me.Add_visitor_btn.TabIndex = 7
        Me.Add_visitor_btn.Text = "Add Visitor"
        Me.Add_visitor_btn.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Add_Visitor1
        '
        Me.Add_Visitor1.Location = New System.Drawing.Point(252, 0)
        Me.Add_Visitor1.Name = "Add_Visitor1"
        Me.Add_Visitor1.Size = New System.Drawing.Size(1109, 763)
        Me.Add_Visitor1.TabIndex = 5
        '
        'Visitors_History1
        '
        Me.Visitors_History1.Location = New System.Drawing.Point(252, 0)
        Me.Visitors_History1.Name = "Visitors_History1"
        Me.Visitors_History1.Size = New System.Drawing.Size(1109, 763)
        Me.Visitors_History1.TabIndex = 10
        '
        'View_Checked_in_Vehicles1
        '
        Me.View_Checked_in_Vehicles1.Location = New System.Drawing.Point(252, 0)
        Me.View_Checked_in_Vehicles1.Name = "View_Checked_in_Vehicles1"
        Me.View_Checked_in_Vehicles1.Size = New System.Drawing.Size(1109, 763)
        Me.View_Checked_in_Vehicles1.TabIndex = 9
        '
        'View_Checked_in1
        '
        Me.View_Checked_in1.Location = New System.Drawing.Point(252, 0)
        Me.View_Checked_in1.Name = "View_Checked_in1"
        Me.View_Checked_in1.Size = New System.Drawing.Size(1109, 763)
        Me.View_Checked_in1.TabIndex = 8
        '
        'Vehicles_History1
        '
        Me.Vehicles_History1.Location = New System.Drawing.Point(252, 0)
        Me.Vehicles_History1.Name = "Vehicles_History1"
        Me.Vehicles_History1.Size = New System.Drawing.Size(1109, 763)
        Me.Vehicles_History1.TabIndex = 7
        '
        'Add_Vehicle1
        '
        Me.Add_Vehicle1.Location = New System.Drawing.Point(252, 0)
        Me.Add_Vehicle1.Name = "Add_Vehicle1"
        Me.Add_Vehicle1.Size = New System.Drawing.Size(1109, 763)
        Me.Add_Vehicle1.TabIndex = 6
        '
        'Dash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1360, 762)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Add_Visitor1)
        Me.Controls.Add(Me.Visitors_History1)
        Me.Controls.Add(Me.View_Checked_in_Vehicles1)
        Me.Controls.Add(Me.View_Checked_in1)
        Me.Controls.Add(Me.Vehicles_History1)
        Me.Controls.Add(Me.Add_Vehicle1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents vehicles_history_btn As Button
    Friend WithEvents view_checkedin_btn As Button
    Friend WithEvents add_vehicle_btn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents visitors_history_btn As Button
    Friend WithEvents view_checkin_btn As Button
    Friend WithEvents Add_visitor_btn As Button
    Friend WithEvents Add_Visitor1 As Add_Visitor
    Friend WithEvents Add_Vehicle1 As Add_Vehicle
    Friend WithEvents Vehicles_History1 As Vehicles_History
    Friend WithEvents View_Checked_in1 As View_Checked_in
    Friend WithEvents View_Checked_in_Vehicles1 As View_Checked_in_Vehicles
    Friend WithEvents Visitors_History1 As Visitors_History
    Friend WithEvents Timer1 As Timer
End Class
