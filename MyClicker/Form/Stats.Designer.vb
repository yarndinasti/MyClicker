<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Stats
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
        Me.LblStart = New System.Windows.Forms.Label()
        Me.LblDelay = New System.Windows.Forms.Label()
        Me.LblPress = New System.Windows.Forms.Label()
        Me.LblDelaySec = New System.Windows.Forms.Label()
        Me.LblDelayTime = New System.Windows.Forms.Label()
        Me.LblPressSec = New System.Windows.Forms.Label()
        Me.LblPressTime = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.RepeatValueLbl = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblStart
        '
        Me.LblStart.AutoSize = True
        Me.LblStart.Location = New System.Drawing.Point(7, 15)
        Me.LblStart.Name = "LblStart"
        Me.LblStart.Size = New System.Drawing.Size(64, 13)
        Me.LblStart.TabIndex = 0
        Me.LblStart.Text = "Start Timer: "
        '
        'LblDelay
        '
        Me.LblDelay.AutoSize = True
        Me.LblDelay.Location = New System.Drawing.Point(7, 32)
        Me.LblDelay.Name = "LblDelay"
        Me.LblDelay.Size = New System.Drawing.Size(66, 13)
        Me.LblDelay.TabIndex = 1
        Me.LblDelay.Text = "Delay Timer:"
        '
        'LblPress
        '
        Me.LblPress.AutoSize = True
        Me.LblPress.Location = New System.Drawing.Point(6, 15)
        Me.LblPress.Name = "LblPress"
        Me.LblPress.Size = New System.Drawing.Size(65, 13)
        Me.LblPress.TabIndex = 2
        Me.LblPress.Text = "Press Timer:"
        '
        'LblDelaySec
        '
        Me.LblDelaySec.AutoSize = True
        Me.LblDelaySec.Location = New System.Drawing.Point(7, 66)
        Me.LblDelaySec.Name = "LblDelaySec"
        Me.LblDelaySec.Size = New System.Drawing.Size(60, 13)
        Me.LblDelaySec.TabIndex = 3
        Me.LblDelaySec.Text = "Remaining:"
        '
        'LblDelayTime
        '
        Me.LblDelayTime.AutoSize = True
        Me.LblDelayTime.Location = New System.Drawing.Point(7, 49)
        Me.LblDelayTime.Name = "LblDelayTime"
        Me.LblDelayTime.Size = New System.Drawing.Size(50, 13)
        Me.LblDelayTime.TabIndex = 3
        Me.LblDelayTime.Text = "Duration:"
        '
        'LblPressSec
        '
        Me.LblPressSec.AutoSize = True
        Me.LblPressSec.Location = New System.Drawing.Point(6, 47)
        Me.LblPressSec.Name = "LblPressSec"
        Me.LblPressSec.Size = New System.Drawing.Size(60, 13)
        Me.LblPressSec.TabIndex = 3
        Me.LblPressSec.Text = "Remaining:"
        '
        'LblPressTime
        '
        Me.LblPressTime.AutoSize = True
        Me.LblPressTime.Location = New System.Drawing.Point(6, 31)
        Me.LblPressTime.Name = "LblPressTime"
        Me.LblPressTime.Size = New System.Drawing.Size(50, 13)
        Me.LblPressTime.TabIndex = 3
        Me.LblPressTime.Text = "Duration:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LblDelayTime)
        Me.GroupBox1.Controls.Add(Me.LblStart)
        Me.GroupBox1.Controls.Add(Me.LblDelay)
        Me.GroupBox1.Controls.Add(Me.LblDelaySec)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 87)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Delay"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LblPress)
        Me.GroupBox2.Controls.Add(Me.LblPressSec)
        Me.GroupBox2.Controls.Add(Me.LblPressTime)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(146, 66)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Click Press"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.RepeatValueLbl)
        Me.GroupBox3.Location = New System.Drawing.Point(3, 154)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(146, 37)
        Me.GroupBox3.TabIndex = 6
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Repeat"
        '
        'RepeatValueLbl
        '
        Me.RepeatValueLbl.AutoSize = True
        Me.RepeatValueLbl.Location = New System.Drawing.Point(7, 16)
        Me.RepeatValueLbl.Name = "RepeatValueLbl"
        Me.RepeatValueLbl.Size = New System.Drawing.Size(39, 13)
        Me.RepeatValueLbl.TabIndex = 0
        Me.RepeatValueLbl.Text = "Label1"
        '
        'Stats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(155, 196)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Stats"
        Me.ShowInTaskbar = False
        Me.Text = "Stats"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LblStart As Label
    Friend WithEvents LblDelay As Label
    Friend WithEvents LblPress As Label
    Friend WithEvents LblDelaySec As Label
    Friend WithEvents LblDelayTime As Label
    Friend WithEvents LblPressSec As Label
    Friend WithEvents LblPressTime As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents RepeatValueLbl As Label
End Class
