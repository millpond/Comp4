Public Class frmMain
    Private Sub btnAddtoDb_Click(sender As Object, e As EventArgs) Handles btnAddtoDb.Click
        Dim addUserConn As New PostgreSQL
        addUserConn.Database = "userDB" 'Ensure UserDB is selected
        addUserConn.ConnectToDB()
        addUserConn.DataOut("Insert into users values (" &
                            txtUID.Text & ",'" &
                            txtLogin.Text & "','" &
                            txtPassword.Text & "','" &
                            txtEmail.Text & "','" &
                            txtForename.Text & "','" &
                            txtSurname.Text & "')")
        MsgBox("OK!")
    End Sub
End Class