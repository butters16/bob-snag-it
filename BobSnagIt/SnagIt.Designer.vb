<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SnagIt
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SnagItButton = New System.Windows.Forms.Button
        Me.SiteIdNumericUpDown = New System.Windows.Forms.NumericUpDown
        Me.LabelComboBox = New System.Windows.Forms.ComboBox
        Me.DoNotSaveCompleteCheckBox = New System.Windows.Forms.CheckBox
        CType(Me.SiteIdNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SnagItButton
        '
        Me.SnagItButton.Location = New System.Drawing.Point(12, 89)
        Me.SnagItButton.Name = "SnagItButton"
        Me.SnagItButton.Size = New System.Drawing.Size(293, 25)
        Me.SnagItButton.TabIndex = 0
        Me.SnagItButton.Text = "Snag It, Bob"
        Me.SnagItButton.UseVisualStyleBackColor = True
        '
        'SiteIdNumericUpDown
        '
        Me.SiteIdNumericUpDown.Location = New System.Drawing.Point(12, 12)
        Me.SiteIdNumericUpDown.Maximum = New Decimal(New Integer() {276447232, 23283, 0, 0})
        Me.SiteIdNumericUpDown.Name = "SiteIdNumericUpDown"
        Me.SiteIdNumericUpDown.Size = New System.Drawing.Size(293, 20)
        Me.SiteIdNumericUpDown.TabIndex = 5
        '
        'LabelComboBox
        '
        Me.LabelComboBox.FormattingEnabled = True
        Me.LabelComboBox.Items.AddRange(New Object() {"Start", "Search", "Clear", "ClearUsingDob", "HitOpen_List", "HitOpen_ListFirst", "HitOpen_ListMiddle", "HitOpen_ListLast", "HitOpen_Details", "HitDismiss_List", "HitDismiss_ListFirst", "HitDismiss_ListMiddle", "HitDismiss_ListLast", "HitDismiss_Details", "HitMultiCaseMultiCharge_List", "HitMultiCaseMultiCharge_ListFirst", "HitMultiCaseMultiCharge_ListMiddle", "HitMultiCaseMultiCharge_ListLast", "HitMultiCaseMultiCharge_Details1", "HitMultiCaseMultiCharge_Details2"})
        Me.LabelComboBox.Location = New System.Drawing.Point(12, 38)
        Me.LabelComboBox.Name = "LabelComboBox"
        Me.LabelComboBox.Size = New System.Drawing.Size(293, 21)
        Me.LabelComboBox.TabIndex = 6
        '
        'DoNotSaveCompleteCheckBox
        '
        Me.DoNotSaveCompleteCheckBox.AutoSize = True
        Me.DoNotSaveCompleteCheckBox.Location = New System.Drawing.Point(12, 66)
        Me.DoNotSaveCompleteCheckBox.Name = "DoNotSaveCompleteCheckBox"
        Me.DoNotSaveCompleteCheckBox.Size = New System.Drawing.Size(292, 17)
        Me.DoNotSaveCompleteCheckBox.TabIndex = 7
        Me.DoNotSaveCompleteCheckBox.Text = "Do not save complete or web archive (due to page load)"
        Me.DoNotSaveCompleteCheckBox.UseVisualStyleBackColor = True
        '
        'SnagIt
        '
        Me.AcceptButton = Me.SnagItButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 128)
        Me.Controls.Add(Me.DoNotSaveCompleteCheckBox)
        Me.Controls.Add(Me.SiteIdNumericUpDown)
        Me.Controls.Add(Me.SnagItButton)
        Me.Controls.Add(Me.LabelComboBox)
        Me.Name = "SnagIt"
        Me.Text = "Bob SnagIt"
        CType(Me.SiteIdNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SnagItButton As System.Windows.Forms.Button
    Friend WithEvents SiteIdNumericUpDown As System.Windows.Forms.NumericUpDown
    Friend WithEvents LabelComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents DoNotSaveCompleteCheckBox As System.Windows.Forms.CheckBox

End Class
