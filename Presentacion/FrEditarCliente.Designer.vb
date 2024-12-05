<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrEditarCliente
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
        txtNombre = New TextBox()
        Label2 = New Label()
        txtApellido = New TextBox()
        txtEmail = New TextBox()
        txtTelefono = New TextBox()
        txtDireccion = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        BtnGuardar = New Button()
        Label6 = New Label()
        checkedListBoxRoles = New CheckedListBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(27, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nombre"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(227, 26)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(276, 27)
        txtNombre.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(27, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(66, 20)
        Label2.TabIndex = 2
        Label2.Text = "Apellido"
        ' 
        ' txtApellido
        ' 
        txtApellido.Location = New Point(227, 69)
        txtApellido.Name = "txtApellido"
        txtApellido.Size = New Size(276, 27)
        txtApellido.TabIndex = 3
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(227, 119)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(276, 27)
        txtEmail.TabIndex = 4
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(227, 164)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(276, 27)
        txtTelefono.TabIndex = 5
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(227, 219)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(276, 27)
        txtDireccion.TabIndex = 6
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(27, 119)
        Label3.Name = "Label3"
        Label3.Size = New Size(132, 20)
        Label3.TabIndex = 7
        Label3.Text = "Correo Electronico"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(27, 171)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 20)
        Label4.TabIndex = 8
        Label4.Text = "Telefono"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(27, 219)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 20)
        Label5.TabIndex = 9
        Label5.Text = "Dirección"
        ' 
        ' BtnGuardar
        ' 
        BtnGuardar.Location = New Point(27, 398)
        BtnGuardar.Name = "BtnGuardar"
        BtnGuardar.Size = New Size(94, 29)
        BtnGuardar.TabIndex = 10
        BtnGuardar.Text = "Modifica"
        BtnGuardar.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(27, 272)
        Label6.Name = "Label6"
        Label6.Size = New Size(53, 20)
        Label6.TabIndex = 11
        Label6.Text = "Label6"
        ' 
        ' checkedListBoxRoles
        ' 
        checkedListBoxRoles.FormattingEnabled = True
        checkedListBoxRoles.Location = New Point(227, 272)
        checkedListBoxRoles.Name = "checkedListBoxRoles"
        checkedListBoxRoles.Size = New Size(276, 114)
        checkedListBoxRoles.TabIndex = 12
        ' 
        ' FrEditarCliente
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(checkedListBoxRoles)
        Controls.Add(Label6)
        Controls.Add(BtnGuardar)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtDireccion)
        Controls.Add(txtTelefono)
        Controls.Add(txtEmail)
        Controls.Add(txtApellido)
        Controls.Add(Label2)
        Controls.Add(txtNombre)
        Controls.Add(Label1)
        Name = "FrEditarCliente"
        Text = "Editar Cliente"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnGuardar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents checkedListBoxRoles As CheckedListBox
End Class
