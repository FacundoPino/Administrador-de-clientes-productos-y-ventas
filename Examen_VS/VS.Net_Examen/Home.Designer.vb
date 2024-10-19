<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.pnlHome = New System.Windows.Forms.Panel()
        Me.FacundoPino = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnProductos = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.pnlHome.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHome
        '
        Me.pnlHome.BackColor = System.Drawing.SystemColors.Highlight
        Me.pnlHome.Controls.Add(Me.FacundoPino)
        Me.pnlHome.Controls.Add(Me.Label1)
        Me.pnlHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHome.Location = New System.Drawing.Point(0, 0)
        Me.pnlHome.Name = "pnlHome"
        Me.pnlHome.Size = New System.Drawing.Size(803, 113)
        Me.pnlHome.TabIndex = 0
        '
        'FacundoPino
        '
        Me.FacundoPino.BackColor = System.Drawing.Color.Black
        Me.FacundoPino.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FacundoPino.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.FacundoPino.Image = CType(resources.GetObject("FacundoPino.Image"), System.Drawing.Image)
        Me.FacundoPino.Location = New System.Drawing.Point(0, 0)
        Me.FacundoPino.Name = "FacundoPino"
        Me.FacundoPino.Size = New System.Drawing.Size(33, 30)
        Me.FacundoPino.TabIndex = 4
        Me.FacundoPino.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.FacundoPino.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Font = New System.Drawing.Font("Felix Titling", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(803, 113)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenidos!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClientes
        '
        Me.btnClientes.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnClientes.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnClientes.Location = New System.Drawing.Point(261, 139)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New System.Drawing.Size(269, 76)
        Me.btnClientes.TabIndex = 1
        Me.btnClientes.Text = "Administrar Clientes"
        Me.btnClientes.UseVisualStyleBackColor = False
        '
        'btnProductos
        '
        Me.btnProductos.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnProductos.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProductos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnProductos.Location = New System.Drawing.Point(261, 235)
        Me.btnProductos.Name = "btnProductos"
        Me.btnProductos.Size = New System.Drawing.Size(269, 76)
        Me.btnProductos.TabIndex = 2
        Me.btnProductos.Text = "Administrar Productos"
        Me.btnProductos.UseVisualStyleBackColor = False
        '
        'btnVentas
        '
        Me.btnVentas.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnVentas.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVentas.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnVentas.Location = New System.Drawing.Point(261, 335)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New System.Drawing.Size(269, 76)
        Me.btnVentas.TabIndex = 3
        Me.btnVentas.Text = "Administrar Ventas"
        Me.btnVentas.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(803, 455)
        Me.Controls.Add(Me.btnVentas)
        Me.Controls.Add(Me.btnProductos)
        Me.Controls.Add(Me.btnClientes)
        Me.Controls.Add(Me.pnlHome)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Home"
        Me.Text = "Home"
        Me.pnlHome.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHome As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClientes As Button
    Friend WithEvents btnProductos As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents FacundoPino As Button
End Class
