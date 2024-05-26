<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class recomendacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(recomendacion))
        Me.vistapanel = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.consumoanio = New System.Windows.Forms.TextBox()
        Me.tipoPanel = New System.Windows.Forms.TextBox()
        Me.modelo = New System.Windows.Forms.TextBox()
        Me.marca = New System.Windows.Forms.TextBox()
        Me.eficiencia = New System.Windows.Forms.TextBox()
        Me.watts = New System.Windows.Forms.TextBox()
        Me.label = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dimensiones = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.consumodia = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.generar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.wattsDia = New System.Windows.Forms.TextBox()
        Me.cantidadPanel = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        CType(Me.vistapanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'vistapanel
        '
        Me.vistapanel.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.vistapanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.vistapanel.Location = New System.Drawing.Point(12, 35)
        Me.vistapanel.Name = "vistapanel"
        Me.vistapanel.Size = New System.Drawing.Size(1320, 216)
        Me.vistapanel.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(547, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(335, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PANELES SOLARES RECOMENDADOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(117, 274)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(272, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SU CONSUMO EN KW ANUAL ES DE: "
        '
        'consumoanio
        '
        Me.consumoanio.Enabled = False
        Me.consumoanio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.consumoanio.Location = New System.Drawing.Point(120, 293)
        Me.consumoanio.Multiline = True
        Me.consumoanio.Name = "consumoanio"
        Me.consumoanio.Size = New System.Drawing.Size(196, 23)
        Me.consumoanio.TabIndex = 3
        '
        'tipoPanel
        '
        Me.tipoPanel.Enabled = False
        Me.tipoPanel.Location = New System.Drawing.Point(686, 289)
        Me.tipoPanel.Name = "tipoPanel"
        Me.tipoPanel.Size = New System.Drawing.Size(100, 20)
        Me.tipoPanel.TabIndex = 4
        '
        'modelo
        '
        Me.modelo.Enabled = False
        Me.modelo.Location = New System.Drawing.Point(686, 393)
        Me.modelo.Name = "modelo"
        Me.modelo.Size = New System.Drawing.Size(100, 20)
        Me.modelo.TabIndex = 5
        '
        'marca
        '
        Me.marca.Enabled = False
        Me.marca.Location = New System.Drawing.Point(686, 367)
        Me.marca.Name = "marca"
        Me.marca.Size = New System.Drawing.Size(100, 20)
        Me.marca.TabIndex = 6
        '
        'eficiencia
        '
        Me.eficiencia.Enabled = False
        Me.eficiencia.Location = New System.Drawing.Point(686, 341)
        Me.eficiencia.Name = "eficiencia"
        Me.eficiencia.Size = New System.Drawing.Size(100, 20)
        Me.eficiencia.TabIndex = 7
        '
        'watts
        '
        Me.watts.Enabled = False
        Me.watts.Location = New System.Drawing.Point(686, 315)
        Me.watts.Name = "watts"
        Me.watts.Size = New System.Drawing.Size(100, 20)
        Me.watts.TabIndex = 9
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.BackColor = System.Drawing.Color.Black
        Me.label.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label.ForeColor = System.Drawing.Color.White
        Me.label.Location = New System.Drawing.Point(642, 270)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(175, 20)
        Me.label.TabIndex = 10
        Me.label.Text = "CARACTERISTICAS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(559, 293)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 16)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "TIPO DE PANEL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(618, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 16)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "WATTS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(590, 342)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "EFICIENCIA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Black
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(618, 371)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 16)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "MARCA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Black
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(609, 397)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 16)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "MODELO"
        '
        'dimensiones
        '
        Me.dimensiones.Enabled = False
        Me.dimensiones.Location = New System.Drawing.Point(686, 421)
        Me.dimensiones.Name = "dimensiones"
        Me.dimensiones.Size = New System.Drawing.Size(100, 20)
        Me.dimensiones.TabIndex = 39
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(567, 425)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 16)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "DIMENSIONES"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(162, 553)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(144, 34)
        Me.Button1.TabIndex = 41
        Me.Button1.Text = "VOLVER A INICIO"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'consumodia
        '
        Me.consumodia.Enabled = False
        Me.consumodia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.consumodia.Location = New System.Drawing.Point(120, 351)
        Me.consumodia.Multiline = True
        Me.consumodia.Name = "consumodia"
        Me.consumodia.Size = New System.Drawing.Size(196, 23)
        Me.consumodia.TabIndex = 42
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(117, 329)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(283, 16)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "SU CONSUMO EN KW POR DIA ES DE: "
        '
        'generar
        '
        Me.generar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.generar.Location = New System.Drawing.Point(1054, 538)
        Me.generar.Name = "generar"
        Me.generar.Size = New System.Drawing.Size(161, 49)
        Me.generar.TabIndex = 44
        Me.generar.Text = "GENERAR RECOMENDACION"
        Me.generar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(106, 383)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(332, 16)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "SU CONSUMO EN WATTS POR HORA ES DE: "
        '
        'wattsDia
        '
        Me.wattsDia.Enabled = False
        Me.wattsDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.wattsDia.Location = New System.Drawing.Point(120, 419)
        Me.wattsDia.Multiline = True
        Me.wattsDia.Name = "wattsDia"
        Me.wattsDia.Size = New System.Drawing.Size(196, 23)
        Me.wattsDia.TabIndex = 46
        '
        'cantidadPanel
        '
        Me.cantidadPanel.FormattingEnabled = True
        Me.cantidadPanel.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.cantidadPanel.Location = New System.Drawing.Point(792, 486)
        Me.cantidadPanel.Name = "cantidadPanel"
        Me.cantidadPanel.Size = New System.Drawing.Size(133, 21)
        Me.cantidadPanel.TabIndex = 47
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(683, 467)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(274, 16)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "CANTIDAD DE PANELES QUE DESEA"
        '
        'recomendacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1389, 739)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cantidadPanel)
        Me.Controls.Add(Me.wattsDia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.generar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.consumodia)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dimensiones)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.watts)
        Me.Controls.Add(Me.eficiencia)
        Me.Controls.Add(Me.marca)
        Me.Controls.Add(Me.modelo)
        Me.Controls.Add(Me.tipoPanel)
        Me.Controls.Add(Me.consumoanio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.vistapanel)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "recomendacion"
        Me.Text = "Recomendacion De Paneles"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.vistapanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vistapanel As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents consumoanio As System.Windows.Forms.TextBox
    Friend WithEvents tipoPanel As System.Windows.Forms.TextBox
    Friend WithEvents modelo As System.Windows.Forms.TextBox
    Friend WithEvents marca As System.Windows.Forms.TextBox
    Friend WithEvents eficiencia As System.Windows.Forms.TextBox
    Friend WithEvents watts As System.Windows.Forms.TextBox
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dimensiones As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents consumodia As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents generar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents wattsDia As System.Windows.Forms.TextBox
    Friend WithEvents cantidadPanel As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
