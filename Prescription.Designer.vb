<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Prescription
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
        pb_rx = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lbl_pres = New Label()
        PictureBox1 = New PictureBox()
        PictureBox2 = New PictureBox()
        btn_finish = New Button()
        lbl_name = New Label()
        lbl_age = New Label()
        lbl_sex = New Label()
        btn_change = New Button()
        CType(pb_rx, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' pb_rx
        ' 
        pb_rx.Image = My.Resources.Resources.rx_icon_6
        pb_rx.Location = New Point(33, 173)
        pb_rx.Name = "pb_rx"
        pb_rx.Size = New Size(57, 58)
        pb_rx.SizeMode = PictureBoxSizeMode.StretchImage
        pb_rx.TabIndex = 0
        pb_rx.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(33, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 25)
        Label1.TabIndex = 1
        Label1.Text = "Name:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(48, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 25)
        Label2.TabIndex = 2
        Label2.Text = "Age: "
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(53, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(48, 25)
        Label3.TabIndex = 3
        Label3.Text = "Sex: "
        ' 
        ' lbl_pres
        ' 
        lbl_pres.Font = New Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point)
        lbl_pres.Location = New Point(70, 229)
        lbl_pres.Name = "lbl_pres"
        lbl_pres.Size = New Size(313, 38)
        lbl_pres.TabIndex = 4
        lbl_pres.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.long_lines_straight_line_transparent_7
        PictureBox1.Location = New Point(33, 123)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(386, 75)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 5
        PictureBox1.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.long_lines_straight_line_transparent_7
        PictureBox2.Location = New Point(33, 276)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(386, 75)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 6
        PictureBox2.TabStop = False
        ' 
        ' btn_finish
        ' 
        btn_finish.Location = New Point(283, 332)
        btn_finish.Name = "btn_finish"
        btn_finish.Size = New Size(136, 45)
        btn_finish.TabIndex = 7
        btn_finish.Text = "Finish"
        btn_finish.UseVisualStyleBackColor = True
        ' 
        ' lbl_name
        ' 
        lbl_name.Location = New Point(97, 19)
        lbl_name.Name = "lbl_name"
        lbl_name.Size = New Size(262, 25)
        lbl_name.TabIndex = 8
        ' 
        ' lbl_age
        ' 
        lbl_age.Location = New Point(97, 58)
        lbl_age.Name = "lbl_age"
        lbl_age.Size = New Size(262, 25)
        lbl_age.TabIndex = 9
        ' 
        ' lbl_sex
        ' 
        lbl_sex.Location = New Point(97, 95)
        lbl_sex.Name = "lbl_sex"
        lbl_sex.Size = New Size(262, 25)
        lbl_sex.TabIndex = 10
        ' 
        ' btn_change
        ' 
        btn_change.Location = New Point(141, 332)
        btn_change.Name = "btn_change"
        btn_change.Size = New Size(136, 45)
        btn_change.TabIndex = 11
        btn_change.Text = "Change"
        btn_change.UseVisualStyleBackColor = True
        ' 
        ' Prescription
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(446, 393)
        Controls.Add(btn_change)
        Controls.Add(lbl_sex)
        Controls.Add(lbl_age)
        Controls.Add(lbl_name)
        Controls.Add(btn_finish)
        Controls.Add(PictureBox2)
        Controls.Add(lbl_pres)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(pb_rx)
        Controls.Add(PictureBox1)
        Name = "Prescription"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Prescription"
        CType(pb_rx, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents pb_rx As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_pres As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_finish As Button
    Friend WithEvents lbl_name As Label
    Friend WithEvents lbl_age As Label
    Friend WithEvents lbl_sex As Label
    Friend WithEvents btn_change As Button
End Class
