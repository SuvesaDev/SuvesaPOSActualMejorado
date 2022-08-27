Imports System.Data.SqlClient

Public Class FrmReportesCajas
    Inherits System.Windows.Forms.Form

#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
    Friend WithEvents SqlSelectCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents lblTipoCambio As System.Windows.Forms.Label
    Friend WithEvents VisorReporte As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents SqlSelectCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand2 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand1 As System.Data.SqlClient.SqlCommand
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboMonedas As System.Windows.Forms.ComboBox
    Friend WithEvents FechaFinal As System.Windows.Forms.DateTimePicker
    Friend WithEvents FechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents ButtonMostrar As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SqlSelectCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlInsertCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand3 As System.Data.SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As System.Data.SqlClient.SqlConnection
    Friend WithEvents daMonedas As System.Data.SqlClient.SqlDataAdapter
    Friend WithEvents DsReciboAbonos As dsReciboAbonos
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbxOpciones As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand2 = New System.Data.SqlClient.SqlCommand
        Me.lblTipoCambio = New System.Windows.Forms.Label
        Me.DsReciboAbonos = New DsReciboAbonos
        Me.VisorReporte = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.SqlSelectCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand2 = New System.Data.SqlClient.SqlCommand
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cbxOpciones = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.cboMonedas = New System.Windows.Forms.ComboBox
        Me.FechaFinal = New System.Windows.Forms.DateTimePicker
        Me.FechaInicio = New System.Windows.Forms.DateTimePicker
        Me.ButtonMostrar = New DevExpress.XtraEditors.SimpleButton
        Me.SqlSelectCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection
        Me.SqlInsertCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlUpdateCommand3 = New System.Data.SqlClient.SqlCommand
        Me.SqlDeleteCommand3 = New System.Data.SqlClient.SqlCommand
        Me.daMonedas = New System.Data.SqlClient.SqlDataAdapter
        CType(Me.DsReciboAbonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT identificacion, cedula, nombre, observaciones, Telefono_01, telefono_02, f" & _
        "ax_01, fax_02, e_mail, abierto, direccion, impuesto, max_credito, Plazo_credito," & _
        " descuento, empresa, tipoprecio, sinrestriccion, usuario, nombreusuario, agente," & _
        " CodMonedaCredito FROM Clientes"
        '
        'SqlDeleteCommand2
        '
        Me.SqlDeleteCommand2.CommandText = "DELETE FROM Moneda WHERE (CodMoneda = @Original_CodMoneda) AND (MonedaNombre = @O" & _
        "riginal_MonedaNombre) AND (Simbolo = @Original_Simbolo) AND (ValorCompra = @Orig" & _
        "inal_ValorCompra) AND (ValorVenta = @Original_ValorVenta)"
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing))
        '
        'lblTipoCambio
        '
        Me.lblTipoCambio.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DsReciboAbonos, "Moneda.ValorCompra"))
        Me.lblTipoCambio.Location = New System.Drawing.Point(496, 176)
        Me.lblTipoCambio.Name = "lblTipoCambio"
        Me.lblTipoCambio.TabIndex = 80
        '
        'DsReciboAbonos
        '
        Me.DsReciboAbonos.DataSetName = "dsReciboAbonos"
        Me.DsReciboAbonos.Locale = New System.Globalization.CultureInfo("es-CR")
        '
        'VisorReporte
        '
        Me.VisorReporte.ActiveViewIndex = -1
        Me.VisorReporte.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.VisorReporte.AutoScroll = True
        Me.VisorReporte.DisplayGroupTree = False
        Me.VisorReporte.Location = New System.Drawing.Point(224, 0)
        Me.VisorReporte.Name = "VisorReporte"
        Me.VisorReporte.ReportSource = Nothing
        Me.VisorReporte.ShowCloseButton = False
        Me.VisorReporte.Size = New System.Drawing.Size(468, 468)
        Me.VisorReporte.TabIndex = 82
        '
        'SqlSelectCommand2
        '
        Me.SqlSelectCommand2.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        '
        'SqlInsertCommand2
        '
        Me.SqlInsertCommand2.CommandText = "INSERT INTO Moneda(CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo) VAL" & _
        "UES (@CodMoneda, @MonedaNombre, @ValorCompra, @ValorVenta, @Simbolo); SELECT Cod" & _
        "Moneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda WHERE (CodMon" & _
        "eda = @CodMoneda)"
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlInsertCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"))
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = "DELETE FROM Clientes WHERE (identificacion = @Original_identificacion) AND (CodMo" & _
        "nedaCredito = @Original_CodMonedaCredito) AND (Plazo_credito = @Original_Plazo_c" & _
        "redito) AND (Telefono_01 = @Original_Telefono_01) AND (abierto = @Original_abier" & _
        "to) AND (agente = @Original_agente) AND (cedula = @Original_cedula) AND (descuen" & _
        "to = @Original_descuento) AND (direccion = @Original_direccion) AND (e_mail = @O" & _
        "riginal_e_mail) AND (empresa = @Original_empresa) AND (fax_01 = @Original_fax_01" & _
        ") AND (fax_02 = @Original_fax_02) AND (impuesto = @Original_impuesto) AND (max_c" & _
        "redito = @Original_max_credito) AND (nombre = @Original_nombre) AND (nombreusuar" & _
        "io = @Original_nombreusuario) AND (observaciones = @Original_observaciones) AND " & _
        "(sinrestriccion = @Original_sinrestriccion) AND (telefono_02 = @Original_telefon" & _
        "o_02) AND (tipoprecio = @Original_tipoprecio) AND (usuario = @Original_usuario)"
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_identificacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMonedaCredito", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMonedaCredito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Plazo_credito", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Plazo_credito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Telefono_01", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono_01", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_abierto", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "abierto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_agente", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agente", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_e_mail", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "e_mail", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_empresa", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "empresa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fax_01", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fax_01", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fax_02", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fax_02", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "impuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_max_credito", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "max_credito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombreusuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombreusuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_sinrestriccion", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sinrestriccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_telefono_02", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono_02", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tipoprecio", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipoprecio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "usuario", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = "UPDATE Clientes SET identificacion = @identificacion, cedula = @cedula, nombre = " & _
        "@nombre, observaciones = @observaciones, Telefono_01 = @Telefono_01, telefono_02" & _
        " = @telefono_02, fax_01 = @fax_01, fax_02 = @fax_02, e_mail = @e_mail, abierto =" & _
        " @abierto, direccion = @direccion, impuesto = @impuesto, max_credito = @max_cred" & _
        "ito, Plazo_credito = @Plazo_credito, descuento = @descuento, empresa = @empresa," & _
        " tipoprecio = @tipoprecio, sinrestriccion = @sinrestriccion, usuario = @usuario," & _
        " nombreusuario = @nombreusuario, agente = @agente, CodMonedaCredito = @CodMoneda" & _
        "Credito WHERE (identificacion = @Original_identificacion) AND (CodMonedaCredito " & _
        "= @Original_CodMonedaCredito) AND (Plazo_credito = @Original_Plazo_credito) AND " & _
        "(Telefono_01 = @Original_Telefono_01) AND (abierto = @Original_abierto) AND (age" & _
        "nte = @Original_agente) AND (cedula = @Original_cedula) AND (descuento = @Origin" & _
        "al_descuento) AND (direccion = @Original_direccion) AND (e_mail = @Original_e_ma" & _
        "il) AND (empresa = @Original_empresa) AND (fax_01 = @Original_fax_01) AND (fax_0" & _
        "2 = @Original_fax_02) AND (impuesto = @Original_impuesto) AND (max_credito = @Or" & _
        "iginal_max_credito) AND (nombre = @Original_nombre) AND (nombreusuario = @Origin" & _
        "al_nombreusuario) AND (observaciones = @Original_observaciones) AND (sinrestricc" & _
        "ion = @Original_sinrestriccion) AND (telefono_02 = @Original_telefono_02) AND (t" & _
        "ipoprecio = @Original_tipoprecio) AND (usuario = @Original_usuario); SELECT iden" & _
        "tificacion, cedula, nombre, observaciones, Telefono_01, telefono_02, fax_01, fax" & _
        "_02, e_mail, abierto, direccion, impuesto, max_credito, Plazo_credito, descuento" & _
        ", empresa, tipoprecio, sinrestriccion, usuario, nombreusuario, agente, CodMoneda" & _
        "Credito FROM Clientes WHERE (identificacion = @identificacion)"
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@identificacion", System.Data.SqlDbType.Int, 4, "identificacion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 30, "cedula"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 255, "nombre"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 255, "observaciones"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Telefono_01", System.Data.SqlDbType.VarChar, 8, "Telefono_01"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@telefono_02", System.Data.SqlDbType.VarChar, 8, "telefono_02"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fax_01", System.Data.SqlDbType.VarChar, 8, "fax_01"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fax_02", System.Data.SqlDbType.VarChar, 8, "fax_02"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@e_mail", System.Data.SqlDbType.VarChar, 255, "e_mail"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@abierto", System.Data.SqlDbType.VarChar, 2, "abierto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 255, "direccion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@impuesto", System.Data.SqlDbType.Float, 8, "impuesto"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@max_credito", System.Data.SqlDbType.Float, 8, "max_credito"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Plazo_credito", System.Data.SqlDbType.Int, 4, "Plazo_credito"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descuento", System.Data.SqlDbType.Float, 8, "descuento"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@empresa", System.Data.SqlDbType.VarChar, 2, "empresa"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tipoprecio", System.Data.SqlDbType.SmallInt, 2, "tipoprecio"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@sinrestriccion", System.Data.SqlDbType.VarChar, 2, "sinrestriccion"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.VarChar, 50, "usuario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombreusuario", System.Data.SqlDbType.VarChar, 50, "nombreusuario"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@agente", System.Data.SqlDbType.VarChar, 50, "agente"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMonedaCredito", System.Data.SqlDbType.Int, 4, "CodMonedaCredito"))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_identificacion", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "identificacion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMonedaCredito", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMonedaCredito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Plazo_credito", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Plazo_credito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Telefono_01", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Telefono_01", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_abierto", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "abierto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_agente", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "agente", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_cedula", System.Data.SqlDbType.VarChar, 30, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "cedula", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_descuento", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "descuento", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_direccion", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "direccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_e_mail", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "e_mail", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_empresa", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "empresa", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fax_01", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fax_01", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_fax_02", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "fax_02", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_impuesto", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "impuesto", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_max_credito", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "max_credito", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombre", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_nombreusuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "nombreusuario", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_observaciones", System.Data.SqlDbType.VarChar, 255, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "observaciones", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_sinrestriccion", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "sinrestriccion", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_telefono_02", System.Data.SqlDbType.VarChar, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "telefono_02", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_tipoprecio", System.Data.SqlDbType.SmallInt, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "tipoprecio", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_usuario", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "usuario", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlUpdateCommand2
        '
        Me.SqlUpdateCommand2.CommandText = "UPDATE Moneda SET CodMoneda = @CodMoneda, MonedaNombre = @MonedaNombre, ValorComp" & _
        "ra = @ValorCompra, ValorVenta = @ValorVenta, Simbolo = @Simbolo WHERE (CodMoneda" & _
        " = @Original_CodMoneda) AND (MonedaNombre = @Original_MonedaNombre) AND (Simbolo" & _
        " = @Original_Simbolo) AND (ValorCompra = @Original_ValorCompra) AND (ValorVenta " & _
        "= @Original_ValorVenta); SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta" & _
        ", Simbolo FROM Moneda WHERE (CodMoneda = @CodMoneda)"
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand2.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO Clientes(identificacion, cedula, nombre, observaciones, Telefono_01, " & _
        "telefono_02, fax_01, fax_02, e_mail, abierto, direccion, impuesto, max_credito, " & _
        "Plazo_credito, descuento, empresa, tipoprecio, sinrestriccion, usuario, nombreus" & _
        "uario, agente, CodMonedaCredito) VALUES (@identificacion, @cedula, @nombre, @obs" & _
        "ervaciones, @Telefono_01, @telefono_02, @fax_01, @fax_02, @e_mail, @abierto, @di" & _
        "reccion, @impuesto, @max_credito, @Plazo_credito, @descuento, @empresa, @tipopre" & _
        "cio, @sinrestriccion, @usuario, @nombreusuario, @agente, @CodMonedaCredito); SEL" & _
        "ECT identificacion, cedula, nombre, observaciones, Telefono_01, telefono_02, fax" & _
        "_01, fax_02, e_mail, abierto, direccion, impuesto, max_credito, Plazo_credito, d" & _
        "escuento, empresa, tipoprecio, sinrestriccion, usuario, nombreusuario, agente, C" & _
        "odMonedaCredito FROM Clientes WHERE (identificacion = @identificacion)"
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@identificacion", System.Data.SqlDbType.Int, 4, "identificacion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@cedula", System.Data.SqlDbType.VarChar, 30, "cedula"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombre", System.Data.SqlDbType.VarChar, 255, "nombre"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@observaciones", System.Data.SqlDbType.VarChar, 255, "observaciones"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Telefono_01", System.Data.SqlDbType.VarChar, 8, "Telefono_01"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@telefono_02", System.Data.SqlDbType.VarChar, 8, "telefono_02"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fax_01", System.Data.SqlDbType.VarChar, 8, "fax_01"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@fax_02", System.Data.SqlDbType.VarChar, 8, "fax_02"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@e_mail", System.Data.SqlDbType.VarChar, 255, "e_mail"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@abierto", System.Data.SqlDbType.VarChar, 2, "abierto"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@direccion", System.Data.SqlDbType.VarChar, 255, "direccion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@impuesto", System.Data.SqlDbType.Float, 8, "impuesto"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@max_credito", System.Data.SqlDbType.Float, 8, "max_credito"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Plazo_credito", System.Data.SqlDbType.Int, 4, "Plazo_credito"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@descuento", System.Data.SqlDbType.Float, 8, "descuento"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@empresa", System.Data.SqlDbType.VarChar, 2, "empresa"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@tipoprecio", System.Data.SqlDbType.SmallInt, 2, "tipoprecio"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@sinrestriccion", System.Data.SqlDbType.VarChar, 2, "sinrestriccion"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@usuario", System.Data.SqlDbType.VarChar, 50, "usuario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@nombreusuario", System.Data.SqlDbType.VarChar, 50, "nombreusuario"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@agente", System.Data.SqlDbType.VarChar, 50, "agente"))
        Me.SqlInsertCommand1.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMonedaCredito", System.Data.SqlDbType.Int, 4, "CodMonedaCredito"))
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbxOpciones)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.cboMonedas)
        Me.GroupBox1.Controls.Add(Me.FechaFinal)
        Me.GroupBox1.Controls.Add(Me.FechaInicio)
        Me.GroupBox1.Controls.Add(Me.ButtonMostrar)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 466)
        Me.GroupBox1.TabIndex = 81
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(208, 16)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Ver Reporte Seg�n"
        '
        'cbxOpciones
        '
        Me.cbxOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxOpciones.Items.AddRange(New Object() {"Reporte Forma de Pagos"})
        Me.cbxOpciones.Location = New System.Drawing.Point(8, 32)
        Me.cbxOpciones.Name = "cbxOpciones"
        Me.cbxOpciones.Size = New System.Drawing.Size(208, 21)
        Me.cbxOpciones.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label4.Location = New System.Drawing.Point(120, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 57
        Me.Label4.Text = "Hasta"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label3.Location = New System.Drawing.Point(8, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Desde"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label13.Location = New System.Drawing.Point(40, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(128, 16)
        Me.Label13.TabIndex = 53
        Me.Label13.Text = "Moneda"
        '
        'cboMonedas
        '
        Me.cboMonedas.DataSource = Me.DsReciboAbonos
        Me.cboMonedas.DisplayMember = "Moneda.MonedaNombre"
        Me.cboMonedas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboMonedas.Location = New System.Drawing.Point(40, 120)
        Me.cboMonedas.Name = "cboMonedas"
        Me.cboMonedas.Size = New System.Drawing.Size(128, 21)
        Me.cboMonedas.TabIndex = 41
        '
        'FechaFinal
        '
        Me.FechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.FechaFinal.Location = New System.Drawing.Point(120, 72)
        Me.FechaFinal.Name = "FechaFinal"
        Me.FechaFinal.Size = New System.Drawing.Size(96, 20)
        Me.FechaFinal.TabIndex = 37
        Me.FechaFinal.Value = New Date(2006, 4, 19, 0, 0, 0, 0)
        '
        'FechaInicio
        '
        Me.FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.FechaInicio.Location = New System.Drawing.Point(8, 72)
        Me.FechaInicio.Name = "FechaInicio"
        Me.FechaInicio.Size = New System.Drawing.Size(96, 20)
        Me.FechaInicio.TabIndex = 36
        Me.FechaInicio.Value = New Date(2006, 4, 10, 0, 0, 0, 0)
        '
        'ButtonMostrar
        '
        Me.ButtonMostrar.Location = New System.Drawing.Point(64, 152)
        Me.ButtonMostrar.Name = "ButtonMostrar"
        Me.ButtonMostrar.Size = New System.Drawing.Size(88, 24)
        Me.ButtonMostrar.TabIndex = 20
        Me.ButtonMostrar.Text = "Mostrar"
        '
        'SqlSelectCommand3
        '
        Me.SqlSelectCommand3.CommandText = "SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda"
        Me.SqlSelectCommand3.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "workstation id=SEESERVER;packet size=4096;integrated security=SSPI;data source=SE" & _
        "ESERVER;persist security info=False;initial catalog=Seepos"
        '
        'SqlInsertCommand3
        '
        Me.SqlInsertCommand3.CommandText = "INSERT INTO Moneda(CodMoneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo) VAL" & _
        "UES (@CodMoneda, @MonedaNombre, @ValorCompra, @ValorVenta, @Simbolo); SELECT Cod" & _
        "Moneda, MonedaNombre, ValorCompra, ValorVenta, Simbolo FROM Moneda WHERE (CodMon" & _
        "eda = @CodMoneda)"
        Me.SqlInsertCommand3.Connection = Me.SqlConnection1
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlInsertCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"))
        '
        'SqlUpdateCommand3
        '
        Me.SqlUpdateCommand3.CommandText = "UPDATE Moneda SET CodMoneda = @CodMoneda, MonedaNombre = @MonedaNombre, ValorComp" & _
        "ra = @ValorCompra, ValorVenta = @ValorVenta, Simbolo = @Simbolo WHERE (CodMoneda" & _
        " = @Original_CodMoneda) AND (MonedaNombre = @Original_MonedaNombre) AND (Simbolo" & _
        " = @Original_Simbolo) AND (ValorCompra = @Original_ValorCompra) AND (ValorVenta " & _
        "= @Original_ValorVenta); SELECT CodMoneda, MonedaNombre, ValorCompra, ValorVenta" & _
        ", Simbolo FROM Moneda WHERE (CodMoneda = @CodMoneda)"
        Me.SqlUpdateCommand3.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@CodMoneda", System.Data.SqlDbType.Int, 4, "CodMoneda"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@MonedaNombre", System.Data.SqlDbType.VarChar, 50, "MonedaNombre"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorCompra", System.Data.SqlDbType.Float, 8, "ValorCompra"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@ValorVenta", System.Data.SqlDbType.Float, 8, "ValorVenta"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Simbolo", System.Data.SqlDbType.VarChar, 2, "Simbolo"))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlUpdateCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing))
        '
        'SqlDeleteCommand3
        '
        Me.SqlDeleteCommand3.CommandText = "DELETE FROM Moneda WHERE (CodMoneda = @Original_CodMoneda) AND (MonedaNombre = @O" & _
        "riginal_MonedaNombre) AND (Simbolo = @Original_Simbolo) AND (ValorCompra = @Orig" & _
        "inal_ValorCompra) AND (ValorVenta = @Original_ValorVenta)"
        Me.SqlDeleteCommand3.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_CodMoneda", System.Data.SqlDbType.Int, 4, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "CodMoneda", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_MonedaNombre", System.Data.SqlDbType.VarChar, 50, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "MonedaNombre", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_Simbolo", System.Data.SqlDbType.VarChar, 2, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Simbolo", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorCompra", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorCompra", System.Data.DataRowVersion.Original, Nothing))
        Me.SqlDeleteCommand3.Parameters.Add(New System.Data.SqlClient.SqlParameter("@Original_ValorVenta", System.Data.SqlDbType.Float, 8, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "ValorVenta", System.Data.DataRowVersion.Original, Nothing))
        '
        'daMonedas
        '
        Me.daMonedas.DeleteCommand = Me.SqlDeleteCommand3
        Me.daMonedas.InsertCommand = Me.SqlInsertCommand3
        Me.daMonedas.SelectCommand = Me.SqlSelectCommand3
        Me.daMonedas.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Moneda", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("CodMoneda", "CodMoneda"), New System.Data.Common.DataColumnMapping("MonedaNombre", "MonedaNombre"), New System.Data.Common.DataColumnMapping("ValorCompra", "ValorCompra"), New System.Data.Common.DataColumnMapping("ValorVenta", "ValorVenta"), New System.Data.Common.DataColumnMapping("Simbolo", "Simbolo")})})
        Me.daMonedas.UpdateCommand = Me.SqlUpdateCommand3
        '
        'FrmReportesCajas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(692, 466)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.VisorReporte)
        Me.Controls.Add(Me.lblTipoCambio)
        Me.Name = "FrmReportesCajas"
        Me.Text = "Reportes Forma de Pago en Caja"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DsReciboAbonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

#Region "variables"

    Private cConexion As Conexion
    Private sqlConexion As SqlConnection
#End Region

    Private Sub ButtonMostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMostrar.Click
        Select Case Me.cbxOpciones.SelectedIndex
            Case 0
                Dim Reporte As New ReporteMovimientoCajasegunFormasdePago
                Reporte.SetParameterValue(0, CDate(Me.FechaInicio.Value))
                Reporte.SetParameterValue(1, CDate(Me.FechaFinal.Value))
                Reporte.SetParameterValue(2, lblTipoCambio.Text)
                Reporte.SetParameterValue(3, cboMonedas.Text)
                CrystalReportsConexion.LoadReportViewer(VisorReporte, Reporte)
                VisorReporte.Show()
        End Select
    End Sub

    Private Sub frmReciboAbonos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cConexion = New Conexion
            sqlConexion = cConexion.Conectar
            SqlConnection1.ConnectionString = CadenaConexionSeePOS
            Me.daMonedas.Fill(Me.DsReciboAbonos, "Moneda")
        Catch ex As SystemException
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub cbxOpciones_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbxOpciones.SelectedIndexChanged
        Select Case Me.cbxOpciones.SelectedIndex
            Case 0
                Me.FechaInicio.Value = Date.Today
                Me.FechaFinal.Value = Date.Today
            Case 1
                Me.FechaInicio.Value = Date.Today
                Me.FechaFinal.Value = Date.Today
            Case 2
                Me.FechaInicio.Value = Date.Today
                Me.FechaFinal.Value = Date.Today
        End Select
    End Sub
End Class
