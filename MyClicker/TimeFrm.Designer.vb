<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TimeFrm
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
        Me.NumTime = New System.Windows.Forms.NumericUpDown()
        Me.ComboTime = New System.Windows.Forms.ComboBox()
        Me.TimeBtn = New System.Windows.Forms.Button()
        CType(Me.NumTime, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumTime
        '
        Me.NumTime.Location = New System.Drawing.Point(12, 7)
        Me.NumTime.Maximum = New Decimal(New Integer() {86400, 0, 0, 0})
        Me.NumTime.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumTime.Name = "NumTime"
        Me.NumTime.Size = New System.Drawing.Size(120, 20)
        Me.NumTime.TabIndex = 0
        Me.NumTime.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ComboTime
        '
        Me.ComboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboTime.FormattingEnabled = True
        Me.ComboTime.Location = New System.Drawing.Point(138, 7)
        Me.ComboTime.Name = "ComboTime"
        Me.ComboTime.Size = New System.Drawing.Size(107, 21)
        Me.ComboTime.TabIndex = 1
        '
        'TimeBtn
        '
        Me.TimeBtn.Location = New System.Drawing.Point(251, 6)
        Me.TimeBtn.Name = "TimeBtn"
        Me.TimeBtn.Size = New System.Drawing.Size(61, 23)
        Me.TimeBtn.TabIndex = 2
        Me.TimeBtn.Text = "Save"
        Me.TimeBtn.UseVisualStyleBackColor = True
        '
        'TimeFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 34)
        Me.Controls.Add(Me.TimeBtn)
        Me.Controls.Add(Me.ComboTime)
        Me.Controls.Add(Me.NumTime)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "TimeFrm"
        Me.Text = "TimeFrm"
        CType(Me.NumTime, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NumTime As NumericUpDown
    Friend WithEvents ComboTime As ComboBox
    Friend WithEvents TimeBtn As Button
End Class
