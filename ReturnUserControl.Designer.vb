<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReturnUserControl
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
        Me.PnlKeycard = New System.Windows.Forms.Panel()
        Me.TxtKeycard = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.BtnSubmit = New System.Windows.Forms.Button()
        Me.BtnBack = New System.Windows.Forms.Button()
        Me.BtnNext = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblKeycard = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PnlKeycard.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlKeycard
        '
        Me.PnlKeycard.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PnlKeycard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PnlKeycard.Controls.Add(Me.TxtKeycard)
        Me.PnlKeycard.Location = New System.Drawing.Point(154, 220)
        Me.PnlKeycard.Name = "PnlKeycard"
        Me.PnlKeycard.Size = New System.Drawing.Size(300, 35)
        Me.PnlKeycard.TabIndex = 11
        '
        'TxtKeycard
        '
        Me.TxtKeycard.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtKeycard.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtKeycard.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtKeycard.Location = New System.Drawing.Point(10, 9)
        Me.TxtKeycard.Margin = New System.Windows.Forms.Padding(10)
        Me.TxtKeycard.Name = "TxtKeycard"
        Me.TxtKeycard.Size = New System.Drawing.Size(280, 15)
        Me.TxtKeycard.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.TxtId)
        Me.Panel2.Location = New System.Drawing.Point(154, 220)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(300, 35)
        Me.Panel2.TabIndex = 12
        '
        'TxtId
        '
        Me.TxtId.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.TxtId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtId.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtId.Location = New System.Drawing.Point(10, 9)
        Me.TxtId.Margin = New System.Windows.Forms.Padding(10)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(280, 15)
        Me.TxtId.TabIndex = 0
        '
        'BtnSubmit
        '
        Me.BtnSubmit.BackColor = System.Drawing.Color.Gold
        Me.BtnSubmit.FlatAppearance.BorderSize = 0
        Me.BtnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSubmit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnSubmit.ForeColor = System.Drawing.Color.Navy
        Me.BtnSubmit.Location = New System.Drawing.Point(304, 261)
        Me.BtnSubmit.Name = "BtnSubmit"
        Me.BtnSubmit.Size = New System.Drawing.Size(150, 35)
        Me.BtnSubmit.TabIndex = 11
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
        Me.BtnBack.Location = New System.Drawing.Point(154, 261)
        Me.BtnBack.Name = "BtnBack"
        Me.BtnBack.Size = New System.Drawing.Size(150, 35)
        Me.BtnBack.TabIndex = 12
        Me.BtnBack.Text = "Back"
        Me.BtnBack.UseVisualStyleBackColor = False
        '
        'BtnNext
        '
        Me.BtnNext.BackColor = System.Drawing.Color.Gold
        Me.BtnNext.FlatAppearance.BorderSize = 0
        Me.BtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNext.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnNext.ForeColor = System.Drawing.Color.Navy
        Me.BtnNext.Location = New System.Drawing.Point(154, 261)
        Me.BtnNext.Name = "BtnNext"
        Me.BtnNext.Size = New System.Drawing.Size(300, 35)
        Me.BtnNext.TabIndex = 10
        Me.BtnNext.Text = "Next"
        Me.BtnNext.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Navy
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(154, 204)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 14)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "ID Number"
        '
        'LblKeycard
        '
        Me.LblKeycard.AutoSize = True
        Me.LblKeycard.BackColor = System.Drawing.Color.Navy
        Me.LblKeycard.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LblKeycard.ForeColor = System.Drawing.Color.Gold
        Me.LblKeycard.Location = New System.Drawing.Point(154, 203)
        Me.LblKeycard.Name = "LblKeycard"
        Me.LblKeycard.Size = New System.Drawing.Size(110, 14)
        Me.LblKeycard.TabIndex = 8
        Me.LblKeycard.Text = "Keycard Number"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Navy
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.PnlKeycard)
        Me.Panel1.Controls.Add(Me.LblKeycard)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.BtnNext)
        Me.Panel1.Controls.Add(Me.BtnBack)
        Me.Panel1.Controls.Add(Me.BtnSubmit)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(0, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(604, 516)
        Me.Panel1.TabIndex = 7
        '
        'ReturnUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ReturnUserControl"
        Me.Size = New System.Drawing.Size(604, 564)
        Me.PnlKeycard.ResumeLayout(False)
        Me.PnlKeycard.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlKeycard As Panel
    Friend WithEvents TxtKeycard As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TxtId As TextBox
    Friend WithEvents BtnSubmit As Button
    Friend WithEvents BtnBack As Button
    Friend WithEvents BtnNext As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LblKeycard As Label
    Friend WithEvents Panel1 As Panel
End Class
