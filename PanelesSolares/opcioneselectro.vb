Imports System.Data.OleDb
Imports System.Data
Public Class opcioneselectro
    Dim conexion As New OleDbConnection
    Dim comandos As New OleDbCommand
    Dim adaptador As New OleDbDataAdapter
    Dim registros As New DataSet
    Dim codigo As Integer
    Private Sub actualizardatagrid()
        Dim adaptador As New OleDbDataAdapter
        Dim registro As New DataSet
        Dim consulta As String
        consulta = "SELECT * FROM electro"
        adaptador = New OleDbDataAdapter(consulta, conexion)
        registro.Tables.Add("electro")
        adaptador.Fill(registro.Tables("electro"))
        vistaelectro.DataSource = registro.Tables("electro")
    End Sub

    Private Sub vistaelectro_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles vistaelectro.CellClick
        Dim i As Integer
        i = vistaelectro.CurrentRow.Index
        txtidElectro.Text = vistaelectro.Item(0, i).Value()
        txtnombre.Text = vistaelectro.Item(1, i).Value()
        txtconsumohs.Text = vistaelectro.Item(2, i).Value()
        txtconsumok.Text = vistaelectro.Item(3, i).Value()
    End Sub

    Private Sub editarelectro_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=paneleSolares.mdb;Persist Security Info=False"
            conexion.Open()
            actualizardatagrid()
        Catch ex As Exception
            MsgBox("error, no se conecto", vbCritical, "sin conexion")
        End Try
    End Sub

    Private Sub NombreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NombreToolStripMenuItem.Click
        Dim registros As DataSet
        Dim consultar As String
        Dim lista As Integer
        If (buscarNombre.Text <> "") Then
            '    consultar = "SELECT * FROM electro WHERE nombre = '" & buscarNombre.Text & "'"
            consultar = "SELECT * FROM electro WHERE nombre LIKE '%" & buscarNombre.Text & "%'"
            adaptador = New OleDbDataAdapter(consultar, conexion)
            registros = New DataSet
            adaptador.Fill(registros, "electro")
            lista = registros.Tables("electro").Rows.Count
            If lista <> 0 Then
                vistaelectro.DataSource = registros
                vistaelectro.DataMember = "electro"
                txtidElectro.Text = registros.Tables("electro").Rows(0).Item("idElectro")
                txtnombre.Text = registros.Tables("electro").Rows(0).Item("nombre")
                txtconsumohs.Text = registros.Tables("electro").Rows(0).Item("hsConsumo")
                txtconsumok.Text = registros.Tables("electro").Rows(0).Item("conKwh")
            Else
                MsgBox("NO HAY REGISTROS CON DICHO NOMBRE", vbCritical, "A T E N C I O N")
                limpiar()
            End If
        End If
    End Sub
    Private Sub limpiar()
        txtidElectro.Clear()
        buscarId.Clear()
        txtnombre.Clear()
        txtconsumohs.Clear()
        txtconsumok.Clear()
        'vistaelectro.Colums.Clear()
    End Sub

    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        txtnombre.Enabled = True
        txtconsumohs.Enabled = True
        txtconsumok.Enabled = True
        buscarId.Enabled = False
        buscarNombre.Enabled = False
        enviar.Enabled = True
    End Sub
    Private Sub enviar_Click(sender As Object, e As EventArgs) Handles enviar.Click
        If txtnombre.Text = "" Or txtconsumohs.Text = "" Or txtconsumok.Text = "" Then
            MsgBox("No puede dejar campos vacios")
        Else
            If Val(txtconsumohs.Text) > 24 Or Val(txtconsumohs.Text) = 0 Then
                MsgBox("No puede ingresar mas de 24 horas ni ingresar 0 horas")
            Else
                Dim actualizar As String
                actualizar = "UPDATE electro SET nombre= '" & txtnombre.Text & "', hsConsumo = '" & CDbl(txtconsumohs.Text) & "', conKwh = '" & CDbl(txtconsumok.Text) & "' WHERE idElectro = " & Val(txtidElectro.Text) & ""
                comandos = New OleDbCommand(actualizar, conexion)
                comandos.ExecuteNonQuery()
                MsgBox("Actualizado correctamente", vbInformation, " correcto")
                actualizardatagrid()
                limpiar()
                txtnombre.Enabled = False
                txtconsumohs.Enabled = False
                txtconsumok.Enabled = False
                buscarId.Enabled = True
                buscarNombre.Enabled = True
                enviar.Enabled = False
            End If
        End If
    End Sub

    Private Sub borrar_Click(sender As Object, e As EventArgs) Handles borrar.Click
        Dim eliminar As String
        Dim si As Byte
        Dim num As Integer
        If txtidElectro.Text <> "" Then
            num = Val(txtidElectro.Text)
            si = MsgBox("Esta seguro que desea eliminar...", vbYesNo, "¿eliminar?")
            If si = vbYes Then
                eliminar = "DELETE FROM electro WHERE idElectro = " & num
                comandos = New OleDbCommand(eliminar, conexion)
                comandos.ExecuteNonQuery()
                MsgBox("Eliminado correctamente", vbInformation, "Correcto")
                limpiar()
                actualizardatagrid()
            Else
                MsgBox("Cancelo la eliminacion", vbCritical, "Cancelado")
                limpiar()
                actualizardatagrid()
            End If
        Else
            MsgBox("Tiene que seleccionar un id para poder eliminar el respectivo electrodomestico!")
            actualizardatagrid()
        End If
    End Sub

    Private Sub VOLVERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VOLVERToolStripMenuItem.Click
        inicio.Show()
        Me.Close()
    End Sub

    Private Sub IDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IDToolStripMenuItem.Click
        Dim registros As DataSet
        Dim consultar As String
        Dim lista As Integer
        Dim num As Integer
        num = Val(buscarId.Text)
        If (buscarId.Text <> "") Then
            consultar = "SELECT * FROM electro WHERE idElectro = " & num
            adaptador = New OleDbDataAdapter(consultar, conexion)
            registros = New DataSet
            adaptador.Fill(registros, "electro")
            lista = registros.Tables("electro").Rows.Count
            If lista <> 0 Then
                vistaelectro.DataSource = registros
                vistaelectro.DataMember = "electro"
                txtidElectro.Text = registros.Tables("electro").Rows(0).Item("idElectro")
                txtnombre.Text = registros.Tables("electro").Rows(0).Item("nombre")
                txtconsumohs.Text = registros.Tables("electro").Rows(0).Item("hsConsumo")
                txtconsumok.Text = registros.Tables("electro").Rows(0).Item("conKwh")
            Else
                MsgBox("NO HAY REGISTROS CON DICHO ID", vbCritical, "A T E N C I O N")
                limpiar()
            End If
        End If
    End Sub

    Private Sub buscarId_KeyPress(sender As Object, e As KeyPressEventArgs) Handles buscarId.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub buscarId_TextChanged(sender As Object, e As EventArgs) Handles buscarId.TextChanged
        If buscarId.Text <> "" Then
            buscarNombre.Enabled = False
        Else
            buscarNombre.Enabled = True
        End If
    End Sub

    Private Sub buscarNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles buscarNombre.KeyPress
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

    Private Sub buscarNombre_TextChanged(sender As Object, e As EventArgs) Handles buscarNombre.TextChanged
        If buscarNombre.Text <> "" Then
            buscarId.Enabled = False
        Else
            buscarId.Enabled = True
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

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
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

    Private Sub txtconsumohs_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtconsumohs.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtconsumok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtconsumok.KeyPress
        If Char.IsDigit(e.KeyChar) Or (e.KeyChar) = "," Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub txtconsumok_TextChanged(sender As Object, e As EventArgs) Handles txtconsumok.TextChanged
        If Not IsNumeric(txtconsumok.Text) And txtconsumok.Text.Contains(",") Then
            MsgBox("ERROR, valor invalido.")
            txtconsumok.Clear()
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        actualizardatagrid()
    End Sub
End Class