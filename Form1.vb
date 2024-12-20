Public Class Form1
    Dim a As Single
    Dim b As Single
    Dim op As String




    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        TextBox1.Text = ""
        a = "0"
        b = "0"

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        TextBox1.Text = (TextBox1.Text) + "4"

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        TextBox1.Text = (TextBox1.Text) + "0"

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox1.Text = (TextBox1.Text) + "."

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = (TextBox1.Text) + "1"
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        TextBox1.Text = (TextBox1.Text) + "2"

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        TextBox1.Text = (TextBox1.Text) + "3"

    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        TextBox1.Text = (TextBox1.Text) + "5"

    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        TextBox1.Text = (TextBox1.Text) + "6"

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        TextBox1.Text = (TextBox1.Text) + "7"

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox1.Text = (TextBox1.Text) + "8"

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox1.Text = (TextBox1.Text) + "9"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        a = Val(TextBox1.Text)
        op = "*"
        TextBox1.Text = ""
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        a = Val(TextBox1.Text)
        op = "+"
        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a = Val(TextBox1.Text)
        op = "-"
        TextBox1.Text = ""
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        a = Val(TextBox1.Text)
        op = "/"
        TextBox1.Text = ""
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        b = Val(TextBox1.Text)
        If op = "+" Then
            TextBox1.Text = a + b
        ElseIf op = "-" Then
            TextBox1.Text = a - b
        ElseIf op = "/" Then
            TextBox1.Text = a / b
        ElseIf op = "*" Then
            TextBox1.Text = a * b
        ElseIf op = "^" Then
            TextBox1.Text = a ^ b
        ElseIf op = "mod" Then
            TextBox1.Text = a Mod b

        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Me.Close()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        a = Val(TextBox1.Text)
        op = "^"
        TextBox1.Text = ""
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        a = Val(TextBox1.Text)
        op = "mod"
        TextBox1.Text = ""
    End Sub
End Class
