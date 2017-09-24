Public Class LoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.


    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        username.Focus()
    End Sub

    Private Sub BunifuFlatButton3_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton3.Click
        Application.Exit()
    End Sub

    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        username.ResetText()
        katasandi.ResetText()
        username.Focus()
    End Sub

    Private Sub katasandi_OnValueChanged(sender As Object, e As EventArgs) Handles katasandi.OnValueChanged
        katasandi.isPassword = True
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        If username.Text = "" Or katasandi.Text = "" Then
            alert.Visible = True
            alert.Text = "Form tidak boleh dikosongkan !"
            username.ResetText()
            katasandi.ResetText()
            username.Focus()
            Exit Sub
        ElseIf username.Text = "admin" And katasandi.Text = "admin" Then
            TransaksiForm.Show()
            username.ResetText()
            katasandi.ResetText()
            username.Focus()
            Me.Visible = False

        Else
            alert.Visible = True
            alert.Text = "Username / Kata sandi salah, silahkan ulangi !"
            username.ResetText()
            katasandi.ResetText()
            username.Focus()
            Exit Sub
        End If
    End Sub
End Class
