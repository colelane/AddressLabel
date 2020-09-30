'Lane Coleman
'RCET 0265
'Fall 2020
'Address Label Generator
'https://github.com/colelane/AddressLabel.git
Public Class AddressLabelForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click


        If FirstNameTextBox.Text = Nothing Or LastNameTextBox.Text = Nothing Or
            StreetAddressTextBox.Text = Nothing Or CityTextBox.Text = Nothing _
            Or StateTextBox.Text = Nothing Or ZipTextBox.Text = Nothing Then
            MsgBox("Please fill out all fields.")
            Exit Sub
        End If

        DisplayLabel.Text = FirstNameTextBox.Text & " " & LastNameTextBox.Text &
            vbNewLine & StreetAddressTextBox.Text & vbNewLine & CityTextBox.Text &
            ", " & StateTextBox.Text & " " & ZipTextBox.Text

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayLabel.Text = Nothing
    End Sub


End Class
