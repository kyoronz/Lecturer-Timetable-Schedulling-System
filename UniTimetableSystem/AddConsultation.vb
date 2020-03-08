Imports System.Data.OleDb
Public Class AddConsultation
    Public selecteddate As String
    Public selectedtime As Double
    Dim dv_arr As New ArrayList 'dv weeks
    Dim dur_arr As New ArrayList 'duration hour
    'Public con_id As Integer = 0
    Dim flag As Integer
    Dim con As OleDb.OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub cmbDur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDur.SelectedIndexChanged
        cmbDateV.Enabled = True
        cmbDur.Enabled = False
        btnClear.Enabled = True
        Dim i As Integer = cmbDur.SelectedIndex '0,1,2 for 1,2,3 hour
        Dim index As Integer = 0
        If i = 0 Then
            dur_arr.Add(selectedtime)
            'ListBox1.Items.Add(dur_arr(index))
        Else
            Dim tempdur As Double = selectedtime
            While (index <= i)
                dur_arr.Add(tempdur)
                'ListBox1.Items.Add(dur_arr(index))
                index += 1
                tempdur += 1
            End While
        End If
    End Sub

    Private Sub cmbDateV_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDateV.SelectedIndexChanged
        cmbVT.Enabled = True
        cmbDateV.Enabled = False
        Dim i As Integer = cmbDateV.SelectedIndex '0,1,2,3 for 1,2,3,4 week
        Dim index As Integer = 0
        If i = 0 Then
            dv_arr.Add(selecteddate)
            ListBox1.Items.Add(dv_arr(index))
        Else
            Dim tempdate As Date = Date.Parse(selecteddate)
            While (index <= i)
                dv_arr.Add(tempdate.ToShortDateString)
                ListBox1.Items.Add(dv_arr(index))
                index += 1
                tempdate = tempdate.AddDays(7)
            End While
        End If
    End Sub

    Private Sub cmbVT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVT.SelectedIndexChanged
        cmbVID.Enabled = True
        cmbVT.Enabled = False
        'search db for venue id based on venue type
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=abc.accdb;")
        con.Open()
        Dim sqlstatement As String = "SELECT ConsultationDate, Stime, VenueID FROM Consultation WHERE Status='Ongoing';"
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
            For i = 0 To (dv_arr.Count - 1)
                If dv_arr(i).Equals(d.Item(0)) Then
                    For j = 0 To (dur_arr.Count - 1)
                        If dur_arr(j).ToString.Equals(d.Item(1)) Then
                            venue_arr.Add(d.Item(2))
                        End If
                    Next
                End If
            Next
            venuecounter += 1
        End While
        sqlstatement = "SELECT VenueID FROM Venue WHERE VenueType='" & cmbVT.SelectedItem & "';"
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
                    cmbVID.Items.Add(d.Item(0))
                End If
                venuecounter += 1
            End While
        Else
            While Not Maxrows1 = venuecounter 'has not reach last row of table
                d = ds1.Tables("VenueName").Rows(venuecounter)
                cmbVID.Items.Add(d.Item(0))
                venuecounter += 1
            End While
        End If
        con.Close()
    End Sub

    Private Sub cmbVID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVID.SelectedIndexChanged
        btnAdd.Enabled = True
        cmbVID.Enabled = False
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ListBox1.Items.Clear()
        dv_arr.Clear()
        dur_arr.Clear()
        cmbVT.Items.Clear()
        loadVenueType() 'load function to load venue type
        cmbVID.Items.Clear()
        cmbDur.Enabled = True
        cmbDateV.Enabled = False
        cmbVT.Enabled = False
        cmbVID.Enabled = False
        btnAdd.Enabled = False
        btnClear.Enabled = False
    End Sub

    Private Sub AddConsultation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDate.Text = selecteddate
        Dim temptime As Double
        'change selectedtime to 12hour basis
        If (selectedtime >= 12) Then
            If (selectedtime = 12) Then
                txtST.Text = selectedtime & " P.M."
            Else
                temptime = selectedtime - 12
                txtST.Text = temptime.ToString & " P.M."
            End If
        Else
                txtST.Text = selectedtime.ToString & " A.M."
        End If
        'search db for venue type
        loadVenueType()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim contempdate As String
        Dim tt_time As Date
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
        Dim d As DataRow
        If Maxrows = 0 Then 'no data
            sql = "SELECT ConsultationDate, Stime FROM Consultation WHERE LectureID='" & Login.uname &
                "'AND Status='Ongoing'"
            da = New OleDbDataAdapter(sql, con)
            da.Fill(ds, "ConsultationView")
            Maxrows = ds.Tables("ConsultationView").Rows.Count
            If Maxrows = 0 Then 'no consultation found for the lecturer
                'straight away add
                count = 0
            Else
                While Not ttcounter = Maxrows 'has not reach last row of table
                    d = ds.Tables("ConsultationView").Rows(ttcounter)
                    For i = 0 To (dv_arr.Count - 1) 'loop con date validation w/ timetable
                        contempdate = Date.Parse(d.Item(0)).ToShortDateString
                        If contempdate.Equals(dv_arr(i).ToString) Then 'same date
                            For j = 0 To (dur_arr.Count - 1) 'loop con duration
                                If count = 1 Then
                                    Exit For
                                End If
                                Dim time As Integer = Integer.Parse(d.Item(1))
                                If ((time.ToString).Equals(dur_arr(j).ToString)) Then 'clash time
                                    ''''''''''output message to give warning
                                    MessageBox.Show("Unable to set consultation." & vbNewLine & "You have an existing consultation slot going on simultaneously on " & d.Item(0) & " at " & d.Item(1) & ".00", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                    count = 1
                                    Exit For
                                ElseIf time > Convert.ToInt32(dur_arr(j)) Or time < Convert.ToInt32(dur_arr(j)) Then 'con time later or earlier than dur_arr by 1 hour
                                    count = 0
                                End If
                            Next
                        End If
                    Next
                    ttcounter += 1
                End While
            End If
            If count = 0 Then
                'add into consultation table
                Dim ds1 As New DataSet
                Dim sql1 As String = "SELECT * FROM Consultation"
                Dim da1 As New OleDb.OleDbDataAdapter(sql1, con)
                da1.Fill(ds1, "Consultation")
                Dim newrows As DataRow = ds1.Tables("Consultation").NewRow
                For i = 0 To (dv_arr.Count - 1)
                    For j = 0 To (dur_arr.Count - 1)
                        newrows.Item(1) = Login.uname
                        newrows.Item(2) = dv_arr(i)
                        newrows.Item(3) = dur_arr(j)
                        newrows.Item(4) = cmbVID.SelectedItem
                        newrows.Item(5) = "Ongoing"
                        ds1.Tables("Consultation").Rows.Add(newrows)
                        newrows = ds1.Tables("Consultation").NewRow()
                    Next
                Next
                Dim cb As New OleDb.OleDbCommandBuilder(da1)
                cb.QuotePrefix = "["
                cb.QuoteSuffix = "]"
                da1.Update(ds1, "Consultation")
                MessageBox.Show("Consultation slot has been successfully added.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else 'got data
            While Not ttcounter = Maxrows 'has not reach last row of table
                d = ds.Tables("Timetable").Rows(ttcounter)
                For i = 0 To (dv_arr.Count - 1) 'loop con date validation w/ timetable
                    contempdate = Date.Parse(d.Item(0)).ToShortDateString
                    If contempdate.Equals(dv_arr(i).ToString) Then 'same date
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
                Next
                ttcounter += 1
            End While

            If (count = 0) Then
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
                        For i = 0 To (dv_arr.Count - 1) 'loop con date validation w/ timetable
                            contempdate = Date.Parse(d.Item(0)).ToShortDateString
                            If contempdate.Equals(dv_arr(i).ToString) Then 'same date
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
                        Next
                        ttcounter += 1
                    End While
                End If
            End If

            If (count = 0) Then 'no clash, write into db
                    Dim ds1 As New DataSet
                    sql = "SELECT * FROM Consultation"
                    Dim da1 As New OleDb.OleDbDataAdapter(sql, con)
                    da1.Fill(ds1, "Consultation")
                    Dim newrows As DataRow = ds1.Tables("Consultation").NewRow
                    For i = 0 To (dv_arr.Count - 1)
                        For j = 0 To (dur_arr.Count - 1)
                            newrows.Item(1) = Login.uname
                            newrows.Item(2) = dv_arr(i)
                            newrows.Item(3) = dur_arr(j)
                            newrows.Item(4) = cmbVID.SelectedItem
                            newrows.Item(5) = "Ongoing"
                            ds1.Tables("Consultation").Rows.Add(newrows)
                            newrows = ds1.Tables("Consultation").NewRow()
                        Next
                    Next
                    Dim cb As New OleDb.OleDbCommandBuilder(da1)
                    cb.QuotePrefix = "["
                    cb.QuoteSuffix = "]"
                    da1.Update(ds1, "Consultation")
                    MessageBox.Show("Consultation slot has been successfully added.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
            con.Close()
        Me.Close()
    End Sub

    Sub loadVenueType()
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
                cmbVT.Items.Add(d.Item(0))
            End If
            venuecounter += 1
        End While
        Dim cb As New OleDb.OleDbCommandBuilder(da)
        cb.QuotePrefix = "["
        cb.QuoteSuffix = "]"
        da.Update(ds, "Venue")
        con.Close()
    End Sub
End Class