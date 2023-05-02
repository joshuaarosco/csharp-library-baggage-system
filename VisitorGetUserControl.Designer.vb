Imports System.IO.Ports

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        components = New ComponentModel.Container()
        PnlVisitorName = New Panel()
        TxtVisitorName = New TextBox()
        LblVisitorName = New Label()
        BtnNext = New Button()
        LblVisitorId = New Label()
        PnlVisitorId = New Panel()
        TxtVisitorId = New TextBox()
        BtnBack = New Button()
        BtnSubmit = New Button()
        PnlPassword = New Panel()
        TxtPassword = New TextBox()
        LblPassword = New Label()
        LblVisitor = New Label()
        PnlVisitorInput = New Panel()
        PnlVisitorInfo = New Panel()
        Panel1 = New Panel()
        Label1 = New Label()
        LblVisitorInfoName = New Label()
        TxtKeycard = New TextBox()
        TimerVisitor = New Timer(components)
        Panel2 = New Panel()
        PnlVisitorName.SuspendLayout()
        PnlVisitorId.SuspendLayout()
        PnlPassword.SuspendLayout()
        PnlVisitorInput.SuspendLayout()
        PnlVisitorInfo.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PnlVisitorName
        ' 
        PnlVisitorName.BackColor = SystemColors.ControlLightLight
        PnlVisitorName.BorderStyle = BorderStyle.FixedSingle
        PnlVisitorName.Controls.Add(TxtVisitorName)
        PnlVisitorName.Location = New Point(18, 94)
        PnlVisitorName.Name = "PnlVisitorName"
        PnlVisitorName.Size = New Size(300, 35)
        PnlVisitorName.TabIndex = 23
        ' 
        ' TxtVisitorName
        ' 
        TxtVisitorName.BackColor = SystemColors.ControlLightLight
        TxtVisitorName.BorderStyle = BorderStyle.None
        TxtVisitorName.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TxtVisitorName.Location = New Point(9, 9)
        TxtVisitorName.Margin = New Padding(10)
        TxtVisitorName.Name = "TxtVisitorName"
        TxtVisitorName.Size = New Size(280, 15)
        TxtVisitorName.TabIndex = 0
        ' 
        ' LblVisitorName
        ' 
        LblVisitorName.AutoSize = True
        LblVisitorName.BackColor = Color.Transparent
        LblVisitorName.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LblVisitorName.ForeColor = Color.Gold
        LblVisitorName.Location = New Point(18, 77)
        LblVisitorName.Name = "LblVisitorName"
        LblVisitorName.Size = New Size(86, 14)
        LblVisitorName.TabIndex = 21
        LblVisitorName.Text = "Visitor Name"
        ' 
        ' BtnNext
        ' 
        BtnNext.BackColor = Color.Gold
        BtnNext.FlatAppearance.BorderSize = 0
        BtnNext.FlatStyle = FlatStyle.Flat
        BtnNext.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        BtnNext.ForeColor = Color.Navy
        BtnNext.Location = New Point(18, 190)
        BtnNext.Name = "BtnNext"
        BtnNext.Size = New Size(300, 35)
        BtnNext.TabIndex = 22
        BtnNext.Text = "Next"
        BtnNext.UseVisualStyleBackColor = False
        ' 
        ' LblVisitorId
        ' 
        LblVisitorId.AutoSize = True
        LblVisitorId.BackColor = Color.Transparent
        LblVisitorId.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LblVisitorId.ForeColor = Color.Gold
        LblVisitorId.Location = New Point(18, 22)
        LblVisitorId.Name = "LblVisitorId"
        LblVisitorId.Size = New Size(63, 14)
        LblVisitorId.TabIndex = 24
        LblVisitorId.Text = "Visitor Id"
        ' 
        ' PnlVisitorId
        ' 
        PnlVisitorId.BackColor = SystemColors.ControlLightLight
        PnlVisitorId.BorderStyle = BorderStyle.FixedSingle
        PnlVisitorId.Controls.Add(TxtVisitorId)
        PnlVisitorId.Location = New Point(18, 39)
        PnlVisitorId.Name = "PnlVisitorId"
        PnlVisitorId.Size = New Size(300, 35)
        PnlVisitorId.TabIndex = 25
        ' 
        ' TxtVisitorId
        ' 
        TxtVisitorId.BackColor = SystemColors.ControlLightLight
        TxtVisitorId.BorderStyle = BorderStyle.None
        TxtVisitorId.Enabled = False
        TxtVisitorId.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TxtVisitorId.Location = New Point(9, 9)
        TxtVisitorId.Margin = New Padding(10)
        TxtVisitorId.Name = "TxtVisitorId"
        TxtVisitorId.Size = New Size(280, 15)
        TxtVisitorId.TabIndex = 0
        ' 
        ' BtnBack
        ' 
        BtnBack.BackColor = Color.Gold
        BtnBack.FlatAppearance.BorderColor = Color.Gold
        BtnBack.FlatStyle = FlatStyle.Flat
        BtnBack.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        BtnBack.ForeColor = Color.Navy
        BtnBack.Location = New Point(18, 167)
        BtnBack.Name = "BtnBack"
        BtnBack.Size = New Size(299, 35)
        BtnBack.TabIndex = 27
        BtnBack.Text = "Back"
        BtnBack.UseVisualStyleBackColor = False
        ' 
        ' BtnSubmit
        ' 
        BtnSubmit.BackColor = Color.Gold
        BtnSubmit.FlatAppearance.BorderSize = 0
        BtnSubmit.FlatStyle = FlatStyle.Flat
        BtnSubmit.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        BtnSubmit.ForeColor = Color.Navy
        BtnSubmit.Location = New Point(167, 167)
        BtnSubmit.Name = "BtnSubmit"
        BtnSubmit.Size = New Size(150, 35)
        BtnSubmit.TabIndex = 26
        BtnSubmit.Text = "Submit"
        BtnSubmit.UseVisualStyleBackColor = False
        ' 
        ' PnlPassword
        ' 
        PnlPassword.BackColor = SystemColors.ControlLightLight
        PnlPassword.BorderStyle = BorderStyle.FixedSingle
        PnlPassword.Controls.Add(TxtPassword)
        PnlPassword.Location = New Point(18, 149)
        PnlPassword.Name = "PnlPassword"
        PnlPassword.Size = New Size(300, 35)
        PnlPassword.TabIndex = 29
        ' 
        ' TxtPassword
        ' 
        TxtPassword.BackColor = SystemColors.ControlLightLight
        TxtPassword.BorderStyle = BorderStyle.None
        TxtPassword.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TxtPassword.Location = New Point(9, 9)
        TxtPassword.Margin = New Padding(10)
        TxtPassword.Name = "TxtPassword"
        TxtPassword.PasswordChar = "•"c
        TxtPassword.Size = New Size(280, 15)
        TxtPassword.TabIndex = 0
        ' 
        ' LblPassword
        ' 
        LblPassword.AutoSize = True
        LblPassword.BackColor = Color.Transparent
        LblPassword.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LblPassword.ForeColor = Color.Gold
        LblPassword.Location = New Point(18, 132)
        LblPassword.Name = "LblPassword"
        LblPassword.Size = New Size(111, 14)
        LblPassword.TabIndex = 28
        LblPassword.Text = "Admin Password"
        ' 
        ' LblVisitor
        ' 
        LblVisitor.AutoSize = True
        LblVisitor.BackColor = Color.Transparent
        LblVisitor.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LblVisitor.ForeColor = Color.Gold
        LblVisitor.Location = New Point(18, 109)
        LblVisitor.Name = "LblVisitor"
        LblVisitor.Size = New Size(59, 14)
        LblVisitor.TabIndex = 31
        LblVisitor.Text = "Visitor : "
        ' 
        ' PnlVisitorInput
        ' 
        PnlVisitorInput.BackColor = Color.Navy
        PnlVisitorInput.Controls.Add(PnlPassword)
        PnlVisitorInput.Controls.Add(LblVisitorId)
        PnlVisitorInput.Controls.Add(LblPassword)
        PnlVisitorInput.Controls.Add(PnlVisitorName)
        PnlVisitorInput.Controls.Add(LblVisitorName)
        PnlVisitorInput.Controls.Add(BtnNext)
        PnlVisitorInput.Controls.Add(PnlVisitorId)
        PnlVisitorInput.Location = New Point(133, 167)
        PnlVisitorInput.Name = "PnlVisitorInput"
        PnlVisitorInput.Size = New Size(339, 245)
        PnlVisitorInput.TabIndex = 32
        ' 
        ' PnlVisitorInfo
        ' 
        PnlVisitorInfo.BackColor = Color.Navy
        PnlVisitorInfo.Controls.Add(Panel1)
        PnlVisitorInfo.Controls.Add(LblVisitorInfoName)
        PnlVisitorInfo.Controls.Add(LblVisitor)
        PnlVisitorInfo.Controls.Add(BtnBack)
        PnlVisitorInfo.Controls.Add(BtnSubmit)
        PnlVisitorInfo.Controls.Add(TxtKeycard)
        PnlVisitorInfo.Location = New Point(133, 167)
        PnlVisitorInfo.Name = "PnlVisitorInfo"
        PnlVisitorInfo.Size = New Size(339, 245)
        PnlVisitorInfo.TabIndex = 33
        ' 
        ' Panel1
        ' 
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(18, 53)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(305, 35)
        Panel1.TabIndex = 34
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.Gold
        Label1.Location = New Point(4, 10)
        Label1.Name = "Label1"
        Label1.Size = New Size(229, 14)
        Label1.TabIndex = 33
        Label1.Text = "Please tap a keycard for the visitor."
        ' 
        ' LblVisitorInfoName
        ' 
        LblVisitorInfoName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LblVisitorInfoName.AutoSize = True
        LblVisitorInfoName.BackColor = Color.Transparent
        LblVisitorInfoName.Font = New Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point)
        LblVisitorInfoName.ForeColor = Color.Gold
        LblVisitorInfoName.Location = New Point(18, 126)
        LblVisitorInfoName.Name = "LblVisitorInfoName"
        LblVisitorInfoName.Size = New Size(230, 29)
        LblVisitorInfoName.TabIndex = 32
        LblVisitorInfoName.Text = "Jhaymark Lopez"
        ' 
        ' TxtKeycard
        ' 
        TxtKeycard.BackColor = SystemColors.ControlLightLight
        TxtKeycard.BorderStyle = BorderStyle.None
        TxtKeycard.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TxtKeycard.Location = New Point(18, 167)
        TxtKeycard.Margin = New Padding(10)
        TxtKeycard.Multiline = True
        TxtKeycard.Name = "TxtKeycard"
        TxtKeycard.Size = New Size(299, 35)
        TxtKeycard.TabIndex = 1
        ' 
        ' TimerVisitor
        ' 
        TimerVisitor.Interval = 1000
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.Navy
        Panel2.Location = New Point(0, 49)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(604, 516)
        Panel2.TabIndex = 34
        ' 
        ' VisitorGetUserControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gold
        Controls.Add(PnlVisitorInfo)
        Controls.Add(PnlVisitorInput)
        Controls.Add(Panel2)
        Name = "VisitorGetUserControl"
        Size = New Size(604, 558)
        PnlVisitorName.ResumeLayout(False)
        PnlVisitorName.PerformLayout()
        PnlVisitorId.ResumeLayout(False)
        PnlVisitorId.PerformLayout()
        PnlPassword.ResumeLayout(False)
        PnlPassword.PerformLayout()
        PnlVisitorInput.ResumeLayout(False)
        PnlVisitorInput.PerformLayout()
        PnlVisitorInfo.ResumeLayout(False)
        PnlVisitorInfo.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
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
    Friend WithEvents LblVisitor As Label
    Friend WithEvents PnlVisitorInput As Panel
    Friend WithEvents PnlVisitorInfo As Panel
    Friend WithEvents TxtKeycard As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LblVisitorInfoName As Label
    Friend WithEvents TimerVisitor As Timer
    Friend WithEvents Panel2 As Panel
End Class
