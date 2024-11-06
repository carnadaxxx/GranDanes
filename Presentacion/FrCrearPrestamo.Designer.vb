<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrCrearPrestamo
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
        cmbClientes = New ComboBox()
        Label2 = New Label()
        txtMontoTotal = New TextBox()
        Label3 = New Label()
        nudNumeroCuotas = New NumericUpDown()
        Label4 = New Label()
        cmbFrecuenciaPago = New ComboBox()
        Label5 = New Label()
        btnCrearPrestamo = New Button()
        txtTasaInteres = New TextBox()
        CType(nudNumeroCuotas, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(22, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(55, 20)
        Label1.TabIndex = 0
        Label1.Text = "Cliente"
        ' 
        ' cmbClientes
        ' 
        cmbClientes.FormattingEnabled = True
        cmbClientes.Location = New Point(238, 21)
        cmbClientes.Name = "cmbClientes"
        cmbClientes.Size = New Size(550, 28)
        cmbClientes.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(22, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 20)
        Label2.TabIndex = 2
        Label2.Text = "Monto a prestar"
        ' 
        ' txtMontoTotal
        ' 
        txtMontoTotal.Location = New Point(238, 90)
        txtMontoTotal.Name = "txtMontoTotal"
        txtMontoTotal.Size = New Size(550, 27)
        txtMontoTotal.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(22, 200)
        Label3.Name = "Label3"
        Label3.Size = New Size(54, 20)
        Label3.TabIndex = 4
        Label3.Text = "Cuotas"
        ' 
        ' nudNumeroCuotas
        ' 
        nudNumeroCuotas.Location = New Point(238, 198)
        nudNumeroCuotas.Name = "nudNumeroCuotas"
        nudNumeroCuotas.Size = New Size(550, 27)
        nudNumeroCuotas.TabIndex = 5
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 268)
        Label4.Name = "Label4"
        Label4.Size = New Size(137, 20)
        Label4.TabIndex = 6
        Label4.Text = "Frecuencia de Pago"
        ' 
        ' cmbFrecuenciaPago
        ' 
        cmbFrecuenciaPago.FormattingEnabled = True
        cmbFrecuenciaPago.Items.AddRange(New Object() {"Mensual", "Quincenal"})
        cmbFrecuenciaPago.Location = New Point(241, 264)
        cmbFrecuenciaPago.Name = "cmbFrecuenciaPago"
        cmbFrecuenciaPago.Size = New Size(547, 28)
        cmbFrecuenciaPago.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(22, 142)
        Label5.Name = "Label5"
        Label5.Size = New Size(106, 20)
        Label5.TabIndex = 8
        Label5.Text = "Tasa de Interes"
        ' 
        ' btnCrearPrestamo
        ' 
        btnCrearPrestamo.Location = New Point(24, 349)
        btnCrearPrestamo.Name = "btnCrearPrestamo"
        btnCrearPrestamo.Size = New Size(764, 29)
        btnCrearPrestamo.TabIndex = 10
        btnCrearPrestamo.Text = "Crear Prestamo"
        btnCrearPrestamo.UseVisualStyleBackColor = True
        ' 
        ' txtTasaInteres
        ' 
        txtTasaInteres.Location = New Point(236, 140)
        txtTasaInteres.Name = "txtTasaInteres"
        txtTasaInteres.Size = New Size(552, 27)
        txtTasaInteres.TabIndex = 11
        ' 
        ' FrCrearPrestamo
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtTasaInteres)
        Controls.Add(btnCrearPrestamo)
        Controls.Add(Label5)
        Controls.Add(cmbFrecuenciaPago)
        Controls.Add(Label4)
        Controls.Add(nudNumeroCuotas)
        Controls.Add(Label3)
        Controls.Add(txtMontoTotal)
        Controls.Add(Label2)
        Controls.Add(cmbClientes)
        Controls.Add(Label1)
        Name = "FrCrearPrestamo"
        Text = "Crear Prestamo"
        CType(nudNumeroCuotas, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmbClientes As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMontoTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nudNumeroCuotas As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbFrecuenciaPago As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCrearPrestamo As Button
    Friend WithEvents txtTasaInteres As TextBox
End Class
