Public Class Form1

    Private Sub btn_hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hitung.Click
        Dim panjang As Integer
        Dim lebar As Integer
        Dim luas As Integer

        panjang = txt_panjang.Text
        lebar = txt_lebar.Text

        luas = panjang * lebar

        Me.txt_hasil.Text = luas
    End Sub
End Class
