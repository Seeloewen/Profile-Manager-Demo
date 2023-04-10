Imports System.Environment

Public Class frmMain

    'Variables used by the software to work correctly
    Public AppData As String = GetFolderPath(SpecialFolder.ApplicationData)
    Public ProfileDirectory As String = AppData + "\Profile Manager Demo\Profiles\"
    Dim ProfileList As String()
    Dim messageboxStrings As New messageboxStrings
    Public Language As String = "English" 'This variable is used for the language across the software. You should replace this with your own translation system

    '-- Event handlers --
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load language
        Language = My.Settings.Language
        LoadTranslations()

        'Check if profile directory exists, if not, create it
        If My.Computer.FileSystem.DirectoryExists(ProfileDirectory) = False Then
            My.Computer.FileSystem.CreateDirectory(ProfileDirectory)
        End If

        'If default profile setting is set to true, try to load default profile. If not possible, it will disable default profile setting.
        If My.Settings.LoadProfileByDefault = True Then
            frmSettings.cbLoadProfileByDefault.Checked = True
            If String.IsNullOrEmpty(My.Settings.DefaultProfile) = False Then
                If My.Computer.FileSystem.FileExists(ProfileDirectory + My.Settings.DefaultProfile + ".txt") Then
                    frmSettings.cbxDefaultProfile.SelectedItem = My.Settings.DefaultProfile
                    frmLoadProfileFrom.InitializeLoadingProfile(My.Settings.DefaultProfile, False)
                Else
                    MsgBox(messageboxStrings.returnMessageboxString("errorDefaultProfileNoLongerExists", Language), MsgBoxStyle.Critical, "Error")
                    frmSettings.cbLoadProfileByDefault.Checked = False
                    My.Settings.LoadProfileByDefault = False
                End If
            Else
                MsgBox(messageboxStrings.returnMessageboxString("errorDefaultProfileEmpty", Language), MsgBoxStyle.Critical, "Error")
                frmSettings.cbLoadProfileByDefault.Checked = False
                My.Settings.LoadProfileByDefault = False
            End If
        End If
    End Sub

    Private Sub btnSaveProfile_Click(sender As Object, e As EventArgs) Handles btnSaveProfile.Click
        'Open save profile dialog
        frmSaveProfileAs.ShowDialog()
    End Sub

    Private Sub btnLoadProfile_Click(sender As Object, e As EventArgs) Handles btnLoadProfile.Click
        'Open load profile dialog
        frmLoadProfileFrom.ShowDialog()
    End Sub

    Private Sub btnOpenProfileEditor_Click(sender As Object, e As EventArgs) Handles btnOpenProfileEditor.Click
        'Show profile editor dialog
        frmProfileEditor.ShowDialog()
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        'Show settings dialog
        frmSettings.ShowDialog()
    End Sub

    '-- Custom methods --

    Private Sub LoadTranslations()
        'Load German translations
        If Language = "German" Then
            gbProfileDemo.Text = "Profil Demo"
            rbtn1.Text = "Option 1"
            rbtn2.Text = "Option 2"
            rbtn3.Text = "Option 3"
            cb1.Text = "Box 1"
            cb2.Text = "Box 2"
            btnSaveProfile.Text = "Profil speichern"
            btnLoadProfile.Text = "Profil laden"
            btnOpenProfileEditor.Text = "Profil Editor öffnen"
            btnSettings.Text = "Einstellungen"
        End If
    End Sub
End Class
