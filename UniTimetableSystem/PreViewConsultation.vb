Imports System.Data.OleDb
Public Class PreViewConsultation
    Public Shared monday_date As String
    Public Shared lectureid As String
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        txtDate.Text = DateTimePicker1.Value.ToShortDateString
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'pass variable to viewconsultation
        'ConsultationMenu.Show()
        'ConsultationMenu.monday_date = txtDate.Text
        If Weekday(DateTimePicker1.Value) <> vbMonday Then
            MessageBox.Show("Selected date must be start of the week." & vbNewLine & "Please select a Monday.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If cmblectid.Visible = False Then 'lecture
                monday_date = txtDate.Text
                btnMove.btnBook.Visible = False
                btnMove.btnCanApp.Visible = False
                btnMove.MdiParent = ConsultationMenu
                btnMove.WindowState = FormWindowState.Maximized
                btnMove.Show()
                btnMove.Loaddate()
                btnMove.loadConSchedule()
                btnMove.loadApp()
                btnMove.checkd()
                Me.Close()
            Else 'student view 
                lectureid = cmblectid.SelectedItem
                monday_date = txtDate.Text
                btnMove.btnAddCon.Visible = False
                btnMove.btnMod.Visible = False
                btnMove.btnmo.Visible = False
                btnMove.btnAddCon.Visible = False
                btnMove.MdiParent = StudentMenu
                btnMove.WindowState = FormWindowState.Maximized
                btnMove.Show()
                btnMove.Loaddate()
                btnMove.loadConSchedule()
                btnMove.loadSApp()
                btnMove.checkd()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub PreViewConsultation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim currentdate As Date = Date.Now
        Dim delta As Integer = DayOfWeek.Monday - currentdate.DayOfWeek
        DateTimePicker1.MinDate = currentdate.AddDays(delta)
        DateTimePicker1.MaxDate = Date.Now().AddMonths(3)

        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=abc.accdb;")
        Dim sql As String = "SELECT LectureID FROM Lecture"
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter(sql, con)
        da.Fill(ds, "lectid")
        Dim Maxrows As Integer = ds.Tables("lectid").Rows.Count
        Dim rcounter As Integer = 0
        Dim d As DataRow
        While Not rcounter = Maxrows
            d = ds.Tables("lectid").Rows(rcounter)
            cmblectid.Items.Add(d.Item(0))
            rcounter += 1
        End While
        con.Close()
    End Sub
End Class