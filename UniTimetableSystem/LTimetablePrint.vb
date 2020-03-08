Public Class LTimetablePrint
    Function datetostring(ByVal test As Date)
        Dim myday As Integer = test.Day
        Dim mymonth As Integer = test.Month
        Dim myyear As Integer = test.Year
        Dim myhour As Integer = test.Hour
        Dim mymin As Integer = test.Minute
        Dim mysec As Integer = test.Second

        Dim result As String = myyear.ToString("00") + "/" + mymonth.ToString("00") + "/" + myday.ToString("00") + " " + myhour.ToString("00") + ":" + mymin.ToString("00") + ":" + mysec.ToString("00")
        Return result
    End Function
    Private Sub LTimetablePrint_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sql As String = "SELECT Format(Timetable.Tdate, 'dd/mm/yyyy hh:nn:ss am/pm') as [Tdate] , Timetable.ModuleID , Course.ModuleName, Timetable.IntakeID , Lecture.LectureName , Timetable.VenueID "
        Dim passdate As Date() = LTimetableView.chosenweek
        sql += "FROM ( ( (Timetable LEFT JOIN Course On (Timetable.ModuleID = Course.ModuleID)) LEFT JOIN Intake_Module On (Intake_Module.ModuleID = Timetable.ModuleID And Intake_Module.IntakeID = Timetable.IntakeID) ) LEFT JOIN Lecture On Lecture.LectureID = Intake_Module.LectureID ) WHERE TDate>=CDate(#" + datetostring(passdate(0)) + "#) And TDate<=CDate(#" + datetostring(passdate(1)) + "#) "
        Dim lectureid As String() = LTimetableView.cboxlecture.Text.Split(" ")
        sql += "And Intake_Module.LectureID = '" + lectureid(0) + "' ORDER BY Timetable.Tdate ASC"
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter(sql, LTimetableAdd.conn)
        LTimetableAdd.conn.Open()
        da.Fill(ds, "Timetable")
        LTimetableAdd.conn.Close()
        Dim dt As DataTable = ds.Tables("Timetable")
        ReportViewer1.LocalReport.DataSources.Clear()
        ReportViewer1.LocalReport.DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource(“TB_DataSet”, dt))

        ReportViewer1.LocalReport.ReportPath = IO.Path.Combine(IO.Directory.GetParent(IO.Directory.GetParent(IO.Directory.GetParent(Application.ExecutablePath).FullName).FullName).FullName, "LTimetableReport.rdlc")

        Me.ReportViewer1.RefreshReport()
    End Sub

End Class