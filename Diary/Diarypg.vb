Public Class Diarypg
    Private Sub Diarypg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles targetsbx.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles moodbx.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles entrybx.TextChanged

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles Dateinputter.ValueChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles datelbl.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles nextbtn.Click

    End Sub

    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles Datechooser.ValueChanged

    End Sub

    Private Sub Loginbtn_Click(sender As Object, e As EventArgs) Handles backtomenubtn.Click
        Dim newForm As New pg1()
        newForm.Show()
        Hide()
    End Sub
End Class