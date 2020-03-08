Imports System.ComponentModel
Imports System.Data.OleDb

Public Class StudentMenu
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim choiceflag As Integer = 0
    Private Sub btnViewLT_Click(sender As Object, e As EventArgs) Handles btnViewLT.Click
        pcb.Visible = False
        LTimetableView.btnadd.Visible = False
        LTimetableView.btnedit.Visible = False
        LTimetableView.btndel.Visible = False
        LTimetableView.btnback.Visible = False
        LTimetableView.MdiParent = Me
        LTimetableView.WindowState = FormWindowState.Maximized
        LTimetableView.Show()
    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        Dim reply As DialogResult
        reply = MessageBox.Show("Are you sure to logout of the program?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If reply = DialogResult.Yes Then
            choiceflag = 1
            Me.Close()
        End If
    End Sub
    Private Sub StudentMenu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If choiceflag = 1 Then
            Login.Show()
        ElseIf choiceflag = 0 Then
            Application.Exit()
        End If
        choiceflag = 0
    End Sub

    Private Sub btnNoti_Click(sender As Object, e As EventArgs) Handles btnNoti.Click
        Dim dialog As Notification
        dialog = New Notification()
        Notification.user = 2
        Dim result As DialogResult = dialog.ShowDialog(Me)
        If result = DialogResult.Yes Then
            btnNoti.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub btnBookC_Click(sender As Object, e As EventArgs) Handles btnBookC.Click
        pcb.Visible = False
        PreViewConsultation.MdiParent = Me
        PreViewConsultation.WindowState = FormWindowState.Maximized
        PreViewConsultation.Show()
    End Sub

    Private Sub StudentMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadnoti()
    End Sub
    Sub loadnoti()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=abc.accdb;")
        Dim sql As String = "SELECT * FROM Appointment WHERE CancelNoti=@CancelNoti AND StudentID='" & Login.uname & "'"
        con.Open()
        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@CancelNoti", "Unread")
        dr = cmd.ExecuteReader
        If (dr.HasRows) Then
            btnNoti.BackColor = Color.DeepSkyBlue
            MessageBox.Show("You have an unread notification." & vbNewLine & "Please click on the Notification button on the below panel to view the notification.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        con.Close()
    End Sub
End Class