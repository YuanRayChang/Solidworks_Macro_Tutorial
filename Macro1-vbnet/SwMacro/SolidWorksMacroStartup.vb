Imports SolidWorks.Interop.sldworks
Imports System

Partial Class SolidWorksMacro


    Private Sub SolidWorksMacro_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup

        Me.swApp = Me.SolidWorksApplication
        Dim runResult As SolidWorks.RunMacroResult = RunMacro()
        If (runResult = SolidWorks.RunMacroResult.NoneSpecified) Then
	    Try
	     SwMacroSetup()
             Catch exSetup as Exception
		System.Diagnostics.Debug.WriteLine(exSetup.ToString())
            End Try
            Main()
	    Try
             SwMacroCleanup()
             Catch exCleanup as Exception
		System.Diagnostics.Debug.WriteLine(exCleanup.ToString())
            End Try
        End If

    End Sub

    Private Sub SolidWorksMacro_Shutdown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shutdown

    End Sub


End Class
