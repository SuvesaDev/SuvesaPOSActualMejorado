Imports System.Windows.Forms
Imports System.Data

Public Module CrystalReportsConexion
    Public Function LoadReportViewer(ByRef Viewer As CrystalDecisions.Windows.Forms.CrystalReportViewer, ByRef objReport As CrystalDecisions.CrystalReports.Engine.ReportDocument, Optional ByVal NoShow As Boolean = False, Optional ByVal NuevaConexion As String = "") As Boolean

        'Declaring variablesables
        'Parameter value object of crystal report RptViewer
        ' parameters used for adding the value to parameter.
        'Current parameter value object(collection) of crystal report parameters.
        'Sub report object of crystal report.
        'Sub report document of crystal report.
        Dim intCounter As Integer
        Dim intCounter1 As Integer 'Crystal Report's report document object

        Dim ConInfo As New CrystalDecisions.Shared.TableLogOnInfo 'object of table Log on info of Crystal report
        Dim paraValue As New CrystalDecisions.Shared.ParameterDiscreteValue
        Dim currValue As CrystalDecisions.Shared.ParameterValues
        Dim mySubReportObject As CrystalDecisions.CrystalReports.Engine.SubreportObject
        Dim mySubRepDoc As New CrystalDecisions.CrystalReports.Engine.ReportDocument
        Dim strParValPair() As String
        Dim strVal() As String
        Dim index As Integer
        Dim SQLConexion As New Conexion
        SQLConexion.sQlconexion.ConnectionString = IIf(NuevaConexion = "", CadenaConexionSeePOS, NuevaConexion)
        If SQLConexion.sQlconexion.State <> ConnectionState.Open Then SQLConexion.sQlconexion.Open()

        Try
            'ConInfo.ConnectionInfo.UserID = ""
            'ConInfo.ConnectionInfo.Password = ""
            ConInfo.ConnectionInfo.IntegratedSecurity = True
            ConInfo.ConnectionInfo.ServerName = SQLConexion.sQlconexion.DataSource
            ConInfo.ConnectionInfo.DatabaseName = SQLConexion.sQlconexion.Database

            For intCounter = 0 To objReport.Database.Tables.Count - 1
                objReport.Database.Tables(intCounter).ApplyLogOnInfo(ConInfo)
            Next
            ' Loop through each section on the report then look 
            ' through each object in the section
            ' if the object is a subreport, then apply logon info 
            ' on each table of that sub report
            For index = 0 To objReport.ReportDefinition.Sections.Count - 1
                For intCounter = 0 To objReport.ReportDefinition.Sections(index).ReportObjects.Count - 1
                    With objReport.ReportDefinition.Sections(index)
                        If .ReportObjects(intCounter).Kind = CrystalDecisions.Shared.ReportObjectKind.SubreportObject Then
                            mySubReportObject = CType(.ReportObjects(intCounter), CrystalDecisions.CrystalReports.Engine.SubreportObject)
                            mySubRepDoc = mySubReportObject.OpenSubreport(mySubReportObject.SubreportName)
                            For intCounter1 = 0 To mySubRepDoc.Database.Tables.Count - 1
                                mySubRepDoc.Database.Tables(intCounter1).ApplyLogOnInfo(ConInfo)
                            Next
                        End If
                    End With
                Next
            Next


            If NoShow = False Then
                Viewer.SelectionFormula = objReport.RecordSelectionFormula
                Viewer.ReportSource = objReport
                Viewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
            End If

            Return True
        Catch ex As System.Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "LoadReportViewer")
            RegistrarLog(ex.StackTrace)
            Return False
        End Try
    End Function



    Public Sub LoadShow(ByRef Reporte As CrystalDecisions.CrystalReports.Engine.ReportDocument, ByRef MDIForm As Form, Optional ByVal NuevaConexion As String = "", Optional ByVal _IdCotizacion As String = "0")
        Dim Visor As New frmVisorReportes
        Visor.IdCotizacion = _IdCotizacion
        LoadReportViewer(Visor.rptViewer, Reporte, , NuevaConexion)
        Visor.rptViewer.Visible = True
        Reporte = Nothing
        Visor.MdiParent = MDIForm
        Visor.Show()
    End Sub
    'Public Sub VerSplit()

    '    Dim delimStr As String = " ,.:"
    '    Dim delimiter As Char() = delimStr.ToCharArray()
    '    Dim words As String = "one two,three:four."
    '    Dim split As String() = Nothing

    '    Console.WriteLine("The delimiters are -{0}-", delimStr)
    '    Dim x As Integer
    '    For x = 1 To 5
    '        split = words.Split(delimiter, x)
    '        Console.WriteLine(ControlChars.Cr + "count = {0,2} ..............", x)
    '        Dim s As String
    '        For Each s In split
    '            Console.WriteLine("-{0}-", s)
    '        Next s
    '    Next x
    'End Sub 'Main
End Module
