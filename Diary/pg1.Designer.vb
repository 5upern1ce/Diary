<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pg1
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
        Me.menulbl = New System.Windows.Forms.Label()
        Me.mkaselectionlbl = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'menulbl
        '
        Me.menulbl.AutoSize = True
        Me.menulbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menulbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.menulbl.Location = New System.Drawing.Point(326, 29)
        Me.menulbl.Name = "menulbl"
        Me.menulbl.Size = New System.Drawing.Size(144, 54)
        Me.menulbl.TabIndex = 0
        Me.menulbl.Text = "Menu"
        '
        'mkaselectionlbl
        '
        Me.mkaselectionlbl.AutoSize = True
        Me.mkaselectionlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mkaselectionlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.mkaselectionlbl.Location = New System.Drawing.Point(319, 83)
        Me.mkaselectionlbl.Name = "mkaselectionlbl"
        Me.mkaselectionlbl.Size = New System.Drawing.Size(165, 25)
        Me.mkaselectionlbl.TabIndex = 1
        Me.mkaselectionlbl.Text = "Make a selection!"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(299, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(198, 79)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Diary Events"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'pg1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.mkaselectionlbl)
        Me.Controls.Add(Me.menulbl)
        Me.Name = "pg1"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents menulbl As Label
    Friend WithEvents mkaselectionlbl As Label
    Friend WithEvents Button1 As Button
End Class
