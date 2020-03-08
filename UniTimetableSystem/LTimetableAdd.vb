Public Class LTimetableAdd
    Public conn As OleDb.OleDbConnection = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=abc.accdb;")
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
    Function moduleopt(ByVal chosendate As Date)
        cboxmdl.Items.Clear()
        cboxmdl.ResetText()
        cboxintakeid.Items.Clear()
        cboxintakeid.ResetText()
        lblselectedlec.Text = ""
        Dim realdate As String = datetostring(chosendate)
        Dim sql As String = "SELECT * FROM [Course] WHERE DateAdd('ww',Duration_ps,SDate) >= CDate(@now) AND SDate <= CDate(@now);"
        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@now", realdate)
        Dim dr As OleDb.OleDbDataReader
        conn.Open()
        Try
            dr = cmd.ExecuteReader
            If Not dr.HasRows() Then
                ''no date
            Else
                While dr.Read()
                    Dim mdl As String = dr.Item(0) + " " + dr.Item(1)
                    cboxmdl.Items.Add(mdl)
                End While
            End If
        Catch ex As Exception

        Finally
            conn.Close()
        End Try
    End Function
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
    Function intakeopt(ByVal mdl As String)
        cboxintakeid.Items.Clear()
        cboxintakeid.ResetText()
        lblselectedlec.Text = ""

        Dim checkdate As Date = Date.ParseExact("2017/04/03", "yyyy/MM/dd", System.Globalization.DateTimeFormatInfo.InvariantInfo)
        Dim checkfirst As Integer = checkdate.DayOfWeek
        Dim df As String = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern
        Dim chosendate As Date = Date.ParseExact(DateTimePicker1.Value.ToShortDateString, df, System.Globalization.DateTimeFormatInfo.InvariantInfo)
        Dim firstday As Date
        Dim lastday As Date
        Dim chosenfirst As Integer = chosendate.DayOfWeek

        If checkfirst = 0 Then
            ''First day is Monday
            firstday = chosendate.AddDays(-chosenfirst)
            lastday = chosendate.AddDays(-chosenfirst + 6)
        ElseIf checkfirst = 1 Then
            ''First day is Sunday
            If chosenfirst = 0 Then
                chosenfirst = 7
            End If
            firstday = chosendate.AddDays(-chosenfirst + 1)
            lastday = chosendate.AddDays(-chosenfirst + 7)
        End If

        Dim cond1 As String = "(SELECT IntakeID FROM Timetable WHERE ModuleID=@mdl AND Tdate>=CDate(@first) AND Tdate<=CDate(@last))"
        Dim sql As String = "SELECT IntakeID FROM Intake_Module WHERE (IntakeID NOT in (" + cond1 + ")) AND ModuleID = @mdl2"
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@mdl", mdl)
        cmd.Parameters.AddWithValue("@first", datetostring(firstday))
        cmd.Parameters.AddWithValue("@last", datetostring(lastday))
        cmd.Parameters.AddWithValue("@mdl2", mdl)
        conn.Open()
        Try
            dr = cmd.ExecuteReader
            If Not dr.HasRows() Then
                ''no data
            Else
                While dr.Read()
                    cboxintakeid.Items.Add(dr.Item(0))
                End While
            End If
        Catch ex As Exception

        Finally
            conn.Close()
        End Try
    End Function
    Function enroldetail(ByVal mdl As String, ByVal intake As String)
        Dim sql As String = "SELECT Lecture.LectureName, Course.Duration_pc FROM (Intake_Module LEFT JOIN Lecture ON Intake_Module.LectureID = Lecture.LectureID) LEFT JOIN Course ON Intake_Module.ModuleID = Course.ModuleID WHERE Intake_Module.ModuleID=@mdl AND IntakeID = @int"
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@mdl", mdl)
        cmd.Parameters.AddWithValue("@int", intake)
        conn.Open()
        dr = cmd.ExecuteReader
        If Not dr.HasRows() Then
            ''no data
        Else
            dr.Read()
            lblselectedlec.Text = dr.Item(0)
            If dr.Item(1).Equals("1") Then
                lblduration.Text = dr.Item(1) + " hour"
            Else
                lblduration.Text = dr.Item(1) + " hours"
            End If

        End If
        conn.Close()
    End Function
    Function venuetype()
        cboxvtype.Items.Clear()
        cboxvtype.ResetText()
        Dim sql As String = "SELECT DISTINCT VenueType FROM [Venue] WHERE NOT VenueType = 'Consultation Suites' AND NOT VenueType = 'Library Discussion Room'"
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        conn.Open()
        dr = cmd.ExecuteReader
        If Not dr.HasRows() Then
            ''no data
        Else
            While dr.Read
                cboxvtype.Items.Add(dr.Item(0))
            End While
        End If
        conn.Close()
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

        If RadioButton2.Checked = True Then
            For i As Integer = 1 To Integer.Parse(cboxweek.Text)
                Dim nextdate As Date = selecteddate.AddDays(7 * i)
                Dim inicond As String = " AND VenueID NOT IN ("
                Dim cond As String = "( SELECT VenueID FROM Timetable LEFT JOIN Course ON Timetable.ModuleID = Course.ModuleID WHERE NOT ( Tdate >= DateAdd( 'n',(@duration*60),CDate(#" + datetostring(nextdate) + "#) ) OR DateAdd( 'n',(Course.Duration_pc*60),Tdate)<= CDate(#" + datetostring(nextdate) + "#)   ) )"
                Dim realcond As String = inicond + cond + ")"
                sql += realcond
            Next
        End If

        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        Dim duration As String() = lblduration.Text.Split(" ")
        cmd.Parameters.AddWithValue("@duration", Integer.Parse(duration(0)))
        cmd.Parameters.AddWithValue("@date", datetostring(selecteddate))
        cmd.Parameters.AddWithValue("@type", venuetype)
        conn.Open()
        dr = cmd.ExecuteReader
        If Not dr.HasRows() Then
            ''no data
        Else
            While dr.Read()
                cboxvenue.Items.Add(dr.Item(0))
            End While
        End If
        conn.Close()
    End Function
    Function fclear()
        btnconf1.Show()
        btnconf2.Hide()
        btnconf3.Hide()

        DateTimePicker1.ResetText()
        cboxintakeid.Items.Clear()
        cboxintakeid.ResetText()
        cboxmdl.Items.Clear()
        cboxmdl.ResetText()
        cboxvenue.Items.Clear()
        cboxvenue.ResetText()
        cboxvtype.Items.Clear()
        cboxvtype.ResetText()
        lblselectedlec.ResetText()

        DateTimePicker1.Enabled = True
        cboxmdl.Enabled = True
        cboxintakeid.Enabled = True
        cboxhour.Enabled = False
        cboxminute.Enabled = False
        cboxampm.Enabled = False
        lblweek.Enabled = False
        cboxvtype.Enabled = False
        cboxvenue.Enabled = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        cboxweek.Enabled = False

        lblduration.Text = "-"
        lblselectedlec.Text = "-"
        DateTimePicker1.Value = Now

        btnPublish.Enabled = False
    End Function
    Private Sub LTimetableAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        forminitialise()
    End Sub
    Function forminitialise()
        fclear()
        DateTimePicker1.MinDate = Now
    End Function

    Private Sub btnconf1_Click(sender As Object, e As EventArgs) Handles btnconf1.Click
        If cboxmdl.Text.Length = 0 Or cboxintakeid.Text.Length = 0 Then
            MessageBox.Show("Please fill in the details", "Form not complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        If DateTimePicker1.Value.DayOfWeek = DayOfWeek.Sunday Then
            MessageBox.Show("Please select another date.", "Date error", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim checkdate As Date = Date.ParseExact("2017/04/03", "yyyy/MM/dd", System.Globalization.DateTimeFormatInfo.InvariantInfo)
        Dim checkfirst As Integer = checkdate.DayOfWeek
        Dim chosendate As Date = DateTimePicker1.Value
        Dim firstday As Date
        Dim lastday As Date
        Dim chosenfirst As Integer = chosendate.DayOfWeek

        If checkfirst = 0 Then
            ''First day is Monday
            firstday = chosendate.AddDays(-chosenfirst)
            lastday = chosendate.AddDays(-chosenfirst + 6)
        ElseIf checkfirst = 1 Then
            ''First day is Sunday
            If chosenfirst = 0 Then
                chosenfirst = 7
            End If
            firstday = chosendate.AddDays(-chosenfirst + 1)
            lastday = chosendate.AddDays(-chosenfirst + 7)
        End If

        Dim sql As String = "SELECT * FROM Timetable WHERE ModuleID=@mdl AND IntakeID = @int AND Tdate>=CDate(@first) AND Tdate<=CDate(@last)"
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@mdl", cboxmdl.Text)
        cmd.Parameters.AddWithValue("@int", cboxintakeid.Text)
        cmd.Parameters.AddWithValue("@first", datetostring(firstday))
        cmd.Parameters.AddWithValue("@last", datetostring(lastday))

        conn.Open()
        dr = cmd.ExecuteReader
        If dr.HasRows() Then
            MessageBox.Show("Same details is existed on the chosen week")
            conn.Close()
            Exit Sub
        Else
            conn.Close()
        End If
        DateTimePicker1.Enabled = False
        cboxmdl.Enabled = False
        cboxintakeid.Enabled = False

        cboxhour.Enabled = True
        cboxminute.Enabled = True
        cboxampm.Enabled = True
        RadioButton1.Enabled = True
        RadioButton2.Enabled = True
        cboxweek.Enabled = True
        lblweek.Enabled = True

        btnconf1.Hide()
        btnconf2.Show()

        cboxampm.SelectedIndex = 0
    End Sub

    Private Sub btnconf2_Click(sender As Object, e As EventArgs) Handles btnconf2.Click
        If cboxhour.Text.Length = 0 Or cboxminute.Text.Length = 0 Or cboxampm.Text.Length = 0 Or (RadioButton2.Checked = True And cboxweek.Text.Length = 0) Then
            MessageBox.Show("Please fill in the details", "Form not complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        Dim dr As OleDb.OleDbDataReader
        Dim cmd As OleDb.OleDbCommand

        Dim strdate As String = DateTimePicker1.Value.ToShortDateString
        Dim df As String = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern
        Dim selecteddate As Date = Date.ParseExact(strdate, df, System.Globalization.DateTimeFormatInfo.InvariantInfo)
        Dim hour As Integer = Integer.Parse(cboxhour.Text)
        If cboxampm.Text.Equals("PM") Then
            hour += 12
        End If
        selecteddate = selecteddate.AddHours(hour)
        selecteddate = selecteddate.AddMinutes(Integer.Parse(cboxminute.Text))

        If RadioButton2.Checked = True Then
            conn.Open()
            For i As Integer = 1 To Integer.Parse(cboxweek.Text)
                Dim mdl As String() = cboxmdl.Text.Split(" ")
                Dim nextdate As Date = selecteddate.AddDays(7 * i)
                Dim sqlmdl As String = "SELECT * FROM [Course] WHERE DateAdd('ww',Duration_ps,SDate) >= CDate(@now) AND SDate <= CDate(@now) AND ModuleID=@mdl"
                cmd = New OleDb.OleDbCommand(sqlmdl, conn)
                cmd.Parameters.AddWithValue("@now", datetostring(nextdate))
                cmd.Parameters.AddWithValue("@mdl", mdl(0))
                dr = cmd.ExecuteReader
                If Not dr.HasRows() Then
                    MessageBox.Show("The selected repeat week is exceed the expire date of the module", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    conn.Close()
                    Exit Sub
                End If
            Next
            dr.Close()
            conn.Close()
        End If

        Dim cond1 As String = "( SELECT VenueID FROM Timetable LEFT JOIN Course ON Timetable.ModuleID = Course.ModuleID WHERE NOT ( Tdate >= DateAdd( 'n',(@duration*60),CDate(@date) ) OR DateAdd( 'n',(Course.Duration_pc*60),Tdate)<= CDate(@date)   ) )"
        Dim sql As String = "SELECT * FROM [Venue] WHERE VenueID NOT IN (" + cond1 + ")"

        If RadioButton2.Checked = True Then
            For i As Integer = 1 To Integer.Parse(cboxweek.Text)
                Dim nextdate As Date = selecteddate.AddDays(7 * i)
                Dim inicond As String = " AND VenueID NOT IN ("
                Dim cond As String = "( SELECT VenueID FROM Timetable LEFT JOIN Course ON Timetable.ModuleID = Course.ModuleID WHERE NOT ( Tdate >= DateAdd( 'n',(@duration*60),CDate(#" + datetostring(nextdate) + "#) ) OR DateAdd( 'n',(Course.Duration_pc*60),Tdate)<= CDate(#" + datetostring(nextdate) + "#)   ) )"
                Dim realcond As String = inicond + cond + ")"
                sql += realcond
            Next
        End If

        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.Parameters.AddWithValue("@duration", Integer.Parse(lblduration.Text.Substring(0, 1)))
        cmd.Parameters.AddWithValue("@date", datetostring(selecteddate))
        conn.Open()
        Try
            dr = cmd.ExecuteReader
            If Not dr.HasRows() Then
                MessageBox.Show("No Classroom is available within this duration")
                conn.Close()
                Exit Sub
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
            conn.Close()
            Exit Sub
        End Try
        conn.Close()
        dr.Close()

        venuetype()

        cboxhour.Enabled = False
        cboxminute.Enabled = False
        cboxampm.Enabled = False
        cboxweek.Enabled = False
        RadioButton1.Enabled = False
        RadioButton2.Enabled = False
        lblweek.Enabled = False

        cboxvenue.Enabled = True
        cboxvtype.Enabled = True

        btnconf2.Hide()
        btnconf3.Show()
    End Sub

    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        If RadioButton2.Checked = True Then
            cboxweek.SelectedIndex = 0
            cboxweek.Enabled = True
        ElseIf RadioButton1.Checked = True Then
            cboxweek.SelectedIndex = -1
            cboxweek.Enabled = False
        End If
    End Sub

    Private Sub cboxmdl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxmdl.SelectedIndexChanged
        Dim mdl As String() = cboxmdl.Text.Split(" ")
        intakeopt(mdl(0))
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Dim realdate As String = DateTimePicker1.Value.ToShortDateString
        Dim df As String = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern
        Dim valuedate As Date = Date.ParseExact(realdate, df, System.Globalization.DateTimeFormatInfo.InvariantInfo)
        If valuedate.DayOfWeek = 0 Then

        End If
        moduleopt(valuedate)
    End Sub

    Private Sub cboxintakeid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxintakeid.SelectedIndexChanged
        Dim mdl As String() = cboxmdl.Text.Split(" ")
        enroldetail(mdl(0), cboxintakeid.Text)
    End Sub

    Private Sub cboxampm_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxampm.SelectedIndexChanged
        hoursopt(cboxampm.Text)
    End Sub

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

    Private Sub btnconf3_Click(sender As Object, e As EventArgs) Handles btnconf3.Click
        If cboxvtype.Text.Length = 0 Or cboxvenue.Text.Length = 0 Then
            MessageBox.Show("Please fill in the details", "Form not complete", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        cboxvenue.Enabled = False
        cboxvtype.Enabled = False

        btnconf3.Hide()
        btnPublish.Enabled = True
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        fclear()
    End Sub

    Private Sub cboxvtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxvtype.SelectedIndexChanged
        cboxvenue.Items.Clear()
        cboxvenue.ResetText()

        venueavailable(cboxvtype.Text)
    End Sub

    Private Sub btnPublish_Click(sender As Object, e As EventArgs) Handles btnPublish.Click
        Dim autonum As New autonumber
        Dim id As String = autonum.getnextid(1)

        Dim strdate As String = DateTimePicker1.Value.ToShortDateString
        Dim df As String = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern
        Dim selecteddate As Date = Date.ParseExact(strdate, df, System.Globalization.DateTimeFormatInfo.InvariantInfo)
        Dim hour As Integer = Integer.Parse(cboxhour.Text)
        Dim mdl As String() = cboxmdl.Text.Split(" ")
        If cboxampm.Text.Equals("PM") And Not cboxhour.Text.Equals("12") Then
            hour += 12
        End If
        selecteddate = selecteddate.AddHours(hour)
        selecteddate = selecteddate.AddMinutes(Integer.Parse(cboxminute.Text))

        Dim sql As String = "INSERT INTO Timetable VALUES (@id,@venueid,@int,@mdl,@date)"
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand(sql, conn)

        cmd.Parameters.AddWithValue("@id", id)
        cmd.Parameters.AddWithValue("@venueid", cboxvenue.Text)
        cmd.Parameters.AddWithValue("@int", cboxintakeid.Text)
        cmd.Parameters.AddWithValue("@mdl", mdl(0))
        cmd.Parameters.AddWithValue("@date", datetostring(selecteddate))
        conn.Open()
        If cmd.ExecuteNonQuery() = 0 Then

        End If
        conn.Close()

        If RadioButton2.Checked = True Then
            For i As Integer = 1 To Integer.Parse(cboxweek.Text)
                id = autonum.getnextid(1)
                Dim nextdate As Date = selecteddate.AddDays(7 * i)
                cmd = New OleDb.OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("@id", id)
                cmd.Parameters.AddWithValue("@venueid", cboxvenue.Text)
                cmd.Parameters.AddWithValue("@int", cboxintakeid.Text)
                cmd.Parameters.AddWithValue("@mdl", mdl(0))
                cmd.Parameters.AddWithValue("@date", datetostring(nextdate))
                conn.Open()
                If cmd.ExecuteNonQuery = 0 Then

                End If
                conn.Close()
            Next
        End If
        MessageBox.Show("Timetable successfully published.", "Publish successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()
    End Sub
End Class