Imports MySql.Data.MySqlClient
Module MySQLModule

    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public data As New DataSet
    Public table As New DataTable

    Public admindata As New DataSet
    Public admintable As New DataTable

    Sub OpenCon()
        con.ConnectionString = "server=localhost; username=root; password=dev123; database=baggage_system"
        con.Open()
    End Sub

    Sub LoadTableHeader()
        admintable.Columns.Add("Id", Type.GetType("System.String"))
        admintable.Columns.Add("Name", Type.GetType("System.String"))
        admintable.Columns.Add("ID #", Type.GetType("System.String"))
        admintable.Columns.Add("Keycard", Type.GetType("System.String"))
        admintable.Columns.Add("Baggage", Type.GetType("System.String"))
        admintable.Columns.Add("Date", Type.GetType("System.String"))
        admintable.Columns.Add("Time In", Type.GetType("System.String"))
        admintable.Columns.Add("Time Out", Type.GetType("System.String"))
    End Sub

    Sub LoadTableHeaderMain()
        table.Columns.Add("Id", Type.GetType("System.String"))
        table.Columns.Add("Keycard", Type.GetType("System.String"))
        table.Columns.Add("Status", Type.GetType("System.String"))
    End Sub

End Module
