Public Class AboutPage
    Private Sub AboutPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.AutoSize = False
        Label1.Height = 2
        Label1.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub btnGithub_Click(sender As Object, e As EventArgs) Handles btnGithub.Click
        Dim url As String = "http://github.com/Line-r/Line_rs-EU4-Modding-Toolkit"
        Process.Start("C:\Program Files\Internet Explorer\iexplore.exe", url)

    End Sub

    Private Sub btnDiscord_Click(sender As Object, e As EventArgs) Handles btnDiscord.Click
        Dim url As String = "https://discord.gg/GBMG5SbkmK"
        Process.Start("C:\Program Files\Internet Explorer\iexplore.exe", url)
    End Sub
End Class