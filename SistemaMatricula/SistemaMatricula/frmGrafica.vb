Imports System.Data.OleDb
Public Class frmGrafica
    Private Sub frmGrafica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0; Data Source=F:\programacion 2parcial\Sistema Matricula 2024\Base de datos\Matricula(2002-2003).mdb")
        Try
            con.Open()
            MsgBox("Conectado")

            Dim query = "Select * from Estudiante"
            Dim adap As New OleDbDataAdapter(query, con)
            Dim dt As New DataTable
            adap.Fill(dt)
            Chart1.Series("Series1").XValueMember = "nombreestudiante"
            Chart1.Series("Series1").YValueMembers = "edadestudiante"
            Chart1.DataSource = dt

        Catch ex As Exception
            MsgBox("No se conecto por: " & ex.Message)
        End Try
    End Sub
End Class