<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Current
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
        btn_confirm = New Button()
        btn_change = New Button()
        Label1 = New Label()
        Label2 = New Label()
        tb_currentmed = New TextBox()
        tb_dose = New TextBox()
        SuspendLayout()
        ' 
        ' btn_confirm
        ' 
        btn_confirm.Location = New Point(302, 180)
        btn_confirm.Name = "btn_confirm"
        btn_confirm.Size = New Size(112, 34)
        btn_confirm.TabIndex = 0
        btn_confirm.Text = "Confirm"
        btn_confirm.UseVisualStyleBackColor = True
        ' 
        ' btn_change
        ' 
        btn_change.Location = New Point(147, 180)
        btn_change.Name = "btn_change"
        btn_change.Size = New Size(149, 34)
        btn_change.TabIndex = 1
        btn_change.Text = "Change Dose"
        btn_change.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(23, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(167, 25)
        Label1.TabIndex = 2
        Label1.Text = "Current Medication:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(23, 93)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 25)
        Label2.TabIndex = 3
        Label2.Text = "Prescribed Dose:"
        ' 
        ' tb_currentmed
        ' 
        tb_currentmed.Enabled = False
        tb_currentmed.Location = New Point(27, 55)
        tb_currentmed.Name = "tb_currentmed"
        tb_currentmed.Size = New Size(382, 31)
        tb_currentmed.TabIndex = 4
        ' 
        ' tb_dose
        ' 
        tb_dose.Enabled = False
        tb_dose.Location = New Point(27, 129)
        tb_dose.Name = "tb_dose"
        tb_dose.Size = New Size(382, 31)
        tb_dose.TabIndex = 5
        ' 
        ' Current
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(446, 239)
        Controls.Add(tb_dose)
        Controls.Add(tb_currentmed)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btn_change)
        Controls.Add(btn_confirm)
        MaximizeBox = False
        Name = "Current"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Current"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_confirm As Button
    Friend WithEvents btn_change As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tb_currentmed As TextBox
    Friend WithEvents tb_dose As TextBox
End Class
