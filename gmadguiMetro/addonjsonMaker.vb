Imports Newtonsoft.Json



Public Class addonjsonMaker
    Dim addonNameSet As String
    Dim addonCatSet As String
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        addonNameSet = addonName.Text
        addonCatSet = addonType.SelectedText

        JObject addonjson = New JObject(
            
        )
    End Sub
End Class