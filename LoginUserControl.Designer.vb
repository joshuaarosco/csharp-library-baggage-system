<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginUserControl
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
        PnlLogin = New Panel()
        PnlPassword = New Panel()
        TxtPassword = New TextBox()
        LblPassword = New Label()
        PnlVisitorName = New Panel()
        TxtUsername = New TextBox()
        BtnLogin = New Button()
        LblVisitorName = New Label()
        LblTitle = New Label()
        DgvBaggages = New DataGridView()
        TxtSearch = New TextBox()
        PnlStudNum = New Panel()
        LblSearch = New Label()
        BtnAdd = New Button()
        TimerAdminUserControl = New Timer(components)
        PnlLogin.SuspendLayout()
        PnlPassword.SuspendLayout()
        PnlVisitorName.SuspendLayout()
        CType(DgvBaggages, ComponentModel.ISupportInitialize).BeginInit()
        PnlStudNum.SuspendLayout()
        SuspendLayout()
        ' 
        ' PnlLogin
        ' 
        PnlLogin.BackColor = Color.Navy
        PnlLogin.Controls.Add(PnlPassword)
        PnlLogin.Controls.Add(LblPassword)
        PnlLogin.Controls.Add(PnlVisitorName)
        PnlLogin.Controls.Add(BtnLogin)
        PnlLogin.Controls.Add(LblVisitorName)
        PnlLogin.Location = New Point(0, 49)
        PnlLogin.Name = "PnlLogin"
        PnlLogin.Size = New Size(604, 516)
        PnlLogin.TabIndex = 0
        ' 
        ' PnlPassword
        ' 
        PnlPassword.BackColor = SystemColors.ControlLightLight
        PnlPassword.BorderStyle = BorderStyle.FixedSingle
        PnlPassword.Controls.Add(TxtPassword)
        PnlPassword.Location = New Point(151, 267)
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
        LblPassword.Location = New Point(151, 250)
        LblPassword.Name = "LblPassword"
        LblPassword.Size = New Size(69, 14)
        LblPassword.TabIndex = 28
        LblPassword.Text = "Password"
        ' 
        ' PnlVisitorName
        ' 
        PnlVisitorName.BackColor = SystemColors.ControlLightLight
        PnlVisitorName.BorderStyle = BorderStyle.FixedSingle
        PnlVisitorName.Controls.Add(TxtUsername)
        PnlVisitorName.Location = New Point(151, 212)
        PnlVisitorName.Name = "PnlVisitorName"
        PnlVisitorName.Size = New Size(300, 35)
        PnlVisitorName.TabIndex = 23
        ' 
        ' TxtUsername
        ' 
        TxtUsername.BackColor = SystemColors.ControlLightLight
        TxtUsername.BorderStyle = BorderStyle.None
        TxtUsername.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TxtUsername.Location = New Point(9, 9)
        TxtUsername.Margin = New Padding(10)
        TxtUsername.Name = "TxtUsername"
        TxtUsername.Size = New Size(280, 15)
        TxtUsername.TabIndex = 0
        ' 
        ' BtnLogin
        ' 
        BtnLogin.BackColor = Color.Gold
        BtnLogin.FlatAppearance.BorderSize = 0
        BtnLogin.FlatStyle = FlatStyle.Flat
        BtnLogin.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        BtnLogin.ForeColor = Color.Navy
        BtnLogin.Location = New Point(151, 308)
        BtnLogin.Name = "BtnLogin"
        BtnLogin.Size = New Size(300, 35)
        BtnLogin.TabIndex = 22
        BtnLogin.Text = "Login"
        BtnLogin.UseVisualStyleBackColor = False
        ' 
        ' LblVisitorName
        ' 
        LblVisitorName.AutoSize = True
        LblVisitorName.BackColor = Color.Transparent
        LblVisitorName.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LblVisitorName.ForeColor = Color.Gold
        LblVisitorName.Location = New Point(151, 195)
        LblVisitorName.Name = "LblVisitorName"
        LblVisitorName.Size = New Size(71, 14)
        LblVisitorName.TabIndex = 21
        LblVisitorName.Text = "Username"
        ' 
        ' LblTitle
        ' 
        LblTitle.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        LblTitle.AutoSize = True
        LblTitle.BackColor = Color.Transparent
        LblTitle.Font = New Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point)
        LblTitle.ForeColor = Color.Navy
        LblTitle.Location = New Point(3, 4)
        LblTitle.Name = "LblTitle"
        LblTitle.Size = New Size(180, 29)
        LblTitle.TabIndex = 34
        LblTitle.Text = "Admin Login"
        ' 
        ' DgvBaggages
        ' 
        DgvBaggages.AllowUserToAddRows = False
        DgvBaggages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvBaggages.BackgroundColor = Color.Navy
        DgvBaggages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvBaggages.GridColor = Color.Navy
        DgvBaggages.Location = New Point(0, 50)
        DgvBaggages.Name = "DgvBaggages"
        DgvBaggages.ReadOnly = True
        DgvBaggages.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgvBaggages.RowTemplate.Height = 25
        DgvBaggages.Size = New Size(604, 516)
        DgvBaggages.TabIndex = 20
        ' 
        ' TxtSearch
        ' 
        TxtSearch.BackColor = SystemColors.ControlLightLight
        TxtSearch.BorderStyle = BorderStyle.None
        TxtSearch.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        TxtSearch.Location = New Point(9, 9)
        TxtSearch.Margin = New Padding(10)
        TxtSearch.Name = "TxtSearch"
        TxtSearch.Size = New Size(280, 15)
        TxtSearch.TabIndex = 0
        ' 
        ' PnlStudNum
        ' 
        PnlStudNum.BackColor = SystemColors.ControlLightLight
        PnlStudNum.BorderStyle = BorderStyle.FixedSingle
        PnlStudNum.Controls.Add(LblSearch)
        PnlStudNum.Controls.Add(TxtSearch)
        PnlStudNum.Location = New Point(0, 0)
        PnlStudNum.Name = "PnlStudNum"
        PnlStudNum.Size = New Size(300, 35)
        PnlStudNum.TabIndex = 19
        ' 
        ' LblSearch
        ' 
        LblSearch.AutoSize = True
        LblSearch.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LblSearch.ForeColor = SystemColors.ControlDarkDark
        LblSearch.Location = New Point(10, 9)
        LblSearch.Name = "LblSearch"
        LblSearch.Size = New Size(68, 14)
        LblSearch.TabIndex = 18
        LblSearch.Text = "Search 🔍"
        ' 
        ' BtnAdd
        ' 
        BtnAdd.BackColor = SystemColors.ButtonHighlight
        BtnAdd.FlatAppearance.BorderColor = Color.Navy
        BtnAdd.FlatStyle = FlatStyle.Flat
        BtnAdd.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        BtnAdd.ForeColor = Color.Navy
        BtnAdd.Location = New Point(309, 0)
        BtnAdd.Name = "BtnAdd"
        BtnAdd.Size = New Size(35, 35)
        BtnAdd.TabIndex = 20
        BtnAdd.Text = "+"
        BtnAdd.UseVisualStyleBackColor = False
        ' 
        ' TimerAdminUserControl
        ' 
        ' 
        ' LoginUserControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gold
        Controls.Add(LblTitle)
        Controls.Add(BtnAdd)
        Controls.Add(PnlStudNum)
        Controls.Add(PnlLogin)
        Controls.Add(DgvBaggages)
        Name = "LoginUserControl"
        Size = New Size(604, 564)
        PnlLogin.ResumeLayout(False)
        PnlLogin.PerformLayout()
        PnlPassword.ResumeLayout(False)
        PnlPassword.PerformLayout()
        PnlVisitorName.ResumeLayout(False)
        PnlVisitorName.PerformLayout()
        CType(DgvBaggages, ComponentModel.ISupportInitialize).EndInit()
        PnlStudNum.ResumeLayout(False)
        PnlStudNum.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PnlLogin As Panel
    Friend WithEvents PnlVisitorInput As Panel
    Friend WithEvents PnlPassword As Panel
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents LblVisitorId As Label
    Friend WithEvents LblPassword As Label
    Friend WithEvents PnlVisitorName As Panel
    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents LblVisitorName As Label
    Friend WithEvents BtnLogin As Button
    Friend WithEvents PnlVisitorId As Panel
    Friend WithEvents TxtVisitorId As TextBox
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents PnlStudNum As Panel
    Friend WithEvents LblSearch As Label
    Friend WithEvents DgvBaggages As DataGridView
    Friend WithEvents BtnAdd As Button
    Friend WithEvents LblTitle As Label
    Friend WithEvents TimerAdminUserControl As Timer
End Class
