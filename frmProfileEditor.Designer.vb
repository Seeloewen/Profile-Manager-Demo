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
        Me.rbtn1 = New System.Windows.Forms.RadioButton()
        Me.cb1s = New System.Windows.Forms.CheckBox()
        Me.rbtn2 = New System.Windows.Forms.RadioButton()
        Me.rbtn3 = New System.Windows.Forms.RadioButton()
        Me.cb2s = New System.Windows.Forms.CheckBox()
        Me.cbxProfile = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.settings = New System.Windows.Forms.RichTextBox()
        Me.gbEditProfile.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbEditProfile
        '
        Me.gbEditProfile.Controls.Add(Me.tb1s)
        Me.gbEditProfile.Controls.Add(Me.rbtn1)
        Me.gbEditProfile.Controls.Add(Me.cb1s)
        Me.gbEditProfile.Controls.Add(Me.rbtn2)
        Me.gbEditProfile.Controls.Add(Me.rbtn3)
        Me.gbEditProfile.Controls.Add(Me.cb2s)
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
        Me.tb1s.Size = New System.Drawing.Size(221, 20)
        Me.tb1s.TabIndex = 6
        '
        'rbtn1
        '
        Me.rbtn1.AutoSize = True
        Me.rbtn1.Checked = True
        Me.rbtn1.Location = New System.Drawing.Point(24, 29)
        Me.rbtn1.Name = "rbtn1"
        Me.rbtn1.Size = New System.Drawing.Size(65, 17)
        Me.rbtn1.TabIndex = 2
        Me.rbtn1.TabStop = True
        Me.rbtn1.Text = "Option 1"
        Me.rbtn1.UseVisualStyleBackColor = True
        '
        'cb1s
        '
        Me.cb1s.AutoSize = True
        Me.cb1s.Location = New System.Drawing.Point(24, 69)
        Me.cb1s.Name = "cb1s"
        Me.cb1s.Size = New System.Drawing.Size(53, 17)
        Me.cb1s.TabIndex = 0
        Me.cb1s.Text = "Box 1"
        Me.cb1s.UseVisualStyleBackColor = True
        '
        'rbtn2
        '
        Me.rbtn2.AutoSize = True
        Me.rbtn2.Location = New System.Drawing.Point(99, 29)
        Me.rbtn2.Name = "rbtn2"
        Me.rbtn2.Size = New System.Drawing.Size(65, 17)
        Me.rbtn2.TabIndex = 4
        Me.rbtn2.TabStop = True
        Me.rbtn2.Text = "Option 2"
        Me.rbtn2.UseVisualStyleBackColor = True
        '
        'rbtn3
        '
        Me.rbtn3.AutoSize = True
        Me.rbtn3.Location = New System.Drawing.Point(180, 29)
        Me.rbtn3.Name = "rbtn3"
        Me.rbtn3.Size = New System.Drawing.Size(65, 17)
        Me.rbtn3.TabIndex = 3
        Me.rbtn3.TabStop = True
        Me.rbtn3.Text = "Option 3"
        Me.rbtn3.UseVisualStyleBackColor = True
        '
        'cb2s
        '
        Me.cb2s.AutoSize = True
        Me.cb2s.Location = New System.Drawing.Point(99, 69)
        Me.cb2s.Name = "cb2s"
        Me.cb2s.Size = New System.Drawing.Size(53, 17)
        Me.cb2s.TabIndex = 1
        Me.cb2s.Text = "Box 2"
        Me.cb2s.UseVisualStyleBackColor = True
        '
        'cbxProfile
        '
        Me.cbxProfile.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxProfile.FormattingEnabled = True
        Me.cbxProfile.Location = New System.Drawing.Point(12, 32)
        Me.cbxProfile.Name = "cbxProfile"
        Me.cbxProfile.Size = New System.Drawing.Size(266, 21)
        Me.cbxProfile.TabIndex = 7
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(11, 210)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(131, 23)
        Me.btnSave.TabIndex = 8
        Me.btnSave.Text = "Save changes"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(147, 210)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(131, 23)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete profile"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(212, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Choose the profile you want to edit:"
        '
        'btnClose
        '
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
        Me.ClientSize = New System.Drawing.Size(298, 272)
        Me.Controls.Add(Me.settings)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
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
    Friend WithEvents rbtn1 As RadioButton
    Friend WithEvents cb1s As CheckBox
    Friend WithEvents rbtn2 As RadioButton
    Friend WithEvents rbtn3 As RadioButton
    Friend WithEvents cb2s As CheckBox
    Friend WithEvents cbxProfile As ComboBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents settings As RichTextBox
End Class
