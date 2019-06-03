Public Class Form1
    Dim quesito(90) As Label
    Private Sub duplicarlabels()
        quesito(1).Left = 40
        quesito(1).Top = 40
        For i = 1 To 90
            quesito(i) = New Label()
            quesito(i).Visible = True

            quesito(i).Width = 80
            quesito(i).Height = 80
            quesito(i).Text = i
            If i <> 1 Then
                quesito(i).Left = quesito(i - 1).Left + 80
                quesito(i).Top = quesito(i - 1).Top + 80
            End If
        Next
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        duplicarlabels()
    End Sub
End Class
