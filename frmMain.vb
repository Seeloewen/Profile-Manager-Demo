Imports System.Environment

Public Class frmMain

    'Variables used by the software to work correctly
    Public AppData As String = GetFolderPath(SpecialFolder.ApplicationData)
    Public ProfileDirectory As String = AppData + "\Profile Manager Demo\Profiles\"
    Dim ProfileList As String()

    '-- Event handlers --

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    MsgBox("Error: Default profile no longer exists. Option will be disabled automatically.", MsgBoxStyle.Critical, "Error")
                    frmSettings.cbLoadProfileByDefault.Checked = False
                    My.Settings.LoadProfileByDefault = False
                End If
            Else
                MsgBox("Error: Could not load default profile as it is empty. Option will be disabled automatically.", MsgBoxStyle.Critical, "Error")
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
End Class
