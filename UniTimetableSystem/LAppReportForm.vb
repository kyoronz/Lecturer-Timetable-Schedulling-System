Public Class LAppReportForm
    Private Sub LAppReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "SELECT Consultation.LectureID, Consultation.ConsultationDate, Consultation.Stime, Consultation.VenueID, Appointment.StudentID, Student.StudentName, Appointment.Purpose, Lecture.LectureName
                                FROM     (((Appointment INNER JOIN
                                Consultation ON Appointment.ConsultationID = Consultation.ConsultationID) INNER JOIN
                                Student ON Appointment.StudentID = Student.StudentID) INNER JOIN
                                Lecture ON Consultation.LectureID = Lecture.LectureID)
                                WHERE  (Appointment.Status = 'Ongoing') AND (Consultation.Status='Ongoing') AND (Consultation.LectureID = '" & Login.uname & "')"
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter(sql, LTimetableAdd.conn)
        LTimetableAdd.conn.Open()
        da.Fill(ds, "Appointment")
        LTimetableAdd.conn.Close()
        Dim dt As DataTable = ds.Tables("Appointment")
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource(“DataSet2”, dt))

        ReportViewer1.LocalReport.ReportPath = IO.Path.Combine(IO.Directory.GetParent(IO.Directory.GetParent(IO.Directory.GetParent(Application.ExecutablePath).FullName).FullName).FullName, "LAppointmentReport.rdlc")

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class