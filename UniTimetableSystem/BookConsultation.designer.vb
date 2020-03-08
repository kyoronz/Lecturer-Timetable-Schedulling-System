<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookConsultation
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
        Me.txtSName = New System.Windows.Forms.TextBox()
        Me.txtSID = New System.Windows.Forms.TextBox()
        Me.txtPurpose = New System.Windows.Forms.TextBox()
        Me.btnCOn = New System.Windows.Forms.Button()
        Me.btnCan = New System.Windows.Forms.Button()
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
        Me.Label1.Location = New System.Drawing.Point(125, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(282, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book An Appointment"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(23, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Student Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(23, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Student ID :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(26, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Purpose :"
        '
        'txtSName
        '
        Me.txtSName.Enabled = False
        Me.txtSName.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSName.Location = New System.Drawing.Point(195, 31)
        Me.txtSName.Name = "txtSName"
        Me.txtSName.Size = New System.Drawing.Size(236, 27)
        Me.txtSName.TabIndex = 4
        '
        'txtSID
        '
        Me.txtSID.Enabled = False
        Me.txtSID.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSID.Location = New System.Drawing.Point(195, 72)
        Me.txtSID.Name = "txtSID"
        Me.txtSID.Size = New System.Drawing.Size(236, 27)
        Me.txtSID.TabIndex = 5
        '
        'txtPurpose
        '
        Me.txtPurpose.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPurpose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtPurpose.Location = New System.Drawing.Point(195, 113)
        Me.txtPurpose.Multiline = True
        Me.txtPurpose.Name = "txtPurpose"
        Me.txtPurpose.Size = New System.Drawing.Size(236, 169)
        Me.txtPurpose.TabIndex = 6
        '
        'btnCOn
        '
        Me.btnCOn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCOn.DialogResult = System.Windows.Forms.DialogResult.Yes
        Me.btnCOn.Enabled = False
        Me.btnCOn.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCOn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCOn.Location = New System.Drawing.Point(130, 457)
        Me.btnCOn.Name = "btnCOn"
        Me.btnCOn.Size = New System.Drawing.Size(95, 42)
        Me.btnCOn.TabIndex = 7
        Me.btnCOn.Text = "Confirm"
        Me.btnCOn.UseVisualStyleBackColor = False
        '
        'btnCan
        '
        Me.btnCan.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCan.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnCan.Location = New System.Drawing.Point(299, 457)
        Me.btnCan.Name = "btnCan"
        Me.btnCan.Size = New System.Drawing.Size(95, 42)
        Me.btnCan.TabIndex = 8
        Me.btnCan.Text = "Cancel"
        Me.btnCan.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkRed
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(540, 70)
        Me.Panel1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.LightCoral
        Me.Panel2.Controls.Add(Me.txtPurpose)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtSName)
        Me.Panel2.Controls.Add(Me.txtSID)
        Me.Panel2.Location = New System.Drawing.Point(49, 121)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(443, 299)
        Me.Panel2.TabIndex = 10
        '
        'BookConsultation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.MistyRose
        Me.ClientSize = New System.Drawing.Size(540, 516)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnCan)
        Me.Controls.Add(Me.btnCOn)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "BookConsultation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtSName As TextBox
    Friend WithEvents txtSID As TextBox
    Friend WithEvents txtPurpose As TextBox
    Friend WithEvents btnCOn As Button
    Friend WithEvents btnCan As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
