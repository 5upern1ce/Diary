Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        errortxt.Hide()
    End Sub

    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles Loginbtn.Click
        If Usernamebox.Text = "Admin" And Passwordbox.Text = "Password" Then
            Dim newForm As New pg1()
            newForm.Show()
            Hide()
        Else
            errortxt.Show()
        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Usernamebox_TextChanged(sender As Object, e As EventArgs) Handles Usernamebox.TextChanged

    End Sub

    Private Sub Passwordbox_TextChanged(sender As Object, e As EventArgs) Handles Passwordbox.TextChanged

    End Sub

    Private Sub errortxt_Click(sender As Object, e As EventArgs) Handles errortxt.Click

    End Sub
End Class
