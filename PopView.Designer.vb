<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PopView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim SexLabel As System.Windows.Forms.Label
        Dim Visit_IDLabel As System.Windows.Forms.Label
        Dim FirstnameLabel As System.Windows.Forms.Label
        Dim MiddlenameLabel As System.Windows.Forms.Label
        Dim SurnameLabel As System.Windows.Forms.Label
        Dim SexLabel1 As System.Windows.Forms.Label
        Dim EntryLabel As System.Windows.Forms.Label
        Dim ExitLabel As System.Windows.Forms.Label
        Dim DestinationLabel As System.Windows.Forms.Label
        Dim PurposeLabel As System.Windows.Forms.Label
        Dim Time_inLabel As System.Windows.Forms.Label
        Dim Time_outLabel As System.Windows.Forms.Label
        Dim Badge_numberLabel As System.Windows.Forms.Label
        Dim PortraitLabel As System.Windows.Forms.Label
        Dim Id_picLabel As System.Windows.Forms.Label
        Dim ID_surrenderedLabel As System.Windows.Forms.Label
        Dim PhoneLabel As System.Windows.Forms.Label
        Dim UseridLabel As System.Windows.Forms.Label
        Dim FullNameLabel As System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PortraitPictureBox = New System.Windows.Forms.PictureBox()
        Me.VisitorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB1DataSet1 = New Security_Logbook.DB1DataSet()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.VisitorsTableAdapter = New Security_Logbook.DB1DataSetTableAdapters.VisitorsTableAdapter()
        Me.TableAdapterManager = New Security_Logbook.DB1DataSetTableAdapters.TableAdapterManager()
        Me.SexTextBox = New System.Windows.Forms.TextBox()
        Me.DB1DataSet2 = New Security_Logbook.DB1DataSet()
        Me.Visit_IDTextBox = New System.Windows.Forms.TextBox()
        Me.FirstnameTextBox = New System.Windows.Forms.TextBox()
        Me.MiddlenameTextBox = New System.Windows.Forms.TextBox()
        Me.SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.SexTextBox1 = New System.Windows.Forms.TextBox()
        Me.EntryTextBox = New System.Windows.Forms.TextBox()
        Me.ExitTextBox = New System.Windows.Forms.TextBox()
        Me.DestinationTextBox = New System.Windows.Forms.TextBox()
        Me.PurposeTextBox = New System.Windows.Forms.TextBox()
        Me.Time_inDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Time_outDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Badge_numberTextBox = New System.Windows.Forms.TextBox()
        Me.PortraitPictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Id_picPictureBox = New System.Windows.Forms.PictureBox()
        Me.ID_surrenderedTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.UseridTextBox = New System.Windows.Forms.TextBox()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        SexLabel = New System.Windows.Forms.Label()
        Visit_IDLabel = New System.Windows.Forms.Label()
        FirstnameLabel = New System.Windows.Forms.Label()
        MiddlenameLabel = New System.Windows.Forms.Label()
        SurnameLabel = New System.Windows.Forms.Label()
        SexLabel1 = New System.Windows.Forms.Label()
        EntryLabel = New System.Windows.Forms.Label()
        ExitLabel = New System.Windows.Forms.Label()
        DestinationLabel = New System.Windows.Forms.Label()
        PurposeLabel = New System.Windows.Forms.Label()
        Time_inLabel = New System.Windows.Forms.Label()
        Time_outLabel = New System.Windows.Forms.Label()
        Badge_numberLabel = New System.Windows.Forms.Label()
        PortraitLabel = New System.Windows.Forms.Label()
        Id_picLabel = New System.Windows.Forms.Label()
        ID_surrenderedLabel = New System.Windows.Forms.Label()
        PhoneLabel = New System.Windows.Forms.Label()
        UseridLabel = New System.Windows.Forms.Label()
        FullNameLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        CType(Me.PortraitPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisitorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB1DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PortraitPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Id_picPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SexLabel
        '
        SexLabel.AutoSize = True
        SexLabel.Location = New System.Drawing.Point(424, 154)
        SexLabel.Name = "SexLabel"
        SexLabel.Size = New System.Drawing.Size(26, 13)
        SexLabel.TabIndex = 90
        SexLabel.Text = "sex:"
        '
        'Visit_IDLabel
        '
        Visit_IDLabel.AutoSize = True
        Visit_IDLabel.Location = New System.Drawing.Point(447, 201)
        Visit_IDLabel.Name = "Visit_IDLabel"
        Visit_IDLabel.Size = New System.Drawing.Size(42, 13)
        Visit_IDLabel.TabIndex = 91
        Visit_IDLabel.Text = "visit ID:"
        '
        'FirstnameLabel
        '
        FirstnameLabel.AutoSize = True
        FirstnameLabel.Location = New System.Drawing.Point(447, 227)
        FirstnameLabel.Name = "FirstnameLabel"
        FirstnameLabel.Size = New System.Drawing.Size(52, 13)
        FirstnameLabel.TabIndex = 93
        FirstnameLabel.Text = "firstname:"
        '
        'MiddlenameLabel
        '
        MiddlenameLabel.AutoSize = True
        MiddlenameLabel.Location = New System.Drawing.Point(447, 253)
        MiddlenameLabel.Name = "MiddlenameLabel"
        MiddlenameLabel.Size = New System.Drawing.Size(66, 13)
        MiddlenameLabel.TabIndex = 95
        MiddlenameLabel.Text = "middlename:"
        '
        'SurnameLabel
        '
        SurnameLabel.AutoSize = True
        SurnameLabel.Location = New System.Drawing.Point(447, 279)
        SurnameLabel.Name = "SurnameLabel"
        SurnameLabel.Size = New System.Drawing.Size(50, 13)
        SurnameLabel.TabIndex = 97
        SurnameLabel.Text = "surname:"
        '
        'SexLabel1
        '
        SexLabel1.AutoSize = True
        SexLabel1.Location = New System.Drawing.Point(447, 305)
        SexLabel1.Name = "SexLabel1"
        SexLabel1.Size = New System.Drawing.Size(26, 13)
        SexLabel1.TabIndex = 99
        SexLabel1.Text = "sex:"
        '
        'EntryLabel
        '
        EntryLabel.AutoSize = True
        EntryLabel.Location = New System.Drawing.Point(447, 331)
        EntryLabel.Name = "EntryLabel"
        EntryLabel.Size = New System.Drawing.Size(33, 13)
        EntryLabel.TabIndex = 101
        EntryLabel.Text = "entry:"
        '
        'ExitLabel
        '
        ExitLabel.AutoSize = True
        ExitLabel.Location = New System.Drawing.Point(447, 357)
        ExitLabel.Name = "ExitLabel"
        ExitLabel.Size = New System.Drawing.Size(26, 13)
        ExitLabel.TabIndex = 103
        ExitLabel.Text = "exit:"
        '
        'DestinationLabel
        '
        DestinationLabel.AutoSize = True
        DestinationLabel.Location = New System.Drawing.Point(447, 383)
        DestinationLabel.Name = "DestinationLabel"
        DestinationLabel.Size = New System.Drawing.Size(61, 13)
        DestinationLabel.TabIndex = 105
        DestinationLabel.Text = "destination:"
        '
        'PurposeLabel
        '
        PurposeLabel.AutoSize = True
        PurposeLabel.Location = New System.Drawing.Point(447, 409)
        PurposeLabel.Name = "PurposeLabel"
        PurposeLabel.Size = New System.Drawing.Size(48, 13)
        PurposeLabel.TabIndex = 107
        PurposeLabel.Text = "purpose:"
        '
        'Time_inLabel
        '
        Time_inLabel.AutoSize = True
        Time_inLabel.Location = New System.Drawing.Point(447, 436)
        Time_inLabel.Name = "Time_inLabel"
        Time_inLabel.Size = New System.Drawing.Size(40, 13)
        Time_inLabel.TabIndex = 109
        Time_inLabel.Text = "time in:"
        '
        'Time_outLabel
        '
        Time_outLabel.AutoSize = True
        Time_outLabel.Location = New System.Drawing.Point(447, 462)
        Time_outLabel.Name = "Time_outLabel"
        Time_outLabel.Size = New System.Drawing.Size(47, 13)
        Time_outLabel.TabIndex = 111
        Time_outLabel.Text = "time out:"
        '
        'Badge_numberLabel
        '
        Badge_numberLabel.AutoSize = True
        Badge_numberLabel.Location = New System.Drawing.Point(447, 487)
        Badge_numberLabel.Name = "Badge_numberLabel"
        Badge_numberLabel.Size = New System.Drawing.Size(78, 13)
        Badge_numberLabel.TabIndex = 113
        Badge_numberLabel.Text = "badge number:"
        '
        'PortraitLabel
        '
        PortraitLabel.AutoSize = True
        PortraitLabel.Location = New System.Drawing.Point(447, 510)
        PortraitLabel.Name = "PortraitLabel"
        PortraitLabel.Size = New System.Drawing.Size(42, 13)
        PortraitLabel.TabIndex = 115
        PortraitLabel.Text = "portrait:"
        '
        'Id_picLabel
        '
        Id_picLabel.AutoSize = True
        Id_picLabel.Location = New System.Drawing.Point(447, 566)
        Id_picLabel.Name = "Id_picLabel"
        Id_picLabel.Size = New System.Drawing.Size(35, 13)
        Id_picLabel.TabIndex = 117
        Id_picLabel.Text = "id pic:"
        '
        'ID_surrenderedLabel
        '
        ID_surrenderedLabel.AutoSize = True
        ID_surrenderedLabel.Location = New System.Drawing.Point(447, 625)
        ID_surrenderedLabel.Name = "ID_surrenderedLabel"
        ID_surrenderedLabel.Size = New System.Drawing.Size(80, 13)
        ID_surrenderedLabel.TabIndex = 119
        ID_surrenderedLabel.Text = "ID surrendered:"
        '
        'PhoneLabel
        '
        PhoneLabel.AutoSize = True
        PhoneLabel.Location = New System.Drawing.Point(447, 651)
        PhoneLabel.Name = "PhoneLabel"
        PhoneLabel.Size = New System.Drawing.Size(40, 13)
        PhoneLabel.TabIndex = 121
        PhoneLabel.Text = "phone:"
        '
        'UseridLabel
        '
        UseridLabel.AutoSize = True
        UseridLabel.Location = New System.Drawing.Point(447, 677)
        UseridLabel.Name = "UseridLabel"
        UseridLabel.Size = New System.Drawing.Size(38, 13)
        UseridLabel.TabIndex = 123
        UseridLabel.Text = "userid:"
        '
        'FullNameLabel
        '
        FullNameLabel.AutoSize = True
        FullNameLabel.Location = New System.Drawing.Point(447, 703)
        FullNameLabel.Name = "FullNameLabel"
        FullNameLabel.Size = New System.Drawing.Size(57, 13)
        FullNameLabel.TabIndex = 125
        FullNameLabel.Text = "Full Name:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Security_Logbook.My.Resources.Resources.portrait
        Me.PictureBox1.InitialImage = Global.Security_Logbook.My.Resources.Resources.portrait
        Me.PictureBox1.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(320, 240)
        Me.PictureBox1.TabIndex = 83
        Me.PictureBox1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel5.Controls.Add(Me.PictureBox3)
        Me.Panel5.Location = New System.Drawing.Point(12, 352)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(322, 242)
        Me.Panel5.TabIndex = 87
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Security_Logbook.My.Resources.Resources.blankid
        Me.PictureBox3.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(320, 240)
        Me.PictureBox3.TabIndex = 82
        Me.PictureBox3.TabStop = False
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel6.Controls.Add(Me.PortraitPictureBox)
        Me.Panel6.Controls.Add(Me.PictureBox1)
        Me.Panel6.Location = New System.Drawing.Point(11, 41)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(322, 242)
        Me.Panel6.TabIndex = 88
        '
        'PortraitPictureBox
        '
        Me.PortraitPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.VisitorsBindingSource, "portrait", True))
        Me.PortraitPictureBox.Location = New System.Drawing.Point(3, 5)
        Me.PortraitPictureBox.Name = "PortraitPictureBox"
        Me.PortraitPictureBox.Size = New System.Drawing.Size(316, 234)
        Me.PortraitPictureBox.TabIndex = 92
        Me.PortraitPictureBox.TabStop = False
        '
        'VisitorsBindingSource
        '
        Me.VisitorsBindingSource.DataMember = "Visitors"
        Me.VisitorsBindingSource.DataSource = Me.DB1DataSet1
        '
        'DB1DataSet1
        '
        Me.DB1DataSet1.DataSetName = "DB1DataSet"
        Me.DB1DataSet1.EnforceConstraints = False
        Me.DB1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitorsBindingSource, "surname", True))
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(338, 46)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(162, 34)
        Me.TextBox1.TabIndex = 89
        Me.TextBox1.Text = "Galaura"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitorsBindingSource, "firstname", True))
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(508, 46)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(179, 34)
        Me.TextBox2.TabIndex = 89
        Me.TextBox2.Text = "Alexis Lyndon"
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitorsBindingSource, "middlename", True))
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Tai Le", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(697, 46)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(162, 34)
        Me.TextBox3.TabIndex = 89
        Me.TextBox3.Text = "Guian"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei Light", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(336, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 19)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Family Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei Light", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(504, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 19)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei Light", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(693, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 19)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Middle Name"
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.VisitorsBindingSource, "visit_ID", True))
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Tai Le", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(76, 8)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(57, 27)
        Me.TextBox4.TabIndex = 89
        Me.TextBox4.Text = "00000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei Light", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 11)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 19)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "Visit ID"
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
        Me.TableAdapterManager.VehiclesTableAdapter = Nothing
        Me.TableAdapterManager.VisitorsTableAdapter = Me.VisitorsTableAdapter
        '
        'SexTextBox
        '
        Me.SexTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitorsBindingSource, "sex", True))
        Me.SexTextBox.Location = New System.Drawing.Point(456, 151)
        Me.SexTextBox.Name = "SexTextBox"
        Me.SexTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SexTextBox.TabIndex = 91
        '
        'DB1DataSet2
        '
        Me.DB1DataSet2.DataSetName = "DB1DataSet"
        Me.DB1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Visit_IDTextBox
        '
        Me.Visit_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitorsBindingSource, "visit_ID", True))
        Me.Visit_IDTextBox.Location = New System.Drawing.Point(533, 198)
        Me.Visit_IDTextBox.Name = "Visit_IDTextBox"
        Me.Visit_IDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Visit_IDTextBox.TabIndex = 92
        '
        'FirstnameTextBox
        '
        Me.FirstnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitorsBindingSource, "firstname", True))
        Me.FirstnameTextBox.Location = New System.Drawing.Point(533, 224)
        Me.FirstnameTextBox.Name = "FirstnameTextBox"
        Me.FirstnameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FirstnameTextBox.TabIndex = 94
        '
        'MiddlenameTextBox
        '
        Me.MiddlenameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitorsBindingSource, "middlename", True))
        Me.MiddlenameTextBox.Location = New System.Drawing.Point(533, 250)
        Me.MiddlenameTextBox.Name = "MiddlenameTextBox"
        Me.MiddlenameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MiddlenameTextBox.TabIndex = 96
        '
        'SurnameTextBox
        '
        Me.SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitorsBindingSource, "surname", True))
        Me.SurnameTextBox.Location = New System.Drawing.Point(533, 276)
        Me.SurnameTextBox.Name = "SurnameTextBox"
        Me.SurnameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.SurnameTextBox.TabIndex = 98
        '
        'SexTextBox1
        '
        Me.SexTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitorsBindingSource, "sex", True))
        Me.SexTextBox1.Location = New System.Drawing.Point(533, 302)
        Me.SexTextBox1.Name = "SexTextBox1"
        Me.SexTextBox1.Size = New System.Drawing.Size(200, 20)
        Me.SexTextBox1.TabIndex = 100
        '
        'EntryTextBox
        '
        Me.EntryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitorsBindingSource, "entry", True))
        Me.EntryTextBox.Location = New System.Drawing.Point(533, 328)
        Me.EntryTextBox.Name = "EntryTextBox"
        Me.EntryTextBox.Size = New System.Drawing.Size(200, 20)
        Me.EntryTextBox.TabIndex = 102
        '
        'ExitTextBox
        '
        Me.ExitTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitorsBindingSource, "exit", True))
        Me.ExitTextBox.Location = New System.Drawing.Point(533, 354)
        Me.ExitTextBox.Name = "ExitTextBox"
        Me.ExitTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ExitTextBox.TabIndex = 104
        '
        'DestinationTextBox
        '
        Me.DestinationTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitorsBindingSource, "destination", True))
        Me.DestinationTextBox.Location = New System.Drawing.Point(533, 380)
        Me.DestinationTextBox.Name = "DestinationTextBox"
        Me.DestinationTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DestinationTextBox.TabIndex = 106
        '
        'PurposeTextBox
        '
        Me.PurposeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitorsBindingSource, "purpose", True))
        Me.PurposeTextBox.Location = New System.Drawing.Point(533, 406)
        Me.PurposeTextBox.Name = "PurposeTextBox"
        Me.PurposeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PurposeTextBox.TabIndex = 108
        '
        'Time_inDateTimePicker
        '
        Me.Time_inDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VisitorsBindingSource, "time_in", True))
        Me.Time_inDateTimePicker.Location = New System.Drawing.Point(533, 432)
        Me.Time_inDateTimePicker.Name = "Time_inDateTimePicker"
        Me.Time_inDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Time_inDateTimePicker.TabIndex = 110
        '
        'Time_outDateTimePicker
        '
        Me.Time_outDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VisitorsBindingSource, "time_out", True))
        Me.Time_outDateTimePicker.Location = New System.Drawing.Point(533, 458)
        Me.Time_outDateTimePicker.Name = "Time_outDateTimePicker"
        Me.Time_outDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.Time_outDateTimePicker.TabIndex = 112
        '
        'Badge_numberTextBox
        '
        Me.Badge_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitorsBindingSource, "badge_number", True))
        Me.Badge_numberTextBox.Location = New System.Drawing.Point(533, 484)
        Me.Badge_numberTextBox.Name = "Badge_numberTextBox"
        Me.Badge_numberTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Badge_numberTextBox.TabIndex = 114
        '
        'PortraitPictureBox1
        '
        Me.PortraitPictureBox1.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.VisitorsBindingSource, "portrait", True))
        Me.PortraitPictureBox1.Location = New System.Drawing.Point(533, 510)
        Me.PortraitPictureBox1.Name = "PortraitPictureBox1"
        Me.PortraitPictureBox1.Size = New System.Drawing.Size(200, 50)
        Me.PortraitPictureBox1.TabIndex = 116
        Me.PortraitPictureBox1.TabStop = False
        '
        'Id_picPictureBox
        '
        Me.Id_picPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.VisitorsBindingSource, "id_pic", True))
        Me.Id_picPictureBox.Location = New System.Drawing.Point(533, 566)
        Me.Id_picPictureBox.Name = "Id_picPictureBox"
        Me.Id_picPictureBox.Size = New System.Drawing.Size(200, 50)
        Me.Id_picPictureBox.TabIndex = 118
        Me.Id_picPictureBox.TabStop = False
        '
        'ID_surrenderedTextBox
        '
        Me.ID_surrenderedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitorsBindingSource, "ID_surrendered", True))
        Me.ID_surrenderedTextBox.Location = New System.Drawing.Point(533, 622)
        Me.ID_surrenderedTextBox.Name = "ID_surrenderedTextBox"
        Me.ID_surrenderedTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ID_surrenderedTextBox.TabIndex = 120
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitorsBindingSource, "phone", True))
        Me.PhoneTextBox.Location = New System.Drawing.Point(533, 648)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PhoneTextBox.TabIndex = 122
        '
        'UseridTextBox
        '
        Me.UseridTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitorsBindingSource, "userid", True))
        Me.UseridTextBox.Location = New System.Drawing.Point(533, 674)
        Me.UseridTextBox.Name = "UseridTextBox"
        Me.UseridTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UseridTextBox.TabIndex = 124
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VisitorsBindingSource, "FullName", True))
        Me.FullNameTextBox.Location = New System.Drawing.Point(533, 700)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.FullNameTextBox.TabIndex = 126
        '
        'PopView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(901, 749)
        Me.Controls.Add(Visit_IDLabel)
        Me.Controls.Add(Me.Visit_IDTextBox)
        Me.Controls.Add(FirstnameLabel)
        Me.Controls.Add(Me.FirstnameTextBox)
        Me.Controls.Add(MiddlenameLabel)
        Me.Controls.Add(Me.MiddlenameTextBox)
        Me.Controls.Add(SurnameLabel)
        Me.Controls.Add(Me.SurnameTextBox)
        Me.Controls.Add(SexLabel1)
        Me.Controls.Add(Me.SexTextBox1)
        Me.Controls.Add(EntryLabel)
        Me.Controls.Add(Me.EntryTextBox)
        Me.Controls.Add(ExitLabel)
        Me.Controls.Add(Me.ExitTextBox)
        Me.Controls.Add(DestinationLabel)
        Me.Controls.Add(Me.DestinationTextBox)
        Me.Controls.Add(PurposeLabel)
        Me.Controls.Add(Me.PurposeTextBox)
        Me.Controls.Add(Time_inLabel)
        Me.Controls.Add(Me.Time_inDateTimePicker)
        Me.Controls.Add(Time_outLabel)
        Me.Controls.Add(Me.Time_outDateTimePicker)
        Me.Controls.Add(Badge_numberLabel)
        Me.Controls.Add(Me.Badge_numberTextBox)
        Me.Controls.Add(PortraitLabel)
        Me.Controls.Add(Me.PortraitPictureBox1)
        Me.Controls.Add(Id_picLabel)
        Me.Controls.Add(Me.Id_picPictureBox)
        Me.Controls.Add(ID_surrenderedLabel)
        Me.Controls.Add(Me.ID_surrenderedTextBox)
        Me.Controls.Add(PhoneLabel)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(UseridLabel)
        Me.Controls.Add(Me.UseridTextBox)
        Me.Controls.Add(FullNameLabel)
        Me.Controls.Add(Me.FullNameTextBox)
        Me.Controls.Add(SexLabel)
        Me.Controls.Add(Me.SexTextBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DB1DataSet1, "Visitors.surname", True))
        Me.Name = "PopView"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        CType(Me.PortraitPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisitorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB1DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PortraitPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Id_picPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DB1DataSet1 As DB1DataSet
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents VisitorsBindingSource As BindingSource
    Friend WithEvents VisitorsTableAdapter As DB1DataSetTableAdapters.VisitorsTableAdapter
    Friend WithEvents PortraitPictureBox As PictureBox
    Friend WithEvents TableAdapterManager As DB1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents SexTextBox As TextBox
    Friend WithEvents DB1DataSet2 As DB1DataSet
    Friend WithEvents Visit_IDTextBox As TextBox
    Friend WithEvents FirstnameTextBox As TextBox
    Friend WithEvents MiddlenameTextBox As TextBox
    Friend WithEvents SurnameTextBox As TextBox
    Friend WithEvents SexTextBox1 As TextBox
    Friend WithEvents EntryTextBox As TextBox
    Friend WithEvents ExitTextBox As TextBox
    Friend WithEvents DestinationTextBox As TextBox
    Friend WithEvents PurposeTextBox As TextBox
    Friend WithEvents Time_inDateTimePicker As DateTimePicker
    Friend WithEvents Time_outDateTimePicker As DateTimePicker
    Friend WithEvents Badge_numberTextBox As TextBox
    Friend WithEvents PortraitPictureBox1 As PictureBox
    Friend WithEvents Id_picPictureBox As PictureBox
    Friend WithEvents ID_surrenderedTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents UseridTextBox As TextBox
    Friend WithEvents FullNameTextBox As TextBox
End Class
