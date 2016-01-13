Imports System.IO

Public Class Options 'Develop this later

    Dim options As Dictionary(Of String, Object)

    Private connAddress As String
    Private connPort As Integer
    Private connUsername As String
    Private connPassword As String

#Region "Properties"

    Property ConnectionAddress As String
        Get
            Return connAddress
        End Get
        Set(value As String)
            connAddress = value
            WriteOptionsToFile()
        End Set
    End Property

    Property ConnectionPort As String
        Get
            Return connPort
        End Get
        Set(value As String)
            connPort = value
            WriteOptionsToFile()
        End Set
    End Property

    Property ConnectionUsername As String
        Get
            Return connUsername
        End Get
        Set(value As String)
            connUsername = value
            WriteOptionsToFile()
        End Set
    End Property

    Property ConnectionPassword As String
        Get
            Return connPassword
        End Get
        Set(value As String)
            connPassword = value
            WriteOptionsToFile()
        End Set
    End Property

#End Region

    Sub New()
        options = New Dictionary(Of String, Object)
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
        'Check to see if config file exists - if not, create
        If Not My.Computer.FileSystem.FileExists("ElizabethLibrary.ELconfig") Then
            Dim fileStream As FileStream = File.Create("ElizabethLibrary.ELconfig")
            fileStream.Close()
        End If
        'Write
        File.WriteAllLines("ElizabethLibrary.ELconfig", finalWriteList.ToArray)
    End Sub

    Sub GetOptionsFromFile()
        'Read
        Dim tempOptions As New Dictionary(Of String, Object)
        Dim initWriteList As List(Of String)
        Dim i As Integer
        Dim key, value As String
        initWriteList = File.ReadAllLines("ElizabethLibrary.ELconfig").ToList
        'Decode
        Try
            For Each element In initWriteList
                i = element.Length
                i = element.IndexOf("[") 'Mark position of "["
                'take substring starting at "[" + 1, of length of the index of "]" - the index of "[" (-1)
                key = element.Substring(i + 1, element.IndexOf("]") - i - 1)
                i = element.IndexOf("=") 'Mark position of "="
                'take substring starting at "=" + 1, of length of the rest of the string
                value = element.Substring(i + 1, element.Length - i - 1)
                value = Replace(value, " ", "") 'Remove any errant spaces the user may have left.
                tempOptions.Add(key, value)
            Next
            options = tempOptions
        Catch ex As Exception
            Debug.WriteLine("Options read error: " & ex.ToString)
            UIExtras.ErrorBox("Problem getting options from file.")
        End Try

    End Sub

End Class
