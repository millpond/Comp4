Public Class frmLogin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

    End Sub

    Private Sub btnAdduser_Click(sender As Object, e As EventArgs) Handles btnAdduser.Click
        Dim frmMain As New frmMain
        frmMain.Activate()
        frmMain.Show()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
