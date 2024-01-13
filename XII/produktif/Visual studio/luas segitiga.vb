Public Class Form1

    Private Sub btn_hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hitung.Click
        Dim alas As Integer
        Dim tinggi As Integer
        Dim luas As Double

        alas = txt_alas.Text
        tinggi = txt_tinggi.Text

        luas = (alas * tinggi) / 2

        Me.txt_hasil.Text = luas
    End Sub
End Class
