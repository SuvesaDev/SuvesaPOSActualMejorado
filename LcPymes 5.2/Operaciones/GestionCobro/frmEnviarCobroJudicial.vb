Imports System.Data
Imports System.Data.SqlClient

Public Class frmEnviarCobroJudicial

    Private Sub CargarInformacionCliente(ByVal codigo As String)
        Dim cConexion As New Conexion
        Dim funciones As New cFunciones
        Dim rs As SqlDataReader
        Dim i As Integer
        Dim fila As DataRow
        Dim factura As Long
        If codigo <> Nothing Then
            rs = cConexion.GetRecorset(cConexion.Conectar, "SELECT Identificacion, Nombre from Clientes where Identificacion ='" & codigo & "'")
            Try
                If rs.Read Then
                    txtCodigo.Text = rs("Identificacion")
                    txtNombre.Text = rs("Nombre")
                    Dim dt As New DataTable
                    dt = funciones.BuscarFacturas(codigo, True)
                    Me.viewDatos.DataSource = dt

                    'carga del datagridview

                    For Each c As DataGridViewColumn In Me.viewDatos.Columns
                        c.ReadOnly = True
                    Next
                    Me.viewDatos.Columns("EnProcesoIncobrable").ReadOnly = False
                    Me.viewDatos.Columns("EnProcesoIncobrable").HeaderText = "Incobrable"
                    Me.viewDatos.Columns("Cod_Moneda").Visible = False                    
                    Me.viewDatos.Columns("Num_Caja").Visible = False
                    Me.viewDatos.Columns("Id").Visible = False
                    Me.viewDatos.Columns("Fecha").DefaultCellStyle.Format = "d"
                    Me.viewDatos.Columns("Total").DefaultCellStyle.Format = "N2"
                    Me.viewDatos.Columns("Total").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

                    If dt.Rows.Count = 0 Then
                        MessageBox.Show("El cliente no tiene facturas pendientes...", "Atención...", MessageBoxButtons.OK)
                        txtCodigo.Focus()
                        rs.Close()
                        Exit Sub
                    Else

                    End If
                Else
                    MsgBox("La identificación del Cliente no se encuentra", MsgBoxStyle.Information, "Atención...")
                    txtCodigo.Focus()
                    rs.Close()
                    Exit Sub
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            rs.Close()
            cConexion.DesConectar(cConexion.Conectar)
        End If
    End Sub

    Private Sub txtCodigo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.F1 Then
            Dim cFunciones As New cFunciones
            txtCodigo.Text = cFunciones.BuscarDatos("select identificacion as Identificación,nombre as Nombre from Clientes", "Nombre")

            CargarInformacionCliente(txtCodigo.Text)
        End If
        If e.KeyCode = Keys.Enter Then
            CargarInformacionCliente(txtCodigo.Text)
        End If
    End Sub

    Private Sub btnEnviarIncobrables_Click(sender As Object, e As EventArgs) Handles btnEnviarIncobrables.Click
        If MsgBox("Confirmar que desea enviar a incobrable las facturas selecionadas", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirmar Accion") = MsgBoxResult.Yes Then

            Dim frm As New frmResponsableEnvioCobro
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim db As New OBSoluciones.SQL.Transaccion(CadenaConexionSeePOS)
                Try
                    For Each r As DataGridViewRow In Me.viewDatos.Rows
                        If r.Cells("EnProcesoIncobrable").Value = True Then
                            db.Ejecutar("Update Ventas Set EnProcesoIncobrable = 1, FechaIncobrable = '" & frm.dtpFecha.Value & "', CedulaIncobrable = '" & frm.IdUsuario & "' Where Id = " & r.Cells("Id").Value, CommandType.Text)
                        End If
                    Next
                    db.Commit()
                    MsgBox("Datos procesados correctamente!!!", MsgBoxStyle.Information, "Correcto")
                    CargarInformacionCliente(txtCodigo.Text)
                Catch ex As Exception
                    db.Rollback()
                End Try
            End If

        End If
    End Sub

End Class