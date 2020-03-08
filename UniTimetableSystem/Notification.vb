Imports System.Data.OleDb
Public Class Notification
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Public Shared user As Integer
    Dim feedpanel(10) As Panel
    Dim seperator(10) As Panel
    Dim feedtext(10) As TextBox
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        If Equals(user, 1) Then 'lecture
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=abc.accdb;")
            Dim sql As String = " UPDATE Appointment SET LectNoti=@LectNoti WHERE LectNoti=@le AND Appointment.ConsultationID IN (SELECT Consultation.ConsultationID FROM Consultation WHERE Consultation.ConsultationID = Appointment.ConsultationID AND Consultation.LectureID='" & Login.uname & "')"
            con.Open()
            cmd = New OleDbCommand(sql, con)
            cmd.Parameters.AddWithValue("@LectNoti", "Read")
            cmd.Parameters.AddWithValue("@le", "Unread")
            cmd.ExecuteNonQuery()
            con.Close()
        ElseIf Equals(user, 2) Then 'student
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=abc.accdb;")
            Dim sql As String = " UPDATE Appointment SET CancelNoti=@CancelNoti WHERE CancelNoti=@le AND StudentID='" & Login.uname & "'"
            con.Open()
            cmd = New OleDbCommand(sql, con)
            cmd.Parameters.AddWithValue("@CancelNoti", "Read")
            cmd.Parameters.AddWithValue("@le", "Unread")
            cmd.ExecuteNonQuery()
            con.Close()
        End If
        Me.Close()
    End Sub

    Private Sub Notification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Maxrows As Integer
        If Equals(user, 1) Then 'lecture
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=abc.accdb;")
            Dim sql As String = " SELECT Appointment.StudentID, Consultation.ConsultationDate, Consultation.Stime, Appointment.LectNoti, Student.StudentName FROM ((Appointment INNER JOIN Consultation ON Appointment.ConsultationID = Consultation.ConsultationID) INNER JOIN Student ON Appointment.StudentID = Student.StudentID) WHERE (Appointment.LectNoti='Unread' OR Appointment.LectNoti='Read')"
            con.Open()
            Dim ds As New DataSet
            Dim da As New OleDbDataAdapter(sql, con)
            da.Fill(ds, "appointment")
            Maxrows = ds.Tables("appointment").Rows.Count
            Dim rcounter As Integer = 0
            Dim d As DataRow
            While Not rcounter = Maxrows
                feedpanel(rcounter) = New Panel
                seperator(rcounter) = New Panel
                feedtext(rcounter) = New TextBox

                d = ds.Tables("appointment").Rows(rcounter)

                With feedpanel(rcounter)
                    .Dock = DockStyle.Top
                    .Height = 100
                    .Width = Panel2.Width
                    .Name = rcounter
                    .BorderStyle = BorderStyle.FixedSingle
                End With

                With seperator(rcounter)
                    .Dock = DockStyle.Top
                    .Height = 10
                End With

                If (d.Item(3) = "Unread") Then
                    With feedtext(rcounter)
                        .Text = "Student " & d.Item(0) & " " & d.Item(4) & " has cancelled the appointment of " & d.Item(1) & " " & d.Item(2) & ":00."
                        .Multiline = True
                        .Dock = DockStyle.Fill
                        .BorderStyle = BorderStyle.None
                        .Enabled = False
                        .BackColor = SystemColors.ActiveCaption
                        .Font = New Font("Arial", 12, FontStyle.Regular)
                    End With
                Else
                    With feedtext(rcounter)
                        .Text = "Student " & d.Item(0) & " " & d.Item(4) & " has cancelled the appointment of " & d.Item(1) & " " & d.Item(2) & ":00."
                        .Multiline = True
                        .Dock = DockStyle.Fill
                        .BorderStyle = BorderStyle.None
                        .Enabled = False
                        .BackColor = SystemColors.GradientInactiveCaption
                        .Font = New Font("Arial", 12, FontStyle.Regular)
                    End With
                End If

                Panel2.Controls.Add(feedpanel(rcounter))
                feedpanel(rcounter).Controls.Add(feedtext(rcounter))
                Panel2.Controls.Add(seperator(rcounter))
                'AddHandler feedpanel(i).MouseHover, AddressOf panelhover
                rcounter += 1
            End While
            con.Close()

        ElseIf Equals(user, 2) Then 'student
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=abc.accdb;")
            Dim sql As String = "SELECT Appointment.CancelReason, Appointment.CancelNoti, Appointment.Status, Consultation.ConsultationDate, Consultation.Stime FROM (Appointment INNER JOIN Consultation ON Appointment.ConsultationID = Consultation.ConsultationID) WHERE StudentID='" & Login.uname & "' AND (CancelNoti='Unread' OR CancelNoti='Read')"
            con.Open()
            Dim ds As New DataSet
            Dim da As New OleDbDataAdapter(sql, con)
            da.Fill(ds, "appointment")
            Maxrows = ds.Tables("appointment").Rows.Count
            Dim rcounter As Integer = 0
            Dim d As DataRow
            While Not rcounter = Maxrows
                feedpanel(rcounter) = New Panel
                seperator(rcounter) = New Panel
                feedtext(rcounter) = New TextBox

                d = ds.Tables("appointment").Rows(rcounter)
                With feedpanel(rcounter)
                    .Dock = DockStyle.Top
                    .Height = 100
                    .Width = Panel2.Width
                    .Name = rcounter
                    .BorderStyle = BorderStyle.FixedSingle
                End With

                With seperator(rcounter)
                    .Dock = DockStyle.Top
                    .Height = 10
                End With

                If (d.Item(2) = "Cancelled") Then

                    If (d.Item(1) = "Unread") Then
                        With feedtext(rcounter)
                            .Text = "Your Appointment on " & d.Item(3) & " " & d.Item(4) & ":00 has been cancelled." & vbNewLine & " Reason :" & d.Item(0) & "."
                            .Multiline = True
                            .Dock = DockStyle.Fill
                            .BorderStyle = BorderStyle.None
                            .Enabled = False
                            .BackColor = SystemColors.ActiveCaption
                            .Font = New Font("Arial", 12, FontStyle.Regular)
                        End With
                    Else
                        With feedtext(rcounter)
                            .Text = "Your Appointment on " & d.Item(3) & " " & d.Item(4) & ":00 has been cancelled." & vbNewLine & " Reason :" & d.Item(0) & "."
                            .Multiline = True
                            .Dock = DockStyle.Fill
                            .BorderStyle = BorderStyle.None
                            .Enabled = False
                            .BackColor = SystemColors.GradientInactiveCaption
                            .Font = New Font("Arial", 12, FontStyle.Regular)
                        End With
                    End If
                Else
                    Dim s As String = d.Item(0).ToString
                    Dim noti() = s.Split
                    If (d.Item(1) = "Unread") Then
                        With feedtext(rcounter)
                            .Text = "Your Appointment on " & noti(1) & " " & noti(2) & ":00 has been changed to " & noti(3) & " " & noti(4) & ":00 at " & noti(5) & " by lecturer " & noti(0) & "."
                            .Multiline = True
                            .Dock = DockStyle.Fill
                            .BorderStyle = BorderStyle.None
                            .Enabled = False
                            .BackColor = SystemColors.ActiveCaption
                            .WordWrap = True
                            .Font = New Font("Arial", 12, FontStyle.Regular)
                        End With
                    Else
                        With feedtext(rcounter)
                            .Text = "Your Appointment on " & noti(1) & " " & noti(2) & ":00 has been changed to " & noti(3) & " " & noti(4) & ":00 at " & noti(5) & " by lecturer " & noti(0) & "."
                            .Multiline = True
                            .Dock = DockStyle.Fill
                            .BorderStyle = BorderStyle.None
                            .Enabled = False
                            .BackColor = SystemColors.GradientInactiveCaption
                            .WordWrap = True
                            .Font = New Font("Arial", 12, FontStyle.Regular)
                        End With
                    End If
                End If
                Panel2.Controls.Add(feedpanel(rcounter))
                feedpanel(rcounter).Controls.Add(feedtext(rcounter))
                Panel2.Controls.Add(seperator(rcounter))
                'AddHandler feedpanel(i).MouseHover, AddressOf panelhover
                rcounter += 1
            End While
            con.Close()
        End If
    End Sub
End Class