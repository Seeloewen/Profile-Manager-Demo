<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProfileEditor
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
        Me.gbEditProfile = New System.Windows.Forms.GroupBox()
        Me.tb1s = New System.Windows.Forms.TextBox()
        Me.rbtn1s = New System.Windows.Forms.RadioButton()
        Me.cb1s = New System.Windows.Forms.CheckBox()
        Me.rbtn2s = New System.Windows.Forms.RadioButton()
        Me.rbtn3s = New System.Windows.Forms.RadioButton()
        Me.cb2s = New System.Windows.Forms.CheckBox()
        Me.cbxProfile = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.lblChooseProfile = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.settings = New System.Windows.Forms.RichTextBox()
        Me.gbEditProfile.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbEditProfile
        '
        Me.gbEditProfile.Controls.Add(Me.tb1s)
        Me.gbEditProfile.Controls.Add(Me.rbtn1s)
        Me.gbEditProfile.Controls.Add(Me.cb1s)
        Me.gbEditProfile.Controls.Add(Me.rbtn2s)
        Me.gbEditProfile.Controls.Add(Me.rbtn3s)
        Me.gbEditProfile.Controls.Add(Me.cb2s)
        Me.gbEditProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbEditProfile.Location = New System.Drawing.Point(11, 59)
        Me.gbEditProfile.Name = "gbEditProfile"
        Me.gbEditProfile.Size = New System.Drawing.Size(267, 145)
        Me.gbEditProfile.TabIndex = 6
        Me.gbEditProfile.TabStop = False
        Me.gbEditProfile.Text = "Edit profile"
        '
        'tb1s
        '
        Me.tb1s.Location = New System.Drawing.Point(24, 106)
        Me.tb1s.Name = "tb1s"
        Me.tb1s.Size = New System.Drawing.Size(221, 22)
        Me.tb1s.TabIndex = 6
        '
        'rbtn1s
        '
        Me.rbtn1s.AutoSize = True
        Me.rbtn1s.Checked = True
        Me.rbtn1s.Location = New System.Drawing.Point(24, 29)
        Me.rbtn1s.Name = "rbtn1s"
        Me.rbtn1s.Size = New System.Drawing.Size(74, 20)
        Me.rbtn1s.TabIndex = 2
        Me.rbtn1s.TabStop = True
        Me.rbtn1s.Text = "Option 1"
        Me.rbtn1s.UseVisualStyleBackColor = True
        '
        'cb1s
        '
        Me.cb1s.AutoSize = True
        Me.cb1s.Location = New System.Drawing.Point(24, 69)
        Me.cb1s.Name = "cb1s"
        Me.cb1s.Size = New System.Drawing.Size(59, 20)
        Me.cb1s.TabIndex = 0
        Me.cb1s.Text = "Box 1"
        Me.cb1s.UseVisualStyleBackColor = True
        '
        'rbtn2s
        '
        Me.rbtn2s.AutoSize = True
        Me.rbtn2s.Location = New System.Drawing.Point(99, 29)
        Me.rbtn2s.Name = "rbtn2s"
        Me.rbtn2s.Size = New System.Drawing.Size(74, 20)
        Me.rbtn2s.TabIndex = 4
        Me.rbtn2s.TabStop = True
        Me.rbtn2s.Text = "Option 2"
        Me.rbtn2s.UseVisualStyleBackColor = True
        '
        'rbtn3s
        '
        Me.rbtn3s.AutoSize = True
        Me.rbtn3s.Location = New System.Drawing.Point(180, 29)
        Me.rbtn3s.Name = "rbtn3s"
        Me.rbtn3s.Size = New System.Drawing.Size(74, 20)
        Me.rbtn3s.TabIndex = 3
        Me.rbtn3s.TabStop = True
        Me.rbtn3s.Text = "Option 3"
        Me.rbtn3s.UseVisualStyleBackColor = True
        '
        'cb2s
        '
        Me.cb2s.AutoSize = True
        Me.cb2s.Location = New System.Drawing.Point(99, 69)
        Me.cb2s.Name = "cb2s"
        Me.cb2s.Size = New System.Drawing.Size(59, 20)
        Me.cb2s.TabIndex = 1
        Me.cb2s.Text = "Box 2"
        Me.cb2s.UseVisualStyleBackColor = True
        '
        'cbxProfile
        '
        Me.cbxProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxProfile.FormattingEnabled = True
        Me.cbxProfile.Location = New System.Drawing.Point(12, 29)
        Me.cbxProfile.Name = "cbxProfile"
        Me.cbxProfile.Size = New System.Drawing.Size(266, 24)
        Me.cbxProfile.TabIndex = 7
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(11, 210)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(131, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(147, 210)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(131, 23)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete profile"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'lblChooseProfile
        '
        Me.lblChooseProfile.AutoSize = True
        Me.lblChooseProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChooseProfile.Location = New System.Drawing.Point(12, 10)
        Me.lblChooseProfile.Name = "lblChooseProfile"
        Me.lblChooseProfile.Size = New System.Drawing.Size(212, 16)
        Me.lblChooseProfile.TabIndex = 10
        Me.lblChooseProfile.Text = "Choose the profile you want to edit:"
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(84, 239)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(126, 23)
        Me.btnClose.TabIndex = 11
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'settings
        '
        Me.settings.Location = New System.Drawing.Point(15, 369)
        Me.settings.Name = "settings"
        Me.settings.Size = New System.Drawing.Size(100, 96)
        Me.settings.TabIndex = 12
        Me.settings.Text = ""
        '
        'frmProfileEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(290, 272)
        Me.Controls.Add(Me.settings)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblChooseProfile)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.cbxProfile)
        Me.Controls.Add(Me.gbEditProfile)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmProfileEditor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profile Editor"
        Me.gbEditProfile.ResumeLayout(False)
        Me.gbEditProfile.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents gbEditProfile As GroupBox
    Friend WithEvents tb1s As TextBox
    Friend WithEvents rbtn1s As RadioButton
    Friend WithEvents cb1s As CheckBox
    Friend WithEvents rbtn2s As RadioButton
    Friend WithEvents rbtn3s As RadioButton
    Friend WithEvents cb2s As CheckBox
    Friend WithEvents cbxProfile As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents lblChooseProfile As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents settings As RichTextBox
End Class
