﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim sex As System.Windows.Forms.Label
        Dim lbl_surrendered As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim BadgeLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Add_Visitor))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.destinationcbox = New System.Windows.Forms.ComboBox()
        Me.AddNew = New System.Windows.Forms.Button()
        Me.purposebox = New System.Windows.Forms.TextBox()
        Me.Phone_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Middle_NameTextBox = New System.Windows.Forms.TextBox()
        Me.First_NameTextBox = New System.Windows.Forms.TextBox()
        Me.Last_NameTextBox = New System.Windows.Forms.TextBox()
        Me.CheckIn = New System.Windows.Forms.Button()
        Me.BadgesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB1DataSet = New Security_Logbook.DB1DataSet()
        Me.DB1DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB1DataSet1 = New Security_Logbook.DB1DataSet()
        Me.sexcbox = New System.Windows.Forms.ComboBox()
        Me.capportraitbtn = New System.Windows.Forms.Button()
        Me.capidbtn = New System.Windows.Forms.Button()
        Me.surrenderedcbox = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.v_id = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.VisitorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VisitorsTableAdapter = New Security_Logbook.DB1DataSetTableAdapters.VisitorsTableAdapter()
        Me.BadgesTableAdapter1 = New Security_Logbook.DB1DataSetTableAdapters.BadgesTableAdapter()
        Me.FKVehiclesBadgesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New Security_Logbook.DB1DataSetTableAdapters.TableAdapterManager()
        Me.DB1DataSet2 = New Security_Logbook.DB1DataSet()
        Me.BadgesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BadgeComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        DestinationLabel = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        Middle_NameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        sex = New System.Windows.Forms.Label()
        lbl_surrendered = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        BadgeLabel = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.BadgesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB1DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisitorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKVehiclesBadgesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB1DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BadgesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DestinationLabel
        '
        DestinationLabel.AutoSize = True
        DestinationLabel.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DestinationLabel.Location = New System.Drawing.Point(72, 366)
        DestinationLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        DestinationLabel.Name = "DestinationLabel"
        DestinationLabel.Size = New System.Drawing.Size(93, 21)
        DestinationLabel.TabIndex = 40
        DestinationLabel.Text = "Destination"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label9.Location = New System.Drawing.Point(94, 429)
        Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(70, 21)
        Label9.TabIndex = 37
        Label9.Text = "Purpose"
        '
        'Phone_NumberLabel
        '
        Phone_NumberLabel.AutoSize = True
        Phone_NumberLabel.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Phone_NumberLabel.Location = New System.Drawing.Point(25, 181)
        Phone_NumberLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(121, 21)
        Phone_NumberLabel.TabIndex = 36
        Phone_NumberLabel.Text = "Phone Number"
        '
        'Middle_NameLabel
        '
        Middle_NameLabel.AutoSize = True
        Middle_NameLabel.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Middle_NameLabel.Location = New System.Drawing.Point(523, 93)
        Middle_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Middle_NameLabel.Name = "Middle_NameLabel"
        Middle_NameLabel.Size = New System.Drawing.Size(110, 21)
        Middle_NameLabel.TabIndex = 34
        Middle_NameLabel.Text = "Middle Name"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(271, 93)
        First_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(89, 21)
        First_NameLabel.TabIndex = 32
        First_NameLabel.Text = "First Name"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(24, 93)
        Last_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(88, 21)
        Last_NameLabel.TabIndex = 29
        Last_NameLabel.Text = "Last Name"
        '
        'sex
        '
        sex.AutoSize = True
        sex.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        sex.Location = New System.Drawing.Point(281, 181)
        sex.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        sex.Name = "sex"
        sex.Size = New System.Drawing.Size(35, 21)
        sex.TabIndex = 29
        sex.Text = "Sex"
        '
        'lbl_surrendered
        '
        lbl_surrendered.AutoSize = True
        lbl_surrendered.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        lbl_surrendered.Location = New System.Drawing.Point(52, 491)
        lbl_surrendered.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        lbl_surrendered.Name = "lbl_surrendered"
        lbl_surrendered.Size = New System.Drawing.Size(114, 21)
        lbl_surrendered.TabIndex = 29
        lbl_surrendered.Text = "ID Surrendred"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.Color.DarkRed
        Label1.Location = New System.Drawing.Point(725, 83)
        Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(26, 20)
        Label1.TabIndex = 28
        Label1.Text = "ID"
        '
        'BadgeLabel
        '
        BadgeLabel.AutoSize = True
        BadgeLabel.Font = New System.Drawing.Font("Microsoft YaHei UI Light", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BadgeLabel.Location = New System.Drawing.Point(26, 541)
        BadgeLabel.Name = "BadgeLabel"
        BadgeLabel.Size = New System.Drawing.Size(140, 21)
        BadgeLabel.TabIndex = 61
        BadgeLabel.Text = "Visitor's ID Badge"
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
        'destinationcbox
        '
        Me.destinationcbox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.destinationcbox.FormattingEnabled = True
        Me.destinationcbox.Items.AddRange(New Object() {"Finance", "Registrar", "College of Computer Studies", "Office of the President", "Admissions", "Magis", "OSA", "SEC Mall", "Security Office"})
        Me.destinationcbox.Location = New System.Drawing.Point(178, 362)
        Me.destinationcbox.MaxLength = 35
        Me.destinationcbox.Name = "destinationcbox"
        Me.destinationcbox.Size = New System.Drawing.Size(246, 31)
        Me.destinationcbox.TabIndex = 6
        '
        'AddNew
        '
        Me.AddNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddNew.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNew.ForeColor = System.Drawing.Color.White
        Me.AddNew.Location = New System.Drawing.Point(698, 680)
        Me.AddNew.Name = "AddNew"
        Me.AddNew.Size = New System.Drawing.Size(168, 54)
        Me.AddNew.TabIndex = 41
        Me.AddNew.Text = "Clear"
        Me.AddNew.UseVisualStyleBackColor = False
        '
        'purposebox
        '
        Me.purposebox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purposebox.Location = New System.Drawing.Point(178, 417)
        Me.purposebox.Margin = New System.Windows.Forms.Padding(2)
        Me.purposebox.MaxLength = 30
        Me.purposebox.Multiline = True
        Me.purposebox.Name = "purposebox"
        Me.purposebox.Size = New System.Drawing.Size(246, 45)
        Me.purposebox.TabIndex = 7
        '
        'Phone_NumberTextBox
        '
        Me.Phone_NumberTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone_NumberTextBox.Location = New System.Drawing.Point(21, 200)
        Me.Phone_NumberTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Phone_NumberTextBox.MaxLength = 25
        Me.Phone_NumberTextBox.Name = "Phone_NumberTextBox"
        Me.Phone_NumberTextBox.Size = New System.Drawing.Size(184, 32)
        Me.Phone_NumberTextBox.TabIndex = 4
        '
        'Middle_NameTextBox
        '
        Me.Middle_NameTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Middle_NameTextBox.Location = New System.Drawing.Point(519, 112)
        Me.Middle_NameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Middle_NameTextBox.MaxLength = 30
        Me.Middle_NameTextBox.Name = "Middle_NameTextBox"
        Me.Middle_NameTextBox.Size = New System.Drawing.Size(209, 32)
        Me.Middle_NameTextBox.TabIndex = 3
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(267, 112)
        Me.First_NameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.First_NameTextBox.MaxLength = 30
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(209, 32)
        Me.First_NameTextBox.TabIndex = 2
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(21, 112)
        Me.Last_NameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Last_NameTextBox.MaxLength = 30
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(212, 32)
        Me.Last_NameTextBox.TabIndex = 1
        '
        'CheckIn
        '
        Me.CheckIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.CheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckIn.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIn.ForeColor = System.Drawing.Color.White
        Me.CheckIn.Location = New System.Drawing.Point(900, 680)
        Me.CheckIn.Name = "CheckIn"
        Me.CheckIn.Size = New System.Drawing.Size(168, 54)
        Me.CheckIn.TabIndex = 27
        Me.CheckIn.Text = "Check In"
        Me.CheckIn.UseVisualStyleBackColor = False
        '
        'BadgesBindingSource
        '
        Me.BadgesBindingSource.DataMember = "Badges"
        Me.BadgesBindingSource.DataSource = Me.DB1DataSet
        '
        'DB1DataSet
        '
        Me.DB1DataSet.DataSetName = "DB1DataSet"
        Me.DB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DB1DataSet1BindingSource
        '
        Me.DB1DataSet1BindingSource.DataSource = Me.DB1DataSet1
        Me.DB1DataSet1BindingSource.Position = 0
        '
        'DB1DataSet1
        '
        Me.DB1DataSet1.DataSetName = "DB1DataSet"
        Me.DB1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'sexcbox
        '
        Me.sexcbox.BackColor = System.Drawing.SystemColors.Window
        Me.sexcbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sexcbox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sexcbox.FormattingEnabled = True
        Me.sexcbox.Items.AddRange(New Object() {"Male", "Female", "Other/Unspecified"})
        Me.sexcbox.Location = New System.Drawing.Point(260, 200)
        Me.sexcbox.Name = "sexcbox"
        Me.sexcbox.Size = New System.Drawing.Size(94, 31)
        Me.sexcbox.TabIndex = 5
        '
        'capportraitbtn
        '
        Me.capportraitbtn.Location = New System.Drawing.Point(662, 299)
        Me.capportraitbtn.Name = "capportraitbtn"
        Me.capportraitbtn.Size = New System.Drawing.Size(105, 23)
        Me.capportraitbtn.TabIndex = 52
        Me.capportraitbtn.Text = "Capture Portrait"
        Me.capportraitbtn.UseVisualStyleBackColor = True
        '
        'capidbtn
        '
        Me.capidbtn.Location = New System.Drawing.Point(677, 338)
        Me.capidbtn.Name = "capidbtn"
        Me.capidbtn.Size = New System.Drawing.Size(90, 31)
        Me.capidbtn.TabIndex = 53
        Me.capidbtn.Text = "CaptureID"
        Me.capidbtn.UseVisualStyleBackColor = True
        '
        'surrenderedcbox
        '
        Me.surrenderedcbox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.surrenderedcbox.FormattingEnabled = True
        Me.surrenderedcbox.Items.AddRange(New Object() {"Driver's License", "School ID", "UMID", "Company ID", "Voter's ID", "Postal ID"})
        Me.surrenderedcbox.Location = New System.Drawing.Point(178, 487)
        Me.surrenderedcbox.MaxLength = 20
        Me.surrenderedcbox.Name = "surrenderedcbox"
        Me.surrenderedcbox.Size = New System.Drawing.Size(246, 31)
        Me.surrenderedcbox.TabIndex = 8
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Security_Logbook.My.Resources.Resources.blankid
        Me.PictureBox2.Location = New System.Drawing.Point(2, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(320, 240)
        Me.PictureBox2.TabIndex = 51
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Security_Logbook.My.Resources.Resources.portrait
        Me.PictureBox1.InitialImage = Global.Security_Logbook.My.Resources.Resources.portrait
        Me.PictureBox1.Location = New System.Drawing.Point(773, 83)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 240)
        Me.PictureBox1.TabIndex = 51
        Me.PictureBox1.TabStop = False
        '
        'v_id
        '
        Me.v_id.AutoSize = True
        Me.v_id.ForeColor = System.Drawing.Color.Red
        Me.v_id.Location = New System.Drawing.Point(749, 87)
        Me.v_id.Name = "v_id"
        Me.v_id.Size = New System.Drawing.Size(13, 13)
        Me.v_id.TabIndex = 55
        Me.v_id.Text = "0"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 50
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Location = New System.Drawing.Point(773, 339)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(322, 242)
        Me.Panel1.TabIndex = 58
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.InitialImage = CType(resources.GetObject("PictureBox3.InitialImage"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(320, 240)
        Me.PictureBox3.TabIndex = 51
        Me.PictureBox3.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel3.Location = New System.Drawing.Point(772, 82)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(322, 242)
        Me.Panel3.TabIndex = 59
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
        'BadgesTableAdapter1
        '
        Me.BadgesTableAdapter1.ClearBeforeFill = True
        '
        'FKVehiclesBadgesBindingSource
        '
        Me.FKVehiclesBadgesBindingSource.DataMember = "FK_Vehicles_Badges"
        Me.FKVehiclesBadgesBindingSource.DataSource = Me.BadgesBindingSource
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BadgesTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Security_Logbook.DB1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        Me.TableAdapterManager.VehiclesTableAdapter = Nothing
        Me.TableAdapterManager.VisitorsTableAdapter = Nothing
        '
        'DB1DataSet2
        '
        Me.DB1DataSet2.DataSetName = "DB1DataSet"
        Me.DB1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BadgesBindingSource1
        '
        Me.BadgesBindingSource1.DataMember = "Badges"
        Me.BadgesBindingSource1.DataSource = Me.DB1DataSet2
        '
        'BadgeComboBox
        '
        Me.BadgeComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BadgesBindingSource1, "badge", True))
        Me.BadgeComboBox.DataSource = Me.BadgesBindingSource1
        Me.BadgeComboBox.DisplayMember = "badge"
        Me.BadgeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.BadgeComboBox.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BadgeComboBox.FormattingEnabled = True
        Me.BadgeComboBox.Location = New System.Drawing.Point(178, 538)
        Me.BadgeComboBox.Name = "BadgeComboBox"
        Me.BadgeComboBox.Size = New System.Drawing.Size(99, 31)
        Me.BadgeComboBox.TabIndex = 9
        Me.BadgeComboBox.ValueMember = "badge"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Black
        Me.Panel4.Location = New System.Drawing.Point(3, 331)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1119, 1)
        Me.Panel4.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(870, 584)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 13)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Click on image to toggle Front/Back ID Image"
        '
        'Add_Visitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(BadgeLabel)
        Me.Controls.Add(Me.BadgeComboBox)
        Me.Controls.Add(Me.v_id)
        Me.Controls.Add(Me.surrenderedcbox)
        Me.Controls.Add(Me.capidbtn)
        Me.Controls.Add(Me.capportraitbtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.sexcbox)
        Me.Controls.Add(Me.destinationcbox)
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
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.CheckIn)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Add_Visitor"
        Me.Size = New System.Drawing.Size(1125, 763)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BadgesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB1DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisitorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKVehiclesBadgesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB1DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BadgesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents destinationcbox As ComboBox
    Friend WithEvents AddNew As Button
    Friend WithEvents purposebox As TextBox
    Friend WithEvents Phone_NumberTextBox As TextBox
    Friend WithEvents Middle_NameTextBox As TextBox
    Friend WithEvents First_NameTextBox As TextBox
    Friend WithEvents Last_NameTextBox As TextBox
    Friend WithEvents CheckIn As Button
    Friend WithEvents DB1DataSet As DB1DataSet
    Friend WithEvents VisitorsBindingSource As BindingSource
    Friend WithEvents sexcbox As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents capportraitbtn As Button
    Friend WithEvents capidbtn As Button
    Friend WithEvents surrenderedcbox As ComboBox
    Friend WithEvents v_id As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents VisitorsTableAdapter As DB1DataSetTableAdapters.VisitorsTableAdapter
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents BadgesBindingSource As BindingSource
    Friend WithEvents BadgesTableAdapter1 As DB1DataSetTableAdapters.BadgesTableAdapter
    Friend WithEvents FKVehiclesBadgesBindingSource As BindingSource
    Friend WithEvents DB1DataSet1BindingSource As BindingSource
    Friend WithEvents DB1DataSet1 As DB1DataSet
    Friend WithEvents TableAdapterManager As DB1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents BadgeComboBox As ComboBox
    Friend WithEvents BadgesBindingSource1 As BindingSource
    Friend WithEvents DB1DataSet2 As DB1DataSet
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
End Class
