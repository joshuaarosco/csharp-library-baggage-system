Imports Microsoft.VisualBasic.ApplicationServices

Module GetDetails
    Dim lockerName As String = ""
    Dim keycardName As String = ""
    Dim userName As String = ""
    Dim studId As String = ""
    Public Function GetLockerName(lockerId As String) As String
        Try
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM lockers WHERE id = '" & lockerId & "' LIMIT 1"
            adapter.SelectCommand = cmd
            data.Clear()

            If adapter.Fill(data) Then
                For x As Integer = 0 To data.Tables(0).Rows.Count - 1

                    lockerName = data.Tables(0).Rows(x)("name").ToString()

                Next
            Else
                lockerName = "xxxxxxxxxx"
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return lockerName
    End Function

    Public Function GetKeycardName(keycardId As String) As String
        Try
            OpenCon()
            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM keycards WHERE id = '" & keycardId & "' LIMIT 1"
            adapter.SelectCommand = cmd
            data.Clear()

            If adapter.Fill(data) Then
                For x As Integer = 0 To data.Tables(0).Rows.Count - 1
                    
                    keycardName = data.Tables(0).Rows(x)("name").ToString()

                Next
            Else
                keycardName = ""
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return keycardName
    End Function

    Public Function GetUserName(userId As String) As Array
        Dim userArray(0 To 1) As String
        Try
            OpenCon()

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM users WHERE id = '" & userId & "' LIMIT 1"
            adapter.SelectCommand = cmd
            data.Clear()

            If adapter.Fill(data) Then
                For x As Integer = 0 To data.Tables(0).Rows.Count - 1

                    userName = data.Tables(0).Rows(x)("name").ToString()
                    userArray(0) = userName
                    studId = data.Tables(0).Rows(x)("student_id").ToString()
                    userArray(1) = studId
                Next
            Else
                userName = ""
                userArray(0) = userName
                studId = ""
                userArray(1) = studId
            End If

            con.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        Return userArray
    End Function

End Module
