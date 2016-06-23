<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<%@ Register assembly="DevExpress.XtraCharts.v15.1.Web, Version=15.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraCharts.Web" tagprefix="dxchartsui" %>
<%@ Register assembly="DevExpress.XtraCharts.v15.1, Version=15.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.XtraCharts" tagprefix="cc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <dxchartsui:WebChartControl ID="WebChartControl1" runat="server" AppearanceNameSerializable="Chameleon" CrosshairEnabled="True" Height="633px" Width="694px">
            <borderoptions visibility="True" />
            <diagramserializable>
                <cc1:XYDiagram>
                    <axisx title-text="Axis X Title" title-visibility="True" visibility="True" visibleinpanesserializable="-1;0">
                        <strips>
                            <cc1:Strip Name="Strip 1" Visible="False">
                                <minlimit axisvalueserializable="0" />
                                <maxlimit axisvalueserializable="1" />
                            </cc1:Strip>
                        </strips>
                        <constantlines>
                            <cc1:ConstantLine AxisValueSerializable="1" Name="Constant Line 1" Visible="False">
                            </cc1:ConstantLine>
                        </constantlines>
                    </axisx>
                    <axisy visibility="True" visibleinpanesserializable="-1;0">
                    </axisy>
                    <panes>
                        <cc1:XYDiagramPane Name="Pane 1" PaneID="0">
                        </cc1:XYDiagramPane>
                    </panes>
                </cc1:XYDiagram>
            </diagramserializable>
            <legend visibility="True"></legend>
            <annotationrepository>
                <cc1:TextAnnotation Name="Text Annotation 1">
                    <anchorpointserializable>
                        <cc1:ChartAnchorPoint Y="43" />
                    </anchorpointserializable>
                    <shapepositionserializable>
                        <cc1:FreePosition>
                            <innerindents left="0" top="0" />
                        </cc1:FreePosition>
                    </shapepositionserializable>
                </cc1:TextAnnotation>
            </annotationrepository>
            <seriesserializable>
                <cc1:Series LabelsVisibility="True" LegendText="4563" Name="Series 1" ToolTipEnabled="True">
                    <points>
                        <cc1:SeriesPoint ArgumentSerializable="0" ColorSerializable="#1F497D" Values="3.5;3.5">
                        </cc1:SeriesPoint>
                        <cc1:SeriesPoint ArgumentSerializable="1" Values="4.6;4.6">
                        </cc1:SeriesPoint>
                        <cc1:SeriesPoint ArgumentSerializable="2" Values="0.5;0.5">
                        </cc1:SeriesPoint>
                        <cc1:SeriesPoint ArgumentSerializable="3" ColorSerializable="#953734" Values="3.6;3.6">
                        </cc1:SeriesPoint>
                        <cc1:SeriesPoint ArgumentSerializable="4" Values="7.8;7.8">
                        </cc1:SeriesPoint>
                    </points>
                    <viewserializable>
                        <cc1:LineSeriesView ColorEach="True" MarkerVisibility="True" PaneName="Pane 1">
                        </cc1:LineSeriesView>
                    </viewserializable>
                    <labelserializable>
                        <cc1:PointSeriesLabel Antialiasing="True" LineVisibility="True">
                            <border visibility="True" />
                        </cc1:PointSeriesLabel>
                    </labelserializable>
                    <topnoptions enabled="True" />
                </cc1:Series>
                <cc1:Series Name="Series 2">
                    <points>
                        <cc1:SeriesPoint ArgumentSerializable="0" Values="2">
                        </cc1:SeriesPoint>
                        <cc1:SeriesPoint ArgumentSerializable="1" Values="8.4">
                        </cc1:SeriesPoint>
                        <cc1:SeriesPoint ArgumentSerializable="2" Values="5">
                        </cc1:SeriesPoint>
                        <cc1:SeriesPoint ArgumentSerializable="3" Values="1.1">
                        </cc1:SeriesPoint>
                        <cc1:SeriesPoint ArgumentSerializable="4" Values="3.9">
                        </cc1:SeriesPoint>
                    </points>
                    <viewserializable>
                        <cc1:AreaSeriesView>
                        </cc1:AreaSeriesView>
                    </viewserializable>
                </cc1:Series>
            </seriesserializable>
            <titles>
                <cc1:ChartTitle />
                <cc1:ChartTitle Text="Chart Title3" />
            </titles>
        </dxchartsui:WebChartControl>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
