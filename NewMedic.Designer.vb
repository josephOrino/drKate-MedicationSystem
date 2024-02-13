<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class NewMedic
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
        Label1 = New Label()
        lbl_dose = New Label()
        tb_currentmed = New TextBox()
        tb_dose = New TextBox()
        SuspendLayout()
        ' 
        ' btn_confirm
        ' 
        btn_confirm.Location = New Point(242, 144)
        btn_confirm.Margin = New Padding(2, 2, 2, 2)
        btn_confirm.Name = "btn_confirm"
        btn_confirm.Size = New Size(90, 27)
        btn_confirm.TabIndex = 0
        btn_confirm.Text = "Confirm"
        btn_confirm.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(18, 17)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 20)
        Label1.TabIndex = 2
        Label1.Text = "New Medication:"
        ' 
        ' lbl_dose
        ' 
        lbl_dose.AutoSize = True
        lbl_dose.Location = New Point(18, 74)
        lbl_dose.Margin = New Padding(2, 0, 2, 0)
        lbl_dose.Name = "lbl_dose"
        lbl_dose.Size = New Size(119, 20)
        lbl_dose.TabIndex = 3
        lbl_dose.Text = "Prescribed Dose:"
        ' 
        ' tb_currentmed
        ' 
        tb_currentmed.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tb_currentmed.AutoCompleteSource = AutoCompleteSource.CustomSource
        tb_currentmed.Location = New Point(22, 44)
        tb_currentmed.Margin = New Padding(2, 2, 2, 2)
        tb_currentmed.Name = "tb_currentmed"
        tb_currentmed.Size = New Size(306, 27)
        tb_currentmed.TabIndex = 4
        ' 
        ' tb_dose
        ' 
        tb_dose.Location = New Point(22, 103)
        tb_dose.Margin = New Padding(2, 2, 2, 2)
        tb_dose.Name = "tb_dose"
        tb_dose.Size = New Size(306, 27)
        tb_dose.TabIndex = 5
        ' 
        ' NewMedic
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(357, 191)
        Controls.Add(tb_dose)
        Controls.Add(tb_currentmed)
        Controls.Add(lbl_dose)
        Controls.Add(Label1)
        Controls.Add(btn_confirm)
        Margin = New Padding(2, 2, 2, 2)
        Name = "NewMedic"
        StartPosition = FormStartPosition.CenterScreen
        Text = "New Medication"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btn_confirm As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_dose As Label
    Friend WithEvents tb_currentmed As TextBox
    Friend WithEvents tb_dose As TextBox
End Class
