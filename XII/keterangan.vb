Public Class Form1

    Private Sub btn_proses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_proses.Click
        Dim nilai As Integer
        Dim ket As String

        nilai = txt_nilai.Text

        If nilai > 80 Then
            ket = "A"
        ElseIf nilai >= 66 Then
            ket = "b"
        ElseIf nilai >= 54 Then
            ket = "c"
        Else
            ket = "d"
        End If

        txt_hasil.Text = ket
    End Sub
End Class
