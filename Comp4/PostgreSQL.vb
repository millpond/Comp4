Public Class PostgreSQL

    Private connDatabase As String = ""
    Private currConn As Npgsql.NpgsqlConnection

#Region "Properties"

    Property Database As String
        Get
            Return connDatabase
        End Get
        Set(value As String)
            connDatabase = value
        End Set
    End Property

#End Region

    Public Sub New(initConnDatabase)
        Database = initConnDatabase
        currConn = New Npgsql.NpgsqlConnection
        ConnectToDB()
    End Sub

    'Opens a connection to the DB, using a connection string made from various properties above
    Public Sub ConnectToDB()
        If currConn.State = ConnectionState.Closed Then
            'Build string
            Dim connString As String = ("Server=" & frmMain.myOptions.ConnectionAddress _
                & ";Port=" & frmMain.myOptions.ConnectionPort _
                & ";Database=" & Database _
                & ";User Id=" & frmMain.myOptions.ConnectionUsername _
                & ";Password=" & frmMain.myOptions.ConnectionPassword & ";")
            currConn.ConnectionString = connString 'Assign string to connection
            Try
                currConn.Open() 'Main connection open here
                Debug.WriteLine("Conection established to database using string: '" & connString & "'")
            Catch ex As Exception
                MsgBox("Failed: " & ex.ToString)
            End Try
        End If
    End Sub

    Public Sub DisconnectFromDB()
        If currConn.State = ConnectionState.Open Then 'Check there is actually a connection to close
            currConn.Close()
        Else
            Debug.WriteLine("Tried to close a nonexistent connection! Connection: " & currConn.ToString)
        End If
    End Sub

    Private Function checkDbStatus() As Boolean 'Checks to make sure the server isnt too busy
        If currConn.FullState = ConnectionState.Open Then
            Return True
        Else
            Return False 'TODO: Maybe have a timeout/loading func here
        End If
    End Function

    'Sends SQL Database A Non-query request. I.E. Puts data in, and expects to get nothing out.
    Private Sub DataOut(ByVal cmdText As String)
        If checkDbStatus() Then
            Dim cmd As Npgsql.NpgsqlCommand
            Dim retry As Boolean = True
            Dim resultDialog As Integer
            cmd = New Npgsql.NpgsqlCommand(cmdText, currConn)
            While retry
                Try
                    Debug.WriteLine("Dataout issue. " & cmd.ExecuteNonQuery() & " rows affectd") 'TODO: Check that when properly compiled this will still work
                    retry = False
                Catch ex As Exception
                    resultDialog = MessageBox.Show(ex, "Database Query Error",
                                                   MessageBoxButtons.RetryCancel,
                                                   MessageBoxIcon.Error)
                    Debug.WriteLine("SQL Dataout error: " & ex.ToString)
                    If resultDialog = DialogResult.Retry Then
                        retry = True
                    Else
                        retry = False
                    End If
                End Try
            End While
        End If
    End Sub

    Public Sub UpdateTable(ByVal tableName As String, ByRef table As DataTable)
        If checkDbStatus() Then
            Dim cmd As Npgsql.NpgsqlCommand
            Dim retry As Boolean = True
            Dim resultDialog As Integer
            cmd = New Npgsql.NpgsqlCommand("SELECT * FROM " & tableName & ";", currConn)
            Dim dataAdapter As New Npgsql.NpgsqlDataAdapter(cmd)
            While retry
                Try
                    Debug.WriteLine("DataIn query executed.")
                    dataAdapter.Fill(table)
                    Dim dataReader As Npgsql.NpgsqlDataReader = cmd.ExecuteReader()
                    retry = False
                Catch ex As Exception
                    resultDialog = MessageBox.Show("There was an error. Please try again.",
                                                   "Database Query Error",
                                                   MessageBoxButtons.RetryCancel,
                                                   MessageBoxIcon.Error)
                    Debug.WriteLine("SQL Dataout error: " & ex.ToString)
                    If resultDialog = DialogResult.Retry Then
                        retry = True
                    Else
                        retry = False
                    End If
                End Try
            End While
        End If
    End Sub

    'Takes an array of strings, and concatenates them with correct syntax for SQL
    Public Function ConcatenateStrings(ByVal varList As List(Of List(Of Object))) As List(Of String)
        Dim workingStr As String
        Dim strList As New List(Of String)
        Dim listLength, sublistElementCount As Integer
        For Each listElement In varList
            listLength = listElement.Count
            sublistElementCount = 0
            workingStr = "("
            For Each sublistElement As Object In listElement
                sublistElementCount += 1
                If TypeOf (sublistElement) Is String Then
                    workingStr += ("'" & sublistElement.ToString & "'") 'Add the 'quote' marks
                Else
                    'Integers do not need the 'quote' marks
                    workingStr += (sublistElement.ToString)
                End If
                If Not sublistElementCount = listLength Then
                    workingStr += (",") 'Add comma if not last element in array
                Else
                    workingStr += (")") 'Else close the brackets off
                End If
            Next
            strList.Add(workingStr)
        Next
        Return strList
    End Function

    'Takes data and formats it to proper sql syntax for table insertion.
    Public Sub AddToTable(ByVal table As String, ByVal varList As List(Of List(Of Object)))
        Dim sqlStr As String
        Dim strList As List(Of String)
        Dim listElementCount As Integer = 0
        Dim listLength As Integer
        strList = ConcatenateStrings(varList)
        sqlStr = "INSERT INTO " & table & " VALUES "
        listLength = strList.Count
        For Each listElement In strList
            listElementCount += 1
            sqlStr += listElement
            If Not listElementCount = listLength Then
                sqlStr += (", ") 'Add comma if not last element in array
            End If
        Next
        DataOut(sqlStr)
        Debug.WriteLine("Added to {0} successfully values: {1}", table, varList.ToString)
    End Sub



End Class
