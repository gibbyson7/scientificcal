Public Class Calculator
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtDisplay.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = 400
        txtDisplay.Width = 318
        Me.Text = "Standard Calculation"
    End Sub

    Private Sub button_Click(sender As Object, e As EventArgs) Handles Button8.Click, Button7.Click, Button6.Click, Button20.Click, Button16.Click, Button15.Click, Button14.Click, Button12.Click, Button11.Click, Button10.Click

        Dim b As Button = sender
        If txtDisplay.Text = "0" Then
            txtDisplay.Text = b.Text
        Else
            txtDisplay.Text = txtDisplay.Text + b.Text
        End If
    End Sub

    Private Sub Arith_Opera(sender As Object, e As EventArgs) Handles Button9.Click, Button5.Click, Button17.Click, Button13.Click

    End Sub
End Class
