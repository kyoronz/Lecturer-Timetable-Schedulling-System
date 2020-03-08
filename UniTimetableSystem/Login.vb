Imports System.Data.OleDb
Public Class Login
    Public Shared uname As String
    Public Shared pword As String
    Dim con As OleDb.OleDbConnection
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPassword.Text = ""
        txtUsername.Text = ""
        txtUsername.Focus()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        uname = txtUsername.Text
        pword = txtPassword.Text

        con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=abc.accdb;")
        con.Open()
        Dim dr As OleDb.OleDbDataReader
        Dim sql As String = "SELECT * FROM [User] WHERE Username=@usr AND Password=@psw"
        Dim cmd As New OleDb.OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@usr", txtUsername.Text)
        cmd.Parameters.AddWithValue("@psw", txtPassword.Text)
        dr = cmd.ExecuteReader
        If (dr.HasRows) Then
            dr.Read()
            If Equals(dr.Item(2), "Admin") Then 'if it is admin else user
                con.Close()
                btnClear.PerformClick()
                Me.Close()
                AdminMenu.Show()
            ElseIf Equals(dr.Item(2), "Lecturer") Then
                con.Close()
                btnClear.PerformClick()
                Me.Close()
                LecturerMenu.Show()
            ElseIf Equals(dr.Item(2), "Student") Then
                con.Close()
                btnClear.PerformClick()
                Me.Close()
                StudentMenu.Show()
            End If
        Else
            MessageBox.Show("User with the password does not exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            con.Close()
        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.Focus()
        AcceptButton = btnLogin
        CancelButton = btnExit
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub


End Class
