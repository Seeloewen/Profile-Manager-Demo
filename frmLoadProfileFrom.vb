﻿Imports System.IO

Public Class frmLoadProfileFrom

    'Variables used by the application to work correctly
    Dim ProfileDirectory As String = frmMain.AppData + "\Profile Manager Demo\Profiles" 'This is the directory, where the profile files are being stored
    Dim ProfileList As String()
    Dim ProfileContent As String()
    Dim LoadFromProfile As String
    'Placeholders used for loading the settings
    Dim rbtn As String
    Dim cb1 As String
    Dim cb2 As String
    Dim tb1 As String

    Private Sub frmLoadProfileFrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Checks if the profile directory exists. If yes, it clears the combobox to avoid duplicates and it starts getting all available profiles, see method below
        If My.Computer.FileSystem.DirectoryExists(frmMain.AppData + "\Profile Manager Demo\Profiles") Then
            cbxProfiles.Items.Clear()
            GetFiles(ProfileDirectory)
        Else
            MsgBox("Error: Profile directory does not exist. Please restart the application.", MsgBoxStyle.Critical, "Error")
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
                    Profile = Profile.Replace(frmMain.AppData + "\Profile Manager Demo\Profiles\", "")
                    Profile = Profile.Replace(".txt", "")
                    cbxProfiles.Items.Add(Profile)
                End If
            Next
        Catch ex As Exception
            MsgBox("Error: Could not load profiles. Please try again." + vbNewLine + "Exception: " + ex.Message)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Closes the load window
        Close()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        'Starts the whole loading process
        InitializeLoadingProfile(cbxProfiles.SelectedItem, True)
    End Sub

    Public Sub InitializeLoadingProfile(Profile As String, ShowMessage As Boolean)
        'Checks if a profile is selected. It then reads the content of the profile file into the array. To avoid errors with the array being too small, it gets resized. The number represents the amount of settings.
        'It then starts to convert and load the profile, see the the method below.
        If String.IsNullOrEmpty(Profile) = False Then
            LoadFromProfile = frmMain.AppData + "\SealSync\Profiles\" + Profile + ".txt"
            ProfileContent = File.ReadAllLines(LoadFromProfile)
            ReDim Preserve ProfileContent(4)
            CheckAndConvertProfile(Profile, ShowMessage)
            Close()
        Else
            MsgBox("Error: No profile selected. Please select a profile to load from.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Public Sub CheckAndConvertProfile(Profile As String, ShowMessage As Boolean)
        'This checks if the profile file that was loaded has enough lines, too few lines would mean that settings are missing, meaning the file is either too old or corrupted.
        'It will check for each required line if it is empty (required lines = the length of a healthy, normal profile file). Make sure that the line amount it checks matches the amount of settings that are being saved.
        'If a line is empty, it will fill that line with a placeholder in the array so the profile can get loaded without errors. After loading the profile, it gets automatically saved so the corrupted/old settings file gets fixed.
        'If no required line is empty and the file is fine, it will just load the profile like normal.
        If (String.IsNullOrEmpty(ProfileContent(0)) OrElse String.IsNullOrEmpty(ProfileContent(1)) OrElse String.IsNullOrEmpty(ProfileContent(2)) OrElse String.IsNullOrEmpty(3)) Then
            Select Case MsgBox("You are trying to load a profile from an older version or a corrupted profile. You need to update it in order to load it. You usually won't lose any settings. Do you want to continue?", MsgBoxStyle.YesNo, "Load old or corrupted profile")
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
                    frmSaveProfileAs.UpdateProfile(Profile)
                    MsgBox("Loaded and updated profile. It should now work correctly!", MsgBoxStyle.Information, "Loaded and updated profile")
                Case Windows.Forms.DialogResult.No
                    MsgBox("Cancelled loading profile.", MsgBoxStyle.Exclamation, "Warning")
            End Select
        Else
            LoadProfile(Profile, ShowMessage)
        End If
    End Sub

    Public Sub LoadProfile(Profile As String, ShowMessage As Boolean) 'This contains examples for loading different elements. Of course, you can use your own methods here.
        'Example for loading a radiobutton. The file stores which button is checked as a string, which is checked here. Depending on the string, a radiobutton will be selected.
        rbtn = settings.Lines(0)
        If rbtn = "rbtn1" Then
            frmMain.rbtn1.Checked = True
        ElseIf rbtn = "rbtn2" Then
            frmMain.rbtn2.Checked = True
        ElseIf rbtn = "rbtn3" Then
            frmMain.rbtn3.Checked = True
        End If

        'Examples for loading checkboxes. Same concept like the radiobuttons, the file stores if the button is checked or not and gets checked depending on the string when being loaded.
        cb1 = settings.Lines(1)
        If cb1 = "cb1Checked" Then
            frmMain.cb1.Checked = True
        ElseIf cb1 = "cb1NotChecked" Then
            frmMain.cb1.Checked = False
        End If
        cb2 = settings.Lines(2)
        If cb2 = "cb2Checked" Then
            frmMain.cb2.Checked = True
        ElseIf cb2 = "cb2NotChecked" Then
            frmMain.cb2.Checked = False
        End If

        'Example for loading a string (like a textbox)
        frmMain.tb1.Text = settings.Lines(3)

        'If ShowMessage is enabled, it will show a messagebox when loading completes.
        If ShowMessage Then
            MsgBox("Loaded profile " + Profile + ".", MsgBoxStyle.Information, "Loaded profile")
        End If
    End Sub
End Class