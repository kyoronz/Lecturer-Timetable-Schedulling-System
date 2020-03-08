Public Class LTimetableEdit
    Dim timetableid As String
    Dim oridate As Date
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
    Private Sub LTimetableEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fclear()
    End Sub
    Function hoursopt(ByVal AMPM As String)
        cboxhour.Items.Clear()
        cboxhour.ResetText()
        If AMPM.Equals("AM") Then
            cboxhour.Items.Clear()
            cboxhour.ResetText()
            For i As Integer = 8 To 11
                Dim hour As String = String.Format("{0}", i)
                cboxhour.Items.Add(hour)
            Next
        ElseIf AMPM.Equals("PM") Then
            cboxhour.Items.Add("12")
            For i As Integer = 1 To 6
                Dim hour As String = String.Format("{0}", i)
                cboxhour.Items.Add(hour)
            Next
        End If
    End Function
    Function venuetype()
        cboxvtype.Items.Clear()
        cboxvtype.ResetText()
        Dim sql As String = "SELECT DISTINCT VenueType FROM [Venue] WHERE NOT VenueType = 'Consultation Suites' AND NOT VenueType = 'Library Discussion Room'"
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand(sql, LTimetableAdd.conn)
        LTimetableAdd.conn.Open()
        dr = cmd.ExecuteReader
        If Not dr.HasRows() Then
            ''no data
        Else
            While dr.Read
                cboxvtype.Items.Add(dr.Item(0))
            End While
        End If
        LTimetableAdd.conn.Close()
    End Function
    Function venueavailable(ByVal venuetype As String)
        cboxvenue.Items.Clear()
        cboxvenue.ResetText()

        Dim strdate As String = DateTimePicker1.Value.ToShortDateString
        Dim df As String = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern
        Dim selecteddate As Date = Date.ParseExact(strdate, df, System.Globalization.DateTimeFormatInfo.InvariantInfo)
        Dim hour As Integer = Integer.Parse(cboxhour.Text)
        If cboxampm.Text.Equals("PM") Then
            hour += 12
        End If
        selecteddate = selecteddate.AddHours(hour)
        selecteddate = selecteddate.AddMinutes(Integer.Parse(cboxminute.Text))

        Dim cond1 As String = "( SELECT VenueID FROM Timetable LEFT JOIN Course ON Timetable.ModuleID = Course.ModuleID WHERE NOT ( Tdate >= DateAdd( 'n',(@duration*60),CDate(@date) ) OR DateAdd( 'n',(Course.Duration_pc*60),Tdate)<= CDate(@date)   ) )"
        Dim sql As String = "SELECT * FROM [Venue] WHERE VenueType =@type AND VenueID NOT IN (" + cond1 + ")"

        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand(sql, LTimetableAdd.conn)
        Dim duration As String() = txtduration.Text.Split(" ")
        cmd.Parameters.AddWithValue("@duration", Integer.Parse(duration(0)))
        cmd.Parameters.AddWithValue("@date", datetostring(selecteddate))
        cmd.Parameters.AddWithValue("@type", venuetype)
        LTimetableAdd.conn.Open()
        dr = cmd.ExecuteReader
        If Not dr.HasRows() Then
            ''no data
        Else
            While dr.Read()
                cboxvenue.Items.Add(dr.Item(0))
            End While
        End If
        LTimetableAdd.conn.Close()
    End Function
    Function fclear()
        btnupdate.Enabled = False
        btnconf1.Show()
        btnconf2.Hide()
        btnconf3.Hide()

        cboxhour.Enabled = False
        cboxhour.Items.Clear()
        cboxhour.ResetText()

        cboxminute.Enabled = False
        cboxminute.Items.Clear()
        cboxminute.ResetText()

        cboxampm.Enabled = False
        cboxampm.ResetText()
        cboxampm.SelectedIndex = -1

        cboxvenue.Enabled = False
        cboxvenue.Items.Clear()
        cboxvenue.ResetText()

        cboxvtype.Enabled = False
        cboxvtype.Items.Clear()
        cboxvtype.ResetText()
        DateTimePicker1.Enabled = True
    End Function
    Function setrecord(ByVal tbid As String, ByVal passdate As Date())
        Dim sql As String = "SELECT Format(Timetable.Tdate, 'dd/mm/yyyy hh:nn:ss am/pm'), Timetable.IntakeID, Timetable.ModuleID, Lecture.LectureName, Course.Sdate, Course.Duration_ps, Course.Duration_pc, Timetable.VenueID, Timetable.Tdate "
        sql += "FROM ( (Timetable LEFT JOIN Course ON Timetable.ModuleID = Course.ModuleID) LEFT JOIN Intake_Module ON (Timetable.IntakeID = Intake_Module.IntakeID AND Timetable.ModuleID = Intake_Module.ModuleID)) LEFT JOIN Lecture ON Intake_Module.LectureID = Lecture.LectureID "
        sql += "WHERE Timetable.TimetableID=@tid"
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand(sql, LTimetableAdd.conn)
        cmd.Parameters.AddWithValue("@tid", tbid)
        LTimetableAdd.conn.Open()
        dr = cmd.ExecuteReader
        If Not dr.HasRows Then
            ''no date error
        Else
            dr.Read()
            txtoridate.Text = dr.Item(0)
            txtint.Text = dr.Item(1)
            txtmdl.Text = dr.Item(2)
            txtlec.Text = dr.Item(3)

            Dim startdate As Date = Date.Parse(dr.Item(4))
            Dim aweek As Integer = Integer.Parse(dr.Item(5))
            Dim df As String = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern
            Dim realsdate As Date = Date.ParseExact(startdate.ToShortDateString(), df, System.Globalization.DateTimeFormatInfo.InvariantInfo)
            Dim enddate As Date = realsdate.AddDays(7 * aweek)
            txtsdate.Text = realsdate.ToLongDateString
            txtenddate.Text = enddate.ToLongDateString

            Dim durationPC As String = dr.Item(6)
            If durationPC.Equals("1") Then
                txtduration.Text = durationPC + " hour"
            Else
                txtduration.Text = durationPC + " hours"
            End If
            txtvenue.Text = dr.Item(7)
            oridate = dr.Item(8)

        End If
        LTimetableAdd.conn.Close()
        timetableid = tbid
        DateTimePicker1.MinDate = passdate(0)
        DateTimePicker1.MaxDate = passdate(1)
    End Function

    Private Sub cboxhour_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxhour.SelectedIndexChanged
        cboxminute.Items.Clear()
        cboxminute.ResetText()
        If cboxhour.Text = 6 Then
            cboxminute.Items.Add("00")
        Else
            cboxminute.Items.Add("00")
            cboxminute.Items.Add("10")
            cboxminute.Items.Add("20")
            cboxminute.Items.Add("30")
            cboxminute.Items.Add("40")
            cboxminute.Items.Add("50")
        End If
    End Sub

    Private Sub cboxampm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxampm.SelectedIndexChanged
        hoursopt(cboxampm.Text)
    End Sub

    Private Sub cboxvtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxvtype.SelectedIndexChanged
        venueavailable(cboxvtype.Text)
    End Sub

    Private Sub btnconf1_Click(sender As Object, e As EventArgs) Handles btnconf1.Click

        If DateTimePicker1.Value.DayOfWeek = DayOfWeek.Sunday Then
            MessageBox.Show("Please select another date.", "Date error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim df As String = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern
        Dim selecteddate As Date = Date.ParseExact(DateTimePicker1.Value.ToShortDateString, df, System.Globalization.DateTimeFormatInfo.InvariantInfo)
        Dim sql As String = "SELECT * FROM [Course] WHERE DateAdd('ww',Duration_ps,SDate) >= CDate(@now) AND SDate <= CDate(@now) AND ModuleID=@mdl"
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand(sql, LTimetableAdd.conn)
        cmd.Parameters.AddWithValue("@now", datetostring(selecteddate))
        cmd.Parameters.AddWithValue("@mdl", txtmdl.Text)
        LTimetableAdd.conn.Open()
        dr = cmd.ExecuteReader
        If Not dr.HasRows() Then
            MessageBox.Show("The selected repeat week is exceed the expire date of the module", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LTimetableAdd.conn.Close()
            Exit Sub
        End If
        LTimetableAdd.conn.Close()

        DateTimePicker1.Enabled = False
        cboxhour.Enabled = True
        cboxminute.Enabled = True
        cboxampm.Enabled = True
        btnconf1.Hide()
        btnconf2.Show()
        cboxampm.SelectedIndex = 0
    End Sub

    Private Sub btnconf2_Click(sender As Object, e As EventArgs) Handles btnconf2.Click
        If cboxhour.Text.Length = 0 Or cboxminute.Text.Length = 0 Or cboxampm.Text.Length = 0 Then
            MessageBox.Show("Please fill in the details", "Form not complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim cond1 As String = "( SELECT VenueID FROM Timetable LEFT JOIN Course ON Timetable.ModuleID = Course.ModuleID WHERE NOT ( Tdate >= DateAdd( 'n',(@duration*60),CDate(@date) ) OR DateAdd( 'n',(Course.Duration_pc*60),Tdate)<= CDate(@date)   ) )"
        Dim sql As String = "SELECT * FROM [Venue] WHERE VenueID NOT IN (" + cond1 + ")"
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand(sql, LTimetableAdd.conn)
        Dim duration As String() = txtduration.Text.Split(" ")
        cmd.Parameters.AddWithValue("@duration", Integer.Parse(duration(0)))
        cmd.Parameters.AddWithValue("@date", datetostring(Me.oridate))
        LTimetableAdd.conn.Open()
        Try
            dr = cmd.ExecuteReader
            If Not dr.HasRows() Then
                MessageBox.Show("No Classroom is available within this duration")
                LTimetableAdd.conn.Close()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            LTimetableAdd.conn.Close()
            Exit Sub
        End Try
        LTimetableAdd.conn.Close()
        dr.Close()

        venuetype()

        btnconf2.Hide()
        btnconf3.Show()
        cboxhour.Enabled = False
        cboxminute.Enabled = False
        cboxampm.Enabled = False
        cboxvtype.Enabled = True
        cboxvenue.Enabled = True
    End Sub

    Private Sub btnconf3_Click(sender As Object, e As EventArgs) Handles btnconf3.Click
        If cboxvtype.Text.Length = 0 Or cboxvenue.Text.Length = 0 Then
            MessageBox.Show("Please fill in the details", "Form not complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        cboxvenue.Enabled = False
        cboxvtype.Enabled = False

        btnconf3.Hide()
        btnupdate.Enabled = True
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Close()
    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        fclear()
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim strdate As String = DateTimePicker1.Value.ToShortDateString
        Dim df As String = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern
        Dim selecteddate As Date = Date.ParseExact(strdate, df, System.Globalization.DateTimeFormatInfo.InvariantInfo)
        Dim hour As Integer = Integer.Parse(cboxhour.Text)
        If cboxampm.Text.Equals("PM") And Not cboxhour.Text.Equals("12") Then
            hour += 12
        End If
        selecteddate = selecteddate.AddHours(hour)
        selecteddate = selecteddate.AddMinutes(Integer.Parse(cboxminute.Text))

        Dim sql As String = "UPDATE Timetable SET Tdate=@tdate, VenueID = @venue WHERE TimetableID='" + timetableid + "'"
        Dim cmd As New OleDb.OleDbCommand(sql, LTimetableAdd.conn)
        cmd.Parameters.AddWithValue("@tdate", datetostring(selecteddate))
        cmd.Parameters.AddWithValue("@venue", cboxvenue.Text)
        LTimetableAdd.conn.Open()
        If cmd.ExecuteNonQuery = 0 Then

        End If
        LTimetableAdd.conn.Close()
        MessageBox.Show("Timetable successfully modified.", "Modified successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class