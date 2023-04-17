Public Class GetUserControl
    Dim studentId As String
    Dim studentName As String
    Dim keyCard As String
    Dim keyCardIsStillInUse As Boolean
    Dim studentNotAvailable As Boolean
    Dim studentBaggageName As String
    Dim studentBaggageKeycard As String

    Dim VisitorUserControl As New VisitorGetUserControl

    Private Sub BtnHome_Click(sender As Object, e As EventArgs)
        Me.SendToBack()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        'This button should open the card storage and give a card
        Try
            GetStudentData()
            CheckStudentCredibility()
            If String.IsNullOrEmpty(studentId) Then
                MessageBox.Show("Student Number not found.", "Oops!")
            ElseIf studentNotAvailable = True Then
                MessageBox.Show("Student " & studentBaggageName & " still has the keycard " & studentBaggageKeycard & ".", "Oops!")
            Else
                HideFirstElements()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub
    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        ShowFirstElements()
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        GetKeycardData()
        CheckKeycardAvailability()
        If String.IsNullOrEmpty(keyCard) Then
            MessageBox.Show("Keycard Number not found.", "Oops!")
        ElseIf keyCardIsStillInUse = True Then
            MessageBox.Show("The keycard was still in use.", "Oops!")
        Else
            Dim result1 As DialogResult = MessageBox.Show("Student Number: " & studentId & vbCrLf & "Keycard Number: " & keyCard,
            "Confirm Information",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Information)

            If result1 = DialogResult.OK Then
                SaveData()
                ShowFirstElements()
                ClearFields()
            End If
        End If
    End Sub

    Sub SaveData()
        OpenCon()
        Try
            Dim time_in = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO baggages (`name`, `student_id`, `keycard_number`, `status`, `time_in`) VALUES ('" & studentName & "', '" & studentId & "', '" & keyCard & "', 'occupied', '" & time_in & "')"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Keycard number " & keyCard & " is now occupied by " & studentName & ".", "Library Baggage System")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub HideFirstElements()
        LblStudNum.Visible = False
        PnlStudNum.Visible = False
        BtnNext.Visible = False
    End Sub
    Sub ShowFirstElements()
        LblStudNum.Visible = True
        PnlStudNum.Visible = True
        BtnNext.Visible = True
    End Sub
    Sub ClearFields()
        TxtId.Clear()
        TxtKeycard.Clear()
    End Sub

    Sub GetStudentData()
        Try
            OpenCon()

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM users WHERE type ='student' AND student_id='" & TxtId.Text & "' LIMIT 1"
            adapter.SelectCommand = cmd
            data.Clear()

            If adapter.Fill(data) Then
                For x As Integer = 0 To data.Tables(0).Rows.Count - 1

                    Dim student_id As String = data.Tables(0).Rows(x)("student_id").ToString()
                    Dim student_name As String = data.Tables(0).Rows(x)("name").ToString()

                    studentId = student_id
                    studentName = student_name

                Next

            Else
                studentId = ""
                studentName = ""
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub GetKeycardData()
        Try
            OpenCon()

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM keycards WHERE keycard_number='" & TxtKeycard.Text & "' LIMIT 1"
            adapter.SelectCommand = cmd
            data.Clear()

            If adapter.Fill(data) Then
                For x As Integer = 0 To data.Tables(0).Rows.Count - 1

                    Dim keycard_number As String = data.Tables(0).Rows(x)("keycard_number").ToString()

                    keyCard = keycard_number

                Next

            Else
                keyCard = ""
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
            cmd.CommandText = "SELECT * FROM baggages WHERE keycard_number='" & keyCard & "' AND status='occupied' LIMIT 1"
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

    Sub CheckStudentCredibility()
        Try
            OpenCon()

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM baggages WHERE student_id='" & studentId & "' AND status='occupied' LIMIT 1"
            adapter.SelectCommand = cmd
            data.Clear()

            If adapter.Fill(data) Then
                For x As Integer = 0 To data.Tables(0).Rows.Count - 1

                    Dim keycard_number As String = data.Tables(0).Rows(x)("keycard_number").ToString()
                    Dim name As String = data.Tables(0).Rows(x)("name").ToString()

                    studentNotAvailable = True
                    studentBaggageName = name
                    studentBaggageKeycard = keycard_number
                Next
            Else
                studentNotAvailable = False
                studentBaggageName = ""
                studentBaggageKeycard = ""
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub GetUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
