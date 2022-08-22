Imports System.IO

Public Class frmProfileEditor

    Dim ProfileDirectory As String = frmMain.AppData + "\Profile Manager Demo\Profiles"
    Dim ProfileList As String()
    Dim LoadFromProfile As String
    Dim rbtn As String
    Dim cb1 As String
    Dim cb2 As String
    Dim tb1 As String

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If rbtn1.Checked Then
            rbtn = "rbtn1"
        ElseIf rbtn2.Checked Then
            rbtn = "rbtn2"
        ElseIf rbtn3.Checked Then
            rbtn = "rbtn3"
        End If

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

        tb1 = tb1s.Text

        If String.IsNullOrEmpty(cbxProfile.SelectedItem) = False Then
            My.Computer.FileSystem.DirectoryExists(frmMain.AppData + "\Profile Manager Demo\Profiles")
            My.Computer.FileSystem.WriteAllText(frmMain.AppData + "\Profile Manager Demo\Profiles\" + cbxProfile.SelectedItem + ".txt", rbtn + vbNewLine + cb1 + vbNewLine + cb2 + vbNewLine + tb1, False)
            MsgBox("Profile was overwritten and saved.", MsgBoxStyle.Information, "Overwritten and saved")
        Else
            MsgBox("Error: Profile directory does not exist. Please restart the application.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If String.IsNullOrEmpty(cbxProfile.SelectedItem) = False Then
            My.Computer.FileSystem.DeleteFile(frmMain.AppData + "\Profile Manager Demo\Profiles\" + cbxProfile.SelectedItem + ".txt")
            MsgBox("Profile was deleted.", MsgBoxStyle.Information, "Deleted")
            cbxProfile.Items.Remove(cbxProfile.SelectedItem)
        Else
            MsgBox("Error: Profile directory does not exist. Please restart the application.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub cbxProfile_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxProfile.SelectedIndexChanged
        LoadProfile(cbxProfile.SelectedItem)
    End Sub

    Private Sub LoadProfile(Profile)
        If String.IsNullOrEmpty(Profile) = False Then
            LoadFromProfile = frmMain.AppData + "\Profile Manager Demo\Profiles\" + Profile + ".txt"
            settings.Text = My.Computer.FileSystem.ReadAllText(LoadFromProfile)

            rbtn = settings.Lines(0)
            If rbtn = "rbtn1" Then
                rbtn1.Checked = True
            ElseIf rbtn = "rbtn2" Then
                rbtn2.Checked = True
            ElseIf rbtn = "rbtn3" Then
                rbtn3.Checked = True
            End If

            cb1 = settings.Lines(1)
            If cb1 = "cb1Checked" Then
                cb1s.Checked = True
            ElseIf cb1 = "cb1NotChecked" Then
                cb1s.Checked = False
            End If

            cb2 = settings.Lines(2)
            If cb2 = "cb2Checked" Then
                cb2s.Checked = True
            ElseIf cb2 = "cb2NotChecked" Then
                cb2s.Checked = False
            End If

            tb1s.Text = settings.Lines(3)
        Else
            MsgBox("Error: Unknown error when loading profile.", MsgBoxStyle.Exclamation, "Error")
        End If
    End Sub

    Private Sub frmProfileEditor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cbxProfile.Items.Clear()
        rbtn1.Checked = True
        cb1s.Checked = False
        cb2s.Checked = False
        tb1s.Text = ""
        GetFiles(ProfileDirectory)
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
                    cbxProfile.Items.Add(Profile)
                End If
            Next
        Catch ex As Exception
            MsgBox("Error: Could not load profiles. Please try again." + vbNewLine + "Exception: " + ex.Message)
        End Try
    End Sub

End Class