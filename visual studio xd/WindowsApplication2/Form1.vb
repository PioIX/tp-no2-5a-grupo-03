Public Class Form1
    Dim j As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim botones As New List(Of Button)
        Dim boton As New Button()
        For k = 0 To 9 Step 1

            For l = 0 To 9 Step 1
                j = l & k
                If l & k = 100 Then
                    boton.Text = 100
                Else
                    boton.Text = j + 1
                End If
                boton.Location = New Point(k * 80, l * 60)
                botones.Add(boton)
                boton.Enabled = True
                boton.Height = 60
                boton.Width = 80
                boton.Font = New Font("Arial", 20, FontStyle.Bold)
                boton = New Button()
                Me.Controls.AddRange(botones.ToArray())
            Next

        Next

    End Sub



End Class
