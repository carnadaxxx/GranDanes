<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrPrestamoDetalle
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
        Label1 = New Label()
        lblCliente = New Label()
        label2 = New Label()
        lblMonto = New Label()
        Label3 = New Label()
        lblTasaInteres = New Label()
        Label4 = New Label()
        lblFechaInicio = New Label()
        DataGridListaCuotas = New DataGridView()
        Label5 = New Label()
        lblMontoConInteres = New Label()
        lblMontoCancelado = New Label()
        Label6 = New Label()
        Label7 = New Label()
        lblEstadoPago = New Label()
        Label8 = New Label()
        lblAprobacion = New Label()
        CType(DataGridListaCuotas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(10, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 15)
        Label1.TabIndex = 0
        Label1.Text = "Cliente"
        ' 
        ' lblCliente
        ' 
        lblCliente.AutoSize = True
        lblCliente.Location = New Point(163, 7)
        lblCliente.Name = "lblCliente"
        lblCliente.Size = New Size(57, 15)
        lblCliente.TabIndex = 1
        lblCliente.Text = "lblCliente"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(10, 36)
        label2.Name = "label2"
        label2.Size = New Size(71, 15)
        label2.TabIndex = 2
        label2.Text = "Monto Total"
        ' 
        ' lblMonto
        ' 
        lblMonto.AutoSize = True
        lblMonto.Location = New Point(163, 36)
        lblMonto.Name = "lblMonto"
        lblMonto.Size = New Size(56, 15)
        lblMonto.TabIndex = 3
        lblMonto.Text = "lblMonto"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(10, 127)
        Label3.Name = "Label3"
        Label3.Size = New Size(83, 15)
        Label3.TabIndex = 4
        Label3.Text = "Tasa de Interes"
        ' 
        ' lblTasaInteres
        ' 
        lblTasaInteres.AutoSize = True
        lblTasaInteres.Location = New Point(163, 127)
        lblTasaInteres.Name = "lblTasaInteres"
        lblTasaInteres.Size = New Size(77, 15)
        lblTasaInteres.TabIndex = 5
        lblTasaInteres.Text = "lblTasaInteres"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(10, 157)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 15)
        Label4.TabIndex = 6
        Label4.Text = "Fecha de Inicio"
        ' 
        ' lblFechaInicio
        ' 
        lblFechaInicio.AutoSize = True
        lblFechaInicio.Location = New Point(163, 157)
        lblFechaInicio.Name = "lblFechaInicio"
        lblFechaInicio.Size = New Size(80, 15)
        lblFechaInicio.TabIndex = 7
        lblFechaInicio.Text = "lblFechaInicio"
        ' 
        ' DataGridListaCuotas
        ' 
        DataGridListaCuotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridListaCuotas.Location = New Point(9, 267)
        DataGridListaCuotas.Margin = New Padding(3, 2, 3, 2)
        DataGridListaCuotas.Name = "DataGridListaCuotas"
        DataGridListaCuotas.RowHeadersWidth = 51
        DataGridListaCuotas.Size = New Size(679, 261)
        DataGridListaCuotas.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(10, 65)
        Label5.Name = "Label5"
        Label5.Size = New Size(117, 15)
        Label5.TabIndex = 9
        Label5.Text = "Monto Con Intereses"
        ' 
        ' lblMontoConInteres
        ' 
        lblMontoConInteres.AutoSize = True
        lblMontoConInteres.Location = New Point(163, 65)
        lblMontoConInteres.Name = "lblMontoConInteres"
        lblMontoConInteres.Size = New Size(113, 15)
        lblMontoConInteres.TabIndex = 10
        lblMontoConInteres.Text = "lblMontoConInteres"
        ' 
        ' lblMontoCancelado
        ' 
        lblMontoCancelado.AutoSize = True
        lblMontoCancelado.Location = New Point(161, 91)
        lblMontoCancelado.Name = "lblMontoCancelado"
        lblMontoCancelado.Size = New Size(115, 15)
        lblMontoCancelado.TabIndex = 11
        lblMontoCancelado.Text = " lblMontoCancelado"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(10, 91)
        Label6.Name = "Label6"
        Label6.Size = New Size(102, 15)
        Label6.TabIndex = 12
        Label6.Text = "Monto Cancelado"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 188)
        Label7.Name = "Label7"
        Label7.Size = New Size(72, 15)
        Label7.TabIndex = 13
        Label7.Text = "Estado Pago"
        ' 
        ' lblEstadoPago
        ' 
        lblEstadoPago.AutoSize = True
        lblEstadoPago.Location = New Point(163, 188)
        lblEstadoPago.Name = "lblEstadoPago"
        lblEstadoPago.Size = New Size(82, 15)
        lblEstadoPago.TabIndex = 14
        lblEstadoPago.Text = "lblEstadoPago"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(13, 220)
        Label8.Name = "Label8"
        Label8.Size = New Size(107, 15)
        Label8.TabIndex = 15
        Label8.Text = "Estado Aprobacion"
        ' 
        ' lblAprobacion
        ' 
        lblAprobacion.AutoSize = True
        lblAprobacion.Location = New Point(163, 220)
        lblAprobacion.Name = "lblAprobacion"
        lblAprobacion.Size = New Size(82, 15)
        lblAprobacion.TabIndex = 16
        lblAprobacion.Text = "lblAprobacion"
        ' 
        ' FrPrestamoDetalle
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 539)
        Controls.Add(lblAprobacion)
        Controls.Add(Label8)
        Controls.Add(lblEstadoPago)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(lblMontoCancelado)
        Controls.Add(lblMontoConInteres)
        Controls.Add(Label5)
        Controls.Add(DataGridListaCuotas)
        Controls.Add(lblFechaInicio)
        Controls.Add(Label4)
        Controls.Add(lblTasaInteres)
        Controls.Add(Label3)
        Controls.Add(lblMonto)
        Controls.Add(label2)
        Controls.Add(lblCliente)
        Controls.Add(Label1)
        Margin = New Padding(3, 2, 3, 2)
        Name = "FrPrestamoDetalle"
        Text = "Detalle de Prestamo"
        CType(DataGridListaCuotas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblCliente As Label
    Friend WithEvents label2 As Label
    Friend WithEvents lblMonto As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTasaInteres As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblFechaInicio As Label
    Friend WithEvents DataGridListaCuotas As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents lblMontoConInteres As Label
    Friend WithEvents lblMontoCancelado As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblEstadoPago As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblAprobacion As Label
End Class
