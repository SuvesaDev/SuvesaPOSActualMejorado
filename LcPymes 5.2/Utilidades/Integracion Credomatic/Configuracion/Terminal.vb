Imports System.Data

Namespace Credomatic
    Namespace Configuracion
        Public Class Terminal

            Private dts As New DataSet
            Private Ubicacion As String = My.Application.Info.DirectoryPath & "\"
            Private Archivo As String = Me.Ubicacion & "configuraciones.xml"

            Public Property Terminal As String
                Get
                    Return Me.GetTerminal
                End Get
                Set(ByVal value As String)
                    Me.SetTerminal(value)
                End Set
            End Property

            Public Property Impresora As String
                Get
                    Return Me.GetImpresora
                End Get
                Set(ByVal value As String)
                    Me.SetImpresora(value)
                End Set
            End Property

            Public Property Datafono As Boolean
                Get
                    Return Me.GetDatafono
                End Get
                Set(ByVal value As Boolean)
                    Me.SetDatafono(value)
                End Set
            End Property

            Private Sub RefrescarDatos()
                For Each Tabla As DataTable In Me.dts.Tables
                    Tabla.Clear()
                Next
                Me.dts.ReadXml(Me.Archivo)
            End Sub

            Private Function GetImpresora() As String
                Try
                    Me.dts.ReadXml(Me.Archivo)
                    Return Me.dts.Tables("Impresora").Rows(0).Item("Impresora")
                Catch ex As Exception
                    Return ""
                End Try
            End Function

            Private Function GetTerminal() As String
                Try
                    Me.dts.ReadXml(Me.Archivo)
                    Return Me.dts.Tables(0).Rows(0).Item("Terminal")
                Catch ex As Exception
                    Return ""
                End Try
            End Function

            Private Function GetDatafono() As Boolean
                Try
                    Me.dts.ReadXml(Me.Archivo)
                    Return Me.dts.Tables("Datafono").Rows(0).Item("Datafono")
                Catch ex As Exception
                    Return False
                End Try
            End Function

            Private Sub SetTerminal(_Terminal As String)
                Try
                    If System.IO.File.Exists(Me.Archivo) = False Then
                        Me.dts.DataSetName = "Configuraciones"
                        Dim dt As New DataTable
                        dt.Columns.Add("Terminal")
                        dt.Rows.Add(_Terminal)
                        Me.dts.Tables.Add(dt)
                        Me.dts.Tables(0).TableName = "Terminal"
                    Else
                        Me.RefrescarDatos()
                        Me.dts.Tables(0).Rows(0).Item("Terminal") = _Terminal
                    End If
                    Me.dts.WriteXml(Me.Ubicacion & "configuraciones.xml", XmlWriteMode.WriteSchema)
                Catch ex As Exception
                End Try
            End Sub

            Private Sub SetImpresora(_Impresora As String)
                Try
                    If Me.dts.Tables.Count = 1 Then
                        Me.dts.DataSetName = "Configuraciones"
                        Dim dt As New DataTable
                        dt.Columns.Add("Impresora")
                        dt.Rows.Add(_Impresora)
                        Me.dts.Tables.Add(dt)
                        Me.dts.Tables(1).TableName = "Impresora"
                    Else
                        Me.RefrescarDatos()
                        Me.dts.Tables("Impresora").Rows(0).Item("Impresora") = _Impresora
                    End If
                    Me.dts.WriteXml(Me.Ubicacion & "configuraciones.xml", XmlWriteMode.WriteSchema)
                Catch ex As Exception
                End Try
            End Sub

            Private Sub SetDatafono(_Datafono As Boolean)
                Try
                    If Me.dts.Tables.Count = 2 Then
                        Me.dts.DataSetName = "Configuraciones"
                        Dim dt As New DataTable
                        dt.Columns.Add("Datafono")
                        dt.Rows.Add(_Datafono)
                        Me.dts.Tables.Add(dt)
                        Me.dts.Tables(2).TableName = "Datafono"
                    Else
                        Me.RefrescarDatos()
                        Me.dts.Tables("Datafono").Rows(0).Item("Datafono") = _Datafono
                    End If
                    Me.dts.WriteXml(Me.Ubicacion & "configuraciones.xml", XmlWriteMode.WriteSchema)
                Catch ex As Exception
                End Try
            End Sub

        End Class
    End Namespace
End Namespace

