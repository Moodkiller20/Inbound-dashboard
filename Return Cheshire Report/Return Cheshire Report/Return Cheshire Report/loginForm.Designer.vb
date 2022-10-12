<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginForm))
        Me.userIdTxt = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.pswTxt = New System.Windows.Forms.TextBox()
        Me.idLbl = New System.Windows.Forms.Label()
        Me.pwsLbl = New System.Windows.Forms.Label()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.forgotPswLink = New System.Windows.Forms.LinkLabel()
        Me.loginAvatar = New System.Windows.Forms.PictureBox()
        CType(Me.loginAvatar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'userIdTxt
        '
        Me.userIdTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.userIdTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userIdTxt.Location = New System.Drawing.Point(486, 171)
        Me.userIdTxt.Multiline = True
        Me.userIdTxt.Name = "userIdTxt"
        Me.userIdTxt.Size = New System.Drawing.Size(250, 30)
        Me.userIdTxt.TabIndex = 1
        Me.userIdTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'pswTxt
        '
        Me.pswTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pswTxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pswTxt.Location = New System.Drawing.Point(486, 276)
        Me.pswTxt.Name = "pswTxt"
        Me.pswTxt.Size = New System.Drawing.Size(250, 29)
        Me.pswTxt.TabIndex = 3
        Me.pswTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.pswTxt.UseSystemPasswordChar = True
        '
        'idLbl
        '
        Me.idLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idLbl.Location = New System.Drawing.Point(483, 133)
        Me.idLbl.Name = "idLbl"
        Me.idLbl.Size = New System.Drawing.Size(271, 35)
        Me.idLbl.TabIndex = 4
        Me.idLbl.Text = "User ID / Employee ID "
        Me.idLbl.UseMnemonic = False
        '
        'pwsLbl
        '
        Me.pwsLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pwsLbl.Location = New System.Drawing.Point(483, 238)
        Me.pwsLbl.Name = "pwsLbl"
        Me.pwsLbl.Size = New System.Drawing.Size(271, 35)
        Me.pwsLbl.TabIndex = 5
        Me.pwsLbl.Text = "Password"
        Me.pwsLbl.UseMnemonic = False
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.AliceBlue
        Me.loginBtn.Location = New System.Drawing.Point(598, 345)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(136, 41)
        Me.loginBtn.TabIndex = 6
        Me.loginBtn.Text = "Login "
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'forgotPswLink
        '
        Me.forgotPswLink.AutoSize = True
        Me.forgotPswLink.Location = New System.Drawing.Point(481, 420)
        Me.forgotPswLink.Name = "forgotPswLink"
        Me.forgotPswLink.Size = New System.Drawing.Size(265, 16)
        Me.forgotPswLink.TabIndex = 7
        Me.forgotPswLink.TabStop = True
        Me.forgotPswLink.Text = "Forgot Password/ Unlock my Account"
        '
        'loginAvatar
        '
        Me.loginAvatar.Cursor = System.Windows.Forms.Cursors.No
        Me.loginAvatar.Image = CType(resources.GetObject("loginAvatar.Image"), System.Drawing.Image)
        Me.loginAvatar.Location = New System.Drawing.Point(248, 133)
        Me.loginAvatar.Name = "loginAvatar"
        Me.loginAvatar.Size = New System.Drawing.Size(229, 222)
        Me.loginAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.loginAvatar.TabIndex = 8
        Me.loginAvatar.TabStop = False
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.loginAvatar)
        Me.Controls.Add(Me.forgotPswLink)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.pwsLbl)
        Me.Controls.Add(Me.idLbl)
        Me.Controls.Add(Me.pswTxt)
        Me.Controls.Add(Me.userIdTxt)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "loginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Return Cheshire Report - Login"
        CType(Me.loginAvatar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub

    Friend WithEvents userIdTxt As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents pswTxt As TextBox
    Friend WithEvents idLbl As Label
    Friend WithEvents pwsLbl As Label
    Friend WithEvents loginBtn As Button
    Friend WithEvents forgotPswLink As LinkLabel
    Friend WithEvents loginAvatar As PictureBox
End Class
