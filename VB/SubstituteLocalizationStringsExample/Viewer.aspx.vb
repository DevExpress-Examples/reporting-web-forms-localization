Imports System
Imports System.Web.UI
Imports System.Web.UI.WebControls

Namespace SubstituteLocalizationStringsExample

    Public Partial Class Viewer
        Inherits Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
            ASPxWebDocumentViewer1.OpenReport("Invoice")
        End Sub
    End Class
End Namespace
