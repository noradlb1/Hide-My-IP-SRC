'+-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+'
'| Tool : Hide My IP                   |'
'| Coder : Adel Rehan                  |'
'| Forum : www.dev-point.com\AdelRehan |'
'| FaceBook : Facebook.com\Adel759     |'
'+-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+'

Public Class ChooseIPCountryForm

    Private Sub ChooseIPCountryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'cmbCountry.Items.Clear()

        'For Each item In My.Settings.ListOfCountries
        '    cmbCountry.Items.Add(item)
        'Next

        cmbCountry.SelectedItem = My.Settings.Country
    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click
        My.Settings.Country = cmbCountry.SelectedItem
        My.Settings.Save()
        Me.Close()
    End Sub
End Class