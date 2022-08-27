Imports System.Data
Public Class frmNoMAG
    Private Cod_Cliente_Buscar As Long

    Private Sub CargarDatos()
        Try
            Dim dt As New DataTable
            cFunciones.Llenar_Tabla_Generico("select n.id, c.cedula, c.nombre from Clientes c inner join NoMAG n on c.identificacion = n.identificacion", dt, CadenaConexionSeePOS)
            Me.viewDatos.DataSource = dt
            Me.viewDatos.Columns("id").Visible = False
        Catch ex As Exception
        End Try        
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        Try
            Dim cFunciones As New cFunciones
            Me.Cod_Cliente_Buscar = cFunciones.BuscarDatosClientes("select identificacion as Identificación,nombre as Nombre from Clientes", "Nombre")

            If Cod_Cliente_Buscar = 0 Then Exit Sub
            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            db.Ejecutar("Insert into NoMAG(Identificacion) values('" & Me.Cod_Cliente_Buscar & "')", Data.CommandType.Text)
            Me.CargarDatos()
        Catch ex As Exception
        End Try
    End Sub


    Private Sub frmNoMAG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarDatos()
    End Sub

    Private Sub viewDatos_KeyDown(sender As Object, e As KeyEventArgs) Handles viewDatos.KeyDown
        If e.KeyCode = Keys.Delete Then
            Try
                Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
                Dim Id As String = Me.viewDatos.Item("Id", Me.viewDatos.CurrentRow.Index).Value
                db.Ejecutar("Delete from NoMAG where Id = " & Id, Data.CommandType.Text)
                Me.CargarDatos()
            Catch ex As Exception
            End Try
        End If
    End Sub
End Class