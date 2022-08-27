Imports System.Drawing


Public Class Cheque
    Public Property Num_Cheque As String
    Public Property Portador As String
    Public Property Monto As Decimal
    Public Property MontoLetras As String
    Public Property Fecha As Date
    Public Property NombreUsuario As String
    Public Property Observaciones As String

    Sub New()
    End Sub

    Sub New(numCheque As String, portador As String, monto As Decimal, fecha As Date, nombreUsuario As String, observaciones As String)
        Me.Num_Cheque = numCheque
        Me.Portador = portador
        Me.Monto = monto
        Me.MontoLetras = Letras(monto).ToUpper
        Me.Fecha = fecha
        Me.NombreUsuario = nombreUsuario
        Me.Observaciones = observaciones
    End Sub

    Private Function Letras(ByVal numero As String) As String
        '********Declara variables de tipo cadena************
        Dim palabras, entero, dec, flag As String

        '********Declara variables de tipo entero***********
        Dim num, x, y As Integer

        flag = "N"

        '**********Número Negativo***********
        If Mid(numero, 1, 1) = "-" Then
            numero = Mid(numero, 2, numero.ToString.Length - 1).ToString
            palabras = "menos "
        End If

        '**********Si tiene ceros a la izquierda*************
        For x = 1 To numero.ToString.Length
            If Mid(numero, 1, 1) = "0" Then
                numero = Trim(Mid(numero, 2, numero.ToString.Length).ToString)
                If Trim(numero.ToString.Length) = 0 Then palabras = ""
            Else
                Exit For
            End If
        Next

        '*********Dividir parte entera y decimal************
        For y = 1 To Len(numero)
            If Mid(numero, y, 1) = "." Then
                flag = "S"
            Else
                If flag = "N" Then
                    entero = entero + Mid(numero, y, 1)
                Else
                    dec = dec + Mid(numero, y, 1)
                End If
            End If
        Next y

        If Len(dec) = 1 Then dec = dec & "0"

        '**********proceso de conversión***********
        flag = "N"

        If Val(numero) <= 999999999 Then
            For y = Len(entero) To 1 Step -1
                num = Len(entero) - (y - 1)
                Select Case y
                    Case 3, 6, 9
                        '**********Asigna las palabras para las centenas***********
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" And Mid(entero, num + 2, 1) = "0" Then
                                    palabras = palabras & "cien "
                                Else
                                    palabras = palabras & "ciento "
                                End If
                            Case "2"
                                palabras = palabras & "doscientos "
                            Case "3"
                                palabras = palabras & "trescientos "
                            Case "4"
                                palabras = palabras & "cuatrocientos "
                            Case "5"
                                palabras = palabras & "quinientos "
                            Case "6"
                                palabras = palabras & "seiscientos "
                            Case "7"
                                palabras = palabras & "setecientos "
                            Case "8"
                                palabras = palabras & "ochocientos "
                            Case "9"
                                palabras = palabras & "novecientos "
                        End Select
                    Case 2, 5, 8
                        '*********Asigna las palabras para las decenas************
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    flag = "S"
                                    palabras = palabras & "diez "
                                End If
                                If Mid(entero, num + 1, 1) = "1" Then
                                    flag = "S"
                                    palabras = palabras & "once "
                                End If
                                If Mid(entero, num + 1, 1) = "2" Then
                                    flag = "S"
                                    palabras = palabras & "doce "
                                End If
                                If Mid(entero, num + 1, 1) = "3" Then
                                    flag = "S"
                                    palabras = palabras & "trece "
                                End If
                                If Mid(entero, num + 1, 1) = "4" Then
                                    flag = "S"
                                    palabras = palabras & "catorce "
                                End If
                                If Mid(entero, num + 1, 1) = "5" Then
                                    flag = "S"
                                    palabras = palabras & "quince "
                                End If
                                If Mid(entero, num + 1, 1) > "5" Then
                                    flag = "N"
                                    palabras = palabras & "dieci"
                                End If
                            Case "2"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "veinte "
                                    flag = "S"
                                Else
                                    palabras = palabras & "veinti"
                                    flag = "N"
                                End If
                            Case "3"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "treinta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "treinta y "
                                    flag = "N"
                                End If
                            Case "4"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "cuarenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "cuarenta y "
                                    flag = "N"
                                End If
                            Case "5"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "cincuenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "cincuenta y "
                                    flag = "N"
                                End If
                            Case "6"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "sesenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "sesenta y "
                                    flag = "N"
                                End If
                            Case "7"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "setenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "setenta y "
                                    flag = "N"
                                End If
                            Case "8"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "ochenta "
                                    flag = "S"
                                Else
                                    palabras = palabras & "ochenta y "
                                    flag = "N"
                                End If
                            Case "9"
                                If Mid(entero, num + 1, 1) = "0" Then
                                    palabras = palabras & "noventa "
                                    flag = "S"
                                Else
                                    palabras = palabras & "noventa y "
                                    flag = "N"
                                End If
                        End Select
                    Case 1, 4, 7
                        '*********Asigna las palabras para las unidades*********
                        Select Case Mid(entero, num, 1)
                            Case "1"
                                If flag = "N" Then
                                    If y = 1 Then
                                        palabras = palabras & "uno "
                                    Else
                                        palabras = palabras & "un "
                                    End If
                                End If
                            Case "2"
                                If flag = "N" Then palabras = palabras & "dos "
                            Case "3"
                                If flag = "N" Then palabras = palabras & "tres "
                            Case "4"
                                If flag = "N" Then palabras = palabras & "cuatro "
                            Case "5"
                                If flag = "N" Then palabras = palabras & "cinco "
                            Case "6"
                                If flag = "N" Then palabras = palabras & "seis "
                            Case "7"
                                If flag = "N" Then palabras = palabras & "siete "
                            Case "8"
                                If flag = "N" Then palabras = palabras & "ocho "
                            Case "9"
                                If flag = "N" Then palabras = palabras & "nueve "
                        End Select
                End Select

                '***********Asigna la palabra mil***************
                If y = 4 Then
                    If Mid(entero, 6, 1) <> "0" Or Mid(entero, 5, 1) <> "0" Or Mid(entero, 4, 1) <> "0" Or _
                    (Mid(entero, 6, 1) = "0" And Mid(entero, 5, 1) = "0" And Mid(entero, 4, 1) = "0" And _
                    Len(entero) <= 6) Then palabras = palabras & "mil "
                End If

                '**********Asigna la palabra millón*************
                If y = 7 Then
                    If Len(entero) = 7 And Mid(entero, 1, 1) = "1" Then
                        palabras = palabras & "millón "
                    Else
                        palabras = palabras & "millones "
                    End If
                End If
            Next y

            '**********Une la parte entera y la parte decimal*************
            If dec <> "" Then
                Letras = palabras & "con " & dec
            Else
                Letras = palabras
            End If
        Else
            Letras = ""
        End If
    End Function

End Class

Public Class imprimirCheque
    Private Cheque As New Cheque

    Public Sub Imprimir(cheque As Cheque, NombreImpresora As String)
        Me.Cheque = cheque
        Dim pd As New System.Drawing.Printing.PrintDocument
        pd.PrinterSettings.PrinterName = NombreImpresora
        AddHandler pd.PrintPage, AddressOf pd_PrintPage
        pd.Print()
    End Sub

    Private Sub pd_PrintPage(ByVal sender As Object, ByVal ev As System.Drawing.Printing.PrintPageEventArgs)

        Dim Num_Cheque As RectangleF
        Dim Portador As RectangleF
        Dim Monto As RectangleF
        Dim MontoLetras As RectangleF
        Dim Fecha As RectangleF
        Dim NombreUsuario As RectangleF
        Dim Observaciones As RectangleF

        Dim Centrar As New StringFormat
        Centrar.Alignment = StringAlignment.Near

        'Imprimie el cheque 
        Num_Cheque = New RectangleF(450, 15, 75, 20)
        Fecha = New RectangleF(330, 35, 120, 20)
        Portador = New RectangleF(65, 70, 250, 20)
        Monto = New RectangleF(450, 65, 105, 20)
        MontoLetras = New RectangleF(65, 87, 550, 40)

        ev.Graphics.DrawString(Me.Cheque.Num_Cheque, New System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, Num_Cheque, Centrar)
        ev.Graphics.DrawString(Me.Cheque.Portador, New System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, Portador, Centrar)
        ev.Graphics.DrawString(Me.Cheque.Monto, New System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, Monto, Centrar)
        ev.Graphics.DrawString(Me.Cheque.MontoLetras, New System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, MontoLetras, Centrar)
        ev.Graphics.DrawString(Me.Cheque.Fecha, New System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, Fecha, Centrar)

        'Imprime la copia del cheque
        Dim Siguiente As Decimal = 250
        Num_Cheque = New RectangleF(450, 15 + Siguiente, 75, 20)
        Fecha = New RectangleF(330, 35 + Siguiente, 120, 20)
        Portador = New RectangleF(65, 70 + Siguiente, 250, 20)
        Monto = New RectangleF(450, 65 + Siguiente, 105, 20)
        MontoLetras = New RectangleF(65, 83 + Siguiente, 550, 40)
        Observaciones = New RectangleF(15, 159 + Siguiente, 400, 20)

        ev.Graphics.DrawString(Me.Cheque.Num_Cheque, New System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, Num_Cheque, Centrar)
        ev.Graphics.DrawString(Me.Cheque.Portador, New System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, Portador, Centrar)
        ev.Graphics.DrawString(Me.Cheque.Monto, New System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, Monto, Centrar)
        ev.Graphics.DrawString(Me.Cheque.MontoLetras, New System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, MontoLetras, Centrar)
        ev.Graphics.DrawString(Me.Cheque.Fecha, New System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, Fecha, Centrar)
        ev.Graphics.DrawString(Me.Cheque.Observaciones, New System.Drawing.Font("Arial", 10, FontStyle.Bold), Brushes.Black, Observaciones, Centrar)
        Exit Sub

        'Imprime la copia del cheque        
        Siguiente = 500
        Num_Cheque = New RectangleF(450, 15 + Siguiente, 75, 20)
        Fecha = New RectangleF(330, 35 + Siguiente, 120, 20)
        Portador = New RectangleF(65, 70 + Siguiente, 250, 20)
        Monto = New RectangleF(450, 65 + Siguiente, 105, 20)
        MontoLetras = New RectangleF(65, 83 + Siguiente, 550, 40)
        Observaciones = New RectangleF(15, 159 + Siguiente, 400, 20)

        ev.Graphics.DrawString(Me.Cheque.Num_Cheque, New System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, Num_Cheque, Centrar)
        ev.Graphics.DrawString(Me.Cheque.Portador, New System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, Num_Cheque, Centrar)
        ev.Graphics.DrawString(Me.Cheque.Monto, New System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, Num_Cheque, Centrar)
        ev.Graphics.DrawString(Me.Cheque.MontoLetras, New System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, Num_Cheque, Centrar)
        ev.Graphics.DrawString(Me.Cheque.Fecha, New System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, Num_Cheque, Centrar)
        ev.Graphics.DrawString(Me.Cheque.Observaciones, New System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, Num_Cheque, Centrar)

        'Imprimie el pie del documento
        NombreUsuario = New RectangleF(480, 85, 75, 20)
        ev.Graphics.DrawString(Me.Cheque.NombreUsuario, New System.Drawing.Font("Arial", 12, FontStyle.Bold), Brushes.Black, Num_Cheque, Centrar)

    End Sub


End Class
