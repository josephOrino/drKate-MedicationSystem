<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProfile
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
        GroupBox1 = New GroupBox()
        tb_sex = New TextBox()
        tb_age = New TextBox()
        tb_ptname = New TextBox()
        tb_ptid = New TextBox()
        Label5 = New Label()
        Label4 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        btn_add = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(tb_sex)
        GroupBox1.Controls.Add(tb_age)
        GroupBox1.Controls.Add(tb_ptname)
        GroupBox1.Controls.Add(tb_ptid)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(11, 11)
        GroupBox1.Margin = New Padding(2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2)
        GroupBox1.Size = New Size(291, 158)
        GroupBox1.TabIndex = 8
        GroupBox1.TabStop = False
        GroupBox1.Text = "Patient Info"
        ' 
        ' tb_sex
        ' 
        tb_sex.Location = New Point(91, 126)
        tb_sex.Margin = New Padding(2)
        tb_sex.Name = "tb_sex"
        tb_sex.Size = New Size(196, 27)
        tb_sex.TabIndex = 10
        ' 
        ' tb_age
        ' 
        tb_age.Location = New Point(91, 94)
        tb_age.Margin = New Padding(2)
        tb_age.Name = "tb_age"
        tb_age.Size = New Size(196, 27)
        tb_age.TabIndex = 9
        ' 
        ' tb_ptname
        ' 
        tb_ptname.Location = New Point(91, 62)
        tb_ptname.Margin = New Padding(2)
        tb_ptname.Name = "tb_ptname"
        tb_ptname.Size = New Size(196, 27)
        tb_ptname.TabIndex = 8
        ' 
        ' tb_ptid
        ' 
        tb_ptid.Enabled = False
        tb_ptid.Location = New Point(91, 30)
        tb_ptid.Margin = New Padding(2)
        tb_ptid.Name = "tb_ptid"
        tb_ptid.Size = New Size(196, 27)
        tb_ptid.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 31)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 20)
        Label5.TabIndex = 6
        Label5.Text = "Patient ID:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(12, 127)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 20)
        Label4.TabIndex = 5
        Label4.Text = "Sex: "
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 63)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 20)
        Label2.TabIndex = 3
        Label2.Text = "Name: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 95)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 20)
        Label3.TabIndex = 4
        Label3.Text = "Age: "
        ' 
        ' btn_add
        ' 
        btn_add.Location = New Point(186, 174)
        btn_add.Name = "btn_add"
        btn_add.Size = New Size(116, 27)
        btn_add.TabIndex = 9
        btn_add.Text = "Add"
        btn_add.UseVisualStyleBackColor = True
        ' 
        ' AddProfile
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(320, 211)
        Controls.Add(btn_add)
        Controls.Add(GroupBox1)
        Name = "AddProfile"
        StartPosition = FormStartPosition.CenterScreen
        Text = "AddProfile"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tb_sex As TextBox
    Friend WithEvents tb_age As TextBox
    Friend WithEvents tb_ptname As TextBox
    Friend WithEvents tb_ptid As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_add As Button
End Class
