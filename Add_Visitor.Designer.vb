<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Add_Visitor
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DestinationLabel As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Phone_NumberLabel As System.Windows.Forms.Label
        Dim Middle_NameLabel As System.Windows.Forms.Label
        Dim First_NameLabel As System.Windows.Forms.Label
        Dim Last_NameLabel As System.Windows.Forms.Label
        Dim Visitor_IDLabel As System.Windows.Forms.Label
        Dim sex As System.Windows.Forms.Label
        Dim lbl_surrendered As System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.destinationbox = New System.Windows.Forms.ComboBox()
        Me.AddNew = New System.Windows.Forms.Button()
        Me.purposebox = New System.Windows.Forms.TextBox()
        Me.Phone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Middle_NameTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.CheckIn = New System.Windows.Forms.Button()
        Me.idbadge = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.capportraitbtn = New System.Windows.Forms.Button()
        Me.capidbtn = New System.Windows.Forms.Button()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.DB1DataSet = New Security_Logbook.DB1DataSet()
        Me.VisitorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VisitorsTableAdapter = New Security_Logbook.DB1DataSetTableAdapters.VisitorsTableAdapter()
        Me.TableAdapterManager = New Security_Logbook.DB1DataSetTableAdapters.TableAdapterManager()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        DestinationLabel = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        Middle_NameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        Visitor_IDLabel = New System.Windows.Forms.Label()
        sex = New System.Windows.Forms.Label()
        lbl_surrendered = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.DB1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisitorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DestinationLabel
        '
        DestinationLabel.AutoSize = True
        DestinationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DestinationLabel.Location = New System.Drawing.Point(21, 257)
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
        Label9.Location = New System.Drawing.Point(21, 299)
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
        Phone_NumberLabel.Location = New System.Drawing.Point(160, 173)
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
        Middle_NameLabel.Location = New System.Drawing.Point(485, 110)
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
        First_NameLabel.Location = New System.Drawing.Point(246, 110)
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
        Last_NameLabel.Location = New System.Drawing.Point(21, 110)
        Last_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(90, 20)
        Last_NameLabel.TabIndex = 29
        Last_NameLabel.Text = "Last Name:"
        '
        'Visitor_IDLabel
        '
        Visitor_IDLabel.AutoSize = True
        Visitor_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Visitor_IDLabel.Location = New System.Drawing.Point(718, 156)
        Visitor_IDLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Visitor_IDLabel.Name = "Visitor_IDLabel"
        Visitor_IDLabel.Size = New System.Drawing.Size(129, 20)
        Visitor_IDLabel.TabIndex = 28
        Visitor_IDLabel.Text = "Visitor ID Badge:"
        '
        'sex
        '
        sex.AutoSize = True
        sex.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        sex.Location = New System.Drawing.Point(21, 170)
        sex.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        sex.Name = "sex"
        sex.Size = New System.Drawing.Size(36, 20)
        sex.TabIndex = 29
        sex.Text = "Sex"
        '
        'lbl_surrendered
        '
        lbl_surrendered.AutoSize = True
        lbl_surrendered.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl_surrendered.Location = New System.Drawing.Point(722, 278)
        lbl_surrendered.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        lbl_surrendered.Name = "lbl_surrendered"
        lbl_surrendered.Size = New System.Drawing.Size(110, 20)
        lbl_surrendered.TabIndex = 29
        lbl_surrendered.Text = "ID Surrendred"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(-4, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1109, 77)
        Me.Panel2.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(18, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(153, 37)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Add Visitor"
        '
        'destinationbox
        '
        Me.destinationbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.destinationbox.FormattingEnabled = True
        Me.destinationbox.Items.AddRange(New Object() {"Finance", "Registrar", "College of Computer Studies", "Office of the President", "Admissions", "Magis", "OSA", "SEC Mall", "Security Office"})
        Me.destinationbox.Location = New System.Drawing.Point(131, 253)
        Me.destinationbox.Name = "destinationbox"
        Me.destinationbox.Size = New System.Drawing.Size(459, 41)
        Me.destinationbox.TabIndex = 42
        '
        'AddNew
        '
        Me.AddNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddNew.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNew.ForeColor = System.Drawing.Color.White
        Me.AddNew.Location = New System.Drawing.Point(37, 662)
        Me.AddNew.Name = "AddNew"
        Me.AddNew.Size = New System.Drawing.Size(168, 54)
        Me.AddNew.TabIndex = 41
        Me.AddNew.Text = "Clear"
        Me.AddNew.UseVisualStyleBackColor = False
        '
        'purposebox
        '
        Me.purposebox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purposebox.Location = New System.Drawing.Point(131, 299)
        Me.purposebox.Margin = New System.Windows.Forms.Padding(2)
        Me.purposebox.Multiline = True
        Me.purposebox.Name = "purposebox"
        Me.purposebox.Size = New System.Drawing.Size(459, 45)
        Me.purposebox.TabIndex = 38
        '
        'Phone_NumberTextBox
        '
        Me.Phone_NumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone_NumberTextBox.Location = New System.Drawing.Point(164, 195)
        Me.Phone_NumberTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Phone_NumberTextBox.Name = "Phone_NumberTextBox"
        Me.Phone_NumberTextBox.Size = New System.Drawing.Size(184, 26)
        Me.Phone_NumberTextBox.TabIndex = 39
        '
        'Middle_NameTextBox
        '
        Me.Middle_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Middle_NameTextBox.Location = New System.Drawing.Point(489, 132)
        Me.Middle_NameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Middle_NameTextBox.Name = "Middle_NameTextBox"
        Me.Middle_NameTextBox.Size = New System.Drawing.Size(203, 26)
        Me.Middle_NameTextBox.TabIndex = 3
        Me.Middle_NameTextBox.Text = "Guiannnnnnnnnnnnnnnn"
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(250, 132)
        Me.First_NameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(216, 26)
        Me.First_NameTextBox.TabIndex = 2
        Me.First_NameTextBox.Text = "Alexissssssssssssssssssss"
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(27, 132)
        Me.Last_NameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(198, 26)
        Me.Last_NameTextBox.TabIndex = 1
        Me.Last_NameTextBox.Text = "Galauraaaaaaaaaaaaaa"
        '
        'CheckIn
        '
        Me.CheckIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.CheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckIn.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIn.ForeColor = System.Drawing.Color.White
        Me.CheckIn.Location = New System.Drawing.Point(925, 685)
        Me.CheckIn.Name = "CheckIn"
        Me.CheckIn.Size = New System.Drawing.Size(168, 54)
        Me.CheckIn.TabIndex = 27
        Me.CheckIn.Text = "Check In"
        Me.CheckIn.UseVisualStyleBackColor = False
        '
        'idbadge
        '
        Me.idbadge.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idbadge.FormattingEnabled = True
        Me.idbadge.Items.AddRange(New Object() {"A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5"})
        Me.idbadge.Location = New System.Drawing.Point(775, 179)
        Me.idbadge.Name = "idbadge"
        Me.idbadge.Size = New System.Drawing.Size(72, 32)
        Me.idbadge.TabIndex = 49
        '
        'ComboBox2
        '
        Me.ComboBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Male", "Female", "Other/Unspecified"})
        Me.ComboBox2.Location = New System.Drawing.Point(25, 193)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(94, 28)
        Me.ComboBox2.TabIndex = 50
        '
        'capportraitbtn
        '
        Me.capportraitbtn.Location = New System.Drawing.Point(741, 217)
        Me.capportraitbtn.Name = "capportraitbtn"
        Me.capportraitbtn.Size = New System.Drawing.Size(105, 23)
        Me.capportraitbtn.TabIndex = 52
        Me.capportraitbtn.Text = "Capture Portrait"
        Me.capportraitbtn.UseVisualStyleBackColor = True
        '
        'capidbtn
        '
        Me.capidbtn.Location = New System.Drawing.Point(757, 246)
        Me.capidbtn.Name = "capidbtn"
        Me.capidbtn.Size = New System.Drawing.Size(90, 31)
        Me.capidbtn.TabIndex = 53
        Me.capidbtn.Text = "CaptureID"
        Me.capidbtn.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"Driver's License", "School ID", "UMID", "Company ID", "Voter's ID", "Postal ID"})
        Me.ComboBox3.Location = New System.Drawing.Point(726, 304)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 54
        '
        'DB1DataSet
        '
        Me.DB1DataSet.DataSetName = "DB1DataSet"
        Me.DB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VisitorsBindingSource
        '
        Me.VisitorsBindingSource.DataMember = "Visitors"
        Me.VisitorsBindingSource.DataSource = Me.DB1DataSet
        '
        'VisitorsTableAdapter
        '
        Me.VisitorsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Security_Logbook.DB1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        Me.TableAdapterManager.VisitorsTableAdapter = Me.VisitorsTableAdapter
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Security_Logbook.My.Resources.Resources.blankid
        Me.PictureBox2.Location = New System.Drawing.Point(756, 335)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(337, 212)
        Me.PictureBox2.TabIndex = 51
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Security_Logbook.My.Resources.Resources.portrait
        Me.PictureBox1.InitialImage = Global.Security_Logbook.My.Resources.Resources.portrait
        Me.PictureBox1.Location = New System.Drawing.Point(853, 89)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(240, 240)
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'Add_Visitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.capidbtn)
        Me.Controls.Add(Me.capportraitbtn)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.idbadge)
        Me.Controls.Add(Me.destinationbox)
        Me.Controls.Add(Me.AddNew)
        Me.Controls.Add(DestinationLabel)
        Me.Controls.Add(Label9)
        Me.Controls.Add(Phone_NumberLabel)
        Me.Controls.Add(Me.purposebox)
        Me.Controls.Add(Me.Phone_NumberTextBox)
        Me.Controls.Add(Middle_NameLabel)
        Me.Controls.Add(Me.Middle_NameTextBox)
        Me.Controls.Add(First_NameLabel)
        Me.Controls.Add(Me.First_NameTextBox)
        Me.Controls.Add(lbl_surrendered)
        Me.Controls.Add(sex)
        Me.Controls.Add(Last_NameLabel)
        Me.Controls.Add(Me.Last_NameTextBox)
        Me.Controls.Add(Visitor_IDLabel)
        Me.Controls.Add(Me.CheckIn)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Add_Visitor"
        Me.Size = New System.Drawing.Size(1109, 763)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DB1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisitorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents destinationbox As ComboBox
    Friend WithEvents AddNew As Button
    Friend WithEvents purposebox As TextBox
    Friend WithEvents Phone_NumberTextBox As TextBox
    Friend WithEvents Middle_NameTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents CheckIn As Button
    Friend WithEvents DB1DataSet As DB1DataSet
    Friend WithEvents VisitorsBindingSource As BindingSource
    Friend WithEvents VisitorsTableAdapter As DB1DataSetTableAdapters.VisitorsTableAdapter
    Friend WithEvents TableAdapterManager As DB1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents idbadge As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents capportraitbtn As Button
    Friend WithEvents capidbtn As Button
    Friend WithEvents ComboBox3 As ComboBox
End Class
