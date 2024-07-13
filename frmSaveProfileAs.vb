Public Class frmSaveProfileAs

    'Variables used by the software to work correctly
    Dim messageboxStrings As New messageboxStrings

    'Variables that store profile content
    Dim rbtn As String
    Dim cb1 As String
    Dim cb2 As String
    Dim tb1 As String

    '-- Event handlers --
    Private Sub frmSaveProfileAs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Load translations
        LoadTranslations()
        LoadDesign()

        'Clear profile name textbox
        tbSaveProfileAs.Clear()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Start saving process
        SaveProfile(tbSaveProfileAs.Text)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Close this window
        Close()
    End Sub

    '-- Custom Methods --

    Public Sub SaveProfile(ProfileName)
        'Set which radiobutton is selected
        If frmMain.rbtn1.Checked Then
            rbtn = "rbtn1"
        ElseIf frmMain.rbtn2.Checked Then
            rbtn = "rbtn2"
        ElseIf frmMain.rbtn3.Checked Then
            rbtn = "rbtn3"
        End If

        'Set wether checkboxes are checked or not
        If frmMain.cb1.Checked Then
            cb1 = "cb1Checked"
        Else
            cb1 = "cb1NotChecked"
        End If
        If frmMain.cb2.Checked Then
            cb2 = "cb2Checked"
        Else
            cb2 = "cb2NotChecked"
        End If

        'Set content based on textbox input, if textbox is empty it will be filled with a placeholder to avoid issues when loading
        If String.IsNullOrEmpty(frmMain.tb1.Text) Then
            tb1 = "None"
        Else
            tb1 = frmMain.tb1.Text
        End If

        'Saves the profile. It checks if the profile already exists or not. If it exists, it will show a warning, otherwise it will not.
        'It will then create a text file with the name set in ProfileName and write the content of the variable to the file.
        'It will show an error if ProfileName is empty or ProfileDirectory doesn't exist.
        If String.IsNullOrEmpty(ProfileName) = False Then
            If My.Computer.FileSystem.DirectoryExists(frmMain.ProfileDirectory) Then
                If My.Computer.FileSystem.FileExists(frmMain.ProfileDirectory + ProfileName + ".txt") Then
                    Select Case MsgBox(messageboxStrings.returnMessageboxString("questionProfileNameAlreadyExists", frmMain.Language), vbQuestion + vbYesNo, "Profile already exists")
                        Case Windows.Forms.DialogResult.Yes
                            My.Computer.FileSystem.WriteAllText(frmMain.ProfileDirectory + ProfileName + ".txt", rbtn + vbNewLine + cb1 + vbNewLine + cb2 + vbNewLine + tb1, False)
                            MsgBox(messageboxStrings.returnMessageboxString("infoProfileOverwrittenAndSaved", frmMain.Language), MsgBoxStyle.Information, "Overwritten and saved")
                            Close()
                        Case Windows.Forms.DialogResult.No
                            MsgBox(messageboxStrings.returnMessageboxString("infoProfileNotOverwritten", frmMain.Language), MsgBoxStyle.Exclamation, "Profile Not overwritten.")
                    End Select
                Else
                    My.Computer.FileSystem.WriteAllText(frmMain.ProfileDirectory + ProfileName + ".txt", rbtn + vbNewLine + cb1 + vbNewLine + cb2 + vbNewLine + tb1, False)
                    MsgBox(messageboxStrings.returnMessageboxString("infoProfileSaved", frmMain.Language), MsgBoxStyle.Information, "Saved")
                    Close()
                End If
            Else
                MsgBox(messageboxStrings.returnMessageboxString("errorProfileDirectoryDoesNotExist", frmMain.Language), MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox(messageboxStrings.returnMessageboxString("errorProfileNameIsEmpty", frmMain.Language), MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Public Sub UpdateProfile(ProfileName)
        'Set which radiobutton is selected
        If frmMain.rbtn1.Checked Then
            rbtn = "rbtn1"
        ElseIf frmMain.rbtn2.Checked Then
            rbtn = "rbtn2"
        ElseIf frmMain.rbtn3.Checked Then
            rbtn = "rbtn3"
        End If

        'Set wether checkboxes are checked or not
        If frmMain.cb1.Checked Then
            cb1 = "cb1Checked"
        Else
            cb1 = "cb1NotChecked"
        End If
        If frmMain.cb2.Checked Then
            cb2 = "cb2Checked"
        Else
            cb2 = "cb2NotChecked"
        End If

        'Set content based on textbox input, if textbox is empty it will be filled with a placeholder to avoid issues when loading
        If String.IsNullOrEmpty(frmMain.tb1.Text) Then
            tb1 = "None"
        Else
            tb1 = frmMain.tb1.Text
        End If

        'Update the selected profile. This will save and overwrite the selected profile without showing any warning or message. Used if a profile is old or corrupted.
        If String.IsNullOrEmpty(ProfileName) = False Then
            If My.Computer.FileSystem.DirectoryExists(frmMain.ProfileDirectory) Then
                My.Computer.FileSystem.WriteAllText(frmMain.ProfileDirectory + ProfileName + ".txt", rbtn + vbNewLine + cb1 + vbNewLine + cb2 + vbNewLine + tb1, False)
            Else
                MsgBox(messageboxStrings.returnMessageboxString("errorProfileDirectoryDoesNotExist", frmMain.Language), MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox(messageboxStrings.returnMessageboxString("errorCouldntUpdateEmptyProfileName", frmMain.Language), MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub LoadTranslations()
        'Load German translations
        If frmMain.Language = "German" Then
            lblSaveProfileAs.Text = "Profil speichern als..."
            btnSave.Text = "Speichern"
            btnCancel.Text = "Abbrechen"
            Text = "Profil speichern als..."
        End If
    End Sub

    Private Sub LoadDesign()
        If frmMain.Design = "Dark" Then
            'Switch all components to dark mode. Note that you will need to change the button design yourself.
            BackColor = Color.FromArgb(41, 41, 41)
            lblSaveProfileAs.ForeColor = Color.White
            tbSaveProfileAs.ForeColor = Color.White
            tbSaveProfileAs.BackColor = Color.Gray
        End If
    End Sub
End Class