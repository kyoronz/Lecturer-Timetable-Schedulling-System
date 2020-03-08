Imports System.Data.OleDb
Public Class btnMove
    Public global_time As Double
    Public global_date As String
    Public consultationid As String
    Public clickedpanel As Panel
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim tempd As String
    Dim tempt As String
    Dim flag As Integer
    Dim dates As Date
    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Dim dialog As ModifyConsultation
        dialog = New ModifyConsultation()
        dialog.selecteddate = global_date
        dialog.selectedtime = global_time
        Dim result As DialogResult = dialog.ShowDialog(Me)
        If result = DialogResult.Yes Then
            loadConSchedule()
            loadApp()
            btnAddCon.Enabled = False
            btnmo.Enabled = False
            btnMod.Enabled = False
            panelappm.Visible = False
        End If
    End Sub

    Private Sub btnAddCon_Click(sender As Object, e As EventArgs) Handles btnAddCon.Click
        Dim dialog As AddConsultation
        dialog = New AddConsultation()
        dialog.selecteddate = global_date
        dialog.selectedtime = global_time
        Dim result As DialogResult = dialog.ShowDialog(Me)
        If result = DialogResult.Yes Then
            loadConSchedule()
            loadApp()
            btnAddCon.Enabled = False
            btnmo.Enabled = False
            btnMod.Enabled = False
            panelappm.Visible = False
        End If
    End Sub

    Private Sub btnBook_Click(sender As Object, e As EventArgs) Handles btnBook.Click
        tempd = lbldate.Text
        tempt = lbltime.Text
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=abc.accdb;")
        Dim sql As String = "SELECT ConsultationID FROM Consultation WHERE ConsultationDate = '" & tempd & "' AND Status = 'Ongoing' AND Stime = '" & tempt & "'"
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter(sql, con)
        da.Fill(ds, "consulid")
        Dim d As DataRow
        d = ds.Tables("consulid").Rows(0)
        consultationid = d.Item(0)
        Dim dialog As BookConsultation
        dialog = New BookConsultation()
        Dim result As DialogResult = dialog.ShowDialog(Me)
        If result = DialogResult.Yes Then
            loadConSchedule()
            loadSApp()
            btnBook.Enabled = False
            btnCanApp.Enabled = True
        End If
    End Sub
    Sub Loaddate()
        'load dates 
        dates = PreViewConsultation.monday_date
        Dim converteddate As Date = Convert.ToDateTime(dates)
        Date1.Text = dates
        Date2.Text = converteddate.AddDays(1).ToShortDateString
        Date3.Text = converteddate.AddDays(2).ToShortDateString
        Date4.Text = converteddate.AddDays(3).ToShortDateString
        Date5.Text = converteddate.AddDays(4).ToShortDateString
        'load db for booked con
    End Sub
    Sub checkd()
        Dim da1 As Date = Convert.ToDateTime(Date1.Text)
        Dim da2 As Date = Convert.ToDateTime(Date2.Text)
        Dim da3 As Date = Convert.ToDateTime(Date3.Text)
        Dim da4 As Date = Convert.ToDateTime(Date4.Text)
        Dim da5 As Date = Convert.ToDateTime(Date5.Text)
        'column 1
        If (Date.Compare(da1, Date.Parse(Date.Now().ToShortDateString)) = 0) Then 'if today check the time and disable accordingly
            If Date.Now().Hour >= 8 Then
                P01.Enabled = False
            End If
            If Date.Now().Hour >= 9 Then
                P02.Enabled = False
            End If
            If Date.Now().Hour >= 10 Then
                P03.Enabled = False
            End If
            If Date.Now().Hour >= 11 Then
                P04.Enabled = False
            End If
            If Date.Now().Hour >= 12 Then
                P05.Enabled = False
            End If
            If Date.Now().Hour >= 13 Then
                P06.Enabled = False
            End If
            If Date.Now().Hour >= 14 Then
                P07.Enabled = False
            End If
            If Date.Now().Hour >= 15 Then
                P08.Enabled = False
            End If
            If Date.Now().Hour >= 16 Then
                P09.Enabled = False
            End If
            If Date.Now().Hour >= 17 Then
                P10.Enabled = False
            End If
        ElseIf (Date.Compare(da1, Date.Now()) < 0) Then 'if past day
            Panel31.Enabled = False
        End If
        'column 2
        If (Date.Compare(da2, Date.Parse(Date.Now().ToShortDateString)) = 0) Then
            If Date.Now().Hour >= 8 Then
                P11.Enabled = False
            End If
            If Date.Now().Hour >= 9 Then
                P12.Enabled = False
            End If
            If Date.Now().Hour >= 10 Then
                P13.Enabled = False
            End If
            If Date.Now().Hour >= 11 Then
                P14.Enabled = False
            End If
            If Date.Now().Hour >= 12 Then
                P15.Enabled = False
            End If
            If Date.Now().Hour >= 13 Then
                P16.Enabled = False
            End If
            If Date.Now().Hour >= 14 Then
                P17.Enabled = False
            End If
            If Date.Now().Hour >= 15 Then
                P18.Enabled = False
            End If
            If Date.Now().Hour >= 16 Then
                P19.Enabled = False
            End If
            If Date.Now().Hour >= 17 Then
                P20.Enabled = False
            End If
        ElseIf (Date.Compare(da2, Date.Now()) < 0) Then
            Panel42.Enabled = False
        End If
        'column 3
        If (Date.Compare(da3, Date.Parse(Date.Now().ToShortDateString)) = 0) Then
            If Date.Now().Hour >= 8 Then
                P21.Enabled = False
            End If
            If Date.Now().Hour >= 9 Then
                P22.Enabled = False
            End If
            If Date.Now().Hour >= 10 Then
                P23.Enabled = False
            End If
            If Date.Now().Hour >= 11 Then
                P24.Enabled = False
            End If
            If Date.Now().Hour >= 12 Then
                P25.Enabled = False
            End If
            If Date.Now().Hour >= 13 Then
                P26.Enabled = False
            End If
            If Date.Now().Hour >= 14 Then
                P27.Enabled = False
            End If
            If Date.Now().Hour >= 15 Then
                P28.Enabled = False
            End If
            If Date.Now().Hour >= 16 Then
                P29.Enabled = False
            End If
            If Date.Now().Hour >= 17 Then
                P30.Enabled = False
            End If
        ElseIf (Date.Compare(da3, Date.Now()) < 0) Then
            Panel53.Enabled = False
        End If
        'column 4
        If (Date.Compare(da4, Date.Parse(Date.Now().ToShortDateString)) = 0) Then
            If Date.Now().Hour >= 8 Then
                P31.Enabled = False
            End If
            If Date.Now().Hour >= 9 Then
                P32.Enabled = False
            End If
            If Date.Now().Hour >= 10 Then
                P33.Enabled = False
            End If
            If Date.Now().Hour >= 11 Then
                P34.Enabled = False
            End If
            If Date.Now().Hour >= 12 Then
                P35.Enabled = False
            End If
            If Date.Now().Hour >= 13 Then
                P36.Enabled = False
            End If
            If Date.Now().Hour >= 14 Then
                P37.Enabled = False
            End If
            If Date.Now().Hour >= 15 Then
                P38.Enabled = False
            End If
            If Date.Now().Hour >= 16 Then
                P39.Enabled = False
            End If
            If Date.Now().Hour >= 17 Then
                P40.Enabled = False
            End If
        ElseIf (Date.Compare(da4, Date.Now()) < 0) Then
            Panel64.Enabled = False
        End If
        'column 5
        If (Date.Compare(da5, Date.Parse(Date.Now().ToShortDateString)) = 0) Then
            If Date.Now().Hour >= 8 Then
                P41.Enabled = False
            End If
            If Date.Now().Hour >= 9 Then
                P42.Enabled = False
            End If
            If Date.Now().Hour >= 10 Then
                P43.Enabled = False
            End If
            If Date.Now().Hour >= 11 Then
                P44.Enabled = False
            End If
            If Date.Now().Hour >= 12 Then
                P45.Enabled = False
            End If
            If Date.Now().Hour >= 13 Then
                P46.Enabled = False
            End If
            If Date.Now().Hour >= 14 Then
                P47.Enabled = False
            End If
            If Date.Now().Hour >= 15 Then
                P48.Enabled = False
            End If
            If Date.Now().Hour >= 16 Then
                P49.Enabled = False
            End If
            If Date.Now().Hour >= 17 Then
                P50.Enabled = False
            End If
        ElseIf (Date.Compare(da5, Date.Now()) < 0) Then
            Panel75.Enabled = False
        End If
    End Sub
    Sub loadSApp()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=abc.accdb;")
        Dim sql As String = "SELECT * FROM Consultation" &
                            " WHERE Consultation.Status='Ongoing' AND Consultation.ConsultationID IN (SELECT Appointment.ConsultationID FROM Appointment" &
                            " WHERE Appointment.Status = 'Ongoing' AND Appointment.ConsultationID = Consultation.ConsultationID)"
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter(sql, con)
        da.Fill(ds, "appm")
        Dim Maxrows As Integer = ds.Tables("appm").Rows.Count
        Dim rcounter As Integer = 0
        Dim d As DataRow
        Dim dat As Date
        Dim dtable1, dtable2, dtable3, dtable4, dtable5 As Date
        While Not rcounter = Maxrows
            d = ds.Tables("appm").Rows(rcounter)
            If Equals(d.Item(1), PreViewConsultation.lectureid) Then
                dat = d.Item(2)
                dat.ToShortDateString()
                dtable1 = Date1.Text
                dtable2 = Date2.Text
                dtable3 = Date3.Text
                dtable4 = Date4.Text
                dtable5 = Date5.Text
                If (Date.Compare(dat, dtable1) = 0) Then
                    If (d.Item(5) = "Ongoing") Then
                        If (d.Item(3) = "8") Then
                            P01.BackColor = Color.Red
                        ElseIf (d.Item(3) = "9") Then
                            P02.BackColor = Color.Red
                        ElseIf (d.Item(3) = "10") Then
                            P03.BackColor = Color.Red
                        ElseIf (d.Item(3) = "11") Then
                            P04.BackColor = Color.Red
                        ElseIf (d.Item(3) = "12") Then
                            P05.BackColor = Color.Red
                        ElseIf (d.Item(3) = "13") Then
                            P06.BackColor = Color.Red
                        ElseIf (d.Item(3) = "14") Then
                            P07.BackColor = Color.Red
                        ElseIf (d.Item(3) = "15") Then
                            P08.BackColor = Color.Red
                        ElseIf (d.Item(3) = "16") Then
                            P09.BackColor = Color.Red
                        ElseIf (d.Item(3) = "17") Then
                            P10.BackColor = Color.Red
                        End If
                    End If
                ElseIf (Date.Compare(dat, dtable2) = 0) Then
                    If (d.Item(5) = "Ongoing") Then
                        If (d.Item(3) = "8") Then
                            P11.BackColor = Color.Red
                        ElseIf (d.Item(3) = "9") Then
                            P12.BackColor = Color.Red
                        ElseIf (d.Item(3) = "10") Then
                            P13.BackColor = Color.Red
                        ElseIf (d.Item(3) = "11") Then
                            P14.BackColor = Color.Red
                        ElseIf (d.Item(3) = "12") Then
                            P15.BackColor = Color.Red
                        ElseIf (d.Item(3) = "13") Then
                            P16.BackColor = Color.Red
                        ElseIf (d.Item(3) = "14") Then
                            P17.BackColor = Color.Red
                        ElseIf (d.Item(3) = "15") Then
                            P18.BackColor = Color.Red
                        ElseIf (d.Item(3) = "16") Then
                            P19.BackColor = Color.Red
                        ElseIf (d.Item(3) = "17") Then
                            P20.BackColor = Color.Red
                        End If
                    End If
                ElseIf (Date.Compare(dat, dtable3) = 0) Then
                    If (d.Item(5) = "Ongoing") Then
                        If (d.Item(3) = "8") Then
                            P21.BackColor = Color.Red
                        ElseIf (d.Item(3) = "9") Then
                            P22.BackColor = Color.Red
                        ElseIf (d.Item(3) = "10") Then
                            P23.BackColor = Color.Red
                        ElseIf (d.Item(3) = "11") Then
                            P24.BackColor = Color.Red
                        ElseIf (d.Item(3) = "12") Then
                            P25.BackColor = Color.Red
                        ElseIf (d.Item(3) = "13") Then
                            P26.BackColor = Color.Red
                        ElseIf (d.Item(3) = "14") Then
                            P27.BackColor = Color.Red
                        ElseIf (d.Item(3) = "15") Then
                            P28.BackColor = Color.Red
                        ElseIf (d.Item(3) = "16") Then
                            P29.BackColor = Color.Red
                        ElseIf (d.Item(3) = "17") Then
                            P30.BackColor = Color.Red
                        End If
                    End If
                ElseIf (Date.Compare(dat, dtable4) = 0) Then
                    If (d.Item(5) = "Ongoing") Then
                        If (d.Item(3) = "8") Then
                            P31.BackColor = Color.Red
                        ElseIf (d.Item(3) = "9") Then
                            P32.BackColor = Color.Red
                        ElseIf (d.Item(3) = "10") Then
                            P33.BackColor = Color.Red
                        ElseIf (d.Item(3) = "11") Then
                            P34.BackColor = Color.Red
                        ElseIf (d.Item(3) = "12") Then
                            P35.BackColor = Color.Red
                        ElseIf (d.Item(3) = "13") Then
                            P36.BackColor = Color.Red
                        ElseIf (d.Item(3) = "14") Then
                            P37.BackColor = Color.Red
                        ElseIf (d.Item(3) = "15") Then
                            P38.BackColor = Color.Red
                        ElseIf (d.Item(3) = "16") Then
                            P39.BackColor = Color.Red
                        ElseIf (d.Item(3) = "17") Then
                            P40.BackColor = Color.Red
                        End If
                    End If
                ElseIf (Date.Compare(dat, dtable5) = 0) Then
                    If (d.Item(5) = "Ongoing") Then
                        If (d.Item(3) = "8") Then
                            P41.BackColor = Color.Red
                        ElseIf (d.Item(3) = "9") Then
                            P42.BackColor = Color.Red
                        ElseIf (d.Item(3) = "10") Then
                            P43.BackColor = Color.Red
                        ElseIf (d.Item(3) = "11") Then
                            P44.BackColor = Color.Red
                        ElseIf (d.Item(3) = "12") Then
                            P45.BackColor = Color.Red
                        ElseIf (d.Item(3) = "13") Then
                            P46.BackColor = Color.Red
                        ElseIf (d.Item(3) = "14") Then
                            P47.BackColor = Color.Red
                        ElseIf (d.Item(3) = "15") Then
                            P48.BackColor = Color.Red
                        ElseIf (d.Item(3) = "16") Then
                            P49.BackColor = Color.Red
                        ElseIf (d.Item(3) = "17") Then
                            P50.BackColor = Color.Red
                        End If
                    End If
                End If
            End If
            rcounter += 1
        End While
        con.Close()
    End Sub
    Sub loadApp()
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=abc.accdb;")
        Dim sql As String = "SELECT * FROM Consultation" &
                            " WHERE Consultation.Status='Ongoing' AND Consultation.ConsultationID IN (SELECT Appointment.ConsultationID FROM Appointment" &
                            " WHERE Appointment.ConsultationID = Consultation.ConsultationID AND Appointment.Status = 'Ongoing')"
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter(sql, con)
        da.Fill(ds, "appm")
        Dim Maxrows As Integer = ds.Tables("appm").Rows.Count
        Dim rcounter As Integer = 0
        Dim d As DataRow
        Dim dat As Date
        Dim dtable1, dtable2, dtable3, dtable4, dtable5 As Date
        While Not rcounter = Maxrows
            d = ds.Tables("appm").Rows(rcounter)
            If Equals(d.Item(1), Login.uname) Then
                dat = d.Item(2)
                dat.ToShortDateString()
                dtable1 = Date1.Text
                dtable2 = Date2.Text
                dtable3 = Date3.Text
                dtable4 = Date4.Text
                dtable5 = Date5.Text
                If (Date.Compare(dat, dtable1) = 0) Then
                    If (d.Item(5) = "Ongoing") Then
                        If (d.Item(3) = "8") Then
                            P01.BackColor = Color.Red
                        ElseIf (d.Item(3) = "9") Then
                            P02.BackColor = Color.Red
                        ElseIf (d.Item(3) = "10") Then
                            P03.BackColor = Color.Red
                        ElseIf (d.Item(3) = "11") Then
                            P04.BackColor = Color.Red
                        ElseIf (d.Item(3) = "12") Then
                            P05.BackColor = Color.Red
                        ElseIf (d.Item(3) = "13") Then
                            P06.BackColor = Color.Red
                        ElseIf (d.Item(3) = "14") Then
                            P07.BackColor = Color.Red
                        ElseIf (d.Item(3) = "15") Then
                            P08.BackColor = Color.Red
                        ElseIf (d.Item(3) = "16") Then
                            P09.BackColor = Color.Red
                        ElseIf (d.Item(3) = "17") Then
                            P10.BackColor = Color.Red
                        End If
                    End If
                ElseIf (Date.Compare(dat, dtable2) = 0) Then
                    If (d.Item(5) = "Ongoing") Then
                        If (d.Item(3) = "8") Then
                            P11.BackColor = Color.Red
                        ElseIf (d.Item(3) = "9") Then
                            P12.BackColor = Color.Red
                        ElseIf (d.Item(3) = "10") Then
                            P13.BackColor = Color.Red
                        ElseIf (d.Item(3) = "11") Then
                            P14.BackColor = Color.Red
                        ElseIf (d.Item(3) = "12") Then
                            P15.BackColor = Color.Red
                        ElseIf (d.Item(3) = "13") Then
                            P16.BackColor = Color.Red
                        ElseIf (d.Item(3) = "14") Then
                            P17.BackColor = Color.Red
                        ElseIf (d.Item(3) = "15") Then
                            P18.BackColor = Color.Red
                        ElseIf (d.Item(3) = "16") Then
                            P19.BackColor = Color.Red
                        ElseIf (d.Item(3) = "17") Then
                            P20.BackColor = Color.Red
                        End If
                    End If
                ElseIf (Date.Compare(dat, dtable3) = 0) Then
                    If (d.Item(5) = "Ongoing") Then
                        If (d.Item(3) = "8") Then
                            P21.BackColor = Color.Red
                        ElseIf (d.Item(3) = "9") Then
                            P22.BackColor = Color.Red
                        ElseIf (d.Item(3) = "10") Then
                            P23.BackColor = Color.Red
                        ElseIf (d.Item(3) = "11") Then
                            P24.BackColor = Color.Red
                        ElseIf (d.Item(3) = "12") Then
                            P25.BackColor = Color.Red
                        ElseIf (d.Item(3) = "13") Then
                            P26.BackColor = Color.Red
                        ElseIf (d.Item(3) = "14") Then
                            P27.BackColor = Color.Red
                        ElseIf (d.Item(3) = "15") Then
                            P28.BackColor = Color.Red
                        ElseIf (d.Item(3) = "16") Then
                            P29.BackColor = Color.Red
                        ElseIf (d.Item(3) = "17") Then
                            P30.BackColor = Color.Red
                        End If
                    End If
                ElseIf (Date.Compare(dat, dtable4) = 0) Then
                    If (d.Item(5) = "Ongoing") Then
                        If (d.Item(3) = "8") Then
                            P31.BackColor = Color.Red
                        ElseIf (d.Item(3) = "9") Then
                            P32.BackColor = Color.Red
                        ElseIf (d.Item(3) = "10") Then
                            P33.BackColor = Color.Red
                        ElseIf (d.Item(3) = "11") Then
                            P34.BackColor = Color.Red
                        ElseIf (d.Item(3) = "12") Then
                            P35.BackColor = Color.Red
                        ElseIf (d.Item(3) = "13") Then
                            P36.BackColor = Color.Red
                        ElseIf (d.Item(3) = "14") Then
                            P37.BackColor = Color.Red
                        ElseIf (d.Item(3) = "15") Then
                            P38.BackColor = Color.Red
                        ElseIf (d.Item(3) = "16") Then
                            P39.BackColor = Color.Red
                        ElseIf (d.Item(3) = "17") Then
                            P40.BackColor = Color.Red
                        End If
                    End If
                ElseIf (Date.Compare(dat, dtable5) = 0) Then
                    If (d.Item(5) = "Ongoing") Then
                        If (d.Item(3) = "8") Then
                            P41.BackColor = Color.Red
                        ElseIf (d.Item(3) = "9") Then
                            P42.BackColor = Color.Red
                        ElseIf (d.Item(3) = "10") Then
                            P43.BackColor = Color.Red
                        ElseIf (d.Item(3) = "11") Then
                            P44.BackColor = Color.Red
                        ElseIf (d.Item(3) = "12") Then
                            P45.BackColor = Color.Red
                        ElseIf (d.Item(3) = "13") Then
                            P46.BackColor = Color.Red
                        ElseIf (d.Item(3) = "14") Then
                            P47.BackColor = Color.Red
                        ElseIf (d.Item(3) = "15") Then
                            P48.BackColor = Color.Red
                        ElseIf (d.Item(3) = "16") Then
                            P49.BackColor = Color.Red
                        ElseIf (d.Item(3) = "17") Then
                            P50.BackColor = Color.Red
                        End If
                    End If
                End If
            End If
            rcounter += 1
        End While
        con.Close()
    End Sub
    Sub loadConSchedule()
        Dim i As Integer = 1
        While i <= 9
            Dim P = Controls.Find("P0" & i, True)
            P(0).BackColor = Color.MistyRose
            i += 1
        End While
        While i <= 50
            Dim P1 = Controls.Find("P" & i, True)
            P1(0).BackColor = Color.MistyRose
            i += 1
        End While
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=abc.accdb;")
        Dim sql As String = "SELECT * FROM Consultation"
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter(sql, con)
        da.Fill(ds, "lecture")
        Dim Maxrows As Integer = ds.Tables("lecture").Rows.Count
        Dim rcounter As Integer = 0
        Dim d As DataRow
        Dim dat As Date
        Dim dtable1, dtable2, dtable3, dtable4, dtable5 As Date
        While Not rcounter = Maxrows
            d = ds.Tables("lecture").Rows(rcounter)
            If Equals(d.Item(1), Login.uname) Or Equals(d.Item(1), PreViewConsultation.lectureid) Then ' need to add one more condition || Equals(d.Item(1), PreviewCon.variable) for student
                dat = d.Item(2)
                dat.ToShortDateString()
                dtable1 = Date1.Text
                dtable2 = Date2.Text
                dtable3 = Date3.Text
                dtable4 = Date4.Text
                dtable5 = Date5.Text
                If (Date.Compare(dat, dtable1) = 0) Then
                    If (d.Item(5) = "Ongoing") Then
                        If (d.Item(3) = "8") Then
                            P01.BackColor = Color.Green
                        ElseIf (d.Item(3) = "9") Then
                            P02.BackColor = Color.Green
                        ElseIf (d.Item(3) = "10") Then
                            P03.BackColor = Color.Green
                        ElseIf (d.Item(3) = "11") Then
                            P04.BackColor = Color.Green
                        ElseIf (d.Item(3) = "12") Then
                            P05.BackColor = Color.Green
                        ElseIf (d.Item(3) = "13") Then
                            P06.BackColor = Color.Green
                        ElseIf (d.Item(3) = "14") Then
                            P07.BackColor = Color.Green
                        ElseIf (d.Item(3) = "15") Then
                            P08.BackColor = Color.Green
                        ElseIf (d.Item(3) = "16") Then
                            P09.BackColor = Color.Green
                        ElseIf (d.Item(3) = "17") Then
                            P10.BackColor = Color.Green
                        End If
                    End If
                ElseIf (Date.Compare(dat, dtable2) = 0) Then
                    If (d.Item(5) = "Ongoing") Then
                        If (d.Item(3) = "8") Then
                            P11.BackColor = Color.Green
                        ElseIf (d.Item(3) = "9") Then
                            P12.BackColor = Color.Green
                        ElseIf (d.Item(3) = "10") Then
                            P13.BackColor = Color.Green
                        ElseIf (d.Item(3) = "11") Then
                            P14.BackColor = Color.Green
                        ElseIf (d.Item(3) = "12") Then
                            P15.BackColor = Color.Green
                        ElseIf (d.Item(3) = "13") Then
                            P16.BackColor = Color.Green
                        ElseIf (d.Item(3) = "14") Then
                            P17.BackColor = Color.Green
                        ElseIf (d.Item(3) = "15") Then
                            P18.BackColor = Color.Green
                        ElseIf (d.Item(3) = "16") Then
                            P19.BackColor = Color.Green
                        ElseIf (d.Item(3) = "17") Then
                            P20.BackColor = Color.Green
                        End If
                    End If
                ElseIf (Date.Compare(dat, dtable3) = 0) Then
                    If (d.Item(5) = "Ongoing") Then
                        If (d.Item(3) = "8") Then
                            P21.BackColor = Color.Green
                        ElseIf (d.Item(3) = "9") Then
                            P22.BackColor = Color.Green
                        ElseIf (d.Item(3) = "10") Then
                            P23.BackColor = Color.Green
                        ElseIf (d.Item(3) = "11") Then
                            P24.BackColor = Color.Green
                        ElseIf (d.Item(3) = "12") Then
                            P25.BackColor = Color.Green
                        ElseIf (d.Item(3) = "13") Then
                            P26.BackColor = Color.Green
                        ElseIf (d.Item(3) = "14") Then
                            P27.BackColor = Color.Green
                        ElseIf (d.Item(3) = "15") Then
                            P28.BackColor = Color.Green
                        ElseIf (d.Item(3) = "16") Then
                            P29.BackColor = Color.Green
                        ElseIf (d.Item(3) = "17") Then
                            P30.BackColor = Color.Green
                        End If
                    End If
                ElseIf (Date.Compare(dat, dtable4) = 0) Then
                    If (d.Item(5) = "Ongoing") Then
                        If (d.Item(3) = "8") Then
                            P31.BackColor = Color.Green
                        ElseIf (d.Item(3) = "9") Then
                            P32.BackColor = Color.Green
                        ElseIf (d.Item(3) = "10") Then
                            P33.BackColor = Color.Green
                        ElseIf (d.Item(3) = "11") Then
                            P34.BackColor = Color.Green
                        ElseIf (d.Item(3) = "12") Then
                            P35.BackColor = Color.Green
                        ElseIf (d.Item(3) = "13") Then
                            P36.BackColor = Color.Green
                        ElseIf (d.Item(3) = "14") Then
                            P37.BackColor = Color.Green
                        ElseIf (d.Item(3) = "15") Then
                            P38.BackColor = Color.Green
                        ElseIf (d.Item(3) = "16") Then
                            P39.BackColor = Color.Green
                        ElseIf (d.Item(3) = "17") Then
                            P40.BackColor = Color.Green
                        End If
                    End If
                ElseIf (Date.Compare(dat, dtable5) = 0) Then
                    If (d.Item(5) = "Ongoing") Then
                        If (d.Item(3) = "8") Then
                            P41.BackColor = Color.Green
                        ElseIf (d.Item(3) = "9") Then
                            P42.BackColor = Color.Green
                        ElseIf (d.Item(3) = "10") Then
                            P43.BackColor = Color.Green
                        ElseIf (d.Item(3) = "11") Then
                            P44.BackColor = Color.Green
                        ElseIf (d.Item(3) = "12") Then
                            P45.BackColor = Color.Green
                        ElseIf (d.Item(3) = "13") Then
                            P46.BackColor = Color.Green
                        ElseIf (d.Item(3) = "14") Then
                            P47.BackColor = Color.Green
                        ElseIf (d.Item(3) = "15") Then
                            P48.BackColor = Color.Green
                        ElseIf (d.Item(3) = "16") Then
                            P49.BackColor = Color.Green
                        ElseIf (d.Item(3) = "17") Then
                            P50.BackColor = Color.Green
                        End If
                    End If
                End If
            End If
            rcounter += 1
        End While
        con.Close()
    End Sub

    Private Sub ConPnl_ClickHandler(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P01.Click, P02.Click, P03.Click, P04.Click, P05.Click, P06.Click, P07.Click, P08.Click, P09.Click, P10.Click, P11.Click, P12.Click, P13.Click, P14.Click, P15.Click, P16.Click, P17.Click, P18.Click, P19.Click, P20.Click, P21.Click, P22.Click, P23.Click, P24.Click, P25.Click, P26.Click, P27.Click, P28.Click, P29.Click, P30.Click, P31.Click, P32.Click, P33.Click, P34.Click, P35.Click, P36.Click, P37.Click, P38.Click, P39.Click, P40.Click, P41.Click, P42.Click, P43.Click, P44.Click, P45.Click, P46.Click, P47.Click, P48.Click, P49.Click, P50.Click
        lblsid.Text = ""
        lblpurp.Text = ""
        Label4.Visible = True
        Dim i As Integer = 1
        clickedpanel = CType(sender, Panel)
        Dim panelname As String = clickedpanel.Name
        Dim panelarray() = panelname.ToCharArray()
        If (panelarray(1).Equals("0"c)) Then
            global_date = Date1.Text
        ElseIf (panelarray(1).Equals("1"c)) Then
            global_date = Date2.Text
            If (panelarray(2).Equals("0"c)) Then
                global_date = Date1.Text
                global_time = 17.0
            End If
        ElseIf (panelarray(1).Equals("2"c)) Then
            global_date = Date3.Text
            If (panelarray(2).Equals("0"c)) Then
                global_date = Date2.Text
                global_time = 17.0
            End If
        ElseIf (panelarray(1).Equals("3"c)) Then
            global_date = Date4.Text
            If (panelarray(2).Equals("0"c)) Then
                global_date = Date3.Text
                global_time = 17.0
            End If
        ElseIf (panelarray(1).Equals("4"c)) Then
            global_date = Date5.Text
            If (panelarray(2).Equals("0"c)) Then
                global_date = Date4.Text
                global_time = 17.0
            End If
        ElseIf (panelarray(1).Equals("5"c)) Then
            global_date = Date5.Text
            global_time = 17.0
        End If
        If (panelarray(2).Equals("1"c)) Then
            global_time = 8.0
        ElseIf (panelarray(2).Equals("2"c)) Then
            global_time = 9.0
        ElseIf (panelarray(2).Equals("3"c)) Then
            global_time = 10.0
        ElseIf (panelarray(2).Equals("4"c)) Then
            global_time = 11.0
        ElseIf (panelarray(2).Equals("5"c)) Then
            global_time = 12.0
        ElseIf (panelarray(2).Equals("6"c)) Then
            global_time = 13.0
        ElseIf (panelarray(2).Equals("7"c)) Then
            global_time = 14.0
        ElseIf (panelarray(2).Equals("8"c)) Then
            global_time = 15.0
        ElseIf (panelarray(2).Equals("9"c)) Then
            global_time = 16.0
        End If
        lbldate.Text = global_date
        lbltime.Text = global_time

        If Panel2.Enabled = False Then
            If clickedpanel.BackColor = Color.DarkGreen Or clickedpanel.BackColor = Color.DarkRed Then
                MessageBox.Show("Please select another consultation as there is already a consultation/appointment in this slot.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim con As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=abc.accdb;")
                Dim sql As String = "SELECT Timetable.Tdate, Timetable.ModuleID
                                FROM (Intake_Module 
                                INNER JOIN Timetable ON Timetable.ModuleID = Intake_Module.ModuleID)
                                WHERE Intake_Module.LectureID ='" & Login.uname & "';"
                Dim ds As New DataSet
                Dim da As New OleDbDataAdapter(sql, con)
                da.Fill(ds, "Timetable")
                Dim Maxrows As Integer = ds.Tables("Timetable").Rows.Count
                If Maxrows = 0 Then ' no clash
                    Dim a As MsgBoxResult = MessageBox.Show("Are you sure to move the consultation to this slot?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If a = MsgBoxResult.Yes Then
                        Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=abc.accdb;")
                        Dim updatesql As String = "UPDATE Consultation SET ConsultationDate=@CD, Stime=@ST WHERE ConsultationDate=@ConD AND Stime=STM"
                        conn.Open()
                        cmd = New OleDbCommand(updatesql, conn)
                        cmd.Parameters.AddWithValue("@CD", lbldate.Text)
                        cmd.Parameters.AddWithValue("@ST", lbltime.Text)
                        cmd.Parameters.AddWithValue("@ConD", tempd)
                        cmd.Parameters.AddWithValue("@STM", tempt)
                        cmd.ExecuteNonQuery()
                        conn.Close()
                        Dim mes As MsgBoxResult = MessageBox.Show("Consultation successfully moved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        If mes = MsgBoxResult.Ok Then
                            loadConSchedule()
                            loadApp()
                            panelappm.Enabled = True
                            Panel2.Enabled = True
                            Panel3.Enabled = True
                            Panel4.Enabled = True
                        End If
                    End If
                Else
                    Dim ttcounter As Integer = 0
                    Dim d As DataRow
                    Dim contempdate As String
                    Dim tt_time As Date
                    Dim count As Integer = 0
                    While Not ttcounter = Maxrows
                        d = ds.Tables("Timetable").Rows(ttcounter)
                        'For i = 0 To (dv_arr.Count - 1) 'loop con date validation w/ timetable
                        If count = 1 Then
                            Exit While
                        End If
                        contempdate = Date.Parse(d.Item(0)).ToShortDateString

                        If contempdate.Equals(global_date) Then 'same date
                            tt_time = Date.Parse(d.Item(0))
                            If ((tt_time.Hour.ToString).Equals(global_time.ToString)) Then 'clash time
                                ''''''''''output message to give warning
                                MessageBox.Show("Unable to set consultation." & vbNewLine & "There is a " & d.Item(1) & " class going on simultaneously on " & d.Item(0) & ".", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                                count = 1
                            ElseIf tt_time.Hour > Convert.ToInt32(global_time.ToString) Or tt_time.Hour < Convert.ToInt32(global_time.ToString) Then 'tt hour later or earlier than dur_arr by 1 hour
                                count = 0
                            End If
                        End If
                        'Next
                        ttcounter += 1
                    End While
                    If count = 0 Then
                        Dim a As MsgBoxResult = MessageBox.Show("Are you sure to move the consultation to this slot?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If a = MsgBoxResult.Yes Then
                            Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=abc.accdb;")
                            Dim updatesql As String = "UPDATE Consultation SET ConsultationDate=@CD, Stime=@ST WHERE ConsultationDate=@ConD AND Stime=STM"
                            conn.Open()
                            cmd = New OleDbCommand(updatesql, conn)
                            cmd.Parameters.AddWithValue("@CD", lbldate.Text)
                            cmd.Parameters.AddWithValue("@ST", lbltime.Text)
                            cmd.Parameters.AddWithValue("@ConD", tempd)
                            cmd.Parameters.AddWithValue("@STM", tempt)
                            cmd.ExecuteNonQuery()
                            conn.Close()
                            Dim mes As MsgBoxResult = MessageBox.Show("Consultation successfully moved.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            If mes = MsgBoxResult.Ok Then
                                loadConSchedule()
                                loadApp()
                                panelappm.Enabled = True
                                Panel2.Enabled = True
                                Panel3.Enabled = True
                                Panel4.Enabled = True
                                btnAddCon.Enabled = False
                                btnmo.Enabled = False
                                btnMod.Enabled = False
                                panelappm.Visible = False
                            End If
                        End If
                    End If
                    ' MessageBox.Show("Please select another consultation slot as your class is conducting at this time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        Else
            If clickedpanel.BackColor = Color.RosyBrown Then 'if no consultation slot
                btnAddCon.Enabled = True
                btnmo.Enabled = False
                btnMod.Enabled = False
                btnBook.Enabled = False
                btnCanApp.Enabled = False
            ElseIf clickedpanel.BackColor = Color.DarkRed Then
                btnCanApp.Enabled = True
                btnAddCon.Enabled = False
                btnMod.Enabled = True
                btnmo.Enabled = False
                btnBook.Enabled = False
            Else
                btnCanApp.Enabled = False
                btnAddCon.Enabled = False
                btnMod.Enabled = True
                btnmo.Enabled = True
                btnBook.Enabled = True
            End If
        End If

        If btnAddCon.Visible = False Then 'student view
            If clickedpanel.BackColor = Color.DarkRed Then 'got appointment need to show appointment derails
                panelappm.Visible = True
                Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=abc.accdb;")
                Dim sql As String = "SELECT Appointment.Purpose, Appointment.StudentID, Student.StudentName FROM (Appointment INNER JOIN Student ON Appointment.StudentID = Student.StudentID)" &
                                    " WHERE Appointment.ConsultationID IN (SELECT Consultation.ConsultationID FROM Consultation" &
                                    " WHERE Consultation.ConsultationID = Appointment.ConsultationID AND Consultation.ConsultationDate = '" & global_date & "' AND Consultation.Stime = '" & global_time & "')"
                Dim ds As New DataSet
                Dim da As New OleDbDataAdapter(sql, con)
                da.Fill(ds, "appointment")
                Dim d As DataRow
                d = ds.Tables("appointment").Rows(0)
                lblsid.Text = d.Item(1)
                lblpurp.Text = d.Item(0)
                lblname.Text = d.Item(2)
                If Not Equals(d.Item(1), Login.uname) Then
                    btnCanApp.Enabled = False
                End If
                con.Close()
            Else
                panelappm.Visible = False
            End If
        Else 'lecture view
            If clickedpanel.BackColor = Color.DarkRed Then 'got appointment need to show appointment derails
                panelappm.Visible = True
                Dim conn As OleDbConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=abc.accdb;")
                Dim sql As String = "SELECT Appointment.Purpose, Appointment.StudentID, Student.StudentName FROM (Appointment INNER JOIN Student ON Appointment.StudentID = Student.StudentID)" &
                                    " WHERE Appointment.ConsultationID IN (SELECT Consultation.ConsultationID FROM Consultation" &
                                    " WHERE Consultation.ConsultationID = Appointment.ConsultationID AND Consultation.ConsultationDate = '" & global_date & "' AND Consultation.Stime = '" & global_time & "')"
                Dim ds As New DataSet
                Dim da As New OleDbDataAdapter(sql, con)
                da.Fill(ds, "appointment")
                Dim d As DataRow
                d = ds.Tables("appointment").Rows(0)
                lblsid.Text = d.Item(1)
                lblpurp.Text = d.Item(0)
                lblname.Text = d.Item(2)
                con.Close()
            Else
                panelappm.Visible = False
            End If
        End If
    End Sub

    Private Sub btnmo_Click(sender As Object, e As EventArgs) Handles btnmo.Click
        MessageBox.Show("Please click on a new time slot to move the consultation.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        tempd = lbldate.Text
        tempt = lbltime.Text
        panelappm.Enabled = False
        Panel2.Enabled = False
        Panel3.Enabled = False
        Panel4.Enabled = False
    End Sub

    Private Sub ConPnl_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P01.MouseEnter, P02.MouseEnter, P03.MouseEnter, P04.MouseEnter, P05.MouseEnter, P06.MouseEnter, P07.MouseEnter, P08.MouseEnter, P09.MouseEnter, P10.MouseEnter, P11.MouseEnter, P12.MouseEnter, P13.MouseEnter, P14.MouseEnter, P15.MouseEnter, P16.MouseEnter, P17.MouseEnter, P18.MouseEnter, P19.MouseEnter, P20.MouseEnter, P21.MouseEnter, P22.MouseEnter, P23.MouseEnter, P24.MouseEnter, P25.MouseEnter, P26.MouseEnter, P27.MouseEnter, P28.MouseEnter, P29.MouseEnter, P30.MouseEnter, P31.MouseEnter, P32.MouseEnter, P33.MouseEnter, P34.MouseEnter, P35.MouseEnter, P36.MouseEnter, P37.MouseEnter, P38.MouseEnter, P39.MouseEnter, P40.MouseEnter, P41.MouseEnter, P42.MouseEnter, P43.MouseEnter, P44.MouseEnter, P45.MouseEnter, P46.MouseEnter, P47.MouseEnter, P48.MouseEnter, P49.MouseEnter, P50.MouseEnter
        Dim movedpanel As Panel = CType(sender, Panel)
        If movedpanel.BackColor = Color.MistyRose Then
            movedpanel.BackColor = Color.RosyBrown
        ElseIf movedpanel.BackColor = Color.Green Then
            movedpanel.BackColor = Color.DarkGreen
        ElseIf movedpanel.BackColor = Color.Red Then
            movedpanel.BackColor = Color.DarkRed
        End If

    End Sub
    Private Sub ConPnl_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles P01.MouseLeave, P02.MouseLeave, P03.MouseLeave, P04.MouseLeave, P05.MouseLeave, P06.MouseLeave, P07.MouseLeave, P08.MouseLeave, P09.MouseLeave, P10.MouseLeave, P11.MouseLeave, P12.MouseLeave, P13.MouseLeave, P14.MouseLeave, P15.MouseLeave, P16.MouseLeave, P17.MouseLeave, P18.MouseLeave, P19.MouseLeave, P20.MouseLeave, P21.MouseLeave, P22.MouseLeave, P23.MouseLeave, P24.MouseLeave, P25.MouseLeave, P26.MouseLeave, P27.MouseLeave, P28.MouseLeave, P29.MouseLeave, P30.MouseLeave, P31.MouseLeave, P32.MouseLeave, P33.MouseLeave, P34.MouseLeave, P35.MouseLeave, P36.MouseLeave, P37.MouseLeave, P38.MouseLeave, P39.MouseLeave, P40.MouseLeave, P41.MouseLeave, P42.MouseLeave, P43.MouseLeave, P44.MouseLeave, P45.MouseLeave, P46.MouseLeave, P47.MouseLeave, P48.MouseLeave, P49.MouseLeave, P50.MouseLeave
        Dim movedpanel As Panel = CType(sender, Panel)
        If movedpanel.BackColor = Color.RosyBrown Then
            movedpanel.BackColor = Color.MistyRose
        ElseIf movedpanel.BackColor = Color.DarkGreen Then
            movedpanel.BackColor = Color.Green
        ElseIf movedpanel.BackColor = Color.DarkRed Then
            movedpanel.BackColor = Color.Red
        End If

    End Sub

    Private Sub btnCanApp_Click(sender As Object, e As EventArgs) Handles btnCanApp.Click
        Dim mess As MsgBoxResult = MessageBox.Show("Are you sure you want to cancel this appointment?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk)
        If mess = MsgBoxResult.Yes Then
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=abc.accdb;")
            Dim sql As String = " UPDATE Appointment SET Status=@Status, Cancelledby=@Cancelledby, LectNoti=@LectNoti WHERE Appointment.ConsultationID IN (SELECT Consultation.ConsultationID FROM Consultation " &
                                " WHERE Consultation.ConsultationID = Appointment.ConsultationID AND Consultation.ConsultationDate = '" & global_date & "' AND Consultation.Stime = '" & global_time & "')"
            con.Open()
            cmd = New OleDbCommand(sql, con)
            cmd.Parameters.AddWithValue("@Status", "Cancelled")
            cmd.Parameters.AddWithValue("@Cancelledby", Login.uname)
            cmd.Parameters.AddWithValue("@LectNoti", "Unread")
            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i >= 1) Then
                MessageBox.Show("Appointment successfully cancelled." & vbNewLine & "A notification has been sent to the lecturer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Sorry the appointment are not cancelled. Please try again later", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
            con.Close()
        End If
        loadConSchedule()
        loadSApp()
        btnCanApp.Enabled = False
    End Sub

    Private Sub btnPrintRe_Click(sender As Object, e As EventArgs) Handles btnPrintRe.Click
        If (btnBook.Visible = False) Then 'lecture view
            LAppReportForm.Show()
        Else 'student view
            SAppReportForm.Show()
        End If
    End Sub
End Class