Module LogicModule
    Sub ChangeCellColor(ByVal dgv As DataGridView)
        If dgv.Rows.Count > 0 Then
            For i As Integer = 0 To dgv.Rows.Count - 1
                For j As Integer = 0 To dgv.Columns.Count - 1
                    Dim CellChange As String = dgv.Rows(i).Cells(j).Value.ToString().Trim()
                    If CellChange.Contains("Available") = True Then

                        With dgv
                            .Rows(i).Cells(j).Style.BackColor = Color.YellowGreen
                        End With

                    End If
                    If CellChange.Contains("Occupied") = True Then

                        With dgv
                            .Rows(i).Cells(j).Style.BackColor = Color.Salmon
                        End With

                    End If
                Next
            Next
        End If

        dgv.DefaultCellStyle.SelectionBackColor = Color.Navy
        dgv.DefaultCellStyle.SelectionForeColor = Color.Gold

        ' Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
        ' value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
        dgv.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty

        ' Set the background color for all rows and for alternating rows. 
        ' The value for alternating rows overrides the value for all rows. 
        dgv.RowsDefaultCellStyle.BackColor = Color.LightGray
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White

        ' Set the row and column header styles.
        'dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Gold
        'dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy
        'dgv.RowHeadersDefaultCellStyle.BackColor = Color.Navy
    End Sub

    Function UppercaseFirstLetter(ByVal val As String) As String
        ' Test for nothing or empty.
        If String.IsNullOrEmpty(val) Then
            Return val
        End If

        ' Convert to character array.
        Dim array() As Char = val.ToCharArray

        ' Uppercase first character.
        array(0) = Char.ToUpper(array(0))

        ' Return new string.
        Return New String(array)
    End Function

End Module
