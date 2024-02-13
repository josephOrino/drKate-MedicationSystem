Imports MedicationSystem.Form1
Public Class NewMedic

    Private Sub NewMedic_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillSource(tb_currentmed, "drugs", "drug_name")
    End Sub

    Private Sub btn_confirm_Click(sender As Object, e As EventArgs) Handles btn_confirm.Click
        Try
            Connect.Open()
            Query = "SELECT * FROM `drugs` WHERE `drug_name` LIKE '%" & tb_currentmed.Text & "'"
            With Command
                .Connection = Connect
                .CommandText = Query
            End With
            Reader = Command.ExecuteReader
            Do While Reader.Read = True
                min = Reader("min_dose")
                max = Reader("max_dose")
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
        If (tb_currentmed.Text = "" And tb_dose.Text = "") Then
            MsgBox("Please make sure textbox is not empty.", vbCritical, "Error")
        ElseIf (Integer.Parse(tb_dose.Text) < min Or Integer.Parse(tb_dose.Text) > max) Then
            MsgBox("Dose is not within approved range. Please refer to formulary for more info.", vbCritical, "Error")
        Else
            If MsgBox("Submit the following prescription?", vbQuestion + vbYesNo, "") = vbYes Then
                Try
                    Connect.Open()
                    Query = "
                        UPDATE `profile` 
                        SET `medication` = '" & tb_currentmed.Text & "', 
                        `dose` = " & tb_dose.Text & " 
                        WHERE `profile`.`patient_id` = '" & id & "';"
                    With Command
                        .Connection = Connect
                        .CommandText = Query
                    End With
                    Reader = Command.ExecuteReader
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    Connect.Close()
                End Try
                Prescription.Show()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub NewMedic_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        fillSource(Form1.tb_search, "profile", "name")
    End Sub
End Class