﻿Class PostgreSQL
    Private connAddress As String = "127.0.0.1"
    Private connPort As String = "5432"
    Private connDatabase As String = ""
    Private connUsername As String = "postgres"
    Private connPassword As String = "password"
    Private currConn As Npgsql.NpgsqlConnection

#Region "Properties"

    Property Address As String
        Get
            Return connAddress
        End Get
        Set(value As String)
            connAddress = value
        End Set
    End Property

    Property Port As String
        Get
            Return connPort
        End Get
        Set(value As String)
            connPort = value
        End Set
    End Property

    Property Database As String
        Get
            Return connDatabase
        End Get
        Set(value As String)
            connDatabase = value
        End Set
    End Property

    Property Username As String
        Get
            Return connUsername
        End Get
        Set(value As String)
            connUsername = value
        End Set
    End Property

    Property Password As String
        Get
            Return connPassword
        End Get
        Set(value As String)
            connPassword = value
        End Set
    End Property

#End Region

    Public Sub New()
        currConn = New Npgsql.NpgsqlConnection
    End Sub

    Public Sub ConnectToDB() 'Opens a connection to the DB, using a connection string made from various properties above
        If currConn.State = ConnectionState.Closed Then
            Dim connString As String = "Server=" & Address & ";Port=" & Port & ";Database=" & Database & ";User Id=" & Username & ";Password=" & Password & ";" 'Build string
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

    Private Function checkDbStatus() As Boolean 'Checks to make sure the server isnt too busy - wouldnt want to inconvenience it
        If currConn.FullState = ConnectionState.Open Then
            Return True
        Else
            Return False 'TODO: Maybe have a timeout/loading func here
        End If
    End Function

    'Sends SQL Database A Non-query request. I.E. Puts data in, and gets nothing out.
    Private Sub DataOut(ByVal cmdText As String)
        If checkDbStatus() Then
            Dim cmd As Npgsql.NpgsqlCommand
            Dim retry As Boolean = True
            Dim resultDialog As Integer
            cmd = New Npgsql.NpgsqlCommand(cmdText, currConn)
            While retry
                Try
                    Debug.WriteLine("Dataout query executed. " & cmd.ExecuteNonQuery() & " rows affected")
                    retry = False
                Catch ex As Exception
                    resultDialog = MessageBox.Show("There was an error. Please try again.", "Database Query Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
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
                    resultDialog = MessageBox.Show("There was an error. Please try again.", "Database Query Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
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
                    workingStr += (sublistElement.ToString)  'Integers do not need the 'quote' marks
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

    Public Sub AddToTable(ByVal table As String, ByVal varList As List(Of List(Of Object))) 'Takes data and formats it to proper sql syntax for table insertion.
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