Imports MySql.Data.MySqlClient
Imports MedicationSystem.Form1
Imports System.Data.Common
Imports MedicationSystem.Formulary

Module Module1
    Dim f1 As Form1
    Public min As Integer
    Public max As Integer
    Public Pres As String
    Public Connect As New MySqlConnection("server=localhost;userid=root;password='';database=inventorydb")
    Public Command As MySqlCommand = New MySqlCommand
    Public Reader As MySqlDataReader
    Public Query As String
    Public source As AutoCompleteStringCollection = New AutoCompleteStringCollection()
    Public id As String
    Public Sub fillSource(ByRef tb As TextBox, ByRef table As String, ByRef col As String)
        source.Clear()
        Try
            Connect.Open()
            Query = "SELECT * FROM " & table & ""
            With Command
                .Connection = Connect
                .CommandText = Query
            End With

            Reader = Command.ExecuteReader

            Do While Reader.Read = True
                source.Add(Reader(col))
            Loop
            tb.AutoCompleteCustomSource = source

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub

    Public Sub showData()
        Try
            Connect.Open()
            Query = "SELECT * FROM profile"
            With Command
                .Connection = Connect
                .CommandText = Query
            End With


            Reader = Command.ExecuteReader

            Do While Reader.Read = True

            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub

    Public Sub showData(ByRef Query As String)
        Try
            Connect.Open()
            With Command
                .Connection = Connect
                .CommandText = Query
            End With

            Reader = Command.ExecuteReader

            If Form1.tb_search.TextLength = 0 Then
                Form1.tb_ptid.Text = ""
                Form1.tb_ptname.Text = ""
                Form1.tb_age.Text = ""
                Form1.tb_sex.Text = ""
                Form1.pbox_prof.Image = My.Resources.Male
            Else
                Do While Reader.Read = True
                    id = Reader("patient_id")
                    Pres = Reader("medication")
                    Form1.tb_ptid.Text = Reader("patient_id")
                    Form1.tb_ptname.Text = Reader("name")
                    Form1.tb_age.Text = Reader("age")
                    Form1.tb_sex.Text = Reader("sex")
                    If Reader("sex") = "F" Then
                        Form1.pbox_prof.Image = My.Resources.Female
                    Else
                        Form1.pbox_prof.Image = My.Resources.Male
                    End If
                Loop
            End If


        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub

    Public Sub toSql(ByRef Query As String)
        Try
            Connect.Open()
            With Command
                .Connection = Connect
                .CommandText = Query
            End With

            Reader = Command.ExecuteReader

            Do While Reader.Read = True
                Dim list = Formulary.lv_medic.Items.Add(Reader("drug_name"))
                list.Subitems.Add(Reader("min_dose"))
                list.Subitems.Add(Reader("max_dose"))
            Loop
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            Connect.Close()
        End Try
    End Sub

End Module
