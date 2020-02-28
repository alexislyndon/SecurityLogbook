<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class View_Checked_in
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.searchbtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.filterbox = New System.Windows.Forms.TextBox()
        Me.checkoutbtn = New System.Windows.Forms.Button()
        Me.VisitorsDataGridView = New System.Windows.Forms.DataGridView()
        Me.visit_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sex = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.entry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.destination = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.purpose = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.time_in = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisitorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB1DataSet1 = New Security_Logbook.DB1DataSet()
        Me.refreshbtn = New System.Windows.Forms.Button()
        Me.TableAdapterManager1 = New Security_Logbook.DB1DataSetTableAdapters.TableAdapterManager()
        Me.VisitorsTableAdapter1 = New Security_Logbook.DB1DataSetTableAdapters.VisitorsTableAdapter()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CheckoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BadgesTableAdapter1 = New Security_Logbook.DB1DataSetTableAdapters.BadgesTableAdapter()
        Me.Panel2.SuspendLayout()
        CType(Me.VisitorsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisitorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB1DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
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
        Me.Label6.Size = New System.Drawing.Size(415, 37)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Visitors List (Checked-in visitors)"
        '
        'searchbtn
        '
        Me.searchbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.searchbtn.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchbtn.ForeColor = System.Drawing.Color.White
        Me.searchbtn.Location = New System.Drawing.Point(204, 189)
        Me.searchbtn.Name = "searchbtn"
        Me.searchbtn.Size = New System.Drawing.Size(103, 23)
        Me.searchbtn.TabIndex = 20
        Me.searchbtn.Text = "Search"
        Me.searchbtn.UseVisualStyleBackColor = False
        Me.searchbtn.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(51, 211)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(147, 1)
        Me.Panel1.TabIndex = 19
        '
        'filterbox
        '
        Me.filterbox.BackColor = System.Drawing.SystemColors.Window
        Me.filterbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.filterbox.Location = New System.Drawing.Point(51, 189)
        Me.filterbox.Multiline = True
        Me.filterbox.Name = "filterbox"
        Me.filterbox.Size = New System.Drawing.Size(147, 23)
        Me.filterbox.TabIndex = 18
        Me.filterbox.Text = "Filter by Badge"
        '
        'checkoutbtn
        '
        Me.checkoutbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.checkoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.checkoutbtn.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkoutbtn.ForeColor = System.Drawing.Color.White
        Me.checkoutbtn.Location = New System.Drawing.Point(769, 699)
        Me.checkoutbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.checkoutbtn.Name = "checkoutbtn"
        Me.checkoutbtn.Size = New System.Drawing.Size(324, 43)
        Me.checkoutbtn.TabIndex = 21
        Me.checkoutbtn.Text = "Check out"
        Me.checkoutbtn.UseVisualStyleBackColor = False
        '
        'VisitorsDataGridView
        '
        Me.VisitorsDataGridView.AllowUserToAddRows = False
        Me.VisitorsDataGridView.AllowUserToDeleteRows = False
        Me.VisitorsDataGridView.AllowUserToOrderColumns = True
        Me.VisitorsDataGridView.AutoGenerateColumns = False
        Me.VisitorsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.VisitorsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken
        Me.VisitorsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VisitorsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.visit_ID, Me.DataGridViewTextBoxColumn15, Me.FullName, Me.phone, Me.sex, Me.entry, Me.destination, Me.purpose, Me.time_in})
        Me.VisitorsDataGridView.DataSource = Me.VisitorsBindingSource
        Me.VisitorsDataGridView.Location = New System.Drawing.Point(45, 225)
        Me.VisitorsDataGridView.Name = "VisitorsDataGridView"
        Me.VisitorsDataGridView.ReadOnly = True
        Me.VisitorsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VisitorsDataGridView.Size = New System.Drawing.Size(1048, 286)
        Me.VisitorsDataGridView.TabIndex = 21
        '
        'visit_ID
        '
        Me.visit_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.visit_ID.DataPropertyName = "visit_ID"
        Me.visit_ID.HeaderText = "Visit ID"
        Me.visit_ID.Name = "visit_ID"
        Me.visit_ID.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "badge_number"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Badge"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'FullName
        '
        Me.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FullName.DataPropertyName = "FullName"
        Me.FullName.HeaderText = "Full Name"
        Me.FullName.Name = "FullName"
        Me.FullName.ReadOnly = True
        '
        'phone
        '
        Me.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.phone.DataPropertyName = "phone"
        Me.phone.HeaderText = "Phone"
        Me.phone.Name = "phone"
        Me.phone.ReadOnly = True
        '
        'sex
        '
        Me.sex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.sex.DataPropertyName = "sex"
        Me.sex.HeaderText = "Sex"
        Me.sex.Name = "sex"
        Me.sex.ReadOnly = True
        '
        'entry
        '
        Me.entry.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.entry.DataPropertyName = "entry"
        Me.entry.HeaderText = "Entry"
        Me.entry.Name = "entry"
        Me.entry.ReadOnly = True
        '
        'destination
        '
        Me.destination.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.destination.DataPropertyName = "destination"
        Me.destination.HeaderText = "Destination"
        Me.destination.Name = "destination"
        Me.destination.ReadOnly = True
        '
        'purpose
        '
        Me.purpose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.purpose.DataPropertyName = "purpose"
        Me.purpose.HeaderText = "Purpose"
        Me.purpose.Name = "purpose"
        Me.purpose.ReadOnly = True
        '
        'time_in
        '
        Me.time_in.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.time_in.DataPropertyName = "time_in"
        Me.time_in.HeaderText = "Time in"
        Me.time_in.Name = "time_in"
        Me.time_in.ReadOnly = True
        '
        'VisitorsBindingSource
        '
        Me.VisitorsBindingSource.DataMember = "Visitors"
        Me.VisitorsBindingSource.DataSource = Me.DB1DataSet1
        '
        'DB1DataSet1
        '
        Me.DB1DataSet1.DataSetName = "DB1DataSet"
        Me.DB1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'refreshbtn
        '
        Me.refreshbtn.Location = New System.Drawing.Point(999, 196)
        Me.refreshbtn.Name = "refreshbtn"
        Me.refreshbtn.Size = New System.Drawing.Size(94, 23)
        Me.refreshbtn.TabIndex = 22
        Me.refreshbtn.Text = "Reset/Refresh"
        Me.refreshbtn.UseVisualStyleBackColor = True
        Me.refreshbtn.Visible = False
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.BadgesTableAdapter = Nothing
        Me.TableAdapterManager1.UpdateOrder = Security_Logbook.DB1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager1.usersTableAdapter = Nothing
        Me.TableAdapterManager1.VehiclesTableAdapter = Nothing
        Me.TableAdapterManager1.VisitorsTableAdapter = Me.VisitorsTableAdapter1
        '
        'VisitorsTableAdapter1
        '
        Me.VisitorsTableAdapter1.ClearBeforeFill = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewToolStripMenuItem, Me.ToolStripSeparator1, Me.CheckoutToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(126, 54)
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(122, 6)
        '
        'CheckoutToolStripMenuItem
        '
        Me.CheckoutToolStripMenuItem.Name = "CheckoutToolStripMenuItem"
        Me.CheckoutToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.CheckoutToolStripMenuItem.Text = "Checkout"
        '
        'BadgesTableAdapter1
        '
        Me.BadgesTableAdapter1.ClearBeforeFill = True
        '
        'View_Checked_in
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.refreshbtn)
        Me.Controls.Add(Me.VisitorsDataGridView)
        Me.Controls.Add(Me.checkoutbtn)
        Me.Controls.Add(Me.searchbtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.filterbox)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "View_Checked_in"
        Me.Size = New System.Drawing.Size(1129, 763)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.VisitorsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisitorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB1DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents searchbtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents filterbox As TextBox
    Friend WithEvents checkoutbtn As Button
    Friend WithEvents DB1DataSet1 As DB1DataSet
    Friend WithEvents TableAdapterManager1 As DB1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents VisitorsTableAdapter1 As DB1DataSetTableAdapters.VisitorsTableAdapter
    Friend WithEvents VisitorsBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents VisitorsDataGridView As DataGridView
    Friend WithEvents refreshbtn As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents CheckoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents BadgesTableAdapter1 As DB1DataSetTableAdapters.BadgesTableAdapter
    Friend WithEvents visit_ID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents FullName As DataGridViewTextBoxColumn
    Friend WithEvents phone As DataGridViewTextBoxColumn
    Friend WithEvents sex As DataGridViewTextBoxColumn
    Friend WithEvents entry As DataGridViewTextBoxColumn
    Friend WithEvents destination As DataGridViewTextBoxColumn
    Friend WithEvents purpose As DataGridViewTextBoxColumn
    Friend WithEvents time_in As DataGridViewTextBoxColumn
End Class
