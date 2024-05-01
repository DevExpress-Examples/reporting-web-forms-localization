<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.master" CodeBehind="Designer.aspx.vb" Inherits="SubstituteLocalizationStringsExample.Designer" %>
<%@ Register Assembly="DevExpress.XtraReports.v23.1.Web.WebForms, Version=23.1.10.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<asp:Content ID="Content" ContentPlaceHolderID="MainContent" runat="server">
    <dx:ASPxReportDesigner EnableRichTextEditor="False" ID="ASPxReportDesigner1" runat="server">
            <ClientSideEvents CustomizeLocalization="function(s, e) {
	            s.UpdateLocalization({
                'Properties': 'Here goes my Report properties',
                'Appearance': 'Change options here for a fantastic view',
                'Data Member' : 'Data Table Name'
                });
            }" />
    </dx:ASPxReportDesigner>
</asp:Content>