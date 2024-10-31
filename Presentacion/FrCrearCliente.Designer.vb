<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrCrearCliente
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BtnCrearCliente = New Button()
        Label1 = New Label()
        NameTextBox = New TextBox()
        EmailTextBox = New TextBox()
        Label2 = New Label()
        Label3 = New Label()
        PhoneTextBox = New TextBox()
        Label4 = New Label()
        AddressTextBox = New TextBox()
        Label5 = New Label()
        TextBoxApellidos = New TextBox()
        SuspendLayout()
        ' 
        ' BtnCrearCliente
        ' 
        BtnCrearCliente.Location = New Point(12, 409)
        BtnCrearCliente.Name = "BtnCrearCliente"
        BtnCrearCliente.Size = New Size(776, 29)
        BtnCrearCliente.TabIndex = 0
        BtnCrearCliente.Text = "Crear Cliente"
        BtnCrearCliente.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(25, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(64, 20)
        Label1.TabIndex = 1
        Label1.Text = "Nombre"
        ' 
        ' NameTextBox
        ' 
        NameTextBox.Location = New Point(171, 28)
        NameTextBox.Name = "NameTextBox"
        NameTextBox.Size = New Size(617, 27)
        NameTextBox.TabIndex = 2
        ' 
        ' EmailTextBox
        ' 
        EmailTextBox.Location = New Point(171, 122)
        EmailTextBox.Name = "EmailTextBox"
        EmailTextBox.Size = New Size(617, 27)
        EmailTextBox.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(25, 125)
        Label2.Name = "Label2"
        Label2.Size = New Size(132, 20)
        Label2.TabIndex = 4
        Label2.Text = "Correo Electronico"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(25, 179)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 20)
        Label3.TabIndex = 5
        Label3.Text = "Telefono"
        ' 
        ' PhoneTextBox
        ' 
        PhoneTextBox.Location = New Point(171, 179)
        PhoneTextBox.Name = "PhoneTextBox"
        PhoneTextBox.Size = New Size(617, 27)
        PhoneTextBox.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(25, 233)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 20)
        Label4.TabIndex = 7
        Label4.Text = "Direccion"
        ' 
        ' AddressTextBox
        ' 
        AddressTextBox.Location = New Point(171, 233)
        AddressTextBox.Name = "AddressTextBox"
        AddressTextBox.Size = New Size(617, 27)
        AddressTextBox.TabIndex = 8
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(29, 78)
        Label5.Name = "Label5"
        Label5.Size = New Size(72, 20)
        Label5.TabIndex = 9
        Label5.Text = "Apellidos"
        ' 
        ' TextBoxApellidos
        ' 
        TextBoxApellidos.Location = New Point(174, 77)
        TextBoxApellidos.Name = "TextBoxApellidos"
        TextBoxApellidos.Size = New Size(614, 27)
        TextBoxApellidos.TabIndex = 10
        ' 
        ' FrCrearCliente
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(TextBoxApellidos)
        Controls.Add(Label5)
        Controls.Add(AddressTextBox)
        Controls.Add(Label4)
        Controls.Add(PhoneTextBox)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(EmailTextBox)
        Controls.Add(NameTextBox)
        Controls.Add(Label1)
        Controls.Add(BtnCrearCliente)
        Name = "FrCrearCliente"
        Text = "Crear Cliente"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnCrearCliente As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxApellidos As TextBox

End Class
