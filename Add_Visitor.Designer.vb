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
        Dim Label1 As System.Windows.Forms.Label
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
        Me.badgecbox = New System.Windows.Forms.ComboBox()
        Me.sexcbox = New System.Windows.Forms.ComboBox()
        Me.capportraitbtn = New System.Windows.Forms.Button()
        Me.capidbtn = New System.Windows.Forms.Button()
        Me.surrenderedcbox = New System.Windows.Forms.ComboBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.v_id = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DB1DataSet = New Security_Logbook.DB1DataSet()
        Me.VisitorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VisitorsTableAdapter = New Security_Logbook.DB1DataSetTableAdapters.VisitorsTableAdapter()
        DestinationLabel = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Phone_NumberLabel = New System.Windows.Forms.Label()
        Middle_NameLabel = New System.Windows.Forms.Label()
        First_NameLabel = New System.Windows.Forms.Label()
        Last_NameLabel = New System.Windows.Forms.Label()
        Visitor_IDLabel = New System.Windows.Forms.Label()
        sex = New System.Windows.Forms.Label()
        lbl_surrendered = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisitorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DestinationLabel
        '
        DestinationLabel.AutoSize = True
        DestinationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DestinationLabel.Location = New System.Drawing.Point(29, 353)
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
        Label9.Location = New System.Drawing.Point(55, 388)
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
        Phone_NumberLabel.Location = New System.Drawing.Point(400, 132)
        Phone_NumberLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Phone_NumberLabel.Name = "Phone_NumberLabel"
        Phone_NumberLabel.Size = New System.Drawing.Size(115, 20)
        Phone_NumberLabel.TabIndex = 36
        Phone_NumberLabel.Text = "Phone Number"
        '
        'Middle_NameLabel
        '
        Middle_NameLabel.AutoSize = True
        Middle_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Middle_NameLabel.Location = New System.Drawing.Point(42, 262)
        Middle_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Middle_NameLabel.Name = "Middle_NameLabel"
        Middle_NameLabel.Size = New System.Drawing.Size(101, 20)
        Middle_NameLabel.TabIndex = 34
        Middle_NameLabel.Text = "Middle Name"
        '
        'First_NameLabel
        '
        First_NameLabel.AutoSize = True
        First_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        First_NameLabel.Location = New System.Drawing.Point(57, 197)
        First_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        First_NameLabel.Name = "First_NameLabel"
        First_NameLabel.Size = New System.Drawing.Size(86, 20)
        First_NameLabel.TabIndex = 32
        First_NameLabel.Text = "First Name"
        '
        'Last_NameLabel
        '
        Last_NameLabel.AutoSize = True
        Last_NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Last_NameLabel.Location = New System.Drawing.Point(57, 132)
        Last_NameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Last_NameLabel.Name = "Last_NameLabel"
        Last_NameLabel.Size = New System.Drawing.Size(86, 20)
        Last_NameLabel.TabIndex = 29
        Last_NameLabel.Text = "Last Name"
        '
        'Visitor_IDLabel
        '
        Visitor_IDLabel.AutoSize = True
        Visitor_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Visitor_IDLabel.Location = New System.Drawing.Point(637, 508)
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
        sex.Location = New System.Drawing.Point(402, 197)
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
        lbl_surrendered.Location = New System.Drawing.Point(641, 445)
        lbl_surrendered.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        lbl_surrendered.Name = "lbl_surrendered"
        lbl_surrendered.Size = New System.Drawing.Size(110, 20)
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
        Me.destinationcbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.destinationcbox.FormattingEnabled = True
        Me.destinationcbox.Items.AddRange(New Object() {"Finance", "Registrar", "College of Computer Studies", "Office of the President", "Admissions", "Magis", "OSA", "SEC Mall", "Security Office"})
        Me.destinationcbox.Location = New System.Drawing.Point(128, 339)
        Me.destinationcbox.MaxLength = 35
        Me.destinationcbox.Name = "destinationcbox"
        Me.destinationcbox.Size = New System.Drawing.Size(459, 41)
        Me.destinationcbox.TabIndex = 6
        '
        'AddNew
        '
        Me.AddNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.AddNew.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AddNew.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNew.ForeColor = System.Drawing.Color.White
        Me.AddNew.Location = New System.Drawing.Point(723, 667)
        Me.AddNew.Name = "AddNew"
        Me.AddNew.Size = New System.Drawing.Size(168, 54)
        Me.AddNew.TabIndex = 41
        Me.AddNew.Text = "Clear"
        Me.AddNew.UseVisualStyleBackColor = False
        '
        'purposebox
        '
        Me.purposebox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.purposebox.Location = New System.Drawing.Point(128, 385)
        Me.purposebox.Margin = New System.Windows.Forms.Padding(2)
        Me.purposebox.MaxLength = 30
        Me.purposebox.Multiline = True
        Me.purposebox.Name = "purposebox"
        Me.purposebox.Size = New System.Drawing.Size(459, 45)
        Me.purposebox.TabIndex = 7
        '
        'Phone_NumberTextBox
        '
        Me.Phone_NumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Phone_NumberTextBox.Location = New System.Drawing.Point(519, 129)
        Me.Phone_NumberTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Phone_NumberTextBox.MaxLength = 25
        Me.Phone_NumberTextBox.Name = "Phone_NumberTextBox"
        Me.Phone_NumberTextBox.Size = New System.Drawing.Size(184, 26)
        Me.Phone_NumberTextBox.TabIndex = 5
        Me.Phone_NumberTextBox.Text = "0000"
        '
        'Middle_NameTextBox
        '
        Me.Middle_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Middle_NameTextBox.Location = New System.Drawing.Point(147, 259)
        Me.Middle_NameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Middle_NameTextBox.MaxLength = 30
        Me.Middle_NameTextBox.Name = "Middle_NameTextBox"
        Me.Middle_NameTextBox.Size = New System.Drawing.Size(209, 26)
        Me.Middle_NameTextBox.TabIndex = 3
        Me.Middle_NameTextBox.Text = "TUNGANG APILIDO"
        '
        'First_NameTextBox
        '
        Me.First_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.First_NameTextBox.Location = New System.Drawing.Point(147, 194)
        Me.First_NameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.First_NameTextBox.MaxLength = 30
        Me.First_NameTextBox.Name = "First_NameTextBox"
        Me.First_NameTextBox.Size = New System.Drawing.Size(209, 26)
        Me.First_NameTextBox.TabIndex = 2
        Me.First_NameTextBox.Text = "PANGALAN"
        '
        'Last_NameTextBox
        '
        Me.Last_NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Last_NameTextBox.Location = New System.Drawing.Point(147, 129)
        Me.Last_NameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Last_NameTextBox.MaxLength = 30
        Me.Last_NameTextBox.Name = "Last_NameTextBox"
        Me.Last_NameTextBox.Size = New System.Drawing.Size(209, 26)
        Me.Last_NameTextBox.TabIndex = 1
        Me.Last_NameTextBox.Text = "APILIDO"
        '
        'CheckIn
        '
        Me.CheckIn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.CheckIn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CheckIn.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckIn.ForeColor = System.Drawing.Color.White
        Me.CheckIn.Location = New System.Drawing.Point(925, 667)
        Me.CheckIn.Name = "CheckIn"
        Me.CheckIn.Size = New System.Drawing.Size(168, 54)
        Me.CheckIn.TabIndex = 27
        Me.CheckIn.Text = "Check In"
        Me.CheckIn.UseVisualStyleBackColor = False
        '
        'badgecbox
        '
        Me.badgecbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.badgecbox.FormattingEnabled = True
        Me.badgecbox.Items.AddRange(New Object() {"A1", "A2", "A3", "A4", "A5", "B1", "B2", "B3", "B4", "B5"})
        Me.badgecbox.Location = New System.Drawing.Point(694, 531)
        Me.badgecbox.MaxLength = 4
        Me.badgecbox.Name = "badgecbox"
        Me.badgecbox.Size = New System.Drawing.Size(72, 32)
        Me.badgecbox.TabIndex = 8
        '
        'sexcbox
        '
        Me.sexcbox.BackColor = System.Drawing.SystemColors.Window
        Me.sexcbox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.sexcbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sexcbox.FormattingEnabled = True
        Me.sexcbox.Items.AddRange(New Object() {"Male", "Female", "Other/Unspecified"})
        Me.sexcbox.Location = New System.Drawing.Point(442, 194)
        Me.sexcbox.Name = "sexcbox"
        Me.sexcbox.Size = New System.Drawing.Size(94, 28)
        Me.sexcbox.TabIndex = 4
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
        Me.surrenderedcbox.FormattingEnabled = True
        Me.surrenderedcbox.Items.AddRange(New Object() {"Driver's License", "School ID", "UMID", "Company ID", "Voter's ID", "Postal ID"})
        Me.surrenderedcbox.Location = New System.Drawing.Point(645, 471)
        Me.surrenderedcbox.MaxLength = 20
        Me.surrenderedcbox.Name = "surrenderedcbox"
        Me.surrenderedcbox.Size = New System.Drawing.Size(121, 21)
        Me.surrenderedcbox.TabIndex = 9
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Security_Logbook.My.Resources.Resources.blankid
        Me.PictureBox2.Location = New System.Drawing.Point(773, 339)
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
        Me.ErrorProvider1.BlinkRate = 1000
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Location = New System.Drawing.Point(772, 338)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(322, 242)
        Me.Panel1.TabIndex = 58
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel3.Location = New System.Drawing.Point(772, 82)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(322, 242)
        Me.Panel3.TabIndex = 59
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
        'Add_Visitor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.v_id)
        Me.Controls.Add(Me.surrenderedcbox)
        Me.Controls.Add(Me.capidbtn)
        Me.Controls.Add(Me.capportraitbtn)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.sexcbox)
        Me.Controls.Add(Me.badgecbox)
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
        Me.Controls.Add(Visitor_IDLabel)
        Me.Controls.Add(Me.CheckIn)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Add_Visitor"
        Me.Size = New System.Drawing.Size(1109, 763)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisitorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents badgecbox As ComboBox
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
End Class
