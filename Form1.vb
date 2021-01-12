Public Class Form1
    Dim aboutpage As New AboutPage
    Dim ModDir As String
    Dim FlagDir As String



    Private Sub mnuOpen_Click(Sender As Object, e As EventArgs) Handles mnuOpen.Click

        If (fbdModDirectory.ShowDialog() = DialogResult.OK) Then
            ModDir = fbdModDirectory.SelectedPath
            btnGenerate.Enabled = True
            btnGenerateDecision.Enabled = True
        End If


    End Sub

    Private Sub mnuAbout_Click(Sender As Object, e As EventArgs) Handles mnuAbout.Click
        aboutpage.ShowDialog()

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
        Dim Ideas As String
        Dim Units As String
        Dim Capital As Integer
        Dim History As String
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

        If (txtIdeas.Lines.Count > 1) Then
            Ideas = ""
            For Each line As String In txtIdeas.Lines
                Ideas = Ideas & line & vbCrLf
            Next
            Ideas = Ideas.Trim()
        End If
        file.WriteLine("historical_idea_groups = { ")
        file.WriteLine(Ideas)
        file.WriteLine(" } ")

        If (txtUnits.Lines.Count > 1) Then
            Units = ""
            For Each line As String In txtUnits.Lines
                Units = Units & line & vbCrLf
            Next
            Units = Units.Trim()
        End If
        file.WriteLine("historical_units = { ")
        file.WriteLine(Units)
        file.WriteLine(" } ")

        'Monarchnames textbox to multiple lines
        If (txtMonarch.Lines.Count > 1) Then
            Monarchname = ""
            For Each line As String In txtMonarch.Lines
                Monarchname = Monarchname & line & vbCrLf
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
                Leadername = Leadername & line & vbCrLf
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
                AcceptedCulture = AcceptedCulture & "add_accepted_culture = " & line & vbCrLf
            Next
            AcceptedCulture = AcceptedCulture.Trim()

        Else
            AcceptedCulture = txtAcceptedCulture.Text
            AcceptedCulture = "add_accepted_culture = " & AcceptedCulture
        End If
        file.WriteLine(AcceptedCulture)

        file.WriteLine("capital = " & CStr(Capital))
        If chkFixed.Checked Then
            file.WriteLine("fixed_capital = " & CStr(Capital))
        End If

        If (txtHistory.Lines.Count > 1) Then
            History = ""
            For Each line As String In txtHistory.Lines
                History = History & line & vbCrLf
            Next
            History = History.Trim()
        End If
        file.WriteLine(History)
        file.Close()


        'Writes localisation file
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

    Private Sub btnAdvancedHistory_Click(sender As Object, e As EventArgs) Handles btnAdvancedHistory.Click
        grbAdvancedHistory.Visible = True
    End Sub

    Private Sub btnGenerateDecision_Click(sender As Object, e As EventArgs) Handles btnGenerateDecision.Click
        Dim file As System.IO.StreamWriter
        Dim DecisionFile As String = txtDecisionFile.Text
        Dim DecisionTitle As String = txtDecisionTitle.Text
        Dim DecisionDesc As String = txtDescription.Text
        Dim Potential As String = txtPotential.Text
        Dim Allow As String = txtAllow.Text
        Dim Effect As String = txtEffect.Text
        Dim AIImportance As Integer = txtAIImportance.Text


        If My.Computer.FileSystem.DirectoryExists(ModDir & "\decisions") = False Then
            My.Computer.FileSystem.CreateDirectory(ModDir & "\decisions")
        End If

        If My.Computer.FileSystem.FileExists(ModDir & "\decisions\" & DecisionFile) = False Then
            System.IO.File.Create(ModDir & "\decisions\" & DecisionFile & ".txt").Dispose()
        End If


        file = My.Computer.FileSystem.OpenTextFileWriter(ModDir & "\decisions\" & DecisionFile & ".txt", True)
        file.WriteLine("country_decisions = {")
        file.WriteLine(DecisionTitle & " = {")

        If chkMajor.Checked = True Then
            file.WriteLine("major = yes")
        Else
            file.WriteLine("major = no")
        End If

        'Potential
        If (txtPotential.Lines.Count > 1) Then
            Potential = ""
            For Each line As String In txtPotential.Lines
                Potential = Potential & line & vbCrLf
            Next
            Potential = Potential.Trim()
        End If
        file.WriteLine("potential = { ")
        file.WriteLine(Potential)
        file.WriteLine(" } ")


        'Allow
        If (txtAllow.Lines.Count > 1) Then
            Allow = ""
            For Each line As String In txtAllow.Lines
                Allow = Allow & line & vbCrLf
            Next
            Allow = Allow.Trim()
        End If
        file.WriteLine("allow = { ")
        file.WriteLine(Allow)
        file.WriteLine(" } ")


        'Effect
        If (txtEffect.Lines.Count > 1) Then
            Effect = ""
            For Each line As String In txtEffect.Lines
                Effect = Effect & line & vbCrLf
            Next
            Effect = Effect.Trim()
        End If
        file.WriteLine("effect = { ")
        file.WriteLine(Effect)
        file.WriteLine(" } ")

        file.WriteLine("ai_will_do = {")
        If chkAIWillDo.Checked = True Then
            file.WriteLine("factor = 1")

        Else
            file.WriteLine("factor = 0")

        End If
        file.WriteLine("}")

        file.WriteLine("ai_importance = " & CStr(AIImportance))


        file.WriteLine("    }")
        file.WriteLine("}")

        file.Close()



        If My.Computer.FileSystem.DirectoryExists(ModDir & "\localisation") = False Then
            My.Computer.FileSystem.CreateDirectory(ModDir & "\localisation")
        End If

        If My.Computer.FileSystem.FileExists(ModDir & "\localisation\" & "LEU4MT_generated_decisions_l_english.yml") = False Then 'Country localisation file
            System.IO.File.Create(ModDir & "\localisation\" & "LEU4MT_generated_decisions_l_english.yml").Dispose()

            'First line on localisation file
            file = My.Computer.FileSystem.OpenTextFileWriter(ModDir & "\localisation\" & "LEU4MT_generated_decisions_l_english.yml", True)
            file.WriteLine("l_english:")
            file.Close()
        End If

        file = My.Computer.FileSystem.OpenTextFileWriter(ModDir & "\localisation\" & "LEU4MT_generated_decisions_l_english.yml", True)
        file.WriteLine(DecisionTitle & "_title: " & Chr(34) & DecisionTitle & Chr(34))
        file.WriteLine(DecisionTitle & "_desc: " & Chr(34) & DecisionDesc & Chr(34))
        file.Close()
    End Sub

    Private Sub btnPotTagPreset_Click(sender As Object, e As EventArgs) Handles btnPotTagPreset.Click
        txtPotential.Text += "tag = "
    End Sub

    Private Sub btnPotOwnsCore_Click(sender As Object, e As EventArgs) Handles btnPotOwnsCore.Click
        txtPotential.Text += "owns_core_province = "
    End Sub

    Private Sub btnPotExists_Click(sender As Object, e As EventArgs) Handles btnPotExists.Click
        txtPotential.Text += "exists = "
    End Sub

    Private Sub btnPotSubject_Click(sender As Object, e As EventArgs) Handles btnPotSubject.Click
        txtPotential.Text += "is_subject = "
    End Sub

    Private Sub btnPotFlag_Click(sender As Object, e As EventArgs) Handles btnPotFlag.Click
        txtPotential.Text += "has_country_flag = "
    End Sub

    Private Sub btnPotModifier_Click(sender As Object, e As EventArgs) Handles btnPotModifier.Click
        txtPotential.Text += "has_country_modifier = "
    End Sub

    Private Sub btnPotNot_Click(sender As Object, e As EventArgs) Handles btnPotNot.Click
        txtPotential.Text += "NOT = {   }"
    End Sub

    Private Sub btnPotOR_Click(sender As Object, e As EventArgs) Handles btnPotOR.Click
        txtPotential.Text += "OR = {   }"
    End Sub

    Private Sub btnPotAND_Click(sender As Object, e As EventArgs) Handles btnPotAND.Click
        txtPotential.Text += "AND = {   }"
    End Sub

    Private Sub btnAllowStab_Click(sender As Object, e As EventArgs) Handles btnAllowStab.Click
        txtAllow.Text += "stability = "
    End Sub

    Private Sub btnAllowCore_Click(sender As Object, e As EventArgs) Handles btnAllowCore.Click
        txtAllow.Text += "owns_core_province = "
    End Sub

    Private Sub btnAllowUnion_Click(sender As Object, e As EventArgs) Handles btnAllowUnion.Click
        txtAllow.Text += "senior_union_with = "
    End Sub

    Private Sub btnAllowColonial_Click(sender As Object, e As EventArgs) Handles btnAllowColonial.Click
        txtAllow.Text += "is_colony = "
    End Sub

    Private Sub btnAllowCulture_Click(sender As Object, e As EventArgs) Handles btnAllowCulture.Click
        txtAllow.Text += "primary_culture = "
    End Sub

    Private Sub btnAllowAI_Click(sender As Object, e As EventArgs) Handles btnAllowAI.Click
        txtAllow.Text += "ai = "
    End Sub

    Private Sub btnAllowNOT_Click(sender As Object, e As EventArgs) Handles btnAllowNOT.Click
        txtAllow.Text += "NOT = {   }"
    End Sub

    Private Sub btnAllowOR_Click(sender As Object, e As EventArgs) Handles btnAllowOR.Click
        txtAllow.Text += "OR = {   }"
    End Sub

    Private Sub btnAllowAND_Click(sender As Object, e As EventArgs) Handles btnAllowAND.Click
        txtAllow.Text += "AND = {   }"
    End Sub

    Private Sub btnEffectTag_Click(sender As Object, e As EventArgs) Handles btnEffectTag.Click
        txtEffect.Text += "change_tag = "
    End Sub

    Private Sub btnEffectAdvisor_Click(sender As Object, e As EventArgs) Handles btnEffectAdvisor.Click
        txtEffect.Text += "create_advisor = "
    End Sub

    Private Sub btnEffectInherit_Click(sender As Object, e As EventArgs) Handles btnEffectInherit.Click
        txtEffect.Text += "inherit = "
    End Sub

    Private Sub btnEffectAlliance_Click(sender As Object, e As EventArgs) Handles btnEffectAlliance.Click
        txtEffect.Text += "create_alliance = "
    End Sub

    Private Sub btnEffectFlag_Click(sender As Object, e As EventArgs) Handles btnEffectFlag.Click
        txtEffect.Text += "set_country_flag = "
    End Sub

    Private Sub btnEffectModifier_Click(sender As Object, e As EventArgs) Handles btnEffectModifier.Click
        txtEffect.Text += "add_country_modifier = { }"
    End Sub

    Private Sub btnEffectNOT_Click(sender As Object, e As EventArgs) Handles btnEffectNOT.Click
        txtEffect.Text += "NOT = {   }"
    End Sub

    Private Sub btnEffectOR_Click(sender As Object, e As EventArgs) Handles btnEffectOR.Click
        txtEffect.Text += "OR = {   }"
    End Sub

    Private Sub btnEffectAND_Click(sender As Object, e As EventArgs) Handles btnEffectAND.Click
        txtEffect.Text += "AND = {   }"
    End Sub
End Class
