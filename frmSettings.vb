Imports System.IO

'This code should be implemented in your applications settings

Public Class frmSettings

    'Variables used by the application to work correctly
    Dim ProfileDirectory As String = frmMain.AppData + "\Profile Manager Demo\Profiles\" 'This is the directory, where the profile files are being stored
    Dim ProfileList As String()
    Dim messageboxStrings As New messageboxStrings

    '-- Event Handlers --

    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load translations
        LoadTranslations()
        LoadDesign()

        'Check checkbox depending on default profile setting
        If My.Settings.LoadProfileByDefault Then
            cbLoadProfileByDefault.Checked = True
        ElseIf My.Settings.LoadProfileByDefault = False Then
            cbLoadProfileByDefault.Checked = False
        End If

        'Check checkbox depending on language setting
        If My.Settings.Language = "German" Then
            cbxLanguage.SelectedIndex = 0
        ElseIf My.Settings.Language = "English" Then
            cbxLanguage.SelectedIndex = 1
        End If

        'Check checkbox depending on design setting
        If My.Settings.Design = "System Default" Then
            cbxDesign.SelectedIndex = 0
        ElseIf My.Settings.Design = "Dark" Then
            cbxDesign.SelectedIndex = 1
        ElseIf My.Settings.Design = "Light" Then
            cbxDesign.SelectedIndex = 2
        End If

        'Clear profile list and get profile list for default profile combobox
        cbxDefaultProfile.Items.Clear()
        GetFiles(ProfileDirectory)

        'Load default profile
        cbxDefaultProfile.SelectedItem = My.Settings.DefaultProfile
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Close this window
        Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Change default profile setting if checkbox is changed
        If cbLoadProfileByDefault.Checked Then
            My.Settings.LoadProfileByDefault = True
        ElseIf cbLoadProfileByDefault.Checked = False Then
            My.Settings.LoadProfileByDefault = False
        End If

        'Change default profile to combobox selection
        My.Settings.DefaultProfile = cbxDefaultProfile.SelectedItem

        'Change language based on selection
        If cbxLanguage.SelectedIndex = 0 Then
            frmMain.Language = "German"
            My.Settings.Language = "German"
        ElseIf cbxLanguage.SelectedIndex = 1 Then
            frmMain.Language = "English"
            My.Settings.Language = "English"
        End If

        'Change design based on selection
        If cbxDesign.SelectedIndex = 0 Then
            frmMain.Design = frmMain.GetDesign()
            My.Settings.Design = "System Default"
        ElseIf cbxDesign.SelectedIndex = 1 Then
            frmMain.Design = "Dark"
            My.Settings.Design = "Dark"
        ElseIf cbxDesign.SelectedIndex = 2 Then
            frmMain.Design = "Light"
            My.Settings.Design = "Light"
        End If

        'Show messagebox to confirm save and close settings
        MsgBox(messageboxStrings.returnMessageboxString("infoSettingsSaved", frmMain.Language), MsgBoxStyle.Information, "Saved settings")
        Close()
    End Sub

    '-- Custom Methods --

    Sub GetFiles(Path As String)
        'Gets all the profile files from the directory and puts their name into the combobox
        If Path.Trim().Length = 0 Then
            Return
        End If

        ProfileList = Directory.GetFileSystemEntries(Path)

        Try
            For Each Profile As String In ProfileList
                If Directory.Exists(Profile) Then
                    GetFiles(Profile)
                Else
                    Profile = Profile.Replace(ProfileDirectory, "")
                    Profile = Profile.Replace(".txt", "")
                    cbxDefaultProfile.Items.Add(Profile)
                End If
            Next
        Catch ex As Exception
            MsgBox(messageboxStrings.returnMessageboxString("errorLoadingProfilesFailed", frmMain.Language) + vbNewLine + "Exception: " + ex.Message)
        End Try
    End Sub

    Private Sub LoadTranslations()
        If frmMain.Language = "German" Then
            'Load German translations
            cbLoadProfileByDefault.Text = "Profil standartmäßig laden:"
            btnSave.Text = "Speichern"
            btnCancel.Text = "Abbrechen"
            Text = "Einstellungen"
            lblDesign.Text = "Aussehen"
            lblLanguage.Text = "Sprache"
            cbxDesign.Items.Clear()
            cbxDesign.Items.Add("Systemstandard")
            cbxDesign.Items.Add("Dunkel")
            cbxDesign.Items.Add("Hell")
        ElseIf frmMain.Language = "English" Then
            'Load English translations
            cbxDesign.Items.Clear()
            cbxDesign.Items.Add("System Default")
            cbxDesign.Items.Add("Dark")
            cbxDesign.Items.Add("Light")
        End If
    End Sub

    Private Sub LoadDesign()
        If frmMain.Design = "Dark" Then
            'Switch all components to dark mode. Note that you will need to change the button design yourself.
            BackColor = Color.FromArgb(41, 41, 41)
            cbLoadProfileByDefault.ForeColor = Color.White
            lblLanguage.ForeColor = Color.White
            lblDesign.ForeColor = Color.White
            cbLoadProfileByDefault.ForeColor = Color.White
        End If
    End Sub
End Class