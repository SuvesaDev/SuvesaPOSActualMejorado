Imports System.Data
Public Class frmBuscarFichasActivas

    Private Sub BuscarFichasActivas()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select Id, Ficha, Tipo, BasedeDatos, Fecha, Nombre_Cliente, Total, Usuario from viewPreventasActivas order by fecha desc", dt, CadenaConexionSeePOS)
        Me.viewFichasActivas.DataSource = dt
        Me.viewFichasActivas.Columns("Id").Visible = False
        Me.viewFichasActivas.Columns("BasedeDatos").Visible = False
        'Me.viewFichasActivas.Columns("Fecha").DefaultCellStyle.Format = "d"
        Me.viewFichasActivas.Columns("Total").DefaultCellStyle.Format = "N2"
    End Sub

    Public Id_Usuario As String = ""
    Public NombreUsuario As String = ""
    Public Numero_Caja As Integer = 0
    Public Factura As Boolean = True
    Public Sub CargarPrimerUsuario(_IdUsuario As String)
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select u.Id_Usuario, u.Nombre, a.Num_Caja from aperturacaja a inner join Usuarios u on a.Cedula = u.Id_Usuario where u.Id_Usuario = '" & _IdUsuario & "' and a.Estado = 'A'", dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.Id_Usuario = dt.Rows(0).Item("Id_Usuario")
            Me.NombreUsuario = dt.Rows(0).Item("Nombre")
            Me.lblUsuario.Text = Me.NombreUsuario
            Me.Numero_Caja = dt.Rows(0).Item("Num_Caja")
            Me.lblNumeroCaja.Text = Me.Numero_Caja
            Me.Factura = True
            If IsClinica() = False Then
                If Me.Numero_Caja <> 1 And Me.Numero_Caja <> 2 Then
                    MsgBox("Solo puede facturar las cajas 1 y 2", MsgBoxStyle.Exclamation, "No se puede realizar la operacion")
                    Me.Factura = False
                End If
            End If
        Else
            MsgBox("Usuario no tiene caja abierta", MsgBoxStyle.Exclamation, Me.Text)
            Me.Factura = False
            Me.lblUsuario.Text = ""
            Me.lblNumeroCaja.Text = ""
        End If
    End Sub

    Private Sub frmBuscarFichasActivas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BuscarFichasActivas()
        Me.btnDevolver.Enabled = IsClinica()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.BuscarFichasActivas()
    End Sub

    Private Sub btnInactivar_Click(sender As Object, e As EventArgs) Handles btnInactivar.Click
        Try          
            If Me.viewFichasActivas.RowCount > 0 Then
                Dim frm As New frmVersionCompleta
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim id As String = Me.viewFichasActivas.Item("Id", Me.viewFichasActivas.CurrentRow.Index).Value
                    Dim base As String = Me.viewFichasActivas.Item("BasedeDatos", Me.viewFichasActivas.CurrentRow.Index).Value
                    Dim tipo As String = Me.viewFichasActivas.Item("Tipo", Me.viewFichasActivas.CurrentRow.Index).Value
                    If IsNumeric(id) = True Then
                        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                        If tipo = "ABO" Then
                            db.Ejecutar("Update " & base & ".dbo.PreAbonocCobrar Set Estado = 'Inactivada' Where Id_Recibo = " & id, CommandType.Text)
                        Else
                            db.Ejecutar("Update " & base & ".dbo.PreVentas Set Estado = 'Inactivada' Where Id = " & id, CommandType.Text)
                        End If
                        Me.BuscarFichasActivas()
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub CapturarDatosFicha()
        If Factura = False Then Exit Sub

        Dim ficha As String = ""
        For Each row As DataGridViewRow In Me.viewFichasActivas.SelectedRows
            If ficha = "" Then
                ficha = row.Cells("Ficha").Value
            Else
                ficha += ", " & row.Cells("Ficha").Value
            End If
        Next

        Dim dtPreventasActivas As New DataTable

        Dim soloAPA As Boolean = True

        cFunciones.Llenar_Tabla_Generico("Select * From viewPreventasActivas Where Ficha in(" & ficha & ")", dtPreventasActivas, CadenaConexionSeePOS)
        If dtPreventasActivas.Rows.Count > 0 Then

            Dim indexFichas As Integer = 0
            Dim frm As New frmDatosPreVenta
            frm.NoEnviarPideFicha = True
            frm.txtTotalCobro.Text = "0.00"
            frm.viewFichas.Columns("cAbono").Visible = False
            For Each x As DataRow In dtPreventasActivas.Rows

                If x.Item("Tipo") = "CRE" Or x.Item("Tipo") = "MCR" Or x.Item("Tipo") = "TCR" Then
                    MsgBox("La ficha esta de credito." & vbCrLf _
                            & "Debe crear una nueva ficha que no sea de credito.", MsgBoxStyle.Exclamation, "No se puede realizar la operacion")
                    Exit Sub
                End If

                Dim dtCliente As New DataTable
                Dim esCliente As Boolean
                Dim cedula, correo As String

                Try
                    frm.Cod_Cliente = x.Item("Cod_Cliente")
                Catch ex As Exception

                End Try

                If x.Item("Tipo") = "APA" Then
                    frm.viewFichas.Columns("cAbono").Visible = True
                    cFunciones.Llenar_Tabla_Generico("select cedula, e_mail as CorreoComprobante from " & x.Item("BasedeDatos") & ".dbo.Clientes_frecuentes where identificacion = " & x.Item("Cod_Cliente"), dtCliente, CadenaConexionSeePOS)
                Else
                    soloAPA = False
                    cFunciones.Llenar_Tabla_Generico("select cedula, CorreoComprobante from " & x.Item("BasedeDatos") & ".dbo.Clientes where identificacion = " & x.Item("Cod_Cliente"), dtCliente, CadenaConexionSeePOS)
                End If

                If dtCliente.Rows.Count > 0 Then
                    esCliente = True
                    cedula = dtCliente.Rows(0).Item("cedula")
                    correo = dtCliente.Rows(0).Item("CorreoComprobante")
                Else
                    esCliente = False
                    cedula = ""
                    correo = ""
                End If

                frm.ckEsElectronica.Enabled = False
                frm.ckEsElectronica.Visible = False
                frm.btnTiquete.Enabled = IIf(esCliente = True, False, True)
                frm.btnFactura.Enabled = IIf(esCliente = False, False, True)
                'frm.MdiParent = Me.MdiParent
                frm.txtPuntoVenta.Text = x.Item("BasedeDatos")
                frm.Id_Usuario = Me.Id_Usuario
                frm.NombreUsuario = Me.NombreUsuario
                frm.Numero_Caja = Me.Numero_Caja
                frm.txtCliente.Text = x.Item("Nombre_Cliente")
                frm.txtCedula.Text = cedula
                frm.txtCorreo.Text = correo
                frm.BanderaesCliente = esCliente
                frm.Id_PreVenta = x.Item("Id")

                frm.viewFichas.Rows.Add()
                frm.viewFichas.Item("cId", indexFichas).Value = x.Item("Id")
                frm.viewFichas.Item("cFicha", indexFichas).Value = x.Item("Ficha")
                frm.viewFichas.Rows(indexFichas).Cells("cRenta").ReadOnly = True
                Select Case x.Item("Tipo")
                    Case "PVE"
                        frm.viewFichas.Item("cFE", indexFichas).Value = False
                        frm.viewFichas.Rows(indexFichas).Cells("cFE").ReadOnly = IIf(esCliente = False, True, False)
                        frm.viewFichas.Rows(indexFichas).Cells("cRenta").ReadOnly = False
                    Case "CON"
                        frm.viewFichas.Item("cFE", indexFichas).Value = True
                        frm.viewFichas.Rows(indexFichas).Cells("cFE").ReadOnly = True
                        frm.viewFichas.Rows(indexFichas).Cells("cRenta").ReadOnly = False
                    Case "TCO"
                        frm.viewFichas.Item("cFE", indexFichas).Value = True
                        frm.viewFichas.Rows(indexFichas).Cells("cFE").ReadOnly = True
                        frm.viewFichas.Rows(indexFichas).Cells("cRenta").ReadOnly = False
                    Case "MCO"
                        frm.viewFichas.Item("cFE", indexFichas).Value = True
                        frm.viewFichas.Rows(indexFichas).Cells("cFE").ReadOnly = True
                        frm.viewFichas.Rows(indexFichas).Cells("cRenta").ReadOnly = False
                    Case Else
                        frm.viewFichas.Item("cFE", indexFichas).Value = False
                        frm.viewFichas.Rows(indexFichas).Cells("cFE").ReadOnly = True
                End Select
                frm.viewFichas.Item("cTipo", indexFichas).Value = x.Item("Tipo")
                frm.viewFichas.Item("cCliente", indexFichas).Value = x.Item("Nombre_Cliente")
                frm.viewFichas.Item("cCedula", indexFichas).Value = cedula
                frm.viewFichas.Item("cCorreo", indexFichas).Value = correo
                frm.viewFichas.Item("cPuntoVenta", indexFichas).Value = x.Item("BasedeDatos")
                frm.viewFichas.Item("cTotal", indexFichas).Value = CDec(x.Item("Total")).ToString("N2")
                frm.viewFichas.Item("cDocumento", indexFichas).Value = 0
                frm.viewFichas.Item("cAbono", indexFichas).Value = 0
                frm.viewFichas.Item("cRenta", indexFichas).Value = False
                indexFichas += 1
            Next

            If dtPreventasActivas.Rows(0).Item("Tipo") <> "ABO" Then
                Select Case dtPreventasActivas.Rows(0).Item("Tipo")
                    Case "APA"
                        frm.btnFactura.Enabled = False
                        frm.btnTiquete.Enabled = False
                        frm.btnReciboDinero.Enabled = False
                        frm.btnGeneraAdelanto.Enabled = False
                    Case "CON"
                        frm.btnGenerarApartado.Enabled = False
                        frm.btnReciboDinero.Enabled = False
                    Case "CRE"
                        frm.btnReciboDinero.Enabled = False
                        frm.btnGenerarApartado.Enabled = False
                    Case "PVE"
                        frm.ckEsElectronica.Enabled = True
                        frm.ckEsElectronica.Visible = True
                        frm.btnFactura.Enabled = False
                        frm.btnReciboDinero.Enabled = False
                        frm.btnGenerarApartado.Enabled = False
                End Select
                '************************************************************************************
            Else
                '************************************************************************************
                Dim dtCliente As New DataTable
                Dim esCliente As Boolean
                Dim cedula, correo As String
                cFunciones.Llenar_Tabla_Generico("select cedula, CorreoComprobante from " & dtPreventasActivas.Rows(0).Item("BasedeDatos") & ".dbo.Clientes where identificacion = " & dtPreventasActivas.Rows(0).Item("Cod_Cliente"), dtCliente, CadenaConexionSeePOS)
                If dtCliente.Rows.Count > 0 Then
                    esCliente = True
                    cedula = dtCliente.Rows(0).Item("cedula")
                    correo = dtCliente.Rows(0).Item("CorreoComprobante")
                Else
                    esCliente = False
                    cedula = ""
                    correo = ""
                End If
                'Dim frm As New frmDatosPreVenta
                ' frm.MdiParent = Me.MdiParent
                frm.txtPuntoVenta.Text = dtPreventasActivas.Rows(0).Item("BasedeDatos")
                frm.Id_Usuario = Me.Id_Usuario
                frm.NombreUsuario = Me.NombreUsuario
                frm.Numero_Caja = Me.Numero_Caja
                frm.txtCliente.Text = dtPreventasActivas.Rows(0).Item("Nombre_Cliente")
                frm.txtCedula.Text = cedula
                frm.txtCorreo.Text = correo
                frm.BanderaesCliente = esCliente
                frm.Id_PreVenta = dtPreventasActivas.Rows(0).Item("Id")
                Dim dtdetalle As New DataTable
                cFunciones.Llenar_Tabla_Generico("select Factura, Monto, Saldo_Ant, Abono, Saldo from " & dtPreventasActivas.Rows(0).Item("BasedeDatos") & ".dbo.Detalle_PreAbonocCobrar where id_recibo = " & dtPreventasActivas.Rows(0).Item("Id"), dtdetalle, CadenaConexionSeePOS)
                frm.viewDatos.DataSource = dtdetalle
                Try
                    frm.viewDatos.Columns("Monto").DefaultCellStyle.Format = "N2"
                    frm.viewDatos.Columns("Monto").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
                    frm.viewDatos.Columns("Saldo_Ant").DefaultCellStyle.Format = "N2"
                    frm.viewDatos.Columns("Saldo_Ant").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
                    frm.viewDatos.Columns("Abono").DefaultCellStyle.Format = "N2"
                    frm.viewDatos.Columns("Abono").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
                    frm.viewDatos.Columns("Saldo").DefaultCellStyle.Format = "N2"
                    frm.viewDatos.Columns("Saldo").DefaultCellStyle.Alignment = Windows.Forms.DataGridViewContentAlignment.MiddleRight
                Catch ex As Exception
                End Try
                frm.btnFactura.Enabled = False
                frm.btnTiquete.Enabled = False
                frm.btnGeneraAdelanto.Enabled = False
                frm.btnGenerarApartado.Enabled = False
                '************************************************************************************
            End If

            If soloAPA = True Then
                frm.viewFichas.Columns("cFE").Visible = False
                frm.viewFichas.Columns("cPendiente").Visible = False
                frm.viewFichas.Columns("cRenta").Visible = False
            End If

            Dim totalapagar As Decimal = (From x As DataGridViewRow In frm.viewFichas.Rows Select CDec(x.Cells("cTotal").Value)).Sum
            frm.txtTotalCobro.Text = totalapagar.ToString("N2")

            frm.ShowDialog()
            Me.BuscarFichasActivas()
            'Me.Close()

        Else

        End If
    End Sub

    Private Sub viewFichasActivas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewFichasActivas.CellDoubleClick
        Me.CapturarDatosFicha()
    End Sub

    Private Sub btnDevolver_Click(sender As Object, e As EventArgs) Handles btnDevolver.Click
        Try
            Dim id As String = Me.viewFichasActivas.Item("Id", Me.viewFichasActivas.CurrentRow.Index).Value
            Dim base As String = Me.viewFichasActivas.Item("BasedeDatos", Me.viewFichasActivas.CurrentRow.Index).Value
            Dim tipo As String = Me.viewFichasActivas.Item("Tipo", Me.viewFichasActivas.CurrentRow.Index).Value

            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select * from Albaran where ID_Factura_Suvesa = " & id, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Dim frm As New frmVersionCompleta
                If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

                    If MsgBox("Desea Reversar la preventa." & vbCrLf _
                              & "Esta accion inactivara la preventa y devolvera los albaranes", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirmar Accion.") = MsgBoxResult.Yes Then
                        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                        db.Ejecutar("Update " & base & ".dbo.PreVentas Set Estado = 'Inactivada' Where Id = " & id, CommandType.Text)
                        db.Ejecutar("Update " & base & ".dbo.Albaran set facturado = 0, ID_Factura_Suvesa = 0 where ID_Factura_Suvesa = " & id, CommandType.Text)
                        Me.BuscarFichasActivas()
                    End If

                End If
            Else
                MsgBox("La preventa no tiene relacionado un albaran", MsgBoxStyle.Exclamation, "No se puede realizar la Operacion.")
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub btnFacturar_Click(sender As Object, e As EventArgs) Handles btnFacturar.Click
        CapturarDatosFicha()
    End Sub

    Private Sub viewFichasActivas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles viewFichasActivas.CellContentClick

    End Sub
End Class