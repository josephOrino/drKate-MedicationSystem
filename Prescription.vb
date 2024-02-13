Public Class Prescription
    Private Sub Prescription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Connect.Open()
            Query = "SELECT * FROM `profile` WHERE `patient_id` LIKE '" & id & "'"
            With Command
                .Connection = Connect
                .CommandText = Query
            End With

            Reader = Command.ExecuteReader

            Do While Reader.Read = True
                lbl_name.Text = Reader("name")
                lbl_age.Text = Reader("age")
                lbl_sex.Text = Reader("sex")
                lbl_pres.Text = Reader("medication") & " " & Reader("dose") & " mg"
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub

    Private Sub btn_change_Click(sender As Object, e As EventArgs) Handles btn_change.Click
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub btn_finish_Click(sender As Object, e As EventArgs) Handles btn_finish.Click
        MsgBox("Changes made.", vbInformation, "")
        Me.Close()

    End Sub
End Class