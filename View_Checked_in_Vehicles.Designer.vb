<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class View_Checked_in_Vehicles
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.checkoutbtn = New System.Windows.Forms.Button()
        Me.searchbtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.filterbox = New System.Windows.Forms.TextBox()
        Me.VehiclesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehiclesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DB1DataSet = New Security_Logbook.DB1DataSet()
        Me.VisitorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VisitorsTableAdapter = New Security_Logbook.DB1DataSetTableAdapters.VisitorsTableAdapter()
        Me.TableAdapterManager = New Security_Logbook.DB1DataSetTableAdapters.TableAdapterManager()
        Me.VehiclesTableAdapter = New Security_Logbook.DB1DataSetTableAdapters.VehiclesTableAdapter()
        Me.Panel2.SuspendLayout()
        CType(Me.VehiclesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VehiclesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DB1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VisitorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1109, 156)
        Me.Panel2.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(20, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(325, 37)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "View Checked-in Vehicles"
        '
        'checkoutbtn
        '
        Me.checkoutbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.checkoutbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.checkoutbtn.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkoutbtn.ForeColor = System.Drawing.Color.White
        Me.checkoutbtn.Location = New System.Drawing.Point(933, 686)
        Me.checkoutbtn.Margin = New System.Windows.Forms.Padding(4)
        Me.checkoutbtn.Name = "checkoutbtn"
        Me.checkoutbtn.Size = New System.Drawing.Size(154, 52)
        Me.checkoutbtn.TabIndex = 22
        Me.checkoutbtn.Text = "Check out"
        Me.checkoutbtn.UseVisualStyleBackColor = False
        '
        'searchbtn
        '
        Me.searchbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(47, Byte), Integer), CType(CType(79, Byte), Integer))
        Me.searchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.searchbtn.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchbtn.ForeColor = System.Drawing.Color.White
        Me.searchbtn.Location = New System.Drawing.Point(416, 226)
        Me.searchbtn.Name = "searchbtn"
        Me.searchbtn.Size = New System.Drawing.Size(103, 23)
        Me.searchbtn.TabIndex = 26
        Me.searchbtn.Text = "Search"
        Me.searchbtn.UseVisualStyleBackColor = False
        Me.searchbtn.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(190, 248)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(220, 1)
        Me.Panel1.TabIndex = 25
        '
        'filterbox
        '
        Me.filterbox.BackColor = System.Drawing.SystemColors.Window
        Me.filterbox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.filterbox.Location = New System.Drawing.Point(190, 226)
        Me.filterbox.Multiline = True
        Me.filterbox.Name = "filterbox"
        Me.filterbox.Size = New System.Drawing.Size(217, 23)
        Me.filterbox.TabIndex = 24
        Me.filterbox.Text = "Search here"
        '
        'VehiclesDataGridView
        '
        Me.VehiclesDataGridView.AutoGenerateColumns = False
        Me.VehiclesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VehiclesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn10})
        Me.VehiclesDataGridView.DataSource = Me.VehiclesBindingSource
        Me.VehiclesDataGridView.Location = New System.Drawing.Point(190, 255)
        Me.VehiclesDataGridView.Name = "VehiclesDataGridView"
        Me.VehiclesDataGridView.ReadOnly = True
        Me.VehiclesDataGridView.Size = New System.Drawing.Size(744, 229)
        Me.VehiclesDataGridView.TabIndex = 26
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.Frozen = True
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "plate"
        Me.DataGridViewTextBoxColumn5.Frozen = True
        Me.DataGridViewTextBoxColumn5.HeaderText = "Plate"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "make"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Make"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "model"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Model"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "color"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Color"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "time_in"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Time in"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "type"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Type"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'VehiclesBindingSource
        '
        Me.VehiclesBindingSource.DataMember = "Vehicles"
        Me.VehiclesBindingSource.DataSource = Me.DB1DataSet
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
        Me.TableAdapterManager.BadgesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Security_Logbook.DB1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usersTableAdapter = Nothing
        Me.TableAdapterManager.VehiclesTableAdapter = Nothing
        Me.TableAdapterManager.VisitorsTableAdapter = Me.VisitorsTableAdapter
        '
        'VehiclesTableAdapter
        '
        Me.VehiclesTableAdapter.ClearBeforeFill = True
        '
        'View_Checked_in_Vehicles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.VehiclesDataGridView)
        Me.Controls.Add(Me.searchbtn)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.filterbox)
        Me.Controls.Add(Me.checkoutbtn)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "View_Checked_in_Vehicles"
        Me.Size = New System.Drawing.Size(1129, 763)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.VehiclesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VehiclesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DB1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VisitorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents checkoutbtn As Button
    Friend WithEvents searchbtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents filterbox As TextBox
    Friend WithEvents DB1DataSet As DB1DataSet
    Friend WithEvents VisitorsBindingSource As BindingSource
    Friend WithEvents VisitorsTableAdapter As DB1DataSetTableAdapters.VisitorsTableAdapter
    Friend WithEvents TableAdapterManager As DB1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents VehiclesBindingSource As BindingSource
    Friend WithEvents VehiclesTableAdapter As DB1DataSetTableAdapters.VehiclesTableAdapter
    Friend WithEvents VehiclesDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
End Class
