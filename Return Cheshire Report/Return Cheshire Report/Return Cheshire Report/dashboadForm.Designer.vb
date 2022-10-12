<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class rtnDashboard
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
        Me.dashTitleLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.carryOverProgressBar = New System.Windows.Forms.ProgressBar()
        Me.carryOverLbl = New System.Windows.Forms.Label()
        Me.refreshProgressBarBtn = New System.Windows.Forms.Button()
        Me.RecordEosGoalBtn = New System.Windows.Forms.ToolStrip()
        Me.recordTruckBtn = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.recordGoal = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.viewDBtn = New System.Windows.Forms.ToolStripButton()
        Me.printReportLbl = New System.Windows.Forms.ToolStripSeparator()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.uphTitleLbl = New System.Windows.Forms.Label()
        Me.previousGoal = New System.Windows.Forms.Label()
        Me.uphGoal = New System.Windows.Forms.Label()
        Me.rtnHours = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.eosUph = New System.Windows.Forms.Label()
        Me.previousDayProgressBar = New System.Windows.Forms.ProgressBar()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.endSessionBtn = New System.Windows.Forms.Button()
        Me.TrailerDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrailerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReturnCarryOverDataSet = New Return_Cheshire_Report.ReturnCarryOverDataSet()
        Me.TrailerTableAdapter = New Return_Cheshire_Report.ReturnCarryOverDataSetTableAdapters.TrailerTableAdapter()
        Me.TableAdapterManager = New Return_Cheshire_Report.ReturnCarryOverDataSetTableAdapters.TableAdapterManager()
        Me.RecordEosGoalBtn.SuspendLayout()
        CType(Me.TrailerDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrailerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReturnCarryOverDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dashTitleLbl
        '
        Me.dashTitleLbl.AutoSize = True
        Me.dashTitleLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dashTitleLbl.ForeColor = System.Drawing.SystemColors.Highlight
        Me.dashTitleLbl.Location = New System.Drawing.Point(323, 37)
        Me.dashTitleLbl.Name = "dashTitleLbl"
        Me.dashTitleLbl.Size = New System.Drawing.Size(448, 42)
        Me.dashTitleLbl.TabIndex = 0
        Me.dashTitleLbl.Text = "RETURN DASHBOARD "
        Me.dashTitleLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 166)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Return CarryOver"
        '
        'carryOverProgressBar
        '
        Me.carryOverProgressBar.Location = New System.Drawing.Point(25, 261)
        Me.carryOverProgressBar.Name = "carryOverProgressBar"
        Me.carryOverProgressBar.Size = New System.Drawing.Size(259, 29)
        Me.carryOverProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.carryOverProgressBar.TabIndex = 2
        '
        'carryOverLbl
        '
        Me.carryOverLbl.AutoSize = True
        Me.carryOverLbl.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.carryOverLbl.ForeColor = System.Drawing.Color.Blue
        Me.carryOverLbl.Location = New System.Drawing.Point(15, 202)
        Me.carryOverLbl.Name = "carryOverLbl"
        Me.carryOverLbl.Size = New System.Drawing.Size(180, 56)
        Me.carryOverLbl.TabIndex = 4
        Me.carryOverLbl.Text = "10,545"
        Me.carryOverLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'refreshProgressBarBtn
        '
        Me.refreshProgressBarBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.refreshProgressBarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshProgressBarBtn.Location = New System.Drawing.Point(1058, 588)
        Me.refreshProgressBarBtn.Name = "refreshProgressBarBtn"
        Me.refreshProgressBarBtn.Size = New System.Drawing.Size(114, 30)
        Me.refreshProgressBarBtn.TabIndex = 3
        Me.refreshProgressBarBtn.Text = "Refresh"
        Me.refreshProgressBarBtn.UseVisualStyleBackColor = False
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
        Me.RecordEosGoalBtn.Size = New System.Drawing.Size(1184, 25)
        Me.RecordEosGoalBtn.TabIndex = 6
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 330)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Previous Day"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 400)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "HOURS"
        '
        'uphTitleLbl
        '
        Me.uphTitleLbl.AutoSize = True
        Me.uphTitleLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uphTitleLbl.Location = New System.Drawing.Point(105, 400)
        Me.uphTitleLbl.Name = "uphTitleLbl"
        Me.uphTitleLbl.Size = New System.Drawing.Size(94, 20)
        Me.uphTitleLbl.TabIndex = 9
        Me.uphTitleLbl.Text = "UPH Goal "
        '
        'previousGoal
        '
        Me.previousGoal.AutoSize = True
        Me.previousGoal.Font = New System.Drawing.Font("Consolas", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.previousGoal.ForeColor = System.Drawing.Color.RoyalBlue
        Me.previousGoal.Location = New System.Drawing.Point(20, 360)
        Me.previousGoal.Name = "previousGoal"
        Me.previousGoal.Size = New System.Drawing.Size(64, 28)
        Me.previousGoal.TabIndex = 10
        Me.previousGoal.Text = "4586"
        Me.previousGoal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'uphGoal
        '
        Me.uphGoal.AutoSize = True
        Me.uphGoal.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uphGoal.ForeColor = System.Drawing.Color.Blue
        Me.uphGoal.Location = New System.Drawing.Point(168, 420)
        Me.uphGoal.Name = "uphGoal"
        Me.uphGoal.Size = New System.Drawing.Size(27, 19)
        Me.uphGoal.TabIndex = 12
        Me.uphGoal.Text = "14"
        Me.uphGoal.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rtnHours
        '
        Me.rtnHours.AutoSize = True
        Me.rtnHours.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtnHours.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rtnHours.Location = New System.Drawing.Point(59, 420)
        Me.rtnHours.Name = "rtnHours"
        Me.rtnHours.Size = New System.Drawing.Size(36, 19)
        Me.rtnHours.TabIndex = 13
        Me.rtnHours.Text = "405"
        Me.rtnHours.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(220, 400)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 20)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "EOS UPH"
        '
        'eosUph
        '
        Me.eosUph.AutoSize = True
        Me.eosUph.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eosUph.ForeColor = System.Drawing.Color.Red
        Me.eosUph.Location = New System.Drawing.Point(281, 420)
        Me.eosUph.Name = "eosUph"
        Me.eosUph.Size = New System.Drawing.Size(27, 19)
        Me.eosUph.TabIndex = 15
        Me.eosUph.Text = "11"
        Me.eosUph.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'previousDayProgressBar
        '
        Me.previousDayProgressBar.BackColor = System.Drawing.SystemColors.Control
        Me.previousDayProgressBar.Location = New System.Drawing.Point(25, 468)
        Me.previousDayProgressBar.Name = "previousDayProgressBar"
        Me.previousDayProgressBar.Size = New System.Drawing.Size(259, 26)
        Me.previousDayProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.previousDayProgressBar.TabIndex = 16
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(900, 37)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(84, 16)
        Me.LinkLabel1.TabIndex = 17
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Adjustment" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.Location = New System.Drawing.Point(1000, 37)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(33, 16)
        Me.LinkLabel2.TabIndex = 18
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Info"
        '
        'endSessionBtn
        '
        Me.endSessionBtn.AutoSize = True
        Me.endSessionBtn.BackColor = System.Drawing.Color.Red
        Me.endSessionBtn.FlatAppearance.BorderSize = 0
        Me.endSessionBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.endSessionBtn.ForeColor = System.Drawing.Color.Black
        Me.endSessionBtn.Location = New System.Drawing.Point(1075, 0)
        Me.endSessionBtn.Name = "endSessionBtn"
        Me.endSessionBtn.Size = New System.Drawing.Size(97, 25)
        Me.endSessionBtn.TabIndex = 20
        Me.endSessionBtn.Text = "End Session"
        Me.endSessionBtn.UseVisualStyleBackColor = False
        '
        'TrailerDataGridView
        '
        Me.TrailerDataGridView.AutoGenerateColumns = False
        Me.TrailerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TrailerDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn1})
        Me.TrailerDataGridView.DataSource = Me.TrailerBindingSource
        Me.TrailerDataGridView.Location = New System.Drawing.Point(432, 202)
        Me.TrailerDataGridView.Name = "TrailerDataGridView"
        Me.TrailerDataGridView.Size = New System.Drawing.Size(740, 348)
        Me.TrailerDataGridView.TabIndex = 21
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Staging Area"
        Me.DataGridViewTextBoxColumn3.DividerWidth = 1
        Me.DataGridViewTextBoxColumn3.HeaderText = "Staging Area"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Trailer Number"
        Me.DataGridViewTextBoxColumn2.DividerWidth = 1
        Me.DataGridViewTextBoxColumn2.HeaderText = "Trailer Number"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Carrier"
        Me.DataGridViewTextBoxColumn4.DividerWidth = 1
        Me.DataGridViewTextBoxColumn4.HeaderText = "Carrier"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Carton Count"
        Me.DataGridViewTextBoxColumn5.DividerWidth = 1
        Me.DataGridViewTextBoxColumn5.HeaderText = "Carton Count"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "DropOff Date"
        Me.DataGridViewTextBoxColumn6.DividerWidth = 1
        Me.DataGridViewTextBoxColumn6.HeaderText = "DropOff Date"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Units Count"
        Me.DataGridViewTextBoxColumn7.DividerWidth = 1
        Me.DataGridViewTextBoxColumn7.HeaderText = "Units Count"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.DividerWidth = 1
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TrailerBindingSource
        '
        Me.TrailerBindingSource.DataMember = "Trailer"
        Me.TrailerBindingSource.DataSource = Me.ReturnCarryOverDataSet
        '
        'ReturnCarryOverDataSet
        '
        Me.ReturnCarryOverDataSet.DataSetName = "ReturnCarryOverDataSet"
        Me.ReturnCarryOverDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TrailerTableAdapter
        '
        Me.TrailerTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.employeeTableAdapter = Nothing
        Me.TableAdapterManager.TrailerTableAdapter = Me.TrailerTableAdapter
        Me.TableAdapterManager.UpdateOrder = Return_Cheshire_Report.ReturnCarryOverDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'rtnDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.TrailerDataGridView)
        Me.Controls.Add(Me.endSessionBtn)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.previousDayProgressBar)
        Me.Controls.Add(Me.eosUph)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.rtnHours)
        Me.Controls.Add(Me.uphGoal)
        Me.Controls.Add(Me.previousGoal)
        Me.Controls.Add(Me.uphTitleLbl)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RecordEosGoalBtn)
        Me.Controls.Add(Me.carryOverLbl)
        Me.Controls.Add(Me.refreshProgressBarBtn)
        Me.Controls.Add(Me.carryOverProgressBar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dashTitleLbl)
        Me.Name = "rtnDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RETURN DASHBOARD"
        Me.RecordEosGoalBtn.ResumeLayout(False)
        Me.RecordEosGoalBtn.PerformLayout()
        CType(Me.TrailerDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrailerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReturnCarryOverDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dashTitleLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents carryOverProgressBar As ProgressBar
    Friend WithEvents carryOverLbl As Label
    Friend WithEvents refreshProgressBarBtn As Button
    Friend WithEvents RecordEosGoalBtn As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents printReportLbl As ToolStripSeparator
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents uphTitleLbl As Label
    Friend WithEvents previousGoal As Label
    Friend WithEvents uphGoal As Label
    Friend WithEvents rtnHours As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents eosUph As Label
    Friend WithEvents previousDayProgressBar As ProgressBar
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents recordTruckBtn As ToolStripButton
    Friend WithEvents recordGoal As ToolStripButton
    Friend WithEvents viewDBtn As ToolStripButton
    Friend WithEvents endSessionBtn As Button
    Friend WithEvents ReturnCarryOverDataSet As ReturnCarryOverDataSet
    Friend WithEvents TrailerBindingSource As BindingSource
    Friend WithEvents TrailerTableAdapter As ReturnCarryOverDataSetTableAdapters.TrailerTableAdapter
    Friend WithEvents TableAdapterManager As ReturnCarryOverDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TrailerDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
