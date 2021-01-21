<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnIfNext = New System.Windows.Forms.Button()
        Me.btnSelectNext = New System.Windows.Forms.Button()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblWeekday = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnIfNext
        '
        Me.btnIfNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIfNext.Location = New System.Drawing.Point(28, 76)
        Me.btnIfNext.Name = "btnIfNext"
        Me.btnIfNext.Size = New System.Drawing.Size(115, 42)
        Me.btnIfNext.TabIndex = 0
        Me.btnIfNext.Text = "If Next Day"
        Me.btnIfNext.UseVisualStyleBackColor = True
        '
        'btnSelectNext
        '
        Me.btnSelectNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectNext.Location = New System.Drawing.Point(208, 76)
        Me.btnSelectNext.Name = "btnSelectNext"
        Me.btnSelectNext.Size = New System.Drawing.Size(115, 42)
        Me.btnSelectNext.TabIndex = 1
        Me.btnSelectNext.Text = "Select Next Day"
        Me.btnSelectNext.UseVisualStyleBackColor = True
        '
        'lblDay
        '
        Me.lblDay.AutoSize = True
        Me.lblDay.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDay.Location = New System.Drawing.Point(12, 211)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(88, 16)
        Me.lblDay.TabIndex = 2
        Me.lblDay.Text = "Day: Monday"
        '
        'lblWeekday
        '
        Me.lblWeekday.AutoSize = True
        Me.lblWeekday.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWeekday.Location = New System.Drawing.Point(12, 290)
        Me.lblWeekday.Name = "lblWeekday"
        Me.lblWeekday.Size = New System.Drawing.Size(67, 16)
        Me.lblWeekday.TabIndex = 3
        Me.lblWeekday.Text = "Weekday"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 445)
        Me.Controls.Add(Me.lblWeekday)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.btnSelectNext)
        Me.Controls.Add(Me.btnIfNext)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnIfNext As System.Windows.Forms.Button
    Friend WithEvents btnSelectNext As System.Windows.Forms.Button
    Friend WithEvents lblDay As System.Windows.Forms.Label
    Friend WithEvents lblWeekday As System.Windows.Forms.Label

End Class
