Imports System.IO

Public Class frmProfileEditor

    'Variables used by the software to work correctly
    Dim ProfileList As String()
    Dim ProfileContent As String()
    Dim LoadFromProfile As String
    Dim messageboxStrings As New messageboxStrings

    'Variables that store profile content
    Dim rbtn As String
    Dim cb1 As String
    Dim cb2 As String
    Dim tb1 As String


    '-- Event Handlers --

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Begin overwriting and saving the selected profile
        SaveProfile(cbxProfile.SelectedItem)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        'Close this window
        Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        'Delete the currently selected profile if it exists
        If My.Computer.FileSystem.FileExists(frmMain.ProfileDirectory + cbxProfile.SelectedItem + ".txt") Then
            My.Computer.FileSystem.DeleteFile(frmMain.ProfileDirectory + cbxProfile.SelectedItem + ".txt")
            MsgBox(messageboxStrings.returnMessageboxString("infoDeletedProfile", frmMain.Language), MsgBoxStyle.Information, "Deleted")
            cbxProfile.Items.Remove(cbxProfile.SelectedItem)
        Else
            MsgBox(messageboxStrings.returnMessageboxString("errorProfileDoesNotExist", frmMain.Language), MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub cbxProfile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProfile.SelectedIndexChanged
        'Begin loading the selected profile
        InitializeLoadingProfile(cbxProfile.SelectedItem, False)
    End Sub

    Private Sub frmProfileEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load translations
        LoadTranslations()

        'Reset the combobox and selected options
        cbxProfile.Items.Clear()
        rbtn1s.Checked = True
        cb1s.Checked = False
        cb2s.Checked = False
        tb1s.Text = ""
        'start getting the profiles
        GetFiles(frmMain.ProfileDirectory)
    End Sub

    '-- Custom Methods --

    Public Sub SaveProfile(ProfileName)
        'Set which radiobutton is selected
        If rbtn1s.Checked Then
            rbtn = "rbtn1"
        ElseIf rbtn2s.Checked Then
            rbtn = "rbtn2"
        ElseIf rbtn3s.Checked Then
            rbtn = "rbtn3"
        End If

        'Set wether checkboxes are checked or not
        If cb1s.Checked Then
            cb1 = "cb1Checked"
        Else
            cb1 = "cb1NotChecked"
        End If
        If cb2s.Checked Then
            cb2 = "cb2Checked"
        Else
            cb2 = "cb2NotChecked"
        End If

        'Set content based on textbox input, if textbox is empty it will be filled with a placeholder to avoid issues when loading
        If String.IsNullOrEmpty(tb1s.Text) Then
            tb1 = "None"
        Else
            tb1 = tb1s.Text
        End If

        'Update the selected profile. This will save and overwrite the selected profile without showing any warning or message.
        If String.IsNullOrEmpty(ProfileName) = False Then
            If My.Computer.FileSystem.DirectoryExists(frmMain.ProfileDirectory) Then
                My.Computer.FileSystem.WriteAllText(frmMain.ProfileDirectory + ProfileName + ".txt", rbtn + vbNewLine + cb1 + vbNewLine + cb2 + vbNewLine + tb1, False)
                MsgBox(messageboxStrings.returnMessageboxString("infoUpdatedSelectedProfile", frmMain.Language), MsgBoxStyle.Information, "Success")
            Else
                MsgBox(messageboxStrings.returnMessageboxString("errorProfileDirectoryDoesNotExist", frmMain.Language), MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox(messageboxStrings.returnMessageboxString("errorProfileNameIsEmpty", frmMain.Language), MsgBoxStyle.Critical, "Error")
        End If
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
                    Profile = Profile.Replace(Path, "")
                    Profile = Profile.Replace(".txt", "")
                    cbxProfile.Items.Add(Profile)
                End If
            Next
        Catch ex As Exception
            MsgBox(messageboxStrings.returnMessageboxString("errorLoadingProfilesFailed", frmMain.Language) + vbNewLine + "Exception: " + ex.Message)
        End Try
    End Sub

    Public Sub InitializeLoadingProfile(Profile As String, ShowMessage As Boolean)
        'Checks if a profile is selected. It then reads the content of the profile file into the array. To avoid errors with the array being too small, it gets resized. The number represents the amount of settings.
        'It then starts to convert and load the profile, see the the method below.
        If String.IsNullOrEmpty(Profile) = False Then
            LoadFromProfile = frmMain.ProfileDirectory + Profile + ".txt"
            ProfileContent = File.ReadAllLines(LoadFromProfile)
            ReDim Preserve ProfileContent(4)
            CheckAndConvertProfile(Profile, ShowMessage)
        Else
            MsgBox(messageboxStrings.returnMessageboxString("errorNoProfileSelected", frmMain.Language), MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Public Sub CheckAndConvertProfile(Profile As String, ShowMessage As Boolean)
        'This checks if the profile file that was loaded has enough lines, too few lines would mean that settings are missing, meaning the file is either too old or corrupted.
        'It will check for each required line if it is empty (required lines = the length of a healthy, normal profile file). Make sure that the line amount it checks matches the amount of settings that are being saved.
        'If a line is empty, it will fill that line with a placeholder in the array so the profile can get loaded without errors. After loading the profile, it gets automatically saved so the corrupted/old settings file gets fixed.
        'If no required line is empty and the file is fine, it will just load the profile like normal.
        If (String.IsNullOrEmpty(ProfileContent(0)) OrElse String.IsNullOrEmpty(ProfileContent(1)) OrElse String.IsNullOrEmpty(ProfileContent(2)) OrElse String.IsNullOrEmpty(3)) Then
            Select Case MsgBox(messageboxStrings.returnMessageboxString("questionLoadOldOrCorruptedProfile", frmMain.Language), vbQuestion + vbYesNo, "Load old or corrupted profile")
                Case Windows.Forms.DialogResult.Yes
                    If String.IsNullOrEmpty(ProfileContent(0)) Then
                        ProfileContent(0) = "rbtn1"
                    End If
                    If String.IsNullOrEmpty(ProfileContent(1)) Then
                        ProfileContent(1) = "cb1Checked"
                    End If
                    If String.IsNullOrEmpty(ProfileContent(2)) Then
                        ProfileContent(2) = "cb2NotChecked"
                    End If
                    If String.IsNullOrEmpty(ProfileContent(3)) Then
                        ProfileContent(3) = "Placeholder"
                    End If
                    LoadProfile(Profile, False)
                    SaveProfile(Profile)
                    MsgBox(messageboxStrings.returnMessageboxString("infoLoadedAndUpdatedProfile", frmMain.Language), MsgBoxStyle.Information, "Loaded And updated profile")
                Case Windows.Forms.DialogResult.No
                    MsgBox(messageboxStrings.returnMessageboxString("infoCancelledLoadingProfiles", frmMain.Language), MsgBoxStyle.Exclamation, "Warning")
            End Select
        Else
            LoadProfile(Profile, ShowMessage)
        End If
    End Sub

    Public Sub LoadProfile(Profile As String, ShowMessage As Boolean) 'This contains examples for loading different elements. Of course, you can use your own methods here.
        'Example for loading a radiobutton. The file stores which button is checked as a string, which is checked here. Depending on the string, a radiobutton will be selected.
        rbtn = ProfileContent(0)
        If rbtn = "rbtn1" Then
            rbtn1s.Checked = True
        ElseIf rbtn = "rbtn2" Then
            rbtn2s.Checked = True
        ElseIf rbtn = "rbtn3" Then
            rbtn3s.Checked = True
        End If

        'Examples for loading checkboxes. Same concept like the radiobuttons, the file stores if the button is checked or not and gets checked depending on the string when being loaded.
        cb1 = ProfileContent(1)
        If cb1 = "cb1Checked" Then
            cb1s.Checked = True
        ElseIf cb1 = "cb1NotChecked" Then
            cb1s.Checked = False
        End If
        cb2 = ProfileContent(2)
        If cb2 = "cb2Checked" Then
            cb2s.Checked = True
        ElseIf cb2 = "cb2NotChecked" Then
            cb2s.Checked = False
        End If

        'Example for loading a string (like a textbox)
        tb1s.Text = ProfileContent(3)

        'If ShowMessage is enabled, it will show a messagebox when loading completes.
        If ShowMessage Then
            MsgBox("Loaded profile " + Profile + ".", MsgBoxStyle.Information, "Loaded profile")
        End If
    End Sub

    Private Sub LoadTranslations()
        'Load German translations
        If frmMain.Language = "German" Then
            lblChooseProfile.Text = "Wähle das Profil, das du editieren möchtest:"
            gbEditProfile.Text = "Profil editieren"
            rbtn1s.Text = "Option 1"
            rbtn2s.Text = "Option 2"
            rbtn3s.Text = "Option 3"
            cb1s.Text = "Box 1"
            cb2s.Text = "Box 2"
            btnSave.Text = "Änderungen speichern"
            btnDelete.Text = "Profil löschen"
            btnClose.Text = "Schließen"
            Text = "Profil Editor"
        End If
    End Sub
End Class