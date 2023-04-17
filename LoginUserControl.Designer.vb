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
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.PnlLogin = New System.Windows.Forms.Panel()
        Me.DgvBaggages = New System.Windows.Forms.DataGridView()
        Me.PnlStudNum = New System.Windows.Forms.Panel()
        Me.LblSearch = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PnlLogin.SuspendLayout()
        CType(Me.DgvBaggages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlStudNum.SuspendLayout()
        Me.SuspendLayout()
        '
        'TxtUsername
        '
        Me.TxtUsername.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtUsername.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtUsername.Location = New System.Drawing.Point(10, 9)
        Me.TxtUsername.Margin = New System.Windows.Forms.Padding(10)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(280, 15)
        Me.TxtUsername.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Navy
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(153, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 14)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Navy
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.Gold
        Me.Label2.Location = New System.Drawing.Point(153, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 14)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.Gold
        Me.BtnLogin.FlatAppearance.BorderSize = 0
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnLogin.ForeColor = System.Drawing.Color.Navy
        Me.BtnLogin.Location = New System.Drawing.Point(153, 291)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(300, 35)
        Me.BtnLogin.TabIndex = 4
        Me.BtnLogin.Text = "Login"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TxtUsername)
        Me.Panel1.Location = New System.Drawing.Point(153, 193)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(300, 35)
        Me.Panel1.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TxtPassword)
        Me.Panel2.Location = New System.Drawing.Point(153, 250)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 35)
        Me.Panel2.TabIndex = 6
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
        'PnlLogin
        '
        Me.PnlLogin.BackColor = System.Drawing.Color.Navy
        Me.PnlLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlLogin.Controls.Add(Me.Panel2)
        Me.PnlLogin.Controls.Add(Me.Panel1)
        Me.PnlLogin.Controls.Add(Me.BtnLogin)
        Me.PnlLogin.Controls.Add(Me.Label1)
        Me.PnlLogin.Controls.Add(Me.Label2)
        Me.PnlLogin.Location = New System.Drawing.Point(0, 49)
        Me.PnlLogin.Name = "PnlLogin"
        Me.PnlLogin.Size = New System.Drawing.Size(604, 516)
        Me.PnlLogin.TabIndex = 7
        '
        'DgvBaggages
        '
        Me.DgvBaggages.AllowUserToAddRows = False
        Me.DgvBaggages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvBaggages.BackgroundColor = System.Drawing.Color.Navy
        Me.DgvBaggages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBaggages.GridColor = System.Drawing.Color.Navy
        Me.DgvBaggages.Location = New System.Drawing.Point(0, 49)
        Me.DgvBaggages.Name = "DgvBaggages"
        Me.DgvBaggages.ReadOnly = True
        Me.DgvBaggages.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvBaggages.RowTemplate.Height = 25
        Me.DgvBaggages.Size = New System.Drawing.Size(604, 516)
        Me.DgvBaggages.TabIndex = 5
        '
        'PnlStudNum
        '
        Me.PnlStudNum.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PnlStudNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlStudNum.Controls.Add(Me.LblSearch)
        Me.PnlStudNum.Controls.Add(Me.TxtSearch)
        Me.PnlStudNum.Location = New System.Drawing.Point(0, 0)
        Me.PnlStudNum.Name = "PnlStudNum"
        Me.PnlStudNum.Size = New System.Drawing.Size(300, 35)
        Me.PnlStudNum.TabIndex = 19
        '
        'LblSearch
        '
        Me.LblSearch.AutoSize = True
        Me.LblSearch.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LblSearch.Location = New System.Drawing.Point(10, 9)
        Me.LblSearch.Name = "LblSearch"
        Me.LblSearch.Size = New System.Drawing.Size(68, 14)
        Me.LblSearch.TabIndex = 18
        Me.LblSearch.Text = "Search 🔍"
        '
        'TxtSearch
        '
        Me.TxtSearch.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtSearch.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtSearch.Location = New System.Drawing.Point(9, 9)
        Me.TxtSearch.Margin = New System.Windows.Forms.Padding(10)
        Me.TxtSearch.Name = "TxtSearch"
        Me.TxtSearch.Size = New System.Drawing.Size(280, 15)
        Me.TxtSearch.TabIndex = 0
        '
        'LoginUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.Controls.Add(Me.PnlStudNum)
        Me.Controls.Add(Me.PnlLogin)
        Me.Controls.Add(Me.DgvBaggages)
        Me.Name = "LoginUserControl"
        Me.Size = New System.Drawing.Size(604, 564)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PnlLogin.ResumeLayout(False)
        Me.PnlLogin.PerformLayout()
        CType(Me.DgvBaggages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlStudNum.ResumeLayout(False)
        Me.PnlStudNum.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TxtUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnLogin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtPassword As TextBox
    Friend WithEvents PnlLogin As Panel
    Friend WithEvents DgvBaggages As DataGridView
    Friend WithEvents PnlStudNum As Panel
    Friend WithEvents LblSearch As Label
    Friend WithEvents TxtSearch As TextBox
End Class
