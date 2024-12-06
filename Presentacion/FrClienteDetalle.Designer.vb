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
        TextEmail = New TextBox()
        TextContraseña = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        CheckedListBoxRoles = New CheckedListBox()
        modificarButton = New Button()
        CType(PrestamosDatagrid, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(10, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(51, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nombre"
        ' 
        ' TextNombre
        ' 
        TextNombre.Location = New Point(98, 4)
        TextNombre.Margin = New Padding(3, 2, 3, 2)
        TextNombre.Name = "TextNombre"
        TextNombre.Size = New Size(328, 23)
        TextNombre.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(13, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 2
        Label2.Text = "Dirección"
        ' 
        ' TextDireccion
        ' 
        TextDireccion.Location = New Point(98, 65)
        TextDireccion.Margin = New Padding(3, 2, 3, 2)
        TextDireccion.Name = "TextDireccion"
        TextDireccion.Size = New Size(328, 23)
        TextDireccion.TabIndex = 3
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(13, 95)
        Label4.Name = "Label4"
        Label4.Size = New Size(52, 15)
        Label4.TabIndex = 5
        Label4.Text = "Telefono"
        ' 
        ' TextTelefono
        ' 
        TextTelefono.Location = New Point(98, 95)
        TextTelefono.Margin = New Padding(3, 2, 3, 2)
        TextTelefono.Name = "TextTelefono"
        TextTelefono.Size = New Size(328, 23)
        TextTelefono.TabIndex = 6
        ' 
        ' PrestamosDatagrid
        ' 
        PrestamosDatagrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        PrestamosDatagrid.Location = New Point(10, 214)
        PrestamosDatagrid.Margin = New Padding(3, 2, 3, 2)
        PrestamosDatagrid.Name = "PrestamosDatagrid"
        PrestamosDatagrid.RowHeadersWidth = 51
        PrestamosDatagrid.Size = New Size(679, 306)
        PrestamosDatagrid.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(10, 34)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 15)
        Label3.TabIndex = 8
        Label3.Text = "Apellidos"
        ' 
        ' TextApellidos
        ' 
        TextApellidos.Location = New Point(98, 35)
        TextApellidos.Margin = New Padding(3, 2, 3, 2)
        TextApellidos.Name = "TextApellidos"
        TextApellidos.Size = New Size(328, 23)
        TextApellidos.TabIndex = 9
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(447, 4)
        Label5.Name = "Label5"
        Label5.Size = New Size(35, 15)
        Label5.TabIndex = 11
        Label5.Text = "Roles"
        ' 
        ' TextEmail
        ' 
        TextEmail.Location = New Point(101, 133)
        TextEmail.Margin = New Padding(3, 2, 3, 2)
        TextEmail.Name = "TextEmail"
        TextEmail.Size = New Size(325, 23)
        TextEmail.TabIndex = 13
        ' 
        ' TextContraseña
        ' 
        TextContraseña.Location = New Point(102, 170)
        TextContraseña.Margin = New Padding(3, 2, 3, 2)
        TextContraseña.Name = "TextContraseña"
        TextContraseña.Size = New Size(324, 23)
        TextContraseña.TabIndex = 14
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(15, 131)
        Label6.Name = "Label6"
        Label6.Size = New Size(36, 15)
        Label6.TabIndex = 15
        Label6.Text = "Email"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(19, 170)
        Label7.Name = "Label7"
        Label7.Size = New Size(67, 15)
        Label7.TabIndex = 16
        Label7.Text = "Contraseña"
        ' 
        ' CheckedListBoxRoles
        ' 
        CheckedListBoxRoles.FormattingEnabled = True
        CheckedListBoxRoles.Location = New Point(447, 24)
        CheckedListBoxRoles.Name = "CheckedListBoxRoles"
        CheckedListBoxRoles.Size = New Size(241, 94)
        CheckedListBoxRoles.TabIndex = 17
        ' 
        ' modificarButton
        ' 
        modificarButton.Location = New Point(447, 133)
        modificarButton.Name = "modificarButton"
        modificarButton.Size = New Size(75, 23)
        modificarButton.TabIndex = 18
        modificarButton.Text = "Modificar cliente"
        modificarButton.UseVisualStyleBackColor = True
        ' 
        ' FrClienteDetalle
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(700, 531)
        Controls.Add(modificarButton)
        Controls.Add(CheckedListBoxRoles)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(TextContraseña)
        Controls.Add(TextEmail)
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
        Margin = New Padding(3, 2, 3, 2)
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
    Friend WithEvents TextEmail As TextBox
    Friend WithEvents TextContraseña As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents CheckedListBoxRoles As CheckedListBox
    Friend WithEvents modificarButton As Button
End Class
