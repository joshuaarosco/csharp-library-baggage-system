Public Class MainUserControl

    Private Sub MainUserControl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTableHeaderMain()
        LoadTable()
        ChangeCellColor(DgvBaggages)
    End Sub

    Sub LoadTable()
        Try

            OpenCon()

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM baggages GROUP BY keycard_number ORDER BY time_in DESC"
            adapter.SelectCommand = cmd
            table.Clear()
            data.Clear()

            If adapter.Fill(data) Then
                For x As Integer = 0 To data.Tables(0).Rows.Count - 1

                    Dim id As String = data.Tables(0).Rows(x)("id").ToString()
                    Dim keycard_number As String = data.Tables(0).Rows(x)("keycard_number").ToString()
                    Dim status As String = data.Tables(0).Rows(x)("status").ToString()

                    table.Rows.Add(id, keycard_number, UppercaseFirstLetter(status))
                Next

                DgvBaggages.DataSource = table
                DgvBaggages.RowHeadersVisible = False
                DgvBaggages.Columns(0).Visible = False
            End If

            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Sub SearchResult()
        Try

            OpenCon()

            cmd.Connection = con
            cmd.CommandText = "SELECT * FROM baggages WHERE keycard_number LIKE '%" & TxtSearch.Text & "%' OR status LIKE '%" & TxtSearch.Text & "%' GROUP BY keycard_number ORDER BY time_in DESC"
            adapter.SelectCommand = cmd
            table.Clear()
            data.Clear()

            If adapter.Fill(data) Then
                For x As Integer = 0 To data.Tables(0).Rows.Count - 1

                    Dim id As String = data.Tables(0).Rows(x)("id").ToString()
                    Dim keycard_number As String = data.Tables(0).Rows(x)("keycard_number").ToString()
                    Dim status As String = data.Tables(0).Rows(x)("status").ToString()

                    table.Rows.Add(id, keycard_number, UppercaseFirstLetter(status))
                Next

                DgvBaggages.DataSource = table
                DgvBaggages.RowHeadersVisible = False
                DgvBaggages.Columns(0).Visible = False
            End If

            con.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        If String.IsNullOrEmpty(TxtSearch.Text) Then
            LblSearch.Visible = True
            LoadTable()
            ChangeCellColor(DgvBaggages)
        Else
            LblSearch.Visible = False
            SearchResult()
            ChangeCellColor(DgvBaggages)
        End If
    End Sub

    Private Sub DgvBaggages_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DgvBaggages.CellFormatting
        ChangeCellColor(DgvBaggages)
    End Sub
End Class
