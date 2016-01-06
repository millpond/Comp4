Class PostgreSQL
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

    Public Sub ConnectToDB()
        'Opens a connection to the DB
        Dim connString As String = "Server=" & Address & ";Port=" & Port & ";Database=" & Database & ";User Id=" & Username & ";Password=" & Password & ";"
        currConn.ConnectionString = connString
        Try
            currConn.Open()
            Debug.WriteLine("Conection established to database using string: '" & connString & "'")
        Catch ex As Exception
            MsgBox("Failed: " & ex.ToString)
        End Try
    End Sub

    Public Sub DisconnectFromDB()
        If currConn.State = ConnectionState.Open Then
            currConn.Close()
        Else
            Debug.WriteLine("Tried to close a nonexistent connection! Connection: " & currConn.ToString)
        End If
    End Sub

    Public Sub DataOut(ByVal cmdText As String)
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
    End Sub

End Class
