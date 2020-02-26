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
        Me.Middle_NameLabel = New System.Windows.Forms.Label()
        Me.First_NameLabel = New System.Windows.Forms.Label()
        Me.Last_NameLabel = New System.Windows.Forms.Label()
        Me.Visitor_IDLabel = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.make = New System.Windows.Forms.ComboBox()
        Me.AddNew = New System.Windows.Forms.Button()
        Me.color = New System.Windows.Forms.TextBox()
        Me.model = New System.Windows.Forms.TextBox()
        Me.Plate = New System.Windows.Forms.TextBox()
        Me.CheckIn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.typecombobox = New System.Windows.Forms.ComboBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.VehiclesTableAdapter = New Security_Logbook.DB1DataSetTableAdapters.VehiclesTableAdapter()
        Me.Panel2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Middle_NameLabel
        '
        Me.Middle_NameLabel.AutoSize = True
        Me.Middle_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Middle_NameLabel.Location = New System.Drawing.Point(208, 410)
        Me.Middle_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Middle_NameLabel.Name = "Middle_NameLabel"
        Me.Middle_NameLabel.Size = New System.Drawing.Size(50, 20)
        Me.Middle_NameLabel.TabIndex = 47
        Me.Middle_NameLabel.Text = "Color:"
        '
        'First_NameLabel
        '
        Me.First_NameLabel.AutoSize = True
        Me.First_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameLabel.Location = New System.Drawing.Point(208, 358)
        Me.First_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.First_NameLabel.Name = "First_NameLabel"
        Me.First_NameLabel.Size = New System.Drawing.Size(91, 20)
        Me.First_NameLabel.TabIndex = 46
        Me.First_NameLabel.Text = "Model-Year"
        '
        'Last_NameLabel
        '
        Me.Last_NameLabel.AutoSize = True
        Me.Last_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_NameLabel.Location = New System.Drawing.Point(208, 307)
        Me.Last_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Last_NameLabel.Name = "Last_NameLabel"
        Me.Last_NameLabel.Size = New System.Drawing.Size(52, 20)
        Me.Last_NameLabel.TabIndex = 44
        Me.Last_NameLabel.Text = "Make:"
        '
        'Visitor_IDLabel
        '
        Me.Visitor_IDLabel.AutoSize = True
        Me.Visitor_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Visitor_IDLabel.Location = New System.Drawing.Point(208, 250)
        Me.Visitor_IDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Visitor_IDLabel.Name = "Visitor_IDLabel"
        Me.Visitor_IDLabel.Size = New System.Drawing.Size(109, 20)
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
        'make
        '
        Me.make.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.make.FormattingEnabled = True
        Me.make.Items.AddRange(New Object() {"Toyota", "Mitsubishi", "Nissan", "Hyundai", "Suzuki", "Ford", "Honda", "Isuzu", "MG", "Kia"})
        Me.make.Location = New System.Drawing.Point(368, 305)
        Me.make.Name = "make"
        Me.make.Size = New System.Drawing.Size(166, 41)
        Me.make.TabIndex = 2
        '
        'AddNew
        '
        Me.AddNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddNew.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNew.ForeColor = System.Drawing.Color.White
        Me.AddNew.Location = New System.Drawing.Point(408, 597)
        Me.AddNew.Name = "AddNew"
        Me.AddNew.Size = New System.Drawing.Size(168, 54)
        Me.AddNew.TabIndex = 50
        Me.AddNew.Text = "Clear"
        Me.AddNew.UseVisualStyleBackColor = False
        '
        'color
        '
        Me.color.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.color.Location = New System.Drawing.Point(368, 408)
        Me.color.Margin = New System.Windows.Forms.Padding(2)
        Me.color.Multiline = True
        Me.color.Name = "color"
        Me.color.Size = New System.Drawing.Size(459, 45)
        Me.color.TabIndex = 4
        '
        'model
        '
        Me.model.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.model.Location = New System.Drawing.Point(368, 356)
        Me.model.Margin = New System.Windows.Forms.Padding(2)
        Me.model.Multiline = True
        Me.model.Name = "model"
        Me.model.Size = New System.Drawing.Size(459, 45)
        Me.model.TabIndex = 3
        '
        'Plate
        '
        Me.Plate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Plate.Location = New System.Drawing.Point(368, 246)
        Me.Plate.Margin = New System.Windows.Forms.Padding(2)
        Me.Plate.Multiline = True
        Me.Plate.Name = "Plate"
        Me.Plate.Size = New System.Drawing.Size(154, 45)
        Me.Plate.TabIndex = 1
        '
        'CheckIn
        '
        Me.CheckIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.CheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckIn.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIn.ForeColor = System.Drawing.Color.White
        Me.CheckIn.Location = New System.Drawing.Point(605, 597)
        Me.CheckIn.Name = "CheckIn"
        Me.CheckIn.Size = New System.Drawing.Size(168, 54)
        Me.CheckIn.TabIndex = 6
        Me.CheckIn.Text = "Check in"
        Me.CheckIn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(208, 472)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 20)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Type:"
        '
        'typecombobox
        '
        Me.typecombobox.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typecombobox.FormattingEnabled = True
        Me.typecombobox.Items.AddRange(New Object() {"Private 4-Wheeler", "Private 3-Wheeler", "Private Motorcycle", "PUJeep", "PUVehicle", "Delivery MC", "Delivery Vehicle", "Truck", "Emergency Vehicle", "Helicopter"})
        Me.typecombobox.Location = New System.Drawing.Point(368, 472)
        Me.typecombobox.Name = "typecombobox"
        Me.typecombobox.Size = New System.Drawing.Size(262, 41)
        Me.typecombobox.TabIndex = 5
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'VehiclesTableAdapter
        '
        Me.VehiclesTableAdapter.ClearBeforeFill = True
        '
        'Add_Vehicle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.typecombobox)
        Me.Controls.Add(Me.make)
        Me.Controls.Add(Me.AddNew)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Middle_NameLabel)
        Me.Controls.Add(Me.color)
        Me.Controls.Add(Me.First_NameLabel)
        Me.Controls.Add(Me.model)
        Me.Controls.Add(Me.Last_NameLabel)
        Me.Controls.Add(Me.Visitor_IDLabel)
        Me.Controls.Add(Me.Plate)
        Me.Controls.Add(Me.CheckIn)
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
    Friend WithEvents make As ComboBox
    Friend WithEvents AddNew As Button
    Friend WithEvents color As TextBox
    Friend WithEvents model As TextBox
    Friend WithEvents Plate As TextBox
    Friend WithEvents CheckIn As Button
    Friend WithEvents Middle_NameLabel As Label
    Friend WithEvents First_NameLabel As Label
    Friend WithEvents Last_NameLabel As Label
    Friend WithEvents Visitor_IDLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents typecombobox As ComboBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents VehiclesTableAdapter As DB1DataSetTableAdapters.VehiclesTableAdapter
End Class
