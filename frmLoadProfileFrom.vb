Imports System.IO

Public Class frmLoadProfileFrom

    Dim ProfileDirectory As String = frmMain.AppData + "\Profile Manager Demo\Profiles"
    Dim ProfileList As String()
    Dim LoadFromProfile As String
    Dim rbtn As String
    Dim cb1 As String
    Dim cb2 As String
    Dim tb1 As String

    Private Sub frmLoadProfileFrom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.DirectoryExists(frmMain.AppData + "\Profile Manager Demo\Profiles") Then
            cbxProfiles.Items.Clear()
            GetFiles(ProfileDirectory)
        Else
            MsgBox("Error: Profile directory does not exist. Please restart the application.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Sub GetFiles(Path As String)
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
        Close()
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        LoadProfile(cbxProfiles.SelectedItem, True)
    End Sub

    Public Sub LoadProfile(Profile, ShowMessage)
        If String.IsNullOrEmpty(Profile) = False Then
            LoadFromProfile = frmMain.AppData + "\Profile Manager Demo\Profiles\" + Profile + ".txt"
            settings.Text = My.Computer.FileSystem.ReadAllText(LoadFromProfile)

            rbtn = settings.Lines(0)
            If rbtn = "rbtn1" Then
                frmMain.rbtn1.Checked = True
            ElseIf rbtn = "rbtn2" Then
                frmMain.rbtn2.Checked = True
            ElseIf rbtn = "rbtn3" Then
                frmMain.rbtn3.Checked = True
            End If

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

            frmMain.tb1.Text = settings.Lines(3)

            If ShowMessage Then
                MsgBox("Loaded profile " + Profile + ".", MsgBoxStyle.Information, "Loaded profile")
            End If

            Close()
        Else
            MsgBox("Error: No profile selected. Please select a profile to load from.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub
End Class