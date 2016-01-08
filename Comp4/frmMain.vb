Public Class frmMain
    Dim curWidth As Integer = Me.Width
    Dim curHeight As Integer = Me.Height
    Dim initWidth As Integer
    Dim initHeight As Integer


    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        Dim widthRatio As Double = (Me.Width - initWidth) / curWidth
        Dim heightRatio As Double = (Me.Height - initHeight) / curHeight

        For Each ctrl In Controls
            ctrl.Width += CInt(ctrl.Width * widthRatio)
            ctrl.Height += CInt(ctrl.Height * heightRatio)
            ctrl.Left += CInt(ctrl.Left * widthRatio)
            ctrl.Top += CInt(ctrl.Top * heightRatio)
        Next

        curWidth = Me.Width
        curHeight = Me.Height

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        initWidth = Me.Width
        initHeight = Me.Height
    End Sub




























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

End Class