<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewDetailForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.RecordEosGoalBtn = New System.Windows.Forms.ToolStrip()
        Me.recordTruckBtn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.recordGoal = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.viewDBtn = New System.Windows.Forms.ToolStripButton()
        Me.printReportLbl = New System.Windows.Forms.ToolStripSeparator()
        Me.ReturnCarryOverDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReturnCarryOverDataSet = New Return_Cheshire_Report.ReturnCarryOverDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.userIdTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.refreshProgressBarBtn = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripDropDownButton1 = New System.Windows.Forms.ToolStripDropDownButton()
        Me.EditDataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddTrailerToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeTableAdapter = New Return_Cheshire_Report.ReturnCarryOverDataSetTableAdapters.employeeTableAdapter()
        Me.TrailerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TrailerTableAdapter = New Return_Cheshire_Report.ReturnCarryOverDataSetTableAdapters.TrailerTableAdapter()
        Me.TableAdapterManager = New Return_Cheshire_Report.ReturnCarryOverDataSetTableAdapters.TableAdapterManager()
        Me.TrailerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RecordEosGoalBtn.SuspendLayout()
        CType(Me.ReturnCarryOverDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReturnCarryOverDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrailerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrailerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.RecordEosGoalBtn.Size = New System.Drawing.Size(984, 25)
        Me.RecordEosGoalBtn.TabIndex = 7
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
        'ReturnCarryOverDataSetBindingSource
        '
        Me.ReturnCarryOverDataSetBindingSource.DataSource = Me.ReturnCarryOverDataSet
        Me.ReturnCarryOverDataSetBindingSource.Position = 0
        '
        'ReturnCarryOverDataSet
        '
        Me.ReturnCarryOverDataSet.DataSetName = "ReturnCarryOverDataSet"
        Me.ReturnCarryOverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(327, 84)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 20)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Carton Count"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateTimePicker1.Location = New System.Drawing.Point(452, 53)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(123, 20)
        Me.DateTimePicker1.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(327, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Dropoff Date "
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"RCV YARD ", "DOOR 1", "DOOR 2", "DOOR 3", "DOOR 4", "DOOR 5", "DOOR 6", "DOOR 7", "DOOR 7", "DOOR 8", "DOOR 9", "DOOR 10", "DOOR 11", "DOOR 12", "DOOR 13", "DOOR 14", "DOOR 15", "DOOR 16", "SAY"})
        Me.ComboBox1.Location = New System.Drawing.Point(170, 83)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(123, 21)
        Me.ComboBox1.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(41, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Staging Area"
        '
        'userIdTxt
        '
        Me.userIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.userIdTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userIdTxt.Location = New System.Drawing.Point(170, 46)
        Me.userIdTxt.Name = "userIdTxt"
        Me.userIdTxt.Size = New System.Drawing.Size(123, 22)
        Me.userIdTxt.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(29, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Trailer Number"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(452, 81)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(123, 22)
        Me.TextBox1.TabIndex = 20
        '
        'refreshProgressBarBtn
        '
        Me.refreshProgressBarBtn.BackColor = System.Drawing.Color.White
        Me.refreshProgressBarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshProgressBarBtn.Location = New System.Drawing.Point(670, 76)
        Me.refreshProgressBarBtn.Name = "refreshProgressBarBtn"
        Me.refreshProgressBarBtn.Size = New System.Drawing.Size(114, 30)
        Me.refreshProgressBarBtn.TabIndex = 21
        Me.refreshProgressBarBtn.Text = "Search"
        Me.refreshProgressBarBtn.UseVisualStyleBackColor = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripDropDownButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(12, 156)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(73, 25)
        Me.ToolStrip1.TabIndex = 22
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripDropDownButton1
        '
        Me.ToolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripDropDownButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditDataToolStripMenuItem, Me.AddTrailerToolStripMenuItem1, Me.DeleteToolStripMenuItem})
        Me.ToolStripDropDownButton1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripDropDownButton1.Name = "ToolStripDropDownButton1"
        Me.ToolStripDropDownButton1.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripDropDownButton1.Text = "Action"
        '
        'EditDataToolStripMenuItem
        '
        Me.EditDataToolStripMenuItem.Name = "EditDataToolStripMenuItem"
        Me.EditDataToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.EditDataToolStripMenuItem.Text = "Edit Trailer Info"
        '
        'AddTrailerToolStripMenuItem1
        '
        Me.AddTrailerToolStripMenuItem1.Name = "AddTrailerToolStripMenuItem1"
        Me.AddTrailerToolStripMenuItem1.Size = New System.Drawing.Size(172, 22)
        Me.AddTrailerToolStripMenuItem1.Text = "Add Trailer"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "employee"
        Me.EmployeeBindingSource.DataSource = Me.ReturnCarryOverDataSetBindingSource
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.employeeTableAdapter = Me.EmployeeTableAdapter
        Me.TableAdapterManager.TrailerTableAdapter = Me.TrailerTableAdapter
        Me.TableAdapterManager.UpdateOrder = Return_Cheshire_Report.ReturnCarryOverDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TrailerDataGridView
        '
        Me.TrailerDataGridView.AutoGenerateColumns = False
        Me.TrailerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TrailerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.TrailerDataGridView.DataSource = Me.TrailerBindingSource
        Me.TrailerDataGridView.Location = New System.Drawing.Point(127, 316)
        Me.TrailerDataGridView.Name = "TrailerDataGridView"
        Me.TrailerDataGridView.Size = New System.Drawing.Size(743, 220)
        Me.TrailerDataGridView.TabIndex = 22
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Trailer Number"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Trailer Number"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Staging Area"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Staging Area"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Carrier"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Carrier"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Carton Count"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Carton Count"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DropOff Date"
        Me.DataGridViewTextBoxColumn6.HeaderText = "DropOff Date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Units Count"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Units Count"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(327, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 20)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Carton Count"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(327, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 20)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Carton Count"
        '
        'viewDetailForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(984, 761)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TrailerDataGridView)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.refreshProgressBarBtn)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.userIdTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RecordEosGoalBtn)
        Me.Name = "viewDetailForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "viewDetailForm"
        Me.RecordEosGoalBtn.ResumeLayout(False)
        Me.RecordEosGoalBtn.PerformLayout()
        CType(Me.ReturnCarryOverDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReturnCarryOverDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrailerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrailerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RecordEosGoalBtn As ToolStrip
    Friend WithEvents recordTruckBtn As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents recordGoal As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents viewDBtn As ToolStripButton
    Friend WithEvents printReportLbl As ToolStripSeparator
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents userIdTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents refreshProgressBarBtn As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripDropDownButton1 As ToolStripDropDownButton
    Friend WithEvents EditDataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddTrailerToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnCarryOverDataSetBindingSource As BindingSource
    Friend WithEvents ReturnCarryOverDataSet As ReturnCarryOverDataSet
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As ReturnCarryOverDataSetTableAdapters.employeeTableAdapter
    Friend WithEvents TrailerBindingSource As BindingSource
    Friend WithEvents TrailerTableAdapter As ReturnCarryOverDataSetTableAdapters.TrailerTableAdapter
    Friend WithEvents TableAdapterManager As ReturnCarryOverDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TrailerDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
