<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrListarPrestamos
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
        DataGridListaPrestamos = New DataGridView()
        CType(DataGridListaPrestamos, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridListaPrestamos
        ' 
        DataGridListaPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridListaPrestamos.Location = New Point(12, 12)
        DataGridListaPrestamos.Name = "DataGridListaPrestamos"
        DataGridListaPrestamos.RowHeadersWidth = 51
        DataGridListaPrestamos.Size = New Size(783, 433)
        DataGridListaPrestamos.TabIndex = 0
        ' 
        ' FrListarPrestamos
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(DataGridListaPrestamos)
        Name = "FrListarPrestamos"
        Text = "Listar Prestamos"
        CType(DataGridListaPrestamos, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridListaPrestamos As DataGridView
End Class
