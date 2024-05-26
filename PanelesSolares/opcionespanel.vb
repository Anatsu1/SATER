Imports System.Data.OleDb
Imports System.Data
Public Class opcionespanel
    Dim conexion As New OleDbConnection
    Dim comandos As New OleDbCommand
    Dim adaptador As New OleDbDataAdapter
    Dim registros As New DataSet
    Dim codigo As Integer
    Private Sub actualizardatagrid()
        Dim adaptador As New OleDbDataAdapter
        Dim registro As New DataSet
        Dim consulta As String
        consulta = "SELECT * FROM paneles"
        adaptador = New OleDbDataAdapter(consulta, conexion)
        registro.Tables.Add("paneles")
        adaptador.Fill(registro.Tables("paneles"))
        vistapanel.DataSource = registro.Tables("paneles")
    End Sub

    Private Sub vistapanel_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles vistapanel.CellClick
        Dim i As Integer
        i = vistapanel.CurrentRow.Index
        idPanel.Text = vistapanel.Item(0, i).Value()
        txtTipo.Text = vistapanel.Item(1, i).Value()
        txtWatts.Text = vistapanel.Item(2, i).Value()
        txtEficiencia.Text = vistapanel.Item(3, i).Value()
        txtMarca.Text = vistapanel.Item(4, i).Value()
        txtModelo.Text = vistapanel.Item(5, i).Value()
        txtDimensiones.Text = vistapanel.Item(6, i).Value()
    End Sub

    Private Sub opcionespanel_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=paneleSolares.mdb;Persist Security Info=False"
            conexion.Open()
            actualizardatagrid()
        Catch ex As Exception
            MsgBox("error, no se conecto", vbCritical, "sin conexion")
        End Try
    End Sub
    Private Sub limpiar()
        idPanel.Clear()
        txtTipo.Clear()
        txtWatts.Clear()
        txtEficiencia.Clear()
        txtMarca.Clear()
        txtModelo.Clear()
        txtDimensiones.Clear()
    End Sub

    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        txtTipo.Enabled = True
        txtWatts.Enabled = True
        txtEficiencia.Enabled = True
        txtMarca.Enabled = True
        txtModelo.Enabled = True
        txtDimensiones.Enabled = True
        buscarId.Enabled = False
        buscarTipo.Enabled = False
        enviar.Enabled = True
    End Sub
    Private Sub enviar_Click(sender As Object, e As EventArgs) Handles enviar.Click
        If txtTipo.Text = "" Or txtWatts.Text = "" Or txtModelo.Text = "" Or txtMarca.Text = "" Or txtEficiencia.Text = "" Or txtDimensiones.Text = "" Then
            MsgBox("No puede dejar campos vacios")
        Else
            If Val(txtEficiencia.Text) > 100 Or Val(txtEficiencia.Text) = 0 Then
                MsgBox("no puede existir mas de 100% de eficiencia o 0%")
            Else
                Dim actualizar As String
                Dim id As Integer
                id = Val(idPanel.Text)
                actualizar = "UPDATE paneles SET tipoPanel= '" & txtTipo.Text & "', watts = '" & CDbl(txtWatts.Text) & "', eficiencia = '" & CDbl(txtEficiencia.Text) & "', marca = '" & txtMarca.Text & "', modelo = '" & txtModelo.Text & "', dimensiones = '" & txtDimensiones.Text & "' WHERE idPanel = " & id & ""
                comandos = New OleDbCommand(actualizar, conexion)
                comandos.ExecuteNonQuery()
                MsgBox("Actualizado correctamente", vbInformation, " correcto")
                actualizardatagrid()
                limpiar()
                txtTipo.Enabled = False
                txtWatts.Enabled = False
                txtEficiencia.Enabled = False
                txtMarca.Enabled = False
                txtModelo.Enabled = False
                txtDimensiones.Enabled = False
                buscarId.Enabled = True
                buscarTipo.Enabled = True
                enviar.Enabled = False
            End If
        End If
    End Sub

    Private Sub buscarId_TextChanged(sender As Object, e As EventArgs) Handles buscarId.TextChanged
        If buscarId.Text <> "" Then
            buscarTipo.Enabled = False
        Else
            buscarTipo.Enabled = True
        End If
    End Sub

    Private Sub buscarTipo_TextChanged(sender As Object, e As EventArgs) Handles buscarTipo.TextChanged
        If buscarTipo.Text <> "" Then
            buscarId.Enabled = False
        Else
            buscarId.Enabled = True
        End If
    End Sub

    Private Sub IDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IDToolStripMenuItem.Click
        Dim registros As DataSet
        Dim consultar As String
        Dim lista As Integer
        Dim num As Integer
        num = Val(buscarId.Text)
        If (buscarId.Text <> "") Then
            consultar = "SELECT * FROM paneles WHERE idPanel = " & num
            adaptador = New OleDbDataAdapter(consultar, conexion)
            registros = New DataSet
            adaptador.Fill(registros, "paneles")
            lista = registros.Tables("paneles").Rows.Count
            If lista <> 0 Then
                vistapanel.DataSource = registros
                vistapanel.DataMember = "paneles"
                idPanel.Text = registros.Tables("paneles").Rows(0).Item("idPanel")
                txtTipo.Text = registros.Tables("paneles").Rows(0).Item("tipoPanel")
                txtWatts.Text = registros.Tables("paneles").Rows(0).Item("watts")
                txtEficiencia.Text = registros.Tables("paneles").Rows(0).Item("eficiencia")
                txtMarca.Text = registros.Tables("paneles").Rows(0).Item("marca")
                txtModelo.Text = registros.Tables("paneles").Rows(0).Item("modelo")
                txtDimensiones.Text = registros.Tables("paneles").Rows(0).Item("dimensiones")
            Else
                MsgBox("NO HAY REGISTROS CON DICHO ID", vbCritical, "A T E N C I O N")
                limpiar()
            End If
        End If
    End Sub

    Private Sub TipoPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoPanelToolStripMenuItem.Click
        Dim registros As DataSet
        Dim consultar As String
        Dim lista As Integer
        If (buscarTipo.Text <> "") Then
            consultar = "SELECT * FROM paneles WHERE tipoPanel LIKE '%" & buscarTipo.Text & "%'"
            adaptador = New OleDbDataAdapter(consultar, conexion)
            registros = New DataSet
            adaptador.Fill(registros, "paneles")
            lista = registros.Tables("paneles").Rows.Count
            If lista <> 0 Then
                vistapanel.DataSource = registros
                vistapanel.DataMember = "paneles"
                idPanel.Text = registros.Tables("paneles").Rows(0).Item("idPanel")
                txtTipo.Text = registros.Tables("paneles").Rows(0).Item("tipoPanel")
                txtWatts.Text = registros.Tables("paneles").Rows(0).Item("watts")
                txtEficiencia.Text = registros.Tables("paneles").Rows(0).Item("eficiencia")
                txtMarca.Text = registros.Tables("paneles").Rows(0).Item("marca")
                txtModelo.Text = registros.Tables("paneles").Rows(0).Item("modelo")
                txtDimensiones.Text = registros.Tables("paneles").Rows(0).Item("dimensiones")
            Else
                MsgBox("NO HAY REGISTROS CON DICHO TIPO DE PANEL", vbCritical, "A T E N C I O N")
                limpiar()
            End If
        End If
    End Sub

    Private Sub VOLVERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VOLVERToolStripMenuItem.Click
        inicio.Show()
        Me.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim eliminar As String
        Dim si As Byte
        Dim num As Integer
        If idPanel.Text <> "" Then
            num = Val(idPanel.Text)
            si = MsgBox("Esta seguro que desea eliminar...", vbYesNo, "¿eliminar?")
            If si = vbYes Then
                eliminar = "DELETE FROM paneles WHERE idPanel = " & num
                comandos = New OleDbCommand(eliminar, conexion)
                comandos.ExecuteNonQuery()
                MsgBox("Eliminado correctamente", vbInformation, "Correcto")
                limpiar()
                actualizardatagrid()
            Else
                MsgBox("Cancelo la eliminacion", vbCritical, "Cancelado")
                limpiar()
            End If
        Else
            MsgBox("Tiene que seleccionar un id para poder eliminar el respectivo electrodomestico!")
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

    Private Sub txtWatts_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWatts.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtEficiencia_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEficiencia.KeyPress
        solonumeros(e)
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        actualizardatagrid()
    End Sub
End Class