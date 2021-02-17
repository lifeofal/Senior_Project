------------------------------------------------
-----         Ab3d.DXEngine Readme         -----
------------------------------------------------

Ab3d.DXEngine is a DirectX 11 rendering engine for Desktop .Net applications.
Ab3d.DXEngine is built for advanced business and scientific 3D visualization.

It uses super fast rendering techniques that can fully utilize graphics cards 
and provide the ultimate performance. It also supports top quality visuals 
with PBR materials and shadows.

Ab3d.DXEngine package is the core package of the library. 
Usually, the Ab3d.DXEngine.Wpf package is also used.

It is also recommended to use Ab3d.PowerToys library that greatly simplifies working with 3D graphics.


Explore features of the library with checking sample projects:
https://github.com/ab4d/Ab3d.DXEngine.Wpf.Samples

Homepage:
https://www.ab4d.com/DXEngine.aspx

Online users guide:
https://www.ab4d.com/DirectX/3D/Introduction.aspx

Online reference help:
https://www.ab4d.com/help/DXEngine/html/R_Project_Ab3d_DXEngine_Help.htm

Change log:
https://www.ab4d.com/DXEngine-history.aspx


Diagnostics tool:
https://www.ab4d.com/GetFile.ashx?fileName=DXEngineSnoop.exe


See also:
https://github.com/ab4d/Ab3d.PowerToys.Wpf.Samples
https://www.ab4d.com/PowerToys.aspx


This version of Ab3d.DXEngine can be used as an evaluation and as a commercial version.

Evaluation usage:
On the first usage of the library, a dialog to start a 60-days evaluation is shown.
The evaluation version offers full functionality of the library but displays an evaluation
info dialog once a day and occasionally shows a "Ab3d.DXEngine evaluation" watermark text.
When the evaluation is expired, you can ask for evaluation extension or restart 
the evaluation period when a new version of the library is available.

You can see the prices of the library and purchase it on 
https://www.ab4d.com/Purchase.aspx#DXEngine

Commercial usage:
In case you have purchased a license, you can get the license parameters
from your User Account web page (https://www.ab4d.com/UserLogIn.aspx).
Then set the parametes with adding the following code before the library is used:

Ab3d.Licensing.DXEngine.LicenseHelper.SetLicense(licenseOwner: "[CompanyName]", 
                                                 licenseType: "[LicenseType]", 
                                                 license: "[LicenseText]");

Note that the version that is distributed as NuGet package uses a different licensing
mechanism then the commercial version that is distributed with a windows installer. 
Also the LicenseText that is used as a parameter to the SetLicense method is different 
then the license key used in the installer.