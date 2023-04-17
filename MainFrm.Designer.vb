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
        Me.PnlHome = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnMinimize = New System.Windows.Forms.Button()
        Me.PbAdmin = New System.Windows.Forms.PictureBox()
        Me.BtnHome = New System.Windows.Forms.Button()
        Me.BtnReturn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PbAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlHome
        '
        Me.PnlHome.BackColor = System.Drawing.Color.Gold
        Me.PnlHome.Location = New System.Drawing.Point(8, 12)
        Me.PnlHome.Name = "PnlHome"
        Me.PnlHome.Size = New System.Drawing.Size(604, 564)
        Me.PnlHome.TabIndex = 0
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.Salmon
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnClose.ForeColor = System.Drawing.Color.Salmon
        Me.BtnClose.Location = New System.Drawing.Point(899, 12)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(35, 35)
        Me.BtnClose.TabIndex = 1
        Me.BtnClose.Text = "x"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnMinimize
        '
        Me.BtnMinimize.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnMinimize.FlatAppearance.BorderColor = System.Drawing.Color.LightSalmon
        Me.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnMinimize.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnMinimize.ForeColor = System.Drawing.Color.LightSalmon
        Me.BtnMinimize.Location = New System.Drawing.Point(865, 12)
        Me.BtnMinimize.Name = "BtnMinimize"
        Me.BtnMinimize.Size = New System.Drawing.Size(35, 35)
        Me.BtnMinimize.TabIndex = 2
        Me.BtnMinimize.Text = "_"
        Me.BtnMinimize.UseVisualStyleBackColor = False
        '
        'PbAdmin
        '
        Me.PbAdmin.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PbAdmin.BackgroundImage = Global.LibraryBaggageSystem.My.Resources.Resources.user
        Me.PbAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PbAdmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PbAdmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PbAdmin.Location = New System.Drawing.Point(899, 582)
        Me.PbAdmin.Name = "PbAdmin"
        Me.PbAdmin.Size = New System.Drawing.Size(35, 36)
        Me.PbAdmin.TabIndex = 9
        Me.PbAdmin.TabStop = False
        Me.PbAdmin.Tag = "Admin"
        '
        'BtnHome
        '
        Me.BtnHome.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnHome.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnHome.Font = New System.Drawing.Font("Verdana", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnHome.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.BtnHome.Location = New System.Drawing.Point(831, 12)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.Size = New System.Drawing.Size(35, 35)
        Me.BtnHome.TabIndex = 11
        Me.BtnHome.Text = "⌂"
        Me.BtnHome.UseVisualStyleBackColor = False
        '
        'BtnReturn
        '
        Me.BtnReturn.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BtnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BtnReturn.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue
        Me.BtnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnReturn.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnReturn.ForeColor = System.Drawing.Color.Navy
        Me.BtnReturn.Location = New System.Drawing.Point(8, 583)
        Me.BtnReturn.Name = "BtnReturn"
        Me.BtnReturn.Size = New System.Drawing.Size(97, 35)
        Me.BtnReturn.TabIndex = 13
        Me.BtnReturn.Text = "&Visitor"
        Me.BtnReturn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.PnlHome)
        Me.Panel1.Controls.Add(Me.BtnReturn)
        Me.Panel1.Location = New System.Drawing.Point(322, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(624, 629)
        Me.Panel1.TabIndex = 15
        '
        'MainFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.LibraryBaggageSystem.My.Resources.Resources.bgimage
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(946, 629)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnMinimize)
        Me.Controls.Add(Me.BtnHome)
        Me.Controls.Add(Me.PbAdmin)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainFrm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MainFrm"
        CType(Me.PbAdmin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnlHome As Panel
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnMinimize As Button
    Friend WithEvents PbAdmin As PictureBox
    Friend WithEvents BtnHome As Button
    Friend WithEvents BtnReturn As Button
    Friend WithEvents Panel1 As Panel
End Class
