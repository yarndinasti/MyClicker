<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class KeySetting
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnKey = New System.Windows.Forms.Button()
        Me.ComKeyHandler = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComKey = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnKey
        '
        Me.btnKey.Location = New System.Drawing.Point(209, 12)
        Me.btnKey.Name = "btnKey"
        Me.btnKey.Size = New System.Drawing.Size(52, 31)
        Me.btnKey.TabIndex = 3
        Me.btnKey.Text = "Save"
        Me.btnKey.UseVisualStyleBackColor = True
        '
        'ComKeyHandler
        '
        Me.ComKeyHandler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComKeyHandler.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComKeyHandler.FormattingEnabled = True
        Me.ComKeyHandler.Location = New System.Drawing.Point(12, 11)
        Me.ComKeyHandler.Name = "ComKeyHandler"
        Me.ComKeyHandler.Size = New System.Drawing.Size(76, 32)
        Me.ComKeyHandler.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(94, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "+"
        '
        'ComKey
        '
        Me.ComKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComKey.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComKey.FormattingEnabled = True
        Me.ComKey.ItemHeight = 24
        Me.ComKey.Location = New System.Drawing.Point(121, 11)
        Me.ComKey.MaxDropDownItems = 5
        Me.ComKey.Name = "ComKey"
        Me.ComKey.Size = New System.Drawing.Size(76, 32)
        Me.ComKey.TabIndex = 4
        '
        'KeySetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(273, 58)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComKey)
        Me.Controls.Add(Me.ComKeyHandler)
        Me.Controls.Add(Me.btnKey)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "KeySetting"
        Me.ShowInTaskbar = False
        Me.Text = "Configuration Keys"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnKey As Button
    Friend WithEvents ComKeyHandler As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ComKey As ComboBox
End Class
