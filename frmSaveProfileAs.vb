Public Class frmSaveProfileAs

    Dim rbtn As String
    Dim cb1 As String
    Dim cb2 As String
    Dim tb1 As String

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If frmMain.rbtn1.Checked Then
            rbtn = "rbtn1"
        ElseIf frmMain.rbtn2.Checked Then
            rbtn = "rbtn2"
        ElseIf frmMain.rbtn3.Checked Then
            rbtn = "rbtn3"
        End If

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

        tb1 = frmMain.tb1.Text

        If String.IsNullOrEmpty(tbSaveProfileAs.Text) = False Then
            If My.Computer.FileSystem.DirectoryExists(frmMain.AppData + "\Profile Manager Demo\Profiles") Then
                If My.Computer.FileSystem.FileExists(frmMain.AppData + "\Profile Manager Demo\Profiles\" + tbSaveProfileAs.Text + ".txt") Then
                    Select Case MessageBox.Show("A profile with this name already exists. Do you want to override it?", "Profile already exists", MessageBoxButtons.YesNo)
                        Case Windows.Forms.DialogResult.Yes
                            My.Computer.FileSystem.WriteAllText(frmMain.AppData + "\Profile Manager Demo\Profiles\" + tbSaveProfileAs.Text + ".txt", rbtn + vbNewLine + cb1 + vbNewLine + cb2 + vbNewLine + tb1, False)
                            MsgBox("Profile was overwritten and saved.", MsgBoxStyle.Information, "Overwritten and saved")
                            Close()
                        Case Windows.Forms.DialogResult.No
                            MsgBox("Profile was not overwritten. Please select a different profile name.", MsgBoxStyle.Exclamation, "Profile not overwritten.")
                    End Select
                Else
                    My.Computer.FileSystem.WriteAllText(frmMain.AppData + "\Profile Manager Demo\Profiles\" + tbSaveProfileAs.Text + ".txt", rbtn + vbNewLine + cb1 + vbNewLine + cb2 + vbNewLine + tb1, False)
                    MsgBox("Profile was saved.", MsgBoxStyle.Information, "Saved")
                    Close()
                End If
            Else
                MsgBox("Error: Profile directory does not exist. Please restart the application.", MsgBoxStyle.Critical, "Error")
            End If
        Else
            MsgBox("Error: Profile name is empty. Please enter a profile name.", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub frmSaveProfileAs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbSaveProfileAs.Clear()
    End Sub
End Class