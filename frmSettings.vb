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

        'Check checkbox depending on default profile setting
        If My.Settings.LoadProfileByDefault Then
            cbLoadProfileByDefault.Checked = True
        ElseIf My.Settings.LoadProfileByDefault = False Then
            cbLoadProfileByDefault.Checked = False
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

        'Show messagebox to confirm save and close settings
        MsgBox(messageboxStrings.returnMessageboxString("infoSettingsSaved", frmMain.Language), MsgBoxStyle.Information, "Saved settings")
        Close()
    End Sub

    Private Sub btnToggleLanguage_Click(sender As Object, e As EventArgs) Handles btnToggleLanguage.Click
        'Toggle language in the software. Please note that you should remove this from your software when implementing and use your own language selector.
        If frmMain.Language = "German" Then
            frmMain.Language = "English"
        ElseIf frmMain.Language = "English" Then
            frmMain.Language = "German"
        End If
        My.Settings.Language = frmMain.Language

        'Show confirmation message. This string is not contained in the messageboxStrings file as it should be removed.
        If frmMain.Language = "German" Then
            MsgBox("Toggled language. Please restart the application for this to take effect.", MsgBoxStyle.Information, "Toggled language")
        ElseIf frmMain.Language = "English" Then
            MsgBox("Sprache geändert. Bitte starte die App neu, damit die Einstellungen angewandt werden.", MsgBoxStyle.Information, "Sprache geändert")
        End If
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
        'Load German translations
        If frmMain.Language = "German" Then
            cbLoadProfileByDefault.Text = "Profil standartmäßig laden:"
            btnSave.Text = "Speichern"
            btnCancel.Text = "Abbrechen"
            btnToggleLanguage.Text = "Sprache ändern"
            Text = "Einstellungen"
        End If
    End Sub
End Class