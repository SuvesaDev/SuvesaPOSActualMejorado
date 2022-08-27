Imports System.Windows.Forms
Imports System.Data

Public Class frmUnirCodigosPuntoVenta

    Private Sub frmUnirCodigosPuntoVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cargar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim frm As New frmAgregarUnificar
        If frm.ShowDialog = Windows.Forms.DialogResult.OK Then

            Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
            Dim sql As String = ""
            sql = "Insert into codigos(IdPuntoVenta1,Codigo1,Cod_Alterno1,Descripcion1,IdPuntoVenta2,Codigo2,Cod_Alterno2,Descripcion2) Values(" & frm.cboPuntoVenta1.SelectedValue & ", " & frm.Codigo1 & ",'" & frm.txtCodigo1.Text & "', '" & frm.txtDescripcion1.Text & "'," & frm.cboPuntoVenta2.SelectedValue & ", " & frm.Codigo2 & ",'" & frm.txtCodigo2.Text & "', '" & frm.txtDescripcion2.Text & "')"
            db.Ejecutar(sql, CommandType.Text)

            Me.Cargar()
        End If
    End Sub

    Private Function getPuntoVenta(_id As Integer) As String
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("select IdPuntoVenta, PuntoVenta from " & TablaSeguridad() & ".dbo.PuntodeVenta where IdPuntoVenta = " & _id, dt, GetSetting("SeeSOFT", "SeePOS", "Seguridad"))
        Return dt.Rows(0).Item("PuntoVenta")
    End Function

    Private Sub Cargar()
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * from Codigos", dt, CadenaConexionSeePOS)
        Dim Index As Integer = 0
        Me.ViewDatos.Rows.Clear()
        For Each r As DataRow In dt.Rows
            Me.ViewDatos.Rows.Add()
            Me.ViewDatos.Item("cId", Index).Value = r.Item("Id")
            Me.ViewDatos.Item("cPuntoVenta1", Index).Value = getPuntoVenta(Convert.ToInt32(r.Item("IdPuntoVenta1")))
            Me.ViewDatos.Item("cCodigo1", Index).Value = r.Item("Codigo1")
            Me.ViewDatos.Item("cCodAlterno1", Index).Value = r.Item("Cod_Alterno1")
            Me.ViewDatos.Item("cDescripcion1", Index).Value = r.Item("Descripcion1")
            Me.ViewDatos.Item("cPuntoVenta2", Index).Value = getPuntoVenta(Convert.ToInt32(r.Item("IdPuntoVenta2")))
            Me.ViewDatos.Item("cCodigo2", Index).Value = r.Item("Codigo2")
            Me.ViewDatos.Item("cCodAlterno2", Index).Value = r.Item("Cod_Alterno2")
            Me.ViewDatos.Item("cDescripcion2", Index).Value = r.Item("Descripcion2")
            Index += 1
        Next
    End Sub



End Class
