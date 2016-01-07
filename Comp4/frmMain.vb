Public Class frmMain
    Dim addUserConn As New PostgreSQL
    Dim dt As New DataTable

    Private Sub btnAddtoDb_Click(sender As Object, e As EventArgs) Handles btnAddtoDb.Click
        Dim detailList As New List(Of Object)
        Dim listList As New List(Of List(Of Object))
        addUserConn.Database = "userDB" 'Ensure UserDB is selected
        addUserConn.ConnectToDB()
        detailList.Add(200)
        detailList.Add(txtLogin.Text)
        detailList.Add(txtPassword.Text)
        detailList.Add(txtEmail.Text)
        detailList.Add(txtForename.Text)
        detailList.Add(txtSurname.Text)
        For i = Int(txtUID.Text) To Int(txtUID.Text) + 10
            detailList(0) = i
            listList.Add(detailList.ToList)
        Next
        addUserConn.AddToTable("users", listList)
        refresh()
        MsgBox("OK!")
    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim addUserConn As New PostgreSQL
        addUserConn.Database = "userDB" 'Ensure UserDB is selected
        addUserConn.ConnectToDB()
        addUserConn.UpdateTable("users", dt)
        DataGridView1.DataSource = dt
    End Sub

    Function refresh()
        addUserConn.Database = "userDB" 'Ensure UserDB is selected
        addUserConn.ConnectToDB()
        addUserConn.UpdateTable("users", dt)
        DataGridView1.DataSource = dt
    End Function
End Class