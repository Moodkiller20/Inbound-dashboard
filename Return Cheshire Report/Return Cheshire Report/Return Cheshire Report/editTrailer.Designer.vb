<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editTrailer
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.StagingZone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrailerNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CartonCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitCount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateRcv = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employeeEntry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lastUpdate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.refreshProgressBarBtn = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.userIdTxt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StagingZone, Me.TrailerNumber, Me.CartonCount, Me.unitCount, Me.DateRcv, Me.employeeEntry, Me.lastUpdate})
        Me.DataGridView1.Location = New System.Drawing.Point(54, 204)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(737, 109)
        Me.DataGridView1.TabIndex = 9
        '
        'StagingZone
        '
        Me.StagingZone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.StagingZone.HeaderText = "Staging Area"
        Me.StagingZone.Name = "StagingZone"
        Me.StagingZone.ReadOnly = True
        Me.StagingZone.Width = 93
        '
        'TrailerNumber
        '
        Me.TrailerNumber.HeaderText = "Trailer #"
        Me.TrailerNumber.Name = "TrailerNumber"
        Me.TrailerNumber.ReadOnly = True
        '
        'CartonCount
        '
        Me.CartonCount.HeaderText = "Carton Count"
        Me.CartonCount.Name = "CartonCount"
        Me.CartonCount.ReadOnly = True
        '
        'unitCount
        '
        Me.unitCount.HeaderText = "Unit Count"
        Me.unitCount.Name = "unitCount"
        Me.unitCount.ReadOnly = True
        '
        'DateRcv
        '
        Me.DateRcv.HeaderText = "Date"
        Me.DateRcv.Name = "DateRcv"
        Me.DateRcv.ReadOnly = True
        '
        'employeeEntry
        '
        Me.employeeEntry.HeaderText = "Employee"
        Me.employeeEntry.Name = "employeeEntry"
        Me.employeeEntry.ReadOnly = True
        '
        'lastUpdate
        '
        Me.lastUpdate.HeaderText = "last update"
        Me.lastUpdate.Name = "lastUpdate"
        Me.lastUpdate.ReadOnly = True
        '
        'refreshProgressBarBtn
        '
        Me.refreshProgressBarBtn.BackColor = System.Drawing.Color.White
        Me.refreshProgressBarBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.refreshProgressBarBtn.Location = New System.Drawing.Point(677, 137)
        Me.refreshProgressBarBtn.Name = "refreshProgressBarBtn"
        Me.refreshProgressBarBtn.Size = New System.Drawing.Size(114, 30)
        Me.refreshProgressBarBtn.TabIndex = 30
        Me.refreshProgressBarBtn.Text = "Search"
        Me.refreshProgressBarBtn.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(508, 134)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(123, 22)
        Me.TextBox1.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(383, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Carton Count"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DateTimePicker1.Location = New System.Drawing.Point(508, 106)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(123, 20)
        Me.DateTimePicker1.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(383, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Dropoff Date "
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"RCV YARD ", "DOOR 1", "DOOR 2", "DOOR 3", "DOOR 4", "DOOR 5", "DOOR 6", "DOOR 7", "DOOR 7", "DOOR 8", "DOOR 9", "DOOR 10", "DOOR 11", "DOOR 12", "DOOR 13", "DOOR 14", "DOOR 15", "DOOR 16", "SAY"})
        Me.ComboBox1.Location = New System.Drawing.Point(226, 136)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(123, 21)
        Me.ComboBox1.TabIndex = 25
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(97, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Staging Area"
        '
        'userIdTxt
        '
        Me.userIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.userIdTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userIdTxt.Location = New System.Drawing.Point(226, 99)
        Me.userIdTxt.Name = "userIdTxt"
        Me.userIdTxt.Size = New System.Drawing.Size(123, 22)
        Me.userIdTxt.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(85, 104)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Trailer Number"
        '
        'Button2
        '
        Me.Button2.AutoSize = True
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(573, 424)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(98, 30)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.AutoSize = True
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(683, 424)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 30)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Save Data "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.AutoSize = True
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(693, 319)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(98, 30)
        Me.Button3.TabIndex = 33
        Me.Button3.Text = "Delete"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'editTrailer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ClientSize = New System.Drawing.Size(865, 479)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.refreshProgressBarBtn)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.userIdTxt)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "editTrailer"
        Me.Text = "Edit Trailer Information"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents StagingZone As DataGridViewTextBoxColumn
    Friend WithEvents TrailerNumber As DataGridViewTextBoxColumn
    Friend WithEvents CartonCount As DataGridViewTextBoxColumn
    Friend WithEvents unitCount As DataGridViewTextBoxColumn
    Friend WithEvents DateRcv As DataGridViewTextBoxColumn
    Friend WithEvents employeeEntry As DataGridViewTextBoxColumn
    Friend WithEvents lastUpdate As DataGridViewTextBoxColumn
    Friend WithEvents refreshProgressBarBtn As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents userIdTxt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
