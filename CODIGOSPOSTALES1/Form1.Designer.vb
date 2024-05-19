<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer

    Private Sub InitializeComponent()
        Me.dgvAsentamientos = New System.Windows.Forms.DataGridView()
        Me.cbEstados = New System.Windows.Forms.ComboBox()
        Me.cbMunicipios = New System.Windows.Forms.ComboBox()
        Me.btnFiltrar = New System.Windows.Forms.Button()
        CType(Me.dgvAsentamientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAsentamientos
        '
        Me.dgvAsentamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAsentamientos.Location = New System.Drawing.Point(12, 12)
        Me.dgvAsentamientos.Name = "dgvAsentamientos"
        Me.dgvAsentamientos.Size = New System.Drawing.Size(750, 346)
        Me.dgvAsentamientos.TabIndex = 0
        '
        'cbEstados
        '
        Me.cbEstados.FormattingEnabled = True
        Me.cbEstados.Location = New System.Drawing.Point(12, 364)
        Me.cbEstados.Name = "cbEstados"
        Me.cbEstados.Size = New System.Drawing.Size(194, 21)
        Me.cbEstados.TabIndex = 1
        '
        'cbMunicipios
        '
        Me.cbMunicipios.FormattingEnabled = True
        Me.cbMunicipios.Location = New System.Drawing.Point(212, 364)
        Me.cbMunicipios.Name = "cbMunicipios"
        Me.cbMunicipios.Size = New System.Drawing.Size(194, 21)
        Me.cbMunicipios.TabIndex = 3
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(412, 362)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltrar.TabIndex = 2
        Me.btnFiltrar.Text = "Filtrar"
        Me.btnFiltrar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Controls.Add(Me.cbMunicipios)
        Me.Controls.Add(Me.cbEstados)
        Me.Controls.Add(Me.dgvAsentamientos)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dgvAsentamientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents dgvAsentamientos As System.Windows.Forms.DataGridView
    Private WithEvents cbEstados As System.Windows.Forms.ComboBox
    Private WithEvents cbMunicipios As System.Windows.Forms.ComboBox
    Private WithEvents btnFiltrar As System.Windows.Forms.Button
End Class



'<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
'Partial Class Form1
'    Inherits System.Windows.Forms.Form

'    Private components As System.ComponentModel.IContainer

'    Private Sub InitializeComponent()
'        Me.dgvAsentamientos = New System.Windows.Forms.DataGridView()
'        Me.cbEstados = New System.Windows.Forms.ComboBox()
'        Me.btnFiltrar = New System.Windows.Forms.Button()
'        Me.cbMunicipios = New System.Windows.Forms.ComboBox()
'        CType(Me.dgvAsentamientos, System.ComponentModel.ISupportInitialize).BeginInit()
'        Me.SuspendLayout()
'        '
'        'dgvAsentamientos
'        '
'        Me.dgvAsentamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
'        Me.dgvAsentamientos.Location = New System.Drawing.Point(12, 12)
'        Me.dgvAsentamientos.Name = "dgvAsentamientos"
'        Me.dgvAsentamientos.Size = New System.Drawing.Size(776, 346)
'        Me.dgvAsentamientos.TabIndex = 0
'        '
'        'cbEstados
'        '
'        Me.cbEstados.FormattingEnabled = True
'        Me.cbEstados.Location = New System.Drawing.Point(12, 364)
'        Me.cbEstados.Name = "cbEstados"
'        Me.cbEstados.Size = New System.Drawing.Size(194, 21)
'        Me.cbEstados.TabIndex = 1
'        '
'        'btnFiltrar
'        '
'        Me.btnFiltrar.Location = New System.Drawing.Point(212, 362)
'        Me.btnFiltrar.Name = "btnFiltrar"
'        Me.btnFiltrar.Size = New System.Drawing.Size(75, 23)
'        Me.btnFiltrar.TabIndex = 2
'        Me.btnFiltrar.Text = "Filtrar"
'        Me.btnFiltrar.UseVisualStyleBackColor = True
'        '
'        'cbMunicipios
'        '
'        Me.cbMunicipios.FormattingEnabled = True
'        Me.cbMunicipios.Location = New System.Drawing.Point(12, 402)
'        Me.cbMunicipios.Name = "cbMunicipios"
'        Me.cbMunicipios.Size = New System.Drawing.Size(194, 21)
'        Me.cbMunicipios.TabIndex = 3
'        '
'        'Form1
'        '
'        Me.ClientSize = New System.Drawing.Size(800, 450)
'        Me.Controls.Add(Me.cbMunicipios)
'        Me.Controls.Add(Me.btnFiltrar)
'        Me.Controls.Add(Me.cbEstados)
'        Me.Controls.Add(Me.dgvAsentamientos)
'        Me.Name = "Form1"
'        Me.Text = "Form1"
'        CType(Me.dgvAsentamientos, System.ComponentModel.ISupportInitialize).EndInit()
'        Me.ResumeLayout(False)

'    End Sub

'    Private WithEvents dgvAsentamientos As System.Windows.Forms.DataGridView
'    Private WithEvents cbEstados As System.Windows.Forms.ComboBox
'    Private WithEvents btnFiltrar As System.Windows.Forms.Button
'    Friend WithEvents cbMunicipios As ComboBox
'End Class
