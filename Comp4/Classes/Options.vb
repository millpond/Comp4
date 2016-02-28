Imports System.IO

Public Class Options 'Develop this later

    Dim options As Dictionary(Of String, Object)

    Private connAddress As String
    Private connPort As Integer
    Private connUsername As String
    Private connPassword As String
    Private xlHeaders As String
    Private enumMusicType As String
    Private enumMusicStatus As String
    Private enumScoreType As String

#Region "Properties"

    Public Property ConnectionAddress As String
        Get
            Return connAddress
        End Get
        Set(value As String)
            connAddress = value
            WriteOptionsToFile()
        End Set
    End Property

    Public Property ConnectionPort As String
        Get
            Return connPort
        End Get
        Set(value As String)
            connPort = value
            WriteOptionsToFile()
        End Set
    End Property

    Public Property ConnectionUsername As String
        Get
            Return connUsername
        End Get
        Set(value As String)
            connUsername = value
            WriteOptionsToFile()
        End Set
    End Property

    Public Property ConnectionPassword As String
        Get
            Return connPassword
        End Get
        Set(value As String)
            connPassword = value
            WriteOptionsToFile()
        End Set
    End Property

    Public Property HeaderString As String
        Get
            Return xlHeaders
        End Get
        Set(value As String)
            xlHeaders = value
            WriteOptionsToFile()
        End Set
    End Property

    Public Property MusicTypeEnumString As String
        Get
            Return enumMusicType
        End Get
        Set(value As String)
            enumMusicType = value
            WriteOptionsToFile()
        End Set
    End Property

    Public Property MusicStatusEnumString As String
        Get
            Return enumMusicStatus
        End Get
        Set(value As String)
            enumMusicStatus = value
            WriteOptionsToFile()
        End Set
    End Property

    Public Property ScoreTypeEnumString As String
        Get
            Return enumScoreType
        End Get
        Set(value As String)
            enumScoreType = value
            WriteOptionsToFile()
        End Set
    End Property

    Public ReadOnly Property Headers As List(Of String)
        Get
            Return splitStringIntoList(HeaderString)
        End Get
    End Property

    Public ReadOnly Property ScoreTypeEnum As List(Of String)
        Get
            Return splitStringIntoList(ScoreTypeEnumString)
        End Get
    End Property

    Public ReadOnly Property MusicTypeEnum As List(Of String)
        Get
            Return splitStringIntoList(MusicTypeEnumString)
        End Get
    End Property

    Public ReadOnly Property MusicStatusEnum As List(Of String)
        Get
            Return splitStringIntoList(MusicStatusEnumString)
        End Get
    End Property

#End Region

    Sub New()
        options = New Dictionary(Of String, Object)
        'If Not My.Computer.FileSystem.FileExists("ElizabethLibrary.ELconfig") Then
        '    PopulateNewOptions()
        'End If
        GetOptionsFromFile()
    End Sub

    Sub WriteOptionsToFile()
        Dim strBuilder As String
        Dim finalWriteList As New List(Of String)
        'Encode
        For Each element In options
            strBuilder = String.Format("[{0}] = {1}", element.Key, element.Value)
            finalWriteList.Add(strBuilder)
        Next
        'Write
        File.WriteAllLines(configFile, finalWriteList.ToArray)
    End Sub

    Sub GetOptionsFromFile()
        'Read
        Dim tempOptions As New Dictionary(Of String, Object)
        Dim initWriteList As List(Of String)
        Dim i As Integer
        Dim key, value As String
        initWriteList = File.ReadAllLines(configFile).ToList
        'Decode
        Try
            For Each element In initWriteList
                If element.Substring(0, 1) = "[" Then
                    i = element.IndexOf("[") 'Mark position of "["
                    'take substring starting at "[" + 1, of length of the index of "]"
                    'and then - the index of "[" (-1)
                    key = element.Substring(i + 1, element.IndexOf("]") - i - 1)
                    i = element.IndexOf("=") 'Mark position of "="
                    'take substring starting at "=" + 1, of length of the rest of the string
                    value = element.Substring(i + 1, element.Length - i - 1)
                    'Remove any errant spaces the user may have left.
                    value = Replace(value, " ", "")
                    tempOptions.Add(key, value)
                End If
            Next
            options = tempOptions
            DepopulateOptionsList()
        Catch ex As Exception
            Debug.WriteLine("Options read error: " & ex.Message.ToString)
            MsgBox("Problem getting options from file.")
        End Try
    End Sub

    ''' <summary>
    ''' Splits up the string separated by "/" into a list of strings
    ''' </summary>
    Public Function splitStringIntoList(str As String) As List(Of String)
        Dim stringList As New List(Of String)
        Dim tempString As String = ""
        For i = 0 To str.Length - 1
            If Not str(i) = "/" Then
                If str(i) = "_" Then 'Replace _ with spaces
                    tempString += " "
                Else
                    tempString += str(i)
                End If
            Else
                stringList.Add(tempString)
                tempString = ""
            End If
        Next
        stringList.Add(tempString)
        Return stringList
    End Function

    'Sub PopulateNewOptions()
    '    options.Add("SQL Connection", ConnectionAddress)
    '    options.Add("SQL Port", ConnectionPort)
    '    options.Add("SQL Username", ConnectionUsername)
    '    options.Add("SQL Password", ConnectionPassword)
    '    options.Add("Excel Headers", HeaderString)
    '    options.Add("Score Type Enum", ScoreTypeEnumString)
    '    options.Add("Music Type Enum", MusicTypeEnumString)
    '    options.Add("Music Status Enum", MusicStatusEnumString)
    '    WriteOptionsToFile()
    'End Sub

    Sub DepopulateOptionsList()
        ConnectionAddress = options("SQL Connection")
        ConnectionPort = options("SQL Port")
        ConnectionUsername = options("SQL Username")
        ConnectionPassword = options("SQL Password")
        HeaderString = options("Table Headers")
        ScoreTypeEnumString = options("Score Type Enum")
        MusicTypeEnumString = options("Music Type Enum")
        MusicStatusEnumString = options("Music Status Enum")
    End Sub

End Class
