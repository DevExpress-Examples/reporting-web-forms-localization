<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T200029)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/SubstituteLocalizationStringsExample/Default.aspx) (VB: [Default.aspx](./VB/SubstituteLocalizationStringsExample/Default.aspx))
* [Default.aspx.cs](./CS/SubstituteLocalizationStringsExample/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/SubstituteLocalizationStringsExample/Default.aspx.vb))
* [Web.config](./CS/SubstituteLocalizationStringsExample/Web.config) (VB: [Web.config](./VB/SubstituteLocalizationStringsExample/Web.config) )
<!-- default file list end -->
# How to Localize the Web Report Designer and Document Viewer Controls

This example illustrates how to apply German localization to reporting controls in a ASP.NET Web Forms application and change the selected UI texts.

The project specifies the application culture with the **Culture** and **UICulture** settings in the [GlobalizationSection](https://docs.microsoft.com/en-us/dotnet/api/system.web.configuration.globalizationsection). The localized texts are obtained automatically from the satellite resource assemblies. Resource assemblies for the German language are included in the DevExpress installation package and added to the project when it is built.

To adjust the default translation, the application handles the reporting control's **CustomizeLocalization** client-side event. The script calls the **UpdateLocalization** method to specify a text for a particular localization string.
 
**See also:**

* [Web Document Viewer - Localization](https://docs.devexpress.com/XtraReports/116315/create-end-user-reporting-applications/web-reporting/asp-net-webforms-reporting/document-viewer/localization)
* [Web End-User Report Designer - Localization](https://docs.devexpress.com/XtraReports/400229/create-end-user-reporting-applications/web-reporting/asp-net-webforms-reporting/end-user-report-designer/localization)


