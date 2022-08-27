Imports System.Data

Public Class frmIngresarNumerodeFicha
    Public IdUsuario As String = "0"

    Private Function GetFicha() As String
        Dim dt As New DataTable
        Dim Fichas As New Collections.Generic.List(Of Integer)
        Dim Desde As Integer = 0
        Dim Hasta As Integer = 0
        cFunciones.Llenar_Tabla_Generico("select * from fichasxusuario where idusuario = " & Me.IdUsuario, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            Me.txtNumero.Text = ""
            Desde = dt.Rows(0).Item("Desde")
            Hasta = dt.Rows(0).Item("Hasta")
            For i As Integer = Desde To Hasta
                Fichas.Add(i)
            Next

            For Each f As Integer In Fichas
                If EstaLibre(f) = True Then
                    Me.txtNumero.Text = f
                    Exit For
                End If
            Next

            If Me.txtNumero.Text = "" Then
                MsgBox("No se encontraron fichas validas.", MsgBoxStyle.Exclamation, "Favor consultar con el encargado.")
            End If

        End If
    End Function

    Private Function EstaLibre(_Ficha As String)
        Dim dt As New DataTable
        Dim IdUsuario As String = Me.IdUsuario
        Dim Ficha As String = _Ficha
        cFunciones.Llenar_Tabla_Generico("select COUNT(*) FichaValida from fichasxusuario where idusuario = " & IdUsuario & " and " & Ficha & " between desde and hasta and " & Ficha & " not in(select Ficha from viewPreventasActivas)", dt, CadenaConexionSeePOS)
        If dt.Rows(0).Item("FichaValida") = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Private Function FichaEsValida() As Boolean
        If Me.EstaLibre(Me.txtNumero.Text) = False Then
            MsgBox("La ficha no es valida" & vbCrLf _
                                   & "Ingrese otra porfavor.", MsgBoxStyle.Exclamation, Me.Text)
            Return False
        Else
            Return True
        End If
    End Function

    Private Function PasaValidacionFicha() As Boolean
        Dim num As String = Me.txtNumero.Text
        Dim dt As New DataTable
        cFunciones.Llenar_Tabla_Generico("Select * From viewpreventasactivas Where Ficha = " & num, dt, CadenaConexionSeePOS)
        If dt.Rows.Count > 0 Then
            MsgBox("El numero de ficha esta activa, favor cambie el numero.", MsgBoxStyle.Exclamation, "No se puede procesar la operacion.")
            Return False
        End If
        Return True
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If Me.txtNumero.Text <> "" And IsNumeric(Me.txtNumero.Text) Then
            If CDec(Me.txtNumero.Text) > 0 Then
                If Me.PasaValidacionFicha = False Then Exit Sub
                If Me.FichaEsValida = False Then Exit Sub
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub frmIngresarNumerodeFicha_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetFicha()
    End Sub

End Class