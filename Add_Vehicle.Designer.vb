<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Vehicle
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim Middle_NameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim Visitor_IDLabel As System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.make = New System.Windows.Forms.ComboBox()
        Me.AddNew = New System.Windows.Forms.Button()
        Me.color = New System.Windows.Forms.TextBox()
        Me.model = New System.Windows.Forms.TextBox()
        Me.Plate = New System.Windows.Forms.TextBox()
        Me.CheckIn = New System.Windows.Forms.Button()
        Middle_NameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        Visitor_IDLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1109, 156)
        Me.Panel2.TabIndex = 14
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(20, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 37)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Add Vehicle"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label2.Location = New System.Drawing.Point(282, 507)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 24)
        Me.Label2.TabIndex = 52
        '
        'make
        '
        Me.make.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.make.FormattingEnabled = True
        Me.make.Items.AddRange(New Object() {"Toyota", "Mitsubishi", "Honda", "Isuzu", "Hyundai", "Kia"})
        Me.make.Location = New System.Drawing.Point(368, 305)
        Me.make.Name = "make"
        Me.make.Size = New System.Drawing.Size(459, 41)
        Me.make.TabIndex = 51
        '
        'AddNew
        '
        Me.AddNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddNew.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNew.ForeColor = System.Drawing.Color.White
        Me.AddNew.Location = New System.Drawing.Point(428, 473)
        Me.AddNew.Name = "AddNew"
        Me.AddNew.Size = New System.Drawing.Size(168, 54)
        Me.AddNew.TabIndex = 50
        Me.AddNew.Text = "Clear"
        Me.AddNew.UseVisualStyleBackColor = False
        '
        'Middle_NameLabel
        '
        Middle_NameLabel.AutoSize = True
        Middle_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Middle_NameLabel.Location = New System.Drawing.Point(208, 410)
        Middle_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Middle_NameLabel.Name = "Middle_NameLabel"
        Middle_NameLabel.Size = New System.Drawing.Size(50, 20)
        Middle_NameLabel.TabIndex = 47
        Middle_NameLabel.Text = "Color:"
        '
        'color
        '
        Me.color.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.color.Location = New System.Drawing.Point(368, 408)
        Me.color.Margin = New System.Windows.Forms.Padding(2)
        Me.color.Multiline = True
        Me.color.Name = "color"
        Me.color.Size = New System.Drawing.Size(459, 45)
        Me.color.TabIndex = 49
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(208, 358)
        First_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(56, 20)
        First_NameLabel.TabIndex = 46
        First_NameLabel.Text = "Model:"
        '
        'model
        '
        Me.model.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.model.Location = New System.Drawing.Point(368, 356)
        Me.model.Margin = New System.Windows.Forms.Padding(2)
        Me.model.Multiline = True
        Me.model.Name = "model"
        Me.model.Size = New System.Drawing.Size(459, 45)
        Me.model.TabIndex = 48
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(208, 307)
        Last_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(52, 20)
        Last_NameLabel.TabIndex = 44
        Last_NameLabel.Text = "Make:"
        '
        'Visitor_IDLabel
        '
        Visitor_IDLabel.AutoSize = True
        Visitor_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Visitor_IDLabel.Location = New System.Drawing.Point(208, 250)
        Visitor_IDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Visitor_IDLabel.Name = "Visitor_IDLabel"
        Visitor_IDLabel.Size = New System.Drawing.Size(109, 20)
        Visitor_IDLabel.TabIndex = 43
        Visitor_IDLabel.Text = "Plate Number:"
        '
        'Plate
        '
        Me.Plate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Plate.Location = New System.Drawing.Point(368, 246)
        Me.Plate.Margin = New System.Windows.Forms.Padding(2)
        Me.Plate.Multiline = True
        Me.Plate.Name = "Plate"
        Me.Plate.Size = New System.Drawing.Size(459, 45)
        Me.Plate.TabIndex = 45
        '
        'CheckIn
        '
        Me.CheckIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.CheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckIn.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIn.ForeColor = System.Drawing.Color.White
        Me.CheckIn.Location = New System.Drawing.Point(625, 473)
        Me.CheckIn.Name = "CheckIn"
        Me.CheckIn.Size = New System.Drawing.Size(168, 54)
        Me.CheckIn.TabIndex = 42
        Me.CheckIn.Text = "Check in"
        Me.CheckIn.UseVisualStyleBackColor = False
        '
        'Add_Vehicle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.make)
        Me.Controls.Add(Me.AddNew)
        Me.Controls.Add(Middle_NameLabel)
        Me.Controls.Add(Me.color)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.model)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Visitor_IDLabel)
        Me.Controls.Add(Me.Plate)
        Me.Controls.Add(Me.CheckIn)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Add_Vehicle"
        Me.Size = New System.Drawing.Size(1109, 763)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents make As ComboBox
    Friend WithEvents AddNew As Button
    Friend WithEvents color As TextBox
    Friend WithEvents model As TextBox
    Friend WithEvents Plate As TextBox
    Friend WithEvents CheckIn As Button
End Class
