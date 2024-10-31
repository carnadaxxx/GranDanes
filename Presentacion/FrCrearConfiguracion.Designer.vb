<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrCrearConfiguracion
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
        Label2 = New Label()
        Label3 = New Label()
        TextBoxNombreConfiguracion = New TextBox()
        TextBoxValorPorDefecto = New TextBox()
        TextBoxDescripcion = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(182, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nombre de Configuracion"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 20)
        Label2.TabIndex = 1
        Label2.Text = "Valor por defecto"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 124)
        Label3.Name = "Label3"
        Label3.Size = New Size(87, 20)
        Label3.TabIndex = 2
        Label3.Text = "Descripcion"
        ' 
        ' TextBoxNombreConfiguracion
        ' 
        TextBoxNombreConfiguracion.Location = New Point(241, 19)
        TextBoxNombreConfiguracion.Name = "TextBoxNombreConfiguracion"
        TextBoxNombreConfiguracion.Size = New Size(547, 27)
        TextBoxNombreConfiguracion.TabIndex = 3
        ' 
        ' TextBoxValorPorDefecto
        ' 
        TextBoxValorPorDefecto.Location = New Point(241, 65)
        TextBoxValorPorDefecto.Name = "TextBoxValorPorDefecto"
        TextBoxValorPorDefecto.Size = New Size(547, 27)
        TextBoxValorPorDefecto.TabIndex = 4
        ' 
        ' TextBoxDescripcion
        ' 
        TextBoxDescripcion.Location = New Point(241, 117)
        TextBoxDescripcion.Name = "TextBoxDescripcion"
        TextBoxDescripcion.Size = New Size(547, 27)
        TextBoxDescripcion.TabIndex = 5
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(12, 409)
        Button1.Name = "Button1"
        Button1.Size = New Size(776, 29)
        Button1.TabIndex = 6
        Button1.Text = "Crear Configuracion"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' FrCrearConfiguracion
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(TextBoxDescripcion)
        Controls.Add(TextBoxValorPorDefecto)
        Controls.Add(TextBoxNombreConfiguracion)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "FrCrearConfiguracion"
        Text = "Crear Configuracion"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxNombreConfiguracion As TextBox
    Friend WithEvents TextBoxValorPorDefecto As TextBox
    Friend WithEvents TextBoxDescripcion As TextBox
    Friend WithEvents Button1 As Button
End Class
