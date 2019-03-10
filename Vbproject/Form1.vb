Public Class LoginPage

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim user As String = txtname.Text
        Dim pass As String = txtpassword.Text
        If user = "" Then
            MessageBox.Show("Enter your Username to Login", "Error Message")

        ElseIf pass = "" Then
            MessageBox.Show("Enter your Password to Login", "Error Message")
        ElseIf (user <> "Admin" Or pass <> "ADMIN") Then
            MessageBox.Show("Invalid Username or Password!", "Error in Login")
        Else
            MessageBox.Show("Successful Login!", "WELCOME")
            Visible = False
            Main.Show()
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub txtname_TextChanged(sender As Object, e As EventArgs) Handles txtname.TextChanged

    End Sub
End Class
