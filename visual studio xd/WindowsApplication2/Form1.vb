Public Class Form1
    Dim quesito(90) As Label
    Private Sub duplicarlabels()

        For i = 1 To 90
            quesito(i) = New Label()
            Me.Controls.Add(quesito(i))
            quesito(1).Left = 20
            quesito(1).Top = 20
            quesito(i).Visible = True
            quesito(i).Width = 40
            quesito(i).Height = 40
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
