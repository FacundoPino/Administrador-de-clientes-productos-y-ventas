<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministrarProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdministrarProductos))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAdmProducto = New System.Windows.Forms.Button()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.txtCategoria = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.btnAdmProducto)
        Me.Panel1.Controls.Add(Me.lblPrecio)
        Me.Panel1.Controls.Add(Me.lblCategoria)
        Me.Panel1.Controls.Add(Me.txtCategoria)
        Me.Panel1.Controls.Add(Me.txtPrecio)
        Me.Panel1.Controls.Add(Me.txtNombre)
        Me.Panel1.Controls.Add(Me.lblNombre)
        Me.Panel1.Controls.Add(Me.txtId)
        Me.Panel1.Controls.Add(Me.lblId)
        Me.Panel1.Location = New System.Drawing.Point(45, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(711, 370)
        Me.Panel1.TabIndex = 1
        '
        'btnAdmProducto
        '
        Me.btnAdmProducto.BackColor = System.Drawing.Color.Black
        Me.btnAdmProducto.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdmProducto.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnAdmProducto.Location = New System.Drawing.Point(209, 293)
        Me.btnAdmProducto.Name = "btnAdmProducto"
        Me.btnAdmProducto.Size = New System.Drawing.Size(225, 62)
        Me.btnAdmProducto.TabIndex = 8
        Me.btnAdmProducto.Text = "Modificar"
        Me.btnAdmProducto.UseVisualStyleBackColor = False
        '
        'lblPrecio
        '
        Me.lblPrecio.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblPrecio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPrecio.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblPrecio.Location = New System.Drawing.Point(44, 156)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(159, 35)
        Me.lblPrecio.TabIndex = 7
        Me.lblPrecio.Text = "PRECIO:"
        Me.lblPrecio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblCategoria
        '
        Me.lblCategoria.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblCategoria.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCategoria.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategoria.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblCategoria.Location = New System.Drawing.Point(44, 217)
        Me.lblCategoria.Name = "lblCategoria"
        Me.lblCategoria.Size = New System.Drawing.Size(159, 35)
        Me.lblCategoria.TabIndex = 6
        Me.lblCategoria.Text = "CATEGORIA:"
        Me.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCategoria
        '
        Me.txtCategoria.Location = New System.Drawing.Point(233, 217)
        Me.txtCategoria.Multiline = True
        Me.txtCategoria.Name = "txtCategoria"
        Me.txtCategoria.Size = New System.Drawing.Size(443, 35)
        Me.txtCategoria.TabIndex = 5
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(233, 156)
        Me.txtPrecio.Multiline = True
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(443, 35)
        Me.txtPrecio.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(233, 90)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(443, 35)
        Me.txtNombre.TabIndex = 3
        '
        'lblNombre
        '
        Me.lblNombre.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblNombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblNombre.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblNombre.Location = New System.Drawing.Point(44, 90)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(159, 35)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "NOMBRE:"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(233, 25)
        Me.txtId.Multiline = True
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(443, 35)
        Me.txtId.TabIndex = 1
        '
        'lblId
        '
        Me.lblId.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblId.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblId.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblId.Location = New System.Drawing.Point(44, 25)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(159, 35)
        Me.lblId.TabIndex = 0
        Me.lblId.Text = "ID CLIENTE:"
        '
        'AdministrarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdministrarProductos"
        Me.Text = "AdministrarProductos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdmProducto As Button
    Friend WithEvents lblPrecio As Label
    Friend WithEvents lblCategoria As Label
    Friend WithEvents txtCategoria As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblId As Label
End Class
