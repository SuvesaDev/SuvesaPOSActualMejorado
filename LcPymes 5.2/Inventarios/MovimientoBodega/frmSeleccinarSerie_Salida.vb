Imports System.Data
Public Class frmSeleccinarSerie_Salida

    Public Property Cantidad As Decimal = 0
    Public WriteOnly Property Codigo As String
        Set(value As String)
            Dim dt As New DataTable
            Dim cod As String = value
            cFunciones.Llenar_Tabla_Generico("select s.serie from Serie s inner join Inventario i on s.codigo = i.codigo and s.vendido = 0 where i.codigo = " & cod, dt, CadenaConexionSeePOS)
            If dt.Rows.Count > 0 Then
                Dim index As Integer = 0
                For Each r As DataRow In dt.Rows
                    Me.viewDatos.Rows.Add()
                    Me.viewDatos.Item("cSeleccionar", index).Value = False
                    Me.viewDatos.Item("cSerie", index).Value = r.Item("Serie")
                    index += 1
                Next
            End If
        End Set
    End Property

    Private Function CantidadMarcada() As Integer
        Dim resultado As Integer = 0

        resultado = (From x As DataGridViewRow In Me.viewDatos.Rows Where x.Cells("cSeleccionar").Value = True Select x).Count()
        Return resultado
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Marcada As Decimal = Me.CantidadMarcada

        If Marcada < Me.Cantidad Then
            MsgBox("Faltan series por marcar.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        If Marcada > Me.Cantidad Then
            MsgBox("Selecciono mas sereries de lo que es.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

End Class