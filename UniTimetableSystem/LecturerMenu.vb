Imports System.ComponentModel
Imports System.Data.OleDb
Public Class LecturerMenu
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim choiceflag As Integer = 0
    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        Dim reply As DialogResult

        reply = MessageBox.Show("Are you sure to logout of the program?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If reply = DialogResult.Yes Then
            choiceflag = 1
            Me.Close()
        End If
    End Sub
    Private Sub LecturerMenu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If choiceflag = 1 Then
            Login.Show()
        ElseIf choiceflag = 0 Then
            Application.Exit()
        End If
        choiceflag = 0
    End Sub

    Private Sub btnVTT_Click(sender As Object, e As EventArgs) Handles btnVTT.Click
        pcb.Visible = False
        LTimetableView.btnadd.Visible = False
        LTimetableView.btnedit.Visible = False
        LTimetableView.btndel.Visible = False
        LTimetableView.btnback.Visible = False
        LTimetableView.MdiParent = Me
        LTimetableView.WindowState = FormWindowState.Maximized
        LTimetableView.Show()
    End Sub

    Private Sub btnCon_Click(sender As Object, e As EventArgs) Handles btnCon.Click
        choiceflag = 2
        Me.Close()
        ConsultationMenu.Show()
        'ViewConsultation.loadConSchedule()
    End Sub

    Private Sub btnNot_Click(sender As Object, e As EventArgs) Handles btnNot.Click
        Dim dialog As Notification
        dialog = New Notification()
        Notification.user = 1
        Dim result As DialogResult = dialog.ShowDialog(Me)
        If result = DialogResult.Yes Then
            btnNot.BackColor = SystemColors.Control
        End If
    End Sub

    Private Sub LecturerMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadnoti()
    End Sub
    Sub loadnoti()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=abc.accdb;")
        Dim sql As String = "SELECT * FROM Appointment WHERE LectNoti=@LectNoti AND Appointment.ConsultationID IN (SELECT Consultation.ConsultationID FROM Consultation WHERE Consultation.ConsultationID = Appointment.ConsultationID AND Consultation.LectureID='" & Login.uname & "')"
        con.Open()
        cmd = New OleDbCommand(sql, con)
        cmd.Parameters.AddWithValue("@LectNoti", "Unread")
        'cmd.Parameters.AddWithValue("@Le", "Read")
        dr = cmd.ExecuteReader
        If (dr.HasRows) Then
            btnNot.BackColor = Color.DeepSkyBlue
            MessageBox.Show("You have an unread notification." & vbNewLine & "Please click on the Notification button on the below panel to view the notification.", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        con.Close()
    End Sub
End Class