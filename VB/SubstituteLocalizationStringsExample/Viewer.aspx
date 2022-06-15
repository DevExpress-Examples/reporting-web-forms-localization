<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Viewer.aspx.vb" Inherits="SubstituteLocalizationStringsExample.Viewer" %>
<%@ Register Assembly="DevExpress.XtraReports.v19.2.Web.WebForms, Version=19.2.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <dx:ASPxWebDocumentViewer ID="ASPxWebDocumentViewer1" runat="server" >
            <ClientSideEvents CustomizeLocalization="function(s, e) {
	            s.UpdateLocalization({
                'Search': 'Geben Sie den zu suchenden Text ein',
                'Search result': 'Ergebnis der Suche',
                'Next Page' : 'Weiter zur nächsten Seite', // A tooltip text.
            'Export Options' : 'Export-Möglichkeiten'
                });
            }" />
    </dx:ASPxWebDocumentViewer>
</asp:Content>