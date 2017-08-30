Public Class frm_ABMPersonas

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles lbl_Nombres.Click

    End Sub

    Private Sub cmd_TipoDocumento_Click(sender As Object, e As EventArgs) Handles lbl_TipoDocumento.Click

    End Sub

    Dim conexion As New Data.OleDb.OleDbConnection
    Dim comando As New Data.OleDb.OleDbCommand

    Dim tabla1 As New Data.DataTable
    Dim cadenaConexion As String = "Provider=SQLNCLI11;Data Source=HP-PC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=_BD_PERSONAS1"

    Private Sub frm_ABMPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        cargarCombo(cmb_TipoDocumento, leoTabla("tipos_documento"))
        cargarCombo(cmb_EstadoCivil, leoTabla("tipos_estado_civil"))
        cargarLista(lst_Lista, leoPersona("personas"))

    End Sub
    Private Sub cargarLista(ByRef lista As ListBox, ByRef tabla As Data.DataTable)

        lista.DataSource = tabla
        lista.DisplayMember = "nombres"
        lista.ValueMember = "documento"
    End Sub

    Private Sub cargarCombo(ByRef combo As ComboBox, ByRef tabla As Data.DataTable)
        combo.DataSource = tabla
        combo.DisplayMember = tabla.Columns(1).ColumnName
        combo.ValueMember = tabla.Columns(0).ColumnName


    End Sub


    Private Function leoTabla(ByVal nombreTabla As String) As Data.DataTable
        Dim tabla As New Data.DataTable

        Me.conexion.ConnectionString = cadenaConexion
        Me.conexion.Open()

        'a partir de aca se envian las consultas a la base de datos
        Me.comando.Connection = conexion
        Me.comando.CommandType = CommandType.Text
        Me.comando.CommandText = "select * from " & nombreTabla

        'se carga la tabla en memoria y como ya los datos de la base de datos estan del lado de la aplicacion, se puede cerrar la conexion a la base de datos
        tabla.Load(Me.comando.ExecuteReader())
        Me.conexion.Close()
        Return tabla

        


    End Function

    Private Function leoPersona(ByVal nombreTabla As String) As Data.DataTable
        Dim tabla As New Data.DataTable

        Me.conexion.ConnectionString = cadenaConexion
        Me.conexion.Open()

        'a partir de aca se envian las consultas a la base de datos
        Me.comando.Connection = conexion
        Me.comando.CommandType = CommandType.Text
        Me.comando.CommandText = "select apellido+', '+nombre as nombres,nro_documento as documento from " & nombreTabla

        'se carga la tabla en memoria y como ya los datos de la base de datos estan del lado de la aplicacion, se puede cerrar la conexion a la base de datos
        tabla.Load(Me.comando.ExecuteReader())
        Me.conexion.Close()
        Return tabla
    End Function

    Private Function validarExistencia() As Boolean

        Dim tabla As New Data.DataTable
        Dim consulta As String = ""

        conexion.Open()
        consulta = "select * from personas where id_tipo_documento = " & cmb_TipoDocumento.SelectedValue & " and nro_documento = " & msktxt_Documento.Text
        Me.comando.CommandType = CommandType.Text
        Me.comando.CommandText = consulta
        Me.comando.Connection = conexion

        MessageBox.Show(consulta)

        tabla.Load(Me.comando.ExecuteReader())

        conexion.Close()

        If tabla.Rows.Count() = 0 Then
            Return True
        Else
            Return False
        End If

        'Dim variable As String
        'Me.comando.Connection = conexion
        'Me.comando.CommandType = CommandType.Text
        'Me.comando.CommandText = "Select personas.nro_documento, personas.id_tipo_documento From personas Where nro_documento = " & numeroDocumento

        'tabla.Load(Me.comando.ExecuteReader())
        'Me.conexion.Close()
        'variable = tabla.Rows[0]
        'Return tabla





    End Function


    Private Sub cmd_Grabar_Click(sender As Object, e As EventArgs) Handles cmd_Grabar.Click
        If validarDatos() Then
            If validarExistencia() Then
                MessageBox.Show("Se grabo con exito el nuevo registro...")
            Else
                MessageBox.Show("Ya existe una persona con ese documento..", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            End If
        End If

    End Sub

    Private Function validarDatos() As Boolean
        Dim nombre, apellido As String
        ' Dim variable As Boolean
        nombre = txt_Nombres.Text
        apellido = txt_Apellido.Text
        If Trim(String.IsNullOrEmpty(apellido)) Then
            MessageBox.Show("Usted debe completar con el Apellido...")
            Return False
        ElseIf Trim(String.IsNullOrEmpty(txt_Nombres.Text)) Then
            MessageBox.Show("Usted debe completar con el Nombre...")
            Return False
        Else
            insertar()
            Return True
        End If

    End Function

  

    Private Function insertar() As Boolean
        Dim consulta As String
        consulta = "Insert into personas (nro_documento, id_tipo_documento, apellido, nombre, id_estado_civil) Values ("
        consulta &= msktxt_Documento.Text & ","
        consulta &= cmb_TipoDocumento.SelectedValue & ",'"
        consulta &= txt_Apellido.Text
        consulta &= "','" & txt_Nombres.Text
        consulta &= "'," & cmb_EstadoCivil.SelectedValue
        consulta &= ")"


        MessageBox.Show(consulta)

        Me.conexion.ConnectionString = cadenaConexion
        Me.conexion.Open()
            'a partir de aca se envian las consultas a la base de datos
        Me.comando.Connection = conexion
        Me.comando.CommandType = CommandType.Text
        Me.comando.CommandText = consulta
        Me.comando.ExecuteNonQuery()
        Me.conexion.Close()

        Return True
    End Function

    Private Sub cmd_Nuevo_Click(sender As Object, e As EventArgs) Handles cmd_Nuevo.Click
        Me.cmd_Grabar.Enabled = True
        Me.cmd_Borrar.Enabled = True
        Me.txt_Apellido.Enabled = True
        Me.txt_Nombres.Enabled = True
        Me.cmb_TipoDocumento.Enabled = True
        Me.msktxt_Documento.Enabled = True
        Me.cmb_EstadoCivil.Enabled = True
        Me.lst_Lista.Enabled = True
        Me.txt_Apellido.Text = ""
        Me.txt_Apellido.Focus()

    End Sub

    Private Sub lst_Lista_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lst_Lista.DoubleClick
        Dim documento As Integer = sender.SelectedValue
        Dim tabla As New Data.DataTable
        Dim consulta As String
        conexion.Open()
        Me.comando.Connection = conexion
        Me.comando.CommandType = CommandType.Text
        Me.comando.CommandText = "select * from personas where nro_documento = " & documento
        tabla.Load(Me.comando.ExecuteReader())
        Me.txt_Apellido.Text = tabla.Rows(0)("apellido")
        Me.txt_Nombres.Text = tabla.Rows(0)("nombre")
        Me.msktxt_Documento.Text = sender.SelectedValue
        Me.cmb_TipoDocumento.SelectedValue = tabla.Rows(0)("id_tipo_documento")
        Me.msktxt_Documento.Enabled = False
        conexion.Close()

        consulta = "Delete from personas where id_tipo_documento = " & Me.cmb_TipoDocumento.SelectedValue & " and nro_documento = " & Me.msktxt_Documento.Text
        conexion.Open()
        Me.comando.Connection = conexion
        Me.comando.CommandType = CommandType.Text

        MessageBox.Show(consulta)
        Me.comando.CommandText = consulta
        Me.comando.ExecuteNonQuery()

        conexion.Close()

    End Sub

    Private Sub lst_Lista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lst_Lista.SelectedIndexChanged

    End Sub
End Class



