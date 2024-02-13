Imports MySql.Data.MySqlClient
Public Class Form1
    Dim counter As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillSource(tb_search, "profile", "name")
        counter = 0
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        counter += 1
        If counter Mod 2 = 0 Then
            Try
                Connect.Open()
                Query = "UPDATE `profile` SET `name` = '" & tb_ptname.Text & "', `age` = '" & tb_age.Text & "', `sex` = '" & tb_sex.Text & "' WHERE `profile`.`patient_id` = '" & tb_ptid.Text & "';"
                With Command
                    .Connection = Connect
                    .CommandText = Query
                End With
                Reader = Command.ExecuteReader
                MsgBox("Changes made!", vbInformation, "Success")
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connect.Close()
            End Try
            fillSource(tb_search, "profile", "name")
            tb_ptname.Enabled = False
            tb_age.Enabled = False
            tb_sex.Enabled = False
            btn_edit.Text = "Edit Info"
        Else
            tb_ptname.Enabled = True
            tb_age.Enabled = True
            tb_sex.Enabled = True
            btn_edit.Text = "Update Info"
        End If
    End Sub

    Private Sub tb_search_TextChanged(sender As Object, e As EventArgs) Handles tb_search.TextChanged
        Query = "SELECT * FROM `profile` WHERE `name` LIKE '%" & tb_search.Text & "'"
        showData(Query)
    End Sub

    Private Sub btn_medi_Click(sender As Object, e As EventArgs) Handles btn_medi.Click
        If tb_search.Text = "" Then
            MsgBox("Please select patient first.", vbInformation, "Reminder")
        Else
            Medic.Show()
        End If

    End Sub

    Private Sub tb_ptname_TextChanged(sender As Object, e As EventArgs) Handles tb_ptname.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        AddProfile.ShowDialog()

    End Sub
End Class
