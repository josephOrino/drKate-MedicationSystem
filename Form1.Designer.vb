<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        pbox_prof = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        GroupBox1 = New GroupBox()
        tb_sex = New TextBox()
        tb_age = New TextBox()
        tb_ptname = New TextBox()
        tb_ptid = New TextBox()
        btn_edit = New Button()
        btn_medi = New Button()
        btn_add = New Button()
        CType(pbox_prof, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(17, 17)
        Label1.Margin = New Padding(2, 0, 2, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(67, 23)
        Label1.TabIndex = 0
        Label1.Text = "Patient:"
        ' 
        ' tb_search
        ' 
        tb_search.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        tb_search.AutoCompleteSource = AutoCompleteSource.CustomSource
        tb_search.Location = New Point(82, 17)
        tb_search.Margin = New Padding(2, 2, 2, 2)
        tb_search.Name = "tb_search"
        tb_search.Size = New Size(305, 27)
        tb_search.TabIndex = 1
        ' 
        ' pbox_prof
        ' 
        pbox_prof.Image = My.Resources.Resources.Male
        pbox_prof.Location = New Point(17, 79)
        pbox_prof.Margin = New Padding(2, 2, 2, 2)
        pbox_prof.Name = "pbox_prof"
        pbox_prof.Size = New Size(208, 208)
        pbox_prof.SizeMode = PictureBoxSizeMode.StretchImage
        pbox_prof.TabIndex = 2
        pbox_prof.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 64)
        Label2.Margin = New Padding(2, 0, 2, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 20)
        Label2.TabIndex = 3
        Label2.Text = "Name: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(13, 96)
        Label3.Margin = New Padding(2, 0, 2, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 20)
        Label3.TabIndex = 4
        Label3.Text = "Age: "
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(13, 128)
        Label4.Margin = New Padding(2, 0, 2, 0)
        Label4.Name = "Label4"
        Label4.Size = New Size(39, 20)
        Label4.TabIndex = 5
        Label4.Text = "Sex: "
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(13, 32)
        Label5.Margin = New Padding(2, 0, 2, 0)
        Label5.Name = "Label5"
        Label5.Size = New Size(76, 20)
        Label5.TabIndex = 6
        Label5.Text = "Patient ID:"
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
        GroupBox1.Location = New Point(243, 65)
        GroupBox1.Margin = New Padding(2, 2, 2, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(2, 2, 2, 2)
        GroupBox1.Size = New Size(291, 158)
        GroupBox1.TabIndex = 7
        GroupBox1.TabStop = False
        GroupBox1.Text = "Patient Info"
        ' 
        ' tb_sex
        ' 
        tb_sex.Enabled = False
        tb_sex.Location = New Point(91, 126)
        tb_sex.Margin = New Padding(2, 2, 2, 2)
        tb_sex.Name = "tb_sex"
        tb_sex.Size = New Size(196, 27)
        tb_sex.TabIndex = 10
        ' 
        ' tb_age
        ' 
        tb_age.Enabled = False
        tb_age.Location = New Point(91, 94)
        tb_age.Margin = New Padding(2, 2, 2, 2)
        tb_age.Name = "tb_age"
        tb_age.Size = New Size(196, 27)
        tb_age.TabIndex = 9
        ' 
        ' tb_ptname
        ' 
        tb_ptname.Enabled = False
        tb_ptname.Location = New Point(91, 62)
        tb_ptname.Margin = New Padding(2, 2, 2, 2)
        tb_ptname.Name = "tb_ptname"
        tb_ptname.Size = New Size(196, 27)
        tb_ptname.TabIndex = 8
        ' 
        ' tb_ptid
        ' 
        tb_ptid.Enabled = False
        tb_ptid.Location = New Point(91, 30)
        tb_ptid.Margin = New Padding(2, 2, 2, 2)
        tb_ptid.Name = "tb_ptid"
        tb_ptid.Size = New Size(196, 27)
        tb_ptid.TabIndex = 7
        ' 
        ' btn_edit
        ' 
        btn_edit.Location = New Point(243, 228)
        btn_edit.Margin = New Padding(2, 2, 2, 2)
        btn_edit.Name = "btn_edit"
        btn_edit.Size = New Size(136, 32)
        btn_edit.TabIndex = 8
        btn_edit.Text = "Edit Info"
        btn_edit.UseVisualStyleBackColor = True
        ' 
        ' btn_medi
        ' 
        btn_medi.Location = New Point(243, 265)
        btn_medi.Margin = New Padding(2, 2, 2, 2)
        btn_medi.Name = "btn_medi"
        btn_medi.Size = New Size(136, 32)
        btn_medi.TabIndex = 9
        btn_medi.Text = "Medication"
        btn_medi.UseVisualStyleBackColor = True
        ' 
        ' btn_add
        ' 
        btn_add.Location = New Point(406, 17)
        btn_add.Margin = New Padding(2, 2, 2, 2)
        btn_add.Name = "btn_add"
        btn_add.Size = New Size(129, 27)
        btn_add.TabIndex = 10
        btn_add.Text = "Add New Record"
        btn_add.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(555, 327)
        Controls.Add(btn_add)
        Controls.Add(btn_medi)
        Controls.Add(btn_edit)
        Controls.Add(GroupBox1)
        Controls.Add(pbox_prof)
        Controls.Add(tb_search)
        Controls.Add(Label1)
        Margin = New Padding(2, 2, 2, 2)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Medication System"
        CType(pbox_prof, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tb_search As TextBox
    Friend WithEvents pbox_prof As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_edit As Button
    Friend WithEvents btn_medi As Button
    Friend WithEvents btn_add As Button
    Friend WithEvents tb_sex As TextBox
    Friend WithEvents tb_age As TextBox
    Friend WithEvents tb_ptname As TextBox
    Friend WithEvents tb_ptid As TextBox
End Class
