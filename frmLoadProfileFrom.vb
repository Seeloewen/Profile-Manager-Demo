Imports System.IO

Public Class frmLoadProfileFrom

    'Variables used by the application to work correctly
    Dim profileList As String()
    Dim profileContent As String()
    Dim loadFromProfile As String

    'Placeholders used for loading the settings
    Dim rbtn As String
    Dim cb1 As String
    Dim cb2 As String
    Dim tb1 As String

    '-- Event Handlers --
    Private Sub frmLoadProfileFrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load translations
        LoadTranslations()
        LoadDesign()

        'Checks if the profile directory exists. If yes, it clears the combobox to avoid duplicates and it starts getting all available profiles, see method below
        If My.Computer.FileSystem.DirectoryExists(frmMain.profileDirectory) Then
            cbxProfiles.Items.Clear()
            GetFiles(frmMain.profileDirectory)
        Else
            MsgBox(GetString("errorProfileDirectoryDoesNotExist", frmMain.language), MsgBoxStyle.Critical, GetString("headerError", frmMain.language))
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Closes the load window
        Close()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        'Starts the whole loading process
        InitializeLoadingProfile(cbxProfiles.SelectedItem, True)
    End Sub

    '-- Custom Methods --

    Sub GetFiles(path As String)
        'Gets all the profile files from the directory and puts their name into the combobox
        If path.Trim().Length = 0 Then
            Return
        End If

        profileList = Directory.GetFileSystemEntries(path)

        Try
            For Each profile As String In profileList
                If Directory.Exists(profile) Then
                    GetFiles(profile)
                Else
                    profile = profile.Replace(path, "").Replace(".txt", "")
                    cbxProfiles.Items.Add(profile)
                End If
            Next
        Catch ex As Exception
            MsgBox(GetString("errorLoadingProfilesFailed", frmMain.language) + vbNewLine + "Exception: " + ex.Message, MsgBoxStyle.Critical, GetString("headerError", frmMain.language))
        End Try
    End Sub

    Public Sub InitializeLoadingProfile(profile As String, showMessage As Boolean)
        'Checks if a profile is selected. It then reads the content of the profile file into the array. To avoid errors with the array being too small, it gets resized. The number represents the amount of settings.
        'It then starts to convert and load the profile, see the the method below.
        If String.IsNullOrEmpty(profile) = False Then
            loadFromProfile = frmMain.profileDirectory + profile + ".txt"
            profileContent = File.ReadAllLines(loadFromProfile)
            ReDim Preserve profileContent(4)
            CheckAndConvertProfile(profile, showMessage)
            Close()
        Else
            MsgBox(GetString("errorNoProfileSelected", frmMain.language), MsgBoxStyle.Critical, GetString("headerError", frmMain.language))
        End If
    End Sub

    Public Sub CheckAndConvertProfile(profile As String, showMessage As Boolean)
        'This checks if the profile file that was loaded has enough lines, too few lines would mean that settings are missing, meaning the file is either too old or corrupted.
        'It will check for each required line if it is empty (required lines = the length of a healthy, normal profile file). Make sure that the line amount it checks matches the amount of settings that are being saved.
        'If a line is empty, it will fill that line with a placeholder in the array so the profile can get loaded without errors. After loading the profile, it gets automatically saved so the corrupted/old settings file gets fixed.
        'If no required line is empty and the file is fine, it will just load the profile like normal.
        If (String.IsNullOrEmpty(profileContent(0)) OrElse String.IsNullOrEmpty(profileContent(1)) OrElse String.IsNullOrEmpty(profileContent(2)) OrElse String.IsNullOrEmpty(3)) Then
            Select Case MsgBox(GetString("questionLoadOldOrCorruptedProfile", frmMain.language), vbQuestion + vbYesNo, GetString("headerOldOrCorrupted", frmMain.language))
                Case Windows.Forms.DialogResult.Yes
                    If String.IsNullOrEmpty(profileContent(0)) Then
                        profileContent(0) = "rbtn1"
                    End If
                    If String.IsNullOrEmpty(profileContent(1)) Then
                        profileContent(1) = "cb1Checked"
                    End If
                    If String.IsNullOrEmpty(profileContent(2)) Then
                        profileContent(2) = "cb2NotChecked"
                    End If
                    If String.IsNullOrEmpty(profileContent(3)) Then
                        profileContent(3) = "Placeholder"
                    End If
                    LoadProfile(profile, False)
                    frmSaveProfileAs.UpdateProfile(profile)
                    MsgBox(GetString("infoLoadedAndUpdatedProfile", frmMain.language), MsgBoxStyle.Information, GetString("headerLoadedUpdatedProfile", frmMain.language))
                Case Windows.Forms.DialogResult.No
                    MsgBox(GetString("infoCancelledLoadingProfiles", frmMain.language), MsgBoxStyle.Exclamation, GetString("headerWarning", frmMain.language))
            End Select
        Else
            LoadProfile(profile, showMessage)
        End If
    End Sub

    Public Sub LoadProfile(profile As String, showMessage As Boolean) 'This contains examples for loading different elements. Of course, you can use your own methods here.
        'Example for loading a radiobutton. The file stores which button is checked as a string, which is checked here. Depending on the string, a radiobutton will be selected.
        rbtn = profileContent(0)
        If rbtn = "rbtn1" Then
            frmMain.rbtn1.Checked = True
        ElseIf rbtn = "rbtn2" Then
            frmMain.rbtn2.Checked = True
        ElseIf rbtn = "rbtn3" Then
            frmMain.rbtn3.Checked = True
        End If

        'Examples for loading checkboxes. Same concept like the radiobuttons, the file stores if the button is checked or not and gets checked depending on the string when being loaded.
        cb1 = profileContent(1)
        If cb1 = "cb1Checked" Then
            frmMain.cb1.Checked = True
        ElseIf cb1 = "cb1NotChecked" Then
            frmMain.cb1.Checked = False
        End If
        cb2 = profileContent(2)
        If cb2 = "cb2Checked" Then
            frmMain.cb2.Checked = True
        ElseIf cb2 = "cb2NotChecked" Then
            frmMain.cb2.Checked = False
        End If

        'Example for loading a string (like a textbox)
        frmMain.tb1.Text = profileContent(3)

        'If ShowMessage is enabled, it will show a messagebox when loading completes.
        If showMessage Then
            MsgBox(GetString("infoProfileLoaded", frmMain.language), MsgBoxStyle.Information, GetString("headerLoadedProfile", frmMain.language))
        End If
    End Sub

    Private Sub LoadTranslations()
        'Load German translation
        If frmMain.language = "German" Then
            lblLoadProfileFrom.Text = "Profil laden von..."
            btnLoad.Text = "Laden"
            btnCancel.Text = "Schließen"
            Text = "Profil laden von..."
        End If
    End Sub

    Private Sub LoadDesign()
        If frmMain.design = "Dark" Then
            'Switch all components to dark mode. Note that you will need to change the button design yourself.
            BackColor = Color.FromArgb(41, 41, 41)
            lblLoadProfileFrom.ForeColor = Color.White
        End If
    End Sub
End Class