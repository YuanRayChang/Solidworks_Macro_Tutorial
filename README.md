# Solidworks Macro Tutorial
In this tutorial, I will show the process of how to make an .exe file using VB.net.

Because there is little information on the internet. So I decided to write one.

Many other tutorials have tought the way to record a macro, and run the macro on Solidworks. However, this is not enough.

Someone like me want to use an .exe file, so that I can call the macro directly by command window, instead of Solidworks.


---
## Software I Used:
* Solidworks 2017
* Visual Studio 2013
I think the sortware version does'nt matter.

---
## Tutorial Starts By Here:

### Start Solidworks:
The first step is click the start macro button, then you can record everything you need.

![](image/start.PNG)


In my case, I draw a cuboid.


Finally, click the stop button.

![](image/end.PNG)

After recording a macro, you should save it as 
`SW ALL Macros Types (*.swp;*.csproj;*.vbproj)`

<img src="image/save_as.png" width="800">

1 .swp file, 1 vb.net folder, 1 csharp folder will be createrd.

![](image/macro_files.PNG)

### Start Visual Studio:
Start Visual Studio, and  add a new Visual Basic project. Just like the figure shown below.

(Sorry that I don't have an English version)

<img src="image/vs.PNG" width="800">

So I created a VB project called "Macro_demo". 

And see the file "Module1.vb" with 4 lines.

<img src="image/init.PNG" width="800">

Before doing anything, we must do the following steps in order to successfully run the project.

You must puts two files in the project folder. 
In my case  it is: `D:\Solidworks_Macro\Macro_demo\Macro_demo\bin\Debug`
### Two files:
* SolidWorks.Interop.SldWorks.dll 
* SolidWorks.Interop.swconst.dll

Actually, I forgot where did I get these files. Perhaps on the internet. So if you don't have those file you can use mine.

Go to project -> properties -> reference path 

### Click "add"

<img src="image/ref.PNG" width="800">

---
### Go to browse, and select the two files:
* SolidWorks.Interop.SldWorks.dll 
* SolidWorks.Interop.swconst.dll
<img src="image/path.PNG" width="800">

---
### Go to "COM", and select two libraries:
* SldWorks 2017 Type Library
* SOLIDWORKS2017 Constant type library
<img src="image/path2.PNG" width="800">

---

As a result, we added 4 things. Like the figure shown below.

<img src="image/path_4.PNG" width="800">

---
Let's go back to the file "Module1.vb", and do the rest of the things.

We have to put the following lines into the file.
```vbnet
Imports SolidWorks.Interop.sldworks
Imports SolidWorks.Interop.swconst
Imports System
Imports System.IO
```

```vbnet
Dim swApp As SldWorks.SldWorks
swApp = New SldWorks.SldWorks()
'When set "swApp.Visible" as "False", Solidworks won't pop out while running the macro
'When set "swApp.Visible" as "True", it is easier to debug while running the macro
swApp.Visible = True
```

And the file becomes:
<img src="image/init_code.PNG">

---
Go to the Macros we recorded at the beginning.

Inside the folder `Macro1-vbnet`.

In my case, open the file, `SolidWorksMacro.vb`, inside the folder: `D:\Solidworks_Macro\Macro1-vbnet\SwMacro`.

Copy the code between `Public Sub main()` and `End Sub`

<img src="image/vb.PNG" width="800">

Paste it to `Module1.vb` just below `swApp.Visible = True`

<img src="image/final_code.PNG" width="800">

---
Finally, you can run it. In my experience, the macro recorded from Solidworks, sometimes can't work.

Which is cause by some redundant code recorded by Solidworks. So you should debug and make sure everything works fine.

Once it is all done, you can find the .exe file inside the folder `D:\Solidworks_Macro\Macro_demo\Macro_demo\bin\Debug`

In my case my .exe file is called `Macro_demo.exe`.

---
## Something More Advanced
### Input parameters to the .exe file from command window
You just simply change `Sub Main()` to `Public Sub main(ByVal ParamArray args() As String)`, 
So that you can **input parameters** to the .exe file from command window.

**Why am I doing this?** Because in my other project, I use Matlab to call command window and input the design parameters
. So as to automatically make new design in Solidworks.  

<img src="image/change.PNG" width="800">

for example, I can type somthing like this: `Macro_demo.exe 1 2 3 4 5`

Which means I input 5 parameters, `1 2 3 4 5`, to `Macro_demo.exe`.
