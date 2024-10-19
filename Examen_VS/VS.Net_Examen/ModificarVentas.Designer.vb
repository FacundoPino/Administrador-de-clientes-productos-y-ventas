<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ModificarVentas))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAdmProducto = New System.Windows.Forms.Button()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblCategoria = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblIdCliente = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.btnAdmProducto)
        Me.Panel1.Controls.Add(Me.lblFecha)
        Me.Panel1.Controls.Add(Me.lblCategoria)
        Me.Panel1.Controls.Add(Me.txtTotal)
        Me.Panel1.Controls.Add(Me.txtFecha)
        Me.Panel1.Controls.Add(Me.txtIdCliente)
        Me.Panel1.Controls.Add(Me.lblId)
        Me.Panel1.Controls.Add(Me.txtId)
        Me.Panel1.Controls.Add(Me.lblIdCliente)
        Me.Panel1.Location = New System.Drawing.Point(45, 40)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(711, 370)
        Me.Panel1.TabIndex = 2
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
        'lblFecha
        '
        Me.lblFecha.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFecha.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblFecha.Location = New System.Drawing.Point(44, 156)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(159, 35)
        Me.lblFecha.TabIndex = 7
        Me.lblFecha.Text = "FECHA:"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        Me.lblCategoria.Text = "TOTAL:"
        Me.lblCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(233, 217)
        Me.txtTotal.Multiline = True
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(443, 35)
        Me.txtTotal.TabIndex = 5
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(233, 156)
        Me.txtFecha.Multiline = True
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(443, 35)
        Me.txtFecha.TabIndex = 4
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Location = New System.Drawing.Point(233, 90)
        Me.txtIdCliente.Multiline = True
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(443, 35)
        Me.txtIdCliente.TabIndex = 3
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
        Me.lblId.TabIndex = 2
        Me.lblId.Text = "ID:"
        Me.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
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
        'lblIdCliente
        '
        Me.lblIdCliente.BackColor = System.Drawing.SystemColors.Highlight
        Me.lblIdCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIdCliente.Font = New System.Drawing.Font("Arial Narrow", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdCliente.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblIdCliente.Location = New System.Drawing.Point(44, 90)
        Me.lblIdCliente.Name = "lblIdCliente"
        Me.lblIdCliente.Size = New System.Drawing.Size(159, 35)
        Me.lblIdCliente.TabIndex = 0
        Me.lblIdCliente.Text = "ID CLIENTE:"
        '
        'ModificarVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ModificarVentas"
        Me.Text = "ModificarVentas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnAdmProducto As Button
    Friend WithEvents lblFecha As Label
    Friend WithEvents lblCategoria As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtFecha As TextBox
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblIdCliente As Label
End Class
