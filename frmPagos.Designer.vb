<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.pnlFormaPago = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboSocio = New System.Windows.Forms.ComboBox()
        Me.txtImporte = New System.Windows.Forms.TextBox()
        Me.chkEfectivo = New System.Windows.Forms.CheckBox()
        Me.chkTransferencia = New System.Windows.Forms.CheckBox()
        Me.chkCooperadora = New System.Windows.Forms.CheckBox()
        Me.chkResidencia = New System.Windows.Forms.CheckBox()
        Me.chkMediaPennsion = New System.Windows.Forms.CheckBox()
        Me.lblFechaMovimiento = New System.Windows.Forms.Label()
        Me.dtpFechaMovimiento = New System.Windows.Forms.DateTimePicker()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblRegistroPagos = New System.Windows.Forms.Label()
        Me.pnlFormaPago.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 90)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Socio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(375, 90)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Importe"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, -1)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Forma de pago"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo de cuota"
        '
        'pnlFormaPago
        '
        Me.pnlFormaPago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlFormaPago.Controls.Add(Me.chkTransferencia)
        Me.pnlFormaPago.Controls.Add(Me.chkEfectivo)
        Me.pnlFormaPago.Controls.Add(Me.Label3)
        Me.pnlFormaPago.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pnlFormaPago.Location = New System.Drawing.Point(72, 159)
        Me.pnlFormaPago.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.pnlFormaPago.Name = "pnlFormaPago"
        Me.pnlFormaPago.Size = New System.Drawing.Size(259, 162)
        Me.pnlFormaPago.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.chkMediaPennsion)
        Me.Panel2.Controls.Add(Me.chkResidencia)
        Me.Panel2.Controls.Add(Me.chkCooperadora)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(379, 160)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(239, 162)
        Me.Panel2.TabIndex = 5
        '
        'cboSocio
        '
        Me.cboSocio.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSocio.FormattingEnabled = True
        Me.cboSocio.Location = New System.Drawing.Point(132, 87)
        Me.cboSocio.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.cboSocio.Name = "cboSocio"
        Me.cboSocio.Size = New System.Drawing.Size(199, 29)
        Me.cboSocio.TabIndex = 6
        '
        'txtImporte
        '
        Me.txtImporte.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImporte.Location = New System.Drawing.Point(454, 87)
        Me.txtImporte.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(164, 29)
        Me.txtImporte.TabIndex = 7
        '
        'chkEfectivo
        '
        Me.chkEfectivo.AutoSize = True
        Me.chkEfectivo.Location = New System.Drawing.Point(18, 46)
        Me.chkEfectivo.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chkEfectivo.Name = "chkEfectivo"
        Me.chkEfectivo.Size = New System.Drawing.Size(91, 25)
        Me.chkEfectivo.TabIndex = 3
        Me.chkEfectivo.Text = "Efectivo"
        Me.chkEfectivo.UseVisualStyleBackColor = True
        '
        'chkTransferencia
        '
        Me.chkTransferencia.AutoSize = True
        Me.chkTransferencia.Location = New System.Drawing.Point(18, 84)
        Me.chkTransferencia.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chkTransferencia.Name = "chkTransferencia"
        Me.chkTransferencia.Size = New System.Drawing.Size(129, 25)
        Me.chkTransferencia.TabIndex = 4
        Me.chkTransferencia.Text = "Transferencia"
        Me.chkTransferencia.UseVisualStyleBackColor = True
        '
        'chkCooperadora
        '
        Me.chkCooperadora.AutoSize = True
        Me.chkCooperadora.Location = New System.Drawing.Point(18, 46)
        Me.chkCooperadora.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chkCooperadora.Name = "chkCooperadora"
        Me.chkCooperadora.Size = New System.Drawing.Size(128, 25)
        Me.chkCooperadora.TabIndex = 4
        Me.chkCooperadora.Text = "Cooperadora"
        Me.chkCooperadora.UseVisualStyleBackColor = True
        '
        'chkResidencia
        '
        Me.chkResidencia.AutoSize = True
        Me.chkResidencia.Location = New System.Drawing.Point(18, 84)
        Me.chkResidencia.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chkResidencia.Name = "chkResidencia"
        Me.chkResidencia.Size = New System.Drawing.Size(110, 25)
        Me.chkResidencia.TabIndex = 5
        Me.chkResidencia.Text = "Residencia"
        Me.chkResidencia.UseVisualStyleBackColor = True
        '
        'chkMediaPennsion
        '
        Me.chkMediaPennsion.AutoSize = True
        Me.chkMediaPennsion.Location = New System.Drawing.Point(18, 122)
        Me.chkMediaPennsion.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.chkMediaPennsion.Name = "chkMediaPennsion"
        Me.chkMediaPennsion.Size = New System.Drawing.Size(116, 25)
        Me.chkMediaPennsion.TabIndex = 6
        Me.chkMediaPennsion.Text = "1/2 Pensión"
        Me.chkMediaPennsion.UseVisualStyleBackColor = True
        '
        'lblFechaMovimiento
        '
        Me.lblFechaMovimiento.AutoSize = True
        Me.lblFechaMovimiento.Location = New System.Drawing.Point(68, 353)
        Me.lblFechaMovimiento.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lblFechaMovimiento.Name = "lblFechaMovimiento"
        Me.lblFechaMovimiento.Size = New System.Drawing.Size(170, 21)
        Me.lblFechaMovimiento.TabIndex = 8
        Me.lblFechaMovimiento.Text = "Fecha de movimiento"
        '
        'dtpFechaMovimiento
        '
        Me.dtpFechaMovimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaMovimiento.Location = New System.Drawing.Point(248, 353)
        Me.dtpFechaMovimiento.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dtpFechaMovimiento.Name = "dtpFechaMovimiento"
        Me.dtpFechaMovimiento.Size = New System.Drawing.Size(120, 29)
        Me.dtpFechaMovimiento.TabIndex = 9
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(72, 417)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(88, 32)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(205, 417)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(88, 32)
        Me.btnLimpiar.TabIndex = 11
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(346, 417)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(88, 32)
        Me.btnGuardar.TabIndex = 12
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblRegistroPagos
        '
        Me.lblRegistroPagos.AutoSize = True
        Me.lblRegistroPagos.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegistroPagos.Location = New System.Drawing.Point(40, 18)
        Me.lblRegistroPagos.Name = "lblRegistroPagos"
        Me.lblRegistroPagos.Size = New System.Drawing.Size(217, 33)
        Me.lblRegistroPagos.TabIndex = 13
        Me.lblRegistroPagos.Text = "Registro de Pagos"
        '
        'frmPagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 480)
        Me.Controls.Add(Me.lblRegistroPagos)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.dtpFechaMovimiento)
        Me.Controls.Add(Me.lblFechaMovimiento)
        Me.Controls.Add(Me.txtImporte)
        Me.Controls.Add(Me.cboSocio)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pnlFormaPago)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "frmPagos"
        Me.Text = "RegistroPagos"
        Me.pnlFormaPago.ResumeLayout(False)
        Me.pnlFormaPago.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents pnlFormaPago As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents chkTransferencia As CheckBox
    Friend WithEvents chkEfectivo As CheckBox
    Friend WithEvents chkMediaPennsion As CheckBox
    Friend WithEvents chkResidencia As CheckBox
    Friend WithEvents chkCooperadora As CheckBox
    Friend WithEvents cboSocio As ComboBox
    Friend WithEvents txtImporte As TextBox
    Friend WithEvents lblFechaMovimiento As Label
    Friend WithEvents dtpFechaMovimiento As DateTimePicker
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblRegistroPagos As Label
End Class
