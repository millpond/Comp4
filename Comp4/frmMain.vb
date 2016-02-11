Public Class frmMain

    Public myOptions As Options
    Public mySQL As PostgreSQL
    Public myMusic As LocalMusic
    Public myActiveMusic As DataTable
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
        KeyPreview = True 'Sets form to look for keyinputs (for fullscreen)
        myOptions = New Options
        mySQL = New PostgreSQL("musicDB")
        myMusic = New LocalMusic(True)
        myActiveMusic = New DataTable
        myExcelSpreadsheet = New ExcelSpreadsheet
        initDataGridView()
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

    Private Sub btnExcelImport_Click(sender As Object, e As EventArgs) Handles btnExcelImport.Click
        Dim chosefile As New frmChoosefile
        If chosefile.ShowDialog() = Windows.Forms.DialogResult.OK Then
            chosefile.Dispose()
        End If
    End Sub
#End Region

#Region "Funcs"

    Sub SimpleSearch(searchStr As String)

    End Sub

    Sub initDataGridView()
        Dim headers As List(Of String) = myOptions.ExcelHeaders
        prepActiveMusic()
        With dgvMain
            .DataSource = myActiveMusic
            .Columns(0).Visible = False 'Nobody needs to see that
            For i = 1 To 16
                .Columns(i).HeaderText = headers(i - 1)
            Next
        End With
    End Sub

    Sub prepActiveMusic()
        myActiveMusic = myMusic.musicDataTable.Clone()
        With myActiveMusic
            .Columns(1).DataType = GetType(String)
            .Columns(5).DataType = GetType(String)
            .Columns(11).DataType = GetType(String)
        End With

        For row = 0 To myMusic.musicDataTable.Rows.Count - 1
            'Replace values with enum names
            myActiveMusic.ImportRow(myMusic.musicDataTable.Rows(row))
            Try
                myActiveMusic.Rows(row)(1) = [Enum].GetName(GetType(LocalMusic.MusicType), 'begin broken code Int(myActiveMusic.Rows(row)(1).value))
            Catch ex As Exception
                Debug.WriteLine(ex)
            End Try
            'Note to future me - I am trying to replace value with the enum names so it looks okay. I can't seem to refernce the cell though.

            myActiveMusic.Rows(row)(5) = [Enum].GetName(GetType(LocalMusic.MusicStatus), Int(myActiveMusic.Rows(row)(5).value))
            myActiveMusic.Rows(row)(11) = [Enum].GetName(GetType(LocalMusic.OrchestralScoreType), Int(myActiveMusic.Rows(row)(11).value))
        Next
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