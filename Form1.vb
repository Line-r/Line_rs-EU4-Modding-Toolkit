Public Class Form1
    Dim CountryName As String
    Dim Adjective As String
    Dim CountryTag As String
    Dim GraphCulture As String
    Dim Color As String
    Dim Monarchname As String
    Dim Leadername As String
    Dim Government As String
    Dim Mercantilism As UInteger
    Dim Techgroup As String
    Dim PrimaryCulture As String
    Dim Capital As Integer

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
        CountryName = txtCountryName.Text
        Adjective = txtAdjective.Text
        CountryTag = txtTag.Text
        Color = txtColor.Text
        Monarchname = txtMonarch.Text

    End Sub
End Class
