Public Class RegisterUserControl
    Dim StudentId As String = ""
    Dim StudentName As String = ""
    Public rfid As String = ""
    Public keycardCounter As Integer
    Dim keycardExist As Boolean = False
    Dim lockerExist As Boolean = False

    Private Sub BtnUser_Click(sender As Object, e As EventArgs) Handles BtnUser.Click
        PnlNewUser.BringToFront()
    End Sub

    Private Sub BtnAddUser_Click(sender As Object, e As EventArgs) Handles BtnAddUser.Click
        If TxtKeycard.Text <> "" And TxtRFID.Text <> "" And TxtName.Text <> "" And TxtStudentId.Text <> "" Then
            SaveStudent()
            GetStudentDetails()
            SaveRFID(StudentId)
            MainFrm.showMainUC = True
            ClearFields()
            MainFrm.refreshKeycardCount = True
            MessageBox.Show("Student has been successfully added!", Title())
        Else
            MessageBox.Show("All fields are required!", Title())
        End If

    End Sub

    Sub ClearFields()
        TxtKeycard.Text = ""
        TxtRFID.Text = ""
        TxtName.Text = ""
        TxtStudentId.Text = ""
        MainFrm.dataMask = ""
        TxtKeyName.Text = ""
        TxtKeyRFID.Text = ""
        TxtLockerNumber.Text = ""
    End Sub

    Sub SaveStudent()
        OpenCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO users (`name`, `student_id`, `type`) VALUES ('" & TxtName.Text & "', '" & TxtStudentId.Text & "', 'student')"
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub GetStudentDetails()
        Try
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM users WHERE name='" & TxtName.Text & "' AND student_id='" & TxtStudentId.Text & "' AND type='student' LIMIT 1"
            adapter.SelectCommand = cmd
            data.Clear()

            If adapter.Fill(data) Then
                For x As Integer = 0 To data.Tables(0).Rows.Count - 1

                    StudentId = data.Tables(0).Rows(x)("id").ToString()
                    StudentName = data.Tables(0).Rows(x)("name").ToString()

                Next
            Else
                StudentId = ""
                StudentName = ""
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub CheckKeycard()
        Try
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM keycards WHERE rfid LIKE '%" & GetTen(TxtKeyRFID.Text) & "%' LIMIT 1"
            adapter.SelectCommand = cmd
            data.Clear()

            If adapter.Fill(data) Then
                For x As Integer = 0 To data.Tables(0).Rows.Count - 1

                    keyCardExist = True

                Next
            Else
                keyCardExist = False
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub SaveRFID(studentId As String)
        OpenCon()
        Try
            cmd.Connection = con
            If studentId <> "" Then
                cmd.CommandText = "INSERT INTO keycards (`rfid`, `keycard_number`, `user_id`) VALUES ('" & TxtRFID.Text & "', '" & TxtKeycard.Text & "', '" & studentId & "')"
            Else
                cmd.CommandText = "INSERT INTO keycards (`rfid`, `keycard_number`) VALUES ('" & TxtKeyRFID.Text & "', '" & TxtKeyName.Text & "')"
            End If
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TimerRegisterUserControl_Tick(sender As Object, e As EventArgs) Handles TimerRegisterUserControl.Tick
        TxtRFID.Text = rfid
        TxtKeyRFID.Text = rfid
        TxtKeycard.Text = keycardCounter.ToString("D3")
        TxtKeyName.Text = keycardCounter.ToString("D3")
    End Sub

    Private Sub RegisterUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TimerRegisterUserControl.Enabled = True
    End Sub

    Private Sub BtnKey_Click(sender As Object, e As EventArgs) Handles BtnKey.Click
        PnlNewKey.BringToFront()
    End Sub

    Private Sub BtnAddKey_Click(sender As Object, e As EventArgs) Handles BtnAddKey.Click
        If TxtKeyName.Text <> "" And TxtKeyRFID.Text <> "" Then
            CheckKeycard()
            If keycardExist Then
                MessageBox.Show("RFID already exist, Please scan a different one!", Title())
            Else
                SaveRFID("")
                MainFrm.showMainUC = True
                ClearFields()
                MainFrm.adminBtnClicked = False
                MainFrm.refreshKeycardCount = True
                MessageBox.Show("Key has been successfully added!", Title())
            End If
        Else
            MessageBox.Show("All fields are required!", Title())
        End If
    End Sub

    Private Sub BtnKeyBack_Click(sender As Object, e As EventArgs) Handles BtnKeyBack.Click
        PnlMenu.BringToFront()
    End Sub

    Private Sub BtnUserBack_Click(sender As Object, e As EventArgs) Handles BtnUserBack.Click
        PnlMenu.BringToFront()
    End Sub

    Private Sub BtnAddLocker_Click(sender As Object, e As EventArgs) Handles BtnAddLocker.Click
        MainFrm.refreshAllTables = True
        If TxtLockerNumber.Text <> "" Then
            CheckLockerName()
            If lockerExist Then
                MessageBox.Show("Locker Number already exist, Please enter a different one!", Title())
                MainFrm.refreshAllTables = True
            Else
                SaveLocker()
                MainFrm.showMainUC = True
                ClearFields()
                MainFrm.adminBtnClicked = False
                MessageBox.Show("Locker has been successfully added!", Title())
                MainFrm.refreshAllTables = True
            End If
        Else
            MessageBox.Show("Locker Number field is required!", Title())
        End If
    End Sub

    Sub CheckLockerName()
        Try
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM lockers WHERE name = '" & TxtLockerNumber.Text & "' LIMIT 1"
            adapter.SelectCommand = cmd
            data.Clear()

            If adapter.Fill(data) Then
                For x As Integer = 0 To data.Tables(0).Rows.Count - 1

                    lockerExist = True

                Next
            Else
                lockerExist = False
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub SaveLocker()
        OpenCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO lockers (`name`, `status`) VALUES ('" & TxtLockerNumber.Text & "', 'available')"
            cmd.ExecuteNonQuery()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnLocker_Click(sender As Object, e As EventArgs) Handles BtnLocker.Click
        PnlNewLocker.BringToFront()
    End Sub

    Private Sub BtnLockerBack_Click(sender As Object, e As EventArgs) Handles BtnLockerBack.Click
        PnlMenu.BringToFront()
    End Sub

    Private Sub PnlNewUser_Paint(sender As Object, e As PaintEventArgs) Handles PnlNewUser.Paint

    End Sub
End Class
