<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formulary
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
        Label1 = New Label()
        tb_search = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        med_name = New ColumnHeader()
        min_dose = New ColumnHeader()
        max_dose = New ColumnHeader()
        lv_medic = New ListView()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(26, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(154, 25)
        Label1.TabIndex = 0
        Label1.Text = "Search medicine:  "
        ' 
        ' tb_search
        ' 
        tb_search.Location = New Point(170, 26)
        tb_search.Name = "tb_search"
        tb_search.Size = New Size(268, 31)
        tb_search.TabIndex = 1
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(630, 437)
        Button1.Name = "Button1"
        Button1.Size = New Size(147, 34)
        Button1.TabIndex = 3
        Button1.Text = "Proceed"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(585, 26)
        Button2.Name = "Button2"
        Button2.Size = New Size(192, 34)
        Button2.TabIndex = 4
        Button2.Text = "Add New Medicine"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' med_name
        ' 
        med_name.Text = "Medicine Name"
        med_name.Width = 400
        ' 
        ' min_dose
        ' 
        min_dose.Text = "Minimum Dose"
        min_dose.Width = 200
        ' 
        ' max_dose
        ' 
        max_dose.Text = "Maximum Dose"
        max_dose.Width = 200
        ' 
        ' lv_medic
        ' 
        lv_medic.Columns.AddRange(New ColumnHeader() {med_name, min_dose, max_dose})
        lv_medic.FullRowSelect = True
        lv_medic.GridLines = True
        lv_medic.Location = New Point(27, 77)
        lv_medic.Name = "lv_medic"
        lv_medic.Size = New Size(745, 343)
        lv_medic.TabIndex = 2
        lv_medic.UseCompatibleStateImageBehavior = False
        lv_medic.View = View.Details
        ' 
        ' Formulary
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 495)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(lv_medic)
        Controls.Add(tb_search)
        Controls.Add(Label1)
        Name = "Formulary"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Formulary"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents med_name As ColumnHeader
    Friend WithEvents min_dose As ColumnHeader
    Friend WithEvents max_dose As ColumnHeader
    Friend WithEvents lv_medic As ListView
    Friend WithEvents tb_search As TextBox
End Class
