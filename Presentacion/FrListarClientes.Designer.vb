<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrListarClientes
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
        dgvClientes = New DataGridView()
        Label2 = New Label()
        InputNombreFiltro = New TextBox()
        BtnFiltrarCliente = New Button()
        CType(dgvClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvClientes
        ' 
        dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvClientes.Location = New Point(10, 36)
        dgvClientes.Margin = New Padding(3, 2, 3, 2)
        dgvClientes.Name = "dgvClientes"
        dgvClientes.RowHeadersWidth = 51
        dgvClientes.Size = New Size(679, 292)
        dgvClientes.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(51, 15)
        Label2.TabIndex = 2
        Label2.Text = "Nombre"
        ' 
        ' InputNombreFiltro
        ' 
        InputNombreFiltro.Location = New Point(73, 9)
        InputNombreFiltro.Margin = New Padding(3, 2, 3, 2)
        InputNombreFiltro.Name = "InputNombreFiltro"
        InputNombreFiltro.Size = New Size(453, 23)
        InputNombreFiltro.TabIndex = 3
        ' 
        ' BtnFiltrarCliente
        ' 
        BtnFiltrarCliente.Location = New Point(530, 8)
        BtnFiltrarCliente.Margin = New Padding(3, 2, 3, 2)
        BtnFiltrarCliente.Name = "BtnFiltrarCliente"
        BtnFiltrarCliente.Size = New Size(161, 22)
        BtnFiltrarCliente.TabIndex = 6
        BtnFiltrarCliente.Text = "Filtrar"
        BtnFiltrarCliente.UseVisualStyleBackColor = True
        ' 
        ' FrListarClientes
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 338)
        Controls.Add(BtnFiltrarCliente)
        Controls.Add(InputNombreFiltro)
        Controls.Add(Label2)
        Controls.Add(dgvClientes)
        Margin = New Padding(3, 2, 3, 2)
        Name = "FrListarClientes"
        Text = "Listado de Clientes"
        CType(dgvClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents InputNombreFiltro As TextBox
    Friend WithEvents BtnFiltrarCliente As Button
End Class
