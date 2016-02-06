Public Class frmMain

    Public myOptions As New Options
    Public mySQL As New PostgreSQL
    Public myLocalMusic As LocalMusic

#Region "Events"

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        Me.tbcMaintab.Location = New System.Drawing.Point(12, 12)
        Me.tbcMaintab.Width = Me.Width - 40
        Me.tbcMaintab.Height = Me.Height - 62 'TODO: finesse margins
        If WindowState = FormWindowState.Maximized Then
            FormBorderStyle = FormBorderStyle.None
            TopMost = True
            lblFullscreenInfo.Show()
        Else
            FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            TopMost = False
            lblFullscreenInfo.Hide()
        End If
    End Sub

    Private Sub frmMain_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If (e.KeyCode And Not Keys.Modifiers) = Keys.F AndAlso e.Modifiers = Keys.Control And WindowState = FormWindowState.Maximized Then
            WindowState = FormWindowState.Normal
        ElseIf (e.KeyCode And Not Keys.Modifiers) = Keys.F AndAlso e.Modifiers = Keys.Control And WindowState = FormWindowState.Normal Then
            WindowState = FormWindowState.Maximized
        End If
        e.Handled = True
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KeyPreview = True 'Sets form to look for keyinputs (for ctrl-f)
        mySQL.Database = "musicDB"
        mySQL.ConnectToDB()
        mySQL.UpdateTable("musicDB", myLocalMusic.musicDataTable)
    End Sub

    Private Sub txtSimpleSearch_KeyDown(sender As Object, e As KeyPressEventArgs) Handles txtSimpleSearch.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            'Search here
            e.Handled = True
        End If
    End Sub

#End Region

#Region "Funcs"

    Sub SimpleSearch(searchStr As String)

    End Sub

#End Region


























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

    Private Sub txtSimpleSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSimpleSearch.TextChanged

    End Sub
End Class