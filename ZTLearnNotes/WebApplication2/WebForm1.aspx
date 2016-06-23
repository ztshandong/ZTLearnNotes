<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<%@ Register assembly="DevExpress.Web.v15.1, Version=15.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<%@ Register assembly="DevExpress.Web.ASPxRichEdit.v15.1, Version=15.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxRichEdit" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.ASPxPivotGrid.v15.1, Version=15.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxPivotGrid" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <%--<script type="text/javascript">
        alert(new Date().toLocaleString());
    </script>--%>
    <%--<script>
        function add(i1,i2) {
            return i1 + i2;
        }
        function myfunction(arr) {
            arr[0] = 1;
        }
        var arr = new Array();
        arr[0] = "a";
        arr[1] = "b";
        myfunction(arr);
        alert(arr);
    </script>--%>
</head>
<body>
    <a href="javascript:alert('hello')">45</a>
    <form id="form1" runat="server">
    <div>
    
        <dx:ASPxPanel ID="ASPxPanel1" runat="server" Height="741px" Width="1112px">
            <PanelCollection>
<dx:PanelContent runat="server">
    <br />
    <br />
    <dx:ASPxRichEdit ID="ASPxRichEdit1" runat="server" DocumentId="" WorkDirectory="~\App_Data\WorkDirectory">
    </dx:ASPxRichEdit>
    <br />
    <br />
    <dx:ASPxButton ID="ASPxButton1" runat="server" OnClick="ASPxButton1_Click" Text="ASPxButton">
    </dx:ASPxButton>
    <br />
    <br />
    <dx:ASPxPivotGrid ID="ASPxPivotGrid1" runat="server" ClientIDMode="AutoID">
        <Fields>
            <dx:PivotGridField ID="fieldDocNo" Area="RowArea" AreaIndex="3" FieldName="DocNo">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldOrgCode" Area="RowArea" AreaIndex="2" FieldName="OrgCode">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldCreatedBy" Area="RowArea" AreaIndex="1" FieldName="CreatedBy">
            </dx:PivotGridField>
            <dx:PivotGridField ID="fieldFlagCheck" Area="RowArea" AreaIndex="0" FieldName="FlagCheck">
            </dx:PivotGridField>
        </Fields>
    </dx:ASPxPivotGrid>
    <dx:ASPxPivotGridExporter ID="ASPxPivotGridExporter1" runat="server" ASPxPivotGridID="ASPxPivotGrid1">
    </dx:ASPxPivotGridExporter>
                <br />
    <br />
    <br />
    <br />
                </dx:PanelContent>
</PanelCollection>
        </dx:ASPxPanel>
    
    </div>
    </form>
</body>
</html>
