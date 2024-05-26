<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class calcularConsumo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(calcularConsumo))
        Me.consumodia = New System.Windows.Forms.TextBox()
        Me.consumoanio = New System.Windows.Forms.TextBox()
        Me.listaordenada = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.hsSol = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cantidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtidElectro = New System.Windows.Forms.TextBox()
        Me.eliminar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtconsumok = New System.Windows.Forms.TextBox()
        Me.agregar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtconsumohs = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.vistaelectro = New System.Windows.Forms.DataGridView()
        Me.listaElectro = New System.Windows.Forms.ListBox()
        Me.listaPotencia = New System.Windows.Forms.ListBox()
        Me.listaCantidad = New System.Windows.Forms.ListBox()
        Me.indiceNum = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.vistaelectro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'consumodia
        '
        Me.consumodia.Enabled = False
        Me.consumodia.Location = New System.Drawing.Point(243, 45)
        Me.consumodia.Name = "consumodia"
        Me.consumodia.Size = New System.Drawing.Size(83, 20)
        Me.consumodia.TabIndex = 40
        Me.consumodia.Visible = False
        '
        'consumoanio
        '
        Me.consumoanio.Enabled = False
        Me.consumoanio.Location = New System.Drawing.Point(80, 45)
        Me.consumoanio.Name = "consumoanio"
        Me.consumoanio.Size = New System.Drawing.Size(83, 20)
        Me.consumoanio.TabIndex = 38
        Me.consumoanio.Visible = False
        '
        'listaordenada
        '
        Me.listaordenada.AutoSize = True
        Me.listaordenada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listaordenada.Location = New System.Drawing.Point(781, 26)
        Me.listaordenada.Name = "listaordenada"
        Me.listaordenada.Size = New System.Drawing.Size(54, 16)
        Me.listaordenada.TabIndex = 39
        Me.listaordenada.Text = "LISTA:"
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(35, 322)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(250, 27)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "VOLVER"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.hsSol)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cantidad)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtidElectro)
        Me.GroupBox2.Controls.Add(Me.eliminar)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.txtconsumok)
        Me.GroupBox2.Controls.Add(Me.agregar)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtconsumohs)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtnombre)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(837, 151)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(321, 372)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        '
        'hsSol
        '
        Me.hsSol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.hsSol.FormattingEnabled = True
        Me.hsSol.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.hsSol.Location = New System.Drawing.Point(104, 260)
        Me.hsSol.Name = "hsSol"
        Me.hsSol.Size = New System.Drawing.Size(121, 21)
        Me.hsSol.TabIndex = 31
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(16, 241)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(302, 16)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "HORAS DE SOL PROMEDIO EN SU ZONA:"
        '
        'cantidad
        '
        Me.cantidad.Location = New System.Drawing.Point(139, 147)
        Me.cantidad.MaxLength = 2
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(108, 20)
        Me.cantidad.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(45, 150)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(85, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "CANTIDAD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(110, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 16)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "ID"
        '
        'txtidElectro
        '
        Me.txtidElectro.Enabled = False
        Me.txtidElectro.Location = New System.Drawing.Point(139, 45)
        Me.txtidElectro.Name = "txtidElectro"
        Me.txtidElectro.Size = New System.Drawing.Size(108, 20)
        Me.txtidElectro.TabIndex = 20
        '
        'eliminar
        '
        Me.eliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.eliminar.Location = New System.Drawing.Point(77, 211)
        Me.eliminar.Name = "eliminar"
        Me.eliminar.Size = New System.Drawing.Size(169, 23)
        Me.eliminar.TabIndex = 18
        Me.eliminar.Text = "ELIMINAR"
        Me.eliminar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(45, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = " ELECTRODOMESTICOS"
        '
        'txtconsumok
        '
        Me.txtconsumok.Enabled = False
        Me.txtconsumok.Location = New System.Drawing.Point(139, 121)
        Me.txtconsumok.Name = "txtconsumok"
        Me.txtconsumok.Size = New System.Drawing.Size(108, 20)
        Me.txtconsumok.TabIndex = 5
        '
        'agregar
        '
        Me.agregar.BackColor = System.Drawing.Color.Transparent
        Me.agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agregar.Location = New System.Drawing.Point(78, 182)
        Me.agregar.Name = "agregar"
        Me.agregar.Size = New System.Drawing.Size(169, 23)
        Me.agregar.TabIndex = 10
        Me.agregar.Text = "AGREGAR"
        Me.agregar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(35, 287)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(250, 29)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "ENVIAR LISTA"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(16, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 16)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "CONSUMO KWH"
        '
        'txtconsumohs
        '
        Me.txtconsumohs.Enabled = False
        Me.txtconsumohs.Location = New System.Drawing.Point(139, 95)
        Me.txtconsumohs.Name = "txtconsumohs"
        Me.txtconsumohs.Size = New System.Drawing.Size(108, 20)
        Me.txtconsumohs.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 16)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "HS DE CONSUMO"
        '
        'txtnombre
        '
        Me.txtnombre.Enabled = False
        Me.txtnombre.Location = New System.Drawing.Point(139, 69)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(108, 20)
        Me.txtnombre.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(60, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 16)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "NOMBRE"
        '
        'vistaelectro
        '
        Me.vistaelectro.BackgroundColor = System.Drawing.SystemColors.HotTrack
        Me.vistaelectro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.vistaelectro.Location = New System.Drawing.Point(0, 142)
        Me.vistaelectro.Name = "vistaelectro"
        Me.vistaelectro.Size = New System.Drawing.Size(800, 489)
        Me.vistaelectro.TabIndex = 41
        '
        'listaElectro
        '
        Me.listaElectro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listaElectro.FormattingEnabled = True
        Me.listaElectro.ItemHeight = 16
        Me.listaElectro.Location = New System.Drawing.Point(585, 45)
        Me.listaElectro.Name = "listaElectro"
        Me.listaElectro.Size = New System.Drawing.Size(215, 84)
        Me.listaElectro.TabIndex = 42
        '
        'listaPotencia
        '
        Me.listaPotencia.Enabled = False
        Me.listaPotencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listaPotencia.FormattingEnabled = True
        Me.listaPotencia.ItemHeight = 16
        Me.listaPotencia.Location = New System.Drawing.Point(402, 12)
        Me.listaPotencia.Name = "listaPotencia"
        Me.listaPotencia.Size = New System.Drawing.Size(102, 68)
        Me.listaPotencia.TabIndex = 43
        Me.listaPotencia.Visible = False
        '
        'listaCantidad
        '
        Me.listaCantidad.Enabled = False
        Me.listaCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.listaCantidad.FormattingEnabled = True
        Me.listaCantidad.ItemHeight = 16
        Me.listaCantidad.Location = New System.Drawing.Point(837, 45)
        Me.listaCantidad.Name = "listaCantidad"
        Me.listaCantidad.Size = New System.Drawing.Size(225, 84)
        Me.listaCantidad.TabIndex = 44
        '
        'indiceNum
        '
        Me.indiceNum.Enabled = False
        Me.indiceNum.Location = New System.Drawing.Point(169, 26)
        Me.indiceNum.Name = "indiceNum"
        Me.indiceNum.Size = New System.Drawing.Size(83, 20)
        Me.indiceNum.TabIndex = 45
        Me.indiceNum.Visible = False
        '
        'calcularConsumo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1250, 666)
        Me.Controls.Add(Me.indiceNum)
        Me.Controls.Add(Me.listaCantidad)
        Me.Controls.Add(Me.listaPotencia)
        Me.Controls.Add(Me.listaElectro)
        Me.Controls.Add(Me.vistaelectro)
        Me.Controls.Add(Me.consumodia)
        Me.Controls.Add(Me.consumoanio)
        Me.Controls.Add(Me.listaordenada)
        Me.Controls.Add(Me.GroupBox2)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "calcularConsumo"
        Me.Text = "Calcular Consumo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.vistaelectro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents consumodia As System.Windows.Forms.TextBox
    Friend WithEvents consumoanio As System.Windows.Forms.TextBox
    Friend WithEvents listaordenada As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents hsSol As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtidElectro As System.Windows.Forms.TextBox
    Friend WithEvents eliminar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtconsumok As System.Windows.Forms.TextBox
    Friend WithEvents agregar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtconsumohs As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents vistaelectro As System.Windows.Forms.DataGridView
    Friend WithEvents listaElectro As System.Windows.Forms.ListBox
    Friend WithEvents listaPotencia As System.Windows.Forms.ListBox
    Friend WithEvents listaCantidad As System.Windows.Forms.ListBox
    Friend WithEvents indiceNum As System.Windows.Forms.TextBox
End Class
