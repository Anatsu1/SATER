Imports System.Data.OleDb
Imports System.Data
Public Class recomendacion
    Dim conexion As New OleDbConnection
    Dim comandos As New OleDbCommand
    Dim adaptador As New OleDbDataAdapter
    Dim registros As New DataSet
    Dim consulta As String
    Dim hsSol = calcularConsumo.hsSol.SelectedItem
    Dim consumoTotalAnio As Integer
    Dim consumoWatts As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        inicio.Show()
        Me.Close()
    End Sub
    Private Sub actualizardatagrid(consulta)
        Dim adaptador As New OleDbDataAdapter
        Dim registro As New DataSet
        adaptador = New OleDbDataAdapter(consulta, conexion)
        registro.Tables.Add("paneles")
        adaptador.Fill(registro.Tables("paneles"))
        vistapanel.DataSource = registro.Tables("paneles")
    End Sub
    Private Sub recomendacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        consumoanio.Text = calcularConsumo.consumoanio.Text
        consumodia.Text = calcularConsumo.consumodia.Text
        consumoTotalAnio = Val(consumoanio.Text)
        consulta = "SELECT * FROM paneles"
        wattsDia.Text = (Val(consumodia.Text) * 1000) / 24
        calcularConsumo.Close()
        Try
            conexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=paneleSolares.mdb;Persist Security Info=False"
            conexion.Open()
            actualizardatagrid(consulta)
        Catch ex As Exception
            MsgBox("error, no se conecto", vbCritical, "sin conexion")
        End Try
    End Sub
    Private Sub vistapanel_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles vistapanel.CellClick
        Dim i As Integer
        i = vistapanel.CurrentRow.Index
        tipoPanel.Text = vistapanel.Item(0, i).Value()
        watts.Text = vistapanel.Item(1, i).Value()
        eficiencia.Text = vistapanel.Item(2, i).Value()
        marca.Text = vistapanel.Item(3, i).Value()
        modelo.Text = vistapanel.Item(4, i).Value()
        dimensiones.Text = vistapanel.Item(5, i).Value()
    End Sub

    Private Sub generar_Click(sender As Object, e As EventArgs) Handles generar.Click
        Dim cantidadesPanel As Integer
        If (cantidadPanel.SelectedItem = "") Then
            cantidadesPanel = 1
        Else
            cantidadesPanel = cantidadPanel.SelectedItem
        End If
        consumoWatts = ((Val(consumodia.Text) * 1000) / hsSol) / cantidadesPanel
        consulta = "SELECT * FROM paneles WHERE watts >= " & consumoWatts
        actualizardatagrid(consulta)
    End Sub
End Class