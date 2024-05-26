Imports System.Data.OleDb
Imports System.Data
Public Class calcularConsumo
    Dim conexion As New OleDbConnection
    Dim comandos As New OleDbCommand
    Dim adaptador As New OleDbDataAdapter
    Dim registros As New DataSet

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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=paneleSolares.mdb;Persist Security Info=False"
            conexion.Open()
            actualizardatagrid()
        Catch ex As Exception
            MsgBox("error, no se conecto", vbCritical, "sin conexion")
        End Try
    End Sub
    Private Sub vistaelectro_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles vistaelectro.CellClick
        Dim i As Integer
        i = vistaelectro.CurrentRow.Index
        txtidElectro.Text = vistaelectro.Item(0, i).Value()
        txtnombre.Text = vistaelectro.Item(1, i).Value()
        txtconsumohs.Text = vistaelectro.Item(2, i).Value()
        txtconsumok.Text = vistaelectro.Item(3, i).Value()
    End Sub
    Private Sub agregar_Click(sender As Object, e As EventArgs) Handles agregar.Click
        Dim potencia As Integer
        If cantidad.Text <> "" And txtnombre.Text <> "" And txtconsumohs.Text <> "" And txtconsumok.Text <> "" Then
            potencia = Val(cantidad.Text) * (CDbl(txtconsumohs.Text) * CDbl(txtconsumok.Text))
            listaElectro.Items.Add(txtnombre.Text)
            listaCantidad.Items.Add(cantidad.Text)
            listaPotencia.Items.Add(potencia)
        Else
            MsgBox("asegurese de seleccionar un electrodomestico y completar la cantidad")
        End If
    End Sub
    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        Dim indiceNume As Integer
        If indiceNum.Text <> "" Then
            indiceNume = indiceNum.Text
            listaElectro.Items.RemoveAt(indiceNume)
            listaCantidad.Items.RemoveAt(indiceNume)
            listaPotencia.Items.RemoveAt(indiceNume)
            listaElectro.Text = ""
            listaCantidad.Text = ""
            listaPotencia.Text = ""
        Else
            MsgBox("Seleccione un elemento de la lista")

        End If

    End Sub
    Private Sub listaElectro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listaElectro.SelectedIndexChanged
        indiceNum.Text = listaElectro.SelectedIndex
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim Valor As Integer
        Dim Suma As Integer = 0
        If cantidad.Text = "" Then
            MsgBox("Por favor ingrese la cantidad del electrodomestico seleccionado. . .")
        ElseIf (hsSol.SelectedItem = "") Then
            MsgBox("Por favor ingrese la cantidad de horas promedio. . .")
        ElseIf listaElectro.Items.Count <= 0 Then
            MsgBox("Por favor ingrese un elemento en la lista...")
        Else
            For i = 0 To listaElectro.Items.Count() - 1
                Valor = listaPotencia.Items(i)
                Suma = Suma + Valor
            Next i
            consumoanio.Text = Suma * 365
            consumodia.Text = Suma
            recomendacion.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        inicio.Show()
        Me.Close()
    End Sub

    Private Sub cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub consumoanio_TextChanged(sender As Object, e As EventArgs) Handles consumoanio.TextChanged

    End Sub
End Class