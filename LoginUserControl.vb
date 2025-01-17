﻿
Public Class LoginUserControl
    Dim authenticated As Boolean
    Dim testText As String = "password"
    Dim _RegisterUserControl As RegisterUserControl
    Public historyTableRefresh As Boolean = False

    Private Sub LoginUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTableHeader()
        AdminLoadTable()
        PnlStudNum.Visible = False
        BtnAdd.Visible = False
    End Sub
    Sub Authenticate()
        Try
            OpenCon()

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM users WHERE username = '" & TxtUsername.Text & "' AND password = '" & TxtPassword.Text & "' LIMIT 1"
            adapter.SelectCommand = cmd
            data.Clear()

            If adapter.Fill(data) Then
                For x As Integer = 0 To data.Tables(0).Rows.Count - 1
                    authenticated = True
                Next
            Else
                authenticated = False
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub AdminLoadTable()
        Try

            OpenCon()

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM baggages ORDER BY time_in DESC"
            adapter.SelectCommand = cmd
            admintable.Clear()
            admindata.Clear()

            con.Close()

            If adapter.Fill(admindata) Then
                For x As Integer = 0 To admindata.Tables(0).Rows.Count - 1

                    Dim id As String = admindata.Tables(0).Rows(x)("id").ToString()
                    Dim name As String = GetUserName(admindata.Tables(0).Rows(x)("user_id").ToString())(0)
                    Dim student_id As String = GetUserName(admindata.Tables(0).Rows(x)("user_id").ToString())(1)
                    Dim keycard_number As String = GetKeycardName(admindata.Tables(0).Rows(x)("keycard_id").ToString())
                    Dim locker_number As String = GetLockerName(admindata.Tables(0).Rows(x)("locker_id").ToString())
                    Dim status As String = admindata.Tables(0).Rows(x)("status").ToString()
                    Dim time_out As String

                    Dim timeInDate As DateTime = admindata.Tables(0).Rows(x)("time_in")
                    Dim in_date = timeInDate.ToString("MMM dd  yyyy")
                    Dim time_in = timeInDate.ToString("h:mm tt")

                    Dim out As String = admindata.Tables(0).Rows(x)("time_out").ToString()

                    If String.IsNullOrEmpty(out) Then
                        time_out = out
                    Else
                        Dim timeOutDate As DateTime = admindata.Tables(0).Rows(x)("time_out")
                        time_out = timeOutDate.ToString("h:mm tt")
                    End If


                    admintable.Rows.Add(id, name, student_id, locker_number, UppercaseFirstLetter(status), in_date, time_in, time_out)
                Next

                DgvBaggages.DataSource = admintable
                DgvBaggages.RowHeadersVisible = False
                DgvBaggages.Columns(0).Visible = False
            End If


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs)
        If String.IsNullOrEmpty(TxtSearch.Text) Then
            LblSearch.Visible = True
            AdminLoadTable()
        Else
            LblSearch.Visible = False
            SearchResult()
        End If
    End Sub

    Sub SearchResult()
        Try

            OpenCon()

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM baggages WHERE time_out LIKE '%" & TxtSearch.Text & "%' OR time_in LIKE '%" & TxtSearch.Text & "%' OR student_id LIKE '%" & TxtSearch.Text & "%' OR name LIKE '%" & TxtSearch.Text & "%' OR keycard_number LIKE '%" & TxtSearch.Text & "%' OR status LIKE '%" & TxtSearch.Text & "%' ORDER BY time_in DESC"
            adapter.SelectCommand = cmd
            admintable.Clear()
            admindata.Clear()

            If adapter.Fill(admindata) Then

                For x As Integer = 0 To admindata.Tables(0).Rows.Count - 1

                    Dim id As String = admindata.Tables(0).Rows(x)("id").ToString()
                    Dim name As String = admindata.Tables(0).Rows(x)("name").ToString()
                    Dim student_id As String = admindata.Tables(0).Rows(x)("student_id").ToString()
                    Dim keycard_number As String = admindata.Tables(0).Rows(x)("keycard_number").ToString()
                    Dim status As String = admindata.Tables(0).Rows(x)("status").ToString()
                    Dim time_out As String

                    Dim timeInDate As DateTime = admindata.Tables(0).Rows(x)("time_in")
                    Dim in_date = timeInDate.ToString("MMM dd  yyyy")
                    Dim time_in = timeInDate.ToString("h:mm tt")

                    Dim out As String = admindata.Tables(0).Rows(x)("time_out").ToString()

                    If String.IsNullOrEmpty(out) Then
                        time_out = out
                    Else
                        Dim timeOutDate As DateTime = admindata.Tables(0).Rows(x)("time_out")
                        time_out = timeOutDate.ToString("h:mm tt")
                    End If


                    admintable.Rows.Add(id, name, student_id, keycard_number, UppercaseFirstLetter(status), in_date, time_in, time_out)
                Next

                DgvBaggages.DataSource = admintable
                DgvBaggages.RowHeadersVisible = False
                DgvBaggages.Columns(0).Visible = False
            End If

            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub DgvBaggages_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs)
        ChangeCellColor(DgvBaggages)
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        MainFrm.showRegisterForm = True
    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Authenticate()
        If authenticated = True Then
            PnlLogin.SendToBack()
            PnlStudNum.Visible = True
            BtnAdd.Visible = True
            LblTitle.Visible = False
        Else
            MessageBox.Show("Invalid username and password combination.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub TimerAdminUserControl_Tick(sender As Object, e As EventArgs) Handles TimerAdminUserControl.Tick
        If historyTableRefresh Then
            AdminLoadTable()
            historyTableRefresh = False
        End If
    End Sub
End Class
