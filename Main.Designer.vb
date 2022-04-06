<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabJugadoras = New System.Windows.Forms.TabPage()
        Me.BTNLimpiarJUG = New System.Windows.Forms.Button()
        Me.BTNEliminarJUG = New System.Windows.Forms.Button()
        Me.BTNActualizarJUG = New System.Windows.Forms.Button()
        Me.BTNAñadirJUG = New System.Windows.Forms.Button()
        Me.DateJugadora = New System.Windows.Forms.DateTimePicker()
        Me.TXTPaisJUG = New System.Windows.Forms.TextBox()
        Me.TXTNombreJUG = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListJugadoras = New System.Windows.Forms.ListBox()
        Me.TabTorneos = New System.Windows.Forms.TabPage()
        Me.TXTCiudadTorneo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TXTFechaTorneo = New System.Windows.Forms.TextBox()
        Me.BTNLimpiarTorneo = New System.Windows.Forms.Button()
        Me.BTNEliminarTorneo = New System.Windows.Forms.Button()
        Me.BTNActualizarTorneo = New System.Windows.Forms.Button()
        Me.BTNAñadirTorneo = New System.Windows.Forms.Button()
        Me.TXTPaisTorneo = New System.Windows.Forms.TextBox()
        Me.TXTNombreTorneo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LSTTorneos = New System.Windows.Forms.ListBox()
        Me.TabPaises = New System.Windows.Forms.TabPage()
        Me.BTNLimpiarPais = New System.Windows.Forms.Button()
        Me.BTNEliminarPais = New System.Windows.Forms.Button()
        Me.BTNActualizarPais = New System.Windows.Forms.Button()
        Me.BTNAñadirPais = New System.Windows.Forms.Button()
        Me.TXTNombrePais = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LSTPais = New System.Windows.Forms.ListBox()
        Me.TabControl2.SuspendLayout()
        Me.TabJugadoras.SuspendLayout()
        Me.TabTorneos.SuspendLayout()
        Me.TabPaises.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabJugadoras)
        Me.TabControl2.Controls.Add(Me.TabTorneos)
        Me.TabControl2.Controls.Add(Me.TabPaises)
        Me.TabControl2.Location = New System.Drawing.Point(0, -5)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(803, 461)
        Me.TabControl2.TabIndex = 2
        '
        'TabJugadoras
        '
        Me.TabJugadoras.Controls.Add(Me.BTNLimpiarJUG)
        Me.TabJugadoras.Controls.Add(Me.BTNEliminarJUG)
        Me.TabJugadoras.Controls.Add(Me.BTNActualizarJUG)
        Me.TabJugadoras.Controls.Add(Me.BTNAñadirJUG)
        Me.TabJugadoras.Controls.Add(Me.DateJugadora)
        Me.TabJugadoras.Controls.Add(Me.TXTPaisJUG)
        Me.TabJugadoras.Controls.Add(Me.TXTNombreJUG)
        Me.TabJugadoras.Controls.Add(Me.Label3)
        Me.TabJugadoras.Controls.Add(Me.Label2)
        Me.TabJugadoras.Controls.Add(Me.Label1)
        Me.TabJugadoras.Controls.Add(Me.ListJugadoras)
        Me.TabJugadoras.Location = New System.Drawing.Point(4, 29)
        Me.TabJugadoras.Name = "TabJugadoras"
        Me.TabJugadoras.Padding = New System.Windows.Forms.Padding(3)
        Me.TabJugadoras.Size = New System.Drawing.Size(795, 428)
        Me.TabJugadoras.TabIndex = 0
        Me.TabJugadoras.Text = "JUGADORAS"
        Me.TabJugadoras.UseVisualStyleBackColor = True
        '
        'BTNLimpiarJUG
        '
        Me.BTNLimpiarJUG.Location = New System.Drawing.Point(522, 355)
        Me.BTNLimpiarJUG.Name = "BTNLimpiarJUG"
        Me.BTNLimpiarJUG.Size = New System.Drawing.Size(148, 42)
        Me.BTNLimpiarJUG.TabIndex = 11
        Me.BTNLimpiarJUG.Text = "Limpiar"
        Me.BTNLimpiarJUG.UseVisualStyleBackColor = True
        '
        'BTNEliminarJUG
        '
        Me.BTNEliminarJUG.Location = New System.Drawing.Point(272, 355)
        Me.BTNEliminarJUG.Name = "BTNEliminarJUG"
        Me.BTNEliminarJUG.Size = New System.Drawing.Size(147, 42)
        Me.BTNEliminarJUG.TabIndex = 10
        Me.BTNEliminarJUG.Text = "Eliminar"
        Me.BTNEliminarJUG.UseVisualStyleBackColor = True
        '
        'BTNActualizarJUG
        '
        Me.BTNActualizarJUG.Location = New System.Drawing.Point(522, 276)
        Me.BTNActualizarJUG.Name = "BTNActualizarJUG"
        Me.BTNActualizarJUG.Size = New System.Drawing.Size(148, 48)
        Me.BTNActualizarJUG.TabIndex = 9
        Me.BTNActualizarJUG.Text = "Actualizar"
        Me.BTNActualizarJUG.UseVisualStyleBackColor = True
        '
        'BTNAñadirJUG
        '
        Me.BTNAñadirJUG.Location = New System.Drawing.Point(272, 276)
        Me.BTNAñadirJUG.Name = "BTNAñadirJUG"
        Me.BTNAñadirJUG.Size = New System.Drawing.Size(147, 48)
        Me.BTNAñadirJUG.TabIndex = 8
        Me.BTNAñadirJUG.Text = "Añadir"
        Me.BTNAñadirJUG.UseVisualStyleBackColor = True
        '
        'DateJugadora
        '
        Me.DateJugadora.Location = New System.Drawing.Point(244, 148)
        Me.DateJugadora.Name = "DateJugadora"
        Me.DateJugadora.Size = New System.Drawing.Size(250, 27)
        Me.DateJugadora.TabIndex = 7
        '
        'TXTPaisJUG
        '
        Me.TXTPaisJUG.Location = New System.Drawing.Point(244, 223)
        Me.TXTPaisJUG.Name = "TXTPaisJUG"
        Me.TXTPaisJUG.Size = New System.Drawing.Size(162, 27)
        Me.TXTPaisJUG.TabIndex = 6
        '
        'TXTNombreJUG
        '
        Me.TXTNombreJUG.Location = New System.Drawing.Point(244, 71)
        Me.TXTNombreJUG.Name = "TXTNombreJUG"
        Me.TXTNombreJUG.Size = New System.Drawing.Size(162, 27)
        Me.TXTNombreJUG.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(244, 192)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Pais:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(244, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 28)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(244, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 28)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre:"
        '
        'ListJugadoras
        '
        Me.ListJugadoras.FormattingEnabled = True
        Me.ListJugadoras.ItemHeight = 20
        Me.ListJugadoras.Location = New System.Drawing.Point(23, 40)
        Me.ListJugadoras.Name = "ListJugadoras"
        Me.ListJugadoras.Size = New System.Drawing.Size(191, 344)
        Me.ListJugadoras.TabIndex = 0
        '
        'TabTorneos
        '
        Me.TabTorneos.Controls.Add(Me.TXTCiudadTorneo)
        Me.TabTorneos.Controls.Add(Me.Label7)
        Me.TabTorneos.Controls.Add(Me.TXTFechaTorneo)
        Me.TabTorneos.Controls.Add(Me.BTNLimpiarTorneo)
        Me.TabTorneos.Controls.Add(Me.BTNEliminarTorneo)
        Me.TabTorneos.Controls.Add(Me.BTNActualizarTorneo)
        Me.TabTorneos.Controls.Add(Me.BTNAñadirTorneo)
        Me.TabTorneos.Controls.Add(Me.TXTPaisTorneo)
        Me.TabTorneos.Controls.Add(Me.TXTNombreTorneo)
        Me.TabTorneos.Controls.Add(Me.Label4)
        Me.TabTorneos.Controls.Add(Me.Label5)
        Me.TabTorneos.Controls.Add(Me.Label6)
        Me.TabTorneos.Controls.Add(Me.LSTTorneos)
        Me.TabTorneos.Location = New System.Drawing.Point(4, 29)
        Me.TabTorneos.Name = "TabTorneos"
        Me.TabTorneos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabTorneos.Size = New System.Drawing.Size(795, 428)
        Me.TabTorneos.TabIndex = 1
        Me.TabTorneos.Text = "TORNEOS"
        Me.TabTorneos.UseVisualStyleBackColor = True
        '
        'TXTCiudadTorneo
        '
        Me.TXTCiudadTorneo.Location = New System.Drawing.Point(537, 63)
        Me.TXTCiudadTorneo.Name = "TXTCiudadTorneo"
        Me.TXTCiudadTorneo.Size = New System.Drawing.Size(162, 27)
        Me.TXTCiudadTorneo.TabIndex = 25
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(537, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 28)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Ciudad:"
        '
        'TXTFechaTorneo
        '
        Me.TXTFechaTorneo.Location = New System.Drawing.Point(259, 140)
        Me.TXTFechaTorneo.Name = "TXTFechaTorneo"
        Me.TXTFechaTorneo.Size = New System.Drawing.Size(156, 27)
        Me.TXTFechaTorneo.TabIndex = 23
        '
        'BTNLimpiarTorneo
        '
        Me.BTNLimpiarTorneo.Location = New System.Drawing.Point(537, 347)
        Me.BTNLimpiarTorneo.Name = "BTNLimpiarTorneo"
        Me.BTNLimpiarTorneo.Size = New System.Drawing.Size(148, 42)
        Me.BTNLimpiarTorneo.TabIndex = 22
        Me.BTNLimpiarTorneo.Text = "Limpiar"
        Me.BTNLimpiarTorneo.UseVisualStyleBackColor = True
        '
        'BTNEliminarTorneo
        '
        Me.BTNEliminarTorneo.Location = New System.Drawing.Point(287, 347)
        Me.BTNEliminarTorneo.Name = "BTNEliminarTorneo"
        Me.BTNEliminarTorneo.Size = New System.Drawing.Size(147, 42)
        Me.BTNEliminarTorneo.TabIndex = 21
        Me.BTNEliminarTorneo.Text = "Eliminar"
        Me.BTNEliminarTorneo.UseVisualStyleBackColor = True
        '
        'BTNActualizarTorneo
        '
        Me.BTNActualizarTorneo.Location = New System.Drawing.Point(537, 268)
        Me.BTNActualizarTorneo.Name = "BTNActualizarTorneo"
        Me.BTNActualizarTorneo.Size = New System.Drawing.Size(148, 48)
        Me.BTNActualizarTorneo.TabIndex = 20
        Me.BTNActualizarTorneo.Text = "Actualizar"
        Me.BTNActualizarTorneo.UseVisualStyleBackColor = True
        '
        'BTNAñadirTorneo
        '
        Me.BTNAñadirTorneo.Location = New System.Drawing.Point(287, 268)
        Me.BTNAñadirTorneo.Name = "BTNAñadirTorneo"
        Me.BTNAñadirTorneo.Size = New System.Drawing.Size(147, 48)
        Me.BTNAñadirTorneo.TabIndex = 19
        Me.BTNAñadirTorneo.Text = "Añadir"
        Me.BTNAñadirTorneo.UseVisualStyleBackColor = True
        '
        'TXTPaisTorneo
        '
        Me.TXTPaisTorneo.Location = New System.Drawing.Point(259, 215)
        Me.TXTPaisTorneo.Name = "TXTPaisTorneo"
        Me.TXTPaisTorneo.Size = New System.Drawing.Size(156, 27)
        Me.TXTPaisTorneo.TabIndex = 17
        '
        'TXTNombreTorneo
        '
        Me.TXTNombreTorneo.Location = New System.Drawing.Point(259, 63)
        Me.TXTNombreTorneo.Name = "TXTNombreTorneo"
        Me.TXTNombreTorneo.Size = New System.Drawing.Size(156, 27)
        Me.TXTNombreTorneo.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(259, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 28)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Pais:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(259, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 28)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Fecha:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(259, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 28)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Nombre:"
        '
        'LSTTorneos
        '
        Me.LSTTorneos.FormattingEnabled = True
        Me.LSTTorneos.ItemHeight = 20
        Me.LSTTorneos.Location = New System.Drawing.Point(38, 32)
        Me.LSTTorneos.Name = "LSTTorneos"
        Me.LSTTorneos.Size = New System.Drawing.Size(191, 344)
        Me.LSTTorneos.TabIndex = 12
        '
        'TabPaises
        '
        Me.TabPaises.Controls.Add(Me.BTNLimpiarPais)
        Me.TabPaises.Controls.Add(Me.BTNEliminarPais)
        Me.TabPaises.Controls.Add(Me.BTNActualizarPais)
        Me.TabPaises.Controls.Add(Me.BTNAñadirPais)
        Me.TabPaises.Controls.Add(Me.TXTNombrePais)
        Me.TabPaises.Controls.Add(Me.Label10)
        Me.TabPaises.Controls.Add(Me.LSTPais)
        Me.TabPaises.Location = New System.Drawing.Point(4, 29)
        Me.TabPaises.Name = "TabPaises"
        Me.TabPaises.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPaises.Size = New System.Drawing.Size(795, 428)
        Me.TabPaises.TabIndex = 2
        Me.TabPaises.Text = "PAÍSES"
        Me.TabPaises.UseVisualStyleBackColor = True
        '
        'BTNLimpiarPais
        '
        Me.BTNLimpiarPais.Location = New System.Drawing.Point(540, 346)
        Me.BTNLimpiarPais.Name = "BTNLimpiarPais"
        Me.BTNLimpiarPais.Size = New System.Drawing.Size(148, 42)
        Me.BTNLimpiarPais.TabIndex = 22
        Me.BTNLimpiarPais.Text = "Limpiar"
        Me.BTNLimpiarPais.UseVisualStyleBackColor = True
        '
        'BTNEliminarPais
        '
        Me.BTNEliminarPais.Location = New System.Drawing.Point(290, 346)
        Me.BTNEliminarPais.Name = "BTNEliminarPais"
        Me.BTNEliminarPais.Size = New System.Drawing.Size(147, 42)
        Me.BTNEliminarPais.TabIndex = 21
        Me.BTNEliminarPais.Text = "Eliminar"
        Me.BTNEliminarPais.UseVisualStyleBackColor = True
        '
        'BTNActualizarPais
        '
        Me.BTNActualizarPais.Location = New System.Drawing.Point(540, 267)
        Me.BTNActualizarPais.Name = "BTNActualizarPais"
        Me.BTNActualizarPais.Size = New System.Drawing.Size(148, 48)
        Me.BTNActualizarPais.TabIndex = 20
        Me.BTNActualizarPais.Text = "Actualizar"
        Me.BTNActualizarPais.UseVisualStyleBackColor = True
        '
        'BTNAñadirPais
        '
        Me.BTNAñadirPais.Location = New System.Drawing.Point(290, 267)
        Me.BTNAñadirPais.Name = "BTNAñadirPais"
        Me.BTNAñadirPais.Size = New System.Drawing.Size(147, 48)
        Me.BTNAñadirPais.TabIndex = 19
        Me.BTNAñadirPais.Text = "Añadir"
        Me.BTNAñadirPais.UseVisualStyleBackColor = True
        '
        'TXTNombrePais
        '
        Me.TXTNombrePais.Location = New System.Drawing.Point(262, 62)
        Me.TXTNombrePais.Name = "TXTNombrePais"
        Me.TXTNombrePais.Size = New System.Drawing.Size(162, 27)
        Me.TXTNombrePais.TabIndex = 16
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label10.Location = New System.Drawing.Point(262, 31)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(94, 28)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Nombre:"
        '
        'LSTPais
        '
        Me.LSTPais.FormattingEnabled = True
        Me.LSTPais.ItemHeight = 20
        Me.LSTPais.Location = New System.Drawing.Point(41, 31)
        Me.LSTPais.Name = "LSTPais"
        Me.LSTPais.Size = New System.Drawing.Size(191, 344)
        Me.LSTPais.TabIndex = 12
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl2)
        Me.Name = "Main"
        Me.Text = "Form1"
        Me.TabControl2.ResumeLayout(False)
        Me.TabJugadoras.ResumeLayout(False)
        Me.TabJugadoras.PerformLayout()
        Me.TabTorneos.ResumeLayout(False)
        Me.TabTorneos.PerformLayout()
        Me.TabPaises.ResumeLayout(False)
        Me.TabPaises.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabJugadoras As TabPage
    Friend WithEvents TabTorneos As TabPage
    Friend WithEvents TabPaises As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents ListJugadoras As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTPaisJUG As TextBox
    Friend WithEvents TXTNombreJUG As TextBox
    Friend WithEvents DateJugadora As DateTimePicker
    Friend WithEvents BTNAñadirJUG As Button
    Friend WithEvents BTNLimpiarJUG As Button
    Friend WithEvents BTNEliminarJUG As Button
    Friend WithEvents BTNActualizarJUG As Button
    Friend WithEvents TXTCiudadTorneo As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TXTFechaTorneo As TextBox
    Friend WithEvents BTNLimpiarTorneo As Button
    Friend WithEvents BTNEliminarTorneo As Button
    Friend WithEvents BTNActualizarTorneo As Button
    Friend WithEvents BTNAñadirTorneo As Button
    Friend WithEvents TXTPaisTorneo As TextBox
    Friend WithEvents TXTNombreTorneo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents LSTTorneos As ListBox
    Friend WithEvents BTNLimpiarPais As Button
    Friend WithEvents BTNEliminarPais As Button
    Friend WithEvents BTNActualizarPais As Button
    Friend WithEvents BTNAñadirPais As Button
    Friend WithEvents TXTNombrePais As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LSTPais As ListBox
End Class
