Imports System.IO

Public Class frmSettings

    'Variables used by the application to work correctly
    Dim ProfileDirectory As String = frmMain.AppData + "\Profile Manager Demo\Profiles\" 'This is the directory, where the profile files are being stored
    Dim ProfileList As String()

    'This code should be implemented in your applications settings
    Private Sub frmSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        'Show messagebox to confirm save
        MsgBox("Saved settings!")
    End Sub

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
            MsgBox("Error: Could not load profiles. Please try again." + vbNewLine + "Exception: " + ex.Message)
        End Try
    End Sub
End Class