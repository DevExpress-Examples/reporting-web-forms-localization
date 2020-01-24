<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="UpdateLocalizationExample.Default" %>

<%@ Register assembly="DevExpress.XtraReports.v19.2.Web.WebForms, Version=19.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraReports.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxReportDesigner ID="ASPxReportDesigner1" ClientInstanceName="testDesigner" runat="server" EnableDataSourceWizard="False" OnLoad="Page_Load">
            <ClientSideEvents CustomizeLocalization="function(s, e) {
	            testDesigner.UpdateLocalization({
                'Properties': 'Here goes my Report properties',
                'Appearance': 'Change options here for a fantastic view',
                'Data Member' : 'Data Table Name'
                });
            }" />
        </dx:ASPxReportDesigner>
    </div>
    </form>
</body>
</html>
