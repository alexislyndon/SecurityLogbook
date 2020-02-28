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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Vehicle))
        Me.Middle_NameLabel = New System.Windows.Forms.Label()
        Me.First_NameLabel = New System.Windows.Forms.Label()
        Me.Last_NameLabel = New System.Windows.Forms.Label()
        Me.Visitor_IDLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.makeCbox = New System.Windows.Forms.ComboBox()
        Me.clearbtn = New System.Windows.Forms.Button()
        Me.colorbox = New System.Windows.Forms.TextBox()
        Me.modelbox = New System.Windows.Forms.TextBox()
        Me.platebox = New System.Windows.Forms.TextBox()
        Me.checkinbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.typeCbox = New System.Windows.Forms.ComboBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.VehiclesTableAdapter = New Security_Logbook.DB1DataSetTableAdapters.VehiclesTableAdapter()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Middle_NameLabel
        '
        Me.Middle_NameLabel.AutoSize = True
        Me.Middle_NameLabel.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Middle_NameLabel.Location = New System.Drawing.Point(208, 410)
        Me.Middle_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Middle_NameLabel.Name = "Middle_NameLabel"
        Me.Middle_NameLabel.Size = New System.Drawing.Size(65, 25)
        Me.Middle_NameLabel.TabIndex = 47
        Me.Middle_NameLabel.Text = "Color:"
        '
        'First_NameLabel
        '
        Me.First_NameLabel.AutoSize = True
        Me.First_NameLabel.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameLabel.Location = New System.Drawing.Point(208, 358)
        Me.First_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.First_NameLabel.Name = "First_NameLabel"
        Me.First_NameLabel.Size = New System.Drawing.Size(113, 25)
        Me.First_NameLabel.TabIndex = 46
        Me.First_NameLabel.Text = "Model-Year"
        '
        'Last_NameLabel
        '
        Me.Last_NameLabel.AutoSize = True
        Me.Last_NameLabel.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_NameLabel.Location = New System.Drawing.Point(208, 307)
        Me.Last_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Last_NameLabel.Name = "Last_NameLabel"
        Me.Last_NameLabel.Size = New System.Drawing.Size(63, 25)
        Me.Last_NameLabel.TabIndex = 44
        Me.Last_NameLabel.Text = "Make:"
        '
        'Visitor_IDLabel
        '
        Me.Visitor_IDLabel.AutoSize = True
        Me.Visitor_IDLabel.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Visitor_IDLabel.Location = New System.Drawing.Point(208, 250)
        Me.Visitor_IDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Visitor_IDLabel.Name = "Visitor_IDLabel"
        Me.Visitor_IDLabel.Size = New System.Drawing.Size(136, 25)
        Me.Visitor_IDLabel.TabIndex = 43
        Me.Visitor_IDLabel.Text = "Plate Number:"
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
        'makeCbox
        '
        Me.makeCbox.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.makeCbox.FormattingEnabled = True
        Me.makeCbox.Items.AddRange(New Object() {"Toyota", "Mitsubishi", "Nissan", "Hyundai", "Suzuki", "Ford", "Honda", "Isuzu", "MG", "Kia"})
        Me.makeCbox.Location = New System.Drawing.Point(368, 305)
        Me.makeCbox.Name = "makeCbox"
        Me.makeCbox.Size = New System.Drawing.Size(208, 34)
        Me.makeCbox.TabIndex = 2
        '
        'clearbtn
        '
        Me.clearbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.clearbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.clearbtn.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clearbtn.ForeColor = System.Drawing.Color.White
        Me.clearbtn.Location = New System.Drawing.Point(698, 680)
        Me.clearbtn.Name = "clearbtn"
        Me.clearbtn.Size = New System.Drawing.Size(168, 54)
        Me.clearbtn.TabIndex = 50
        Me.clearbtn.Text = "Clear"
        Me.clearbtn.UseVisualStyleBackColor = False
        '
        'colorbox
        '
        Me.colorbox.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.colorbox.Location = New System.Drawing.Point(368, 408)
        Me.colorbox.Margin = New System.Windows.Forms.Padding(2)
        Me.colorbox.Multiline = True
        Me.colorbox.Name = "colorbox"
        Me.colorbox.Size = New System.Drawing.Size(279, 45)
        Me.colorbox.TabIndex = 4
        '
        'modelbox
        '
        Me.modelbox.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modelbox.Location = New System.Drawing.Point(368, 356)
        Me.modelbox.Margin = New System.Windows.Forms.Padding(2)
        Me.modelbox.Multiline = True
        Me.modelbox.Name = "modelbox"
        Me.modelbox.Size = New System.Drawing.Size(279, 45)
        Me.modelbox.TabIndex = 3
        '
        'platebox
        '
        Me.platebox.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.platebox.Location = New System.Drawing.Point(368, 246)
        Me.platebox.Margin = New System.Windows.Forms.Padding(2)
        Me.platebox.Multiline = True
        Me.platebox.Name = "platebox"
        Me.platebox.Size = New System.Drawing.Size(154, 45)
        Me.platebox.TabIndex = 1
        '
        'checkinbtn
        '
        Me.checkinbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.checkinbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.checkinbtn.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkinbtn.ForeColor = System.Drawing.Color.White
        Me.checkinbtn.Location = New System.Drawing.Point(900, 680)
        Me.checkinbtn.Name = "checkinbtn"
        Me.checkinbtn.Size = New System.Drawing.Size(168, 54)
        Me.checkinbtn.TabIndex = 6
        Me.checkinbtn.Text = "Check in Vehicle"
        Me.checkinbtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(208, 472)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 25)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Type:"
        '
        'typeCbox
        '
        Me.typeCbox.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typeCbox.FormattingEnabled = True
        Me.typeCbox.Items.AddRange(New Object() {"Private 4-Wheeler", "Private 3-Wheeler", "Private Motorcycle", "PUJeep", "PUVehicle", "Delivery MC", "Delivery Vehicle", "Truck", "Emergency Vehicle", "Helicopter"})
        Me.typeCbox.Location = New System.Drawing.Point(368, 472)
        Me.typeCbox.Name = "typeCbox"
        Me.typeCbox.Size = New System.Drawing.Size(279, 34)
        Me.typeCbox.TabIndex = 5
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 50
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'VehiclesTableAdapter
        '
        Me.VehiclesTableAdapter.ClearBeforeFill = True
        '
        'Add_Vehicle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.typeCbox)
        Me.Controls.Add(Me.makeCbox)
        Me.Controls.Add(Me.clearbtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Middle_NameLabel)
        Me.Controls.Add(Me.colorbox)
        Me.Controls.Add(Me.First_NameLabel)
        Me.Controls.Add(Me.modelbox)
        Me.Controls.Add(Me.Last_NameLabel)
        Me.Controls.Add(Me.Visitor_IDLabel)
        Me.Controls.Add(Me.platebox)
        Me.Controls.Add(Me.checkinbtn)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Add_Vehicle"
        Me.Size = New System.Drawing.Size(1109, 763)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents makeCbox As ComboBox
    Friend WithEvents clearbtn As Button
    Friend WithEvents colorbox As TextBox
    Friend WithEvents modelbox As TextBox
    Friend WithEvents platebox As TextBox
    Friend WithEvents checkinbtn As Button
    Friend WithEvents Middle_NameLabel As Label
    Friend WithEvents First_NameLabel As Label
    Friend WithEvents Last_NameLabel As Label
    Friend WithEvents Visitor_IDLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents typeCbox As ComboBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents VehiclesTableAdapter As DB1DataSetTableAdapters.VehiclesTableAdapter
End Class
