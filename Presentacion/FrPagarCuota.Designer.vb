<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrPagarCuota
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
        BtnPagarCuota = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' BtnPagarCuota
        ' 
        BtnPagarCuota.Location = New Point(12, 138)
        BtnPagarCuota.Name = "BtnPagarCuota"
        BtnPagarCuota.Size = New Size(364, 29)
        BtnPagarCuota.TabIndex = 0
        BtnPagarCuota.Text = "Pagar Cuota"
        BtnPagarCuota.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(120, 68)
        Label1.Name = "Label1"
        Label1.Size = New Size(165, 20)
        Label1.TabIndex = 1
        Label1.Text = "Desea pagar esta cuota"
        ' 
        ' FrPagarCuota
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(388, 179)
        Controls.Add(Label1)
        Controls.Add(BtnPagarCuota)
        Name = "FrPagarCuota"
        Text = "FrPagarCuota"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BtnPagarCuota As Button
    Friend WithEvents Label1 As Label
End Class
