Imports System.IO

Public Class frmRenameProfile

    Private targetProfile As String

    Public Sub ShowWindow(targetProfile As String) 'Should be used so the targetProfile arg can be passed
        Me.targetProfile = targetProfile
        ShowDialog()
    End Sub

    Public Sub RenameProfile(targetProfile As String, newName As String)
        'Rename profile by "moving" it, if the profile and new name are valid
        If Not String.IsNullOrEmpty(newName) And Not String.IsNullOrEmpty(targetProfile) Then
            Try
                File.Move($"{frmMain.profileDirectory}{targetProfile}.txt", $"{frmMain.profileDirectory}{newName}.txt")
                MsgBox(GetString("infoUpdatedSelectedProfile", frmMain.language), MsgBoxStyle.Information, "Success")
                Close()
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
            End Try

        Else
            MsgBox(GetString("errorProfileNameIsEmpty", frmMain.language), MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub LoadTranslations()
        'Load German translations
        If frmMain.language = "German" Then
            lblRenameProfileTo.Text = "Profil umbenennen zu..."
            btnRename.Text = "Umbenennen"
            btnCancel.Text = "Abbrechen"
            Text = "Profil speichern als..."
        End If
    End Sub

    Private Sub LoadDesign()
        If frmMain.design = "Dark" Then
            'Switch all components to dark mode. Note that you will need to change the button design yourself.
            BackColor = Color.FromArgb(41, 41, 41)
            lblRenameProfileTo.ForeColor = Color.White
            tbSaveProfileAs.ForeColor = Color.White
            tbSaveProfileAs.BackColor = Color.Gray
        End If
    End Sub

    Private Sub btnRename_Click(sender As Object, e As EventArgs) Handles btnRename.Click
        RenameProfile(targetProfile, tbSaveProfileAs.Text)
    End Sub

    Private Sub frmRenameProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTranslations()
        LoadDesign()
        tbSaveProfileAs.Clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class