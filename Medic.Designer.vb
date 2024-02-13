<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Medic
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btn_new = New Button()
        btn_current = New Button()
        btn_formulary = New Button()
        SuspendLayout()
        ' 
        ' btn_new
        ' 
        btn_new.Location = New Point(27, 95)
        btn_new.Name = "btn_new"
        btn_new.Size = New Size(386, 48)
        btn_new.TabIndex = 0
        btn_new.Text = "New Medication"
        btn_new.UseVisualStyleBackColor = True
        ' 
        ' btn_current
        ' 
        btn_current.Location = New Point(27, 31)
        btn_current.Name = "btn_current"
        btn_current.Size = New Size(386, 48)
        btn_current.TabIndex = 1
        btn_current.Text = "Current Medication"
        btn_current.UseVisualStyleBackColor = True
        ' 
        ' btn_formulary
        ' 
        btn_formulary.Location = New Point(27, 159)
        btn_formulary.Name = "btn_formulary"
        btn_formulary.Size = New Size(386, 48)
        btn_formulary.TabIndex = 2
        btn_formulary.Text = "Formulary"
        btn_formulary.UseVisualStyleBackColor = True
        ' 
        ' Medic
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(446, 239)
        Controls.Add(btn_formulary)
        Controls.Add(btn_current)
        Controls.Add(btn_new)
        MaximizeBox = False
        Name = "Medic"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Medic"
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn_new As Button
    Friend WithEvents btn_current As Button
    Friend WithEvents btn_formulary As Button
End Class
