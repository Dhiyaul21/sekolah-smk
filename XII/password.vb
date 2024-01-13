Public Class Form1

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub btn_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_login.Click
        Dim username As String
        Dim password As String

        username = txt_username.Text
        password = txt_password.Text

        If username = "aul" Or password = "ciciko" Then
            MsgBox("anda berhasil login")
        ElseIf username = "ual" Or password = "okoci" Then
            MsgBox("anda admin")
        Else
            MsgBox("gagal login")
        End If
    End Sub
End Class
