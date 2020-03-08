Imports System.ComponentModel

Public Class AdminMenu

    Dim choiceflag As Integer = 0
    Private Sub btnViewtt_Click(sender As Object, e As EventArgs) Handles btnViewtt.Click

        pcb.Visible = False
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

    Private Sub AdminMenu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If choiceflag = 1 Then
            Login.Show()
        Else
            Application.Exit()
        End If
        choiceflag = 0
    End Sub
End Class