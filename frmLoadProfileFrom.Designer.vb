<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLoadProfileFrom
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblLoadProfileFrom = New System.Windows.Forms.Label()
        Me.cbxProfiles = New System.Windows.Forms.ComboBox()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.settings = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'lblLoadProfileFrom
        '
        Me.lblLoadProfileFrom.AutoSize = True
        Me.lblLoadProfileFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoadProfileFrom.Location = New System.Drawing.Point(12, 9)
        Me.lblLoadProfileFrom.Name = "lblLoadProfileFrom"
        Me.lblLoadProfileFrom.Size = New System.Drawing.Size(116, 16)
        Me.lblLoadProfileFrom.TabIndex = 0
        Me.lblLoadProfileFrom.Text = "Load profile from..."
        '
        'cbxProfiles
        '
        Me.cbxProfiles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxProfiles.FormattingEnabled = True
        Me.cbxProfiles.Location = New System.Drawing.Point(15, 29)
        Me.cbxProfiles.Name = "cbxProfiles"
        Me.cbxProfiles.Size = New System.Drawing.Size(347, 21)
        Me.cbxProfiles.TabIndex = 1
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(138, 67)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(109, 23)
        Me.btnLoad.TabIndex = 3
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(253, 67)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 23)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'settings
        '
        Me.settings.Location = New System.Drawing.Point(15, 116)
        Me.settings.Name = "settings"
        Me.settings.Size = New System.Drawing.Size(347, 31)
        Me.settings.TabIndex = 5
        Me.settings.Text = ""
        '
        'frmLoadProfileFrom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(374, 105)
        Me.Controls.Add(Me.settings)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.cbxProfiles)
        Me.Controls.Add(Me.lblLoadProfileFrom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLoadProfileFrom"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Load profile from..."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLoadProfileFrom As Label
    Friend WithEvents cbxProfiles As ComboBox
    Friend WithEvents btnLoad As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents settings As RichTextBox
End Class
