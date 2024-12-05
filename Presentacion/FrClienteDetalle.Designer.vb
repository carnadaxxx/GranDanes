<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrClienteDetalle
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
        TextNombre = New TextBox()
        Label2 = New Label()
        TextDireccion = New TextBox()
        Label4 = New Label()
        TextTelefono = New TextBox()
        PrestamosDatagrid = New DataGridView()
        Label3 = New Label()
        TextApellidos = New TextBox()
        Label5 = New Label()
        ListBoxRoles = New ListBox()
        CType(PrestamosDatagrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nombre"
        ' 
        ' TextNombre
        ' 
        TextNombre.Location = New Point(112, 6)
        TextNombre.Name = "TextNombre"
        TextNombre.Size = New Size(374, 27)
        TextNombre.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(15, 90)
        Label2.Name = "Label2"
        Label2.Size = New Size(72, 20)
        Label2.TabIndex = 2
        Label2.Text = "Dirección"
        ' 
        ' TextDireccion
        ' 
        TextDireccion.Location = New Point(112, 87)
        TextDireccion.Name = "TextDireccion"
        TextDireccion.Size = New Size(374, 27)
        TextDireccion.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(15, 127)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 20)
        Label4.TabIndex = 5
        Label4.Text = "Telefono"
        ' 
        ' TextTelefono
        ' 
        TextTelefono.Location = New Point(112, 127)
        TextTelefono.Name = "TextTelefono"
        TextTelefono.Size = New Size(374, 27)
        TextTelefono.TabIndex = 6
        ' 
        ' PrestamosDatagrid
        ' 
        PrestamosDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        PrestamosDatagrid.Location = New Point(12, 177)
        PrestamosDatagrid.Name = "PrestamosDatagrid"
        PrestamosDatagrid.RowHeadersWidth = 51
        PrestamosDatagrid.Size = New Size(776, 394)
        PrestamosDatagrid.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 45)
        Label3.Name = "Label3"
        Label3.Size = New Size(72, 20)
        Label3.TabIndex = 8
        Label3.Text = "Apellidos"
        ' 
        ' TextApellidos
        ' 
        TextApellidos.Location = New Point(112, 47)
        TextApellidos.Name = "TextApellidos"
        TextApellidos.Size = New Size(374, 27)
        TextApellidos.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(511, 6)
        Label5.Name = "Label5"
        Label5.Size = New Size(45, 20)
        Label5.TabIndex = 11
        Label5.Text = "Roles"
        ' 
        ' ListBoxRoles
        ' 
        ListBoxRoles.FormattingEnabled = True
        ListBoxRoles.Location = New Point(515, 36)
        ListBoxRoles.Name = "ListBoxRoles"
        ListBoxRoles.Size = New Size(273, 104)
        ListBoxRoles.TabIndex = 12
        ' 
        ' FrClienteDetalle
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 583)
        Controls.Add(ListBoxRoles)
        Controls.Add(Label5)
        Controls.Add(TextApellidos)
        Controls.Add(Label3)
        Controls.Add(PrestamosDatagrid)
        Controls.Add(TextTelefono)
        Controls.Add(Label4)
        Controls.Add(TextDireccion)
        Controls.Add(Label2)
        Controls.Add(TextNombre)
        Controls.Add(Label1)
        Name = "FrClienteDetalle"
        Text = "Detalle del Cliente"
        CType(PrestamosDatagrid, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextDireccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextTelefono As TextBox
    Friend WithEvents PrestamosDatagrid As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents TextApellidos As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ListBoxRoles As ListBox
End Class
