Public Class Medic
    Private Sub btn_current_Click(sender As Object, e As EventArgs) Handles btn_current.Click
        If Pres = "" Then
            MsgBox("No medication found. Please create a new one", vbCritical, "Error")
        Else
            Current.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        If id = "" Then
            MsgBox("No patient selected. Please select first.", vbCritical, "Error")
        Else
            NewMedic.Show()
        End If
        Me.Close()
    End Sub

    Private Sub btn_formulary_Click(sender As Object, e As EventArgs) Handles btn_formulary.Click
        Formulary.Show()
        Me.Close()
    End Sub

    Private Sub Medic_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class