<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminUserControl
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
        Me.PnlAdmin = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'PnlAdmin
        '
        Me.PnlAdmin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.PnlAdmin.Location = New System.Drawing.Point(0, 0)
        Me.PnlAdmin.Name = "PnlAdmin"
        Me.PnlAdmin.Size = New System.Drawing.Size(604, 516)
        Me.PnlAdmin.TabIndex = 7
        '
        'AdminUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.PnlAdmin)
        Me.Name = "AdminUserControl"
        Me.Size = New System.Drawing.Size(604, 516)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PnlAdmin As Panel
End Class
