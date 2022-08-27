Imports System.Data.Sql
Imports System.Data
Public Class frmCambiarConexion

    'Data Source=9; Initial Catalog=Seepos ; Integrated Security=true;

    Private Sub CambiarConexion(_servidor As String, _basededatos As String)

        Dim Seguridad As String = "Data Source=" & _servidor & "; Initial Catalog=Seguridad ; Integrated Security=true;"
        Dim Seepos As String = "Data Source=" & _servidor & "; Initial Catalog=" & _basededatos & " ; Integrated Security=true;"
        Dim Bancos As String = "Data Source=" & _servidor & "; Initial Catalog=Bancos ; Integrated Security=true;"
        Dim Contabilidad As String = "Data Source=" & _servidor & "; Initial Catalog=Contabilidad ; Integrated Security=true;"
        Dim Cedula As String = "Data Source=" & _servidor & "; Initial Catalog=Cedula ; Integrated Security=true;"
        Dim Planilla As String = "Data Source=" & _servidor & "; Initial Catalog=Planilla ; Integrated Security=true;"

        Dim db As New OBSoluciones.SQL.Sentencias(Seguridad)
        If db.ProbarConexion(Seguridad) = True Then
            SaveSetting("SeeSoft", "Seguridad", "Conexion", Seguridad)
            SaveSetting("SeeSoft", "SeePOS", "Conexion", Seepos)
            SaveSetting("SeeSoft", "SeePOS", "datos_cedulas", Cedula)
            SaveSetting("SeeSoft", "Bancos", "Conexion", Bancos)
            SaveSetting("SeeSoft", "Contabilidad", "Conexion", Contabilidad)
            SaveSetting("SeeSoft", "Planilla", "Conexion", Planilla)
            SaveSetting("SeeSoft", "Planilla", "Conexion", Planilla)
            SaveSetting("Hotel", "Hotel", "CONEXION", Seepos)
            SaveSetting("SeeSoft", "Hotel", "CONEXION", Seepos)
            SaveSetting("SeeSoft", "Proveeduria", "Conexion", Seepos)
            SaveSetting("SeeSoft", "Restaurante", "Conexion", Seepos)
            Me.DialogResult = Windows.Forms.DialogResult.OK
        End If

    End Sub

    Private Sub frmCambiarConexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cboBasedeDatos.SelectedIndex = 0
    End Sub

    Private Sub DetectarServidores()
        txtServidor.Items.Clear()
        Dim servidores As SqlDataSourceEnumerator
        'Obtenemos el enumerador SQL
        Dim tablaServidores As DataTable
        'Dimenesionamos la tabla que guardara los datos
        servidores = SqlDataSourceEnumerator.Instance
        'Obtenemos las instancias sql
        tablaServidores = New DataTable()
        tablaServidores = servidores.GetDataSources()
        'Copiamos las instancias al datatable
        Dim rowServidor As DataRow
        'Dimensionamos una fila para recorrer el datatable
        For Each rowServidor In tablaServidores.Rows
            If String.IsNullOrEmpty(rowServidor("InstanceName").ToString()) Then
                'El siguiente codigo añade las instancias
                txtServidor.Items.Add(rowServidor("ServerName").ToString())
            Else
                txtServidor.Items.Add(rowServidor("ServerName") & "\\" & rowServidor("InstanceName"))
            End If
        Next

        If Me.txtServidor.Items.Count > 0 Then
            Me.txtServidor.SelectedIndex = 0
        Else
            MsgBox("No se encontraron resultados.", MsgBoxStyle.Exclamation, Me.Text)
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Me.DetectarServidores()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.CambiarConexion(Me.txtServidor.Text, Me.cboBasedeDatos.Text)
    End Sub
End Class