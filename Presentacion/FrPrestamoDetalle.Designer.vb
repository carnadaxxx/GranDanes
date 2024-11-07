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
        CType(DataGridListaCuotas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 20)
        Label1.TabIndex = 0
        Label1.Text = "Cliente"
        ' 
        ' lblCliente
        ' 
        lblCliente.AutoSize = True
        lblCliente.Location = New Point(98, 9)
        lblCliente.Name = "lblCliente"
        lblCliente.Size = New Size(72, 20)
        lblCliente.TabIndex = 1
        lblCliente.Text = "lblCliente"
        ' 
        ' label2
        ' 
        label2.AutoSize = True
        label2.Location = New Point(12, 48)
        label2.Name = "label2"
        label2.Size = New Size(90, 20)
        label2.TabIndex = 2
        label2.Text = "Monto Total"
        ' 
        ' lblMonto
        ' 
        lblMonto.AutoSize = True
        lblMonto.Location = New Point(142, 49)
        lblMonto.Name = "lblMonto"
        lblMonto.Size = New Size(70, 20)
        lblMonto.TabIndex = 3
        lblMonto.Text = "lblMonto"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(11, 169)
        Label3.Name = "Label3"
        Label3.Size = New Size(106, 20)
        Label3.TabIndex = 4
        Label3.Text = "Tasa de Interes"
        ' 
        ' lblTasaInteres
        ' 
        lblTasaInteres.AutoSize = True
        lblTasaInteres.Location = New Point(159, 169)
        lblTasaInteres.Name = "lblTasaInteres"
        lblTasaInteres.Size = New Size(98, 20)
        lblTasaInteres.TabIndex = 5
        lblTasaInteres.Text = "lblTasaInteres"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(11, 209)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 20)
        Label4.TabIndex = 6
        Label4.Text = "Fecha de Inicio"
        ' 
        ' lblFechaInicio
        ' 
        lblFechaInicio.AutoSize = True
        lblFechaInicio.Location = New Point(176, 209)
        lblFechaInicio.Name = "lblFechaInicio"
        lblFechaInicio.Size = New Size(100, 20)
        lblFechaInicio.TabIndex = 7
        lblFechaInicio.Text = "lblFechaInicio"
        ' 
        ' DataGridListaCuotas
        ' 
        DataGridListaCuotas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridListaCuotas.Location = New Point(11, 343)
        DataGridListaCuotas.Name = "DataGridListaCuotas"
        DataGridListaCuotas.RowHeadersWidth = 51
        DataGridListaCuotas.Size = New Size(776, 246)
        DataGridListaCuotas.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(11, 87)
        Label5.Name = "Label5"
        Label5.Size = New Size(145, 20)
        Label5.TabIndex = 9
        Label5.Text = "Monto Con Intereses"
        ' 
        ' lblMontoConInteres
        ' 
        lblMontoConInteres.AutoSize = True
        lblMontoConInteres.Location = New Point(186, 87)
        lblMontoConInteres.Name = "lblMontoConInteres"
        lblMontoConInteres.Size = New Size(140, 20)
        lblMontoConInteres.TabIndex = 10
        lblMontoConInteres.Text = "lblMontoConInteres"
        ' 
        ' lblMontoCancelado
        ' 
        lblMontoCancelado.AutoSize = True
        lblMontoCancelado.Location = New Point(176, 124)
        lblMontoCancelado.Name = "lblMontoCancelado"
        lblMontoCancelado.Size = New Size(144, 20)
        lblMontoCancelado.TabIndex = 11
        lblMontoCancelado.Text = " lblMontoCancelado"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 121)
        Label6.Name = "Label6"
        Label6.Size = New Size(127, 20)
        Label6.TabIndex = 12
        Label6.Text = "Monto Cancelado"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(14, 251)
        Label7.Name = "Label7"
        Label7.Size = New Size(91, 20)
        Label7.TabIndex = 13
        Label7.Text = "Estado Pago"
        ' 
        ' lblEstadoPago
        ' 
        lblEstadoPago.AutoSize = True
        lblEstadoPago.Location = New Point(176, 251)
        lblEstadoPago.Name = "lblEstadoPago"
        lblEstadoPago.Size = New Size(104, 20)
        lblEstadoPago.TabIndex = 14
        lblEstadoPago.Text = "lblEstadoPago"
        ' 
        ' FrPrestamoDetalle
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 601)
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
End Class
