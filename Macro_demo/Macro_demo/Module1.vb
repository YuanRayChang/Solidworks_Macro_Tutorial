Imports SolidWorks.Interop.sldworks
Imports SolidWorks.Interop.swconst
Imports System
Imports System.IO
Module Module1

    Sub Main()
        Dim swApp As SldWorks.SldWorks
        swApp = New SldWorks.SldWorks()
        'When set "swApp.Visible" as "False", Solidworks won't pop out while running the macro
        'When set "swApp.Visible" as "True", it is easier to debug while running the macro
        swApp.Visible = True
        Dim swDoc As ModelDoc2 = Nothing
        Dim swPart As PartDoc = Nothing
        Dim swDrawing As DrawingDoc = Nothing
        Dim swAssembly As AssemblyDoc = Nothing
        Dim boolstatus As Boolean = False
        Dim longstatus As Integer = 0
        Dim longwarnings As Integer = 0
        '
        'New Document
        Dim swSheetWidth As Double
        swSheetWidth = 0
        Dim swSheetHeight As Double
        swSheetHeight = 0
        swDoc = CType(swApp.NewDocument("D:\Program Files\SolidWorks Corp\SOLIDWORKS (2)\lang\chinese\Tutorial\part.prtdot" & _
                "", 0, swSheetWidth, swSheetHeight), ModelDoc2)
        swPart = swDoc
        swApp.ActivateDoc2("Part1", False, longstatus)
        swDoc = CType(swApp.ActiveDoc, ModelDoc2)
        Dim myModelView As ModelView = Nothing
        myModelView = CType(swDoc.ActiveView, ModelView)
        myModelView.FrameState = CType(swWindowState_e.swWindowMaximized, Integer)
        swDoc.SketchManager.InsertSketch(True)
        boolstatus = swDoc.Extension.SelectByID2("Front", "PLANE", -0.068230578696965388, 0.046649779711848, 0.0043111746054159822, False, 0, Nothing, 0)
        swDoc.ClearSelection2(True)
        boolstatus = swDoc.Extension.SetUserPreferenceToggle(CType(swUserPreferenceToggle_e.swSketchAddConstToRectEntity, Integer), CType(swUserPreferenceOption_e.swDetailingNoOptionSpecified, Integer), False)
        boolstatus = swDoc.Extension.SetUserPreferenceToggle(CType(swUserPreferenceToggle_e.swSketchAddConstLineDiagonalType, Integer), CType(swUserPreferenceOption_e.swDetailingNoOptionSpecified, Integer), True)
        Dim vSkLines As Array = Nothing
        vSkLines = CType(swDoc.SketchManager.CreateCornerRectangle(-0.05212005640233669, 0.022239709930839985, 0, 0.043660780232323892, -0.038612502517961472, 0), Array)
        swDoc.ClearSelection2(True)
        swDoc.SketchManager.InsertSketch(True)
        '
        'Named View
        swDoc.ShowNamedView2("*Trimetric", 8)
        swDoc.ViewZoomtofit2()
        Dim myFeature As Feature = Nothing
        myFeature = CType(swDoc.FeatureManager.FeatureExtrusion2(True, False, False, 0, 0, 0.025, 0.01, False, False, False, False, 0.017453292519943334, 0.017453292519943334, False, False, False, False, True, True, True, 0, 0, False), Feature)
        swDoc.ISelectionManager.EnableContourSelection = False
    End Sub

End Module
