Public Class Form1

    Private Sub btn_proses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_proses.Click
        Dim a As String
        Dim b As String
        Dim c As String

        a = txt_a.Text
        b = txt_b.Text

        c = a + b

        Me.txt_hasil.text = c
    End Sub
End Class
