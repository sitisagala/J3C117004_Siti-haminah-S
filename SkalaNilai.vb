Public Class SkalaNilai

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a As Integer
        a = txtnilai.Text

        Select Case a
            Case 0 To 20
                TextBox1.Text = " Anda Mendapat Nilai E"
            Case 21 To 35
                TextBox1.Text = " Anda Mendapat Nilai D"
            Case 36 To 45
                TextBox1.Text = " Anda Mendapat Nilai C"
            Case 46 To 55
                TextBox1.Text = " Anda Mendapat Nilai BC"
            Case 56 To 70
                TextBox1.Text = " Anda Mendapat Nilai B"
            Case 71 To 75
                TextBox1.Text = " Anda Mendapat Nilai AB"
            Case 76 To 100
                TextBox1.Text = " Anda Mendapat Nilai A"
            Case Else
                TextBox1.Text = " Nilai Hanya Sampai 100"

        End Select
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtnilai.Text = " "
        TextBox1.Text = " "
        txtnilai.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub
End Class
