Public Class AdminUserControl

    Dim LoginUserControl As New LoginUserControl
    Private Sub AdminUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PnlAdmin.Controls.Add(LoginUserControl)
    End Sub
End Class
