﻿Public Class Login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Check to make sure textboxes aren't empty or obviously erroneous
        If txtPassword.Text.Length < 4 Or txtUsername.Text.Length < 4 Then
            MessageBox.Show("Please complete the required fields...", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim loginConn As New Npgsql.NpgsqlConnection
            pgConnection
        End If
    End Sub

    Private Sub btnAdduser_Click(sender As Object, e As EventArgs) Handles btnAdduser.Click

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
