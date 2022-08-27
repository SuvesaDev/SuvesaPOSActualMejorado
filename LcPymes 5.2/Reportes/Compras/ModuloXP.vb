Option Strict Off
Option Explicit On 
Imports System.Windows.Forms

Module ModuleXP

    Declare Function SHGetPathFromIDList Lib "shell32.dll" Alias "SHGetPathFromIDListA" (ByVal pidl As Integer, ByVal pszPath As String) As Integer'MLHIDE
    'UPGRADE_WARNING: La estructura ITEMIDLIST puede requerir que se pasen atributos de cálculo de referencia como argumento en esta instrucción Declare. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
    Declare Function SHGetSpecialFolderLocation Lib "shell32.dll" (ByVal hwndOwner As Integer, ByVal nFolder As Integer, ByRef pidl As ITEMIDLIST) As Integer'MLHIDE
    'UPGRADE_WARNING: La estructura BROWSEINFO puede requerir que se pasen atributos de cálculo de referencia como argumento en esta instrucción Declare. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1050"'
    Declare Function SHBrowseForFolder Lib "shell32.dll" Alias "SHBrowseForFolderA" (ByRef lpBrowseInfo As BROWSEINFO) As Integer 'MLHIDE

    Structure SHITEMID
        Dim cb As Integer
        Dim abID As Byte
    End Structure

    Structure ITEMIDLIST
        Dim mkid As SHITEMID
    End Structure

    Structure BROWSEINFO
        Dim hOwner As Integer
        Dim pidlRoot As Integer
        Dim pszDisplayName As String
        Dim lpszTitle As String
        Dim ulFlags As Integer
        Dim lpfn As Integer
        Dim lParam As Integer
        Dim iImage As Integer
    End Structure

    Public Const NOERROR As Short = 0
    Public Const CSIDL_DESKTOP As Short = &H0S 'constants for determining where to browse
    Public Const CSIDL_PROGRAMS As Short = &H2S
    Public Const CSIDL_CONTROLS As Short = &H3S
    Public Const CSIDL_PRINTERS As Short = &H4S
    Public Const CSIDL_PERSONAL As Short = &H5S
    Public Const CSIDL_FAVORITES As Short = &H6S
    Public Const CSIDL_STARTUP As Short = &H7S
    Public Const CSIDL_RECENT As Short = &H8S
    Public Const CSIDL_SENDTO As Short = &H9S
    Public Const CSIDL_BITBUCKET As Short = &HAS
    Public Const CSIDL_STARTMENU As Short = &HBS
    Public Const CSIDL_DESKTOPDIRECTORY As Short = &H10S
    Public Const CSIDL_DRIVES As Short = &H11S
    Public Const CSIDL_NETWORK As Short = &H12S
    Public Const CSIDL_NETHOOD As Short = &H13S
    Public Const CSIDL_FONTS As Short = &H14S
    Public Const CSIDL_TEMPLATES As Short = &H15S

    Public Const BIF_RETURNONLYFSDIRS As Short = &H1S
    Public Const BIF_DONTGOBELOWDOMAIN As Short = &H2S
    Public Const BIF_STATUSTEXT As Short = &H4S
    Public Const BIF_RETURNFSANCESTORS As Short = &H8S
    Public Const BIF_BROWSEFORCOMPUTER As Short = &H1000S
    Public Const BIF_BROWSEFORPRINTER As Short = &H2000S

    'Public CodigoBusquedaArticulos As Object

    'This module will also work with the
    '"Microsoft Windows Common Controls 5.0 (SP2)" component,
    'Which comes with VS 6 Enterprise (Not sure about other versions).

    'This code creates the xml manifest for using windows
    'xp theme controls. The InitXP sub should be called
    'in the Form_Initialize event of each form, befor
    'the form is shown. This only works when the program
    'is an executible, not in the IDE. Also, The First Time
    'The exe is run, it will not work. Creating a sub
    'program that is run first may do the trick . . .

    'Note: Command buttons and option buttons do not seem
    'to display properly when placed inside of a frame control.
    'Frame controls INSIDE of another frame control also have
    'the same effect

    'Although I have not tested it on other systems, there
    'should be no effect . . .
    'Upgrades controls
    Public Declare Function InitCommonControls Lib "Comctl32.dll" () As Integer 'MLHIDE

    Public Sub InitXP()

        Dim strPath As String 'Path to the manifest file
        Dim strData As String 'XML data for the manifest file
        Dim FF As Short 'FreeFile handle

        'Skip errors
        On Error Resume Next

        'Get the path to the exe. The manifest has the same name, with the manifest extension
        strPath = Application.StartupPath & IIf(Right(Application.StartupPath, 1) = "\", vbNullString, "\") 'MLHIDE
        strPath = strPath & Application.ProductName & IIf(LCase(Right(Application.ProductName, 4)) = ".exe", ".manifest", ".exe.manifest") 'MLHIDE

        'Check for the existance of the file, and skip to initializing if found
        'UPGRADE_WARNING: Dir tiene un nuevo comportamiento. Haga clic aquí para obtener más información: 'ms-help://MS.VSCC.2003/commoner/redir/redirect.htm?keyword="vbup1041"'
        If Dir(strPath, FileAttribute.ReadOnly Or FileAttribute.System Or FileAttribute.Hidden) <> vbNullString Then GoTo InitControls

        'Set up the xml data
        strData = "<?xml version=" & Chr(34) & "1.0" & Chr(34) & " encoding=" & Chr(34) & "UTF-8" & Chr(34) & " standalone=" & Chr(34) & "yes" & Chr(34) & "?>" & vbCrLf 'MLHIDE
        strData = strData & "<assembly xmlns=" & Chr(34) & "urn:schemas-microsoft-com:asm.v1" & Chr(34) & " manifestVersion=" & Chr(34) & "1.0" & Chr(34) & ">" & vbCrLf 'MLHIDE
        strData = strData & "     <assemblyIdentity version=" & Chr(34) & "1.0.0.0" & Chr(34) & " processorArchitecture=" & Chr(34) & "X86" & Chr(34) & " name=" & Chr(34) & "HybridDesign.WindowsXP.Example" & Chr(34) & " type=" & Chr(34) & "win32" & Chr(34) & " />" & vbCrLf 'MLHIDE
        strData = strData & "     <description>Windows XP Theme.</description>" & vbCrLf 'MLHIDE
        strData = strData & "     <dependency>" & vbCrLf              'MLHIDE
        strData = strData & "          <dependentAssembly>" & vbCrLf  'MLHIDE
        strData = strData & "               <assemblyIdentity type=" & Chr(34) & "win32" & Chr(34) & " name=" & Chr(34) & "Microsoft.Windows.Common-Controls" & Chr(34) & " version=" & Chr(34) & "6.0.0.0" & Chr(34) & " processorArchitecture=" & Chr(34) & "X86" & Chr(34) & " publicKeyToken=" & Chr(34) & "6595b64144ccf1df" & Chr(34) & " language=" & Chr(34) & "*" & Chr(34) & " />" & vbCrLf'MLHIDE
        strData = strData & "          </dependentAssembly>" & vbCrLf 'MLHIDE
        strData = strData & "     </dependency>" & vbCrLf             'MLHIDE
        strData = strData & "</assembly>"                             'MLHIDE

        'Open the file and print the xml data
        FF = FreeFile
        FileOpen(FF, strPath, OpenMode.Output)
        PrintLine(FF, strData)
        FileClose(FF)

        'Set the atrributes of the file
        SetAttr(strPath, FileAttribute.System Or FileAttribute.ReadOnly Or FileAttribute.Archive)
        '    SetAttr strPath, vbHidden Or vbSystem Or vbReadOnly Or vbArchive

InitControls:

        'Call the api to initialize the XP theme
        Call InitCommonControls()
    End Sub
End Module