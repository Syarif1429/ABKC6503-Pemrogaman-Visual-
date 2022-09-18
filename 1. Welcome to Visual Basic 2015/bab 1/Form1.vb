Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblName.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object,
        ByVal e As System.EventArgs) Handles btnOK.Click
        'Display a message box greeting to the user
        MessageBox.Show("Hello, " & txtName.Text &
        "! Welcome to Visual Basic 2015.",
        "Hello User Message")
    End Sub

    Private Sub btnExit_Click(sender As Object,
        e As EventArgs) Handles btnExit.Click
        'End the program and close the form
        Me.Close()
    End Sub
End Class
