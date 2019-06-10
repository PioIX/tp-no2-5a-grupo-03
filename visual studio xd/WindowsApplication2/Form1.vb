Dim numberOfButtons As Integer
Dim buttons() As Button

Private Sub MyForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    ReDim buttons(numberOfButtons)
    For counter As Integer = 0 To numberOfButtons
        With buttons(counter)
            .Size = (10, 10)
            .Visible = False
            .Location = (55, 33 + counter * 13)
            .Text = "Button " + (counter + 1).ToString ' or some name from an array you pass from main
            'any other property
            AddHandler buttons(counter).Clicked AddressOf All_Buttons_Clicked
        End With
        '
    Next
End Sub