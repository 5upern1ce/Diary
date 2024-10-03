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
        Me.components = New System.ComponentModel.Container()
        Me.Loginbtn = New System.Windows.Forms.Button()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Titlelbl = New System.Windows.Forms.Label()
        Me.Usernamebox = New System.Windows.Forms.TextBox()
        Me.Passwordbox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.errortxt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Loginbtn
        '
        Me.Loginbtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(242, Byte), Integer), CType(CType(34, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Loginbtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 23.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Loginbtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(3, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(140, Byte), Integer))
        Me.Loginbtn.Location = New System.Drawing.Point(321, 322)
        Me.Loginbtn.Name = "Loginbtn"
        Me.Loginbtn.Size = New System.Drawing.Size(138, 75)
        Me.Loginbtn.TabIndex = 0
        Me.Loginbtn.Text = "Login"
        Me.Loginbtn.UseVisualStyleBackColor = False
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Titlelbl
        '
        Me.Titlelbl.AutoSize = True
        Me.Titlelbl.Font = New System.Drawing.Font("Impact", 35.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Titlelbl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(217, Byte), Integer), CType(CType(149, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Titlelbl.Location = New System.Drawing.Point(184, 72)
        Me.Titlelbl.Name = "Titlelbl"
        Me.Titlelbl.Size = New System.Drawing.Size(427, 59)
        Me.Titlelbl.TabIndex = 1
        Me.Titlelbl.Text = "Welcome to my Diary"
        Me.Titlelbl.UseMnemonic = False
        '
        'Usernamebox
        '
        Me.Usernamebox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Usernamebox.Location = New System.Drawing.Point(321, 156)
        Me.Usernamebox.Name = "Usernamebox"
        Me.Usernamebox.Size = New System.Drawing.Size(258, 35)
        Me.Usernamebox.TabIndex = 2
        '
        'Passwordbox
        '
        Me.Passwordbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Passwordbox.Location = New System.Drawing.Point(321, 225)
        Me.Passwordbox.Name = "Passwordbox"
        Me.Passwordbox.Size = New System.Drawing.Size(258, 35)
        Me.Passwordbox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(118, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 39)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(167, 39)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Password"
        '
        'errortxt
        '
        Me.errortxt.AutoSize = True
        Me.errortxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errortxt.ForeColor = System.Drawing.Color.Red
        Me.errortxt.Location = New System.Drawing.Point(203, 278)
        Me.errortxt.Name = "errortxt"
        Me.errortxt.Size = New System.Drawing.Size(376, 29)
        Me.errortxt.TabIndex = 6
        Me.errortxt.Text = "Incorrect username and password"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(166, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.errortxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Passwordbox)
        Me.Controls.Add(Me.Usernamebox)
        Me.Controls.Add(Me.Titlelbl)
        Me.Controls.Add(Me.Loginbtn)
        Me.Name = "Form1"
        Me.Text = "Login Page"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Loginbtn As Button
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents Titlelbl As Label
    Friend WithEvents Usernamebox As TextBox
    Friend WithEvents Passwordbox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents errortxt As Label
End Class
