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
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        InputNombreFiltro = New TextBox()
        BtnFiltrarCliente = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(12, 70)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(776, 368)
        DataGridView1.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(79, 20)
        Label1.TabIndex = 1
        Label1.Text = "Buscar por"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 38)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 20)
        Label2.TabIndex = 2
        Label2.Text = "Nombre"
        ' 
        ' InputNombreFiltro
        ' 
        InputNombreFiltro.Location = New Point(81, 38)
        InputNombreFiltro.Name = "InputNombreFiltro"
        InputNombreFiltro.Size = New Size(517, 27)
        InputNombreFiltro.TabIndex = 3
        ' 
        ' BtnFiltrarCliente
        ' 
        BtnFiltrarCliente.Location = New Point(604, 36)
        BtnFiltrarCliente.Name = "BtnFiltrarCliente"
        BtnFiltrarCliente.Size = New Size(184, 29)
        BtnFiltrarCliente.TabIndex = 6
        BtnFiltrarCliente.Text = "Filtrar"
        BtnFiltrarCliente.UseVisualStyleBackColor = True
        ' 
        ' FrListarClientes
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(BtnFiltrarCliente)
        Controls.Add(InputNombreFiltro)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Name = "FrListarClientes"
        Text = "Listado de Clientes"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents InputNombreFiltro As TextBox
    Friend WithEvents BtnFiltrarCliente As Button
End Class
