Public Class VisitorGetUserControl
    Dim visitorIdDate As String
    Dim visitorIdCount As String
    Dim authenticated As Boolean
    Dim name As String
    Dim id As String
    Dim keyCard As String
    Dim keyCardIsStillInUse As Boolean
    Private Sub VisitorGetUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '' Visitor id should change every day and based from visitor that are coming each day
        GenerateVisitorId()
        ShowFirstElements()
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        CheckPassword()
        If authenticated = False Then
            MessageBox.Show("Please enter the correct Admin Password", "Oops!")
        Else
            HideFirstElements()
            name = TxtVisitorName.Text
            id = TxtVisitorId.Text
        End If
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
            Dim result1 As DialogResult = MessageBox.Show("Visitor Id Number: " & id & vbCrLf & "Keycard Number: " & keyCard,
            "Confirm Information",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Information)

            If result1 = DialogResult.OK Then
                SaveBaggageData()
                SaveVistorData()
                ShowFirstElements()
                ClearFields()
                GenerateVisitorId()
            End If
        End If
    End Sub
    Sub ClearFields()
        TxtKeycard.Clear()
        TxtPassword.Clear()
        TxtVisitorId.Clear()
        TxtVisitorName.Clear()
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
        PnlPassword.Visible = False
        PnlVisitorId.Visible = False
        PnlVisitorName.Visible = False

        LblPassword.Visible = False
        LblVisitorId.Visible = False
        LblVisitorName.Visible = False

        BtnNext.Visible = False

        PnlKeycard.Visible = True
        LblKeycard.Visible = True
        BtnBack.Visible = True
        BtnSubmit.Visible = True
    End Sub
    Sub ShowFirstElements()
        PnlPassword.Visible = True
        PnlVisitorId.Visible = True
        PnlVisitorName.Visible = True

        LblPassword.Visible = True
        LblVisitorId.Visible = True
        LblVisitorName.Visible = True

        BtnNext.Visible = True

        PnlKeycard.Visible = False
        LblKeycard.Visible = False
        BtnBack.Visible = False
        BtnSubmit.Visible = False
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
    Sub SaveBaggageData()
        OpenCon()
        Try
            Dim time_in = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO baggages (`name`, `student_id`, `keycard_number`, `status`, `time_in`) VALUES ('" & name & "', '" & id & "', '" & keyCard & "', 'occupied', '" & time_in & "')"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Keycard number " & keyCard & " is now occupied by Visitor " & name & ".", "Library Baggage System")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub SaveVistorData()
        OpenCon()
        Try
            cmd.Connection = con
            cmd.CommandText = "INSERT INTO users (`name`, `student_id`, `type`) VALUES ('" & name & "', '" & id & "', 'visitor')"
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
            cmd.CommandText = "SELECT * FROM baggages WHERE student_id LIKE '%" & visitorIdDate & "%'"
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
End Class
