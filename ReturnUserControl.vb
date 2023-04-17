Public Class ReturnUserControl
    Dim keyCard As String
    Dim studentId As String
    Dim studentName As String
    Dim baggageId As String
    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles BtnNext.Click
        Try
            CheckKeyCard()
            If String.IsNullOrEmpty(keyCard) Then
                MessageBox.Show("The keycard number is either not in occupied or does not exist.", "Oops!")
            Else
                HideFirstElements()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs) Handles BtnSubmit.Click
        Try
            CheckBaggage()
            If String.IsNullOrEmpty(studentId) Then
                MessageBox.Show("The ID Number and keycard number do not match on any occupied locker.", "Oops!")
            Else
                UpdateBaggageStatus()
                ClearFields()
                ShowFirstElements()
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles BtnBack.Click
        ShowFirstElements()
    End Sub
    Sub HideFirstElements()
        LblKeycard.Visible = False
        PnlKeycard.Visible = False
        BtnNext.Visible = False
    End Sub
    Sub ShowFirstElements()
        LblKeycard.Visible = True
        PnlKeycard.Visible = True
        BtnNext.Visible = True
    End Sub
    Sub ClearFields()
        TxtId.Clear()
        TxtKeycard.Clear()
    End Sub

    Sub CheckKeyCard()
        Try
            OpenCon()

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM baggages WHERE keycard_number='" & TxtKeycard.Text & "' AND status='occupied' LIMIT 1"
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

    Sub CheckBaggage()
        Try
            OpenCon()

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM baggages WHERE student_id = '" & TxtId.Text & "' AND keycard_number = '" & keyCard & "' AND status = 'occupied' LIMIT 1"
            adapter.SelectCommand = cmd
            data.Clear()

            If adapter.Fill(data) Then
                For x As Integer = 0 To data.Tables(0).Rows.Count - 1

                    Dim student_id As String = data.Tables(0).Rows(x)("student_id").ToString()
                    Dim name As String = data.Tables(0).Rows(x)("name").ToString()
                    Dim id As String = data.Tables(0).Rows(x)("id").ToString()
                    studentId = student_id
                    studentName = name
                    baggageId = id

                Next
            Else
                studentId = ""
                studentName = ""
                baggageId = ""
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
    Sub UpdateBaggageStatus()
        OpenCon()
        Try
            Dim time_out = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")
            cmd.Connection = con
            cmd.CommandText = "UPDATE baggages SET status = 'available' , time_out = '" & time_out & "' WHERE Id = '" & baggageId & "'"
            cmd.ExecuteNonQuery()
            MessageBox.Show("Keycard number " & keyCard & " is now available.", "Library Baggage System")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

End Class
