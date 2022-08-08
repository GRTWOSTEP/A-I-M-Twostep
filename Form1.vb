Public Class Form1

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        If NumericUpDown1.Value > 0 And NumericUpDown2.Value > 0 Then
            Dim number As Decimal = Convert.ToDecimal(NumericUpDown1.Value) / Convert.ToDecimal(NumericUpDown2.Value)
            TextBox3.Text = number.ToString
            TextBox3.Refresh()
        End If
    End Sub

    Private Sub NumericUpDown2_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown2.ValueChanged
        If NumericUpDown1.Value > 0 And NumericUpDown2.Value > 0 Then
            Dim number As Decimal = Convert.ToDecimal(NumericUpDown1.Value) / Convert.ToDecimal(NumericUpDown2.Value)
            TextBox3.Text = number.ToString
            TextBox3.Refresh()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If NumericUpDown1.Value > 0 And NumericUpDown2.Value > 0 And TextBox3.TextLength > 0 Then
            Dim numbers As Decimal = Convert.ToDecimal(TextBox3.Text) - ((Convert.ToDecimal(TextBox3.Text) * Convert.ToDecimal(ComboBox2.Text)) / 100)
            TextBox4.Text = numbers.ToString
            TextBox4.Refresh()
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If NumericUpDown3.Value > 0 Then
            Dim numbers As Decimal = Convert.ToDecimal(NumericUpDown3.Value) - Convert.ToDecimal(ComboBox1.Text)
            TextBox6.Text = numbers.ToString
            TextBox6.Refresh()
        End If
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        If TextBox6.TextLength > 0 And TextBox4.Text > 0 Then
            Dim numbers As Decimal = Convert.ToDecimal(TextBox6.Text) * ((Convert.ToDecimal(TextBox4.Text) / 1000))
            TextBox7.Text = numbers.ToString
            TextBox7.Refresh()
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        If TextBox7.TextLength > 1 And NumericUpDown4.Value > 0 Then
            Dim numbers As Decimal = Convert.ToDecimal(TextBox7.Text) * (Convert.ToDecimal(NumericUpDown4.Value))
            TextBox9.Text = numbers.ToString
            TextBox9.Refresh()
        End If
    End Sub
    Private Sub NumericUpDown4_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown4.ValueChanged
        If TextBox7.TextLength > 1 And NumericUpDown4.Value > 0 Then
            Dim numbers As Decimal = Convert.ToDecimal(TextBox7.Text) * (Convert.ToDecimal(NumericUpDown4.Value))
            TextBox9.Text = numbers.ToString
            TextBox9.Refresh()
        End If
    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs) Handles NumericUpDown5.ValueChanged
        If TextBox9.TextLength > 1 And NumericUpDown5.Value > 0 Then
            Dim numbers As Decimal = Convert.ToDecimal(TextBox9.Text) / (Convert.ToDecimal(NumericUpDown5.Value))
            TextBox10.Text = numbers.ToString
            TextBox10.Refresh()
        End If
    End Sub

    Private Sub NumericUpDown6_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown6.ValueChanged
        If NumericUpDown6.Value > 0 And NumericUpDown17.Value > 0 Then
            Dim numbers As Decimal = (Convert.ToDecimal(TextBox4.Text) * Convert.ToDecimal(NumericUpDown4.Value)) * ((Convert.ToDecimal(NumericUpDown17.Value) / 1000) - 0.1)
            TextBox10.Text = numbers.ToString
            TextBox10.Refresh()
        End If
    End Sub

    Private Sub NumericUpDown17_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown17.ValueChanged
        If NumericUpDown6.Value > 0 And NumericUpDown17.Value > 0 Then
            Dim numbers As Decimal = (Convert.ToDecimal(TextBox4.Text) * Convert.ToDecimal(NumericUpDown4.Value)) * ((Convert.ToDecimal(NumericUpDown17.Value) / 1000) - 0.1)
            TextBox1.Text = numbers.ToString
            TextBox1.Refresh()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.TextLength > 0 And NumericUpDown5.Value > 0 Then
            Dim numbers As Decimal = Convert.ToDecimal(TextBox1.Text) / Convert.ToDecimal(NumericUpDown5.Value)
            TextBox18.Text = numbers.ToString
            TextBox18.Refresh()
        End If
    End Sub

    Private Sub NumericUpDown7_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown7.ValueChanged
        If NumericUpDown7.Value > 0 And NumericUpDown16.Value > 0 Then
            Dim numbers As Decimal = (Convert.ToDecimal(TextBox4.Text) * Convert.ToDecimal(NumericUpDown4.Value)) * ((Convert.ToDecimal(NumericUpDown16.Value) / 1000) - 0.1)
            TextBox10.Text = numbers.ToString
            TextBox10.Refresh()
        End If
    End Sub

    Private Sub NumericUpDown16_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown16.ValueChanged
        If NumericUpDown7.Value > 0 And NumericUpDown16.Value > 0 Then
            Dim numbers As Decimal = (Convert.ToDecimal(TextBox4.Text) * Convert.ToDecimal(NumericUpDown4.Value)) * ((Convert.ToDecimal(NumericUpDown16.Value) / 1000) - 0.1)
            TextBox2.Text = numbers.ToString
            TextBox2.Refresh()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox1.TextLength > 0 And NumericUpDown5.Value > 0 Then
            Dim numbers As Decimal = Convert.ToDecimal(TextBox2.Text) / Convert.ToDecimal(NumericUpDown5.Value)
            TextBox17.Text = numbers.ToString
            TextBox17.Refresh()
        End If
    End Sub
End Class
