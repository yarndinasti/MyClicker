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
        Me.SuspendLayout()
        '
        'LblStart
        '
        Me.LblStart.AutoSize = True
        Me.LblStart.Location = New System.Drawing.Point(12, 9)
        Me.LblStart.Name = "LblStart"
        Me.LblStart.Size = New System.Drawing.Size(64, 13)
        Me.LblStart.TabIndex = 0
        Me.LblStart.Text = "Start Timer: "
        '
        'LblDelay
        '
        Me.LblDelay.AutoSize = True
        Me.LblDelay.Location = New System.Drawing.Point(12, 26)
        Me.LblDelay.Name = "LblDelay"
        Me.LblDelay.Size = New System.Drawing.Size(66, 13)
        Me.LblDelay.TabIndex = 1
        Me.LblDelay.Text = "Delay Timer:"
        '
        'LblPress
        '
        Me.LblPress.AutoSize = True
        Me.LblPress.Location = New System.Drawing.Point(12, 78)
        Me.LblPress.Name = "LblPress"
        Me.LblPress.Size = New System.Drawing.Size(65, 13)
        Me.LblPress.TabIndex = 2
        Me.LblPress.Text = "Press Timer:"
        '
        'LblDelaySec
        '
        Me.LblDelaySec.AutoSize = True
        Me.LblDelaySec.Location = New System.Drawing.Point(12, 60)
        Me.LblDelaySec.Name = "LblDelaySec"
        Me.LblDelaySec.Size = New System.Drawing.Size(60, 13)
        Me.LblDelaySec.TabIndex = 3
        Me.LblDelaySec.Text = "Remaining:"
        '
        'LblDelayTime
        '
        Me.LblDelayTime.AutoSize = True
        Me.LblDelayTime.Location = New System.Drawing.Point(12, 43)
        Me.LblDelayTime.Name = "LblDelayTime"
        Me.LblDelayTime.Size = New System.Drawing.Size(50, 13)
        Me.LblDelayTime.TabIndex = 3
        Me.LblDelayTime.Text = "Duration:"
        '
        'LblPressSec
        '
        Me.LblPressSec.AutoSize = True
        Me.LblPressSec.Location = New System.Drawing.Point(12, 110)
        Me.LblPressSec.Name = "LblPressSec"
        Me.LblPressSec.Size = New System.Drawing.Size(60, 13)
        Me.LblPressSec.TabIndex = 3
        Me.LblPressSec.Text = "Remaining:"
        '
        'LblPressTime
        '
        Me.LblPressTime.AutoSize = True
        Me.LblPressTime.Location = New System.Drawing.Point(12, 94)
        Me.LblPressTime.Name = "LblPressTime"
        Me.LblPressTime.Size = New System.Drawing.Size(50, 13)
        Me.LblPressTime.TabIndex = 3
        Me.LblPressTime.Text = "Duration:"
        '
        'Stats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(184, 139)
        Me.Controls.Add(Me.LblPressTime)
        Me.Controls.Add(Me.LblDelayTime)
        Me.Controls.Add(Me.LblPressSec)
        Me.Controls.Add(Me.LblDelaySec)
        Me.Controls.Add(Me.LblPress)
        Me.Controls.Add(Me.LblDelay)
        Me.Controls.Add(Me.LblStart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Stats"
        Me.ShowInTaskbar = False
        Me.Text = "Stats"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblStart As Label
    Friend WithEvents LblDelay As Label
    Friend WithEvents LblPress As Label
    Friend WithEvents LblDelaySec As Label
    Friend WithEvents LblDelayTime As Label
    Friend WithEvents LblPressSec As Label
    Friend WithEvents LblPressTime As Label
End Class
