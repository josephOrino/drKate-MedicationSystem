Imports MedicationSystem.NewMedic

Public Class Formulary
    Private Sub Formulary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        toSql("SELECT * FROM `drugs`")
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NewMedic.Show()
        Me.Close()
    End Sub

    Private Sub lv_medic_Click(sender As Object, e As EventArgs) Handles lv_medic.Click
        NewMedic.tb_currentmed.Text = lv_medic.SelectedItems(0).SubItems(0).Text
        NewMedic.tb_dose.Text = lv_medic.SelectedItems(0).SubItems(1).Text
        min = lv_medic.SelectedItems(0).SubItems(1).Text
        max = lv_medic.SelectedItems(0).SubItems(2).Text
        NewMedic.lbl_dose.Text = "Prescribed dose: (" & min & " - " & max & ")"
    End Sub

    Private Sub tb_search_TextChanged(sender As Object, e As EventArgs) Handles tb_search.TextChanged
        Query = "SELECT * FROM `drugs` WHERE `drug_name` LIKE '%" & tb_search.Text & "%'"
        Try
            Connect.Open()
            With Command
                .Connection = Connect
                .CommandText = Query
            End With

            Reader = Command.ExecuteReader
            lv_medic.Items.Clear()
            Do While Reader.Read = True
                Dim list = lv_medic.Items.Add(Reader("drug_name"))
                list.Subitems.Add(Reader("min_dose"))
                list.Subitems.Add(Reader("max_dose"))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub
End Class