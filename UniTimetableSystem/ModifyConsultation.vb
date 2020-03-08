Imports System.Data.OleDb
Public Class ModifyConsultation
    Public selecteddate As String
    Public selectedtime As Double
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand 'run command search database
    Dim dr As OleDbDataReader 'forward reading component
    Dim global_flag As Integer = 0
    Dim newdate As String
    Dim newstarttime As String = "0"
    'Dim dv_arr As New ArrayList 'dv weeks
    Dim dur_arr As New ArrayList 'duration hour
    Private Sub cmbNStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNStatus.SelectedIndexChanged
        If cmbNStatus.SelectedIndex = 0 Then
            If btnMove.clickedpanel.BackColor = Color.Green Then 'not booked, no reason
                txtReason.Enabled = False
                lblCanRe.Enabled = False
                global_flag = 1
                btnUpdate.Enabled = True
            Else 'booked, backcolor = red, write reason + noti
                lblCanRe.Enabled = True
                txtReason.Enabled = True
                global_flag = 2
                btnUpdate.Enabled = True
            End If
        ElseIf cmbNStatus.SelectedIndex = 1 Then 'modify details
            Label4.Enabled = True
            global_flag = 3
            DateTimePicker1.MinDate = Date.Now()
            DateTimePicker1.MaxDate = Date.Now().AddMonths(3)
            Label5.Enabled = False
            cmbNewST.Enabled = False
            DateTimePicker1.Enabled = True
        End If
        btnClear.Enabled = True
        cmbNStatus.Enabled = False
    End Sub

    Private Sub cmbNDate_SelectedIndexChanged(sender As Object, e As EventArgs)
        cmbNewST.Enabled = True
        DateTimePicker1.Enabled = False
    End Sub

    Private Sub cmbNewST_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNewST.SelectedIndexChanged
        Label4.Enabled = False
        Label5.Enabled = False
        cmbNewDur.Enabled = True
        Label6.Enabled = True
        cmbNewST.Enabled = False
        DateTimePicker1.Enabled = False
        'put selected time into newselectedtime variable
        Dim str_time As String = cmbNewST.SelectedItem.ToString()
        Dim newtime_arr() = str_time.Split
        If (Integer.Parse(newtime_arr(0)) >= 10) Then '10,11,12
            newstarttime = newtime_arr(0)
        Else '8,9,1,2,3,4,5
            If newtime_arr(0).Equals("8") Or newtime_arr(0).Equals("9") Then
                newstarttime = newtime_arr(0)
            Else
                newstarttime = (Integer.Parse(newtime_arr(0)) + 12).ToString
            End If
        End If
        'For index As Integer = 0 To 12
        '    If newstarttime = "0" Then
        '        If newtime_arr(0).Equals("1") Then '1
        '            newstarttime = "13"
        '        ElseIf newtime_arr(0).Equals("10") Then '10
        '            newstarttime = "10" '10,11,12

        '        End If
        '    Else '8,9,2,3,4,5
        '            If newtime_arr(0).Equals("8") Then
        '                newstarttime = "8"
        '            ElseIf newtime_arr(0).Equals("9") Then
        '                newstarttime = "9"
        '            Else '2,3,4,5
        '                For indexy As Integer = 2 To 5
        '                    If (newtime_arr(0).Equals(indexy.ToString)) Then
        '                        newstarttime = (indexy + 12).ToString
        '                    End If
        '                Next
        '            End If
        '        End If
        '    Else
        '        Exit For
        '    End If
        'Next
    End Sub

    Private Sub cmbNewDur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNewDur.SelectedIndexChanged
        Label6.Enabled = False
        cmbNewDur.Enabled = False
        Label8.Enabled = True
        cmbNewVT.Enabled = True
        'store selected duration into dur_arr
        Dim i As Integer = cmbNewDur.SelectedIndex '0,1,2 for 1,2,3 hour
        Dim index As Integer = 0
        If i = 0 Then
            dur_arr.Add(newstarttime)
            'ListBox1.Items.Add(dur_arr(index))
        Else
            Dim tempdur As Double = newstarttime
            While (index <= i)
                dur_arr.Add(tempdur)
                'ListBox1.Items.Add(dur_arr(index))
                index += 1
                tempdur += 1
            End While
        End If
        'load venue type
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=abc.accdb;")
        con.Open()
        Dim sqlstatement As String = "SELECT DISTINCT VenueType FROM Venue ORDER BY VenueType ASC"
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter(sqlstatement, con)
        da.Fill(ds, "Venue")
        Dim Maxrows As Integer = ds.Tables("Venue").Rows.Count
        Dim venuecounter As Integer = 0
        Dim d As DataRow
        While Not venuecounter = Maxrows 'has not reach last row of table
            d = ds.Tables("Venue").Rows(venuecounter)
            If (d.Item(0).Equals("Library Discussion Room") = True Or d.Item(0).Equals("Consultation Suites") = True) Then
                cmbNewVT.Items.Add(d.Item(0))
            End If
            venuecounter += 1
        End While
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"
        da.Update(ds, "Venue")
        con.Close()
    End Sub

    Private Sub cmbNewVT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNewVT.SelectedIndexChanged
        Label8.Enabled = False
        cmbNewVT.Enabled = False
        Label9.Enabled = True
        cmbNewVID.Enabled = True
        'load available venue id
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=abc.accdb;")
        con.Open()
        Dim sqlstatement As String = "SELECT ConsultationDate, Stime, VenueID FROM Consultation 
                                        WHERE Status='Ongoing' AND ConsultationDate='" & newdate & "'AND Stime='" & newstarttime & "';"
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter(sqlstatement, con)
        da.Fill(ds, "Venue")
        Dim Maxrows As Integer = ds.Tables("Venue").Rows.Count
        Dim venuecounter As Integer = 0
        Dim d As DataRow
        Dim venue_arr As New ArrayList
        Dim i As Integer = 0
        While Not venuecounter = Maxrows 'has not reach last row of table
            d = ds.Tables("Venue").Rows(venuecounter)
            'For i = 0 To (dv_arr.Count - 1)
            '    If dv_arr(i).Equals(d.Item(0)) Then
            For j = 0 To (dur_arr.Count - 1)
                If dur_arr(j).ToString.Equals(d.Item(1)) Then
                    venue_arr.Add(d.Item(2))
                End If
            Next
            'End If
            'Next
            venuecounter += 1
        End While
        sqlstatement = "SELECT VenueID FROM Venue WHERE VenueType='" & cmbNewVT.SelectedItem & "';"
        Dim ds1 As New DataSet
        Dim da1 As New OleDbDataAdapter(sqlstatement, con)
        da1.Fill(ds1, "VenueName")
        Dim Maxrows1 As Integer = ds1.Tables("VenueName").Rows.Count
        venuecounter = 0
        Dim cnt As Integer = 0
        If venue_arr.Count > 0 Then
            While Not Maxrows1 = venuecounter 'has not reach last row of table
                d = ds1.Tables("VenueName").Rows(venuecounter)
                For i = 0 To (venue_arr.Count - 1)
                    If venue_arr(i).Equals(d.Item(0)) = False Then 'not matched
                        cnt = 1
                        Continue For
                    Else
                        cnt = 0
                        Exit For
                    End If
                Next
                If cnt = 1 Then
                    cmbNewVID.Items.Add(d.Item(0))
                End If
                venuecounter += 1
            End While
        Else
            While Not Maxrows1 = venuecounter 'has not reach last row of table
                d = ds1.Tables("VenueName").Rows(venuecounter)
                cmbNewVID.Items.Add(d.Item(0))
                venuecounter += 1
            End While
        End If
        con.Close()
    End Sub

    Private Sub cmbNewVID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbNewVID.SelectedIndexChanged
        btnUpdate.Enabled = True
        cmbNewVID.Enabled = False
        Label9.Enabled = False
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dur_arr.Clear()
        newstarttime = 0
        cmbNStatus.SelectedIndex = 0
        cmbNStatus.Enabled = True
        txtReason.Text = ""
        cmbNewST.Items.Clear()
        cmbNewVT.Items.Clear()
        cmbNewVID.Items.Clear()
        lblCanRe.Enabled = False
        txtReason.Enabled = False
        DateTimePicker1.Enabled = False
        cmbNewST.Enabled = False
        cmbNewDur.Enabled = False
        cmbNewVT.Enabled = False
        cmbNewVID.Enabled = False
        btnUpdate.Enabled = False
        btnClear.Enabled = False
        Label4.Enabled = False
        Label5.Enabled = False
        Label6.Enabled = False
        Label8.Enabled = False
        Label9.Enabled = False
    End Sub

    Private Sub txtReason_TextChanged(sender As Object, e As EventArgs) Handles txtReason.TextChanged
        btnUpdate.Enabled = True
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If global_flag = 1 Then 'not booked, no reason, green
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=abc.accdb;")
            Dim sql As String = "UPDATE Consultation SET Consultation.Status='Cancelled' 
                   WHERE Consultation.ConsultationDate = '" & selecteddate & "' AND Consultation.Stime ='" & selectedtime & "';"
            con.Open()
            cmd = New OleDbCommand(sql, con)
            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i >= 1) Then
                MessageBox.Show("This consultation slot has been successfully cancelled.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Sorry the appointment is not cancelled. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            con.Close()
            Me.Close()
        ElseIf global_flag = 2 Then 'booked, got reason + noti, red
            If txtReason.Text = "" Then 'dont allow
                MessageBox.Show("Please enter the cancellation reason.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=abc.accdb;")
                Dim sql As String = " UPDATE Appointment SET Status=@Status, Cancelledby=@Cancelledby, CancelReason=@CancelReason, CancelNoti=@CancelNoti WHERE Appointment.ConsultationID IN (SELECT Consultation.ConsultationID FROM Consultation " &
                                        " WHERE Consultation.ConsultationID = Appointment.ConsultationID AND Consultation.ConsultationDate = '" & selecteddate & "' AND Consultation.Stime = '" & selectedtime & "')"
                con.Open()
                cmd = New OleDbCommand(sql, con)
                cmd.Parameters.AddWithValue("@Status", "Cancelled")
                cmd.Parameters.AddWithValue("@Cancelledby", Login.uname)
                cmd.Parameters.AddWithValue("@CancelReason", txtReason.Text)
                cmd.Parameters.AddWithValue("@CancelNoti", "Unread")
                Dim i As Integer = cmd.ExecuteNonQuery()

                sql = "UPDATE Consultation INNER JOIN Appointment ON Consultation.ConsultationID = Appointment.ConsultationID
                    SET Consultation.Status='Cancelled' WHERE Consultation.ConsultationDate = '" & selecteddate & "' AND Consultation.Stime = '" & selectedtime & "';"
                cmd = New OleDbCommand(sql, con)
                i = cmd.ExecuteNonQuery()
                If (i >= 1) Then
                    MessageBox.Show("This appointment has been successfully cancelled." & vbNewLine & "A notification will be sent to notify the student.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Sorry the appointment is not cancelled. Please try again later.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
                con.Close()
                Me.Close()
            End If
        ElseIf global_flag = 3 Then 'modify details
            con = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=abc.accdb;")
            con.Open()
            Dim ds As New DataSet
            Dim sql As String = "SELECT Timetable.Tdate, Timetable.ModuleID
                                FROM (Intake_Module 
                                INNER JOIN Timetable ON Timetable.ModuleID = Intake_Module.ModuleID)
                                WHERE Intake_Module.LectureID ='" & Login.uname & "';"
            Dim da As New OleDbDataAdapter(sql, con)
            da.Fill(ds, "Timetable")
            Dim Maxrows As Integer = ds.Tables("Timetable").Rows.Count
            Dim ttcounter = 0, count = 0, i, j As Integer
            Dim contempdate As String
            Dim d As DataRow
            If Maxrows = 0 Then 'no data in timetable sql
                'check consultation table if clash
                sql = "SELECT ConsultationDate, Stime FROM Consultation WHERE LectureID='" & Login.uname &
                "'AND Status='Ongoing';"
                da = New OleDbDataAdapter(sql, con)
                da.Fill(ds, "ConsultationView")
                Maxrows = ds.Tables("ConsultationView").Rows.Count
                If Maxrows = 0 Then 'no consultation found for the lecturer
                    'straight away add
                    count = 0
                Else
                    ttcounter = 0
                    While Not ttcounter = Maxrows 'has not reach last row of table
                        d = ds.Tables("ConsultationView").Rows(ttcounter)
                        contempdate = Date.Parse(d.Item(0)).ToShortDateString
                        If contempdate.Equals(newdate) Then 'same date
                            For j = 0 To (dur_arr.Count - 1) 'loop con duration
                                If count = 1 Then
                                    Exit For
                                End If
                                Dim ampm As String
                                Dim time As Integer = Integer.Parse(d.Item(1))
                                If time < 12 Then
                                    ampm = "A.M."
                                Else
                                    ampm = "P.M."
                                End If
                                If ((time.ToString).Equals(dur_arr(j).ToString)) Then 'clash time
                                    ''''''''''output message to give warning
                                    MessageBox.Show("Unable to set consultation." & vbNewLine & "You have an existing consultation slot going on simultaneously on " & d.Item(0) & " at " & d.Item(1) & ".00 " & ampm, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    count = 1
                                    Exit For
                                ElseIf time > Convert.ToInt32(dur_arr(j)) Or time < Convert.ToInt32(dur_arr(j)) Then 'con time later or earlier than dur_arr by 1 hour
                                    count = 0
                                End If
                            Next
                        End If
                        ttcounter += 1
                    End While
                End If
                'update consultation slot
                If count = 0 Then 'date time duration all no problem
                    sql = "UPDATE Consultation SET ConsultationDate=@cd, Stime=@st, VenueID=@vid WHERE ConsultationDate='" & selecteddate &
                    "'AND Stime='" & selectedtime & "LectureID='" & Login.uname & "' AND Status='Ongoing';"
                    cmd = New OleDbCommand(sql, con)
                    cmd.Parameters.AddWithValue("@cd", newdate)
                    cmd.Parameters.AddWithValue("@st", newstarttime)
                    cmd.Parameters.AddWithValue("@vid", cmbNewVID.SelectedItem)
                    i = cmd.ExecuteNonQuery()
                    If (i >= 1) Then
                        MessageBox.Show("Consultation slot has been successfully added.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("Consultation slot is not modified.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else 'got data in timetable sql
                Dim tt_time As Date
                While Not ttcounter = Maxrows 'has not reach last row of table
                    d = ds.Tables("Timetable").Rows(ttcounter)
                    'For i = 0 To (dv_arr.Count - 1) 'loop con date validation w/ timetable
                    contempdate = Date.Parse(d.Item(0)).ToShortDateString
                    If contempdate.Equals(newdate) Then 'same date
                        For j = 0 To (dur_arr.Count - 1) 'loop con duration
                            If count = 1 Then
                                Exit For
                            End If
                            tt_time = Date.Parse(d.Item(0))
                            If ((tt_time.Hour.ToString).Equals(dur_arr(j).ToString)) Then 'clash time
                                ''''''''''output message to give warning
                                MessageBox.Show("Unable to set consultation." & vbNewLine & "There is a " & d.Item(1) & " class going on simultaneously on " & d.Item(0) & ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                count = 1
                                Exit For
                            ElseIf tt_time.Hour > Convert.ToInt32(dur_arr(j)) Or tt_time.Hour < Convert.ToInt32(dur_arr(j)) Then 'tt hour later or earlier than dur_arr by 1 hour
                                count = 0
                            End If
                        Next
                    End If
                    'Next
                    ttcounter += 1
                End While
                'check consultation table
                sql = "SELECT ConsultationDate, Stime FROM Consultation WHERE LectureID='" & Login.uname &
                "'AND Status='Ongoing';"
                da = New OleDbDataAdapter(sql, con)
                da.Fill(ds, "ConsultationView")
                Maxrows = ds.Tables("ConsultationView").Rows.Count
                If Maxrows = 0 Then 'no consultation found for the lecturer
                    'straight away add
                    count = 0
                Else
                    ttcounter = 0
                    While Not ttcounter = Maxrows 'has not reach last row of table
                        d = ds.Tables("ConsultationView").Rows(ttcounter)
                        contempdate = Date.Parse(d.Item(0)).ToShortDateString
                        If contempdate.Equals(newdate) Then 'same date
                            For j = 0 To (dur_arr.Count - 1) 'loop con duration
                                If count = 1 Then
                                    Exit For
                                End If
                                Dim ampm As String
                                Dim time As Integer = Integer.Parse(d.Item(1))
                                If time < 12 Then
                                    ampm = "A.M."
                                Else
                                    ampm = "P.M."
                                End If
                                If ((time.ToString).Equals(dur_arr(j).ToString)) Then 'clash time
                                    ''''''''''output message to give warning
                                    MessageBox.Show("Unable to set consultation." & vbNewLine & "You have an existing consultation slot going on simultaneously on " & d.Item(0) & " at " & d.Item(1) & ".00 " & ampm, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    count = 1
                                    Exit For
                                ElseIf time > Convert.ToInt32(dur_arr(j)) Or time < Convert.ToInt32(dur_arr(j)) Then 'con time later or earlier than dur_arr by 1 hour
                                    count = 0
                                End If
                            Next
                        End If
                        ttcounter += 1
                    End While
                End If
                If count = 0 Then 'no clash, write into db
                    If btnMove.clickedpanel.BackColor = Color.Green Then
                        sql = "UPDATE Consultation SET ConsultationDate=@cd, Stime=@st, VenueID=@vid
                            WHERE ConsultationDate = '" & selecteddate & "' AND Stime = '" & selectedtime & "' AND LectureID='" & Login.uname & "'AND Status='Ongoing';"
                        cmd = New OleDbCommand(sql, con)
                        cmd.Parameters.AddWithValue("@cd", newdate)
                        cmd.Parameters.AddWithValue("@st", newstarttime)
                        cmd.Parameters.AddWithValue("@vid", cmbNewVID.SelectedItem)
                        i = cmd.ExecuteNonQuery()
                        If i >= 1 Then
                            MessageBox.Show("Consultation slot has been successfully modified.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Unsuccessful modification.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    ElseIf btnMove.clickedpanel.BackColor = Color.Red Then
                        sql = "UPDATE Consultation INNER JOIN Appointment ON Consultation.ConsultationID = Appointment.ConsultationID
                            SET Consultation.ConsultationDate=@cd, Consultation.Stime=@st, Consultation.VenueID=@vid, Appointment.CancelReason=@cr, Appointment.CancelNoti=@CancelNoti
                            WHERE Consultation.ConsultationDate = '" & selecteddate & "' AND Consultation.Stime = '" & selectedtime & "' AND Consultation.LectureID='" & Login.uname & "'AND Consultation.Status='Ongoing';"

                        cmd = New OleDbCommand(sql, con)
                        cmd.Parameters.AddWithValue("@cd", newdate)
                        cmd.Parameters.AddWithValue("@st", newstarttime)
                        cmd.Parameters.AddWithValue("@vid", cmbNewVID.SelectedItem)
                        cmd.Parameters.AddWithValue("@cr", Login.uname & " " & selecteddate & " " & selectedtime & " " & newdate & " " & newstarttime & " " & cmbNewVID.SelectedItem)
                        cmd.Parameters.AddWithValue("@CancelNoti", "Unread")
                        i = cmd.ExecuteNonQuery()

                        If i >= 1 Then
                            MessageBox.Show("Consultation slot has been successfully modified." & vbNewLine & "A notification will be sent to the student who booked the consultation slot.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Unsuccessful modification", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    End If
                    If dur_arr.Count > 1 Then 'duration 2 - 3
                        Dim ds1 As New DataSet
                        Dim sql1 As String = "SELECT * FROM Consultation"
                        Dim da1 As New OleDb.OleDbDataAdapter(sql1, con)
                        da1.Fill(ds1, "Consultation")
                        Dim newrows As DataRow = ds1.Tables("Consultation").NewRow
                        For j = 1 To (dur_arr.Count - 1)
                            newrows.Item(1) = Login.uname
                            newrows.Item(2) = newdate
                            newrows.Item(3) = dur_arr(j)
                            newrows.Item(4) = cmbNewVID.SelectedItem
                            newrows.Item(5) = "Ongoing"
                            ds1.Tables("Consultation").Rows.Add(newrows)
                            newrows = ds1.Tables("Consultation").NewRow()
                        Next
                        Dim cb As New OleDb.OleDbCommandBuilder(da1)
                        cb.QuotePrefix = "["
                        cb.QuoteSuffix = "]"
                        da1.Update(ds1, "Consultation")
                    End If
                End If
                End If
            con.Close()
            Me.Close()
        End If
    End Sub

    Private Sub ModifyConsultation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=abc.accdb;")
        'Dim sql As String
        'sql = "SELECT * FROM Consultation WHERE LectureID=@LID AND ConsultationDate=@CD AND Stime=@ST"

        'conn.Open()
        'cmd = New OleDbCommand(sql, conn)
        'cmd.Parameters.AddWithValue("@LID", Login.uname)
        'cmd.Parameters.AddWithValue("@CD", selecteddate)
        'cmd.Parameters.AddWithValue("@ST", selectedtime)
        'dr = cmd.ExecuteReader

        'If (dr.HasRows) Then
        '    dr.Read()
        '    cmbNewDur.SelectedItem = dr.Item("Duration")
        '    cmbNewDate.SelectedItem = dr.Item("Datevalidation")
        '    cmbNewVID.SelectedItem = dr.Item("VenueID")
        'End If
        'conn.Close()
        txtOldDate.Text = selecteddate
        txtOldTime.Text = selectedtime
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Label5.Enabled = True
        cmbNewST.Enabled = True
        cmbNewST.Items.Clear()
        If DateTimePicker1.Enabled = True Then
            If (DateTimePicker1.Value.DayOfWeek = DayOfWeek.Saturday Or DateTimePicker1.Value.DayOfWeek = DayOfWeek.Sunday) Then
                Label5.Enabled = False
                cmbNewST.Enabled = False
            Else
                newdate = DateTimePicker1.Value.ToShortDateString
                con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=abc.accdb;")
                con.Open()
                Dim sqlstatement As String = "SELECT Stime, VenueID FROM Consultation WHERE Status='Ongoing'" & "AND LectureID='" & Login.uname & "'AND ConsultationDate='" & newdate & "';"
                Dim ds As New DataSet
                Dim da As New OleDbDataAdapter(sqlstatement, con)
                da.Fill(ds, "STime")
                Dim Maxrows As Integer = ds.Tables("STime").Rows.Count
                Dim stimecounter As Integer = 0
                Dim d As DataRow
                Dim stime_arr As New ArrayList
                Dim i As Integer = 0
                Dim index As Integer = 0
                Dim count As Integer = 0
                If Maxrows = 0 Then 'no data found in consultation table
                    i = 8
                    While i <= 17
                        If (i >= 12) Then
                            If (i = 12) Then
                                cmbNewST.Items.Add(i.ToString & " P.M.")
                            Else
                                Dim temptime As Double = i - 12
                                cmbNewST.Items.Add(temptime.ToString & " P.M.")
                            End If
                        Else
                            cmbNewST.Items.Add(i.ToString & " A.M.")
                        End If
                        i += 1
                    End While
                Else 'got data
                    While Not stimecounter = Maxrows 'has not reach last row of table
                        d = ds.Tables("STime").Rows(stimecounter)
                        stime_arr.Add(d.Item(0))
                        stimecounter += 1
                    End While
                    i = 8
                    While i <= 17
                        For index = 0 To (stime_arr.Count - 1)
                            If Integer.Parse(stime_arr(index)).Equals(i) = False Then 'not match, check next element
                                count = 0
                            Else
                                count = 1
                                Exit For
                            End If
                        Next
                        If count = 0 Then 'not match, add into cmb
                            'check if >12 or <12, put am / pm, add to cmb
                            If (i >= 12) Then
                                If (i = 12) Then
                                    cmbNewST.Items.Add(i.ToString & " P.M.")
                                Else
                                    Dim temptime As Double = i - 12
                                    cmbNewST.Items.Add(temptime.ToString & " P.M.")
                                End If
                            Else
                                cmbNewST.Items.Add(i.ToString & " A.M.")
                            End If
                        End If
                        i += 1
                    End While
                End If
            End If
        End If
    End Sub
End Class