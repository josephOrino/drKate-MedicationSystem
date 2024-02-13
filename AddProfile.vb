Imports MedicationSystem.Form1

Public Class AddProfile
    Dim pt_id As String
    Private Sub AddProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Connect.Open()
            Query = "SELECT patient_id FROM profile ORDER BY patient_id DESC LIMIT 1;"
            With Command
                .Connection = Connect
                .CommandText = Query
            End With


            Reader = Command.ExecuteReader

            Do While Reader.Read = True
                pt_id = Reader("patient_id")
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
        Dim toconvert As String = pt_id(3) & pt_id(4) & pt_id(5) & pt_id(6)
        Dim toInt As Integer = Integer.Parse(toconvert)
        toInt += 1
        Dim final As String
        If toInt >= 10 And toInt <= 99 Then
            final = "PT-00" & toInt
        ElseIf toInt >= 100 And toInt <= 999 Then
            final = "PT-0" & toInt
        ElseIf toInt >= 1000 And toInt <= 9999 Then
            final = "PT-" & toInt
        Else
            final = "PT-000" & toInt
        End If
        tb_ptid.Text = final
    End Sub

    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If tb_ptname.Text = "" Or tb_age.Text = "" Or tb_sex.Text = "" Then
            MsgBox("Please make sure no field is empty.", vbCritical, "Error")
        Else
            Try
                Connect.Open()
                Query = "INSERT INTO `profile`(`patient_id`, `name`, `age`, `sex`) 
                    VALUES ('" & tb_ptid.Text & "','" & tb_ptname.Text & "','" & tb_age.Text & "','" & tb_sex.Text & "')"
                With Command
                    .Connection = Connect
                    .CommandText = Query
                End With
                MsgBox("Profile Added!", vbInformation, "Success")

                Reader = Command.ExecuteReader
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Connect.Close()
            End Try
            tb_ptname.Clear()
            tb_age.Clear()
            tb_sex.Clear()
            fillSource(Form1.tb_search, "profile", "name")
            Me.Close()
        End If

    End Sub
End Class