Public Class Perkalian
    Dim a As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a = 1
        While a <= 12
            ListBox1.Items.Add(a & " x " & TextBox1.Text & " = " & a * TextBox1.Text)
            a = a + 1
        End While

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = " "
        ListBox1.Items.Clear()

        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub
End Class