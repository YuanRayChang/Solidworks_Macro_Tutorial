Module Module1
Imports SolidWorks.Interop.sldworks
Imports SolidWorks.Interop.swconst
Imports System
Imports System.IO

    Sub Main()
        Dim swDoc As ModelDoc2 = Nothing
        Dim swPart As PartDoc = Nothing
        Dim swDrawing As DrawingDoc = Nothing
        Dim swAssembly As AssemblyDoc = Nothing
        Dim boolstatus As Boolean = False
        Dim longstatus As Integer = 0
        Dim longwarnings As Integer = 0
        Dim swApp As SldWorks.SldWorks
        swApp = New SldWorks.SldWorks()
        'When set "swApp.Visible" as "False", Solidworks won't pop out when running the macro
        'When set "swApp.Visible" as "True", It is easier to debug when running the macro
        swApp.Visible = True

    End Sub

End Module
