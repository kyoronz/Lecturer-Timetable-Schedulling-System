<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pcb = New System.Windows.Forms.PictureBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btnViewLT = New System.Windows.Forms.Button()
        Me.btnBookC = New System.Windows.Forms.Button()
        Me.btnNoti = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.pcb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(1304, 28)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(68, 24)
        Me.FileToolStripMenuItem.Text = "Logout"
        '
        'pcb
        '
        Me.pcb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pcb.Image = CType(resources.GetObject("pcb.Image"), System.Drawing.Image)
        Me.pcb.Location = New System.Drawing.Point(0, 28)
        Me.pcb.Name = "pcb"
        Me.pcb.Size = New System.Drawing.Size(1304, 734)
        Me.pcb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pcb.TabIndex = 8
        Me.pcb.TabStop = False
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btnViewLT)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnBookC)
        Me.FlowLayoutPanel1.Controls.Add(Me.btnNoti)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 698)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1304, 64)
        Me.FlowLayoutPanel1.TabIndex = 10
        '
        'btnViewLT
        '
        Me.btnViewLT.Location = New System.Drawing.Point(3, 3)
        Me.btnViewLT.Name = "btnViewLT"
        Me.btnViewLT.Size = New System.Drawing.Size(454, 54)
        Me.btnViewLT.TabIndex = 0
        Me.btnViewLT.Text = "View Lecturer's Timetable"
        Me.btnViewLT.UseVisualStyleBackColor = True
        '
        'btnBookC
        '
        Me.btnBookC.Location = New System.Drawing.Point(463, 3)
        Me.btnBookC.Name = "btnBookC"
        Me.btnBookC.Size = New System.Drawing.Size(420, 54)
        Me.btnBookC.TabIndex = 1
        Me.btnBookC.Text = "Book Consultation"
        Me.btnBookC.UseVisualStyleBackColor = True
        '
        'btnNoti
        '
        Me.btnNoti.Location = New System.Drawing.Point(889, 3)
        Me.btnNoti.Name = "btnNoti"
        Me.btnNoti.Size = New System.Drawing.Size(403, 54)
        Me.btnNoti.TabIndex = 3
        Me.btnNoti.Text = "Notification"
        Me.btnNoti.UseVisualStyleBackColor = True
        '
        'StudentMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1304, 762)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.pcb)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "StudentMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentMenu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.pcb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pcb As PictureBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btnViewLT As Button
    Friend WithEvents btnBookC As Button
    Friend WithEvents btnNoti As Button
End Class
