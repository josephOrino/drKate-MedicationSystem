Public Class Current
    Dim counter As Integer
    Private Sub Current_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        counter = 0
        Try
            Connect.Open()
            Query = "SELECT * FROM `profile` WHERE `patient_id` LIKE '" & id & "'"
            With Command
                .Connection = Connect
                .CommandText = Query
            End With

            Reader = Command.ExecuteReader

            Do While Reader.Read = True
                tb_currentmed.Text = Reader("medication")
                tb_dose.Text = Reader("dose")
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub

    Private Sub btn_change_Click(sender As Object, e As EventArgs) Handles btn_change.Click
        counter += 1
        If counter Mod 2 = 0 Then
            tb_currentmed.Enabled = False
            tb_dose.Enabled = False
            btn_change.Text = "Change Dose"
            Try
                Connect.Open()
                Query = "
                        UPDATE `profile` 
                        SET `dose` = " & tb_dose.Text & " 
                        WHERE `profile`.`patient_id` = '" & id & "';"
                With Command
                    .Connection = Connect
                    .CommandText = Query
                End With

                Reader = Command.ExecuteReader

                Do While Reader.Read = True
                    tb_currentmed.Text = Reader("medication")
                    tb_dose.Text = Reader("dose")
                Loop
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connect.Close()
            End Try
        Else
            tb_dose.Enabled = True
            btn_change.Text = "Update Dose"
        End If
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
                Prescription.Show()
                Me.Close()
            End If
        End If



    End Sub
End Class