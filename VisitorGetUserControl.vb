Imports System.Text
Imports Org.BouncyCastle.Asn1.Ocsp

Public Class VisitorGetUserControl
    Dim visitorIdDate As String
    Dim visitorIdCount As String
    Dim authenticated As Boolean
    Dim visitorname As String
    Dim id As String
    Dim userId As String
    Dim keyCardId As String
    Dim keyCardIsStillInUse As Boolean
    Dim lockerId As String
    Dim lockerName As String
    Public rfid As String = ""
    Private Sub VisitorGetUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Visitor id should change every day and based from the number of visitor that are coming each day
        GenerateVisitorId()
        ShowFirstElements()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click

        If TxtVisitorName.Text <> "" Then
            CheckPassword()
            If authenticated = False Then
                MessageBox.Show("Please enter the correct Admin Password", "Oops!")
            Else
                HideFirstElements()
                visitorname = TxtVisitorName.Text
                LblVisitorInfoName.Text = visitorname
                id = TxtVisitorId.Text
                TimerVisitor.Enabled = True
            End If
        Else
            MessageBox.Show("Visitor name field is required.", Title())
        End If

    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        ShowFirstElements()
        TimerVisitor.Enabled = False
        ClearRFID()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click

    End Sub
    Sub ClearFields()
        TxtKeycard.Clear()
        TxtPassword.Clear()
        TxtVisitorId.Clear()
        TxtVisitorName.Clear()
        ClearRFID()
    End Sub

    Sub ClearRFID()
        MainFrm.dataMask = ""
    End Sub

    Sub CheckPassword()
        Try
            OpenCon()

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM users WHERE type ='admin' AND password='" & TxtPassword.Text & "' LIMIT 1"
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
    Sub HideFirstElements()
        PnlVisitorInput.SendToBack()
    End Sub
    Sub ShowFirstElements()
        PnlVisitorInput.BringToFront()
    End Sub

    Sub GetKeycardData(_rfid As String)
        Try
            _rfid = GetTen(_rfid)
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM keycards WHERE rfid LIKE '%" & _rfid & "%' LIMIT 1"
            adapter.SelectCommand = cmd
            data.Clear()

            If adapter.Fill(data) Then
                For x As Integer = 0 To data.Tables(0).Rows.Count - 1

                    Dim keycard_id As String = data.Tables(0).Rows(x)("id").ToString()
                    keyCardId = keycard_id

                Next

            Else
                keyCardId = ""
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub CheckKeycardAvailability()
        Try
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM baggages WHERE keycard_id='" & keyCardId & "' AND status='occupied' LIMIT 1"
            adapter.SelectCommand = cmd
            data.Clear()

            If adapter.Fill(data) Then
                For x As Integer = 0 To data.Tables(0).Rows.Count - 1

                    keyCardIsStillInUse = True

                Next
            Else
                keyCardIsStillInUse = False
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub SaveBaggageData()
        OpenCon()
        Try
            Dim time_in = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO baggages (`user_id`, `keycard_id`, `locker_id`, `status`, `time_in`) VALUES ('" & userId & "', '" & keyCardId & "', '" & lockerId & "', 'occupied', '" & time_in & "')"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Locker Number " & lockerName & " is now occupied by Visitor " & visitorname & ".", Title())
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub SaveVisitorData()
        OpenCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO users (`name`, `student_id`, `type`) VALUES ('" & visitorname & "', '" & id & "', 'visitor')"
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub GenerateVisitorId()
        Try
            OpenCon()

            visitorIdDate = DateTime.Now.ToString("yyyyMMdd")

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM users WHERE student_id LIKE '%" & visitorIdDate & "%'"
            adapter.SelectCommand = cmd
            data.Clear()

            If adapter.Fill(data) Then
                visitorIdCount = data.Tables(0).Rows.Count + 1

                TxtVisitorId.Text = visitorIdDate & "-" & visitorIdCount.ToString().PadLeft(3, "0")
            Else
                TxtVisitorId.Text = visitorIdDate & "-001"
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TimerVisitor_Tick(sender As Object, e As EventArgs) Handles TimerVisitor.Tick
        TxtKeycard.Text = rfid.ToString()
    End Sub

    Private Sub TxtKeycard_TextChanged(sender As Object, e As EventArgs) Handles TxtKeycard.TextChanged
        MainFrm.refreshAllTables = True
        If (TxtKeycard.Text <> "") Then
            GetKeycardData(TxtKeycard.Text)
            CheckKeycardAvailability()
            CheckAndGetAvailableLocker()
            If String.IsNullOrEmpty(keyCardId) Then
                MessageBox.Show("Keycard not found.", "Oops!")
            ElseIf keyCardIsStillInUse = True Then
                MessageBox.Show("The keycard was still in use.", "Oops!")
            ElseIf lockerName = "" Then
                MessageBox.Show("No available locker yet.", "Oops!")
            Else
                Dim result1 As DialogResult = MessageBox.Show("Visitor Id Number: " & id & vbCrLf & "Locker Number: " & lockerName,
                    "Confirm Information",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Information)

                If result1 = DialogResult.OK Then
                    SaveVisitorData()
                    GetVisitorData()
                    SaveBaggageData()
                    UpdateLockerStatus()
                    UpdateKeycard()
                    ShowFirstElements()
                    ClearFields()
                    GenerateVisitorId()
                    MainFrm.refreshAllTables = True
                End If
            End If
            TimerVisitor.Enabled = False
        End If
    End Sub

    Sub CheckAndGetAvailableLocker()
        Try
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM lockers WHERE status = 'available' LIMIT 1"
            adapter.SelectCommand = cmd
            data.Clear()

            If adapter.Fill(data) Then
                For x As Integer = 0 To data.Tables(0).Rows.Count - 1

                    lockerId = data.Tables(0).Rows(x)("id").ToString()
                    lockerName = data.Tables(0).Rows(x)("name").ToString()

                Next
            Else
                lockerId = ""
                lockerName = ""
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub GetVisitorData()
        Try
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM users WHERE student_id = '" & id & "' LIMIT 1"
            adapter.SelectCommand = cmd
            data.Clear()

            If adapter.Fill(data) Then
                For x As Integer = 0 To data.Tables(0).Rows.Count - 1

                    userId = data.Tables(0).Rows(x)("id").ToString()

                Next
            Else
                userId = ""
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub UpdateLockerStatus()
        OpenCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE lockers SET status='occupied' WHERE id='" & lockerId & "'"
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub UpdateKeycard()
        OpenCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE keycards SET user_id='" & userId & "' WHERE id='" & keyCardId & "'"
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class
