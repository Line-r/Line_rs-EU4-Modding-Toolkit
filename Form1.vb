Public Class Form1
    Dim ModDir As String
    Dim FlagDir As String



    Private Sub mnuOpen_Click(Sender As Object, e As EventArgs) Handles mnuOpen.Click

        If (fbdModDirectory.ShowDialog() = DialogResult.OK) Then
            ModDir = fbdModDirectory.SelectedPath
            btnGenerate.Enabled = True
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
        Dim AcceptedCulture As String
        Dim Capital As Integer
        Dim file As System.IO.StreamWriter

        CountryName = txtCountryName.Text
        Adjective = txtAdjective.Text
        CountryTag = txtTag.Text
        Color = txtColor.Text
        Mercantilism = CInt(txtMercantilism.Text)
        PrimaryCulture = txtPrimaryCulture.Text
        Capital = txtCapital.Text

        GraphCulture = cmbGraphicalCulture.SelectedItem.ToString.ToLower
        Government = cmbGovernment.SelectedItem.ToString.ToLower
        Techgroup = cmbTech.SelectedItem.ToString.ToLower
        Religion = cmbReligion.SelectedItem.ToString.ToLower


        If My.Computer.FileSystem.DirectoryExists(ModDir & "\common") = False Then
            My.Computer.FileSystem.CreateDirectory(ModDir & "\common")
        End If

        If My.Computer.FileSystem.DirectoryExists(ModDir & "\history") = False Then
            My.Computer.FileSystem.CreateDirectory(ModDir & "\history")
        End If

        If My.Computer.FileSystem.DirectoryExists(ModDir & "\history\countries") = False Then
            My.Computer.FileSystem.CreateDirectory(ModDir & "\history\countries")
        End If

        If My.Computer.FileSystem.DirectoryExists(ModDir & "\common\country_tags") = False Then
            My.Computer.FileSystem.CreateDirectory(ModDir & "\common\country_tags")
        End If

        If My.Computer.FileSystem.DirectoryExists(ModDir & "\common\countries") = False Then
            My.Computer.FileSystem.CreateDirectory(ModDir & "\common\countries")
        End If

        If My.Computer.FileSystem.DirectoryExists(ModDir & "\localisation") = False Then
            My.Computer.FileSystem.CreateDirectory(ModDir & "\localisation")
        End If



        If My.Computer.FileSystem.FileExists(ModDir & "\common\country_tags\generated.txt") = False Then 'Country tag file generation
            System.IO.File.Create(ModDir & "\common\country_tags\generated.txt").Dispose()
        End If

        If My.Computer.FileSystem.FileExists(ModDir & "\common\countries\" & CountryName & ".txt") = False Then 'Country file generation
            System.IO.File.Create(ModDir & "\common\countries\" & CountryName & ".txt").Dispose()
        End If

        If My.Computer.FileSystem.FileExists(ModDir & "\history\countries\" & CountryTag & " - " & CountryName & ".txt") = False Then 'Country history file generation
            System.IO.File.Create(ModDir & "\history\countries\" & CountryTag & " - " & CountryName & ".txt").Dispose()

        End If

        If My.Computer.FileSystem.FileExists(ModDir & "\localisation\" & "LEU4MT_generated_nations_l_english.yml") = False Then 'Country localisation file
            System.IO.File.Create(ModDir & "\localisation\" & "LEU4MT_generated_nations_l_english.yml").Dispose()

            'First line on localisation file
            file = My.Computer.FileSystem.OpenTextFileWriter(ModDir & "\localisation\" & "LEU4MT_generated_nations_l_english.yml", True)
            file.WriteLine("l_english:")
            file.Close()
        End If

        'Writes tag file
        file = My.Computer.FileSystem.OpenTextFileWriter(ModDir & "\common\country_tags\generated.txt", True)
        file.WriteLine(CountryTag & " = " & Chr(34) & "countries/" & CountryName & ".txt" & Chr(34))
        file.Close()

        'Writes country file
        file = My.Computer.FileSystem.OpenTextFileWriter(ModDir & "\common\countries\" & CountryName & ".txt", True)
        file.WriteLine("#" & CountryName & " Generated using LEU4MT")
        file.WriteLine("graphical_culture = " & GraphCulture)
        file.WriteLine("color = { " & Color & " }")

        'Monarchnames textbox to multiple lines
        If (txtMonarch.Lines.Count > 1) Then
            Monarchname = ""
            For Each line As String In txtMonarch.Lines
                Monarchname = Monarchname & " " & line & vbCrLf
            Next
            Monarchname = Monarchname.Trim()
        End If
        file.WriteLine("monarch_names = { ")
        file.WriteLine(Monarchname)
        file.WriteLine(" } ")

        'Same as above, but for leaders
        If (txtLeader.Lines.Count > 1) Then
            Leadername = ""
            For Each line As String In txtLeader.Lines
                Leadername = Leadername & " " & line & vbCrLf
            Next
            Leadername = Leadername.Trim()
        End If
        file.WriteLine("leader_names = { ")
        file.WriteLine(Leadername)
        file.WriteLine(" } ")





        file.Close()





        'Writes tag file
        file = My.Computer.FileSystem.OpenTextFileWriter(ModDir & "\common\country_tags\generated.txt", True)
        file.WriteLine(CountryTag & " = " & Chr(34) & "countries/" & CountryName & ".txt" & Chr(34))
        file.Close()

        'Writes history file
        file = My.Computer.FileSystem.OpenTextFileWriter(ModDir & "\history\countries\" & CountryTag & " - " & CountryName & ".txt", True)
        file.WriteLine("government = " & Government)
        file.WriteLine("mercantilism = " & CStr(Mercantilism))
        file.WriteLine("technology_group = " & Techgroup)
        file.WriteLine("religion = " & Religion)
        file.WriteLine("primary_culture = " & PrimaryCulture)

        If (txtAcceptedCulture.Lines.Count > 1) Then
            AcceptedCulture = ""
            For Each line As String In txtAcceptedCulture.Lines
                AcceptedCulture = AcceptedCulture & " " & line & vbCrLf
            Next
            AcceptedCulture = AcceptedCulture.Trim()
        End If
        file.WriteLine("add_accepted_culture = " & AcceptedCulture)
        'Ensure that above has add_accepted_culture before each line


        If chkFixed.Checked = False Then
            file.WriteLine("capital = " & CStr(Capital))
        Else
            file.WriteLine("fixed_capital = " & CStr(Capital))
        End If
        file.Close()

        'Wirtes localisation file
        file = My.Computer.FileSystem.OpenTextFileWriter(ModDir & "\localisation\" & "LEU4MT_generated_nations_l_english.yml", True)
        file.WriteLine(CountryTag & ": " & Chr(34) & CountryName & Chr(34))
        file.WriteLine(CountryTag & "_ADJ: " & Chr(34) & Adjective & Chr(34))
        file.Close()



        If My.Computer.FileSystem.DirectoryExists(ModDir & "\gfx") = False Then
            My.Computer.FileSystem.CreateDirectory(ModDir & "\gfx")
        End If

        If My.Computer.FileSystem.DirectoryExists(ModDir & "\gfx\flags") = False Then
            My.Computer.FileSystem.CreateDirectory(ModDir & "\gfx\flags")
        End If


        My.Computer.FileSystem.CopyFile(FlagDir, ModDir & "\gfx\flags\" & CountryTag & ".tga")
    End Sub

    Private Sub btnFlag_Click(sender As Object, e As EventArgs) Handles btnFlag.Click
        ofdFlag.Filter = "TGA Files|*.tga"

        If (ofdFlag.ShowDialog() = DialogResult.OK) Then
            FlagDir = ofdFlag.FileName
            imgFlag.Image = Image.FromFile(FlagDir)
        End If


    End Sub
End Class
