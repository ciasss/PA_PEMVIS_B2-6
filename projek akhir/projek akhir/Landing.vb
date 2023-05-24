Public Class Landing
    Private Sub Landing_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.TopLevel = False
        Panel1.Controls.Add(Login)
        Login.BringToFront()
        Login.Show()
    End Sub
    Private Sub lblSignUp_Click(sender As Object, e As EventArgs) Handles lblSignUp.Click
        Register.TopLevel = False
        Panel1.Controls.Add(Register)
        Register.BringToFront()
        Register.Show()
    End Sub
End Class
