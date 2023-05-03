Imports System.IO.Ports
Imports Microsoft.VisualBasic.ApplicationServices

Public Class MainFrm
    Public dataMask As String = ""
    Public lockerMask As String = ""
    Public showRegisterForm As Boolean = False
    Public showMainUC As Boolean = False
    Public adminBtnClicked As Boolean = False
    Public refreshAllTables As Boolean = False
    Public refreshKeycardCount As Boolean = False

    Dim _GetUserControl As New GetUserControl
    Dim _MainUserControl As New MainUserControl
    Dim _AdminUserControl As New AdminUserControl
    Dim _LoginUserControl As New LoginUserControl
    Dim _VisitorGetUserControl As New VisitorGetUserControl
    Dim _RegisterUserControl As New RegisterUserControl

    Dim keycardId As String = ""
    Dim userId As String = ""
    Dim baggageId As String = ""
    Dim lockerId As String = ""
    Dim userType As String = ""
    Dim userName As String = ""
    Dim lockerName As String = ""

    Dim keycardCounter As Integer = 0
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub MainFrm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeycardCount()
        PnlHome.Controls.Add(_MainUserControl)
        BtnHome.Enabled = False
        adminBtnClicked = False
        TimerForUserControl.Enabled = True
    End Sub

    Private Sub PbAdmin_MouseHover(sender As Object, e As EventArgs) Handles PbAdmin.MouseHover
        PbAdmin.BorderStyle = BorderStyle.FixedSingle
    End Sub

    Private Sub PbAdmin_MouseLeave(sender As Object, e As EventArgs) Handles PbAdmin.MouseLeave
        PbAdmin.BorderStyle = BorderStyle.None
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        _MainUserControl.BringToFront()
        PnlHome.BringToFront()

        EnableButtons()
        BtnHome.Enabled = False
        adminBtnClicked = False
    End Sub

    Private Sub PbAdmin_Click(sender As Object, e As EventArgs) Handles PbAdmin.Click
        PnlHome.Controls.Add(_AdminUserControl)
        _AdminUserControl.BringToFront()

        adminBtnClicked = True
        PbAdmin.Enabled = False
        EnableButtons()
    End Sub

    Private Sub BtnGet_Click(sender As Object, e As EventArgs)
        PnlHome.Controls.Add(_GetUserControl)
        _GetUserControl.BringToFront()

        EnableButtons()

    End Sub

    Private Sub BtnReturn_Click(sender As Object, e As EventArgs) Handles BtnVisitor.Click
        PnlHome.Controls.Add(_VisitorGetUserControl)
        _VisitorGetUserControl.BringToFront()

        EnableButtons()
        BtnVisitor.Enabled = False
    End Sub

    Sub EnableButtons()
        BtnHome.Enabled = True
        BtnVisitor.Enabled = True
        PbAdmin.Enabled = True
    End Sub

    Private Sub BtnConnect_Click(sender As Object, e As EventArgs) Handles BtnConnect.Click
        ConnectScannerCOM()
        ConnectLockerCOM()
    End Sub

    Sub ConnectLockerCOM()
        Try
            LockerSerialPort.Close()
            LockerSerialPort.BaudRate = Val(TxtBaudrate.Text)
            LockerSerialPort.PortName = TxtLockerCOM.Text
            LockerSerialPort.DataBits = 8
            LockerSerialPort.Parity = Parity.None
            LockerSerialPort.StopBits = StopBits.One
            LockerSerialPort.Handshake = Handshake.None
            LockerSerialPort.Encoding = System.Text.Encoding.Default
            LockerSerialPort.ReadTimeout = 10000
            LockerSerialPort.Open()
            If LockerSerialPort.IsOpen Then
                PBLockerConnection.BackColor = Color.Green
                'PBDisplayConnection.BackColor = Color.Green
                TimerSerial.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Sub ConnectScannerCOM()
        Try
            DesktopScannerSerialPort.Close()
            DesktopScannerSerialPort.BaudRate = Val(TxtBaudrate.Text)
            DesktopScannerSerialPort.PortName = TxtScannerCOM.Text
            DesktopScannerSerialPort.DataBits = 8
            DesktopScannerSerialPort.Parity = Parity.None
            DesktopScannerSerialPort.StopBits = StopBits.One
            DesktopScannerSerialPort.Handshake = Handshake.None
            DesktopScannerSerialPort.Encoding = System.Text.Encoding.Default
            DesktopScannerSerialPort.ReadTimeout = 10000
            DesktopScannerSerialPort.Open()
            If DesktopScannerSerialPort.IsOpen Then
                PBConnection.BackColor = Color.Green
                PBDisplayConnection.BackColor = Color.Green
                TimerSerial.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub PBDisplayConnection_Click(sender As Object, e As EventArgs) Handles PBDisplayConnection.Click
        PnlConnection.Visible = True
    End Sub

    Private Sub PBConnection_Click(sender As Object, e As EventArgs) Handles PBConnection.Click
        PnlConnection.Visible = False
    End Sub

    Private Sub TimerSerial_Tick(sender As Object, e As EventArgs) Handles TimerSerial.Tick
        LblDataMask.Text = dataMask
        TxtDataMask.Text = dataMask
        _VisitorGetUserControl.rfid = dataMask
        _RegisterUserControl.rfid = dataMask
        TxtLockerMask.Text = lockerMask
        LblDataMask.Text = lockerMask
    End Sub

    Private Sub TxtDataMask_TextChanged(sender As Object, e As EventArgs) Handles TxtDataMask.TextChanged
        refreshAllTables = True
        If TxtDataMask.Text <> "" Then
            CheckKeycard()
            If keycardId = "" And BtnVisitor.Enabled = True And adminBtnClicked = False Then
                MessageBox.Show("Unregistered keycard, keycard details not found!", "Oops!")
            ElseIf userId = "" And BtnVisitor.Enabled = True And adminBtnClicked = False Then
                MessageBox.Show("No user has been assigned on this keycard yet.", "Oops!")
            ElseIf userId <> "" And keycardId <> "" Then
                GetBaggageDetail()
                If baggageId <> "" Then
                    Logout()
                    MessageBox.Show("Logged out successfully.", Title())
                    refreshAllTables = True
                Else
                    Login()
                    refreshAllTables = True
                End If
            End If
        End If
    End Sub

    Sub CheckKeycard()
        Try
            Dim rfid = GetTen(TxtDataMask.Text)
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM keycards WHERE rfid LIKE '%" & rfid & "%' LIMIT 1"
            adapter.SelectCommand = cmd
            data.Clear()

            If adapter.Fill(data) Then
                For x As Integer = 0 To data.Tables(0).Rows.Count - 1

                    keycardId = data.Tables(0).Rows(x)("id").ToString()
                    userId = data.Tables(0).Rows(x)("user_id").ToString()

                Next
            Else
                keycardId = ""
                userId = ""
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub CheckLockerKeycard()
        Try
            Dim rfid = GetTen(TxtLockerMask.Text)
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM keycards WHERE rfid LIKE '%" & rfid & "%' LIMIT 1"
            adapter.SelectCommand = cmd
            data.Clear()

            If adapter.Fill(data) Then
                For x As Integer = 0 To data.Tables(0).Rows.Count - 1

                    keycardId = data.Tables(0).Rows(x)("id").ToString()
                    userId = data.Tables(0).Rows(x)("user_id").ToString()

                Next
            Else
                keycardId = ""
                userId = ""
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub Logout()
        GetBaggageDetail()
        GetUserDetail()
        UpdateBaggage()
        UpdateLocker()
        If userType = "visitor" Then
            UpdateKeycard()
        End If
        ClearVariables()
    End Sub

    Sub ClearVariables()
        keycardId = ""
        userId = ""
        baggageId = ""
        lockerId = ""
        userType = ""
        userName = ""
        dataMask = ""
    End Sub

    Sub GetBaggageDetail()
        Try
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM baggages WHERE keycard_id = '" & keycardId & "' AND user_id = '" & userId & "' AND status = 'occupied' LIMIT 1"
            adapter.SelectCommand = cmd
            data.Clear()

            If adapter.Fill(data) Then
                For x As Integer = 0 To data.Tables(0).Rows.Count - 1

                    baggageId = data.Tables(0).Rows(x)("id").ToString()
                    lockerId = data.Tables(0).Rows(x)("locker_id").ToString()

                Next
            Else
                baggageId = ""
                lockerId = ""
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub GetUserDetail()
        Try
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM users WHERE id = '" & userId & "' LIMIT 1"
            adapter.SelectCommand = cmd
            data.Clear()

            If adapter.Fill(data) Then
                For x As Integer = 0 To data.Tables(0).Rows.Count - 1

                    userType = data.Tables(0).Rows(x)("type").ToString()
                    userName = data.Tables(0).Rows(x)("name").ToString()

                Next
            Else
                userType = ""
                userName = ""
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub UpdateBaggage()
        OpenCon()
        Try
            Dim time_out = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            cmd.Connection = con
            cmd.CommandText = "UPDATE baggages SET status='available', time_out='" & time_out & "' WHERE id='" & baggageId & "'"
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub UpdateLocker()
        OpenCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "UPDATE lockers SET status='available' WHERE id='" & lockerId & "'"
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
            cmd.CommandText = "UPDATE keycards SET user_id=NULL WHERE id='" & keycardId & "'"
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub Login()
        CheckAndGetAvailableLocker()
        GetUserDetail()
        If lockerName = "" Then
            MessageBox.Show("No available locker yet.", "Oops!")
        Else
            Dim result1 As DialogResult = MessageBox.Show("Student: " & userName & vbCrLf & "Locker Number: " & lockerName,
            "Confirm Information",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Information)

            If result1 = DialogResult.OK Then
                SaveBaggageData()
                UpdateLockerStatus()
                ClearVariables()
                MessageBox.Show("Locker Number " & lockerName & " is now occupied by Student " & userName & ".", Title())
            End If
        End If
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

    Sub SaveBaggageData()
        OpenCon()
        Try
            Dim time_in = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO baggages (`user_id`, `keycard_id`, `locker_id`, `status`, `time_in`) VALUES ('" & userId & "', '" & keycardId & "', '" & lockerId & "', 'occupied', '" & time_in & "')"
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
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

    Sub SendSerialData(lockerName As String)
        LockerSerialPort.Write(String.Format(lockerName))
    End Sub

    Private Sub DesktopScannerSerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles DesktopScannerSerialPort.DataReceived
        dataMask = DesktopScannerSerialPort.ReadLine()
    End Sub

    Private Sub LockerSerialPort_DataReceived(sender As Object, e As SerialDataReceivedEventArgs) Handles LockerSerialPort.DataReceived
        lockerMask = LockerSerialPort.ReadLine()
    End Sub

    Private Sub TxtLockerMask_TextChanged(sender As Object, e As EventArgs) Handles TxtLockerMask.TextChanged
        If TxtLockerMask.Text <> "" Then
            Dim lockerName As String = "xxxxxxxxxx"
            CheckLockerKeycard()
            If keycardId <> "" And userId <> "" Then
                GetBaggageDetail()
                If baggageId <> "" And lockerId <> "" Then
                    lockerName = GetLockerName(lockerId)
                    SendSerialData(lockerName)
                    'MessageBox.Show("Access Granted!", Title())
                    lockerMask = ""
                Else
                    SendSerialData(lockerName)
                    'MessageBox.Show("Access Denied!", Title())
                    lockerMask = ""
                End If
            Else
                SendSerialData(lockerName)
            End If
        End If
    End Sub

    Private Sub TimerForUserControl_Tick(sender As Object, e As EventArgs) Handles TimerForUserControl.Tick
        If refreshKeycardCount Then
            KeycardCount()
            refreshKeycardCount = False
        End If
        If refreshAllTables Then
            _MainUserControl.mainTableRefresh = True
            _LoginUserControl.historyTableRefresh = True
            refreshAllTables = False
        End If
        If showRegisterForm Then
            PnlHome.Controls.Add(_RegisterUserControl)
            _RegisterUserControl.BringToFront()

            EnableButtons()
            showRegisterForm = False
        End If

        If showMainUC Then
            PnlHome.Controls.Add(_MainUserControl)
            _MainUserControl.BringToFront()

            EnableButtons()
            showMainUC = False
        End If
    End Sub

    Sub KeycardCount()
        Try
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT Count(*) FROM keycards"
            adapter.SelectCommand = cmd
            data.Clear()

            If adapter.Fill(data) Then
                For x As Integer = 0 To data.Tables(0).Rows.Count - 1

                    keycardCounter = data.Tables(0).Rows(x)("count(*)") + 1

                Next
            Else
                keycardCounter = keycardCounter + 1
            End If

            _RegisterUserControl.keycardCounter = keycardCounter
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class
