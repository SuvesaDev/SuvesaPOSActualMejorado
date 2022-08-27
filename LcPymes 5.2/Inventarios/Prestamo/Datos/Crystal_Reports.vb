Imports System.Data.SqlClient
Imports System.Data

Namespace Prestamos
    Public Class Crystal_Reports
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
                ConInfo.ConnectionInfo.IntegratedSecurity = True
                'ConInfo.ConnectionInfo.UserID = ""
                'ConInfo.ConnectionInfo.Password = ""
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
                    For intCounter = 0 To _
                          objReport.ReportDefinition.Sections(index).ReportObjects.Count - 1
                        With objReport.ReportDefinition.Sections(index)
                            If .ReportObjects(intCounter).Kind =
                               CrystalDecisions.Shared.ReportObjectKind.SubreportObject Then
                                mySubReportObject = CType(.ReportObjects(intCounter), 
                                CrystalDecisions.CrystalReports.Engine.SubreportObject)
                                mySubRepDoc =
                                 mySubReportObject.OpenSubreport(mySubReportObject.SubreportName)
                                For intCounter1 = 0 To mySubRepDoc.Database.Tables.Count - 1
                                    mySubRepDoc.Database.Tables(intCounter1).ApplyLogOnInfo(ConInfo)

                                Next
                            End If
                        End With
                    Next
                Next
                If NoShow = False Then Viewer.ReportSource = objReport
                Return True
            Catch ex As System.Exception
                MsgBox(ex.Message)
                Return False
            End Try
        End Function
    End Class

End Namespace
