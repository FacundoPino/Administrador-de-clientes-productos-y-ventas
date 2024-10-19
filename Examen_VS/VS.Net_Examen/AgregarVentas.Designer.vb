<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarVentas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarVentas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnMenos = New System.Windows.Forms.Button()
        Me.btnMas = New System.Windows.Forms.Button()
        Me.dgvAgregar = New System.Windows.Forms.DataGridView()
        Me.dgvProductos = New System.Windows.Forms.DataGridView()
        Me.btnAdmVenta = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvAgregar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.btnEliminar)
        Me.Panel1.Controls.Add(Me.txtCliente)
        Me.Panel1.Controls.Add(Me.lblCliente)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnAgregar)
        Me.Panel1.Controls.Add(Me.btnMenos)
        Me.Panel1.Controls.Add(Me.btnMas)
        Me.Panel1.Controls.Add(Me.dgvAgregar)
        Me.Panel1.Controls.Add(Me.dgvProductos)
        Me.Panel1.Controls.Add(Me.btnAdmVenta)
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Controls.Add(Me.txtTotal)
        Me.Panel1.Location = New System.Drawing.Point(45, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(711, 589)
        Me.Panel1.TabIndex = 2
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.Red
        Me.btnEliminar.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnEliminar.Location = New System.Drawing.Point(285, 441)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(126, 41)
        Me.btnEliminar.TabIndex = 17
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'txtCliente
        '
        Me.txtCliente.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.ForeColor = System.Drawing.SystemColors.Desktop
        Me.txtCliente.Location = New System.Drawing.Point(193, 22)
        Me.txtCliente.Multiline = True
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(493, 33)
        Me.txtCliente.TabIndex = 16
        '
        'lblCliente
        '
        Me.lblCliente.AutoSize = True
        Me.lblCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCliente.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCliente.Location = New System.Drawing.Point(40, 22)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(147, 33)
        Me.lblCliente.TabIndex = 15
        Me.lblCliente.Text = "ID CLIENTE:"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(212, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(269, 34)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Seleccione su producto"
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.SystemColors.ControlText
        Me.btnAgregar.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAgregar.Location = New System.Drawing.Point(243, 283)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(194, 46)
        Me.btnAgregar.TabIndex = 13
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnMenos
        '
        Me.btnMenos.BackColor = System.Drawing.Color.DarkBlue
        Me.btnMenos.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnMenos.Location = New System.Drawing.Point(40, 441)
        Me.btnMenos.Name = "btnMenos"
        Me.btnMenos.Size = New System.Drawing.Size(87, 41)
        Me.btnMenos.TabIndex = 12
        Me.btnMenos.Text = "-"
        Me.btnMenos.UseVisualStyleBackColor = False
        '
        'btnMas
        '
        Me.btnMas.BackColor = System.Drawing.Color.LimeGreen
        Me.btnMas.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnMas.Location = New System.Drawing.Point(599, 441)
        Me.btnMas.Name = "btnMas"
        Me.btnMas.Size = New System.Drawing.Size(87, 41)
        Me.btnMas.TabIndex = 11
        Me.btnMas.Text = "+"
        Me.btnMas.UseVisualStyleBackColor = False
        '
        'dgvAgregar
        '
        Me.dgvAgregar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvAgregar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAgregar.Location = New System.Drawing.Point(40, 335)
        Me.dgvAgregar.Name = "dgvAgregar"
        Me.dgvAgregar.ReadOnly = True
        Me.dgvAgregar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAgregar.Size = New System.Drawing.Size(646, 100)
        Me.dgvAgregar.TabIndex = 10
        '
        'dgvProductos
        '
        Me.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductos.Location = New System.Drawing.Point(40, 138)
        Me.dgvProductos.Name = "dgvProductos"
        Me.dgvProductos.ReadOnly = True
        Me.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProductos.Size = New System.Drawing.Size(646, 139)
        Me.dgvProductos.TabIndex = 9
        '
        'btnAdmVenta
        '
        Me.btnAdmVenta.BackColor = System.Drawing.Color.Black
        Me.btnAdmVenta.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmVenta.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAdmVenta.Location = New System.Drawing.Point(243, 529)
        Me.btnAdmVenta.Name = "btnAdmVenta"
        Me.btnAdmVenta.Size = New System.Drawing.Size(225, 56)
        Me.btnAdmVenta.TabIndex = 8
        Me.btnAdmVenta.Text = "Cerrar Venta"
        Me.btnAdmVenta.UseVisualStyleBackColor = False
        '
        'lblTotal
        '
        Me.lblTotal.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblTotal.Location = New System.Drawing.Point(40, 488)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(159, 35)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "TOTAL:"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotal
        '
        Me.txtTotal.BackColor = System.Drawing.SystemColors.Highlight
        Me.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTotal.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.txtTotal.Location = New System.Drawing.Point(243, 488)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(443, 35)
        Me.txtTotal.TabIndex = 5
        '
        'AgregarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 645)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AgregarVentas"
        Me.Text = "AdministrarVentas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvAgregar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdmVenta As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents dgvAgregar As DataGridView
    Friend WithEvents dgvProductos As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnMenos As Button
    Friend WithEvents btnMas As Button
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents lblCliente As Label
    Friend WithEvents btnEliminar As Button
End Class
