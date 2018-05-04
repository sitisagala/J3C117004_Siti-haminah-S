Public Class FaktorFiboKuadrat

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim a, i, b, c, n, hasil As Integer
        a = 1
        For i = 1 To TextBox1.Text
            a = a * i

        Next i
        txtfaktorial.Text = a

        a = 0
        b = 1
        n = TextBox1.Text
        TextBox2.Text = a
        TextBox2.Text = b
        For i = 3 To n
            c = Val(a) + Val(b)
            TextBox2.Text = c
            a = b
            b = c
        Next i
        hasil = n * n

        txtkuadrat.Text = hasil


    End Sub

End Class