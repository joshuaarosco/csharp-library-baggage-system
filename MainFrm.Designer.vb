Imports System.IO.Ports

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFrm
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
        components = New ComponentModel.Container()
        Dim AsciiEncodingSealed1 As Text.ASCIIEncoding = New Text.ASCIIEncoding()
        Dim DecoderReplacementFallback1 As Text.DecoderReplacementFallback = New Text.DecoderReplacementFallback()
        Dim EncoderReplacementFallback1 As Text.EncoderReplacementFallback = New Text.EncoderReplacementFallback()
        PnlHome = New Panel()
        BtnClose = New Button()
        BtnMinimize = New Button()
        PbAdmin = New PictureBox()
        BtnHome = New Button()
        BtnVisitor = New Button()
        Panel1 = New Panel()
        PnlConnection = New Panel()
        PBLockerConnection = New PictureBox()
        Label3 = New Label()
        TxtLockerCOM = New TextBox()
        LblDataMask = New Label()
        PBConnection = New PictureBox()
        Label2 = New Label()
        TxtBaudrate = New TextBox()
        TxtScannerCOM = New TextBox()
        Label1 = New Label()
        BtnConnect = New Button()
        TxtDataMask = New TextBox()
        TxtLockerMask = New TextBox()
        PBDisplayConnection = New PictureBox()
        TimerSerial = New Timer(components)
        DesktopScannerSerialPort = New SerialPort(components)
        LockerSerialPort = New SerialPort(components)
        TimerForUserControl = New Timer(components)
        CType(PbAdmin, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        PnlConnection.SuspendLayout()
        CType(PBLockerConnection, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBConnection, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBDisplayConnection, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlHome
        ' 
        PnlHome.BackColor = Color.Gold
        PnlHome.Location = New Point(8, 12)
        PnlHome.Name = "PnlHome"
        PnlHome.Size = New Size(604, 564)
        PnlHome.TabIndex = 0
        ' 
        ' BtnClose
        ' 
        BtnClose.BackColor = SystemColors.ButtonHighlight
        BtnClose.FlatAppearance.BorderColor = Color.Salmon
        BtnClose.FlatStyle = FlatStyle.Flat
        BtnClose.Font = New Font("Verdana", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        BtnClose.ForeColor = Color.Salmon
        BtnClose.Location = New Point(899, 12)
        BtnClose.Name = "BtnClose"
        BtnClose.Size = New Size(35, 35)
        BtnClose.TabIndex = 1
        BtnClose.Text = "x"
        BtnClose.UseVisualStyleBackColor = False
        ' 
        ' BtnMinimize
        ' 
        BtnMinimize.BackColor = SystemColors.ButtonHighlight
        BtnMinimize.FlatAppearance.BorderColor = Color.LightSalmon
        BtnMinimize.FlatStyle = FlatStyle.Flat
        BtnMinimize.Font = New Font("Verdana", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        BtnMinimize.ForeColor = Color.LightSalmon
        BtnMinimize.Location = New Point(865, 12)
        BtnMinimize.Name = "BtnMinimize"
        BtnMinimize.Size = New Size(35, 35)
        BtnMinimize.TabIndex = 2
        BtnMinimize.Text = "_"
        BtnMinimize.UseVisualStyleBackColor = False
        ' 
        ' PbAdmin
        ' 
        PbAdmin.BackColor = SystemColors.ButtonHighlight
        PbAdmin.BackgroundImage = My.Resources.Resources.user
        PbAdmin.BackgroundImageLayout = ImageLayout.Stretch
        PbAdmin.BorderStyle = BorderStyle.FixedSingle
        PbAdmin.Cursor = Cursors.Hand
        PbAdmin.Location = New Point(899, 582)
        PbAdmin.Name = "PbAdmin"
        PbAdmin.Size = New Size(35, 36)
        PbAdmin.TabIndex = 9
        PbAdmin.TabStop = False
        PbAdmin.Tag = "Admin"
        ' 
        ' BtnHome
        ' 
        BtnHome.BackColor = SystemColors.ButtonHighlight
        BtnHome.FlatAppearance.BorderColor = SystemColors.ActiveCaption
        BtnHome.FlatStyle = FlatStyle.Flat
        BtnHome.Font = New Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point)
        BtnHome.ForeColor = SystemColors.ActiveCaption
        BtnHome.Location = New Point(831, 12)
        BtnHome.Name = "BtnHome"
        BtnHome.Size = New Size(35, 35)
        BtnHome.TabIndex = 11
        BtnHome.Text = "⌂"
        BtnHome.UseVisualStyleBackColor = False
        ' 
        ' BtnVisitor
        ' 
        BtnVisitor.BackColor = SystemColors.ButtonHighlight
        BtnVisitor.BackgroundImageLayout = ImageLayout.Zoom
        BtnVisitor.FlatAppearance.BorderColor = Color.MidnightBlue
        BtnVisitor.FlatStyle = FlatStyle.Flat
        BtnVisitor.Font = New Font("Verdana", 9.0F, FontStyle.Regular, GraphicsUnit.Point)
        BtnVisitor.ForeColor = Color.Navy
        BtnVisitor.Location = New Point(8, 583)
        BtnVisitor.Name = "BtnVisitor"
        BtnVisitor.Size = New Size(97, 35)
        BtnVisitor.TabIndex = 13
        BtnVisitor.Text = "&Visitor"
        BtnVisitor.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Gold
        Panel1.Controls.Add(PnlHome)
        Panel1.Controls.Add(BtnVisitor)
        Panel1.Location = New Point(322, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(624, 629)
        Panel1.TabIndex = 15
        ' 
        ' PnlConnection
        ' 
        PnlConnection.BackColor = Color.FloralWhite
        PnlConnection.Controls.Add(PBLockerConnection)
        PnlConnection.Controls.Add(Label3)
        PnlConnection.Controls.Add(TxtLockerCOM)
        PnlConnection.Controls.Add(LblDataMask)
        PnlConnection.Controls.Add(PBConnection)
        PnlConnection.Controls.Add(Label2)
        PnlConnection.Controls.Add(TxtBaudrate)
        PnlConnection.Controls.Add(TxtScannerCOM)
        PnlConnection.Controls.Add(Label1)
        PnlConnection.Controls.Add(BtnConnect)
        PnlConnection.Controls.Add(TxtDataMask)
        PnlConnection.Controls.Add(TxtLockerMask)
        PnlConnection.Location = New Point(12, 461)
        PnlConnection.Name = "PnlConnection"
        PnlConnection.Size = New Size(178, 157)
        PnlConnection.TabIndex = 23
        PnlConnection.Visible = False
        ' 
        ' PBLockerConnection
        ' 
        PBLockerConnection.BackColor = Color.Red
        PBLockerConnection.Location = New Point(43, 121)
        PBLockerConnection.Name = "PBLockerConnection"
        PBLockerConnection.Size = New Size(26, 24)
        PBLockerConnection.TabIndex = 31
        PBLockerConnection.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 44)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 15)
        Label3.TabIndex = 30
        Label3.Text = "Locker COM"
        ' 
        ' TxtLockerCOM
        ' 
        TxtLockerCOM.Location = New Point(97, 41)
        TxtLockerCOM.Name = "TxtLockerCOM"
        TxtLockerCOM.Size = New Size(70, 23)
        TxtLockerCOM.TabIndex = 29
        TxtLockerCOM.Text = "COM20"
        ' 
        ' LblDataMask
        ' 
        LblDataMask.AutoSize = True
        LblDataMask.Location = New Point(11, 100)
        LblDataMask.Name = "LblDataMask"
        LblDataMask.Size = New Size(25, 15)
        LblDataMask.TabIndex = 27
        LblDataMask.Text = "000"
        ' 
        ' PBConnection
        ' 
        PBConnection.BackColor = Color.Red
        PBConnection.Location = New Point(11, 121)
        PBConnection.Name = "PBConnection"
        PBConnection.Size = New Size(26, 24)
        PBConnection.TabIndex = 26
        PBConnection.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(11, 73)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 25
        Label2.Text = "Baudrate"
        ' 
        ' TxtBaudrate
        ' 
        TxtBaudrate.Location = New Point(97, 70)
        TxtBaudrate.Name = "TxtBaudrate"
        TxtBaudrate.Size = New Size(70, 23)
        TxtBaudrate.TabIndex = 24
        TxtBaudrate.Text = "9600"
        ' 
        ' TxtScannerCOM
        ' 
        TxtScannerCOM.Location = New Point(97, 12)
        TxtScannerCOM.Name = "TxtScannerCOM"
        TxtScannerCOM.Size = New Size(70, 23)
        TxtScannerCOM.TabIndex = 23
        TxtScannerCOM.Text = "COM1"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(11, 15)
        Label1.Name = "Label1"
        Label1.Size = New Size(80, 15)
        Label1.TabIndex = 22
        Label1.Text = "Scanner COM"
        ' 
        ' BtnConnect
        ' 
        BtnConnect.Location = New Point(97, 122)
        BtnConnect.Name = "BtnConnect"
        BtnConnect.Size = New Size(70, 23)
        BtnConnect.TabIndex = 21
        BtnConnect.Text = "Connect"
        BtnConnect.UseVisualStyleBackColor = True
        ' 
        ' TxtDataMask
        ' 
        TxtDataMask.Location = New Point(97, 70)
        TxtDataMask.Name = "TxtDataMask"
        TxtDataMask.Size = New Size(70, 23)
        TxtDataMask.TabIndex = 28
        ' 
        ' TxtLockerMask
        ' 
        TxtLockerMask.Location = New Point(97, 70)
        TxtLockerMask.Name = "TxtLockerMask"
        TxtLockerMask.Size = New Size(70, 23)
        TxtLockerMask.TabIndex = 32
        ' 
        ' PBDisplayConnection
        ' 
        PBDisplayConnection.BackColor = Color.Red
        PBDisplayConnection.Location = New Point(23, 582)
        PBDisplayConnection.Name = "PBDisplayConnection"
        PBDisplayConnection.Size = New Size(26, 24)
        PBDisplayConnection.TabIndex = 27
        PBDisplayConnection.TabStop = False
        ' 
        ' TimerSerial
        ' 
        TimerSerial.Interval = 1
        ' 
        ' TimerForUserControl
        ' 
        ' 
        ' MainFrm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.bgimage
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(946, 629)
        Controls.Add(PnlConnection)
        Controls.Add(BtnClose)
        Controls.Add(BtnMinimize)
        Controls.Add(BtnHome)
        Controls.Add(PbAdmin)
        Controls.Add(Panel1)
        Controls.Add(PBDisplayConnection)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.None
        Name = "MainFrm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainFrm"
        CType(PbAdmin, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        PnlConnection.ResumeLayout(False)
        PnlConnection.PerformLayout()
        CType(PBLockerConnection, ComponentModel.ISupportInitialize).EndInit()
        CType(PBConnection, ComponentModel.ISupportInitialize).EndInit()
        CType(PBDisplayConnection, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PnlHome As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnMinimize As Button
    Friend WithEvents PbAdmin As PictureBox
    Friend WithEvents BtnHome As Button
    Friend WithEvents BtnVisitor As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PnlConnection As Panel
    Friend WithEvents PBConnection As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtBaudrate As TextBox
    Friend WithEvents TxtScannerCOM As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnConnect As Button
    Friend WithEvents PBDisplayConnection As PictureBox
    Friend WithEvents DesktopScannerSerialPort As IO.Ports.SerialPort
    Friend WithEvents LockerSerialPort As IO.Ports.SerialPort
    Friend WithEvents LblDataMask As Label
    Friend WithEvents TimerSerial As Timer
    Friend WithEvents TxtDataMask As TextBox
    Friend WithEvents TxtLockerCOM As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PBLockerConnection As PictureBox
    Friend WithEvents TxtLockerMask As TextBox
    Friend WithEvents TimerForUserControl As Timer
End Class
