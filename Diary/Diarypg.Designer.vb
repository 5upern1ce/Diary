<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Diarypg
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
        Me.diarytitlbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'diarytitlbl
        '
        Me.diarytitlbl.AutoSize = True
        Me.diarytitlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diarytitlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.diarytitlbl.Location = New System.Drawing.Point(324, 37)
        Me.diarytitlbl.Name = "diarytitlbl"
        Me.diarytitlbl.Size = New System.Drawing.Size(138, 54)
        Me.diarytitlbl.TabIndex = 0
        Me.diarytitlbl.Text = "Diary"
        '
        'Diarypg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.diarytitlbl)
        Me.Name = "Diarypg"
        Me.Text = "Diary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents diarytitlbl As Label
End Class
