<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LecturerMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LecturerMenu))
        Me.pcb = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnVTT = New System.Windows.Forms.Button()
        Me.btnCon = New System.Windows.Forms.Button()
        Me.btnNot = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.pcb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pcb
        '
        Me.pcb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pcb.Image = CType(resources.GetObject("pcb.Image"), System.Drawing.Image)
        Me.pcb.Location = New System.Drawing.Point(0, 0)
        Me.pcb.Name = "pcb"
        Me.pcb.Size = New System.Drawing.Size(1304, 762)
        Me.pcb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcb.TabIndex = 8
        Me.pcb.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.MistyRose
        Me.FlowLayoutPanel1.Controls.Add(Me.btnVTT)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnCon)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnNot)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 698)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1304, 64)
        Me.FlowLayoutPanel1.TabIndex = 9
        '
        'btnVTT
        '
        Me.btnVTT.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnVTT.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVTT.Location = New System.Drawing.Point(3, 3)
        Me.btnVTT.Name = "btnVTT"
        Me.btnVTT.Size = New System.Drawing.Size(474, 54)
        Me.btnVTT.TabIndex = 0
        Me.btnVTT.Text = "View Timetable "
        Me.btnVTT.UseVisualStyleBackColor = False
        '
        'btnCon
        '
        Me.btnCon.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnCon.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCon.Location = New System.Drawing.Point(483, 3)
        Me.btnCon.Name = "btnCon"
        Me.btnCon.Size = New System.Drawing.Size(419, 54)
        Me.btnCon.TabIndex = 1
        Me.btnCon.Text = "Consulation Schedule"
        Me.btnCon.UseVisualStyleBackColor = False
        '
        'btnNot
        '
        Me.btnNot.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnNot.Font = New System.Drawing.Font("Arial", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNot.Location = New System.Drawing.Point(908, 3)
        Me.btnNot.Name = "btnNot"
        Me.btnNot.Size = New System.Drawing.Size(393, 54)
        Me.btnNot.TabIndex = 2
        Me.btnNot.Text = "Notification"
        Me.btnNot.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.MistyRose
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(1304, 28)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.FileToolStripMenuItem.Text = "Logout"
        '
        'LecturerMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1304, 762)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.pcb)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "LecturerMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lecturer Menu"
        CType(Me.pcb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pcb As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnVTT As Button
    Friend WithEvents btnCon As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnNot As Button
End Class
