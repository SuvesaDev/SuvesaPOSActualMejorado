
Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms
Public Class frm_rifas
    Inherits FrmPlantilla

    Dim NuevaConexion As String
    Dim sqlConexion As SqlConnection
    Dim usua As Usuario_Logeado
    Dim strModulo As String = ""
    Public CConexion As New Conexion

    Private Sub frm_rifas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.SqlConnection1.ConnectionString = IIf(NuevaConexion = "", CadenaConexionSeePOS, NuevaConexion)
            strModulo = IIf(NuevaConexion = "", "SeePOS", "SeePos")
            'SqlConnection.ConnectionString = CadenaConexionSeePOS
            Me.adapte_rifa.Fill(Me.Dsrifa1.rifa)

            Dsrifa1.rifa.idColumn.AutoIncrement = True
            Dsrifa1.rifa.idColumn.AutoIncrementSeed = -1

            Dsrifa1.rifa.fecha_inicioColumn.DefaultValue = dt_fin.Text
            Dsrifa1.rifa.fecha_finColumn.DefaultValue = dt_fin.Text
            Dsrifa1.rifa.anuladaColumn.DefaultValue = ck_anulado.Checked
            Dsrifa1.rifa.finalizadaColumn.DefaultValue = ck_finalizada.Checked
            Dsrifa1.rifa.cant_minColumn.DefaultValue = cant_minima.Value

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Function Nuevo()
        Try
            Me.BindingContext(Me.Dsrifa1.rifa).EndCurrentEdit()
            Me.BindingContext(Me.Dsrifa1.rifa).AddNew()

        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Function
    Function Registrar()
        Try
            Me.BindingContext(Me.Dsrifa1.rifa).EndCurrentEdit()
            Me.adapte_rifa.Update(Me.Dsrifa1.rifa)
            MsgBox("Los datos fueron ingresados correctamente")
        Catch ex As Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Function

    Private Sub Eliminar()
        Try
            Dim rs As SqlDataReader
            If Me.BindingContext(Me.Dsrifa1.rifa).Count > 0 Then

                'Evaluo si las subfamilias estan asociadas a un articulo 
                Dim strCodigoMarca As String = Me.BindingContext(Me.Dsrifa1, "rifa").Current("CodMarca")
                'Habro la conexion 
                sqlConexion = CConexion.Conectar(strModulo)
                'Realizo la busqueda en la base de datos
                rs = CConexion.GetRecorset(sqlConexion, "SELECT id FROM Inventario WHERE CodMarca = '" & strCodigoMarca & "'")
                'Evaluo si encontro registros dentro de la tabla inventario
                If rs.Read Then
                    MsgBox("No se puede eliminar esta Marca por que existe articulos en el inventario que pertenecen a esta")
                    rs.Close()
                    CConexion.DesConectar(sqlConexion)
                    Exit Sub
                End If
                'Si no encontro registros eliminara el registro actual
                Me.EliminarDatos(Me.adapte_rifa, Me.Dsrifa1, Me.Dsrifa1.rifa.ToString)
            End If
            rs.Close()
            CConexion.DesConectar(sqlConexion)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Sub Buscar_rifa()
        Try
            Dim Fx As New cFunciones
            Dim valor As String
            Dim pos As Integer
            Dim vista As DataView

            valor = Fx.BuscarDatos("Select id,descripcion from rifa", "Rifas", "Buscar rifa...", Me.SqlConnection1.ConnectionString)

            If valor = "" Then
                Exit Sub
            Else
                vista = Me.Dsrifa1.rifa.DefaultView
                vista.Sort = "id"
                pos = vista.Find(CDbl(valor))
                Me.BindingContext(Me.Dsrifa1, "rifa").Position = pos
                Me.Cargar_Proveedores(Me.BindingContext(Me.Dsrifa1, "rifa").Current("Id"))
            End If
            Me.gp.Enabled = True
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Try

            Dim PMU As New PerfilModulo_Class   'Declara la variable Perfil Modulo Usuario
            PMU = VSM(usua.Cedula, Me.Name) 'Carga los privilegios del usuario con el modu

            Select Case ToolBar1.Buttons.IndexOf(e.Button)
                Case 0
                    If ToolBar1.Buttons(0).Text = "Nuevo" Then
                        Me.NuevosDatos(Me.Dsrifa1, Me.Dsrifa1.rifa.ToString)
                        ToolBar1.Buttons(0).Text = "Cancelar"
                        ToolBar1.Buttons(0).ImageIndex = 8
                        Me.ToolBar1.Buttons(2).Enabled = True
                        DataNavigator.Enabled = True
                        Me.ToolBarBuscar.Enabled = False
                        Me.ToolBarImprimir.Enabled = False
                        Me.ToolBarEliminar.Enabled = False
                        gp.Enabled = True
                    Else
                        Me.BindingContext(Me.Dsrifa1, "rifa").CancelCurrentEdit()
                        ToolBar1.Buttons(0).Text = "Nuevo"
                        ToolBar1.Buttons(0).ImageIndex = 0
                        Me.ToolBar1.Buttons(2).Enabled = False
                        DataNavigator.Enabled = True
                        Me.ToolBarBuscar.Enabled = True
                        Me.ToolBarImprimir.Enabled = True
                        Me.ToolBarEliminar.Enabled = True
                    End If

                Case 1 : If PMU.Find Then Me.Buscar_rifa() Else MsgBox("No tiene permiso para Buscar información...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                Case 2 : If PMU.Update Then
                        Me.RegistrarDatos(Me.adapte_rifa, Me.Dsrifa1, Me.Dsrifa1.rifa.ToString)
                        Me.Guardar_Proveedores(Me.BindingContext(Me.Dsrifa1, "rifa").Current("Id"))
                        DataNavigator.Enabled = True
                        Me.ToolBarBuscar.Enabled = True
                        Me.ToolBarImprimir.Enabled = True
                        Me.ToolBarEliminar.Enabled = True
                    Else
                        MsgBox("No tiene permiso para agregar o actualizar datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                    End If

                Case 3 : If PMU.Delete Then Eliminar() Else MsgBox("No tiene permiso para eliminar o anular datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                    'Case 4 : If PMU.Print Then Me.imprimir() Else MsgBox("No tiene permiso para imprimir los datos...", MsgBoxStyle.Information, "Atención...") : Exit Sub
                Case 4 : Me.gp.Enabled = True
                Case 6 : Me.Cerrar()

            End Select
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub New(ByVal Usuario_Parametro As Object, Optional ByVal Conexion As String = "")
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        NuevaConexion = Conexion
        usua = Usuario_Parametro

    End Sub

    Private Index As Integer = 0
    Private Sub btnAgregarProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarProveedor.Click
        Dim Fx As New cFunciones
        Dim valor As String
        Dim dt As New DataTable
        valor = Fx.BuscarDatos("Select CodigoProv,Nombre from Proveedores", "Nombre", "Buscar Proveedor...")
        If valor <> "" Then
            cFunciones.Llenar_Tabla_Generico("select CodigoProv, Nombre from Proveedores where CodigoProv = " & valor, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Me.viewProveedores.Rows.Add()
                Me.viewProveedores.Item(0, Me.Index).Value = dt.Rows(0).Item("CodigoProv")
                Me.viewProveedores.Item(1, Me.Index).Value = dt.Rows(0).Item("Nombre")
                Me.Index += 1
            End If
        End If
    End Sub

    Private Sub btnQuitarproveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarproveedor.Click
        If Me.viewProveedores.RowCount > 0 Then
            Me.viewProveedores.Rows.Remove(Me.viewProveedores.CurrentRow)
            Me.Index -= 1
        End If
    End Sub

    Private Sub Guardar_Proveedores(ByVal _IdRifa As String)
        Dim db As New GestioDatos()
        db.Ejecuta("delete from Rifa_Detalle where IdRifa = " & _IdRifa)

        For Each r As DataGridViewRow In Me.viewProveedores.Rows
            db.Ejecuta("Insert into Rifa_Detalle(IdRifa,IdProveedor,Nombre) values(" & _IdRifa & ", " & r.Cells(0).Value & ", '" & r.Cells(1).Value & "')")
        Next
    End Sub

    Private Sub Cargar_Proveedores(ByVal _IdRifa As String)
        Dim db As New GestioDatos()
        Dim dt As New DataTable
        dt = db.Ejecuta("Select * from Rifa_Detalle where IdRifa = " & _IdRifa)

        Me.viewProveedores.Rows.Clear()
        Me.Index = 0

        For i As Integer = 0 To dt.Rows.Count - 1
            Me.viewProveedores.Rows.Add()
            Me.viewProveedores.Item(0, Me.Index).Value = dt.Rows(i).Item("IdProveedor")
            Me.viewProveedores.Item(1, Me.Index).Value = dt.Rows(i).Item("Nombre")
            Me.Index += 1
        Next

    End Sub

End Class