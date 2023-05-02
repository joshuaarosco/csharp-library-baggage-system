Module StringFomatterModule

    Public Function GetTen(source As String) As String
        Dim cutdown As String = source.Substring(0, 10)
        Return cutdown
    End Function

    Public Function Title() As String
        Return "DVITC Library Baggage System"
    End Function
End Module
