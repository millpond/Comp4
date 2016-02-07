Public Class frmMain

    Public myOptions As Options
    Public mySQL As PostgreSQL
    Public myMusic As LocalMusic
    Public myActiveMusic As List(Of LocalMusic.MusicPiece)
    Public myExcelSpreadsheet As ExcelSpreadsheet

#Region "Events"

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Me.tbcMaintab.Location = New Point(12, 12)
        Me.tbcMaintab.Width = Me.Width - 40
        Me.tbcMaintab.Height = Me.Height - 62 'TODO: finesse margins
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
            TopMost = True
            lblFullscreenInfo.Show()
        Else
            FormBorderStyle = FormBorderStyle.Sizable
            TopMost = False
            lblFullscreenInfo.Hide()
        End If
    End Sub

    Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.F11 And WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        ElseIf e.KeyCode = Keys.F11 And WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        End If
        e.Handled = True
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True 'Sets form to look for keyinputs (for ctrl-f)
        myOptions = New Options
        mySQL = New PostgreSQL("musicDB")
        myMusic = New LocalMusic(True)
        myActiveMusic = New List(Of LocalMusic.MusicPiece)
        myExcelSpreadsheet = New ExcelSpreadsheet
        myActiveMusic = myMusic.musicPieceList
    End Sub

    Private Sub txtSimpleSearch_KeyDown(sender As Object, e As KeyPressEventArgs) _
        Handles txtSimpleSearch.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            'Search here
            e.Handled = True
        End If
    End Sub

    Private Sub btnExcelExport_Click(sender As Object, e As EventArgs) _
        Handles btnExcelExport.Click
        myExcelSpreadsheet.exportToSpreadsheet(myMusic.musicDataTable)
    End Sub

#End Region

#Region "Funcs"

    Sub SimpleSearch(searchStr As String)

    End Sub

#End Region

End Class



























'Dim addUserConn As New PostgreSQL
'Dim dt As New DataTable

'Private Sub btnAddtoDb_Click(sender As Object, e As EventArgs)
'    Dim detailList As New List(Of Object)
'    Dim listList As New List(Of List(Of Object))
'    addUserConn.Database = "userDB" 'Ensure UserDB is selected
'    addUserConn.ConnectToDB()
'    detailList.Add(200)
'    detailList.Add(txtLogin.Text)
'    detailList.Add(txtPassword.Text)
'    detailList.Add(txtEmail.Text)
'    detailList.Add(txtForename.Text)
'    detailList.Add(txtSurname.Text)
'    For i = Int(txtUID.Text) To Int(txtUID.Text) + 10
'        detailList(0) = i
'        listList.Add(detailList.ToList)
'    Next
'    addUserConn.AddToTable("users", listList)
'    refresh()
'    MsgBox("OK!")
'End Sub

'Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'    Dim addUserConn As New PostgreSQL
'    addUserConn.Database = "userDB" 'Ensure UserDB is selected
'    addUserConn.ConnectToDB()
'    addUserConn.UpdateTable("users", dt)
'    DataGridView1.DataSource = dt
'End Sub

'Function refresh()
'    addUserConn.Database = "userDB" 'Ensure UserDB is selected
'    addUserConn.ConnectToDB()
'    addUserConn.UpdateTable("users", dt)
'    DataGridView1.DataSource = dt
'End Function