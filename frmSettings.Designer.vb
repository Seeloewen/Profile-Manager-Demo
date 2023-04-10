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
        Me.btnToggleLanguage = New System.Windows.Forms.Button()
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
        Me.btnCancel.Location = New System.Drawing.Point(147, 109)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(133, 23)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(12, 109)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(129, 23)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnToggleLanguage
        '
        Me.btnToggleLanguage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnToggleLanguage.Location = New System.Drawing.Point(12, 80)
        Me.btnToggleLanguage.Name = "btnToggleLanguage"
        Me.btnToggleLanguage.Size = New System.Drawing.Size(267, 23)
        Me.btnToggleLanguage.TabIndex = 15
        Me.btnToggleLanguage.Text = "Toggle language"
        Me.btnToggleLanguage.UseVisualStyleBackColor = True
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(292, 143)
        Me.Controls.Add(Me.btnToggleLanguage)
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
    Friend WithEvents btnToggleLanguage As Button
End Class
