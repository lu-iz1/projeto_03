﻿Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nota1, nota2, media As Double

        nota1 = CDbl(TextBox1.Text)
        nota2 = CDbl(TextBox2.Text)
        media = (nota1 + nota2) / 2
        Label4.Text = media
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
