Imports System.Data.OleDb
Public Class BookConsultation
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Private Sub txtPurpose_TextChanged(sender As Object, e As EventArgs) Handles txtPurpose.TextChanged
        btnCOn.Enabled = True
    End Sub

    Private Sub btnCan_Click(sender As Object, e As EventArgs) Handles btnCan.Click
        Me.Close()
    End Sub

    Private Sub btnCOn_Click(sender As Object, e As EventArgs) Handles btnCOn.Click
        If txtPurpose.Text = "" Then
            MessageBox.Show("Please make sure that the purpose is filled.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=abc.accdb;")
            Dim sql As String = "INSERT INTO Appointment (ConsultationID,StudentID,Purpose,Status) VALUES (@ConsultationID,@StudentID,@Purpose,@Status)"
            con.Open()
            cmd = New OleDbCommand(sql, con)
            cmd.Parameters.AddWithValue("@ConsultationID", btnMove.consultationid)
            cmd.Parameters.AddWithValue("@StudentID", Login.uname)
            cmd.Parameters.AddWithValue("@Purpose", txtPurpose.Text)
            cmd.Parameters.AddWithValue("@Status", "Ongoing")
            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i >= 1) Then
                MessageBox.Show("Appointment successfully booked.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            Else
                MessageBox.Show("Sorry the appointment are not made. Please try again later", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.Close()
            End If
            con.Close()
        End If
    End Sub

    Private Sub BookConsultation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtSID.Text = Login.uname
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=abc.accdb;")
        con.Open()
        Dim sql As String = "Select StudentName FROM Student WHERE StudentId = '" & txtSID.Text & "'"
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter(sql, con)
        da.Fill(ds, "students")
        Dim d As DataRow
        d = ds.Tables("students").Rows(0)
        txtSName.Text = d.Item(0)
        con.Close()
    End Sub
End Class