Public Class MainFrm

    Dim GetUserControl As New GetUserControl
    Dim MainUserControl As New MainUserControl
    Dim AdminUserControl As New AdminUserControl
    Dim ReturnUserControl As New ReturnUserControl
    Dim VisitorGetUserControl As New VisitorGetUserControl
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PnlHome.Controls.Add(MainUserControl)
        BtnHome.Enabled = False
    End Sub

    Private Sub PbAdmin_MouseHover(sender As Object, e As EventArgs) Handles PbAdmin.MouseHover
        PbAdmin.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub PbAdmin_MouseLeave(sender As Object, e As EventArgs) Handles PbAdmin.MouseLeave
        PbAdmin.BorderStyle = BorderStyle.None
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        MainUserControl.BringToFront()
        PnlHome.BringToFront()

        EnableButtons()
        BtnHome.Enabled = False
    End Sub

    Private Sub PbAdmin_Click(sender As Object, e As EventArgs) Handles PbAdmin.Click
        PnlHome.Controls.Add(AdminUserControl)
        AdminUserControl.BringToFront()

        EnableButtons()
        PbAdmin.Enabled = False
    End Sub

    Private Sub BtnGet_Click(sender As Object, e As EventArgs)
        PnlHome.Controls.Add(GetUserControl)
        GetUserControl.BringToFront()

        EnableButtons()

    End Sub

    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnReturn.Click
        PnlHome.Controls.Add(VisitorGetUserControl)
        VisitorGetUserControl.BringToFront()

        EnableButtons()
        BtnReturn.Enabled = False
    End Sub

    Sub EnableButtons()

        BtnHome.Enabled = True
        BtnReturn.Enabled = True
        PbAdmin.Enabled = True
    End Sub

End Class
