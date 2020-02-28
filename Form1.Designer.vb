<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.view_checkin_btn = New System.Windows.Forms.Button()
        Me.Add_visitor_btn = New System.Windows.Forms.Button()
        Me.Adduser1 = New Security_Logbook.adduser()
        Me.VisitorsTableAdapter1 = New Security_Logbook.DB1DataSetTableAdapters.VisitorsTableAdapter()
        Me.DB1DataSet1 = New Security_Logbook.DB1DataSet()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.UserControl11 = New Security_Logbook.UserControl1()
        Me.Panel1.SuspendLayout()
        CType(Me.DB1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(34, Byte), Integer), CType(CType(36, Byte), Integer), CType(CType(49, Byte), Integer))
        Me.Panel1.Controls.Add(Me.LogOutBtn)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.view_checkin_btn)
        Me.Panel1.Controls.Add(Me.Add_visitor_btn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(252, 768)
        Me.Panel1.TabIndex = 6
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
        Me.Add_visitor_btn.Text = "Add User"
        Me.Add_visitor_btn.UseVisualStyleBackColor = False
        '
        'Adduser1
        '
        Me.Adduser1.Location = New System.Drawing.Point(254, -1)
        Me.Adduser1.Name = "Adduser1"
        Me.Adduser1.Size = New System.Drawing.Size(1360, 750)
        Me.Adduser1.TabIndex = 7
        '
        'VisitorsTableAdapter1
        '
        Me.VisitorsTableAdapter1.ClearBeforeFill = True
        '
        'DB1DataSet1
        '
        Me.DB1DataSet1.DataSetName = "DB1DataSet"
        Me.DB1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'UserControl11
        '
        Me.UserControl11.Location = New System.Drawing.Point(666, 399)
        Me.UserControl11.Name = "UserControl11"
        Me.UserControl11.Size = New System.Drawing.Size(1129, 763)
        Me.UserControl11.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.UserControl11)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Adduser1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DB1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents LogOutBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents view_checkin_btn As Button
    Friend WithEvents Add_visitor_btn As Button
    Friend WithEvents Adduser1 As adduser
    Friend WithEvents VisitorsTableAdapter1 As DB1DataSetTableAdapters.VisitorsTableAdapter
    Friend WithEvents DB1DataSet1 As DB1DataSet
    Friend WithEvents Timer1 As Timer
    Friend WithEvents UserControl11 As UserControl1
End Class
