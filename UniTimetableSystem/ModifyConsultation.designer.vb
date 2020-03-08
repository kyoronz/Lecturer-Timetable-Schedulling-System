<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModifyConsultation
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
        Me.lblCanRe = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbNStatus = New System.Windows.Forms.ComboBox()
        Me.txtReason = New System.Windows.Forms.TextBox()
        Me.cmbNewST = New System.Windows.Forms.ComboBox()
        Me.cmbNewDur = New System.Windows.Forms.ComboBox()
        Me.cmbNewVT = New System.Windows.Forms.ComboBox()
        Me.cmbNewVID = New System.Windows.Forms.ComboBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtOldDate = New System.Windows.Forms.TextBox()
        Me.txtOldTime = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Schoolbook", 13.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(210, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(262, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Modify Consultation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(52, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Select New Status :"
        '
        'lblCanRe
        '
        Me.lblCanRe.AutoSize = True
        Me.lblCanRe.BackColor = System.Drawing.Color.Transparent
        Me.lblCanRe.Enabled = False
        Me.lblCanRe.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCanRe.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCanRe.Location = New System.Drawing.Point(52, 145)
        Me.lblCanRe.Name = "lblCanRe"
        Me.lblCanRe.Size = New System.Drawing.Size(168, 19)
        Me.lblCanRe.TabIndex = 2
        Me.lblCanRe.Text = "Cancellation Reason :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(52, 299)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Select New Date :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(52, 344)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Select New Start Time :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(52, 388)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(172, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Select New Duration : "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Enabled = False
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(52, 429)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(191, 19)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Select New Venue Type :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Enabled = False
        Me.Label9.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(54, 473)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(173, 19)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Select New Venue ID :"
        '
        'cmbNStatus
        '
        Me.cmbNStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNStatus.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNStatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbNStatus.FormattingEnabled = True
        Me.cmbNStatus.Items.AddRange(New Object() {"Cancellation", "On Going"})
        Me.cmbNStatus.Location = New System.Drawing.Point(320, 105)
        Me.cmbNStatus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbNStatus.Name = "cmbNStatus"
        Me.cmbNStatus.Size = New System.Drawing.Size(351, 27)
        Me.cmbNStatus.TabIndex = 9
        '
        'txtReason
        '
        Me.txtReason.Enabled = False
        Me.txtReason.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReason.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtReason.Location = New System.Drawing.Point(320, 142)
        Me.txtReason.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(351, 112)
        Me.txtReason.TabIndex = 10
        '
        'cmbNewST
        '
        Me.cmbNewST.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNewST.Enabled = False
        Me.cmbNewST.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNewST.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbNewST.FormattingEnabled = True
        Me.cmbNewST.Location = New System.Drawing.Point(320, 337)
        Me.cmbNewST.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbNewST.Name = "cmbNewST"
        Me.cmbNewST.Size = New System.Drawing.Size(351, 27)
        Me.cmbNewST.TabIndex = 12
        '
        'cmbNewDur
        '
        Me.cmbNewDur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNewDur.Enabled = False
        Me.cmbNewDur.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNewDur.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbNewDur.FormattingEnabled = True
        Me.cmbNewDur.Items.AddRange(New Object() {"1", "2", "3"})
        Me.cmbNewDur.Location = New System.Drawing.Point(320, 380)
        Me.cmbNewDur.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbNewDur.Name = "cmbNewDur"
        Me.cmbNewDur.Size = New System.Drawing.Size(282, 27)
        Me.cmbNewDur.TabIndex = 13
        '
        'cmbNewVT
        '
        Me.cmbNewVT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNewVT.Enabled = False
        Me.cmbNewVT.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNewVT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbNewVT.FormattingEnabled = True
        Me.cmbNewVT.Location = New System.Drawing.Point(320, 422)
        Me.cmbNewVT.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbNewVT.Name = "cmbNewVT"
        Me.cmbNewVT.Size = New System.Drawing.Size(351, 27)
        Me.cmbNewVT.TabIndex = 15
        '
        'cmbNewVID
        '
        Me.cmbNewVID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbNewVID.Enabled = False
        Me.cmbNewVID.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbNewVID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmbNewVID.FormattingEnabled = True
        Me.cmbNewVID.Location = New System.Drawing.Point(320, 466)
        Me.cmbNewVID.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cmbNewVID.Name = "cmbNewVID"
        Me.cmbNewVID.Size = New System.Drawing.Size(351, 27)
        Me.cmbNewVID.TabIndex = 16
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnUpdate.Enabled = False
        Me.btnUpdate.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnUpdate.Location = New System.Drawing.Point(148, 637)
        Me.btnUpdate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(120, 61)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnClear.Enabled = False
        Me.btnClear.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnClear.Location = New System.Drawing.Point(295, 637)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(120, 61)
        Me.btnClear.TabIndex = 18
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBack.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnBack.Location = New System.Drawing.Point(440, 637)
        Me.btnBack.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(120, 61)
        Me.btnBack.TabIndex = 19
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(54, 34)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 19)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Selected Date:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label10.Location = New System.Drawing.Point(54, 71)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(116, 19)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Selected Time:"
        '
        'txtOldDate
        '
        Me.txtOldDate.Enabled = False
        Me.txtOldDate.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOldDate.Location = New System.Drawing.Point(320, 31)
        Me.txtOldDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOldDate.Name = "txtOldDate"
        Me.txtOldDate.Size = New System.Drawing.Size(351, 27)
        Me.txtOldDate.TabIndex = 22
        '
        'txtOldTime
        '
        Me.txtOldTime.Enabled = False
        Me.txtOldTime.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtOldTime.Location = New System.Drawing.Point(320, 68)
        Me.txtOldTime.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOldTime.Name = "txtOldTime"
        Me.txtOldTime.Size = New System.Drawing.Size(351, 27)
        Me.txtOldTime.TabIndex = 23
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Enabled = False
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(320, 288)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(4)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(351, 27)
        Me.DateTimePicker1.TabIndex = 24
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(609, 383)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 19)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "hour(s)"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(746, 52)
        Me.Panel1.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightCoral
        Me.Panel2.Controls.Add(Me.DateTimePicker1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.lblCanRe)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtOldTime)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtOldDate)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.cmbNStatus)
        Me.Panel2.Controls.Add(Me.txtReason)
        Me.Panel2.Controls.Add(Me.cmbNewST)
        Me.Panel2.Controls.Add(Me.cmbNewDur)
        Me.Panel2.Controls.Add(Me.cmbNewVID)
        Me.Panel2.Controls.Add(Me.cmbNewVT)
        Me.Panel2.Location = New System.Drawing.Point(12, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(698, 517)
        Me.Panel2.TabIndex = 28
        '
        'ModifyConsultation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(746, 710)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnUpdate)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "ModifyConsultation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblCanRe As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents cmbNStatus As ComboBox
    Friend WithEvents txtReason As TextBox
    Friend WithEvents cmbNewST As ComboBox
    Friend WithEvents cmbNewDur As ComboBox
    Friend WithEvents cmbNewVT As ComboBox
    Friend WithEvents cmbNewVID As ComboBox
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtOldDate As TextBox
    Friend WithEvents txtOldTime As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
