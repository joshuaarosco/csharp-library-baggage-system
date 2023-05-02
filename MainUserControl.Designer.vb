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
        components = New ComponentModel.Container()
        DgvBaggages = New DataGridView()
        PnlStudNum = New Panel()
        LblSearch = New Label()
        TxtSearch = New TextBox()
        TimerMainUserControl = New Timer(components)
        CType(DgvBaggages, ComponentModel.ISupportInitialize).BeginInit()
        PnlStudNum.SuspendLayout()
        SuspendLayout()
        ' 
        ' DgvBaggages
        ' 
        DgvBaggages.AllowUserToAddRows = False
        DgvBaggages.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DgvBaggages.BackgroundColor = Color.Navy
        DgvBaggages.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DgvBaggages.GridColor = Color.Navy
        DgvBaggages.Location = New Point(0, 48)
        DgvBaggages.Name = "DgvBaggages"
        DgvBaggages.ReadOnly = True
        DgvBaggages.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DgvBaggages.RowTemplate.Height = 25
        DgvBaggages.Size = New Size(604, 516)
        DgvBaggages.TabIndex = 4
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
        PnlStudNum.TabIndex = 18
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
        ' TimerMainUserControl
        ' 
        TimerMainUserControl.Interval = 1000
        ' 
        ' MainUserControl
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Gold
        Controls.Add(PnlStudNum)
        Controls.Add(DgvBaggages)
        Name = "MainUserControl"
        Size = New Size(604, 564)
        CType(DgvBaggages, ComponentModel.ISupportInitialize).EndInit()
        PnlStudNum.ResumeLayout(False)
        PnlStudNum.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents DgvBaggages As DataGridView
    Friend WithEvents PnlStudNum As Panel
    Friend WithEvents LblSearch As Label
    Friend WithEvents TxtSearch As TextBox
    Friend WithEvents TimerMainUserControl As Timer
End Class
