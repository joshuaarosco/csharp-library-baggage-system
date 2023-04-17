<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GetUserControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.PnlKeycard = New System.Windows.Forms.Panel()
        Me.TxtKeycard = New System.Windows.Forms.TextBox()
        Me.lblKeycard = New System.Windows.Forms.Label()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.LblStudNum = New System.Windows.Forms.Label()
        Me.PnlStudNum = New System.Windows.Forms.Panel()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.PnlKeycard.SuspendLayout()
        Me.PnlStudNum.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(-1, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(616, 545)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.Controls.Add(Me.PnlStudNum)
        Me.Panel2.Controls.Add(Me.LblStudNum)
        Me.Panel2.Controls.Add(Me.BtnNext)
        Me.Panel2.Controls.Add(Me.lblKeycard)
        Me.Panel2.Controls.Add(Me.PnlKeycard)
        Me.Panel2.Controls.Add(Me.BtnBack)
        Me.Panel2.Controls.Add(Me.BtnSubmit)
        Me.Panel2.Location = New System.Drawing.Point(1, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(604, 558)
        Me.Panel2.TabIndex = 17
        '
        'BtnSubmit
        '
        Me.BtnSubmit.BackColor = System.Drawing.Color.Gold
        Me.BtnSubmit.FlatAppearance.BorderSize = 0
        Me.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubmit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnSubmit.ForeColor = System.Drawing.Color.Navy
        Me.BtnSubmit.Location = New System.Drawing.Point(305, 269)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(150, 35)
        Me.BtnSubmit.TabIndex = 19
        Me.BtnSubmit.Text = "Submit"
        Me.BtnSubmit.UseVisualStyleBackColor = False
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
        Me.BtnBack.TabIndex = 20
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'PnlKeycard
        '
        Me.PnlKeycard.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PnlKeycard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlKeycard.Controls.Add(Me.TxtKeycard)
        Me.PnlKeycard.Location = New System.Drawing.Point(155, 228)
        Me.PnlKeycard.Name = "PnlKeycard"
        Me.PnlKeycard.Size = New System.Drawing.Size(300, 35)
        Me.PnlKeycard.TabIndex = 18
        '
        'TxtKeycard
        '
        Me.TxtKeycard.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtKeycard.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtKeycard.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtKeycard.Location = New System.Drawing.Point(9, 9)
        Me.TxtKeycard.Margin = New System.Windows.Forms.Padding(10)
        Me.TxtKeycard.Name = "TxtKeycard"
        Me.TxtKeycard.Size = New System.Drawing.Size(280, 15)
        Me.TxtKeycard.TabIndex = 0
        '
        'lblKeycard
        '
        Me.lblKeycard.AutoSize = True
        Me.lblKeycard.BackColor = System.Drawing.Color.Transparent
        Me.lblKeycard.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblKeycard.ForeColor = System.Drawing.Color.Gold
        Me.lblKeycard.Location = New System.Drawing.Point(155, 211)
        Me.lblKeycard.Name = "lblKeycard"
        Me.lblKeycard.Size = New System.Drawing.Size(101, 14)
        Me.lblKeycard.TabIndex = 17
        Me.lblKeycard.Text = "Locker Number"
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.Gold
        Me.BtnNext.FlatAppearance.BorderSize = 0
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNext.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnNext.ForeColor = System.Drawing.Color.Navy
        Me.BtnNext.Location = New System.Drawing.Point(155, 269)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(300, 35)
        Me.BtnNext.TabIndex = 15
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'LblStudNum
        '
        Me.LblStudNum.AutoSize = True
        Me.LblStudNum.BackColor = System.Drawing.Color.Transparent
        Me.LblStudNum.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblStudNum.ForeColor = System.Drawing.Color.Gold
        Me.LblStudNum.Location = New System.Drawing.Point(155, 211)
        Me.LblStudNum.Name = "LblStudNum"
        Me.LblStudNum.Size = New System.Drawing.Size(110, 14)
        Me.LblStudNum.TabIndex = 13
        Me.LblStudNum.Text = "Student Number"
        '
        'PnlStudNum
        '
        Me.PnlStudNum.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PnlStudNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlStudNum.Controls.Add(Me.TxtId)
        Me.PnlStudNum.Enabled = False
        Me.PnlStudNum.Location = New System.Drawing.Point(155, 228)
        Me.PnlStudNum.Name = "PnlStudNum"
        Me.PnlStudNum.Size = New System.Drawing.Size(300, 35)
        Me.PnlStudNum.TabIndex = 16
        '
        'TxtId
        '
        Me.TxtId.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtId.Enabled = False
        Me.TxtId.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtId.Location = New System.Drawing.Point(9, 9)
        Me.TxtId.Margin = New System.Windows.Forms.Padding(10)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(280, 15)
        Me.TxtId.TabIndex = 0
        '
        'GetUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.Controls.Add(Me.Panel1)
        Me.Name = "GetUserControl"
        Me.Size = New System.Drawing.Size(604, 564)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.PnlKeycard.ResumeLayout(False)
        Me.PnlKeycard.PerformLayout()
        Me.PnlStudNum.ResumeLayout(False)
        Me.PnlStudNum.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PnlStudNum As Panel
    Friend WithEvents TxtId As TextBox
    Friend WithEvents LblStudNum As Label
    Friend WithEvents BtnNext As Button
    Friend WithEvents lblKeycard As Label
    Friend WithEvents PnlKeycard As Panel
    Friend WithEvents TxtKeycard As TextBox
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnSubmit As Button
End Class
