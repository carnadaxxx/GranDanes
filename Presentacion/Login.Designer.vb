<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        TextBoxEmail = New TextBox()
        password = New Label()
        TextBoxPassword = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 20)
        Label1.TabIndex = 0
        Label1.Text = "Correo Electronico"
        ' 
        ' TextBoxEmail
        ' 
        TextBoxEmail.Location = New Point(152, 19)
        TextBoxEmail.Name = "TextBoxEmail"
        TextBoxEmail.Size = New Size(267, 27)
        TextBoxEmail.TabIndex = 1
        ' 
        ' password
        ' 
        password.AutoSize = True
        password.Location = New Point(12, 94)
        password.Name = "password"
        password.Size = New Size(83, 20)
        password.TabIndex = 2
        password.Text = "Contraseña"
        ' 
        ' TextBoxPassword
        ' 
        TextBoxPassword.Location = New Point(152, 94)
        TextBoxPassword.Name = "TextBoxPassword"
        TextBoxPassword.Size = New Size(267, 27)
        TextBoxPassword.TabIndex = 3
        TextBoxPassword.UseSystemPasswordChar = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 173)
        Button1.Name = "Button1"
        Button1.Size = New Size(407, 29)
        Button1.TabIndex = 4
        Button1.Text = "Ingresar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(436, 250)
        Controls.Add(Button1)
        Controls.Add(TextBoxPassword)
        Controls.Add(password)
        Controls.Add(TextBoxEmail)
        Controls.Add(Label1)
        Name = "Login"
        Text = "Ingresar al sistema"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents password As Label
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents Button1 As Button
End Class
