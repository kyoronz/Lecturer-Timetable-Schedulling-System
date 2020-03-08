Public Class LTimetableView
    Dim loginflag As Integer = 1 ''fake

    Public chosenweek As Date()
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
    Private Sub LTimetableView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        forminitialisation()
        lectureopt()
        ' timetable(currentweek(Date.ParseExact("2017/04/17", "yyyy/MM/dd", System.Globalization.DateTimeFormatInfo.InvariantInfo)))
    End Sub
    Function timetable(ByVal passdate As Date())
        Dim sql As String = "SELECT Format(Timetable.Tdate, 'dd/mm/yyyy hh:nn:ss am/pm') as [Timetable Date], Timetable.ModuleID as [Module Code], Course.ModuleName as [Module Name], Timetable.IntakeID as [Intake], Lecture.LectureName as [Lecture], Timetable.VenueID as [Venue] "

        If loginflag = 1 Then
            sql += ",Timetable.TimetableID as [Timetable ID]"
        End If
        sql += "FROM ( ( (Timetable LEFT JOIN Course On (Timetable.ModuleID = Course.ModuleID)) LEFT JOIN Intake_Module On (Intake_Module.ModuleID = Timetable.ModuleID And Intake_Module.IntakeID = Timetable.IntakeID) ) LEFT JOIN Lecture On Lecture.LectureID = Intake_Module.LectureID ) WHERE TDate>=CDate(#" + datetostring(passdate(0)) + "#) And TDate<=CDate(#" + datetostring(passdate(1)) + "#) "
        Dim lectureid As String() = cboxlecture.Text.Split(" ")
        If Not cboxlecture.Text.Length = 0 Then
            sql += "And Intake_Module.LectureID = '" + lectureid(0) + "' "
        End If
        sql += "ORDER BY Timetable.Tdate ASC"
        Dim ds As New DataSet
        Dim da As New OleDb.OleDbDataAdapter(sql, LTimetableAdd.conn)
        LTimetableAdd.conn.Open()
        da.Fill(ds, "Timetable")
        LTimetableAdd.conn.Close()
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "Timetable"

        DataGridView1.Columns(0).Width = 150
    End Function

    Function currentweek(ByVal passdate As Date)
        Dim checkdate As Date = Date.ParseExact("2017/04/03", "yyyy/MM/dd", System.Globalization.DateTimeFormatInfo.InvariantInfo)
        Dim checkfirst As Integer = checkdate.DayOfWeek
        Dim df As String = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern
        passdate = Date.ParseExact(passdate.ToShortDateString(), df, System.Globalization.DateTimeFormatInfo.InvariantInfo)
        Dim firstday As Date
        Dim lastday As Date
        Dim passfirst As Integer = passdate.DayOfWeek
        If checkfirst = 0 Then
            ''First day is Monday
            firstday = passdate.AddDays(-passfirst)
            lastday = passdate.AddDays(-passfirst + 6)
        ElseIf checkfirst = 1 Then
            ''First day is Sunday
            If passfirst = 0 Then
                passfirst = 7
            End If
            firstday = passdate.AddDays(-passfirst + 1)
            lastday = passdate.AddDays(-passfirst + 7)
        End If

        Dim aweek As Date() = {firstday, lastday}
        chosenweek = aweek
        Return aweek
    End Function

    Function forminitialisation()
        DateTimePicker1.MinDate = Today.AddDays(-7)
        If Not loginflag = 1 Then
            lbltbid.Hide()
            txttbid.Hide()
            btnadd.Hide()
            btnedit.Hide()
            btndel.Hide()
        End If
    End Function

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        timetable(currentweek(DateTimePicker1.Value))
        textclear()
    End Sub
    Function lectureopt()
        cboxlecture.Items.Clear()
        cboxlecture.ResetText()
        Dim sql As String = "SELECT * FROM Lecture"
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand(sql, LTimetableAdd.conn)
        LTimetableAdd.conn.Open()
        dr = cmd.ExecuteReader
        If Not dr.HasRows Then
            ''no data
        Else
            While dr.Read
                Dim lecture As String = dr.Item(0) + " " + dr.Item(1)
                cboxlecture.Items.Add(lecture)
            End While
        End If
        LTimetableAdd.conn.Close()
        cboxlecture.SelectedIndex = 0
        textclear()
    End Function

    Function textclear()
        txttbid.Clear()
        txtdate.Clear()
        txtmdlid.Clear()
        txtmdlname.Clear()
        txtint.Clear()
        txtvenue.Clear()
    End Function

    Private Sub cboxlecture_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboxlecture.SelectedIndexChanged
        timetable(currentweek(DateTimePicker1.Value))
        textclear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        If txttbid.Text.Length = 0 Then
            MessageBox.Show("Choose one timetable to proceed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim edit As New LTimetableEdit()
        edit.setrecord(txttbid.Text, chosenweek)
        edit.ShowDialog()
        timetable(currentweek(DateTimePicker1.Value))
    End Sub
    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Dim row As Integer = e.RowIndex
        If row = -1 Then
            Exit Sub
        End If
        txtdate.Text = DataGridView1.Rows(row).Cells(0).Value
        txtmdlid.Text = DataGridView1.Rows(row).Cells(1).Value
        txtmdlname.Text = DataGridView1.Rows(row).Cells(2).Value
        txtint.Text = DataGridView1.Rows(row).Cells(3).Value
        txtvenue.Text = DataGridView1.Rows(row).Cells(5).Value
        Try
            If loginflag = 1 Then
                txttbid.Text = DataGridView1.Rows(row).Cells(6).Value
            End If
        Catch ex As Exception
            ''out of bound error
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Dim add As New LTimetableAdd()
        add.ShowDialog()
        textclear()
        timetable(currentweek(DateTimePicker1.Value))
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btndel.Click
        If Not loginflag = 1 Then
            MessageBox.Show("Only admin can delete the timetable details")
            Exit Sub
        End If
        If txttbid.Text.Length = 0 Then
            MessageBox.Show("Choose one timetable to proceed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Dim i As Integer = MessageBox.Show("Are you sure you want to delete the selected timetable details?", "Confirmation Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)
        If Not i = DialogResult.Yes Then
            Exit Sub
        Else
            Dim sql As String = "DELETE FROM Timetable WHERE TimetableID = @id"
            Dim dr As OleDb.OleDbDataReader
            Dim cmd As New OleDb.OleDbCommand(sql, LTimetableAdd.conn)
            cmd.Parameters.AddWithValue("@id", txttbid.Text)
            LTimetableAdd.conn.Open()
            If cmd.ExecuteNonQuery = 0 Then

            End If
            LTimetableAdd.conn.Close()
        End If
        textclear()
        timetable(currentweek(DateTimePicker1.Value))
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        LTimetablePrint.ShowDialog()
    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Me.Close()
        AdminMenu.pcb.Visible = True
    End Sub
End Class