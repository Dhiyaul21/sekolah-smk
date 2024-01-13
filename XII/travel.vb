Public Class Form1
    Private Sub cmb_tujuan_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_tujuan.SelectedIndexChanged
        If cmb_maskapai.Text = "Garuda" Then
            If cmb_tujuan.Text = "Medan-Padang" Then
                txt_harga.Text = "RP. 700.000,-"
            ElseIf cmb_tujuan.Text = "Medan-Jakarta" Then
                txt_harga.Text = "RP. 850.000,-"
            ElseIf cmb_tujuan.Text = "Medan-Bali" Then
                txt_harga.Text = "RP. 900.000,-"
            End If
        ElseIf cmb_maskapai.Text = "Lion" Then
            If cmb_tujuan.Text = "Medan-Padang" Then
                txt_harga.Text = "RP. 600.000,-"
            ElseIf cmb_tujuan.Text = "Medan-Jakarta" Then
                txt_harga.Text = "RP. 750.000,-"
            ElseIf cmb_tujuan.Text = "Medan-Bali" Then
                txt_harga.Text = "RP. 800.000,-"
            End If
        ElseIf cmb_maskapai.Text = "Sriwijaya" Then
            If cmb_tujuan.Text = "Medan-Padang" Then
                txt_harga.Text = "RP. 600.000,-"
            ElseIf cmb_tujuan.Text = "Medan-Jakarta" Then
                txt_harga.Text = "RP. 750.000,-"
            ElseIf cmb_tujuan.Text = "Medan-Bali" Then
                txt_harga.Text = "RP. 800.000,-"
            End If
        End If
    End Sub
End Class
