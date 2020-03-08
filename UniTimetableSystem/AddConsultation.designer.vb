<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddConsultation
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.txtST = New System.Windows.Forms.TextBox()
        Me.cmbDur = New System.Windows.Forms.ComboBox()
        Me.cmbDateV = New System.Windows.Forms.ComboBox()
        Me.cmbVT = New System.Windows.Forms.ComboBox()
        Me.cmbVID = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(281, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(236, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Consultation "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(90, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Selected Date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(160, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Selected Start Time :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(80, 118)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(131, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Select Duration :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Select Date Validation :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Select Venue Type :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(69, 253)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Select Venue ID :"
        '
        'txtDate
        '
        Me.txtDate.Enabled = False
        Me.txtDate.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtDate.Location = New System.Drawing.Point(237, 25)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(282, 27)
        Me.txtDate.TabIndex = 7
        '
        'txtST
        '
        Me.txtST.Enabled = False
        Me.txtST.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtST.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtST.Location = New System.Drawing.Point(237, 70)
        Me.txtST.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtST.Name = "txtST"
        Me.txtST.Size = New System.Drawing.Size(282, 27)
        Me.txtST.TabIndex = 8
        '
        'cmbDur
        '
        Me.cmbDur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDur.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDur.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbDur.FormattingEnabled = True
        Me.cmbDur.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbDur.Location = New System.Drawing.Point(237, 115)
        Me.cmbDur.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbDur.Name = "cmbDur"
        Me.cmbDur.Size = New System.Drawing.Size(213, 27)
        Me.cmbDur.TabIndex = 9
        '
        'cmbDateV
        '
        Me.cmbDateV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbDateV.Enabled = False
        Me.cmbDateV.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDateV.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbDateV.FormattingEnabled = True
        Me.cmbDateV.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.cmbDateV.Location = New System.Drawing.Point(237, 160)
        Me.cmbDateV.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbDateV.Name = "cmbDateV"
        Me.cmbDateV.Size = New System.Drawing.Size(213, 27)
        Me.cmbDateV.TabIndex = 10
        '
        'cmbVT
        '
        Me.cmbVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVT.Enabled = False
        Me.cmbVT.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVT.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbVT.FormattingEnabled = True
        Me.cmbVT.Location = New System.Drawing.Point(237, 205)
        Me.cmbVT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbVT.Name = "cmbVT"
        Me.cmbVT.Size = New System.Drawing.Size(282, 27)
        Me.cmbVT.TabIndex = 11
        '
        'cmbVID
        '
        Me.cmbVID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbVID.Enabled = False
        Me.cmbVID.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVID.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmbVID.FormattingEnabled = True
        Me.cmbVID.Location = New System.Drawing.Point(237, 250)
        Me.cmbVID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbVID.Name = "cmbVID"
        Me.cmbVID.Size = New System.Drawing.Size(282, 27)
        Me.cmbVID.TabIndex = 12
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAdd.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnAdd.Enabled = False
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdd.Location = New System.Drawing.Point(46, 476)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(113, 51)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add "
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnClear.Enabled = False
        Me.btnClear.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClear.Location = New System.Drawing.Point(247, 476)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(113, 50)
        Me.btnClear.TabIndex = 14
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBack.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBack.Location = New System.Drawing.Point(455, 476)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(113, 49)
        Me.btnBack.TabIndex = 15
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(457, 123)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 19)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "hour(s)"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(457, 168)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 19)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "week(s)"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.LightCoral
        Me.ListBox1.Enabled = False
        Me.ListBox1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 17
        Me.ListBox1.Location = New System.Drawing.Point(631, 247)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(159, 106)
        Me.ListBox1.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(824, 69)
        Me.Panel1.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightCoral
        Me.Panel2.Controls.Add(Me.cmbVID)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtDate)
        Me.Panel2.Controls.Add(Me.txtST)
        Me.Panel2.Controls.Add(Me.cmbVT)
        Me.Panel2.Controls.Add(Me.cmbDur)
        Me.Panel2.Controls.Add(Me.cmbDateV)
        Me.Panel2.Location = New System.Drawing.Point(23, 112)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(564, 322)
        Me.Panel2.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(627, 207)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(162, 19)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Consultation Date(s):"
        '
        'AddConsultation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(824, 563)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnAdd)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "AddConsultation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtDate As TextBox
    Friend WithEvents txtST As TextBox
    Friend WithEvents cmbDur As ComboBox
    Friend WithEvents cmbDateV As ComboBox
    Friend WithEvents cmbVT As ComboBox
    Friend WithEvents cmbVID As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label10 As Label
End Class
