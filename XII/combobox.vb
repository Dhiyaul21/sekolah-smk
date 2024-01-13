Public Class Form1
    Private Sub btn_cek_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cek.Click
        Select Case cmb_merk.Text
            Case "01"
                txt_nama.Text = "Iphone"
                txt_harga.Text = "Rp. 20.000.000,-"
            Case "02"
                txt_nama.Text = "Samsung"
                txt_harga.Text = "Rp. 19.000.000,-"
            Case "03"
                txt_nama.Text = "Realme"
                txt_harga.Text = "Rp. 18.000.000,-"
            Case "04"
                txt_nama.Text = "Infinix"
                txt_harga.Text = "Rp. 17.000.000,-"
            Case "05"
                txt_nama.Text = "Oppo"
                txt_harga.Text = "Rp. 16.000.000,-"
        End Select
    End Sub
End Class
