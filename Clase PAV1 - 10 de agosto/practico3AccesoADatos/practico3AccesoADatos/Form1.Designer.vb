<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ABMPersonas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ABMPersonas))
        Me.lbl_Apellido = New System.Windows.Forms.Label()
        Me.lbl_TipoDocumento = New System.Windows.Forms.Label()
        Me.lbl_EstadoCivil = New System.Windows.Forms.Label()
        Me.lbl_Nombres = New System.Windows.Forms.Label()
        Me.lbl_Documento = New System.Windows.Forms.Label()
        Me.lst_Lista = New System.Windows.Forms.ListBox()
        Me.txt_Nombres = New System.Windows.Forms.TextBox()
        Me.txt_Apellido = New System.Windows.Forms.TextBox()
        Me.cmb_TipoDocumento = New System.Windows.Forms.ComboBox()
        Me.cmb_EstadoCivil = New System.Windows.Forms.ComboBox()
        Me.msktxt_Documento = New System.Windows.Forms.MaskedTextBox()
        Me.cmd_Nuevo = New System.Windows.Forms.Button()
        Me.cmd_Grabar = New System.Windows.Forms.Button()
        Me.cmd_Borrar = New System.Windows.Forms.Button()
        Me.cmd_Salir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_Apellido
        '
        Me.lbl_Apellido.AutoSize = True
        Me.lbl_Apellido.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Apellido.Location = New System.Drawing.Point(12, 33)
        Me.lbl_Apellido.Name = "lbl_Apellido"
        Me.lbl_Apellido.Size = New System.Drawing.Size(72, 21)
        Me.lbl_Apellido.TabIndex = 0
        Me.lbl_Apellido.Text = "Apellido"
        '
        'lbl_TipoDocumento
        '
        Me.lbl_TipoDocumento.AutoSize = True
        Me.lbl_TipoDocumento.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TipoDocumento.Location = New System.Drawing.Point(12, 90)
        Me.lbl_TipoDocumento.Name = "lbl_TipoDocumento"
        Me.lbl_TipoDocumento.Size = New System.Drawing.Size(138, 21)
        Me.lbl_TipoDocumento.TabIndex = 4
        Me.lbl_TipoDocumento.Text = "Tipo Documento"
        '
        'lbl_EstadoCivil
        '
        Me.lbl_EstadoCivil.AutoSize = True
        Me.lbl_EstadoCivil.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EstadoCivil.Location = New System.Drawing.Point(12, 141)
        Me.lbl_EstadoCivil.Name = "lbl_EstadoCivil"
        Me.lbl_EstadoCivil.Size = New System.Drawing.Size(97, 21)
        Me.lbl_EstadoCivil.TabIndex = 8
        Me.lbl_EstadoCivil.Text = "Estado Civil"
        '
        'lbl_Nombres
        '
        Me.lbl_Nombres.AutoSize = True
        Me.lbl_Nombres.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nombres.Location = New System.Drawing.Point(12, 63)
        Me.lbl_Nombres.Name = "lbl_Nombres"
        Me.lbl_Nombres.Size = New System.Drawing.Size(80, 21)
        Me.lbl_Nombres.TabIndex = 2
        Me.lbl_Nombres.Text = "Nombres"
        '
        'lbl_Documento
        '
        Me.lbl_Documento.AutoSize = True
        Me.lbl_Documento.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Documento.Location = New System.Drawing.Point(12, 115)
        Me.lbl_Documento.Name = "lbl_Documento"
        Me.lbl_Documento.Size = New System.Drawing.Size(100, 21)
        Me.lbl_Documento.TabIndex = 6
        Me.lbl_Documento.Text = "Documento"
        '
        'lst_Lista
        '
        Me.lst_Lista.Enabled = False
        Me.lst_Lista.FormattingEnabled = True
        Me.lst_Lista.Location = New System.Drawing.Point(12, 179)
        Me.lst_Lista.Name = "lst_Lista"
        Me.lst_Lista.Size = New System.Drawing.Size(467, 186)
        Me.lst_Lista.TabIndex = 10
        '
        'txt_Nombres
        '
        Me.txt_Nombres.Enabled = False
        Me.txt_Nombres.Location = New System.Drawing.Point(151, 59)
        Me.txt_Nombres.Name = "txt_Nombres"
        Me.txt_Nombres.Size = New System.Drawing.Size(279, 20)
        Me.txt_Nombres.TabIndex = 3
        '
        'txt_Apellido
        '
        Me.txt_Apellido.Enabled = False
        Me.txt_Apellido.Location = New System.Drawing.Point(151, 33)
        Me.txt_Apellido.Name = "txt_Apellido"
        Me.txt_Apellido.Size = New System.Drawing.Size(279, 20)
        Me.txt_Apellido.TabIndex = 1
        '
        'cmb_TipoDocumento
        '
        Me.cmb_TipoDocumento.Enabled = False
        Me.cmb_TipoDocumento.FormattingEnabled = True
        Me.cmb_TipoDocumento.Location = New System.Drawing.Point(151, 86)
        Me.cmb_TipoDocumento.Name = "cmb_TipoDocumento"
        Me.cmb_TipoDocumento.Size = New System.Drawing.Size(121, 21)
        Me.cmb_TipoDocumento.TabIndex = 5
        '
        'cmb_EstadoCivil
        '
        Me.cmb_EstadoCivil.Enabled = False
        Me.cmb_EstadoCivil.FormattingEnabled = True
        Me.cmb_EstadoCivil.Location = New System.Drawing.Point(151, 142)
        Me.cmb_EstadoCivil.Name = "cmb_EstadoCivil"
        Me.cmb_EstadoCivil.Size = New System.Drawing.Size(121, 21)
        Me.cmb_EstadoCivil.TabIndex = 9
        '
        'msktxt_Documento
        '
        Me.msktxt_Documento.Enabled = False
        Me.msktxt_Documento.Location = New System.Drawing.Point(152, 113)
        Me.msktxt_Documento.Mask = "99999999"
        Me.msktxt_Documento.Name = "msktxt_Documento"
        Me.msktxt_Documento.Size = New System.Drawing.Size(121, 20)
        Me.msktxt_Documento.TabIndex = 7
        '
        'cmd_Nuevo
        '
        Me.cmd_Nuevo.Image = Global.practico3AccesoADatos.My.Resources.Resources.Nuevo2
        Me.cmd_Nuevo.Location = New System.Drawing.Point(16, 373)
        Me.cmd_Nuevo.Name = "cmd_Nuevo"
        Me.cmd_Nuevo.Size = New System.Drawing.Size(50, 50)
        Me.cmd_Nuevo.TabIndex = 11
        Me.cmd_Nuevo.UseVisualStyleBackColor = True
        '
        'cmd_Grabar
        '
        Me.cmd_Grabar.Enabled = False
        Me.cmd_Grabar.Image = Global.practico3AccesoADatos.My.Resources.Resources.Grabar2
        Me.cmd_Grabar.Location = New System.Drawing.Point(84, 373)
        Me.cmd_Grabar.Name = "cmd_Grabar"
        Me.cmd_Grabar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_Grabar.TabIndex = 12
        Me.cmd_Grabar.UseVisualStyleBackColor = True
        '
        'cmd_Borrar
        '
        Me.cmd_Borrar.Enabled = False
        Me.cmd_Borrar.Image = CType(resources.GetObject("cmd_Borrar.Image"), System.Drawing.Image)
        Me.cmd_Borrar.Location = New System.Drawing.Point(151, 373)
        Me.cmd_Borrar.Name = "cmd_Borrar"
        Me.cmd_Borrar.Size = New System.Drawing.Size(50, 50)
        Me.cmd_Borrar.TabIndex = 13
        Me.cmd_Borrar.UseVisualStyleBackColor = True
        '
        'cmd_Salir
        '
        Me.cmd_Salir.Image = Global.practico3AccesoADatos.My.Resources.Resources.puerta
        Me.cmd_Salir.Location = New System.Drawing.Point(429, 373)
        Me.cmd_Salir.Name = "cmd_Salir"
        Me.cmd_Salir.Size = New System.Drawing.Size(50, 50)
        Me.cmd_Salir.TabIndex = 14
        Me.cmd_Salir.UseVisualStyleBackColor = True
        '
        'frm_ABMPersonas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(491, 436)
        Me.Controls.Add(Me.cmd_Nuevo)
        Me.Controls.Add(Me.cmd_Grabar)
        Me.Controls.Add(Me.cmd_Borrar)
        Me.Controls.Add(Me.cmd_Salir)
        Me.Controls.Add(Me.msktxt_Documento)
        Me.Controls.Add(Me.cmb_EstadoCivil)
        Me.Controls.Add(Me.cmb_TipoDocumento)
        Me.Controls.Add(Me.txt_Apellido)
        Me.Controls.Add(Me.txt_Nombres)
        Me.Controls.Add(Me.lst_Lista)
        Me.Controls.Add(Me.lbl_Documento)
        Me.Controls.Add(Me.lbl_Nombres)
        Me.Controls.Add(Me.lbl_EstadoCivil)
        Me.Controls.Add(Me.lbl_TipoDocumento)
        Me.Controls.Add(Me.lbl_Apellido)
        Me.Name = "frm_ABMPersonas"
        Me.Text = "ABM Personas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Apellido As System.Windows.Forms.Label
    Friend WithEvents lbl_TipoDocumento As System.Windows.Forms.Label
    Friend WithEvents lbl_EstadoCivil As System.Windows.Forms.Label
    Friend WithEvents lbl_Nombres As System.Windows.Forms.Label
    Friend WithEvents lbl_Documento As System.Windows.Forms.Label
    Friend WithEvents lst_Lista As System.Windows.Forms.ListBox
    Friend WithEvents txt_Nombres As System.Windows.Forms.TextBox
    Friend WithEvents txt_Apellido As System.Windows.Forms.TextBox
    Friend WithEvents cmb_TipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_EstadoCivil As System.Windows.Forms.ComboBox
    Friend WithEvents msktxt_Documento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmd_Salir As System.Windows.Forms.Button
    Friend WithEvents cmd_Borrar As System.Windows.Forms.Button
    Friend WithEvents cmd_Grabar As System.Windows.Forms.Button
    Friend WithEvents cmd_Nuevo As System.Windows.Forms.Button

End Class
