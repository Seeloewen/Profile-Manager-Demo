<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.cb1 = New System.Windows.Forms.CheckBox()
        Me.cb2 = New System.Windows.Forms.CheckBox()
        Me.rbtn1 = New System.Windows.Forms.RadioButton()
        Me.rbtn3 = New System.Windows.Forms.RadioButton()
        Me.rbtn2 = New System.Windows.Forms.RadioButton()
        Me.gbProfileDemo = New System.Windows.Forms.GroupBox()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.btnSaveProfile = New System.Windows.Forms.Button()
        Me.btnLoadProfile = New System.Windows.Forms.Button()
        Me.btnOpenProfileEditor = New System.Windows.Forms.Button()
        Me.btnSettings = New System.Windows.Forms.Button()
        Me.gbProfileDemo.SuspendLayout()
        Me.SuspendLayout()
        '
        'cb1
        '
        Me.cb1.AutoSize = True
        Me.cb1.Location = New System.Drawing.Point(24, 69)
        Me.cb1.Name = "cb1"
        Me.cb1.Size = New System.Drawing.Size(59, 20)
        Me.cb1.TabIndex = 0
        Me.cb1.Text = "Box 1"
        Me.cb1.UseVisualStyleBackColor = True
        '
        'cb2
        '
        Me.cb2.AutoSize = True
        Me.cb2.Location = New System.Drawing.Point(99, 69)
        Me.cb2.Name = "cb2"
        Me.cb2.Size = New System.Drawing.Size(59, 20)
        Me.cb2.TabIndex = 1
        Me.cb2.Text = "Box 2"
        Me.cb2.UseVisualStyleBackColor = True
        '
        'rbtn1
        '
        Me.rbtn1.AutoSize = True
        Me.rbtn1.Checked = True
        Me.rbtn1.Location = New System.Drawing.Point(24, 29)
        Me.rbtn1.Name = "rbtn1"
        Me.rbtn1.Size = New System.Drawing.Size(74, 20)
        Me.rbtn1.TabIndex = 2
        Me.rbtn1.TabStop = True
        Me.rbtn1.Text = "Option 1"
        Me.rbtn1.UseVisualStyleBackColor = True
        '
        'rbtn3
        '
        Me.rbtn3.AutoSize = True
        Me.rbtn3.Location = New System.Drawing.Point(180, 29)
        Me.rbtn3.Name = "rbtn3"
        Me.rbtn3.Size = New System.Drawing.Size(74, 20)
        Me.rbtn3.TabIndex = 3
        Me.rbtn3.TabStop = True
        Me.rbtn3.Text = "Option 3"
        Me.rbtn3.UseVisualStyleBackColor = True
        '
        'rbtn2
        '
        Me.rbtn2.AutoSize = True
        Me.rbtn2.Location = New System.Drawing.Point(99, 29)
        Me.rbtn2.Name = "rbtn2"
        Me.rbtn2.Size = New System.Drawing.Size(74, 20)
        Me.rbtn2.TabIndex = 4
        Me.rbtn2.TabStop = True
        Me.rbtn2.Text = "Option 2"
        Me.rbtn2.UseVisualStyleBackColor = True
        '
        'gbProfileDemo
        '
        Me.gbProfileDemo.Controls.Add(Me.tb1)
        Me.gbProfileDemo.Controls.Add(Me.rbtn1)
        Me.gbProfileDemo.Controls.Add(Me.cb1)
        Me.gbProfileDemo.Controls.Add(Me.rbtn2)
        Me.gbProfileDemo.Controls.Add(Me.rbtn3)
        Me.gbProfileDemo.Controls.Add(Me.cb2)
        Me.gbProfileDemo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbProfileDemo.Location = New System.Drawing.Point(12, 12)
        Me.gbProfileDemo.Name = "gbProfileDemo"
        Me.gbProfileDemo.Size = New System.Drawing.Size(267, 155)
        Me.gbProfileDemo.TabIndex = 5
        Me.gbProfileDemo.TabStop = False
        Me.gbProfileDemo.Text = "Profile Demo"
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(24, 106)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(221, 22)
        Me.tb1.TabIndex = 6
        '
        'btnSaveProfile
        '
        Me.btnSaveProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSaveProfile.Location = New System.Drawing.Point(12, 173)
        Me.btnSaveProfile.Name = "btnSaveProfile"
        Me.btnSaveProfile.Size = New System.Drawing.Size(136, 23)
        Me.btnSaveProfile.TabIndex = 6
        Me.btnSaveProfile.Text = "Save profile"
        Me.btnSaveProfile.UseVisualStyleBackColor = True
        '
        'btnLoadProfile
        '
        Me.btnLoadProfile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoadProfile.Location = New System.Drawing.Point(154, 173)
        Me.btnLoadProfile.Name = "btnLoadProfile"
        Me.btnLoadProfile.Size = New System.Drawing.Size(125, 23)
        Me.btnLoadProfile.TabIndex = 7
        Me.btnLoadProfile.Text = "Load profile"
        Me.btnLoadProfile.UseVisualStyleBackColor = True
        '
        'btnOpenProfileEditor
        '
        Me.btnOpenProfileEditor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenProfileEditor.Location = New System.Drawing.Point(12, 202)
        Me.btnOpenProfileEditor.Name = "btnOpenProfileEditor"
        Me.btnOpenProfileEditor.Size = New System.Drawing.Size(136, 23)
        Me.btnOpenProfileEditor.TabIndex = 8
        Me.btnOpenProfileEditor.Text = "Open Profile Editor"
        Me.btnOpenProfileEditor.UseVisualStyleBackColor = True
        '
        'btnSettings
        '
        Me.btnSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettings.Location = New System.Drawing.Point(154, 202)
        Me.btnSettings.Name = "btnSettings"
        Me.btnSettings.Size = New System.Drawing.Size(125, 23)
        Me.btnSettings.TabIndex = 11
        Me.btnSettings.Text = "Settings"
        Me.btnSettings.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(291, 237)
        Me.Controls.Add(Me.btnSettings)
        Me.Controls.Add(Me.btnOpenProfileEditor)
        Me.Controls.Add(Me.btnLoadProfile)
        Me.Controls.Add(Me.btnSaveProfile)
        Me.Controls.Add(Me.gbProfileDemo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profile Manager Demo"
        Me.gbProfileDemo.ResumeLayout(False)
        Me.gbProfileDemo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cb1 As CheckBox
    Friend WithEvents cb2 As CheckBox
    Friend WithEvents rbtn1 As RadioButton
    Friend WithEvents rbtn3 As RadioButton
    Friend WithEvents rbtn2 As RadioButton
    Friend WithEvents gbProfileDemo As GroupBox
    Friend WithEvents tb1 As TextBox
    Friend WithEvents btnSaveProfile As Button
    Friend WithEvents btnLoadProfile As Button
    Friend WithEvents btnOpenProfileEditor As Button
    Friend WithEvents btnSettings As Button
End Class
