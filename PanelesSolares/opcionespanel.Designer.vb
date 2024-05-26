<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class opcionespanel
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(opcionespanel))
        Me.vistapanel = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.buscarTipo = New System.Windows.Forms.TextBox()
        Me.enviar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.buscarId = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.idPanel = New System.Windows.Forms.TextBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.modificar = New System.Windows.Forms.Button()
        Me.txtDimensiones = New System.Windows.Forms.TextBox()
        Me.txtModelo = New System.Windows.Forms.TextBox()
        Me.txtMarca = New System.Windows.Forms.TextBox()
        Me.txtEficiencia = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtWatts = New System.Windows.Forms.TextBox()
        Me.txtTipo = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILTRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoPanelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VOLVERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.vistapanel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'vistapanel
        '
        Me.vistapanel.AllowUserToAddRows = False
        Me.vistapanel.AllowUserToDeleteRows = False
        Me.vistapanel.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.vistapanel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.vistapanel.Location = New System.Drawing.Point(486, 125)
        Me.vistapanel.Name = "vistapanel"
        Me.vistapanel.ReadOnly = True
        Me.vistapanel.Size = New System.Drawing.Size(871, 435)
        Me.vistapanel.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.buscarTipo)
        Me.GroupBox1.Controls.Add(Me.enviar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.buscarId)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.idPanel)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.modificar)
        Me.GroupBox1.Controls.Add(Me.txtDimensiones)
        Me.GroupBox1.Controls.Add(Me.txtModelo)
        Me.GroupBox1.Controls.Add(Me.txtMarca)
        Me.GroupBox1.Controls.Add(Me.txtEficiencia)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtWatts)
        Me.GroupBox1.Controls.Add(Me.txtTipo)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 125)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(290, 486)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(75, 491)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 23)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Resetear datagrid"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'buscarTipo
        '
        Me.buscarTipo.Location = New System.Drawing.Point(114, 449)
        Me.buscarTipo.MaxLength = 40
        Me.buscarTipo.Name = "buscarTipo"
        Me.buscarTipo.Size = New System.Drawing.Size(108, 20)
        Me.buscarTipo.TabIndex = 17
        '
        'enviar
        '
        Me.enviar.Enabled = False
        Me.enviar.Location = New System.Drawing.Point(148, 247)
        Me.enviar.Name = "enviar"
        Me.enviar.Size = New System.Drawing.Size(123, 37)
        Me.enviar.TabIndex = 42
        Me.enviar.Text = "ENVIAR MODIFICACION"
        Me.enviar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(8, 449)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 16)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "TIPO PANEL"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.White
        Me.Label19.Location = New System.Drawing.Point(43, 299)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(189, 16)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "ELIMINAR  PANEL SOLAR"
        '
        'buscarId
        '
        Me.buscarId.Location = New System.Drawing.Point(114, 415)
        Me.buscarId.MaxLength = 5
        Me.buscarId.Name = "buscarId"
        Me.buscarId.Size = New System.Drawing.Size(108, 20)
        Me.buscarId.TabIndex = 14
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.White
        Me.Label20.Location = New System.Drawing.Point(22, 385)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(217, 16)
        Me.Label20.TabIndex = 2
        Me.Label20.Text = "BUSCAR PANELES SOLARES"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.White
        Me.Label21.Location = New System.Drawing.Point(81, 419)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(23, 16)
        Me.Label21.TabIndex = 15
        Me.Label21.Text = "ID"
        '
        'idPanel
        '
        Me.idPanel.Enabled = False
        Me.idPanel.Location = New System.Drawing.Point(148, 62)
        Me.idPanel.Name = "idPanel"
        Me.idPanel.ShortcutsEnabled = False
        Me.idPanel.Size = New System.Drawing.Size(108, 20)
        Me.idPanel.TabIndex = 44
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(46, 328)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(176, 44)
        Me.Button5.TabIndex = 19
        Me.Button5.Text = "BORRAR"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(119, 66)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 16)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "ID"
        '
        'modificar
        '
        Me.modificar.Location = New System.Drawing.Point(17, 247)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(122, 37)
        Me.modificar.TabIndex = 20
        Me.modificar.Text = "HABILITAR MODIFICAR"
        Me.modificar.UseVisualStyleBackColor = True
        '
        'txtDimensiones
        '
        Me.txtDimensiones.Enabled = False
        Me.txtDimensiones.Location = New System.Drawing.Point(148, 215)
        Me.txtDimensiones.MaxLength = 10
        Me.txtDimensiones.Name = "txtDimensiones"
        Me.txtDimensiones.ShortcutsEnabled = False
        Me.txtDimensiones.Size = New System.Drawing.Size(109, 20)
        Me.txtDimensiones.TabIndex = 41
        '
        'txtModelo
        '
        Me.txtModelo.Enabled = False
        Me.txtModelo.Location = New System.Drawing.Point(149, 189)
        Me.txtModelo.MaxLength = 12
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.ShortcutsEnabled = False
        Me.txtModelo.Size = New System.Drawing.Size(108, 20)
        Me.txtModelo.TabIndex = 40
        '
        'txtMarca
        '
        Me.txtMarca.Enabled = False
        Me.txtMarca.Location = New System.Drawing.Point(148, 163)
        Me.txtMarca.MaxLength = 12
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.ShortcutsEnabled = False
        Me.txtMarca.Size = New System.Drawing.Size(108, 20)
        Me.txtMarca.TabIndex = 39
        '
        'txtEficiencia
        '
        Me.txtEficiencia.Enabled = False
        Me.txtEficiencia.Location = New System.Drawing.Point(149, 137)
        Me.txtEficiencia.MaxLength = 3
        Me.txtEficiencia.Name = "txtEficiencia"
        Me.txtEficiencia.ShortcutsEnabled = False
        Me.txtEficiencia.Size = New System.Drawing.Size(108, 20)
        Me.txtEficiencia.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 219)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 16)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "DIMENSIONES"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(72, 193)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "MODELO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(81, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 16)
        Me.Label4.TabIndex = 35
        Me.Label4.Text = "MARCA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(53, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 16)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "EFICIENCIA"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(22, 89)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(121, 16)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "TIPO DE PANEL"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(77, 115)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 16)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "WATTS"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(22, 16)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(261, 18)
        Me.Label17.TabIndex = 2
        Me.Label17.Text = "MODIFICAR PANELES SOLARES"
        '
        'txtWatts
        '
        Me.txtWatts.Enabled = False
        Me.txtWatts.Location = New System.Drawing.Point(149, 111)
        Me.txtWatts.MaxLength = 4
        Me.txtWatts.Name = "txtWatts"
        Me.txtWatts.ShortcutsEnabled = False
        Me.txtWatts.Size = New System.Drawing.Size(108, 20)
        Me.txtWatts.TabIndex = 13
        '
        'txtTipo
        '
        Me.txtTipo.Enabled = False
        Me.txtTipo.Location = New System.Drawing.Point(149, 85)
        Me.txtTipo.MaxLength = 12
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.ShortcutsEnabled = False
        Me.txtTipo.Size = New System.Drawing.Size(108, 20)
        Me.txtTipo.TabIndex = 14
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILTRARToolStripMenuItem, Me.VOLVERToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1589, 24)
        Me.MenuStrip1.TabIndex = 35
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILTRARToolStripMenuItem
        '
        Me.FILTRARToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TipoPanelToolStripMenuItem, Me.IDToolStripMenuItem})
        Me.FILTRARToolStripMenuItem.Name = "FILTRARToolStripMenuItem"
        Me.FILTRARToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.FILTRARToolStripMenuItem.Text = "FILTRAR"
        '
        'TipoPanelToolStripMenuItem
        '
        Me.TipoPanelToolStripMenuItem.Name = "TipoPanelToolStripMenuItem"
        Me.TipoPanelToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.TipoPanelToolStripMenuItem.Text = "Tipo Panel"
        '
        'IDToolStripMenuItem
        '
        Me.IDToolStripMenuItem.Name = "IDToolStripMenuItem"
        Me.IDToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.IDToolStripMenuItem.Text = "ID"
        '
        'VOLVERToolStripMenuItem
        '
        Me.VOLVERToolStripMenuItem.Name = "VOLVERToolStripMenuItem"
        Me.VOLVERToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.VOLVERToolStripMenuItem.Text = "VOLVER"
        '
        'opcionespanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1589, 738)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.vistapanel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "opcionespanel"
        Me.Text = "Opciones de Paneles"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.vistapanel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents vistapanel As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDimensiones As System.Windows.Forms.TextBox
    Friend WithEvents txtModelo As System.Windows.Forms.TextBox
    Friend WithEvents txtMarca As System.Windows.Forms.TextBox
    Friend WithEvents txtEficiencia As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtWatts As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents buscarId As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents buscarTipo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents modificar As System.Windows.Forms.Button
    Friend WithEvents enviar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents idPanel As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILTRARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoPanelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VOLVERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
