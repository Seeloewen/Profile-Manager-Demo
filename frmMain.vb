Imports System.Environment
Imports System.IO

Public Class frmMain

TODO: Alle Pfadverweise durch ProfileDirectory Variable ersetzen

    Public AppData As String = GetFolderPath(SpecialFolder.ApplicationData)
    Dim ProfileDirectory As String = AppData + "\Profile Manager Demo\Profiles"
    Dim ProfileList As String()

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.DirectoryExists(AppData + "\Profile Manager Demo\Profiles") = False Then
            My.Computer.FileSystem.CreateDirectory(AppData + "\Profile Manager Demo\Profiles")
        End If

        GetFiles(ProfileDirectory)

        If My.Settings.LoadProfileByDefault = True Then
            cbLoadProfileByDefault.Checked = True
            If String.IsNullOrEmpty(My.Settings.DefaultProfile) = False Then
                If My.Computer.FileSystem.FileExists(AppData + "\Profile Manager Demo\Profiles\" + My.Settings.DefaultProfile + ".txt") Then
                    cbxDefaultProfile.SelectedItem = My.Settings.DefaultProfile
                    frmLoadProfileFrom.LoadProfile(cbxDefaultProfile.SelectedItem, False)
                Else
                    MsgBox("Error: Default profile no longer exists. Option will be disabled automatically.", MsgBoxStyle.Critical, "Error")
                    cbLoadProfileByDefault.Checked = False
                    My.Settings.LoadProfileByDefault = False
                End If
            Else
                MsgBox("Error: Could not load default profile as it is empty. Option will be disabled automatically.", MsgBoxStyle.Critical, "Error")
                cbLoadProfileByDefault.Checked = False
                My.Settings.LoadProfileByDefault = False
            End If
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
                    Profile = Profile.Replace(AppData + "\Profile Manager Demo\Profiles\", "")
                    Profile = Profile.Replace(".txt", "")
                    cbxDefaultProfile.Items.Add(Profile)
                End If
            Next
        Catch ex As Exception
            MsgBox("Error: Could not load profiles. Please try again." + vbNewLine + "Exception: " + ex.Message)
        End Try
    End Sub

    Private Sub btnSaveProfile_Click(sender As Object, e As EventArgs) Handles btnSaveProfile.Click
        frmSaveProfileAs.ShowDialog()
    End Sub

    Private Sub btnLoadProfile_Click(sender As Object, e As EventArgs) Handles btnLoadProfile.Click
        frmLoadProfileFrom.ShowDialog()
    End Sub

    Private Sub cbLoadProfileByDefault_CheckedChanged(sender As Object, e As EventArgs) Handles cbLoadProfileByDefault.CheckedChanged
        If cbLoadProfileByDefault.Checked Then
            My.Settings.LoadProfileByDefault = True
        ElseIf cbLoadProfileByDefault.Checked = False Then
            My.Settings.LoadProfileByDefault = False
        End If
    End Sub

    Private Sub cbxDefaultProfile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxDefaultProfile.SelectedIndexChanged
        My.Settings.DefaultProfile = cbxDefaultProfile.SelectedItem
    End Sub

    Private Sub btnOpenProfileEditor_Click(sender As Object, e As EventArgs) Handles btnOpenProfileEditor.Click
        frmProfileEditor.ShowDialog()
    End Sub
End Class
