Public Class autonumber
    Function timetableid()
        Dim idnumber As Integer
        Dim sql As String = "SELECT TimetableID FROM Timetable ORDER BY LEN(TimetableID) DESC, TimetableID DESC"
        Dim dr As OleDb.OleDbDataReader
        Dim cmd As New OleDb.OleDbCommand(sql, LTimetableAdd.conn)
        LTimetableAdd.conn.Open()
        dr = cmd.ExecuteReader
        If Not dr.HasRows Then
            idnumber = 0
        Else
            dr.Read()
            Dim tbid As String = dr.Item(0)
            If tbid.Length > 8 Then
                Do
                    tbid = dr.Item(0)
                    If Not tbid.Length > 8 Then
                        tbid = dr.Item(0)
                        Exit Do
                    End If
                    Dim testid = Integer.Parse(tbid.Substring(2))
                    If Not testid < 999999 Then
                        Exit Do
                    End If
                Loop While dr.Read()
            End If
            idnumber = Integer.Parse(tbid.Substring(2))
        End If
        LTimetableAdd.conn.Close()
        Return idnumber
    End Function
    Function getnextid(ByVal type As Integer)

        Dim idnumber As Integer = timetableid()
        idnumber += 1
        Dim addzero As Integer = 0
        Select Case (idnumber) 'get error after over 999999 - 6 digit value
            Case 0 To 9
                addzero = 5
            Case 10 To 99
                addzero = 4
            Case 100 To 999
                addzero = 3
            Case 1000 To 9999
                addzero = 2
            Case 10000 To 99999
                addzero = 1
            Case Else
                addzero = 0
        End Select

        Dim id As String
        Select Case (type)
            Case 1
                id = "TB" 'timetable
            Case Else
                Return False
        End Select
        For i As Integer = 1 To addzero
            id += "0"
        Next

        id += idnumber.ToString("0")

        '  id = id + idnumber.ToString("000000")
        Return id
    End Function
End Class

