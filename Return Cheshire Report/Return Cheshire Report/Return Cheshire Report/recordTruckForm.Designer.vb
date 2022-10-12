<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class recordTruckForm
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
        Dim Trailer_NumberLabel As System.Windows.Forms.Label
        Dim Units_CountLabel As System.Windows.Forms.Label
        Dim DropOff_DateLabel As System.Windows.Forms.Label
        Dim Carton_CountLabel As System.Windows.Forms.Label
        Dim CarrierLabel As System.Windows.Forms.Label
        Dim Staging_AreaLabel As System.Windows.Forms.Label
        Me.dashTitleLbl = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RecordEosGoalBtn = New System.Windows.Forms.ToolStrip()
        Me.recordTruckBtn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.recordGoal = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.viewDBtn = New System.Windows.Forms.ToolStripButton()
        Me.printReportLbl = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RecordTruck1DataSet = New Return_Cheshire_Report.recordTruck1DataSet()
        Me.TruckTableAdapter = New Return_Cheshire_Report.recordTruck1DataSetTableAdapters.truckTableAdapter()
        Me.TableAdapterManager = New Return_Cheshire_Report.recordTruck1DataSetTableAdapters.TableAdapterManager()
        Me.AppData = New Return_Cheshire_Report.appData()
        Me.TruckTableAdapter1 = New Return_Cheshire_Report.appDataTableAdapters.truckTableAdapter()
        Me.TableAdapterManager1 = New Return_Cheshire_Report.appDataTableAdapters.TableAdapterManager()
        Me.ReturnCarryOverDataSet = New Return_Cheshire_Report.ReturnCarryOverDataSet()
        Me.TrailerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrailerTableAdapter = New Return_Cheshire_Report.ReturnCarryOverDataSetTableAdapters.TrailerTableAdapter()
        Me.TableAdapterManager2 = New Return_Cheshire_Report.ReturnCarryOverDataSetTableAdapters.TableAdapterManager()
        Me.TrailerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DropOff_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Carton_CountTextBox = New System.Windows.Forms.TextBox()
        Me.CarrierTextBox = New System.Windows.Forms.TextBox()
        Me.Staging_AreaTextBox = New System.Windows.Forms.TextBox()
        Me.Trailer_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Units_CountTextBox = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Trailer_NumberLabel = New System.Windows.Forms.Label()
        Units_CountLabel = New System.Windows.Forms.Label()
        DropOff_DateLabel = New System.Windows.Forms.Label()
        Carton_CountLabel = New System.Windows.Forms.Label()
        CarrierLabel = New System.Windows.Forms.Label()
        Staging_AreaLabel = New System.Windows.Forms.Label()
        Me.RecordEosGoalBtn.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RecordTruck1DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AppData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReturnCarryOverDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrailerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrailerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Trailer_NumberLabel
        '
        Trailer_NumberLabel.AutoSize = True
        Trailer_NumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Trailer_NumberLabel.Location = New System.Drawing.Point(693, 139)
        Trailer_NumberLabel.Name = "Trailer_NumberLabel"
        Trailer_NumberLabel.Size = New System.Drawing.Size(110, 18)
        Trailer_NumberLabel.TabIndex = 19
        Trailer_NumberLabel.Text = "Trailer Number:"
        '
        'Units_CountLabel
        '
        Units_CountLabel.AutoSize = True
        Units_CountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Units_CountLabel.Location = New System.Drawing.Point(36, 142)
        Units_CountLabel.Name = "Units_CountLabel"
        Units_CountLabel.Size = New System.Drawing.Size(90, 18)
        Units_CountLabel.TabIndex = 29
        Units_CountLabel.Text = "Units Count:"
        '
        'DropOff_DateLabel
        '
        DropOff_DateLabel.AutoSize = True
        DropOff_DateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DropOff_DateLabel.Location = New System.Drawing.Point(349, 102)
        DropOff_DateLabel.Name = "DropOff_DateLabel"
        DropOff_DateLabel.Size = New System.Drawing.Size(104, 18)
        DropOff_DateLabel.TabIndex = 27
        DropOff_DateLabel.Text = "Drop Off Date:"
        '
        'Carton_CountLabel
        '
        Carton_CountLabel.AutoSize = True
        Carton_CountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Carton_CountLabel.Location = New System.Drawing.Point(25, 100)
        Carton_CountLabel.Name = "Carton_CountLabel"
        Carton_CountLabel.Size = New System.Drawing.Size(101, 18)
        Carton_CountLabel.TabIndex = 25
        Carton_CountLabel.Text = "Carton Count:"
        '
        'CarrierLabel
        '
        CarrierLabel.AutoSize = True
        CarrierLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CarrierLabel.Location = New System.Drawing.Point(374, 142)
        CarrierLabel.Name = "CarrierLabel"
        CarrierLabel.Size = New System.Drawing.Size(57, 18)
        CarrierLabel.TabIndex = 23
        CarrierLabel.Text = "Carrier:"
        '
        'Staging_AreaLabel
        '
        Staging_AreaLabel.AutoSize = True
        Staging_AreaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Staging_AreaLabel.Location = New System.Drawing.Point(708, 105)
        Staging_AreaLabel.Name = "Staging_AreaLabel"
        Staging_AreaLabel.Size = New System.Drawing.Size(95, 18)
        Staging_AreaLabel.TabIndex = 21
        Staging_AreaLabel.Text = "Staging Area:"
        '
        'dashTitleLbl
        '
        Me.dashTitleLbl.AutoSize = True
        Me.dashTitleLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold)
        Me.dashTitleLbl.ForeColor = System.Drawing.SystemColors.Highlight
        Me.dashTitleLbl.Location = New System.Drawing.Point(305, 35)
        Me.dashTitleLbl.Name = "dashTitleLbl"
        Me.dashTitleLbl.Size = New System.Drawing.Size(372, 42)
        Me.dashTitleLbl.TabIndex = 1
        Me.dashTitleLbl.Text = "RECORD TRAILER "
        Me.dashTitleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(276, 570)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 28)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Save Data "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(776, 646)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 30)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'RecordEosGoalBtn
        '
        Me.RecordEosGoalBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RecordEosGoalBtn.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RecordEosGoalBtn.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.RecordEosGoalBtn.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.recordTruckBtn, Me.ToolStripSeparator1, Me.recordGoal, Me.ToolStripSeparator2, Me.viewDBtn, Me.printReportLbl})
        Me.RecordEosGoalBtn.Location = New System.Drawing.Point(0, 0)
        Me.RecordEosGoalBtn.Name = "RecordEosGoalBtn"
        Me.RecordEosGoalBtn.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.RecordEosGoalBtn.Size = New System.Drawing.Size(1037, 25)
        Me.RecordEosGoalBtn.TabIndex = 17
        Me.RecordEosGoalBtn.Text = "ToolStrip1"
        '
        'recordTruckBtn
        '
        Me.recordTruckBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.recordTruckBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.recordTruckBtn.Name = "recordTruckBtn"
        Me.recordTruckBtn.Size = New System.Drawing.Size(91, 22)
        Me.recordTruckBtn.Text = "Record Truck"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'recordGoal
        '
        Me.recordGoal.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.recordGoal.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.recordGoal.Name = "recordGoal"
        Me.recordGoal.Size = New System.Drawing.Size(121, 22)
        Me.recordGoal.Text = "Record EOS GOAL"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'viewDBtn
        '
        Me.viewDBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.viewDBtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.viewDBtn.Name = "viewDBtn"
        Me.viewDBtn.Size = New System.Drawing.Size(87, 22)
        Me.viewDBtn.Text = "View Report"
        '
        'printReportLbl
        '
        Me.printReportLbl.Name = "printReportLbl"
        Me.printReportLbl.Size = New System.Drawing.Size(6, 25)
        '
        'RecordTruck1DataSet
        '
        Me.RecordTruck1DataSet.DataSetName = "recordTruck1DataSet"
        Me.RecordTruck1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TruckTableAdapter
        '
        Me.TruckTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.truckTableAdapter = Me.TruckTableAdapter
        Me.TableAdapterManager.UpdateOrder = Return_Cheshire_Report.recordTruck1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'AppData
        '
        Me.AppData.DataSetName = "appData"
        Me.AppData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TruckTableAdapter1
        '
        Me.TruckTableAdapter1.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.truckTableAdapter = Me.TruckTableAdapter1
        Me.TableAdapterManager1.UpdateOrder = Return_Cheshire_Report.appDataTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ReturnCarryOverDataSet
        '
        Me.ReturnCarryOverDataSet.DataSetName = "ReturnCarryOverDataSet"
        Me.ReturnCarryOverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TrailerBindingSource
        '
        Me.TrailerBindingSource.DataMember = "Trailer"
        Me.TrailerBindingSource.DataSource = Me.ReturnCarryOverDataSet
        '
        'TrailerTableAdapter
        '
        Me.TrailerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.employeeTableAdapter = Nothing
        Me.TableAdapterManager2.TrailerTableAdapter = Me.TrailerTableAdapter
        Me.TableAdapterManager2.UpdateOrder = Return_Cheshire_Report.ReturnCarryOverDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TrailerDataGridView
        '
        Me.TrailerDataGridView.AllowUserToAddRows = False
        Me.TrailerDataGridView.AllowUserToDeleteRows = False
        Me.TrailerDataGridView.AutoGenerateColumns = False
        Me.TrailerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TrailerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.TrailerDataGridView.DataSource = Me.TrailerBindingSource
        Me.TrailerDataGridView.Location = New System.Drawing.Point(12, 187)
        Me.TrailerDataGridView.Name = "TrailerDataGridView"
        Me.TrailerDataGridView.ReadOnly = True
        Me.TrailerDataGridView.Size = New System.Drawing.Size(1005, 377)
        Me.TrailerDataGridView.TabIndex = 17
        '
        'DropOff_DateDateTimePicker
        '
        Me.DropOff_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.TrailerBindingSource, "DropOff Date", True))
        Me.DropOff_DateDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DropOff_DateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DropOff_DateDateTimePicker.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DropOff_DateDateTimePicker.Location = New System.Drawing.Point(459, 103)
        Me.DropOff_DateDateTimePicker.Name = "DropOff_DateDateTimePicker"
        Me.DropOff_DateDateTimePicker.Size = New System.Drawing.Size(137, 22)
        Me.DropOff_DateDateTimePicker.TabIndex = 28
        '
        'Carton_CountTextBox
        '
        Me.Carton_CountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrailerBindingSource, "Carton Count", True))
        Me.Carton_CountTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Carton_CountTextBox.Location = New System.Drawing.Point(132, 100)
        Me.Carton_CountTextBox.Name = "Carton_CountTextBox"
        Me.Carton_CountTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Carton_CountTextBox.TabIndex = 26
        '
        'CarrierTextBox
        '
        Me.CarrierTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrailerBindingSource, "Carrier", True))
        Me.CarrierTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CarrierTextBox.Location = New System.Drawing.Point(459, 139)
        Me.CarrierTextBox.Name = "CarrierTextBox"
        Me.CarrierTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CarrierTextBox.TabIndex = 24
        '
        'Staging_AreaTextBox
        '
        Me.Staging_AreaTextBox.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Staging_AreaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Staging_AreaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrailerBindingSource, "Staging Area", True))
        Me.Staging_AreaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Staging_AreaTextBox.Location = New System.Drawing.Point(817, 77)
        Me.Staging_AreaTextBox.Name = "Staging_AreaTextBox"
        Me.Staging_AreaTextBox.ReadOnly = True
        Me.Staging_AreaTextBox.Size = New System.Drawing.Size(200, 15)
        Me.Staging_AreaTextBox.TabIndex = 22
        '
        'Trailer_NumberTextBox
        '
        Me.Trailer_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrailerBindingSource, "Trailer Number", True))
        Me.Trailer_NumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Trailer_NumberTextBox.Location = New System.Drawing.Point(817, 143)
        Me.Trailer_NumberTextBox.Name = "Trailer_NumberTextBox"
        Me.Trailer_NumberTextBox.Size = New System.Drawing.Size(200, 22)
        Me.Trailer_NumberTextBox.TabIndex = 20
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(147, 570)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(109, 28)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "Add Trailer"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.AutoSize = True
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(12, 570)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(116, 28)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "Delete Trailer"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Units_CountTextBox
        '
        Me.Units_CountTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TrailerBindingSource, "Units Count", True))
        Me.Units_CountTextBox.Location = New System.Drawing.Point(132, 143)
        Me.Units_CountTextBox.Name = "Units_CountTextBox"
        Me.Units_CountTextBox.Size = New System.Drawing.Size(200, 20)
        Me.Units_CountTextBox.TabIndex = 45
        '
        'Button5
        '
        Me.Button5.AutoSize = True
        Me.Button5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(919, 646)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(98, 30)
        Me.Button5.TabIndex = 47
        Me.Button5.Text = "Finish"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"RCV Yard", "DOOR 1", "DOOR 2", "DOOR 3", "DOOR 4", "DOOR 5", "DOOR 6", "DOOR 7", "DOOR 8", "DOOR 9", "DOOR 10", "DOOR 11", "DOOR 12", "DOOR 13", "DOOR 14", "DOOR 15", "DOOR 16", "DOOR 17", "Shipping Yard"})
        Me.ComboBox1.Location = New System.Drawing.Point(817, 107)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 48
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Trailer Number"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Trailer Number"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 101
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Staging Area"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Staging Area"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Carrier"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Carrier"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Carton Count"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Carton Count"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DropOff Date"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DropOff Date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Units Count"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Units Count"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'recordTruckForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1037, 688)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Units_CountTextBox)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Trailer_NumberLabel)
        Me.Controls.Add(Me.Trailer_NumberTextBox)
        Me.Controls.Add(Staging_AreaLabel)
        Me.Controls.Add(Me.Staging_AreaTextBox)
        Me.Controls.Add(CarrierLabel)
        Me.Controls.Add(Me.CarrierTextBox)
        Me.Controls.Add(Carton_CountLabel)
        Me.Controls.Add(Me.Carton_CountTextBox)
        Me.Controls.Add(DropOff_DateLabel)
        Me.Controls.Add(Me.DropOff_DateDateTimePicker)
        Me.Controls.Add(Units_CountLabel)
        Me.Controls.Add(Me.TrailerDataGridView)
        Me.Controls.Add(Me.RecordEosGoalBtn)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dashTitleLbl)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "recordTruckForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Record Truck "
        Me.RecordEosGoalBtn.ResumeLayout(False)
        Me.RecordEosGoalBtn.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RecordTruck1DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AppData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReturnCarryOverDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrailerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrailerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dashTitleLbl As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents RecordEosGoalBtn As ToolStrip
    Friend WithEvents recordTruckBtn As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents recordGoal As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents viewDBtn As ToolStripButton
    Friend WithEvents printReportLbl As ToolStripSeparator
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents RecordTruck1DataSet As recordTruck1DataSet
    Friend WithEvents TruckTableAdapter As recordTruck1DataSetTableAdapters.truckTableAdapter
    Friend WithEvents TableAdapterManager As recordTruck1DataSetTableAdapters.TableAdapterManager
    Friend WithEvents AppData As appData
    Friend WithEvents TruckTableAdapter1 As appDataTableAdapters.truckTableAdapter
    Friend WithEvents TableAdapterManager1 As appDataTableAdapters.TableAdapterManager
    Friend WithEvents ReturnCarryOverDataSet As ReturnCarryOverDataSet
    Friend WithEvents TrailerBindingSource As BindingSource
    Friend WithEvents TrailerTableAdapter As ReturnCarryOverDataSetTableAdapters.TrailerTableAdapter
    Friend WithEvents TableAdapterManager2 As ReturnCarryOverDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TrailerDataGridView As DataGridView
    Friend WithEvents DropOff_DateDateTimePicker As DateTimePicker
    Friend WithEvents Carton_CountTextBox As TextBox
    Friend WithEvents CarrierTextBox As TextBox
    Friend WithEvents Staging_AreaTextBox As TextBox
    Friend WithEvents Trailer_NumberTextBox As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Units_CountTextBox As TextBox
    Friend WithEvents Button5 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
End Class
