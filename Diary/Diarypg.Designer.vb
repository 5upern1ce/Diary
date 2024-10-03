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
        Me.titlebx = New System.Windows.Forms.TextBox()
        Me.entrybx = New System.Windows.Forms.TextBox()
        Me.moodbx = New System.Windows.Forms.TextBox()
        Me.targetsbx = New System.Windows.Forms.TextBox()
        Me.Dateinputter = New System.Windows.Forms.DateTimePicker()
        Me.ttllbl = New System.Windows.Forms.Label()
        Me.datelbl = New System.Windows.Forms.Label()
        Me.entrylbl = New System.Windows.Forms.Label()
        Me.moodlbl = New System.Windows.Forms.Label()
        Me.targetslbl = New System.Windows.Forms.Label()
        Me.Datechooser = New System.Windows.Forms.DateTimePicker()
        Me.nextbtn = New System.Windows.Forms.Button()
        Me.previousbtn = New System.Windows.Forms.Button()
        Me.backtomenubtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'diarytitlbl
        '
        Me.diarytitlbl.AutoSize = True
        Me.diarytitlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 35.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.diarytitlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(5, Byte), Integer))
        Me.diarytitlbl.Location = New System.Drawing.Point(317, 9)
        Me.diarytitlbl.Name = "diarytitlbl"
        Me.diarytitlbl.Size = New System.Drawing.Size(138, 54)
        Me.diarytitlbl.TabIndex = 0
        Me.diarytitlbl.Text = "Diary"
        '
        'titlebx
        '
        Me.titlebx.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titlebx.Location = New System.Drawing.Point(157, 116)
        Me.titlebx.Name = "titlebx"
        Me.titlebx.Size = New System.Drawing.Size(360, 30)
        Me.titlebx.TabIndex = 1
        '
        'entrybx
        '
        Me.entrybx.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.entrybx.Location = New System.Drawing.Point(157, 229)
        Me.entrybx.Multiline = True
        Me.entrybx.Name = "entrybx"
        Me.entrybx.Size = New System.Drawing.Size(360, 93)
        Me.entrybx.TabIndex = 3
        '
        'moodbx
        '
        Me.moodbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moodbx.Location = New System.Drawing.Point(157, 328)
        Me.moodbx.Name = "moodbx"
        Me.moodbx.Size = New System.Drawing.Size(360, 30)
        Me.moodbx.TabIndex = 4
        '
        'targetsbx
        '
        Me.targetsbx.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.targetsbx.Location = New System.Drawing.Point(157, 364)
        Me.targetsbx.Name = "targetsbx"
        Me.targetsbx.Size = New System.Drawing.Size(360, 30)
        Me.targetsbx.TabIndex = 5
        '
        'Dateinputter
        '
        Me.Dateinputter.Location = New System.Drawing.Point(157, 176)
        Me.Dateinputter.Name = "Dateinputter"
        Me.Dateinputter.Size = New System.Drawing.Size(360, 20)
        Me.Dateinputter.TabIndex = 6
        '
        'ttllbl
        '
        Me.ttllbl.AutoSize = True
        Me.ttllbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ttllbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.ttllbl.Location = New System.Drawing.Point(72, 119)
        Me.ttllbl.Name = "ttllbl"
        Me.ttllbl.Size = New System.Drawing.Size(54, 25)
        Me.ttllbl.TabIndex = 7
        Me.ttllbl.Text = "Title"
        '
        'datelbl
        '
        Me.datelbl.AutoSize = True
        Me.datelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datelbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.datelbl.Location = New System.Drawing.Point(72, 176)
        Me.datelbl.Name = "datelbl"
        Me.datelbl.Size = New System.Drawing.Size(57, 25)
        Me.datelbl.TabIndex = 8
        Me.datelbl.Text = "Date"
        '
        'entrylbl
        '
        Me.entrylbl.AutoSize = True
        Me.entrylbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.entrylbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.entrylbl.Location = New System.Drawing.Point(72, 232)
        Me.entrylbl.Name = "entrylbl"
        Me.entrylbl.Size = New System.Drawing.Size(62, 25)
        Me.entrylbl.TabIndex = 9
        Me.entrylbl.Text = "Entry"
        '
        'moodlbl
        '
        Me.moodlbl.AutoSize = True
        Me.moodlbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moodlbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.moodlbl.Location = New System.Drawing.Point(72, 328)
        Me.moodlbl.Name = "moodlbl"
        Me.moodlbl.Size = New System.Drawing.Size(66, 25)
        Me.moodlbl.TabIndex = 10
        Me.moodlbl.Text = "Mood"
        '
        'targetslbl
        '
        Me.targetslbl.AutoSize = True
        Me.targetslbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.targetslbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.targetslbl.Location = New System.Drawing.Point(65, 367)
        Me.targetslbl.Name = "targetslbl"
        Me.targetslbl.Size = New System.Drawing.Size(86, 25)
        Me.targetslbl.TabIndex = 11
        Me.targetslbl.Text = "Targets"
        '
        'Datechooser
        '
        Me.Datechooser.Location = New System.Drawing.Point(611, 116)
        Me.Datechooser.Name = "Datechooser"
        Me.Datechooser.Size = New System.Drawing.Size(167, 20)
        Me.Datechooser.TabIndex = 12
        '
        'nextbtn
        '
        Me.nextbtn.Location = New System.Drawing.Point(620, 331)
        Me.nextbtn.Name = "nextbtn"
        Me.nextbtn.Size = New System.Drawing.Size(91, 30)
        Me.nextbtn.TabIndex = 13
        Me.nextbtn.Text = "Next"
        Me.nextbtn.UseVisualStyleBackColor = True
        '
        'previousbtn
        '
        Me.previousbtn.Location = New System.Drawing.Point(620, 367)
        Me.previousbtn.Name = "previousbtn"
        Me.previousbtn.Size = New System.Drawing.Size(91, 27)
        Me.previousbtn.TabIndex = 14
        Me.previousbtn.Text = "Previous"
        Me.previousbtn.UseVisualStyleBackColor = True
        '
        'backtomenubtn
        '
        Me.backtomenubtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.backtomenubtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backtomenubtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.backtomenubtn.Location = New System.Drawing.Point(23, 12)
        Me.backtomenubtn.Name = "backtomenubtn"
        Me.backtomenubtn.Size = New System.Drawing.Size(230, 75)
        Me.backtomenubtn.TabIndex = 15
        Me.backtomenubtn.Text = "Back to menu"
        Me.backtomenubtn.UseVisualStyleBackColor = False
        '
        'Diarypg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.backtomenubtn)
        Me.Controls.Add(Me.previousbtn)
        Me.Controls.Add(Me.nextbtn)
        Me.Controls.Add(Me.Datechooser)
        Me.Controls.Add(Me.targetslbl)
        Me.Controls.Add(Me.moodlbl)
        Me.Controls.Add(Me.entrylbl)
        Me.Controls.Add(Me.datelbl)
        Me.Controls.Add(Me.ttllbl)
        Me.Controls.Add(Me.Dateinputter)
        Me.Controls.Add(Me.targetsbx)
        Me.Controls.Add(Me.moodbx)
        Me.Controls.Add(Me.entrybx)
        Me.Controls.Add(Me.titlebx)
        Me.Controls.Add(Me.diarytitlbl)
        Me.Name = "Diarypg"
        Me.Text = "Diary"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents diarytitlbl As Label
    Friend WithEvents titlebx As TextBox
    Friend WithEvents entrybx As TextBox
    Friend WithEvents moodbx As TextBox
    Friend WithEvents targetsbx As TextBox
    Friend WithEvents Dateinputter As DateTimePicker
    Friend WithEvents ttllbl As Label
    Friend WithEvents datelbl As Label
    Friend WithEvents entrylbl As Label
    Friend WithEvents moodlbl As Label
    Friend WithEvents targetslbl As Label
    Friend WithEvents Datechooser As DateTimePicker
    Friend WithEvents nextbtn As Button
    Friend WithEvents previousbtn As Button
    Friend WithEvents backtomenubtn As Button
End Class
