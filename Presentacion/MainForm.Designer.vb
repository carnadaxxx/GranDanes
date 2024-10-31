<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        MenuStrip1 = New MenuStrip()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        NuevoClienteToolStripMenuItem = New ToolStripMenuItem()
        VerClientesToolStripMenuItem = New ToolStripMenuItem()
        ConfiguracionesToolStripMenuItem = New ToolStripMenuItem()
        CrearConfiguracionToolStripMenuItem = New ToolStripMenuItem()
        MostrarConfiguracionesToolStripMenuItem = New ToolStripMenuItem()
        pnlContenedor = New Panel()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {ClientesToolStripMenuItem, ConfiguracionesToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NuevoClienteToolStripMenuItem, VerClientesToolStripMenuItem})
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(75, 24)
        ClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' NuevoClienteToolStripMenuItem
        ' 
        NuevoClienteToolStripMenuItem.Name = "NuevoClienteToolStripMenuItem"
        NuevoClienteToolStripMenuItem.Size = New Size(185, 26)
        NuevoClienteToolStripMenuItem.Text = "Nuevo Cliente"
        ' 
        ' VerClientesToolStripMenuItem
        ' 
        VerClientesToolStripMenuItem.Name = "VerClientesToolStripMenuItem"
        VerClientesToolStripMenuItem.Size = New Size(185, 26)
        VerClientesToolStripMenuItem.Text = "Ver Clientes"
        ' 
        ' ConfiguracionesToolStripMenuItem
        ' 
        ConfiguracionesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CrearConfiguracionToolStripMenuItem, MostrarConfiguracionesToolStripMenuItem})
        ConfiguracionesToolStripMenuItem.Name = "ConfiguracionesToolStripMenuItem"
        ConfiguracionesToolStripMenuItem.Size = New Size(130, 24)
        ConfiguracionesToolStripMenuItem.Text = "Configuraciones"
        ' 
        ' CrearConfiguracionToolStripMenuItem
        ' 
        CrearConfiguracionToolStripMenuItem.Name = "CrearConfiguracionToolStripMenuItem"
        CrearConfiguracionToolStripMenuItem.Size = New Size(254, 26)
        CrearConfiguracionToolStripMenuItem.Text = "Crear Configuracion "
        ' 
        ' MostrarConfiguracionesToolStripMenuItem
        ' 
        MostrarConfiguracionesToolStripMenuItem.Name = "MostrarConfiguracionesToolStripMenuItem"
        MostrarConfiguracionesToolStripMenuItem.Size = New Size(254, 26)
        MostrarConfiguracionesToolStripMenuItem.Text = "Mostrar Configuraciones"
        ' 
        ' pnlContenedor
        ' 
        pnlContenedor.Dock = DockStyle.Fill
        pnlContenedor.Location = New Point(0, 28)
        pnlContenedor.Name = "pnlContenedor"
        pnlContenedor.Size = New Size(800, 422)
        pnlContenedor.TabIndex = 1
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(pnlContenedor)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "MainForm"
        Text = "HomePage"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NuevoClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfiguracionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CrearConfiguracionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarConfiguracionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pnlContenedor As Panel
End Class
