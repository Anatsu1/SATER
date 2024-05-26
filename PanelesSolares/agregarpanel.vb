Imports System.Data.OleDb
Imports System.Data
Public Class agregarpanel
    Dim conexion As New OleDbConnection
    Dim comandos As New OleDbCommand
    Private Sub agregarpanel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=paneleSolares.mdb;Persist Security Info=False"
            conexion.Open()
            actualizardatagrid()
        Catch ex As Exception
            MsgBox("error, no se conecto", vbCritical, "sin conexion")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtTipo.Text = "" Or txtWatts.Text = "" Or txtModelo.Text = "" Or txtMarca.Text = "" Or txtEficiencia.Text = "" Or txtDimensiones.Text = "" Then
            MsgBox("No puede dejar campos vacios")
        Else
            If Val(txtEficiencia.Text) > 100 Or Val(txtEficiencia.Text) = 0 Then
                MsgBox("no puede existir mas de 100% de eficiencia o 0%")
            Else
                Try
                    comandos = New OleDbCommand("INSERT INTO paneles(tipoPanel,watts,eficiencia,marca,modelo,dimensiones)" & Chr(13) & "VALUES (txtTipo, CDbl(txtWatts), CDbl(txtEficiencia), txtMarca, txtModelo, txtDimensiones)", conexion)
                    comandos.Parameters.AddWithValue("@tipoPanel", txtTipo.Text)
                    comandos.Parameters.AddWithValue("@watts", CDbl(txtWatts.Text))
                    comandos.Parameters.AddWithValue("@eficiencia", CDbl(txtEficiencia.Text))
                    comandos.Parameters.AddWithValue("@marca", txtMarca.Text)
                    comandos.Parameters.AddWithValue("@modelo", txtModelo.Text)
                    comandos.Parameters.AddWithValue("@dimensiones", txtDimensiones.Text)
                    comandos.ExecuteNonQuery()
                    MsgBox("guardado", vbInformation, "correctamente")
                    actualizardatagrid()
                Catch ex As Exception
                    MsgBox("error", vbCritical, "atencion")
                End Try
            End If
        End If
    End Sub
    Private Sub actualizardatagrid()
        Dim adaptador As New OleDbDataAdapter
        Dim registro As New DataSet
        Dim consulta As String
        consulta = "SELECT * FROM paneles"
        adaptador = New OleDbDataAdapter(consulta, conexion)
        registro.Tables.Add("paneles")
        adaptador.Fill(registro.Tables("paneles"))
        dgvelectro.DataSource = registro.Tables("paneles")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        opcionespanel.Show()
        Me.Hide()
    End Sub

    Private Sub txtTipo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTipo.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Public Sub solonumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or (e.KeyChar) = "," Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub txtWatts_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWatts.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txtEficiencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEficiencia.KeyPress
        solonumeros(e)
    End Sub

    Private Sub txtMarca_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMarca.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtModelo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtModelo.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtDimensiones_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDimensiones.KeyPress
        If Char.IsDigit(e.KeyChar) Or (e.KeyChar) = "x" Or (e.KeyChar) = "," Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtEficiencia_TextChanged(sender As Object, e As EventArgs) Handles txtEficiencia.TextChanged
        If Not IsNumeric(txtEficiencia.Text) And txtEficiencia.Text.Contains(",") Then
            MsgBox("ERROR, valor invalido.")
            txtEficiencia.Clear()
            Exit Sub
        End If
    End Sub

    Private Sub txtWatts_TextChanged(sender As Object, e As EventArgs) Handles txtWatts.TextChanged
        If Not IsNumeric(txtWatts.Text) And txtWatts.Text.Contains(",") Then
            MsgBox("ERROR, valor invalido.")
            txtWatts.Clear()
            Exit Sub
        End If
    End Sub

    Private Sub txtDimensiones_TextChanged(sender As Object, e As EventArgs) Handles txtDimensiones.TextChanged
        If Not IsNumeric(txtDimensiones.Text) And txtDimensiones.Text.Contains(",") Then
            MsgBox("ERROR, valor invalido.")
            txtDimensiones.Clear()
            Exit Sub
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        inicio.Show()
        Me.Close()
    End Sub
End Class