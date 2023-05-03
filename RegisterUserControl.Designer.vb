<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterUserControl
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
        PnlMenu = New Panel()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        BtnUser = New Button()
        BtnLocker = New Button()
        BtnKey = New Button()
        LblVisitorInfoName = New Label()
        PnlNewUser = New Panel()
        BtnUserBack = New Button()
        Panel2 = New Panel()
        TxtRFID = New TextBox()
        Label5 = New Label()
        Panel1 = New Panel()
        TxtName = New TextBox()
        Label4 = New Label()
        PnlPassword = New Panel()
        TxtKeycard = New TextBox()
        PnlVisitorName = New Panel()
        TxtStudentId = New TextBox()
        BtnAddUser = New Button()
        LblVisitorName = New Label()
        PnlNewKey = New Panel()
        BtnKeyBack = New Button()
        Panel4 = New Panel()
        TxtKeyRFID = New TextBox()
        Label6 = New Label()
        Panel6 = New Panel()
        TxtKeyName = New TextBox()
        Label8 = New Label()
        BtnAddKey = New Button()
        TimerRegisterUserControl = New Timer(components)
        PnlNewLocker = New Panel()
        BtnLockerBack = New Button()
        Panel5 = New Panel()
        TxtLockerNumber = New TextBox()
        Label7 = New Label()
        BtnAddLocker = New Button()
        PnlMenu.SuspendLayout()
        PnlNewUser.SuspendLayout()
        Panel2.SuspendLayout()
        Panel1.SuspendLayout()
        PnlPassword.SuspendLayout()
        PnlVisitorName.SuspendLayout()
        PnlNewKey.SuspendLayout()
        Panel4.SuspendLayout()
        Panel6.SuspendLayout()
        PnlNewLocker.SuspendLayout()
        Panel5.SuspendLayout()
        SuspendLayout()
        ' 
        ' PnlMenu
        ' 
        PnlMenu.BackColor = Color.Navy
        PnlMenu.Controls.Add(Label3)
        PnlMenu.Controls.Add(Label2)
        PnlMenu.Controls.Add(Label1)
        PnlMenu.Controls.Add(BtnUser)
        PnlMenu.Controls.Add(BtnLocker)
        PnlMenu.Controls.Add(BtnKey)
        PnlMenu.Location = New Point(0, 49)
        PnlMenu.Name = "PnlMenu"
        PnlMenu.Size = New Size(604, 516)
        PnlMenu.TabIndex = 0
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.AliceBlue
        Label3.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(304, 244)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 14)
        Label3.TabIndex = 39
        Label3.Text = "Locker"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.AliceBlue
        Label2.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(304, 152)
        Label2.Name = "Label2"
        Label2.Size = New Size(30, 14)
        Label2.TabIndex = 38
        Label2.Text = "Key"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.AliceBlue
        Label1.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(127, 152)
        Label1.Name = "Label1"
        Label1.Size = New Size(36, 14)
        Label1.TabIndex = 37
        Label1.Text = "User"
        ' 
        ' BtnUser
        ' 
        BtnUser.BackColor = Color.AliceBlue
        BtnUser.BackgroundImage = My.Resources.Resources.user_icon
        BtnUser.BackgroundImageLayout = ImageLayout.Zoom
        BtnUser.FlatStyle = FlatStyle.Flat
        BtnUser.Location = New Point(121, 145)
        BtnUser.Name = "BtnUser"
        BtnUser.Size = New Size(170, 172)
        BtnUser.TabIndex = 40
        BtnUser.UseVisualStyleBackColor = False
        ' 
        ' BtnLocker
        ' 
        BtnLocker.BackColor = Color.AliceBlue
        BtnLocker.BackgroundImage = My.Resources.Resources.locker_icon
        BtnLocker.BackgroundImageLayout = ImageLayout.Zoom
        BtnLocker.FlatStyle = FlatStyle.Flat
        BtnLocker.Location = New Point(297, 237)
        BtnLocker.Name = "BtnLocker"
        BtnLocker.Size = New Size(170, 80)
        BtnLocker.TabIndex = 41
        BtnLocker.UseVisualStyleBackColor = False
        ' 
        ' BtnKey
        ' 
        BtnKey.BackColor = Color.AliceBlue
        BtnKey.BackgroundImage = My.Resources.Resources.keycard_icon
        BtnKey.BackgroundImageLayout = ImageLayout.Zoom
        BtnKey.FlatStyle = FlatStyle.Flat
        BtnKey.Location = New Point(297, 145)
        BtnKey.Name = "BtnKey"
        BtnKey.Size = New Size(170, 80)
        BtnKey.TabIndex = 42
        BtnKey.UseVisualStyleBackColor = False
        ' 
        ' LblVisitorInfoName
        ' 
        LblVisitorInfoName.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LblVisitorInfoName.AutoSize = True
        LblVisitorInfoName.BackColor = Color.Transparent
        LblVisitorInfoName.Font = New Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point)
        LblVisitorInfoName.ForeColor = Color.Navy
        LblVisitorInfoName.Location = New Point(3, 3)
        LblVisitorInfoName.Name = "LblVisitorInfoName"
        LblVisitorInfoName.Size = New Size(134, 29)
        LblVisitorInfoName.TabIndex = 33
        LblVisitorInfoName.Text = "Add New"
        ' 
        ' PnlNewUser
        ' 
        PnlNewUser.BackColor = Color.Navy
        PnlNewUser.Controls.Add(BtnUserBack)
        PnlNewUser.Controls.Add(Panel2)
        PnlNewUser.Controls.Add(Label5)
        PnlNewUser.Controls.Add(Panel1)
        PnlNewUser.Controls.Add(Label4)
        PnlNewUser.Controls.Add(PnlPassword)
        PnlNewUser.Controls.Add(PnlVisitorName)
        PnlNewUser.Controls.Add(BtnAddUser)
        PnlNewUser.Controls.Add(LblVisitorName)
        PnlNewUser.Location = New Point(0, 49)
        PnlNewUser.Name = "PnlNewUser"
        PnlNewUser.Size = New Size(604, 516)
        PnlNewUser.TabIndex = 34
        ' 
        ' BtnUserBack
        ' 
        BtnUserBack.BackColor = Color.Gold
        BtnUserBack.FlatAppearance.BorderSize = 0
        BtnUserBack.FlatStyle = FlatStyle.Flat
        BtnUserBack.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        BtnUserBack.ForeColor = Color.Navy
        BtnUserBack.Location = New Point(152, 314)
        BtnUserBack.Name = "BtnUserBack"
        BtnUserBack.Size = New Size(148, 35)
        BtnUserBack.TabIndex = 37
        BtnUserBack.Text = "Back"
        BtnUserBack.UseVisualStyleBackColor = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ControlLightLight
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(TxtRFID)
        Panel2.Location = New Point(152, 273)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(300, 35)
        Panel2.TabIndex = 36
        ' 
        ' TxtRFID
        ' 
        TxtRFID.BackColor = SystemColors.ControlLightLight
        TxtRFID.BorderStyle = BorderStyle.None
        TxtRFID.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TxtRFID.Location = New Point(9, 9)
        TxtRFID.Margin = New Padding(10)
        TxtRFID.Name = "TxtRFID"
        TxtRFID.Size = New Size(280, 15)
        TxtRFID.TabIndex = 0
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.Transparent
        Label5.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.Gold
        Label5.Location = New Point(152, 256)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 14)
        Label5.TabIndex = 35
        Label5.Text = "RFID"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ControlLightLight
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(TxtName)
        Panel1.Location = New Point(152, 164)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(300, 35)
        Panel1.TabIndex = 36
        ' 
        ' TxtName
        ' 
        TxtName.BackColor = SystemColors.ControlLightLight
        TxtName.BorderStyle = BorderStyle.None
        TxtName.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TxtName.Location = New Point(9, 9)
        TxtName.Margin = New Padding(10)
        TxtName.Name = "TxtName"
        TxtName.Size = New Size(280, 15)
        TxtName.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.Gold
        Label4.Location = New Point(152, 147)
        Label4.Name = "Label4"
        Label4.Size = New Size(43, 14)
        Label4.TabIndex = 35
        Label4.Text = "Name"
        ' 
        ' PnlPassword
        ' 
        PnlPassword.BackColor = SystemColors.ControlLightLight
        PnlPassword.BorderStyle = BorderStyle.FixedSingle
        PnlPassword.Controls.Add(TxtKeycard)
        PnlPassword.Location = New Point(152, 273)
        PnlPassword.Name = "PnlPassword"
        PnlPassword.Size = New Size(300, 35)
        PnlPassword.TabIndex = 34
        ' 
        ' TxtKeycard
        ' 
        TxtKeycard.BackColor = SystemColors.ControlLightLight
        TxtKeycard.BorderStyle = BorderStyle.None
        TxtKeycard.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TxtKeycard.Location = New Point(9, 9)
        TxtKeycard.Margin = New Padding(10)
        TxtKeycard.Name = "TxtKeycard"
        TxtKeycard.Size = New Size(280, 15)
        TxtKeycard.TabIndex = 0
        ' 
        ' PnlVisitorName
        ' 
        PnlVisitorName.BackColor = SystemColors.ControlLightLight
        PnlVisitorName.BorderStyle = BorderStyle.FixedSingle
        PnlVisitorName.Controls.Add(TxtStudentId)
        PnlVisitorName.Location = New Point(152, 218)
        PnlVisitorName.Name = "PnlVisitorName"
        PnlVisitorName.Size = New Size(300, 35)
        PnlVisitorName.TabIndex = 32
        ' 
        ' TxtStudentId
        ' 
        TxtStudentId.BackColor = SystemColors.ControlLightLight
        TxtStudentId.BorderStyle = BorderStyle.None
        TxtStudentId.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TxtStudentId.Location = New Point(9, 9)
        TxtStudentId.Margin = New Padding(10)
        TxtStudentId.Name = "TxtStudentId"
        TxtStudentId.Size = New Size(280, 15)
        TxtStudentId.TabIndex = 0
        ' 
        ' BtnAddUser
        ' 
        BtnAddUser.BackColor = Color.Gold
        BtnAddUser.FlatAppearance.BorderSize = 0
        BtnAddUser.FlatStyle = FlatStyle.Flat
        BtnAddUser.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        BtnAddUser.ForeColor = Color.Navy
        BtnAddUser.Location = New Point(304, 314)
        BtnAddUser.Name = "BtnAddUser"
        BtnAddUser.Size = New Size(148, 35)
        BtnAddUser.TabIndex = 31
        BtnAddUser.Text = "Create"
        BtnAddUser.UseVisualStyleBackColor = False
        ' 
        ' LblVisitorName
        ' 
        LblVisitorName.AutoSize = True
        LblVisitorName.BackColor = Color.Transparent
        LblVisitorName.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LblVisitorName.ForeColor = Color.Gold
        LblVisitorName.Location = New Point(152, 201)
        LblVisitorName.Name = "LblVisitorName"
        LblVisitorName.Size = New Size(74, 14)
        LblVisitorName.TabIndex = 30
        LblVisitorName.Text = "Student Id"
        ' 
        ' PnlNewKey
        ' 
        PnlNewKey.BackColor = Color.Navy
        PnlNewKey.Controls.Add(BtnKeyBack)
        PnlNewKey.Controls.Add(Panel4)
        PnlNewKey.Controls.Add(Label6)
        PnlNewKey.Controls.Add(Panel6)
        PnlNewKey.Controls.Add(Label8)
        PnlNewKey.Controls.Add(BtnAddKey)
        PnlNewKey.Location = New Point(0, 49)
        PnlNewKey.Name = "PnlNewKey"
        PnlNewKey.Size = New Size(604, 516)
        PnlNewKey.TabIndex = 37
        ' 
        ' BtnKeyBack
        ' 
        BtnKeyBack.BackColor = Color.Gold
        BtnKeyBack.FlatAppearance.BorderSize = 0
        BtnKeyBack.FlatStyle = FlatStyle.Flat
        BtnKeyBack.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        BtnKeyBack.ForeColor = Color.Navy
        BtnKeyBack.Location = New Point(152, 299)
        BtnKeyBack.Name = "BtnKeyBack"
        BtnKeyBack.Size = New Size(148, 35)
        BtnKeyBack.TabIndex = 37
        BtnKeyBack.Text = "Back"
        BtnKeyBack.UseVisualStyleBackColor = False
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = SystemColors.ControlLightLight
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Controls.Add(TxtKeyRFID)
        Panel4.Location = New Point(152, 258)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(300, 35)
        Panel4.TabIndex = 36
        ' 
        ' TxtKeyRFID
        ' 
        TxtKeyRFID.BackColor = SystemColors.ControlLightLight
        TxtKeyRFID.BorderStyle = BorderStyle.None
        TxtKeyRFID.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TxtKeyRFID.Location = New Point(9, 9)
        TxtKeyRFID.Margin = New Padding(10)
        TxtKeyRFID.Name = "TxtKeyRFID"
        TxtKeyRFID.Size = New Size(280, 15)
        TxtKeyRFID.TabIndex = 38
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.Transparent
        Label6.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = Color.Gold
        Label6.Location = New Point(152, 241)
        Label6.Name = "Label6"
        Label6.Size = New Size(36, 14)
        Label6.TabIndex = 35
        Label6.Text = "RFID"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.ControlLightLight
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Controls.Add(TxtKeyName)
        Panel6.Location = New Point(152, 200)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(300, 35)
        Panel6.TabIndex = 34
        ' 
        ' TxtKeyName
        ' 
        TxtKeyName.BackColor = SystemColors.ControlLightLight
        TxtKeyName.BorderStyle = BorderStyle.None
        TxtKeyName.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TxtKeyName.Location = New Point(8, 9)
        TxtKeyName.Margin = New Padding(10)
        TxtKeyName.Name = "TxtKeyName"
        TxtKeyName.Size = New Size(280, 15)
        TxtKeyName.TabIndex = 39
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.Transparent
        Label8.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.ForeColor = Color.Gold
        Label8.Location = New Point(152, 183)
        Label8.Name = "Label8"
        Label8.Size = New Size(110, 14)
        Label8.TabIndex = 33
        Label8.Text = "Keycard Number"
        ' 
        ' BtnAddKey
        ' 
        BtnAddKey.BackColor = Color.Gold
        BtnAddKey.FlatAppearance.BorderSize = 0
        BtnAddKey.FlatStyle = FlatStyle.Flat
        BtnAddKey.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        BtnAddKey.ForeColor = Color.Navy
        BtnAddKey.Location = New Point(304, 299)
        BtnAddKey.Name = "BtnAddKey"
        BtnAddKey.Size = New Size(148, 35)
        BtnAddKey.TabIndex = 31
        BtnAddKey.Text = "Create"
        BtnAddKey.UseVisualStyleBackColor = False
        ' 
        ' TimerRegisterUserControl
        ' 
        ' 
        ' PnlNewLocker
        ' 
        PnlNewLocker.BackColor = Color.Navy
        PnlNewLocker.Controls.Add(BtnLockerBack)
        PnlNewLocker.Controls.Add(Panel5)
        PnlNewLocker.Controls.Add(Label7)
        PnlNewLocker.Controls.Add(BtnAddLocker)
        PnlNewLocker.Location = New Point(0, 49)
        PnlNewLocker.Name = "PnlNewLocker"
        PnlNewLocker.Size = New Size(604, 516)
        PnlNewLocker.TabIndex = 38
        ' 
        ' BtnLockerBack
        ' 
        BtnLockerBack.BackColor = Color.Gold
        BtnLockerBack.FlatAppearance.BorderSize = 0
        BtnLockerBack.FlatStyle = FlatStyle.Flat
        BtnLockerBack.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        BtnLockerBack.ForeColor = Color.Navy
        BtnLockerBack.Location = New Point(152, 256)
        BtnLockerBack.Name = "BtnLockerBack"
        BtnLockerBack.Size = New Size(148, 35)
        BtnLockerBack.TabIndex = 37
        BtnLockerBack.Text = "Back"
        BtnLockerBack.UseVisualStyleBackColor = False
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ControlLightLight
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Controls.Add(TxtLockerNumber)
        Panel5.Location = New Point(152, 215)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(300, 35)
        Panel5.TabIndex = 36
        ' 
        ' TxtLockerNumber
        ' 
        TxtLockerNumber.BackColor = SystemColors.ControlLightLight
        TxtLockerNumber.BorderStyle = BorderStyle.None
        TxtLockerNumber.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TxtLockerNumber.Location = New Point(9, 9)
        TxtLockerNumber.Margin = New Padding(10)
        TxtLockerNumber.Name = "TxtLockerNumber"
        TxtLockerNumber.Size = New Size(280, 15)
        TxtLockerNumber.TabIndex = 38
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.Transparent
        Label7.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = Color.Gold
        Label7.Location = New Point(152, 198)
        Label7.Name = "Label7"
        Label7.Size = New Size(101, 14)
        Label7.TabIndex = 35
        Label7.Text = "Locker Number"
        ' 
        ' BtnAddLocker
        ' 
        BtnAddLocker.BackColor = Color.Gold
        BtnAddLocker.FlatAppearance.BorderSize = 0
        BtnAddLocker.FlatStyle = FlatStyle.Flat
        BtnAddLocker.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        BtnAddLocker.ForeColor = Color.Navy
        BtnAddLocker.Location = New Point(304, 256)
        BtnAddLocker.Name = "BtnAddLocker"
        BtnAddLocker.Size = New Size(148, 35)
        BtnAddLocker.TabIndex = 31
        BtnAddLocker.Text = "Create"
        BtnAddLocker.UseVisualStyleBackColor = False
        ' 
        ' RegisterUserControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gold
        Controls.Add(LblVisitorInfoName)
        Controls.Add(PnlNewUser)
        Controls.Add(PnlMenu)
        Controls.Add(PnlNewLocker)
        Controls.Add(PnlNewKey)
        Name = "RegisterUserControl"
        Size = New Size(604, 558)
        PnlMenu.ResumeLayout(False)
        PnlMenu.PerformLayout()
        PnlNewUser.ResumeLayout(False)
        PnlNewUser.PerformLayout()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        PnlPassword.ResumeLayout(False)
        PnlPassword.PerformLayout()
        PnlVisitorName.ResumeLayout(False)
        PnlVisitorName.PerformLayout()
        PnlNewKey.ResumeLayout(False)
        PnlNewKey.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        PnlNewLocker.ResumeLayout(False)
        PnlNewLocker.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PnlMenu As Panel
    Friend WithEvents LblVisitorInfoName As Label
    Friend WithEvents PBUser As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PBLocker As PictureBox
    Friend WithEvents PBKey As PictureBox
    Friend WithEvents BtnUser As Button
    Friend WithEvents BtnLocker As Button
    Friend WithEvents BtnKey As Button
    Friend WithEvents PnlNewUser As Panel
    Friend WithEvents PnlPassword As Panel
    Friend WithEvents TxtKeycard As TextBox
    Friend WithEvents PnlVisitorName As Panel
    Friend WithEvents TxtStudentId As TextBox
    Friend WithEvents BtnAddUser As Button
    Friend WithEvents LblVisitorName As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TxtName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtRFID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TimerRegisterUserControl As Timer
    Friend WithEvents PnlNewKey As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents TxtLockerNumber As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents BtnAddKey As Button
    Friend WithEvents TxtKeyRFID As TextBox
    Friend WithEvents TxtKeyName As TextBox
    Friend WithEvents BtnKeyBack As Button
    Friend WithEvents BtnUserBack As Button
    Friend WithEvents PnlNewLocker As Panel
    Friend WithEvents BtnLockerBack As Button
    Friend WithEvents BtnAddLocker As Button
End Class
