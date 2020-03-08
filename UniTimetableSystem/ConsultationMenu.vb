Imports System.ComponentModel
Public Class ConsultationMenu
    Dim choiceflag As Integer = 0
    Private Sub AdminMenu_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If choiceflag = 1 Then
            Login.Show()
        ElseIf choiceflag = 0 Then
            Application.Exit()
        End If
        choiceflag = 0
    End Sub
    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click
        Dim reply As DialogResult

        reply = MessageBox.Show("Are you sure to logout of the program?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If reply = DialogResult.Yes Then
            choiceflag = 1
            Me.Close()
        End If
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        choiceflag = 2
        Me.Close()
        LecturerMenu.Show()
    End Sub

    Private Sub ConsultationMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PreViewConsultation.Label4.Visible = False
        PreViewConsultation.cmblectid.Visible = False
        PreViewConsultation.MdiParent = Me
        PreViewConsultation.WindowState = FormWindowState.Maximized
        PreViewConsultation.Show()
    End Sub

End Class