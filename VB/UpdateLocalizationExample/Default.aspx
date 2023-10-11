<%@ Page Language="VB" AutoEventWireup="true" CodeBehind="Default.aspx.vb" Inherits="UpdateLocalizationExample.Default" %>

<%@ Register assembly="DevExpress.XtraReports.v15.1.Web, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraReports.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ASPxReportDesigner ID="ASPxReportDesigner1" ClientInstanceName="testDesigner" runat="server" EnableDataSourceWizard="False" ShouldShareReportDataSources="True" TryAddDefaultDataSerializer="True" OnLoad="Page_Load">
            <ClientSideEvents Init="function(s, e) {
	            testDesigner.UpdateLocalization({
                    'Properties': 'Custom text',
       	            'Appearance': 'Custom text123',
                'Data Member' : 'DM'
                });
            }" />
        </dx:ASPxReportDesigner>
    </div>
    </form>
</body>
</html>
