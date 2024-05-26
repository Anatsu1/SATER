Imports System.Data.OleDb
Imports System.Data
Public Class agregarelectro
    Dim conexion As New OleDbConnection
    Dim comandos As New OleDbCommand
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=paneleSolares.mdb;Persist Security Info=False"
            conexion.Open()
            actualizardatagrid()


        Catch ex As Exception
            MsgBox("error, no se conecto", vbCritical, "sin conexion")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txtnombre.Text = "" Or txtconsumohs.Text = "" Or txtconsumok.Text = "" Then
            MsgBox("No puede dejar campos vacios")
        Else
            If Val(txtconsumohs.Text) > 24 Or Val(txtconsumohs.Text) = 0 Then
                MsgBox("No puede ingresar mas de 24 horas ni ingresar 0 horas")
                txtconsumohs.Focus()
            Else
                Try
                    comandos = New OleDbCommand("INSERT INTO electro(nombre,hsConsumo,conKwh)" & Chr(13) & "VALUES (txtnombre, Cdbl(txtconsumohs), Cdbl(txtconsumok))", conexion)
                    comandos.Parameters.AddWithValue("@nombre", txtnombre.Text)
                    comandos.Parameters.AddWithValue("@hsConsumo", CDbl(txtconsumohs.Text))
                    comandos.Parameters.AddWithValue("@conKwh", CDbl(txtconsumok.Text))
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
        consulta = "SELECT * FROM electro"
        adaptador = New OleDbDataAdapter(consulta, conexion)
        registro.Tables.Add("electro")
        adaptador.Fill(registro.Tables("electro"))
        dgvelectro.DataSource = registro.Tables("electro")
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        opcioneselectro.Show()
        Me.Hide()
    End Sub

    Private Sub txtnombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
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
    Public Sub solonumeros(ByRef e As System.Windows.Forms.KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) Or (e.KeyChar) = "," Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtconsumok_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtconsumok.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        End If
        solonumeros(e)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        inicio.Show()
        Me.Close()
    End Sub

    Private Sub txtconsumok_TextChanged(sender As Object, e As EventArgs) Handles txtconsumok.TextChanged
        If Not IsNumeric(txtconsumok.Text) And txtconsumok.Text.Contains(",") Then
            MsgBox("ERROR, valor invalido.")
            txtconsumok.Clear()
            Exit Sub
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
'deja guarda cuando no escribiste nada
'dejar ingresar la , en los textbox
