<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inicio))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ELECTRODOMESTICOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NUEVOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MODIFICARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PANELESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NUEVOToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MODIFICARToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.empezar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ELECTRODOMESTICOSToolStripMenuItem, Me.PANELESToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1590, 26)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ELECTRODOMESTICOSToolStripMenuItem
        '
        Me.ELECTRODOMESTICOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NUEVOToolStripMenuItem, Me.MODIFICARToolStripMenuItem})
        Me.ELECTRODOMESTICOSToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.LightBlue
        Me.ELECTRODOMESTICOSToolStripMenuItem.Name = "ELECTRODOMESTICOSToolStripMenuItem"
        Me.ELECTRODOMESTICOSToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.ELECTRODOMESTICOSToolStripMenuItem.Text = "ELECTRODOMESTICOS"
        '
        'NUEVOToolStripMenuItem
        '
        Me.NUEVOToolStripMenuItem.Name = "NUEVOToolStripMenuItem"
        Me.NUEVOToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.NUEVOToolStripMenuItem.Text = "NUEVO"
        '
        'MODIFICARToolStripMenuItem
        '
        Me.MODIFICARToolStripMenuItem.Name = "MODIFICARToolStripMenuItem"
        Me.MODIFICARToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.MODIFICARToolStripMenuItem.Text = "OPCIONES"
        '
        'PANELESToolStripMenuItem
        '
        Me.PANELESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NUEVOToolStripMenuItem1, Me.MODIFICARToolStripMenuItem1})
        Me.PANELESToolStripMenuItem.Name = "PANELESToolStripMenuItem"
        Me.PANELESToolStripMenuItem.Size = New System.Drawing.Size(88, 22)
        Me.PANELESToolStripMenuItem.Text = "PANELES"
        '
        'NUEVOToolStripMenuItem1
        '
        Me.NUEVOToolStripMenuItem1.Name = "NUEVOToolStripMenuItem1"
        Me.NUEVOToolStripMenuItem1.Size = New System.Drawing.Size(155, 22)
        Me.NUEVOToolStripMenuItem1.Text = "NUEVO"
        '
        'MODIFICARToolStripMenuItem1
        '
        Me.MODIFICARToolStripMenuItem1.Name = "MODIFICARToolStripMenuItem1"
        Me.MODIFICARToolStripMenuItem1.Size = New System.Drawing.Size(155, 22)
        Me.MODIFICARToolStripMenuItem1.Text = "OPCIONES"
        '
        'empezar
        '
        Me.empezar.BackColor = System.Drawing.Color.LightSkyBlue
        Me.empezar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.empezar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.empezar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.empezar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empezar.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.empezar.Location = New System.Drawing.Point(891, 395)
        Me.empezar.Name = "empezar"
        Me.empezar.Size = New System.Drawing.Size(381, 64)
        Me.empezar.TabIndex = 2
        Me.empezar.Text = "CALCULAR CONSUMO"
        Me.empezar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-133, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1018, 773)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1590, 796)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.empezar)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "inicio"
        Me.Text = "MENU ENERGIA SOLAR"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ELECTRODOMESTICOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NUEVOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MODIFICARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PANELESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NUEVOToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MODIFICARToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents empezar As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
