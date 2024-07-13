<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cbxDefaultProfile = New System.Windows.Forms.ComboBox()
        Me.cbLoadProfileByDefault = New System.Windows.Forms.CheckBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cbxDesign = New System.Windows.Forms.ComboBox()
        Me.lblDesign = New System.Windows.Forms.Label()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.cbxLanguage = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'cbxDefaultProfile
        '
        Me.cbxDefaultProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDefaultProfile.FormattingEnabled = True
        Me.cbxDefaultProfile.Location = New System.Drawing.Point(12, 38)
        Me.cbxDefaultProfile.Name = "cbxDefaultProfile"
        Me.cbxDefaultProfile.Size = New System.Drawing.Size(267, 21)
        Me.cbxDefaultProfile.TabIndex = 12
        '
        'cbLoadProfileByDefault
        '
        Me.cbLoadProfileByDefault.AutoSize = True
        Me.cbLoadProfileByDefault.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLoadProfileByDefault.Location = New System.Drawing.Point(12, 12)
        Me.cbLoadProfileByDefault.Name = "cbLoadProfileByDefault"
        Me.cbLoadProfileByDefault.Size = New System.Drawing.Size(161, 20)
        Me.cbLoadProfileByDefault.TabIndex = 11
        Me.cbLoadProfileByDefault.Text = "Load profile by default:"
        Me.cbLoadProfileByDefault.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(147, 195)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(133, 23)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(12, 195)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(129, 23)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cbxDesign
        '
        Me.cbxDesign.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxDesign.FormattingEnabled = True
        Me.cbxDesign.Items.AddRange(New Object() {"System Default", "Dark", "Light"})
        Me.cbxDesign.Location = New System.Drawing.Point(13, 96)
        Me.cbxDesign.Name = "cbxDesign"
        Me.cbxDesign.Size = New System.Drawing.Size(268, 21)
        Me.cbxDesign.TabIndex = 16
        '
        'lblDesign
        '
        Me.lblDesign.AutoSize = True
        Me.lblDesign.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesign.Location = New System.Drawing.Point(9, 75)
        Me.lblDesign.Name = "lblDesign"
        Me.lblDesign.Size = New System.Drawing.Size(53, 16)
        Me.lblDesign.TabIndex = 17
        Me.lblDesign.Text = "Design:"
        '
        'lblLanguage
        '
        Me.lblLanguage.AutoSize = True
        Me.lblLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLanguage.Location = New System.Drawing.Point(9, 132)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(71, 16)
        Me.lblLanguage.TabIndex = 18
        Me.lblLanguage.Text = "Language:"
        '
        'cbxLanguage
        '
        Me.cbxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxLanguage.FormattingEnabled = True
        Me.cbxLanguage.Items.AddRange(New Object() {"System Default (Systemstandard)", "German (Deutsch)", "English (Englisch)"})
        Me.cbxLanguage.Location = New System.Drawing.Point(12, 153)
        Me.cbxLanguage.Name = "cbxLanguage"
        Me.cbxLanguage.Size = New System.Drawing.Size(268, 21)
        Me.cbxLanguage.TabIndex = 19
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(292, 230)
        Me.Controls.Add(Me.cbxLanguage)
        Me.Controls.Add(Me.lblLanguage)
        Me.Controls.Add(Me.lblDesign)
        Me.Controls.Add(Me.cbxDesign)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.cbxDefaultProfile)
        Me.Controls.Add(Me.cbLoadProfileByDefault)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Settings"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxDefaultProfile As ComboBox
    Friend WithEvents cbLoadProfileByDefault As CheckBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents cbxDesign As ComboBox
    Friend WithEvents lblDesign As Label
    Friend WithEvents lblLanguage As Label
    Friend WithEvents cbxLanguage As ComboBox
End Class
