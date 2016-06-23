<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<%@ Register assembly="DevExpress.Web.v15.1, Version=15.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxRichEdit.v15.1, Version=15.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxRichEdit" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <dx:ASPxCardView ID="ASPxCardView1" runat="server">
        </dx:ASPxCardView>
    
    </div>
        <p>
            &nbsp;</p>
        <dx:ASPxRichEdit ID="ASPxRichEdit1" runat="server" WorkDirectory="~\App_Data\WorkDirectory">
        </dx:ASPxRichEdit>
    </form>
</body>
</html>
