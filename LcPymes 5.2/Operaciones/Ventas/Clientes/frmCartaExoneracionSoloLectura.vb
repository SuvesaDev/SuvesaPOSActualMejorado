Imports System.Data
Public Class frmCartaExoneracionSoloLectura
    Public Identificacion As String = "0"
    Private Id As Integer = 0

    Private Sub CargarCliente(_Identificacion As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * from Clientes where Identificacion = '" & _Identificacion & "'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.txtCodCliente.Text = _Identificacion
            Me.txtCliente.Text = dt.Rows(0).Item("nombre")
            Me.CargarCartasCliente(_Identificacion)
        End If
    End Sub

    Private Sub CargarCartasCliente(_Identificacion As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * from viewCartaExoneracion where identificacion = '" & _Identificacion & "'", dt, CadenaConexionSeePOS)
        Me.viewCartasExoneracion.DataSource = dt
        Me.viewCartasExoneracion.Columns("FechaEmision").DefaultCellStyle.Format = "d"
        Me.viewCartasExoneracion.Columns("FechaVence").DefaultCellStyle.Format = "d"
        Me.viewCartasExoneracion.Columns("Id").Visible = False
        Me.viewCartasExoneracion.Columns("Identificacion").Visible = False
        Me.viewCartasExoneracion.Columns("Nombre").Visible = False
        Me.viewCartasExoneracion.Columns("IdTipoExoneracion").Visible = False
    End Sub

    Public Sub CargarTiposExoneracion()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select IdTipoExoneracion, TipoExoneracion from TipoExoneracion where TipoExoneracion <> ''", dt, CadenaConexionSeePOS)
        Me.cboExoneracion.DataSource = dt
        Me.cboExoneracion.DisplayMember = "TipoExoneracion"
        Me.cboExoneracion.ValueMember = "IdTipoExoneracion"
    End Sub

    Private Sub AgregarCarta()
        If Me.txtPorcentajeCompra.Text <> "" Then
            If IsNumeric(Me.txtPorcentajeCompra.Text) Then
                Dim PorcentajeCompra As Decimal = CDec(Me.txtPorcentajeCompra.Text)
                If PorcentajeCompra > 1 And PorcentajeCompra <= 13 Then

                    Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                    If Me.Id = 0 Then
                        db.AddParametro("@Identificacion", Me.txtCodCliente.Text)
                        db.AddParametro("@IdTipoExoneracion", Me.cboExoneracion.SelectedValue)
                        db.AddParametro("@NumeroDocumento", Me.txtNumeroDocumento.Text)
                        db.AddParametro("@FechaEmision", Me.dtpFechaEmison.Value)
                        db.AddParametro("@FechaVence", Me.dtpFechaVence.Value)
                        db.AddParametro("@PorcentajeCompra", Me.txtPorcentajeCompra.Text)
                        db.AddParametro("@Impuesto", Me.txtIV.Text)
                        db.Ejecutar("Insert into CartaExoneracion([Identificacion],[IdTipoExoneracion],[NumeroDocumento],[FechaEmision],[FechaVence],[PorcentajeCompra],[Impuesto]) Values(@Identificacion, @IdTipoExoneracion, @NumeroDocumento, @FechaEmision, @FechaVence, @PorcentajeCompra, @Impuesto)", CommandType.Text)
                    Else
                        db.AddParametro("@Identificacion", Me.txtCodCliente.Text)
                        db.AddParametro("@IdTipoExoneracion", Me.cboExoneracion.SelectedValue)
                        db.AddParametro("@NumeroDocumento", Me.txtNumeroDocumento.Text)
                        db.AddParametro("@FechaEmision", Me.dtpFechaEmison.Value)
                        db.AddParametro("@FechaVence", Me.dtpFechaVence.Value)
                        db.AddParametro("@PorcentajeCompra", Me.txtPorcentajeCompra.Text)
                        db.AddParametro("@Impuesto", Me.txtIV.Text)
                        db.Ejecutar("Update CartaExoneracion Set [Identificacion] = @Identificacion, [IdTipoExoneracion] = @IdTipoExoneracion, [NumeroDocumento] = @NumeroDocumento, [FechaEmision] = @FechaEmision, [FechaVence] = @FechaVence, [PorcentajeCompra] = @PorcentajeCompra ,[Impuesto] = @Impuesto Where Id =  " & Me.Id, CommandType.Text)
                    End If
                    Me.CargarCartasCliente(Me.txtCodCliente.Text)
                    Me.Limpiar()
                Else
                    MsgBox("Porcentaje Exoneracion invalido.", MsgBoxStyle.Exclamation, Text)
                    Me.txtPorcentajeCompra.Focus()
                End If
            Else
                MsgBox("Porcentaje Exoneracion invalido.", MsgBoxStyle.Exclamation, Text)
                Me.txtPorcentajeCompra.Focus()
            End If
        Else
            MsgBox("Porcentaje Exoneracion invalido.", MsgBoxStyle.Exclamation, Text)
            Me.txtPorcentajeCompra.Focus()
        End If
    End Sub

    Private Sub EliminarCarta()
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        db.AddParametro("@Id", Me.Id)
        db.Ejecutar("Delete from CartaExoneracion Where Id = @Id", CommandType.Text)
        Me.CargarCartasCliente(Me.txtCodCliente.Text)
        Me.Limpiar()
    End Sub

    Private Sub Limpiar()
        Me.txtNumeroDocumento.Text = ""
        Me.dtpFechaEmison.Value = Date.Now
        Me.dtpFechaVence.Value = Date.Now
        Me.txtPorcentajeCompra.Text = 0
        Me.txtIV.Text = "13"
        Me.Id = 0
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Dim frmBuscarCliente As New frm_buscar_cliente
        frmBuscarCliente.txt_nombre.Focus()
        If frmBuscarCliente.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.CargarCliente(frmBuscarCliente.id)
        End If
    End Sub

    Private Sub txtPorcentajeCompra_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles txtPorcentajeCompra.KeyPress

    End Sub

    Private Sub frmCartaExoneracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarTiposExoneracion()
        If Me.Identificacion <> "0" Then Me.CargarCliente(Me.Identificacion)
    End Sub

    Private Sub txtPorcentajeCompra_TextChanged(sender As Object, e As EventArgs) Handles txtPorcentajeCompra.TextChanged
        If IsNumeric(txtPorcentajeCompra.Text) = True Then
            Dim IV As Decimal = 13 - CDec(Me.txtPorcentajeCompra.Text)
            Me.txtIV.Text = IV
        Else
            Me.txtIV.Text = 13
        End If
    End Sub

    Private Sub viewCartasExoneracion_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewCartasExoneracion.CellDoubleClick
        Me.Id = Me.viewCartasExoneracion.Item("Id", Me.viewCartasExoneracion.CurrentRow.Index).Value
        Me.cboExoneracion.SelectedValue = Me.viewCartasExoneracion.Item("IdTipoExoneracion", Me.viewCartasExoneracion.CurrentRow.Index).Value
        Me.txtNumeroDocumento.Text = Me.viewCartasExoneracion.Item("NumeroDocumento", Me.viewCartasExoneracion.CurrentRow.Index).Value
        Me.dtpFechaEmison.Value = Me.viewCartasExoneracion.Item("FechaEmision", Me.viewCartasExoneracion.CurrentRow.Index).Value
        Me.dtpFechaVence.Value = Me.viewCartasExoneracion.Item("FechaVence", Me.viewCartasExoneracion.CurrentRow.Index).Value
        Me.txtPorcentajeCompra.Text = Me.viewCartasExoneracion.Item("PorcentajeCompra", Me.viewCartasExoneracion.CurrentRow.Index).Value
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New frmValidarCartaExoneracion
        frm.NumeroCarta = ""
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

            'If frm.txtIdentificacion.Text <> Me.Identificacion Then
            '    MsgBox("La cedula del cliente y la cedula de la exoneracion no son la misma", MsgBoxStyle.Critical, "Cedula incorrecta")
            '    Exit Sub
            'End If

            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            db.AddParametro("@Identificacion", Identificacion)
            db.AddParametro("@IdTipoExoneracion", Me.cboExoneracion.SelectedValue) 'nose
            db.AddParametro("@NumeroDocumento", frm.txtNumCarta.Text)
            db.AddParametro("@FechaEmision", frm.dtpFecha.Value)
            db.AddParametro("@FechaVence", DateAdd(DateInterval.Year, 1, frm.dtpFecha.Value))
            db.AddParametro("@PorcentajeCompra", CDec(frm.txtPorcentaje.Text))
            db.AddParametro("@Impuesto", CDec(13 - CDec(frm.txtPorcentaje.Text)))
            db.AddParametro("@Nota", "")
            db.Ejecutar("Insert into CartaExoneracion([Identificacion],[IdTipoExoneracion],[NumeroDocumento],[FechaEmision],[FechaVence],[PorcentajeCompra],[Impuesto], [Nota]) Values(@Identificacion, @IdTipoExoneracion, @NumeroDocumento, @FechaEmision, @FechaVence, @PorcentajeCompra, @Impuesto, @Nota)", CommandType.Text)
            Me.CargarCliente(Me.Identificacion)

        End If
    End Sub

End Class