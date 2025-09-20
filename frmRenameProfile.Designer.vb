<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRenameProfile
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnRename = New System.Windows.Forms.Button()
        Me.tbSaveProfileAs = New System.Windows.Forms.TextBox()
        Me.lblRenameProfileTo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(244, 64)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 23)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnRename
        '
        Me.btnRename.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRename.Location = New System.Drawing.Point(129, 64)
        Me.btnRename.Name = "btnRename"
        Me.btnRename.Size = New System.Drawing.Size(109, 23)
        Me.btnRename.TabIndex = 6
        Me.btnRename.Text = "Rename"
        Me.btnRename.UseVisualStyleBackColor = True
        '
        'tbSaveProfileAs
        '
        Me.tbSaveProfileAs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSaveProfileAs.Location = New System.Drawing.Point(15, 33)
        Me.tbSaveProfileAs.Name = "tbSaveProfileAs"
        Me.tbSaveProfileAs.Size = New System.Drawing.Size(338, 22)
        Me.tbSaveProfileAs.TabIndex = 5
        '
        'lblRenameProfileTo
        '
        Me.lblRenameProfileTo.AutoSize = True
        Me.lblRenameProfileTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRenameProfileTo.Location = New System.Drawing.Point(12, 9)
        Me.lblRenameProfileTo.Name = "lblRenameProfileTo"
        Me.lblRenameProfileTo.Size = New System.Drawing.Size(122, 16)
        Me.lblRenameProfileTo.TabIndex = 4
        Me.lblRenameProfileTo.Text = "Rename profile to..."
        '
        'frmRenameProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(368, 102)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnRename)
        Me.Controls.Add(Me.tbSaveProfileAs)
        Me.Controls.Add(Me.lblRenameProfileTo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmRenameProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rename Profile"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnRename As Button
    Friend WithEvents tbSaveProfileAs As TextBox
    Friend WithEvents lblRenameProfileTo As Label
End Class
