<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class opcioneselectro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(opcioneselectro))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Actualizar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VOLVER = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.electrodomestico = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.consumo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.consumoKW = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.borrar = New System.Windows.Forms.Button()
        Me.buscarNombre = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.buscarId = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtidElectro = New System.Windows.Forms.TextBox()
        Me.enviar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtconsumok = New System.Windows.Forms.TextBox()
        Me.modificar = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtconsumohs = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.vistaelectro = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILTRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NombreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VOLVERToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.vistaelectro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Actualizar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.VOLVER)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.electrodomestico)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.consumo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.consumoKW)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 53)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 373)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Actualizar
        '
        Me.Actualizar.Location = New System.Drawing.Point(13, 211)
        Me.Actualizar.Name = "Actualizar"
        Me.Actualizar.Size = New System.Drawing.Size(194, 50)
        Me.Actualizar.TabIndex = 21
        Me.Actualizar.Text = "Actualizar"
        Me.Actualizar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "EDITAR ELECTRODOMESTICOS"
        '
        'VOLVER
        '
        Me.VOLVER.Location = New System.Drawing.Point(13, 267)
        Me.VOLVER.Name = "VOLVER"
        Me.VOLVER.Size = New System.Drawing.Size(194, 50)
        Me.VOLVER.TabIndex = 6
        Me.VOLVER.Text = "Volver"
        Me.VOLVER.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "CONSUMO KWH"
        '
        'electrodomestico
        '
        Me.electrodomestico.Location = New System.Drawing.Point(107, 95)
        Me.electrodomestico.Name = "electrodomestico"
        Me.electrodomestico.Size = New System.Drawing.Size(100, 20)
        Me.electrodomestico.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "HS DE CONSUMO"
        '
        'consumo
        '
        Me.consumo.Location = New System.Drawing.Point(107, 121)
        Me.consumo.Name = "consumo"
        Me.consumo.Size = New System.Drawing.Size(100, 20)
        Me.consumo.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(47, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "NOMBRE"
        '
        'consumoKW
        '
        Me.consumoKW.Location = New System.Drawing.Point(107, 147)
        Me.consumoKW.Name = "consumoKW"
        Me.consumoKW.Size = New System.Drawing.Size(100, 20)
        Me.consumoKW.TabIndex = 17
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.borrar)
        Me.GroupBox2.Controls.Add(Me.buscarNombre)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.buscarId)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtnombre)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtidElectro)
        Me.GroupBox2.Controls.Add(Me.enviar)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtconsumok)
        Me.GroupBox2.Controls.Add(Me.modificar)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtconsumohs)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Location = New System.Drawing.Point(886, 102)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(262, 421)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(58, 392)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(154, 29)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Resetear datagrid"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Control
        Me.Label15.Location = New System.Drawing.Point(37, 356)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 16)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "NOMBRE"
        '
        'borrar
        '
        Me.borrar.Location = New System.Drawing.Point(43, 223)
        Me.borrar.Name = "borrar"
        Me.borrar.Size = New System.Drawing.Size(169, 32)
        Me.borrar.TabIndex = 19
        Me.borrar.Text = "BORRAR"
        Me.borrar.UseVisualStyleBackColor = True
        '
        'buscarNombre
        '
        Me.buscarNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscarNombre.Location = New System.Drawing.Point(104, 349)
        Me.buscarNombre.MaxLength = 40
        Me.buscarNombre.Name = "buscarNombre"
        Me.buscarNombre.ShortcutsEnabled = False
        Me.buscarNombre.Size = New System.Drawing.Size(108, 22)
        Me.buscarNombre.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label14.Location = New System.Drawing.Point(53, 202)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(151, 18)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "ELIMINAR ELECTRO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(25, 291)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(250, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "BUSCAR  ELECTRODOMESTICOS"
        '
        'buscarId
        '
        Me.buscarId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buscarId.Location = New System.Drawing.Point(104, 320)
        Me.buscarId.MaxLength = 5
        Me.buscarId.Name = "buscarId"
        Me.buscarId.ShortcutsEnabled = False
        Me.buscarId.Size = New System.Drawing.Size(108, 22)
        Me.buscarId.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(75, 323)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(21, 16)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "ID"
        '
        'txtnombre
        '
        Me.txtnombre.Enabled = False
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(124, 64)
        Me.txtnombre.MaxLength = 10
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.ShortcutsEnabled = False
        Me.txtnombre.Size = New System.Drawing.Size(108, 22)
        Me.txtnombre.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label10.Location = New System.Drawing.Point(89, 46)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(21, 16)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "ID"
        '
        'txtidElectro
        '
        Me.txtidElectro.Enabled = False
        Me.txtidElectro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtidElectro.Location = New System.Drawing.Point(124, 37)
        Me.txtidElectro.Name = "txtidElectro"
        Me.txtidElectro.Size = New System.Drawing.Size(108, 22)
        Me.txtidElectro.TabIndex = 20
        '
        'enviar
        '
        Me.enviar.Enabled = False
        Me.enviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enviar.Location = New System.Drawing.Point(6, 150)
        Me.enviar.Name = "enviar"
        Me.enviar.Size = New System.Drawing.Size(117, 46)
        Me.enviar.TabIndex = 18
        Me.enviar.Text = "ENVIAR MODIFICACION"
        Me.enviar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(25, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "EDITAR  ELECTRODOMESTICOS"
        '
        'txtconsumok
        '
        Me.txtconsumok.Enabled = False
        Me.txtconsumok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconsumok.Location = New System.Drawing.Point(124, 122)
        Me.txtconsumok.MaxLength = 4
        Me.txtconsumok.Name = "txtconsumok"
        Me.txtconsumok.ShortcutsEnabled = False
        Me.txtconsumok.Size = New System.Drawing.Size(108, 22)
        Me.txtconsumok.TabIndex = 12
        '
        'modificar
        '
        Me.modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.modificar.Location = New System.Drawing.Point(139, 151)
        Me.modificar.Name = "modificar"
        Me.modificar.Size = New System.Drawing.Size(108, 45)
        Me.modificar.TabIndex = 10
        Me.modificar.Text = " HABILITAR MODIFICAR"
        Me.modificar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(7, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 16)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "CONSUMO KWH"
        '
        'txtconsumohs
        '
        Me.txtconsumohs.Enabled = False
        Me.txtconsumohs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtconsumohs.Location = New System.Drawing.Point(124, 93)
        Me.txtconsumohs.MaxLength = 2
        Me.txtconsumohs.Name = "txtconsumohs"
        Me.txtconsumohs.ShortcutsEnabled = False
        Me.txtconsumohs.Size = New System.Drawing.Size(108, 22)
        Me.txtconsumohs.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(6, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(121, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "HS DE CONSUMO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label9.Location = New System.Drawing.Point(53, 72)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 16)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "NOMBRE"
        '
        'vistaelectro
        '
        Me.vistaelectro.AllowUserToAddRows = False
        Me.vistaelectro.AllowUserToDeleteRows = False
        Me.vistaelectro.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.vistaelectro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.vistaelectro.Location = New System.Drawing.Point(154, 108)
        Me.vistaelectro.Name = "vistaelectro"
        Me.vistaelectro.ReadOnly = True
        Me.vistaelectro.Size = New System.Drawing.Size(629, 518)
        Me.vistaelectro.TabIndex = 25
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILTRARToolStripMenuItem, Me.VOLVERToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1271, 26)
        Me.MenuStrip1.TabIndex = 26
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILTRARToolStripMenuItem
        '
        Me.FILTRARToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NombreToolStripMenuItem, Me.IDToolStripMenuItem})
        Me.FILTRARToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FILTRARToolStripMenuItem.Name = "FILTRARToolStripMenuItem"
        Me.FILTRARToolStripMenuItem.Size = New System.Drawing.Size(80, 22)
        Me.FILTRARToolStripMenuItem.Text = "FILTRAR"
        '
        'NombreToolStripMenuItem
        '
        Me.NombreToolStripMenuItem.Name = "NombreToolStripMenuItem"
        Me.NombreToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.NombreToolStripMenuItem.Text = "Nombre"
        '
        'IDToolStripMenuItem
        '
        Me.IDToolStripMenuItem.Name = "IDToolStripMenuItem"
        Me.IDToolStripMenuItem.Size = New System.Drawing.Size(130, 22)
        Me.IDToolStripMenuItem.Text = "ID"
        '
        'VOLVERToolStripMenuItem
        '
        Me.VOLVERToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VOLVERToolStripMenuItem.Name = "VOLVERToolStripMenuItem"
        Me.VOLVERToolStripMenuItem.Size = New System.Drawing.Size(79, 22)
        Me.VOLVERToolStripMenuItem.Text = "VOLVER"
        '
        'opcioneselectro
        '
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1271, 707)
        Me.Controls.Add(Me.vistaelectro)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "opcioneselectro"
        Me.Text = "Opciones de Electrodomesticos"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.vistaelectro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Actualizar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents VOLVER As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents electrodomestico As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents consumo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents consumoKW As System.Windows.Forms.TextBox
    Friend WithEvents editarelectro As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtconsumok As System.Windows.Forms.TextBox
    Friend WithEvents modificar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtconsumohs As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents vistaelectro As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents buscarId As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FILTRARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NombreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VOLVERToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents enviar As System.Windows.Forms.Button
    Friend WithEvents borrar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtidElectro As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents buscarNombre As System.Windows.Forms.TextBox
    Friend WithEvents IDToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
