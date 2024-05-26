Public Class inicio
    Private Sub NUEVOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NUEVOToolStripMenuItem.Click
        agregarelectro.Show()
        Me.Hide()
    End Sub

    Private Sub MODIFICARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MODIFICARToolStripMenuItem.Click
        opcioneselectro.Show()
        Me.Hide()
    End Sub

    Private Sub NUEVOToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NUEVOToolStripMenuItem1.Click
        agregarpanel.Show()
        Me.Hide()

    End Sub
    Private Sub inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub empezar_Click(sender As Object, e As EventArgs) Handles empezar.Click
        calcularConsumo.Show()
        Me.Hide()
    End Sub

    Private Sub MODIFICARToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles MODIFICARToolStripMenuItem1.Click
        opcionespanel.Show()
        Me.Hide()
    End Sub
End Class
