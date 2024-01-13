Public Class Form1

    Private Sub cmd_merk_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd_merk.SelectedIndexChanged
        If cmb_jenis.Text = "Gaming" Then
            If cmd_merk.Text = "Asus" Then
                txt_hasil.Text = "ROG,TUF"
            ElseIf cmd_merk.Text = "Lenovo" Then
                txt_hasil.Text = "Legion,IdepadGaming"
            ElseIf cmd_merk.Text = "MSI" Then
                txt_hasil.Text = "Titan"
            End If
        ElseIf cmb_jenis.Text = "Office" Then
            If cmd_merk.Text = "Asus" Then
                txt_hasil.Text = "VivoBook,ZenBook"
            ElseIf cmd_merk.Text = "Lenovo" Then
                txt_hasil.Text = "Ideapad,Thinkpad"
            ElseIf cmd_merk.Text = "MSI" Then
                txt_hasil.Text = "Modern"
            End If
        End If
    End Sub
End Class
