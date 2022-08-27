Public Class frmValidarRegistroMAG

    Public Property Identificacion As String

    Private Sub CargarDatosMAG()
        Me.txtEstado.Text = "NO"
        Dim Datos As api.Hacienda.MAG = api.Hacienda.EstaRegistradoMAG(Me.Identificacion)
        Me.ckVenta1.Checked = False

        Try
            Me.txtNombre.Text = Datos.situacionTributaria.nombre

            Me.ckMAG.Checked = Datos.listaDatosMAG(0).indicadorActivoMAG
            Me.ckVenta1.Checked = Me.ckMAG.Checked
            Me.txtEstado.Text = Datos.listaDatosMAG(0).estadoMAG
            Me.txtFechaBaja.Text = Datos.listaDatosMAG(0).fechaBajaMAG
        Catch ex As Exception
        End Try
        
        Try
            Me.viewDatos.DataSource = Datos.situacionTributaria.actividades
            Me.viewDatos.Columns("CODIGO").Visible = False

            Dim Distribuidor As Integer = (From x As api.Hacienda.Actividade In Datos.situacionTributaria.actividades Where x.codigo = "523912" Select x).Count()
            If Distribuidor > 0 Then
                Me.ckVenta1.Checked = True
            End If
        Catch ex As Exception
        End Try
        
    End Sub

    Private Sub frmValidarRegistroMAG_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CargarDatosMAG()
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

End Class