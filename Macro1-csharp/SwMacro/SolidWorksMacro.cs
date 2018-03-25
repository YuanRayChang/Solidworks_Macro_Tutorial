using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
using System;

namespace Macro1.csproj
{
    public partial class SolidWorksMacro
    {


        public void Main()
        {

            
            ModelDoc2 swDoc = null;
            PartDoc swPart = null;
            DrawingDoc swDrawing = null;
            AssemblyDoc swAssembly = null;
            bool boolstatus = false;
            int longstatus = 0;
            int longwarnings = 0;
            // 
            // New Document
            double swSheetWidth;
            swSheetWidth = 0;
            double swSheetHeight;
            swSheetHeight = 0;
            swDoc = ((ModelDoc2)(swApp.NewDocument("D:\\Program Files\\SolidWorks Corp\\SOLIDWORKS (2)\\lang\\chinese\\Tutorial\\part.prtdot" +
                    "", 0, swSheetWidth, swSheetHeight)));
            swPart = swDoc;
            swApp.ActivateDoc2("Part1", false, ref longstatus);
            swDoc = ((ModelDoc2)(swApp.ActiveDoc));
            ModelView myModelView = null;
            myModelView = ((ModelView)(swDoc.ActiveView));
            myModelView.FrameState = ((int)(swWindowState_e.swWindowMaximized));
            swDoc.SketchManager.InsertSketch(true);
            boolstatus = swDoc.Extension.SelectByID2("Front", "PLANE", -0.068230578696965388, 0.046649779711848, 0.0043111746054159822, false, 0, null, 0);
            swDoc.ClearSelection2(true);
            boolstatus = swDoc.Extension.SetUserPreferenceToggle(((int)(swUserPreferenceToggle_e.swSketchAddConstToRectEntity)), ((int)(swUserPreferenceOption_e.swDetailingNoOptionSpecified)), false);
            boolstatus = swDoc.Extension.SetUserPreferenceToggle(((int)(swUserPreferenceToggle_e.swSketchAddConstLineDiagonalType)), ((int)(swUserPreferenceOption_e.swDetailingNoOptionSpecified)), true);
            Array vSkLines = null;
            vSkLines = ((Array)(swDoc.SketchManager.CreateCornerRectangle(-0.05212005640233669, 0.022239709930839985, 0, 0.043660780232323892, -0.038612502517961472, 0)));
            swDoc.ClearSelection2(true);
            swDoc.SketchManager.InsertSketch(true);
            // 
            // Named View
            swDoc.ShowNamedView2("*Trimetric", 8);
            swDoc.ViewZoomtofit2();
            Feature myFeature = null;
            myFeature = ((Feature)(swDoc.FeatureManager.FeatureExtrusion2(true, false, false, 0, 0, 0.025, 0.01, false, false, false, false, 0.017453292519943334, 0.017453292519943334, false, false, false, false, true, true, true, 0, 0, false)));
            swDoc.ISelectionManager.EnableContourSelection = false;
        }

        /// <summary>
        ///  The SldWorks swApp variable is pre-assigned for you.
        /// </summary>
        public SldWorks swApp;
    }
}


