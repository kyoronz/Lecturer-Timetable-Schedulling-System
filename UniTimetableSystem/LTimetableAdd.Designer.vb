<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LTimetableAdd
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LTimetableAdd))
        Me.btnPublish = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnconf1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboxintakeid = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cboxmdl = New System.Windows.Forms.ComboBox()
        Me.lblselectedlec = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnconf2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.lblweek = New System.Windows.Forms.Label()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.cboxweek = New System.Windows.Forms.ComboBox()
        Me.lblduration = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboxhour = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboxampm = New System.Windows.Forms.ComboBox()
        Me.cboxminute = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnconf3 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cboxvtype = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cboxvenue = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnPublish
        '
        Me.btnPublish.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnPublish.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPublish.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnPublish.Location = New System.Drawing.Point(254, 629)
        Me.btnPublish.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnPublish.Name = "btnPublish"
        Me.btnPublish.Size = New System.Drawing.Size(124, 44)
        Me.btnPublish.TabIndex = 27
        Me.btnPublish.Text = "Publish"
        Me.btnPublish.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnClear.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(487, 629)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(112, 44)
        Me.btnClear.TabIndex = 29
        Me.btnClear.Text = "Reset"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DarkRed
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(270, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(348, 28)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Publish Lecturer Timetable"
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(114, 488)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(633, 2)
        Me.Label11.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label12.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(114, 619)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(633, 2)
        Me.Label12.TabIndex = 38
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(883, 47)
        Me.Panel1.TabIndex = 46
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightCoral
        Me.Panel2.Controls.Add(Me.btnconf1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cboxintakeid)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.cboxmdl)
        Me.Panel2.Controls.Add(Me.lblselectedlec)
        Me.Panel2.Location = New System.Drawing.Point(110, 68)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(634, 178)
        Me.Panel2.TabIndex = 47
        '
        'btnconf1
        '
        Me.btnconf1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnconf1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconf1.Location = New System.Drawing.Point(529, 133)
        Me.btnconf1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnconf1.Name = "btnconf1"
        Me.btnconf1.Size = New System.Drawing.Size(100, 37)
        Me.btnconf1.TabIndex = 50
        Me.btnconf1.Text = "Confirm"
        Me.btnconf1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 19)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Select Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(42, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 19)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Select Module"
        '
        'cboxintakeid
        '
        Me.cboxintakeid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxintakeid.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxintakeid.FormattingEnabled = True
        Me.cboxintakeid.Location = New System.Drawing.Point(220, 100)
        Me.cboxintakeid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxintakeid.Name = "cboxintakeid"
        Me.cboxintakeid.Size = New System.Drawing.Size(300, 27)
        Me.cboxintakeid.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(42, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 19)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Selected Lecturer"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(220, 14)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(300, 27)
        Me.DateTimePicker1.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(42, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(103, 19)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Select Intake"
        '
        'cboxmdl
        '
        Me.cboxmdl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxmdl.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxmdl.FormattingEnabled = True
        Me.cboxmdl.Location = New System.Drawing.Point(220, 57)
        Me.cboxmdl.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxmdl.Name = "cboxmdl"
        Me.cboxmdl.Size = New System.Drawing.Size(300, 27)
        Me.cboxmdl.TabIndex = 45
        '
        'lblselectedlec
        '
        Me.lblselectedlec.AutoSize = True
        Me.lblselectedlec.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblselectedlec.Location = New System.Drawing.Point(216, 142)
        Me.lblselectedlec.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblselectedlec.Name = "lblselectedlec"
        Me.lblselectedlec.Size = New System.Drawing.Size(15, 19)
        Me.lblselectedlec.TabIndex = 47
        Me.lblselectedlec.Text = "-"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightCoral
        Me.Panel3.Controls.Add(Me.btnconf2)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.lblduration)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.cboxhour)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.cboxampm)
        Me.Panel3.Controls.Add(Me.cboxminute)
        Me.Panel3.Location = New System.Drawing.Point(112, 269)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(632, 207)
        Me.Panel3.TabIndex = 48
        '
        'btnconf2
        '
        Me.btnconf2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnconf2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconf2.Location = New System.Drawing.Point(527, 166)
        Me.btnconf2.Margin = New System.Windows.Forms.Padding(4)
        Me.btnconf2.Name = "btnconf2"
        Me.btnconf2.Size = New System.Drawing.Size(100, 37)
        Me.btnconf2.TabIndex = 53
        Me.btnconf2.Text = "Confirm"
        Me.btnconf2.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.lblweek)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.cboxweek)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(32, 98)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(579, 60)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Time Option"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RadioButton1.Location = New System.Drawing.Point(31, 25)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(135, 23)
        Me.RadioButton1.TabIndex = 42
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Only this week"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'lblweek
        '
        Me.lblweek.AutoSize = True
        Me.lblweek.BackColor = System.Drawing.Color.Transparent
        Me.lblweek.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblweek.Location = New System.Drawing.Point(446, 27)
        Me.lblweek.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblweek.Name = "lblweek"
        Me.lblweek.Size = New System.Drawing.Size(96, 19)
        Me.lblweek.TabIndex = 44
        Me.lblweek.Text = "week/weeks"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RadioButton2.Location = New System.Drawing.Point(207, 25)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(4)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(140, 23)
        Me.RadioButton2.TabIndex = 42
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Repeat for next"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'cboxweek
        '
        Me.cboxweek.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxweek.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.cboxweek.FormattingEnabled = True
        Me.cboxweek.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cboxweek.Location = New System.Drawing.Point(365, 21)
        Me.cboxweek.Margin = New System.Windows.Forms.Padding(4)
        Me.cboxweek.Name = "cboxweek"
        Me.cboxweek.Size = New System.Drawing.Size(62, 27)
        Me.cboxweek.TabIndex = 43
        '
        'lblduration
        '
        Me.lblduration.AutoSize = True
        Me.lblduration.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblduration.Location = New System.Drawing.Point(212, 16)
        Me.lblduration.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblduration.Name = "lblduration"
        Me.lblduration.Size = New System.Drawing.Size(15, 19)
        Me.lblduration.TabIndex = 52
        Me.lblduration.Text = "-"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(28, 16)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 19)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Course Duration"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(132, 19)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Select Start Time"
        '
        'cboxhour
        '
        Me.cboxhour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxhour.Enabled = False
        Me.cboxhour.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxhour.FormattingEnabled = True
        Me.cboxhour.Location = New System.Drawing.Point(213, 52)
        Me.cboxhour.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxhour.Name = "cboxhour"
        Me.cboxhour.Size = New System.Drawing.Size(68, 27)
        Me.cboxhour.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(287, 56)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 19)
        Me.Label6.TabIndex = 50
        Me.Label6.Text = ":"
        '
        'cboxampm
        '
        Me.cboxampm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxampm.Enabled = False
        Me.cboxampm.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxampm.FormattingEnabled = True
        Me.cboxampm.Items.AddRange(New Object() {"AM", "PM"})
        Me.cboxampm.Location = New System.Drawing.Point(397, 52)
        Me.cboxampm.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxampm.Name = "cboxampm"
        Me.cboxampm.Size = New System.Drawing.Size(81, 27)
        Me.cboxampm.TabIndex = 48
        '
        'cboxminute
        '
        Me.cboxminute.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxminute.Enabled = False
        Me.cboxminute.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxminute.FormattingEnabled = True
        Me.cboxminute.Items.AddRange(New Object() {"00", "10", "20", "30", "40", "50"})
        Me.cboxminute.Location = New System.Drawing.Point(318, 52)
        Me.cboxminute.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxminute.Name = "cboxminute"
        Me.cboxminute.Size = New System.Drawing.Size(73, 27)
        Me.cboxminute.TabIndex = 49
        '
        'Label10
        '
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(110, 256)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(633, 2)
        Me.Label10.TabIndex = 36
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightCoral
        Me.Panel4.Controls.Add(Me.btnconf3)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.cboxvtype)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.cboxvenue)
        Me.Panel4.Location = New System.Drawing.Point(114, 503)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(629, 104)
        Me.Panel4.TabIndex = 49
        '
        'btnconf3
        '
        Me.btnconf3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnconf3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnconf3.Location = New System.Drawing.Point(525, 58)
        Me.btnconf3.Margin = New System.Windows.Forms.Padding(4)
        Me.btnconf3.Name = "btnconf3"
        Me.btnconf3.Size = New System.Drawing.Size(100, 42)
        Me.btnconf3.TabIndex = 46
        Me.btnconf3.Text = "Confirm"
        Me.btnconf3.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(30, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(145, 19)
        Me.Label8.TabIndex = 44
        Me.Label8.Text = "Select Venue Type"
        '
        'cboxvtype
        '
        Me.cboxvtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxvtype.Enabled = False
        Me.cboxvtype.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxvtype.FormattingEnabled = True
        Me.cboxvtype.Location = New System.Drawing.Point(216, 11)
        Me.cboxvtype.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxvtype.Name = "cboxvtype"
        Me.cboxvtype.Size = New System.Drawing.Size(205, 27)
        Me.cboxvtype.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(30, 70)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 19)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Select Venue"
        '
        'cboxvenue
        '
        Me.cboxvenue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxvenue.Enabled = False
        Me.cboxvenue.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxvenue.FormattingEnabled = True
        Me.cboxvenue.Location = New System.Drawing.Point(216, 67)
        Me.cboxvenue.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboxvenue.Name = "cboxvenue"
        Me.cboxvenue.Size = New System.Drawing.Size(205, 27)
        Me.cboxvenue.TabIndex = 43
        '
        'LTimetableAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(883, 686)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnPublish)
        Me.Controls.Add(Me.btnClear)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LTimetableAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LTimetableAdd"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnPublish As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnconf1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cboxintakeid As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents cboxmdl As ComboBox
    Friend WithEvents lblselectedlec As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents lblweek As Label
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents cboxweek As ComboBox
    Friend WithEvents btnconf2 As Button
    Friend WithEvents lblduration As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboxhour As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cboxampm As ComboBox
    Friend WithEvents cboxminute As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnconf3 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents cboxvtype As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents cboxvenue As ComboBox
End Class
