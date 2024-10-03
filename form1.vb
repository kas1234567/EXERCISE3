Public Class Form1
    'For loop
    'this displays numbers from 1 to 10
    Private Sub btnCount_Click(sender As Object, e As EventArgs) Handles btnCount.Click
        Dim count As Integer
        For count = 1 To 10
            txtNumber.Text = count
            'diplay msgbox
            MessageBox.Show("number" & count)
        Next
    End Sub



    'Exercise ii,
    'while loop
    'A programe that asks a user to for number and then counts down to zero
    Private Sub btnCounting_Click(sender As Object, e As EventArgs) Handles btnCounting.Click
        Dim cont As Integer = 0
        cont = txtNum1.Text
        While cont
            cont = (cont - 1)
            txtNum1.Text = cont
            'display number in textbox and msg box
            MessageBox.Show("Count" & cont)
        End While

    End Sub

End Class
