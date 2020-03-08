Public Class SAppReportForm
    Private Sub SAppReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "SELECT Student.StudentID, Student.StudentName, Consultation.ConsultationDate, Consultation.Stime, Consultation.VenueID, Appointment.Purpose, Lecture.LectureName
                  FROM     (((Appointment INNER JOIN
                  Student ON Appointment.StudentID = Student.StudentID) INNER JOIN
                  Consultation ON Appointment.ConsultationID = Consultation.ConsultationID) INNER JOIN
                  Lecture ON Consultation.LectureID = Lecture.LectureID)
                  WHERE  (Student.StudentID = '" & Login.uname & "') AND (Appointment.Status = 'Ongoing') AND (Consultation.Status = 'Ongoing')"
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter(sql, LTimetableAdd.conn)
        LTimetableAdd.conn.Open()
        da.Fill(ds, "Appointment")
        LTimetableAdd.conn.Close()
        Dim dt As DataTable = ds.Tables("Appointment")
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource(“DataSet3”, dt))

        ReportViewer1.LocalReport.ReportPath = IO.Path.Combine(IO.Directory.GetParent(IO.Directory.GetParent(IO.Directory.GetParent(Application.ExecutablePath).FullName).FullName).FullName, "SAppointmentReport.rdlc")

        Me.ReportViewer1.RefreshReport()
    End Sub


End Class