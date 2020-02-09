<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Add_Visitor
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
        Dim DestinationLabel As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim Middle_NameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim Visitor_IDLabel As System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.AddNew = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Phone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Middle_NameTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Visitor_IDTextBox = New System.Windows.Forms.TextBox()
        Me.CheckIn = New System.Windows.Forms.Button()
        DestinationLabel = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        Middle_NameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        Visitor_IDLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DestinationLabel
        '
        DestinationLabel.AutoSize = True
        DestinationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DestinationLabel.Location = New System.Drawing.Point(174, 466)
        DestinationLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        DestinationLabel.Name = "DestinationLabel"
        DestinationLabel.Size = New System.Drawing.Size(94, 20)
        DestinationLabel.TabIndex = 40
        DestinationLabel.Text = "Destination:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(174, 508)
        Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(68, 20)
        Label9.TabIndex = 37
        Label9.Text = "Purpose"
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phone_NumberLabel.Location = New System.Drawing.Point(174, 408)
        Phone_NumberLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(119, 20)
        Phone_NumberLabel.TabIndex = 36
        Phone_NumberLabel.Text = "Phone Number:"
        '
        'Middle_NameLabel
        '
        Middle_NameLabel.AutoSize = True
        Middle_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Middle_NameLabel.Location = New System.Drawing.Point(174, 357)
        Middle_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Middle_NameLabel.Name = "Middle_NameLabel"
        Middle_NameLabel.Size = New System.Drawing.Size(105, 20)
        Middle_NameLabel.TabIndex = 34
        Middle_NameLabel.Text = "Middle Name:"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(174, 306)
        First_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(90, 20)
        First_NameLabel.TabIndex = 32
        First_NameLabel.Text = "First Name:"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(174, 253)
        Last_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(90, 20)
        Last_NameLabel.TabIndex = 29
        Last_NameLabel.Text = "Last Name:"
        AddHandler Last_NameLabel.Click, AddressOf Me.Last_NameLabel_Click
        '
        'Visitor_IDLabel
        '
        Visitor_IDLabel.AutoSize = True
        Visitor_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Visitor_IDLabel.Location = New System.Drawing.Point(174, 197)
        Visitor_IDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Visitor_IDLabel.Name = "Visitor_IDLabel"
        Visitor_IDLabel.Size = New System.Drawing.Size(129, 20)
        Visitor_IDLabel.TabIndex = 28
        Visitor_IDLabel.Text = "Visitor ID Badge:"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1109, 156)
        Me.Panel2.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(20, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 37)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Add Visitor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(798, 466)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(798, 413)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "-"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(798, 357)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "-"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(798, 321)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 45
        Me.Label4.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(798, 265)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(10, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(798, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "-"
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Finance", "Registrar", "College of Computer Studies", "Office of the President", "Admissions", "Magis", "OSA", "SEC Mall", "Security Office"})
        Me.ComboBox1.Location = New System.Drawing.Point(334, 458)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(459, 41)
        Me.ComboBox1.TabIndex = 42
        '
        'AddNew
        '
        Me.AddNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddNew.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNew.ForeColor = System.Drawing.Color.White
        Me.AddNew.Location = New System.Drawing.Point(386, 584)
        Me.AddNew.Name = "AddNew"
        Me.AddNew.Size = New System.Drawing.Size(168, 54)
        Me.AddNew.TabIndex = 41
        Me.AddNew.Text = "Clear"
        Me.AddNew.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(334, 505)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(459, 45)
        Me.TextBox1.TabIndex = 38
        '
        'Phone_NumberTextBox
        '
        Me.Phone_NumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone_NumberTextBox.Location = New System.Drawing.Point(334, 405)
        Me.Phone_NumberTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Phone_NumberTextBox.Multiline = True
        Me.Phone_NumberTextBox.Name = "Phone_NumberTextBox"
        Me.Phone_NumberTextBox.Size = New System.Drawing.Size(459, 45)
        Me.Phone_NumberTextBox.TabIndex = 39
        '
        'Middle_NameTextBox
        '
        Me.Middle_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Middle_NameTextBox.Location = New System.Drawing.Point(334, 354)
        Me.Middle_NameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Middle_NameTextBox.Multiline = True
        Me.Middle_NameTextBox.Name = "Middle_NameTextBox"
        Me.Middle_NameTextBox.Size = New System.Drawing.Size(459, 45)
        Me.Middle_NameTextBox.TabIndex = 35
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(334, 303)
        Me.First_NameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.First_NameTextBox.Multiline = True
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(459, 45)
        Me.First_NameTextBox.TabIndex = 33
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(334, 250)
        Me.Last_NameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Last_NameTextBox.Multiline = True
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(459, 45)
        Me.Last_NameTextBox.TabIndex = 31
        '
        'Visitor_IDTextBox
        '
        Me.Visitor_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Visitor_IDTextBox.Location = New System.Drawing.Point(334, 194)
        Me.Visitor_IDTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Visitor_IDTextBox.Multiline = True
        Me.Visitor_IDTextBox.Name = "Visitor_IDTextBox"
        Me.Visitor_IDTextBox.Size = New System.Drawing.Size(459, 45)
        Me.Visitor_IDTextBox.TabIndex = 30
        '
        'CheckIn
        '
        Me.CheckIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.CheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckIn.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIn.ForeColor = System.Drawing.Color.White
        Me.CheckIn.Location = New System.Drawing.Point(599, 584)
        Me.CheckIn.Name = "CheckIn"
        Me.CheckIn.Size = New System.Drawing.Size(168, 54)
        Me.CheckIn.TabIndex = 27
        Me.CheckIn.Text = "Check in"
        Me.CheckIn.UseVisualStyleBackColor = False
        '
        'Add_Visitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.AddNew)
        Me.Controls.Add(DestinationLabel)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Phone_NumberLabel)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Phone_NumberTextBox)
        Me.Controls.Add(Middle_NameLabel)
        Me.Controls.Add(Me.Middle_NameTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(Visitor_IDLabel)
        Me.Controls.Add(Me.Visitor_IDTextBox)
        Me.Controls.Add(Me.CheckIn)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Add_Visitor"
        Me.Size = New System.Drawing.Size(1109, 763)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents AddNew As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Phone_NumberTextBox As TextBox
    Friend WithEvents Middle_NameTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents Visitor_IDTextBox As TextBox
    Friend WithEvents CheckIn As Button
End Class
