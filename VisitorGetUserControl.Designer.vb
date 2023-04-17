<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisitorGetUserControl
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
        Me.PnlVisitorName = New System.Windows.Forms.Panel()
        Me.TxtVisitorName = New System.Windows.Forms.TextBox()
        Me.LblVisitorName = New System.Windows.Forms.Label()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.LblVisitorId = New System.Windows.Forms.Label()
        Me.PnlVisitorId = New System.Windows.Forms.Panel()
        Me.TxtVisitorId = New System.Windows.Forms.TextBox()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.PnlPassword = New System.Windows.Forms.Panel()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.LblPassword = New System.Windows.Forms.Label()
        Me.PnlKeycard = New System.Windows.Forms.Panel()
        Me.TxtKeycard = New System.Windows.Forms.TextBox()
        Me.LblKeycard = New System.Windows.Forms.Label()
        Me.PnlVisitorName.SuspendLayout()
        Me.PnlVisitorId.SuspendLayout()
        Me.PnlPassword.SuspendLayout()
        Me.PnlKeycard.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlVisitorName
        '
        Me.PnlVisitorName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PnlVisitorName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlVisitorName.Controls.Add(Me.TxtVisitorName)
        Me.PnlVisitorName.Location = New System.Drawing.Point(155, 238)
        Me.PnlVisitorName.Name = "PnlVisitorName"
        Me.PnlVisitorName.Size = New System.Drawing.Size(300, 35)
        Me.PnlVisitorName.TabIndex = 23
        '
        'TxtVisitorName
        '
        Me.TxtVisitorName.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtVisitorName.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtVisitorName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtVisitorName.Location = New System.Drawing.Point(9, 9)
        Me.TxtVisitorName.Margin = New System.Windows.Forms.Padding(10)
        Me.TxtVisitorName.Name = "TxtVisitorName"
        Me.TxtVisitorName.Size = New System.Drawing.Size(280, 15)
        Me.TxtVisitorName.TabIndex = 0
        '
        'LblVisitorName
        '
        Me.LblVisitorName.AutoSize = True
        Me.LblVisitorName.BackColor = System.Drawing.Color.Transparent
        Me.LblVisitorName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblVisitorName.ForeColor = System.Drawing.Color.Gold
        Me.LblVisitorName.Location = New System.Drawing.Point(155, 221)
        Me.LblVisitorName.Name = "LblVisitorName"
        Me.LblVisitorName.Size = New System.Drawing.Size(86, 14)
        Me.LblVisitorName.TabIndex = 21
        Me.LblVisitorName.Text = "Visitor Name"
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.Gold
        Me.BtnNext.FlatAppearance.BorderSize = 0
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNext.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnNext.ForeColor = System.Drawing.Color.Navy
        Me.BtnNext.Location = New System.Drawing.Point(155, 334)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(300, 35)
        Me.BtnNext.TabIndex = 22
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'LblVisitorId
        '
        Me.LblVisitorId.AutoSize = True
        Me.LblVisitorId.BackColor = System.Drawing.Color.Transparent
        Me.LblVisitorId.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblVisitorId.ForeColor = System.Drawing.Color.Gold
        Me.LblVisitorId.Location = New System.Drawing.Point(155, 166)
        Me.LblVisitorId.Name = "LblVisitorId"
        Me.LblVisitorId.Size = New System.Drawing.Size(63, 14)
        Me.LblVisitorId.TabIndex = 24
        Me.LblVisitorId.Text = "Visitor Id"
        '
        'PnlVisitorId
        '
        Me.PnlVisitorId.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PnlVisitorId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlVisitorId.Controls.Add(Me.TxtVisitorId)
        Me.PnlVisitorId.Location = New System.Drawing.Point(155, 183)
        Me.PnlVisitorId.Name = "PnlVisitorId"
        Me.PnlVisitorId.Size = New System.Drawing.Size(300, 35)
        Me.PnlVisitorId.TabIndex = 25
        '
        'TxtVisitorId
        '
        Me.TxtVisitorId.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtVisitorId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtVisitorId.Enabled = False
        Me.TxtVisitorId.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtVisitorId.Location = New System.Drawing.Point(9, 9)
        Me.TxtVisitorId.Margin = New System.Windows.Forms.Padding(10)
        Me.TxtVisitorId.Name = "TxtVisitorId"
        Me.TxtVisitorId.Size = New System.Drawing.Size(280, 15)
        Me.TxtVisitorId.TabIndex = 0
        '
        'BtnBack
        '
        Me.BtnBack.BackColor = System.Drawing.Color.Navy
        Me.BtnBack.FlatAppearance.BorderColor = System.Drawing.Color.Gold
        Me.BtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBack.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnBack.ForeColor = System.Drawing.Color.Gold
        Me.BtnBack.Location = New System.Drawing.Point(155, 269)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(150, 35)
        Me.BtnBack.TabIndex = 27
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'BtnSubmit
        '
        Me.BtnSubmit.BackColor = System.Drawing.Color.Gold
        Me.BtnSubmit.FlatAppearance.BorderSize = 0
        Me.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubmit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnSubmit.ForeColor = System.Drawing.Color.Navy
        Me.BtnSubmit.Location = New System.Drawing.Point(304, 269)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(150, 35)
        Me.BtnSubmit.TabIndex = 26
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = False
        '
        'PnlPassword
        '
        Me.PnlPassword.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PnlPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlPassword.Controls.Add(Me.TxtPassword)
        Me.PnlPassword.Location = New System.Drawing.Point(155, 293)
        Me.PnlPassword.Name = "PnlPassword"
        Me.PnlPassword.Size = New System.Drawing.Size(300, 35)
        Me.PnlPassword.TabIndex = 29
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtPassword.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtPassword.Location = New System.Drawing.Point(9, 9)
        Me.TxtPassword.Margin = New System.Windows.Forms.Padding(10)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtPassword.Size = New System.Drawing.Size(280, 15)
        Me.TxtPassword.TabIndex = 0
        '
        'LblPassword
        '
        Me.LblPassword.AutoSize = True
        Me.LblPassword.BackColor = System.Drawing.Color.Transparent
        Me.LblPassword.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblPassword.ForeColor = System.Drawing.Color.Gold
        Me.LblPassword.Location = New System.Drawing.Point(155, 276)
        Me.LblPassword.Name = "LblPassword"
        Me.LblPassword.Size = New System.Drawing.Size(111, 14)
        Me.LblPassword.TabIndex = 28
        Me.LblPassword.Text = "Admin Password"
        '
        'PnlKeycard
        '
        Me.PnlKeycard.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PnlKeycard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlKeycard.Controls.Add(Me.TxtKeycard)
        Me.PnlKeycard.Location = New System.Drawing.Point(155, 228)
        Me.PnlKeycard.Name = "PnlKeycard"
        Me.PnlKeycard.Size = New System.Drawing.Size(300, 35)
        Me.PnlKeycard.TabIndex = 30
        '
        'TxtKeycard
        '
        Me.TxtKeycard.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtKeycard.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtKeycard.Enabled = False
        Me.TxtKeycard.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtKeycard.Location = New System.Drawing.Point(9, 9)
        Me.TxtKeycard.Margin = New System.Windows.Forms.Padding(10)
        Me.TxtKeycard.Name = "TxtKeycard"
        Me.TxtKeycard.Size = New System.Drawing.Size(280, 15)
        Me.TxtKeycard.TabIndex = 0
        '
        'LblKeycard
        '
        Me.LblKeycard.AutoSize = True
        Me.LblKeycard.BackColor = System.Drawing.Color.Transparent
        Me.LblKeycard.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblKeycard.ForeColor = System.Drawing.Color.Gold
        Me.LblKeycard.Location = New System.Drawing.Point(155, 211)
        Me.LblKeycard.Name = "LblKeycard"
        Me.LblKeycard.Size = New System.Drawing.Size(101, 14)
        Me.LblKeycard.TabIndex = 31
        Me.LblKeycard.Text = "Locker Number"
        '
        'VisitorGetUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.Controls.Add(Me.PnlPassword)
        Me.Controls.Add(Me.LblPassword)
        Me.Controls.Add(Me.LblVisitorName)
        Me.Controls.Add(Me.LblVisitorId)
        Me.Controls.Add(Me.PnlVisitorId)
        Me.Controls.Add(Me.BtnNext)
        Me.Controls.Add(Me.LblKeycard)
        Me.Controls.Add(Me.PnlVisitorName)
        Me.Controls.Add(Me.BtnBack)
        Me.Controls.Add(Me.BtnSubmit)
        Me.Controls.Add(Me.PnlKeycard)
        Me.name = "VisitorGetUserControl"
        Me.Size = New System.Drawing.Size(604, 558)
        Me.PnlVisitorName.ResumeLayout(False)
        Me.PnlVisitorName.PerformLayout()
        Me.PnlVisitorId.ResumeLayout(False)
        Me.PnlVisitorId.PerformLayout()
        Me.PnlPassword.ResumeLayout(False)
        Me.PnlPassword.PerformLayout()
        Me.PnlKeycard.ResumeLayout(False)
        Me.PnlKeycard.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlVisitorName As Panel
    Friend WithEvents TxtVisitorName As TextBox
    Friend WithEvents LblVisitorName As Label
    Friend WithEvents BtnNext As Button
    Friend WithEvents LblVisitorId As Label
    Friend WithEvents PnlVisitorId As Panel
    Friend WithEvents TxtVisitorId As TextBox
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents PnlPassword As Panel
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents LblPassword As Label
    Friend WithEvents PnlKeycard As Panel
    Friend WithEvents TxtKeycard As TextBox
    Friend WithEvents LblKeycard As Label
End Class
