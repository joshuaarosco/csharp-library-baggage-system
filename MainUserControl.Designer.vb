<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainUserControl
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
        Me.DgvBaggages = New System.Windows.Forms.DataGridView()
        Me.PnlStudNum = New System.Windows.Forms.Panel()
        Me.LblSearch = New System.Windows.Forms.Label()
        Me.TxtSearch = New System.Windows.Forms.TextBox()
        CType(Me.DgvBaggages, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlStudNum.SuspendLayout()
        Me.SuspendLayout()
        '
        'DgvBaggages
        '
        Me.DgvBaggages.AllowUserToAddRows = False
        Me.DgvBaggages.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvBaggages.BackgroundColor = System.Drawing.Color.Navy
        Me.DgvBaggages.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvBaggages.GridColor = System.Drawing.Color.Navy
        Me.DgvBaggages.Location = New System.Drawing.Point(0, 48)
        Me.DgvBaggages.Name = "DgvBaggages"
        Me.DgvBaggages.ReadOnly = True
        Me.DgvBaggages.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvBaggages.RowTemplate.Height = 25
        Me.DgvBaggages.Size = New System.Drawing.Size(604, 516)
        Me.DgvBaggages.TabIndex = 4
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
        Me.PnlStudNum.TabIndex = 18
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
        'MainUserControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gold
        Me.Controls.Add(Me.PnlStudNum)
        Me.Controls.Add(Me.DgvBaggages)
        Me.Name = "MainUserControl"
        Me.Size = New System.Drawing.Size(604, 564)
        CType(Me.DgvBaggages, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlStudNum.ResumeLayout(False)
        Me.PnlStudNum.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DgvBaggages As DataGridView
    Friend WithEvents PnlStudNum As Panel
    Friend WithEvents LblSearch As Label
    Friend WithEvents TxtSearch As TextBox
End Class
