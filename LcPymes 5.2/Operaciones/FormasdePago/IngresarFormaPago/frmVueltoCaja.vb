﻿Public Class frmVueltoCaja

    Public Vuelto As Decimal

    Public Pendiente As Decimal = 0
    Public Pagocon As Decimal = 0


    Private Sub frmVueltoCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.lblVuelto.Text = Me.lblVuelto.Text.Replace("?", Me.Vuelto.ToString("N2"))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim Detalle As String = "Total Cobrar:      " & Pendiente.ToString("N2") & vbCrLf _
                              & "Total Pagado:      " & Pagocon.ToString("N2") & vbCrLf _
                              & "Total Vuelto:      " & Vuelto.ToString("N2")
        MsgBox(Detalle, MsgBoxStyle.Information, Me.Text)
    End Sub

End Class