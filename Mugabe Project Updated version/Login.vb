Public Class Login

    Private Sub password_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles password.TextChanged

    End Sub

    Private Sub username_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles username.TextChanged

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If username.Text = "Tafadzwa" And password.Text = "Receptionist" Then
            MsgBox("Welcome back" & username.Text, MsgBoxStyle.OkCancel)
            Main_Menu.Show() 'opens Main menu when receptionist inputs his password and username
        ElseIf username.Text = "Tanatswa" And password.Text = "Manager" Then
            MsgBox("Welcome back" & username.Text, MsgBoxStyle.OkCancel)
            Managers_Menu.Show() 'opens Managers menu when manager inputs his password and username
        Else : MsgBox("The username or passsword you have entered is wrong", MsgBoxStyle.Critical)
        End If
    End Sub


    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        If username.Text = "Tafadzwa" And password.Text = "Receptionist" Then
            MsgBox("WELCOME")
            Me.Hide()
            Main_Menu.Show() 'opens Main menu when receptionist inputs his password and username
        ElseIf username.Text = "Tanatswa" And password.Text = "Manager" Then
            MsgBox("Welcome Back Tanatswa", MsgBoxStyle.Information)
            Me.Hide()
            Managers_Menu.Show() 'opens Managers menu when manager inputs his password and username
        ElseIf username.Text = "" And password.Text = "" Then
            MsgBox("Please Fill in the required fields", vbCritical)
        Else : MsgBox("The username or passsword you have entered is wrong", vbCritical)
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        username.Clear() 'clears username textbox
        password.Clear() 'clears password textbox
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Managers_Menu.Show()

    End Sub
End Class
