Public Class Form1
    Dim ModDir As String


    Private Sub mnuOpen_Click(Sender As Object, e As EventArgs) Handles mnuOpen.Click

        If (fbdModDirectory.ShowDialog() = DialogResult.OK) Then
            ModDir = fbdModDirectory.SelectedPath
            Label14.Text = ModDir
        End If


    End Sub

    Private Sub btnGenerate_Click(sender As Object, e As EventArgs) Handles btnGenerate.Click
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
        Dim Religion As String
        Dim PrimaryCulture As String
        Dim Capital As Integer


        CountryName = txtCountryName.Text
        Adjective = txtAdjective.Text
        CountryTag = txtTag.Text
        Color = txtColor.Text
        Monarchname = txtMonarch.Text
        Leadername = txtLeader.Text
        Mercantilism = CInt(txtMercantilism.Text)
        PrimaryCulture = txtPrimaryCulture.Text
        Capital = txtCapital.Text

        GraphCulture = cmbGraphicalCulture.SelectedItem.ToString
        Government = cmbGovernment.SelectedItem.ToString
        Techgroup = cmbTech.SelectedItem.ToString
        Religion = cmbReligion.SelectedItem.ToString

        If My.Computer.FileSystem.DirectoryExists(ModDir & "\common") = False Then
            My.Computer.FileSystem.CreateDirectory(ModDir & "\common")
            My.Computer.FileSystem.CreateDirectory(ModDir & "\common\country_tags")
            System.IO.File.Create(ModDir & "\common\country_tags\generated.txt").Dispose()
        End If



        Dim file As System.IO.StreamWriter
        file = My.Computer.FileSystem.OpenTextFileWriter(ModDir & "\common\country_tags\generated.txt", True)
        file.WriteLine(CountryTag & " = " & Chr(34) & "countries/" & CountryName & ".txt" & Chr(34))
        file.Close()
    End Sub
End Class
