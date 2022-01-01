'+-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+'
'| Tool : Hide My IP                   |'
'| Coder : Adel Rehan                  |'
'| Forum : www.dev-point.com\AdelRehan |'
'| FaceBook : Facebook.com\Adel759     |'
'+-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-+'

Imports System.Net
Imports Microsoft.Win32
Imports System.Text.RegularExpressions

Public Class MainForm

    Dim wb As New WebClient

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Registry As RegistryKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Internet Settings", True)
        If Registry.GetValue("ProxyEnable", Nothing) = 1 Then
            Registry.SetValue("ProxyEnable", 0, RegistryValueKind.DWord)
            Registry.SetValue("ProxyServer", "http=;ftp=;https=;", RegistryValueKind.String)
            Registry.SetValue("Status", "Disable", RegistryValueKind.String)
        End If

        Try
            'http://www.antedes.com/getip.php
            Dim SourceCode As String = wb.DownloadString("http://clientn.easy-hideip.com/map/whatismyip.php")

            Dim ImageUrl As String
            Dim Country As String
            Dim RealIP As String

            Country = Regex.Match(SourceCode, "<div align=""left"">Country: (.+?)</div>", RegexOptions.IgnoreCase).Value
            Country = Country.Replace("<div align=""left"">Country: ", String.Empty).Replace("</div>", String.Empty)
            ImageUrl = Regex.Match(SourceCode, "src=""flag_short/(.+?)""", RegexOptions.IgnoreCase).Value
            ImageUrl = ImageUrl.Replace("src=""", String.Empty).Replace("""", String.Empty)
            ImageUrl = "http://clientn.easy-hideip.com/map/" & ImageUrl
            pcbRealCountry.Load(ImageUrl)

            RealIP = Regex.Match(SourceCode, "<p>\d+.\d+.\d+.\d+</p>", RegexOptions.IgnoreCase).Value
            RealIP = RealIP.Replace("<p>", Nothing).Replace("</p>", Nothing)
            lblRealIP.Text = RealIP

            My.Settings.RealIP = RealIP
            My.Settings.RealIPImage = ImageUrl
            My.Settings.Save()
        Catch ex As Exception
            lblRealIP.Text = My.Settings.RealIP
            If My.Settings.RealIPImage = "UnKnown" Then
                pcbRealCountry.Image = My.Resources.UnKnown
            Else
                pcbRealCountry.Load(My.Settings.RealIPImage)
            End If
        End Try

        'If My.Settings.Complete = 0 Then
        '    RefreshIP()
        'End If

        lblFakeIP.Text = My.Settings.IP.Split(":").GetValue(0)
        lblFakeLocation.Text = My.Settings.Country

        If My.Settings.Country.Contains(" ") Then
            pcbFakeCountry.Image = My.Resources.ResourceManager.GetObject(My.Settings.Country.Replace(" ", ""))
        Else
            pcbFakeCountry.Image = My.Resources.ResourceManager.GetObject(My.Settings.Country)
        End If
    End Sub

    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim Registry As RegistryKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Internet Settings", True)
        Registry.SetValue("ProxyEnable", 0, RegistryValueKind.DWord)
        Registry.SetValue("ProxyServer", "http=;ftp=;https=;", RegistryValueKind.String)
        Registry.SetValue("Status", "Disable", RegistryValueKind.String)
        Threading.Thread.Sleep(500)
        Registry.SetValue("Status", "None", RegistryValueKind.String)
    End Sub

    Function RefreshIP()
        Dim Url As String = "https://www.dropbox.com/s/ud01b7k09k3ns5y/ListOfIP.txt?dl=1"
        Dim SourceCode As String = wb.DownloadString(Url)

        For x As Integer = 0 To My.Settings.ListOfCountries.Count - 1
            Dim Country As String = My.Settings.ListOfCountries.Item(x)
            My.Settings(Country.Replace(" ", "")).Clear()
            Using txtString As New RichTextBox
                txtString.Text = "|" & System.Text.RegularExpressions.Regex.Match(SourceCode, "(?<=" & System.Text.RegularExpressions.Regex.Escape(Country & "||") & ").+?(?=" & System.Text.RegularExpressions.Regex.Escape("||") & ")", System.Text.RegularExpressions.RegexOptions.IgnoreCase).Value & "|"

                Dim Result As System.Text.RegularExpressions.MatchCollection = System.Text.RegularExpressions.Regex.Matches(txtString.Text, "(?<=" & System.Text.RegularExpressions.Regex.Escape("|") & ").+?(?=" & System.Text.RegularExpressions.Regex.Escape("|") & ")", System.Text.RegularExpressions.RegexOptions.IgnoreCase)
                For Each M As System.Text.RegularExpressions.Match In Result
                    My.Settings(Country.Replace(" ", "")).Add(M.Value)
                    My.Settings.Save()
                Next
            End Using
        Next

        My.Settings.Complete = 1
        My.Settings.Save()

        Return True
    End Function

    Private Sub lblCheckIPInfo_Click(sender As Object, e As EventArgs) Handles lblCheckIPInfo.Click
        Process.Start("http://clientn.easy-hideip.com/map/whatismyip.php")
    End Sub

    Private Sub btnChooseIPCountry_Click(sender As Object, e As EventArgs) Handles btnChooseIPCountry.Click
        ChooseIPCountryForm.ShowDialog()
    End Sub

    Private Sub btnHideIP_Click(sender As Object, e As EventArgs) Handles btnHideIP.Click
        If btnHideIP.Text = "Hide IP" Then

            btnHideIP.Text = "Stop Hide"

            lblInfo.Text = "Fake IP in use."
            lblInfo2.Text = "All your online activity is under protection."
            lblInfo2.Location = New Point(92, 116)

            Dim Country As String = My.Settings.Country.Replace(" ", "")

            Dim rnd = New Random()
            For i As Int32 = 1 To 10
                Dim RandomIP = My.Settings(Country)(rnd.Next(0, My.Settings(Country).Count))
                My.Settings.IP = RandomIP
                My.Settings.Save()
            Next
            lblFakeLocation.Text = My.Settings.Country
            lblFakeIP.Text = My.Settings.IP.Split(":").GetValue(0)
            pcbFakeCountry.Image = My.Resources.ResourceManager.GetObject(Country)

            Dim Registry As RegistryKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Internet Settings", True)
            Registry.SetValue("ProxyEnable", 1, RegistryValueKind.DWord)
            Registry.SetValue("MigrateProxy", 1, RegistryValueKind.DWord)
            Registry.SetValue("ProxyOverride", "local", RegistryValueKind.String)
            Registry.SetValue("ProxyServer", "http=" & My.Settings.IP & ";ftp=" & My.Settings.IP & ";https=" & My.Settings.IP & ";", RegistryValueKind.String)
            Registry.SetValue("IP", My.Settings.IP.Split(":").GetValue(0), RegistryValueKind.String)
            Registry.SetValue("Port", My.Settings.IP.Split(":").GetValue(1), RegistryValueKind.String)
            Registry.SetValue("Status", "Enable", RegistryValueKind.String)

        Else

            btnHideIP.Text = "Hide IP"

            lblInfo.Text = "Warning!"
            lblInfo2.Text = "You are currently not hiding your Real IP!"
            lblInfo2.Location = New Point(68, 116)

            Dim Registry As RegistryKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Internet Settings", True)
            Registry.SetValue("ProxyEnable", 0, RegistryValueKind.DWord)
            Registry.SetValue("ProxyServer", "http=;ftp=;https=;", RegistryValueKind.String)
            Registry.SetValue("Status", "Disable", RegistryValueKind.String)

        End If
    End Sub

    Private Sub btnUpdateIPLists_Click(sender As Object, e As EventArgs)
        RefreshIP()
        MessageBox.Show("Successfully updated IP lists!", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
