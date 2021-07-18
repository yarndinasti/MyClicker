<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RepeatFrm
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
        Me.ComboRepeat = New System.Windows.Forms.ComboBox()
        Me.RepeatNum = New System.Windows.Forms.NumericUpDown()
        Me.saveBtn = New System.Windows.Forms.Button()
        CType(Me.RepeatNum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboRepeat
        '
        Me.ComboRepeat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboRepeat.FormattingEnabled = True
        Me.ComboRepeat.Location = New System.Drawing.Point(12, 12)
        Me.ComboRepeat.Name = "ComboRepeat"
        Me.ComboRepeat.Size = New System.Drawing.Size(121, 21)
        Me.ComboRepeat.TabIndex = 0
        '
        'RepeatNum
        '
        Me.RepeatNum.Location = New System.Drawing.Point(139, 12)
        Me.RepeatNum.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.RepeatNum.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.RepeatNum.Name = "RepeatNum"
        Me.RepeatNum.Size = New System.Drawing.Size(157, 20)
        Me.RepeatNum.TabIndex = 1
        Me.RepeatNum.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'saveBtn
        '
        Me.saveBtn.Location = New System.Drawing.Point(302, 10)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(67, 23)
        Me.saveBtn.TabIndex = 2
        Me.saveBtn.Text = "Save"
        Me.saveBtn.UseVisualStyleBackColor = True
        '
        'RepeatFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(381, 48)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.RepeatNum)
        Me.Controls.Add(Me.ComboRepeat)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "RepeatFrm"
        Me.ShowInTaskbar = False
        Me.Text = "Edit Repeat"
        CType(Me.RepeatNum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboRepeat As ComboBox
    Friend WithEvents RepeatNum As NumericUpDown
    Friend WithEvents saveBtn As Button
End Class
