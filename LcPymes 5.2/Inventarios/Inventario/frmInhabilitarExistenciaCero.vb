Public Class frmInhabilitarExistenciaCero

    Private Sub btnInhabilitarCero_Click(sender As Object, e As EventArgs) Handles btnInhabilitarCero.Click
        Dim db As New OBSoluciones.SQL.Sentencias(CadenaConexionSeePOS)
        db.Ejecutar("Update dbo.Inventario set Inhabilitado = 1 where inhabilitado = 0 and existencia = 0 and Consignacion = 0", Data.CommandType.Text)

        If CadenaConexionSeePOS.IndexOf("192.168.0.2") > 0 Then
            db.Ejecutar("Update seepos.dbo.Inventario set Inhabilitado = 1 where inhabilitado = 0 and existencia = 0 and Consignacion = 0", Data.CommandType.Text)
            db.Ejecutar("Update Mascotas.dbo.Inventario set Inhabilitado = 1 where inhabilitado = 0 and existencia = 0 and Consignacion = 0", Data.CommandType.Text)
            db.Ejecutar("Update Taller.dbo.Inventario set Inhabilitado = 1 where inhabilitado = 0 and existencia = 0 and Consignacion = 0", Data.CommandType.Text)
        End If
        Me.Close()
    End Sub
End Class