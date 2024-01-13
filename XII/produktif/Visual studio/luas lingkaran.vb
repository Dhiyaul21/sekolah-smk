Public Class Form1

    Private Sub btn_hitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_hitung.Click
        Dim jari As Integer
        Dim luas As Double

        jari = txt_jari.Text

        luas = 22 / 7 * jari * jari

        Me.txt_hasil.Text = luas
    End Sub
End Class
