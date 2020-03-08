<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LTimetableView
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtvenue = New System.Windows.Forms.TextBox()
        Me.txtint = New System.Windows.Forms.TextBox()
        Me.txtmdlname = New System.Windows.Forms.TextBox()
        Me.txtmdlid = New System.Windows.Forms.TextBox()
        Me.txttbid = New System.Windows.Forms.TextBox()
        Me.txtdate = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbltbid = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboxlecture = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnback = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Firebrick
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtvenue)
        Me.Panel1.Controls.Add(Me.txtint)
        Me.Panel1.Controls.Add(Me.txtmdlname)
        Me.Panel1.Controls.Add(Me.txtmdlid)
        Me.Panel1.Controls.Add(Me.txttbid)
        Me.Panel1.Controls.Add(Me.txtdate)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.lbltbid)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.cboxlecture)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnadd)
        Me.Panel1.Controls.Add(Me.btnback)
        Me.Panel1.Controls.Add(Me.btndel)
        Me.Panel1.Controls.Add(Me.btnedit)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1053, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(463, 725)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(169, 561)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(129, 73)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Print Timetable"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtvenue
        '
        Me.txtvenue.BackColor = System.Drawing.Color.Firebrick
        Me.txtvenue.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtvenue.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvenue.ForeColor = System.Drawing.SystemColors.Control
        Me.txtvenue.Location = New System.Drawing.Point(197, 417)
        Me.txtvenue.Margin = New System.Windows.Forms.Padding(4)
        Me.txtvenue.Multiline = True
        Me.txtvenue.Name = "txtvenue"
        Me.txtvenue.ReadOnly = True
        Me.txtvenue.Size = New System.Drawing.Size(253, 22)
        Me.txtvenue.TabIndex = 7
        '
        'txtint
        '
        Me.txtint.BackColor = System.Drawing.Color.Firebrick
        Me.txtint.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtint.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtint.ForeColor = System.Drawing.SystemColors.Control
        Me.txtint.Location = New System.Drawing.Point(196, 373)
        Me.txtint.Margin = New System.Windows.Forms.Padding(4)
        Me.txtint.Multiline = True
        Me.txtint.Name = "txtint"
        Me.txtint.ReadOnly = True
        Me.txtint.Size = New System.Drawing.Size(253, 22)
        Me.txtint.TabIndex = 7
        '
        'txtmdlname
        '
        Me.txtmdlname.BackColor = System.Drawing.Color.Firebrick
        Me.txtmdlname.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmdlname.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmdlname.ForeColor = System.Drawing.SystemColors.Control
        Me.txtmdlname.Location = New System.Drawing.Point(196, 329)
        Me.txtmdlname.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmdlname.Multiline = True
        Me.txtmdlname.Name = "txtmdlname"
        Me.txtmdlname.ReadOnly = True
        Me.txtmdlname.Size = New System.Drawing.Size(253, 22)
        Me.txtmdlname.TabIndex = 7
        '
        'txtmdlid
        '
        Me.txtmdlid.BackColor = System.Drawing.Color.Firebrick
        Me.txtmdlid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtmdlid.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmdlid.ForeColor = System.Drawing.SystemColors.Control
        Me.txtmdlid.Location = New System.Drawing.Point(196, 284)
        Me.txtmdlid.Margin = New System.Windows.Forms.Padding(4)
        Me.txtmdlid.Multiline = True
        Me.txtmdlid.Name = "txtmdlid"
        Me.txtmdlid.ReadOnly = True
        Me.txtmdlid.Size = New System.Drawing.Size(253, 22)
        Me.txtmdlid.TabIndex = 7
        '
        'txttbid
        '
        Me.txttbid.BackColor = System.Drawing.Color.Firebrick
        Me.txttbid.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txttbid.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttbid.ForeColor = System.Drawing.SystemColors.Control
        Me.txttbid.Location = New System.Drawing.Point(196, 197)
        Me.txttbid.Margin = New System.Windows.Forms.Padding(4)
        Me.txttbid.Multiline = True
        Me.txttbid.Name = "txttbid"
        Me.txttbid.ReadOnly = True
        Me.txttbid.Size = New System.Drawing.Size(253, 25)
        Me.txttbid.TabIndex = 7
        '
        'txtdate
        '
        Me.txtdate.BackColor = System.Drawing.Color.Firebrick
        Me.txtdate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtdate.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdate.ForeColor = System.Drawing.SystemColors.Control
        Me.txtdate.Location = New System.Drawing.Point(196, 240)
        Me.txtdate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtdate.Multiline = True
        Me.txtdate.Name = "txtdate"
        Me.txtdate.ReadOnly = True
        Me.txtdate.Size = New System.Drawing.Size(253, 22)
        Me.txtdate.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(84, 417)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Venue :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(86, 374)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Intake :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(31, 329)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Module Name :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(34, 284)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 19)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Module Code :"
        '
        'lbltbid
        '
        Me.lbltbid.AutoSize = True
        Me.lbltbid.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltbid.ForeColor = System.Drawing.SystemColors.Control
        Me.lbltbid.Location = New System.Drawing.Point(40, 197)
        Me.lbltbid.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbltbid.Name = "lbltbid"
        Me.lbltbid.Size = New System.Drawing.Size(109, 19)
        Me.lbltbid.TabIndex = 5
        Me.lbltbid.Text = "Timetable ID :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(23, 240)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 19)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Timetable Date :"
        '
        'cboxlecture
        '
        Me.cboxlecture.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxlecture.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboxlecture.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cboxlecture.FormattingEnabled = True
        Me.cboxlecture.Location = New System.Drawing.Point(169, 117)
        Me.cboxlecture.Margin = New System.Windows.Forms.Padding(4)
        Me.cboxlecture.Name = "cboxlecture"
        Me.cboxlecture.Size = New System.Drawing.Size(252, 27)
        Me.cboxlecture.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(75, 120)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Lecture :"
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnadd.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(32, 480)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(131, 73)
        Me.btnadd.TabIndex = 2
        Me.btnadd.Text = "Add Timetable Details"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btnback
        '
        Me.btnback.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnback.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnback.Location = New System.Drawing.Point(309, 561)
        Me.btnback.Margin = New System.Windows.Forms.Padding(4)
        Me.btnback.Name = "btnback"
        Me.btnback.Size = New System.Drawing.Size(131, 73)
        Me.btnback.TabIndex = 2
        Me.btnback.Text = "Back"
        Me.btnback.UseVisualStyleBackColor = False
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btndel.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.Location = New System.Drawing.Point(309, 480)
        Me.btndel.Margin = New System.Windows.Forms.Padding(4)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(131, 73)
        Me.btndel.TabIndex = 2
        Me.btndel.Text = "Delete Timetable Details"
        Me.btndel.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnedit.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.Location = New System.Drawing.Point(170, 480)
        Me.btnedit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(131, 73)
        Me.btnedit.TabIndex = 2
        Me.btnedit.Text = "Edit Timetable Details"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(96, 68)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Date :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.ControlLight
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(169, 62)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(252, 27)
        Me.DateTimePicker1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.MistyRose
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(1053, 725)
        Me.DataGridView1.TabIndex = 1
        '
        'LTimetableView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1516, 725)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "LTimetableView"
        Me.Text = "LTimetableView"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents btnadd As Button
    Friend WithEvents btnback As Button
    Friend WithEvents btndel As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents cboxlecture As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtvenue As TextBox
    Friend WithEvents txtint As TextBox
    Friend WithEvents txtmdlname As TextBox
    Friend WithEvents txtmdlid As TextBox
    Friend WithEvents txtdate As TextBox
    Friend WithEvents txttbid As TextBox
    Friend WithEvents lbltbid As Label
    Friend WithEvents Button1 As Button
End Class
