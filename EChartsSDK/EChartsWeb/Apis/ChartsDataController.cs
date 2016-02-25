using ECharts;
using ECharts.Entities;
using ECharts.Entities.axis;
using ECharts.Entities.feature;
using ECharts.Entities.series;
using ECharts.Entities.series.data;
using ECharts.Entities.style;
using EChartsWeb.Util;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EChartsWeb.Apis
{
    public class ChartsDataController : ApiController
    {
        #region tooltip
        //[AcceptVerbs("GET", "POST")]
        //public string ToolTip()
        //{
        //    Dictionary<string, double> datas1 = new Dictionary<string, double>();

        //    datas1.Add("周一", 332);
        //    datas1.Add("周二", 301);
        //    datas1.Add("周三", 334);
        //    datas1.Add("周四", 390);
        //    datas1.Add("周五", 330);
        //    datas1.Add("周六", 330);
        //    datas1.Add("周日", 320);

        //    Dictionary<string, double> datas2 = new Dictionary<string, double>();
        //    datas2.Add("周一", 862);
        //    datas2.Add("周二", 1018);
        //    datas2.Add("周三", 964);
        //    datas2.Add("周四", 1026);
        //    datas2.Add("周五", 1679);
        //    datas2.Add("周六", 1600);
        //    datas2.Add("周日", 157);

        //    ChartOption option = new ChartOption();
        //    option.tooltip = new ToolTip()
        //    {
        //        trigger = TriggerType.axis,
        //        show = true,
        //        showContent = true,
        //        showDelay = 0,
        //        hideDelay = 50,
        //        transitionDuration = 0,
        //        borderRadius = 8,
        //        borderWidth = 2,
        //        padding = 10,
        //        position = new JRaw(string.Format(@"function(p){{
        //            return [p[0] + 10,p[1]-10];
        //        }}")),
        //        textStyle = new TextStyle
        //        {
        //            color = "yellow",
        //            decoration = "none",
        //            fontFamily = "Verdana,sans-serif",
        //            fontSize = 15,
        //            fontStyle = FontStyleType.italic,
        //            fontWeight = "bold"
        //        },
        //        formatter = new JRaw(string.Format(@"function(params){{  
        //        var res = 'function formatter:<br/>'+params[0].name;
        //        for(var i=0,l=params.length;i<l;i++){{
        //            res +='<br/>'+params[i].seriesName+':'+params[i].value;
        //        }}
        //        return res;}}"))
        //    };

        //    option.xAxis = new List<Axis>()
        //    {
        //        new ValueAxis()
        //        {
        //             data = new List<object>(datas1.Keys.ToList()),
        //             type = AxisType.category
        //        }
        //    };
        //    option.yAxis = new List<Axis>() {
        //        new ValueAxis()
        //        {
        //             type = AxisType.value,
        //        }
        //    };

        //    option.series = new List<Object>() {
        //        new Bar() {
        //             name = "坐标触发",
        //             type = ChartType.bar,
        //             data=  datas1.Values.ToList()
        //        },
        //        new Bar() {
        //             name = "坐标触发",
        //             type = ChartType.bar,
        //             data= datas2.Values.ToList()
        //        },
        //        new Bar() {
        //            name = "数据项触发1",
        //            type = ChartType.bar,
        //            tooltip = new ToolTip() {
        //                 trigger = TriggerType.item,
        //                 position= new JRaw("[0,0]"),
        //                 formatter = new JRaw(@"Series formatter:<br/>{a}<br/>{b}:{c}").ToString()
        //            },
        //            stack ="数据项",
        //            data =  new List<object>(){
        //               120,
        //               132,
        //               new SeriesData(){
        //                    value = 301,
        //                    itemStyle  = new ItemStyle(){
        //                      normal = new Normal(){
        //                       color="red"
        //                      }
        //                    },
        //                    tooltip=new ToolTip(){
        //                         backgroundColor="blue",
        //                     formatter=new JRaw(@"Data formatter: <br/>{a}<br/>{b}:{c}").ToString(),
        //                    }
        //               },
        //               134,
        //               90,
        //               new SeriesData(){
        //                value = 230,
        //                tooltip = new ToolTip(){
        //                 show=false,
        //                }
        //               }
        //            }
        //        },
        //        new Bar(){
        //            name="数据项触发2",
        //            type = ChartType.bar,
        //            tooltip = new ToolTip(){
        //                 show = false,
        //                 trigger=TriggerType.item,
        //            },
        //            stack="数据项",
        //            data = datas1.Values.ToList()
        //        }
        //    };

        //    var result = JsonTools.ObjectToJson2(option);
        //    return result;
        //}
        #endregion
        
        #region line data
        [AcceptVerbs("GET", "POST")]
        public string Line()
        {
            IList<string> ads = ChartsUtil.Ads();
            IList<string> weeks = ChartsUtil.Weeks();
            ChartOption option = new ChartOption();
            option.ToolTip().Trigger(TriggerType.axis);
            option.Legend().SetData(new List<object>(ads));

            
            var feature = new Feature();
            feature.DataView().Show(true).ReadOnly(false);
            feature.Mark().Show(true);
            feature.Restore().Show(true);
            feature.MagicType().Show(true).Type("line", "bar", "stack", "tiled");
            feature.SaveAsImage().Show(true);
            option.ToolBox().Show(true).SetFeature(feature);               


            option.calculable = true;
            var x = new CategoryAxis();
            x.BoundaryGap(false).SetData(new List<object>(weeks));
            option.XAxis(x);
            option.YAxis(new ValueAxis());
            
            
            var l1 = new Line("邮件营销");
            var s = new ItemStyle();
            s.Normal().AreaStyle().Color(new JRaw(@"(function () {
                require(['zrender'],
                function (zrender) {
                    zr = zrender.init(document.getElementById('charts'));
                    color = require('zrender/tool/color');
                    return color.getLinearGradient(
                      0, 200, 0, 400,
                      [[0, 'rgba(255,0,0,0.8)'], [0.8, 'rgba(255,255,255,0.1)']]);
                });
            })()"));
            l1.Stack("总量").Symbol(SymbolType.none).SetItemStyle(s);
            var sd = new SeriesData<int>(90);
            sd.Symbol(SymbolType.droplet).SymbolSize(5);
            l1.Data(120, 132, 301, 134, sd, 230, 210);

            var l2 = new Line("联盟广告");
            var sd2 = new SeriesData<int>(201);
            sd2.Symbol(SymbolType.star).SymbolSize(15)
                .ItemStyle().Normal().Label().Show(true)
                .TextStyle().FontSize(20).FontFamily("微软雅黑").FontWeight("bold");
            l2.Stack("总量").Smooth(true).Symbol(@"http://echarts.baidu.com/doc/asset/ico/favicon.png").SymbolSize(8)
                .Data(120, 82, sd2, 190, new SeriesData<int>(134).Symbol(SymbolType.none),
                new SeriesData<int>(134).Symbol(SymbolType.none), 190,
                new SeriesData<int>(230).Symbol(SymbolType.emptypin).SymbolSize(8), 190, 110);

            var l3 = new Line("直接访问");
            var s1 = new ItemStyle();
            s1.Normal().Color("red").LineStyle().Width(2).Type(LineStyleType.dashed);
            s1.Emphasis().Color("blue");
            l3.Stack("总量").Symbol(SymbolType.arrow).SymbolSize(6).SymbolRotate(-45)
                .SetItemStyle(s1);

            var s2 = new ItemStyle();
            s2.Normal().Color("yelowgreen");
            s2.Emphasis().Color("orange");
            var sd3 = new SeriesData<int>(390);
            sd3.Symbol("star6").SymbolSize(20).SymbolRotate(10)
                .Label().Show(true).Position(StyleLabelTyle.inside)
                .TextStyle().FontSize(20);

            l3.SetItemStyle(s2);
            l3.Data(320, 332, "-", 334, sd3, 330, 320);

            var l4 = new Line("搜索引擎");
            var s3 = new ItemStyle();
            s3.Normal().LineStyle().Width(2).Color(new JRaw(@"(function (){
                            require(['zrender'],
                           function (zrender) {
                              zr = zrender.init(document.getElementById('charts'));
                              color = require('zrender/tool/color');                            
                              return color.getLinearGradient(
                               0, 0, 1000, 0,
                               [[0, 'rgba(255,0,0,0.8)'],[0.8, 'rgba(255,255,0,0.8)']]);
                            });                            
                        })()")).ShadowColor("rgba(0,0,0,0.5)")
                        .ShadowBlur(10).ShadowOffsetX(8).ShadowOffsetY(8);
            s3.Emphasis().Label().Show(true);
            l4.SetItemStyle(s3);
            var sd4 = new SeriesData<int>(734);
            sd4.Symbol(SymbolType.emptyheart).SymbolSize(10);
            l4.Data(620, 732, 791, sd4, 890, 930, 820);

            Line l5 = new Line("视频广告");
            l5.stack = "总量";
            l5.data = ChartsUtil.Datas(7, 820, 1400); ;

            option.Series<Line>(l1, l2, l3, l4, l5);
            var result = JsonTools.ObjectToJson2(option);
            return result;
        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("line1")]
        public string StdLine()
        {
            IList<string> weeks = ChartsUtil.Weeks();

            IList<int> datas1 = ChartsUtil.Datas(7, 10, 15);

            IList<int> datas2 = ChartsUtil.Datas(7, -2, 5);

            int min = datas2.Min();
            int index = datas2.IndexOf(min);

            ChartOption option = new ChartOption();

            option.title = new Title()
            {
                show = true,
                text = "未来一周天气变化",
                subtext = "纯虚构数据"
            };


            option.tooltip = new ToolTip()
            {
                trigger = TriggerType.axis
            };

            option.legend = new Legend()
            {
                data = new List<object>(){
                   "最高温度",
                   "最低温度"
                 }
            };

            option.calculable = true;

            option.xAxis = new List<Axis>()
            {
                new CategoryAxis()
                {                    
                    type = AxisType.category,                    
                    boundaryGap= false,
                    data = new List<object>(weeks)
                }
            };

            option.yAxis = new List<Axis>()
            {
                new ValueAxis()
                {
                    type = AxisType.value,
                    axisLabel = new AxisLabel(){
                     formatter=new JRaw("{value} ℃").ToString()
                    }
                }
            };
            option.series = new List<object>()
            {
                    new Line()
                    {
                        name = "最高温度",
                        type =  ChartType.line,
                        data =  datas1,
                        markPoint =  new MarkPoint()
                        {
                                data = new List<object>()
                                {
                                    new MarkData()
                                    {
                                         name = "最大值",
                                         type= MarkType.max,                                                                                                                           
                                    },
                                    new MarkData()
                                    {
                                         name = "最小值",
                                         type= MarkType.min,
                                    }
                                }
                        },
                        markLine = new MarkLine()
                        {
                                data = new List<object>()
                                {
                                     new MarkData()
                                     {
                                          name = "平均值",
                                          type = MarkType.average
                                     }
                                }
                       }
              },
              new Line(){
                name="最低温度",
                type = ChartType.line,
                data = datas2,
                markPoint= new MarkPoint(){
                 data = new List<object>(){
                    new MarkData(){
                     name="周最低",
                     value = min,
                     xAxis = index,
                     yAxis = min+0.5,
                    }        
                 }
                },
               markLine = new MarkLine(){
                data = new List<object>(){
                   new MarkData(){
                    type = MarkType.average,
                    name = "平均值"
                   }
                }
               }
              }
            };
            var result = JsonTools.ObjectToJson2(option);
            return result;
        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("line2")]
        public string HeapLine()
        {
            IList<string> ads = ChartsUtil.Ads();
            IList<string> weeks = ChartsUtil.Weeks();
            IList<int> data1 = ChartsUtil.Datas(7, 90, 240);
            IList<int> data2 = ChartsUtil.Datas(7, 190, 310);
            IList<int> data3 = ChartsUtil.Datas(7, 150, 410);
            IList<int> data4 = ChartsUtil.Datas(7, 300, 400);
            IList<int> data5 = ChartsUtil.Datas(7, 820, 1400);

            ChartOption option = new ChartOption();
            option.legend = new Legend()
            {
                data = new List<object>(ads)
            };

            option.tooltip = new ECharts.Entities.ToolTip()
            {
                trigger = TriggerType.axis
            };

            option.calculable = true;

            option.XAxis(new CategoryAxis()
            {
                type = AxisType.category,
                boundaryGap = false,
                data = new List<object>(weeks),
            });

            option.YAxis(new ValueAxis()
            {
                type = AxisType.value
            });

            Line l1 = new Line(ads[0]);
            l1.stack = "总量";
            l1.data = data1;

            Line l2 = new Line(ads[1]);
            l2.stack = "总量";
            l2.data = data2;

            Line l3 = new Line(ads[2]);
            l3.stack = "总量";
            l3.data = data3;

            Line l4 = new Line(ads[3]);
            l4.stack = "总量";
            l4.data = data4;

            Line l5 = new Line(ads[4]);
            l5.stack = "总量";
            l5.data = data5;

            option.Series<Line>(l1, l2, l3, l4, l5);


            var result = JsonTools.ObjectToJson2(option);
            return result;
        }


        [AcceptVerbs("GET", "POST")]
        [ActionName("line3")]
        public string StdArea()
        {
            IList<string> weeks = ChartsUtil.Weeks();

            IList<int> datas1 = ChartsUtil.Datas(7, 10, 800);
            IList<int> datas2 = ChartsUtil.Datas(7, 10, 600);
            IList<int> datas3 = ChartsUtil.Datas(7, 20, 1300);

            ChartOption option = new ChartOption();

            option.title = new Title()
            {
                text = "某楼盘销售情况",
                subtext = "纯属虚构"
            };

            option.tooltip = new ToolTip()
            {
                trigger = TriggerType.axis
            };

            option.Legend("意向", "预购", "成交");

            option.calculable = true;

            option.XAxis(new CategoryAxis()
            {
                type = AxisType.category,
                boundaryGap = false,
                data = new List<object>(weeks),
            });

            option.YAxis(new ValueAxis()
            {
                type = AxisType.value,
            });
            ItemStyle itemStyle = new ItemStyle()
            {
                normal = new Normal()
                {
                    areaStyle = new AreaStyle()
                    {
                        type = AreaStyleType.Default,
                    }
                }
            };
            Line l1 = new Line("预购");
            l1.smooth = true;
            l1.itemStyle = itemStyle;
            l1.data = datas1;

            Line l2 = new Line("成交");
            l2.smooth = true;
            l2.itemStyle = itemStyle;
            l2.data = datas2;

            Line l3 = new Line("意向");
            l3.smooth = true;
            l3.itemStyle = itemStyle;
            l3.data = datas3;

            option.Series<Line>(l1, l2, l3);

            var result = JsonTools.ObjectToJson2(option);
            return result;
        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("line4")]
        public string HeapArea()
        {
            IList<string> ads = ChartsUtil.Ads();
            IList<string> weeks = ChartsUtil.Weeks();
            IList<int> data1 = ChartsUtil.Datas(7, 90, 240);
            IList<int> data2 = ChartsUtil.Datas(7, 190, 310);
            IList<int> data3 = ChartsUtil.Datas(7, 150, 410);
            IList<int> data4 = ChartsUtil.Datas(7, 300, 400);
            IList<int> data5 = ChartsUtil.Datas(7, 820, 1400);

            ChartOption option = new ChartOption();
            Legend legend = new Legend();
            legend.data = new List<object>(ads);
            option.Legend(legend);

            option.tooltip = new ECharts.Entities.ToolTip()
            {
                trigger = TriggerType.axis
            };

            option.calculable = true;

            option.XAxis(new CategoryAxis()
            {
                type = AxisType.category,
                boundaryGap = false,
                data = new List<object>(weeks),
            });

            option.YAxis(new ValueAxis()
            {
                type = AxisType.value
            });

            ItemStyle itemStyle = new ItemStyle();
            itemStyle.Normal().AreaStyle().SetType(AreaStyleType.Default);
           

            Line l1 = new Line(ads[0]);
            l1.stack = "总量";
            l1.data = data1;
            l1.itemStyle = itemStyle;

            Line l2 = new Line(ads[1]);
            l2.stack = "总量";
            l2.data = data2;
            l2.itemStyle = itemStyle;

            Line l3 = new Line(ads[2]);
            l3.stack = "总量";
            l3.data = data3;
            l3.itemStyle = itemStyle;

            Line l4 = new Line(ads[3]);
            l4.stack = "总量";
            l4.data = data4;
            l4.itemStyle = itemStyle;

            Line l5 = new Line(ads[4]);
            l5.stack = "总量";
            l5.data = data5;
            l5.itemStyle = itemStyle;

            option.Series<Line>(l1, l2, l3, l4, l5);


            var result = JsonTools.ObjectToJson2(option);
            return result; 
        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("line5")]
        public string StdLine2()
        {
            IList<int> temp = ChartsUtil.Steps(6, -80, 20);
            IList<int> height = ChartsUtil.Datas(6, 0, 80);
           

            ChartOption option = new ChartOption();
            option.Legend("高度与气温变化关系");
            option.calculable = true;
            option.ToolTip().Trigger(TriggerType.axis)
                .Formatter(new JRaw("Temperature : <br/>{b}km : {c}°C").ToString());
            var x = new ValueAxis();
            x.AxisLabel().Formatter(new JRaw("{value} °C").ToString());
            option.XAxis(x);
            var y = new CategoryAxis();
            y.BoundaryGap(false);
            y.AxisLine().OnZero(false);
            y.AxisLabel().Formatter(new JRaw("{value} km").ToString());
            y.SetData(temp.Cast<object>().ToList());
            option.YAxis(y);
            var line = new Line("高度与气温变化关系");
            var itemStyle = new ItemStyle();
            itemStyle.Normal().LineStyle().ShadowColor("rgba(0,0,0,0,4)");
            line.Smooth(true);
            line.itemStyle = itemStyle;
            line.data = height;
            option.Series<Line>(line);
            var result = JsonTools.ObjectToJson2(option);
            return result;

        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("line6")]
        public string Area()
        {

            var times = ChartsUtil.TimeSteps(new DateTime(2009, 6, 12, 2, 0, 0), new DateTime(2009, 10, 18, 8, 0, 0), new TimeSpan(1, 0, 0));
         
            var flows = ChartsUtil.Flows();
            var rains = ChartsUtil.Rains();

            ChartOption option = new ChartOption();
            option.Title().Text("雨量流量关系图").SubText("数据来自西安兰特水电测控技术有限公司")
                .X(HorizontalType.center);

            option.ToolTip().Trigger(TriggerType.axis)
                .Formatter(new JRaw(@"function(params) {
                    return params[0].name + '<br/>'
                   + params[0].seriesName + ' : ' + params[0].value + ' (m^3/s)<br/>'
                   + params[1].seriesName + ' : ' + -params[1].value + ' (mm)';}"));
            option.Legend("流量", "降雨量").Legend().X(HorizontalType.left);

            option.DataZoom().Show(true).Realtime(true).Start(0).End(100);

            var x = new CategoryAxis();
            x.BoundaryGap(false).AxisLine().OnZero(false);
            x.SetData(times.Cast<object>().ToList());
            option.XAxis(x);

            var y1 = new ValueAxis();
            y1.Name("流量").Max(500);
            var y2 = new ValueAxis();
            y2.Name("降雨量").AxisLabel().Formatter(new JRaw("function(v){return -v;}"));
            option.YAxis(y1, y2);

            var itemStyle = new ItemStyle();
            itemStyle.Normal().AreaStyle().SetType(AreaStyleType.Default);
            var l1 = new Line("流量");
            l1.itemStyle = itemStyle;
            l1.data = flows;            

            var l2 = new Line("降雨量");
            l2.YAxisIndex(1);
            l2.itemStyle = itemStyle;
            l2.data = new JRaw(string.Format(@"(function(){{
                var oriData = [{0}]; 
                var len = oriData.length;
                while(len--) {{
                    oriData[len] *= -1;
                }}
                return oriData;}})()", string.Join(",", rains)));

            option.Series<Line>(l1, l2);

            var result = JsonTools.ObjectToJson2(option);
            return result;
        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("line7")]
        public string UnequalLine()
        {
            ChartOption option = new ChartOption();

            option.Title().Text("双数值轴折线").SubText("纯属虚构");
            option.ToolTip().Trigger(TriggerType.axis).Formatter(new JRaw(@"function (params) {
            return params.seriesName + ' : [ '
                   + params.value[0] + ', ' 
                   + params.value[1] + ' ]';
        }")).AxisPointer().Show(true).Type(AxisPointType.cross)
           .LineStyle().Type(LineStyleType.dashed).Width(1);
            option.Legend("数据1", "数据2");
            option.calculable = true;
            option.XAxis(new ValueAxis());
            var y = new ValueAxis();
            y.AxisLine().LineStyle().Color("#dc143c");
            option.YAxis(y);

            var l1 = new Line("数据1");
            l1.data = ChartsUtil.TowDatas(9, 2, 0, 20);
            var mp1 = new MarkData("最大值");
            mp1.Type(MarkType.max).Symbol("emptyCircle")
                .ItemStyle().Normal().Color("#dc143c").Label().Position(StyleLabelTyle.top);
            var mp2 = new MarkData("最小值");
            mp2.Type(MarkType.min).Symbol("emptyCircle")
                .ItemStyle().Normal().Color("#dc143c").Label().Position(StyleLabelTyle.bottom);
            var mp3 = new MarkData("最大值");
            mp3.Type(MarkType.max).Symbol("emptyCircle").ValueIndex(0)
                .ItemStyle().Normal().Color("#1e90ff").Label().Position(StyleLabelTyle.right);
            var mp4 = new MarkData("最小值");
            mp4.Type(MarkType.min).Symbol("emptyCircle").ValueIndex(0)
                .ItemStyle().Normal().Color("#1e90ff").Label().Position(StyleLabelTyle.left);
            l1.MarkPoint().Data(mp1,mp2,mp3,mp4);

            var ml1 = new MarkData("最大值");
            ml1.Type(MarkType.max)
                .ItemStyle().Normal().Color("#dc143c");
            var ml2 = new MarkData("最小值");
            ml2.Type(MarkType.min)
                .ItemStyle().Normal().Color("#dc143c");
            var ml3 = new MarkData("平均值");
            ml3.Type(MarkType.average)
                .ItemStyle().Normal().Color("#dc143c");
            var ml4 = new MarkData("最大值");
            ml4.Type(MarkType.max).ValueIndex(0)
                .ItemStyle().Normal().Color("#1e90ff");
            var ml5 = new MarkData("最小值");
            ml5.Type(MarkType.min).ValueIndex(0)
                .ItemStyle().Normal().Color("#1e90ff");
            var ml6 = new MarkData("平均值");
            ml6.Type(MarkType.average).ValueIndex(0)
              .ItemStyle().Normal().Color("#1e90ff");
            l1.MarkLine().Data(ml1, ml2, ml3, ml4, ml5, ml6);

            var l2 = new Line("数据2");
            l2.data = ChartsUtil.TowDatas(9, 2, 0, 20);
            option.Series<Line>(l1, l2);
            var result = JsonTools.ObjectToJson2(option);
            return result;
        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("line8")]
        public string TimeLine()
        {
            ChartOption option = new ChartOption();
            option.Title().Text("时间坐标折线图").SubText("dataZoom支持");
            option.ToolTip().Trigger(TriggerType.item)
                .Formatter(new JRaw(@"function (params) {
                    var date = new Date(params.value[0]);
                    data = date.getFullYear() + '-'
                           + (date.getMonth() + 1) + '-'
                           + date.getDate() + ' '
                           + date.getHours() + ':'
                           + date.getMinutes();
                    return data + '<br/>'
                           + params.value[1] + ', ' 
                           + params.value[2];
                }"));
            option.DataZoom().Show(true).Start(70);
            option.Legend().Data("series1");
            option.Grid().Y2(80);
            option.XAxis(new TimeAxis().SplitNumber(10));
            option.YAxis(new ValueAxis());
            var line = new Line("series1");
            line.showAllSymbol = true;
            line.symbolSize = new JRaw(@"function (value){
                return Math.round(value[2]/10) + 2;
            }");
            line.data = new JRaw(@" (function () {
                var d = [];
                var len = 0;
                var now = new Date();
                var value;
                while (len++ < 200) {
                    d.push([
                        new Date(2014, 9, 1, 0, len * 10000),
                        (Math.random()*30).toFixed(2) - 0,
                        (Math.random()*100).toFixed(2) - 0
                    ]);
                }
                return d;
            })()");

            option.Series<Line>(line);

            var result = JsonTools.ObjectToJson2(option);
            return result;
        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("line9")]
        public string LogLine()
        {

            ChartOption option = new ChartOption();
            option.Title().Text("对数轴示例").X(HorizontalType.center);
            option.ToolTip().Trigger(TriggerType.item).Formatter(new JRaw("{a} <br/>{b} : {c}").ToString());
            var legend = new Legend();
            legend.X(HorizontalType.left);
            legend.Data("2的指数", "3的指数");
            option.legend = legend;
            var x = new CategoryAxis();
            x.Name("x").SplitLine().Show(true);
            
            IList<string> baseDatas = ChartsUtil.Sequences(1, 9).ToList().ConvertAll(f=>f.ToString()).ToList();
            x.data= new List<object>(baseDatas);            
            option.XAxis(x);

            var y =new LogAxis();
            y.Name("y").LogLabelBase(3).SplitNumber(3);
            option.YAxis(y);

            var l1 = new Line("3的指数");
            l1.data = ChartsUtil.Exps(baseDatas.Count(), 3);
            var l2 = new Line("2的指数");
            l2.data = ChartsUtil.Exps(baseDatas.Count(), 2);
            option.Series<Line>(l1, l2);
            var result = JsonTools.ObjectToJson2(option);
            return result;
        }
        #endregion

        #region bar data

        [AcceptVerbs("GET", "POST")]
        [ActionName("bar1")]
        public string Column()
        {

            ChartOption option = new ChartOption();
            option.ToolTip().Trigger(TriggerType.axis)
               .AxisPointer().Type(AxisPointType.shadow);

            option.Legend("蒸发量", "降雨量");
            option.ToolBox(ToolBox());
            option.calculable = true;
            var x = new CategoryAxis();
            x.SetData(ChartsUtil.Months().Cast<object>().ToList());
            option.XAxis(x);
            var y = new ValueAxis();
            option.YAxis(y);
            var bar1 = new Bar("蒸发量");
            bar1.SetData(ChartsData.EvapsYear);
            bar1.MarkPoint().Data(new MarkData("最大值", MarkType.max), new MarkData("最小值", MarkType.min));
            bar1.MarkLine().Data(new MarkData("平均值", MarkType.average));

            var bar2 = new Bar("降水量");
            bar2.SetData(ChartsData.RainsYear);
            var mp1 = new MarkData("年最高");
            double rainMax = ChartsData.RainsYear.Max();
            mp1.value = rainMax;
            mp1.yAxis = rainMax + 0.5;
            mp1.xAxis = ChartsData.RainsYear.IndexOf(rainMax);
            mp1.symbolSize = 18;
            var mp2 = new MarkData("年最低");
            double rainMin = ChartsData.RainsYear.Min();
            mp2.Value(rainMin).YAxis(rainMin + 0.5).XAxis(ChartsData.RainsYear.IndexOf(rainMin));
            bar2.MarkPoint().Data(mp1, mp2);
            bar2.MarkLine().Data(new MarkData("平均值", MarkType.average));

            option.Series(bar1, bar2);

            var result = JsonTools.ObjectToJson2(option);
            return result;
        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("bar2")]
        public string HeapColumn()
        {
            IList<string> ads = ChartsUtil.Ads();
            IList<string> ses = ChartsUtil.Ses();
            IList<int> data1 = ChartsUtil.Datas(7, 90, 240);
            IList<int> data2 = ChartsUtil.Datas(7, 190, 310);
            IList<int> data3 = ChartsUtil.Datas(7, 150, 410);
            IList<int> data4 = ChartsUtil.Datas(7, 300, 400);
            IList<int> data5 = ChartsUtil.Datas(7, 820, 1400);
            IList<int> data6 = ChartsUtil.Datas(7, 600, 1200);
            IList<int> data7 = ChartsUtil.Datas(7, 80, 400);
            IList<int> data8 = ChartsUtil.Datas(7, 100, 300);
            ads.ToList().AddRange(ses);
            ChartOption option = new ChartOption();
            option.ToolTip().Trigger(TriggerType.axis);
            option.Legend().SetData(new List<object>(ads.ToList()));
            option.ToolBox(ToolBox(OrientType.vertical));
            option.ToolBox().X(HorizontalType.right).Y(HorizontalType.center);
            option.calculable = true;
            var x = new CategoryAxis();
            x.SetData(ChartsUtil.Weeks().Cast<object>().ToList());
            option.XAxis(x);
            var y = new ValueAxis();
            option.YAxis(y);
            Bar b1 = new Bar(ads[0]);
            b1.stack = "广告";
            b1.data = data1;

            Bar b2 = new Bar(ads[1]);
            b2.stack = "广告";
            b2.data = data2;

            Bar b3 = new Bar(ads[2]);
            b3.stack = "广告";
            b3.data = data3;

            Bar b4 = new Bar(ads[3]);
            var mk1 = new MarkLine();
            mk1.ItemStyle().Normal().LineStyle().Type(LineStyleType.dashed);
            mk1.Data(new MarkData(MarkType.min), new MarkData(MarkType.max));
            b4.markLine = mk1;
            b4.data = data4;

            Bar b5 = new Bar(ads[4]);
            b5.stack = "搜索引擎";
            b5.data = data5;

            Bar b6 = new Bar(ses[0]);
            b6.stack = "搜索引擎";
            b6.data = data6;

            Bar b7 = new Bar(ses[1]);
            b7.stack = "搜索引擎";
            b7.data = data7;

            Bar b8 = new Bar(ses[2]);
            b8.stack = "搜索引擎";
            b8.data = data8;

            // option.Series<Line>(l1, l2, l3, l4, l5);
            option.Series(b1, b2, b3, b4, b5, b6, b7, b8);

            var result = JsonTools.ObjectToJson2(option);
            return result;

        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("bar3")]
        public string StdBar()
        {
            ChartOption option = new ChartOption();
            option.Title().Text("世界人口总数").SubText("数据来源网络");
            option.ToolTip().Trigger(TriggerType.axis)
               .AxisPointer().Type(AxisPointType.shadow);
            option.Legend().Data("2011年", "2012年");
            option.ToolBox(ToolBox());
            option.calculable = true;
            var x = new ValueAxis();
            x.BoundaryGap(new List<double>() { 0, 0.01 });
            option.XAxis(x);
            var y = new CategoryAxis();
            y.SetData(new List<object>(ChartsUtil.Pops()));
            option.YAxis(y);
            var bar1 = new Bar("2011年");
            bar1.Data(18203, 23489, 29034, 104970, 131744, 630230);

            var bar2 = new Bar("2012年");
            bar2.Data(19325, 23438, 31000, 121594, 134141, 681807);

            option.Series(bar1, bar2);

            var result = JsonTools.ObjectToJson2(option);
            return result;
        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("bar4")]
        public string HeapBar()
        {
            IList<string> ads = ChartsUtil.Ads();
            IList<int> data1 = ChartsUtil.Datas(7, 90, 240);
            IList<int> data2 = ChartsUtil.Datas(7, 190, 310);
            IList<int> data3 = ChartsUtil.Datas(7, 150, 410);
            IList<int> data4 = ChartsUtil.Datas(7, 300, 400);
            IList<int> data5 = ChartsUtil.Datas(7, 820, 1400);

            ChartOption option = new ChartOption();

            option.ToolTip().Trigger(TriggerType.axis).AxisPointer().Type(AxisPointType.shadow);
            option.Legend().SetData(new List<object>(ads.ToList()));
            option.ToolBox(ToolBox());

            option.calculable = true;
            var x = new ValueAxis();
            option.XAxis(x);

            var y = new CategoryAxis();
            y.data = new List<object>(ChartsUtil.Weeks());
            option.YAxis(y);

            var itemStyle = new ItemStyle();
            itemStyle.Normal().Label().Show(true).Position(StyleLabelTyle.insideRight);

            Bar b1 = new Bar(ads[0]);
            b1.stack = "总量";
            b1.itemStyle = itemStyle;
            b1.data = data1;

            Bar b2 = new Bar(ads[1]);
            b2.stack = "总量";
            b2.itemStyle = itemStyle;
            b2.data = data2;

            Bar b3 = new Bar(ads[2]);
            b3.stack = "总量";
            b3.itemStyle = itemStyle;
            b3.data = data3;

            Bar b4 = new Bar(ads[3]);
            b4.stack = "总量";
            b4.itemStyle = itemStyle;
            b4.data = data4;

            Bar b5 = new Bar(ads[4]);
            b5.stack = "总量";
            b5.itemStyle = itemStyle;
            b5.data = data5;



            // option.Series<Line>(l1, l2, l3, l4, l5);
            option.Series(b1, b2, b3, b4, b5);

            var result = JsonTools.ObjectToJson2(option);
            return result;

        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("bar5")]
        public string StdWhirlwindBar()
        {
            IList<int> data1 = ChartsUtil.Datas(7, 220, 240);
            IList<int> data2 = ChartsUtil.Datas(7, 300, 500);
            IList<int> data3 = ChartsUtil.Datas(7, -250, -100);

            ChartOption option = new ChartOption();

            option.ToolTip().Trigger(TriggerType.axis).AxisPointer().Type(AxisPointType.shadow);
            option.Legend().Data("利润", "支出", "收入");

            Feature feature = new Feature();
            feature.Mark().Show(true);
            feature.DataView().Show(true).ReadOnly(false);
            feature.MagicType().Show(true).Type("line", "bar");
            feature.Restore().Show(true);
            feature.SaveAsImage().Show(true);            
            option.ToolBox().Show(true).SetFeature(feature);
            option.Calculable(true);
            ValueAxis x = new ValueAxis();
            option.XAxis(x);

            CategoryAxis y = new CategoryAxis();
            y.AxisTick().Show(false);
            y.SetData(ChartsUtil.Weeks().Cast<object>().ToList());
            option.YAxis(y);

            Bar b1 = new Bar("利润");
            b1.ItemStyle().Normal().Label().Show(true).Position(StyleLabelTyle.inside);
            b1.data = data1;

            Bar b2 = new Bar("收入");
            b2.Stack("总量").BarWidth(5).
                ItemStyle().Normal().Label().Show(true);
            b2.data = data2;

            Bar b3 = new Bar("支出");
            b3.Stack("总量").
                ItemStyle().Normal().Label().Show(true).Position(StyleLabelTyle.left);
            b3.data = data3;
            option.Series(b1, b2, b3);
            var result = JsonTools.ObjectToJson2(option);
            return result;

        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("bar6")]
        public string VaryWaterfallBar()
        {
            ChartOption option = new ChartOption();
            option.Title().Text("阶梯瀑布图").Subtext("Form ExcelHome").
                Sublink("http://e.weibo.com/1341556070/Aj1J2x5a5");
            option.ToolTip().Trigger(TriggerType.axis)
                .Formatter(new JRaw(@"function (params) {
                    var tar;
                    if (params[1].value != '-') {
                        tar = params[1];
                    }
                    else {
                        tar = params[0];
                    }
                    return tar.name + '<br/>' + tar.seriesName + ' : ' + tar.value;
                  }"))
                .AxisPointer().Type(AxisPointType.shadow);
            option.Legend().Data("支出", "收入");
            Feature feature = new Feature();
            feature.Mark().Show(true);
            feature.DataView().Show(true).ReadOnly(false);
            feature.MagicType().Show(true).Type("line", "bar");
            feature.Restore().Show(true);
            feature.SaveAsImage().Show(true);
            option.ToolBox().Show(true).SetFeature(feature);
            CategoryAxis x = new CategoryAxis();
            x.SplitLine().Show(true);
            x.data = new JRaw(@"function (){
                var list = [];
                for (var i = 1; i <= 11; i++) {
                    list.push('11月' + i + '日');
                }
                return list;
            }()");
            option.XAxis(x);
            option.YAxis(new ValueAxis());
            Bar b1 = new Bar("辅助");
            b1.Stack("总量");
            var itemStyle = new ItemStyle();
            itemStyle.Normal().BarBorderColor("rgba(0,0,0,0)").Color("rgba(0,0,0,0)");
            itemStyle.Emphasis().BarBorderColor("rgba(0,0,0,0)").Color("rgba(0,0,0,0)");
            b1.SetItemStyle(itemStyle);
            b1.Data(0, 900, 1245, 1530, 1376, 1376, 1511, 1689, 1856, 1495, 1292);

            Bar b2 = new Bar("收入");
            b2.Stack("总量");
            b2.ItemStyle().Normal().Label().Show(true).Position(StyleLabelTyle.top);
            b2.Data(900, 345, 393, "-", "-", 135, 178, 286, "-", "-", "-");

            Bar b3 = new Bar("支出");
            b3.Stack("总量");
            b3.ItemStyle().Normal().Label().Show(true).Position(StyleLabelTyle.bottom);
            b3.Data("-", "-", "-", 108, 154, "-", "-", "-", 119, 361, 203);

            option.Series(b1, b2, b3);

            var result = JsonTools.ObjectToJson2(option);
            return result;
        }


        [AcceptVerbs("GET", "POST")]
        [ActionName("bar7")]
        public string CompWaterfallBar()
        {
            ChartOption option = new ChartOption();
            option.Title().Text("深圳月最低生活费组成（单位:元）").Subtext("Form ExcelHome").
                Sublink("http://e.weibo.com/1341556070/AjQH99che");
            option.ToolTip().Trigger(TriggerType.axis)
                .Formatter(new JRaw(@"function (params) {
            var tar = params[0];
            return tar.name + '<br/>' + tar.seriesName + ' : ' + tar.value;
                }"))
                .AxisPointer().Type(AxisPointType.shadow);
            
            Feature feature = new Feature();
            feature.Mark().Show(true);
            feature.DataView().Show(true).ReadOnly(false);
            feature.MagicType().Show(true).Type("line", "bar");
            feature.Restore().Show(true);
            feature.SaveAsImage().Show(true);
            option.ToolBox().Show(true).SetFeature(feature);
            CategoryAxis x = new CategoryAxis();
            x.SplitLine().Show(true);
            x.Data("总费用", "房租", "水电费", "交通费", "伙食费", "日用品数");
            option.XAxis(x);
            option.YAxis(new ValueAxis());
            Bar b1 = new Bar("辅助");
            b1.Stack("总量");
            var itemStyle = new ItemStyle();
            itemStyle.Normal().BarBorderColor("rgba(0,0,0,0)").Color("rgba(0,0,0,0)");
            itemStyle.Emphasis().BarBorderColor("rgba(0,0,0,0)").Color("rgba(0,0,0,0)");
            b1.SetItemStyle(itemStyle);
            b1.Data(0, 1700, 1400, 1200, 300, 0);

            Bar b2 = new Bar("生活费");
            b2.Stack("总量");
            b2.ItemStyle().Normal().Label().Show(true).Position(StyleLabelTyle.top);
            b2.Data(2900, 1200, 300, 200, 900, 300);            

            option.Series(b1, b2);

            var result = JsonTools.ObjectToJson2(option);
            return result;
        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("bar8")]
        public string WhirlwindBar()
        {
            ChartOption option = new ChartOption();
            option.Title().Text("多维条形图").Subtext("Form ExcelHome").
                Sublink("http://e.weibo.com/1341556070/AiEscco0H");

            option.ToolTip().Trigger(TriggerType.axis)
               .AxisPointer().Type(AxisPointType.shadow);
            Feature feature = new Feature();
            feature.Mark().Show(true);
            feature.DataView().Show(true).ReadOnly(false);
            feature.MagicType().Show(true).Type("line", "bar");
            feature.Restore().Show(true);
            feature.SaveAsImage().Show(true);
            option.ToolBox().Show(true).SetFeature(feature);
            option.Grid().Y(80).Y2(30);
            ValueAxis x = new ValueAxis();
            x.Position(PositionType.top);
            x.SplitLine().LineStyle().Type(LineStyleType.dashed);
            option.XAxis(x);
            CategoryAxis y = new CategoryAxis();
            y.AxisLabel().Show(true);
            y.AxisLine().Show(true);
            y.AxisTick().Show(true);
            y.SplitLine().Show(true);
            y.Data("ten", "nine", "eight", "seven", "six", "five", "four", "three", "two", "one");
            option.YAxis(y);

            Bar b1 = new Bar("生活费");
            b1.Stack("总量");
            var itemStyle = new ItemStyle();
            itemStyle.Normal().Color("orange").BarBorderRadius(5)
                .Label().Show(true).Position(StyleLabelTyle.left).Formatter("{b}");
            b1.SetItemStyle(itemStyle);
            var labelRight = new ItemStyle();
            labelRight.Normal().Label().Position(StyleLabelTyle.right);
            SeriesData<double> sd1 = new SeriesData<double>(-0.07, labelRight);
            SeriesData<double> sd2 = new SeriesData<double>(-0.09, labelRight);
            SeriesData<double> sd3 = new SeriesData<double>(0.2);
            SeriesData<double> sd4 = new SeriesData<double>(0.44);
            SeriesData<double> sd5 = new SeriesData<double>(-0.23, labelRight);
            SeriesData<double> sd6 = new SeriesData<double>(0.08);
            SeriesData<double> sd7 = new SeriesData<double>(-0.17, labelRight);
            SeriesData<double> sd8 = new SeriesData<double>(0.47);
            SeriesData<double> sd9 = new SeriesData<double>(-0.36, labelRight);
            SeriesData<double> sd10 = new SeriesData<double>(0.18);
            b1.Data(sd1, sd2, sd4, sd5, sd6, sd7, sd8, sd9, sd10);
            option.Series(b1);
            var result = JsonTools.ObjectToJson2(option);
            return result;
        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("bar10")]
        public string TemperatureBar()
        {
            ChartOption option = new ChartOption();
            option.Title().Text("温度计式图表").Subtext("Form ExcelHome").
                Sublink("http://e.weibo.com/1341556070/AizJXrAEa");
            option.ToolTip().Trigger(TriggerType.axis)
             .Formatter(new JRaw(@"function (params){
            return params[0].name + '<br/>'
                   + params[0].seriesName + ' : ' + params[0].value + '<br/>'
                   + params[1].seriesName + ' : ' + (params[1].value + params[0].value);
            }"))
             .AxisPointer().Type(AxisPointType.shadow);
            option.Legend().Data("Acutal","Forecast");
            Feature feature = new Feature();
            feature.Mark().Show(true);
            feature.DataView().Show(true).ReadOnly(false);
            feature.Restore().Show(true);
            feature.SaveAsImage().Show(true);
            option.ToolBox().Show(true).SetFeature(feature);
            option.Grid().Y(80).Y2(30);
            CategoryAxis x = new CategoryAxis();
            x.Data("Cosco", "CMA", "APL", "OOCL", "Wanhai", "Zim");
            option.XAxis(x);
            ValueAxis y = new ValueAxis();
            y.BoundaryGap(new List<double>() { 0,0.1 });           
            option.YAxis(y);

            var tomatoStyle = new ItemStyle();
            tomatoStyle.Normal().Color("tomato").BarBorderRadius(0)
                .BarBorderColor("tomato").BarBorderWidth(6)
                .Label().Show(true).Position(StyleLabelTyle.insideTop);
            Bar b1 = new Bar("Acutal");
            b1.Stack("sum");
            b1.SetItemStyle(tomatoStyle);            
            b1.Data(260, 200, 220, 120, 100, 80);

            var forecastStyle = new ItemStyle();
            forecastStyle.Normal().Color("#fff").BarBorderRadius(0)
                .BarBorderColor("tomato").BarBorderWidth(6)
                .Label().Show(true).Position(StyleLabelTyle.top)
                .Formatter(new JRaw(@"function (params) {
                            for (var i = 0, l = option.xAxis[0].data.length; i < l; i++) {
                                if (option.xAxis[0].data[i] == params.name) {
                                    return option.series[0].data[i] + params.value;
                                }
                            }
                        }"))
                        .TextStyle().Color("tomato");

            Bar b2 = new Bar("Forecast");
            b2.Stack("sum");
            b2.SetItemStyle(forecastStyle);
            b2.Data(40, 80, 50, 80, 80, 70);

            option.Series(b1, b2);

            var result = JsonTools.ObjectToJson2(option);
            return result;
        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("bar11")]
        public string TimeColumn()
        {
            TimeLine time = new ECharts.Entities.TimeLine();
            time.Data("2002-01-01", "2003-01-01", "2004-01-01", "2005-01-01", "2006-01-01",
            "2007-01-01", "2008-01-01", "2009-01-01", "2010-01-01")
            .AutoPlay(true).PlayInterval(1000);
            time.Label().Formatter(new JRaw(@" function(s) {
                return s.slice(0, 4);
            }"));


          

            ChartOption option = new ChartOption();
            option.timeline = time;            

            ChartOption option1 = new ChartOption();
            option1.Title().Text("2002全国宏观经济指标").Subtext("数据来自国家统计局");
            option1.ToolTip().Trigger(TriggerType.axis);

            Dictionary<string, bool> selected = new Dictionary<string, bool>();
            selected.Add("GDP", true);
            selected.Add("金融", false);
            selected.Add("房地产", true);
            selected.Add("第一产业", false);
            selected.Add("第二产业", false);
            selected.Add("第三产业", false);
            option1.Legend().Data("GDP", "金融", "房地产", "第一产业", "第二产业", "第三产业")
                .X(HorizontalType.left).SetSelected(selected).X(HorizontalType.right);

            Feature feature = new Feature();
            feature.Mark().Show(true);
            feature.DataView().Show(true).ReadOnly(false);
            feature.Restore().Show(true);
            feature.SaveAsImage().Show(true);
            feature.MagicType().Show(true).Type("line", "bar", "stack", "tiled");
            option1.ToolBox().Show(true).Orient(OrientType.vertical)
                .X(HorizontalType.right).Y(HorizontalType.center).SetFeature(feature);                      
            option1.Grid().Y(80).Y2(100);

            CategoryAxis x = new CategoryAxis();
            x.Data("北京", "\n天津", "河北", "\n山西", "内蒙古", "\n辽宁", "吉林", "\n黑龙江",
                    "上海", "\n江苏", "浙江", "\n安徽", "福建", "\n江西", "山东", "\n河南",
                    "湖北", "\n湖南", "广东", "\n广西", "海南", "\n重庆", "四川", "\n贵州",
                    "云南", "\n西藏", "陕西", "\n甘肃", "青海", "\n宁夏", "新疆");
            x.AxisLabel().Interval(0);
            option1.XAxis(x);

            option1.Calculable(true);

            ValueAxis y1 = new ValueAxis();
            y1.Name("GDP(亿元)").Max(53500);
            ValueAxis y2 = new ValueAxis();
            y2.Name("其他(亿元)");            
            option1.YAxis(y1,y2);

            var lStyle = new LineStyle();
            lStyle.Color("orange");

            var mlStyle = new ItemStyle();            
            mlStyle.Normal().SetLineStyle(lStyle)
                .BarBorderColor("orange")
                .Label().Show(true).Position(StyleLabelTyle.left)
                .Formatter(new JRaw(@"function(params){
                                        return Math.round(params.value);
                                    }")).TextStyle().Color("orange");
            var ml = new MarkLine();
            ml.Symbol(new List<string>() { "arrow", "none" })
                .SetItemStyle(mlStyle);
            ml.symbolSize = new List<int> { 4, 2 };           
            ml.Data(new MarkData() { type = MarkType.average, name = "平均值" });

            Bar b1 = new Bar("GDP");            
            b1.markLine = ml;
            b1.data = new JRaw(@"dataMap.dataGDP['2002']");                       

            Bar b2 = new Bar("金融");
            b2.yAxisIndex = 1;         
            b2.data = new JRaw(@"dataMap.dataFinancial['2002']");


            Bar b3 = new Bar("房地产");
            b3.yAxisIndex = 1;
            b3.data =new JRaw(@"dataMap.dataEstate['2002']");


            Bar b4 = new Bar("第一产业");
            b4.yAxisIndex = 1;
            b4.data = new JRaw(@"dataMap.dataPI['2002']");


            Bar b5 = new Bar("第二产业");
            b5.yAxisIndex = 1;
            b5.data = new JRaw(@"dataMap.dataSI['2002']");


            Bar b6 = new Bar("第三产业");
            b6.yAxisIndex = 1;
            b6.data = new JRaw(@"dataMap.dataTI['2002']");

            option1.Series(b1, b2, b3, b4, b5, b6);

            IList<string> providers = new List<string>() {
                "dataMap.dataGDP",
                "dataMap.dataFinancial",
                "dataMap.dataEstate",
                "dataMap.dataPI",
                "dataMap.dataSI",
                "dataMap.dataTI"
            };


            ChartOption option2 = new ChartOption();
            option2.Title().Text("2003全国宏观经济指标");
            var d1 = ChartsUtil.EconDatas(2003, providers);

            option2.series = d1.Cast<object>().ToList();

            ChartOption option3 = new ChartOption();
            option3.Title().Text("2004全国宏观经济指标");
            var d2 = ChartsUtil.EconDatas(2004, providers);
                        
            option3.series = d2.Cast<object>().ToList(); 

            ChartOption option4 = new ChartOption();
            option4.Title().Text("2005全国宏观经济指标");

            var d3 = ChartsUtil.EconDatas(2005, providers);

            option4.series = d3.Cast<object>().ToList();

            ChartOption option5 = new ChartOption();
            option5.Title().Text("2006全国宏观经济指标");
            var d4 = ChartsUtil.EconDatas(2006, providers);

            option5.series = d4.Cast<object>().ToList();

            ChartOption option6 = new ChartOption();
            option6.Title().Text("2007全国宏观经济指标");
            var d5 = ChartsUtil.EconDatas(2007, providers);

            option6.series = d5.Cast<object>().ToList();

            ChartOption option7 = new ChartOption();
            option7.Title().Text("2008全国宏观经济指标");
            var d6 = ChartsUtil.EconDatas(2008, providers);

            option7.series = d6.Cast<object>().ToList();

            ChartOption option8 = new ChartOption();
            option8.Title().Text("2009全国宏观经济指标");
            var d7 = ChartsUtil.EconDatas(2009, providers);

            option8.series = d7.Cast<object>().ToList();

            ChartOption option9 = new ChartOption();
            option9.Title().Text("2010全国宏观经济指标");
            var d8 = ChartsUtil.EconDatas(2010, providers);

            option9.series = d8.Cast<object>().ToList();

            var options = new List<ChartOption>() {
                 option1,option2,option3,option4,option5,option7,
                 option8,option9
            };

            option.options = options;

            var result = JsonTools.ObjectToJson2(option);
            return result;
        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("bar12")]
        public string MultiLayerColumn()
        {
            ChartOption option = new ChartOption();
            option.Title().Text("ECharts2 vs ECharts1").SubText("Chrome下测试数据");
            option.ToolTip().Trigger(TriggerType.axis);             
            option.Legend().Data("ECharts1 - 2k数据", "ECharts1 - 2w数据", "ECharts1 - 20w数据", "",
            "ECharts2 - 2k数据", "ECharts2 - 2w数据", "ECharts2 - 20w数据");
            Feature feature = new Feature();
            feature.Mark().Show(true);
            feature.DataView().Show(true).ReadOnly(false);
            feature.Restore().Show(true);
            feature.SaveAsImage().Show(true);
            feature.MagicType().Show(true).Type("line", "bar");
            option.ToolBox().Show(true).SetFeature(feature);

            option.calculable = true;
            option.Grid().Y(70).Y2(30).X2(20);

            var x1 = new CategoryAxis();
            x1.Data("Line", "Bar", "Scatter", "K", "Map");
            var x2 = new CategoryAxis();
            x2.AxisLine().Show(false);
            x2.AxisTick().Show(false);
            x2.AxisLabel().Show(false);
            x2.SplitArea().Show(false);
            x2.SplitLine().Show(false);
            x2.Data("Line", "Bar", "Scatter", "K", "Map");
            option.XAxis(x1,x2);

            var y = new ValueAxis();
            y.AxisLabel().Formatter(@"{value} ms");
            option.YAxis(y);

            var bar1 = new Bar("ECharts2 - 2k数据");
            bar1.ItemStyle().Normal().Color("rgba(193,35,43,1)").Label().Show(true);                
            bar1.Data(40, 155, 95, 75, 0);

            var bar2 = new Bar("ECharts2 - 2w数据");
            bar2.ItemStyle().Normal().Color("rgba(181,195,52,1)").Label().Show(true)
                .TextStyle().Color("#27727B");
            bar2.Data(100, 200, 105, 100, 156);

            var bar3 = new Bar("ECharts2 - 20w数据");
            bar3.ItemStyle().Normal().Color("rgba(252,206,16,1)").Label().Show(true)
                .TextStyle().Color("#E87C25");
            bar3.Data(906, 911, 908, 778, 0);

            var bar4 = new Bar("ECharts1 - 2k数据");
            bar4.XAxisIndex(1);
            bar4.ItemStyle().Normal().Color("rgba(193,35,43,0.5)").Label().Show(true)
                .Formatter(new JRaw(@"function(p){return p.value > 0 ? (p.value +'\n'):'';}"));                
            bar4.Data(96, 224, 164, 124, 0);

            var bar5 = new Bar("ECharts1 - 2w数据");
            bar5.XAxisIndex(1);
            bar5.ItemStyle().Normal().Color("rgba(181,195,52,0.5)").Label().Show(true);                
            bar5.Data(491, 2035, 389, 955, 347);

            var bar6 = new Bar("ECharts1 - 20w数据");
            bar6.XAxisIndex(1);
            bar6.ItemStyle().Normal().Color("rgba(181,195,52,0.5)").Label().Show(true)
                .Formatter(new JRaw(@"function(p){return p.value > 0 ? (p.value +'\n'):'';}"));
            bar6.Data(3000, 3000, 2817, 3000, 0);
            option.Series(bar1, bar2, bar3, bar4, bar5, bar6);

            var result = JsonTools.ObjectToJson2(option);
            return result;
        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("bar13")]
        public string UnequalBar()
        {
            ChartOption option = new ChartOption();
            option.Title().Text("双数值柱形图").Subtext("纯属虚构");

            option.ToolTip().Trigger(TriggerType.axis)
                .Formatter(new JRaw(@"function (params) {
                    return params.seriesName + ' : [ '
                           + params.value[0] + ', ' 
                           + params.value[1] + ' ]';
                }"))
               .AxisPointer().Show(true).Type(AxisPointType.cross)
               .LineStyle().Type(LineStyleType.dashed).Width(1);
            option.Legend("数据1","数据2");
            Feature feature = new Feature();
            feature.Mark().Show(true);
            feature.DataView().Show(true).ReadOnly(false);
            feature.MagicType().Show(true).Type("line", "bar");
            feature.Restore().Show(true);
            feature.SaveAsImage().Show(true);
            option.ToolBox().Show(true).SetFeature(feature);
            option.Grid().Y(80).Y2(30);
            option.Calculable(true);
            ValueAxis x = new ValueAxis();          
            option.XAxis(x);
            ValueAxis y = new ValueAxis();
            y.AxisLine().Show(true).LineStyle().Color("#dc143c");
            option.YAxis(y);

            Bar b1 = new Bar("数据1");
            double[,] datas = new double[,] {  {1.5, 10}, {5, 7}, {8, 8}, {12, 6}, {11, 12}, {16, 9}, {14, 6}, {17, 4}, {19, 9} };
            b1.data = datas;
            //纵轴
            var md1 = new MarkData("最大值", MarkType.max);
            md1.Symbol("emptyCircle").ItemStyle().Normal().Color("#dc143c").Label().Position(StyleLabelTyle.top);
            var md2 = new MarkData("最小值", MarkType.min);
            md2.Symbol("emptyCircle").ItemStyle().Normal().Color("#dc143c").Label().Position(StyleLabelTyle.bottom);
            //横轴
            var md3 = new MarkData("最大值", MarkType.max);
            md3.Symbol("emptyCircle").ValueIndex(0).ItemStyle().Normal().Color("#1e90ff").Label().Position(StyleLabelTyle.left);
            var md4 = new MarkData("最小值", MarkType.min);
            md4.Symbol("emptyCircle").ValueIndex(0).ItemStyle().Normal().Color("#1e90ff").Label().Position(StyleLabelTyle.right);
            b1.MarkPoint().Data(md1, md2, md3, md4);
                      
            var data2 = new[,] { { 1, 2 }, { 2, 3 }, { 4, 4 }, { 7, 5 }, { 11, 11 }, { 18, 15 } };
            var b2 = new Bar("数据2");
            b2.BarWidth(10);
            b2.data = data2;
            //纵轴
            var md5 = new MarkData("最大值", MarkType.max);
            md5.ItemStyle().Normal().Color("#dc143c");
            var md6 = new MarkData("最小值", MarkType.min);
            md6.ItemStyle().Normal().Color("#dc143c");
            var md7 = new MarkData("平均值", MarkType.average);
            md7.ItemStyle().Normal().Color("#dc143c");
            //横轴
            var md8 = new MarkData("最大值", MarkType.max);
            md8.ValueIndex(0).ItemStyle().Normal().Color("#dc143c");
            var md9 = new MarkData("最小值", MarkType.min);
            md9.ValueIndex(0).ItemStyle().Normal().Color("#dc143c");
            var md10 = new MarkData("平均值", MarkType.average);
            md10.ValueIndex(0).ItemStyle().Normal().Color("#dc143c");
            b2.MarkLine().Data(md5, md6, md7, md8, md9, md10);
            option.Series(b1,b2);
            var result = JsonTools.ObjectToJson2(option);
            return result;
        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("bar14")]
        public string RainbowColumn()
        {
            ChartOption option = new ChartOption();
            option.Title().X(HorizontalType.center)
                .Text("ECharts例子个数统计").SubText("Rainbow bar example")
                .Link("http://echarts.baidu.com/doc/example.html");
            option.ToolTip().Trigger(TriggerType.item);
          
            Feature feature = new Feature();
            
            feature.DataView().Show(true).ReadOnly(false);
            feature.Restore().Show(true);
            feature.SaveAsImage().Show(true);
         
            option.ToolBox().Show(true).SetFeature(feature);

            option.calculable = true;
            option.Grid().Y(80).Y2(80).BorderWidth(0);

            var x1 = new CategoryAxis();
            x1.Data("Line", "Bar", "Scatter", "K", "Pie", "Radar", "Chord", "Force", "Map", "Gauge", "Funnel");
            x1.Show(false);           
            option.XAxis(x1);

            var y = new ValueAxis();
            y.Show(false);
            option.YAxis(y);

            var bar1 = new Bar("ECharts例子个数统计");
            
            bar1.Data(12, 21, 10, 4, 12, 5, 6, 5, 25, 23, 7);

            var style = new ItemStyle();
            style.Normal().Color(new JRaw(@"function(params) {                        
                        var colorList = [
                          '#C1232B','#B5C334','#FCCE10','#E87C25','#27727B',
                           '#FE8463','#9BCA63','#FAD860','#F3A43B','#60C0DD',
                           '#D7504B','#C6E579','#F4E001','#F0805A','#26C0C0'
                        ];
                        return colorList[params.dataIndex]
                    }"))
                    .Label().Show(true).Position(StyleLabelTyle.top).Formatter(@"{b}\n{c}");
            bar1.SetItemStyle(style);

            var mp = new MarkPoint();
            mp.ToolTip().Trigger(TriggerType.item)
                .BackgroundColor("rgba(0,0,0,0)")
                .Formatter(new JRaw(@"function(params){
                        return '<img src=""' 
                                + params.data.symbol.replace('image://', '')
                                + '""/>';
                }"));
            var md = new MarkData("Line");
            md.XAxis(0).Y(350).Symbol("image://../asset/ico/折线图.png");
            var md1 = new MarkData("Bar");
            md1.XAxis(1).Y(350).Symbol("image://../asset/ico/柱状图.png");
            var md2 = new MarkData("Scatter");
            md2.XAxis(2).Y(350).Symbol("image://../asset/ico/散点图.png");
            var md3 = new MarkData("K");
            md3.XAxis(3).Y(350).Symbol("image://../asset/ico/K线图.png");
            var md4 = new MarkData("Pie");
            md4.XAxis(4).Y(350).Symbol("image://../asset/ico/饼状图.png");
            var md5 = new MarkData("Radar");
            md5.XAxis(5).Y(350).Symbol("image://../asset/ico/雷达图.png");
            var md6 = new MarkData("Chord");
            md6.XAxis(6).Y(350).Symbol("image://../asset/ico/和弦图.png");
            var md7 = new MarkData("Force");
            md7.XAxis(7).Y(350).Symbol("image://../asset/ico/力导向图.png");
            var md8 = new MarkData("Map");
            md8.XAxis(8).Y(350).Symbol("image://../asset/ico/地图.png");
            var md9 = new MarkData("Gauge");
            md9.XAxis(9).Y(350).Symbol("image://../asset/ico/仪表盘.png");
            var md10 = new MarkData("Funnel");
            md10.XAxis(10).Y(350).Symbol("image://../asset/ico/漏斗图.png");
            option.Series(bar1);

            var result = JsonTools.ObjectToJson2(option);
            return result;
        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("bar15")]
        public string MultiRainbowColumn()
        {
            ChartOption option = new ChartOption();

            var colorList = new List<string> { "#ff7f50","#87cefa","#da70d6","#32cd32","#6495ed",
                 "#ff69b4","#ba55d3","#cd5c5c","#ffa500","#40e0d0"
            };
        

            option.Title().X(HorizontalType.center)
                .Text("2010-2013年中国城镇居民家庭人均消费构成（元）")
                .SubText("数据来自国家统计局")
                .Link("http://data.stats.gov.cn/search/keywordlist2?keyword=%E5%9F%8E%E9%95%87%E5%B1%85%E6%B0%91%E6%B6%88%E8%B4%B9");
            option.ToolTip().Trigger(TriggerType.axis)
                .BackgroundColor("rgba(255,255,255,0.7)")
                .Formatter(new JRaw(@"function(params) {
            // for text color
            var color = colorList[params[0].dataIndex];
            var res = '<div style=""color:' + color + '"">';
            res += '<strong>' + params[0].name + '消费（元）</strong>'
            for (var i = 0, l = params.length; i < l; i++) {
                res += '<br/>' + params[i].seriesName + ' : ' + params[i].value 
            }
            res += '</div>';
            return res;
            }"))
           .AxisPointer().Type(AxisPointType.shadow);
            option.Legend().X(HorizontalType.right).Data("2010","2011","2012","2013");

            Feature feature = new Feature();
            feature.Mark().Show(true);
            feature.DataView().Show(true).ReadOnly(false);
            feature.Restore().Show(true);
            feature.SaveAsImage().Show(true);
            option.ToolBox().Show(true)
                .Orient(OrientType.vertical).Y(HorizontalType.center)
                .SetFeature(feature);

            option.calculable = true;
            option.Grid().Y(80).Y2(40).X2(40);

            var x1 = new CategoryAxis();
            x1.Data("食品", "衣着", "居住", "家庭设备及用品", "医疗保健", "交通和通信", "文教娱乐服务", "其他");            
            option.XAxis(x1);

            var y = new ValueAxis();          
            option.YAxis(y);

            var bar1 = new Bar("2010");
            bar1.Data(4804.7, 1444.3, 1332.1, 908, 871.8, 1983.7, 1627.6, 499.2);

            var bar2 = new Bar("2011");
            bar2.Data(5506.3, 1674.7, 1405, 1023.2, 969, 2149.7, 1851.7, 581.3);

            var bar3 = new Bar("2012");
            bar3.Data(6040.9, 1823.4, 1484.3, 1116.1, 1063.7, 2455.5, 2033.5, 657.1);

            var bar4 = new Bar("2013");
            bar4.Data(6311.9, 1902, 1745.1, 1215.1, 1118.3, 2736.9, 2294, 699.4);


            option.Series(bar1, bar2, bar3, bar4);

            var result = JsonTools.ObjectToJson2(option);
            return result;
        }


        [AcceptVerbs("GET", "POST")]        
        public string Bar()
        {
            ChartOption option = new ChartOption();

            option.ToolTip().Trigger(TriggerType.axis);               
            option.Legend().Data("邮件营销", "联盟广告", "直接访问", "搜索引擎");

            Feature feature = new Feature();
            feature.Mark().Show(true);
            feature.DataView().Show(true).ReadOnly(false);
            feature.Restore().Show(true);
            feature.MagicType().Show(true).Type("line", "bar", "stack", "tiled");
            feature.SaveAsImage().Show(true);
            option.ToolBox().Show(true)
                .SetFeature(feature);
            
            option.calculable = true;
            var x = new CategoryAxis();
            x.Data("周一", "周二", "周三", "周四", "周五", "周六", "周日");
            option.XAxis(x);
            var y = new ValueAxis();        
            option.YAxis(y);

            var style = new ItemStyle();
            style.Normal().BarBorderColor("red").BarBorderWidth(5)
                .Color(new JRaw(@"(function (){
                        var zrColor = require('zrender/tool/color');
                        return zrColor.getLinearGradient(
                            0, 400, 0, 300,
                            [[0, 'green'],[1, 'yellow']]
                        )
                    })()"));
            style.Emphasis().BarBorderColor("green").BarBorderWidth(5)
                .Color(new JRaw(@"(function (){
                        var zrColor = require('zrender/tool/color');
                        return zrColor.getLinearGradient(
                            0, 400, 0, 300,
                            [[0, 'red'],[1, 'orange']]
                        )
                    })()"))
                    .Label().Show(true).Position(StyleLabelTyle.top).Formatter("{a}{b}{c}")
                    .TextStyle().Color("blue");            

            var bar1 = new Bar("邮件营销");
            bar1.SetItemStyle(style);
            bar1.Data(220, 232, 101, 234, 190, 330, 210);
            
            var bar2 = new Bar("联盟广告");
            bar2.Stack("总量");
            bar2.Data(120, '-', 451, 134, 190, 230, 110);

            var style2 = new ItemStyle();
            style2.Normal().BarBorderColor("tomato").BarBorderWidth(6).Color("red");
            style2.Emphasis().BarBorderColor("red").Color("blue");

            var style3 = new ItemStyle();
            style3.Normal().Color("lime");
            style3.Emphasis().Color("skyBlue");
            var bar3 = new Bar("直接访问");
            bar3.Stack("总量");
            bar3.SetItemStyle(style2);
            var sd = new SeriesData<int>(390,style3);
            sd.SymbolSize(10);            
            bar3.Data(320, 332, 100, 334, sd, 330, 320);


            var style4 = new ItemStyle();
            style4.Normal().Label().Position(StyleLabelTyle.inside);
            var sd2 = new SeriesData<int>(701, style4);
            var bar4 = new Bar("搜索引擎");
            bar4.Stack("总量");
            bar4.BarWidth(40);
            bar4.ItemStyle().Normal().BarBorderRadius(5).Label()
                .Show(true).TextStyle().FontSize(20).FontFamily("微软雅黑").FontWeight("bold");
         
            bar4.MarkLine().Data(new MarkData("平均值", MarkType.average), new MarkData(MarkType.max),
                new MarkData(MarkType.min));
            
            bar4.Data(620, 732, sd2, 734, 890, 930, 820);

            option.Series(bar1, bar2, bar3, bar4);

            var result = JsonTools.ObjectToJson2(option);
            return result;
        }

        //paired bars
        #endregion

        #region scatter data
        [AcceptVerbs("GET", "POST")]
        [ActionName("Sactter1")]
        public string StdScatter()
        {
            ChartOption option = new ChartOption();
            option.Title().Text("男女身高体重分部").SubText("数据来源网络");
            option.ToolTip().Trigger(TriggerType.axis)
               .ShowDelay(0).Formatter(new JRaw(@" function (params) {
                if (params.value.length > 1) {
                    return params.seriesName + ' :<br/>'
                       + params.value[0] + 'cm ' 
                       + params.value[1] + 'kg ';
                }
                else {
                    return params.seriesName + ' :<br/>'
                       + params.name + ' : '
                       + params.value + 'kg ';
                }
            }"))
            .AxisPointer().Show(true).Type(AxisPointType.cross)
            .LineStyle().Type(LineStyleType.dashed).Width(1);

            option.Legend().Data("女性", "男性");

            option.ToolBox(ToolBox());
            option.calculable = true;

            var x = new ValueAxis();
            x.Scale(true).AxisLabel().Formatter(new JRaw("{value cm}").ToString());
            option.XAxis(x);
            var y = new ValueAxis();
            y.SetData(new List<object>(ChartsUtil.Pops()));
            option.YAxis(y);
            var s1 = new Scatter("女性");
            s1.SetData(ChartsData.females);
            s1.MarkPoint().Data(new MarkData("最大值", MarkType.max),new MarkData("最小值", MarkType.min));
            s1.MarkLine().Data(new MarkData("平均值", MarkType.average));
            
            var s2 = new Scatter("男性");
            s2.SetData(ChartsData.males);
            s2.MarkPoint().Data(new MarkData("最大值", MarkType.max), new MarkData("最小值", MarkType.min));
            s2.MarkLine().Data(new MarkData("平均值", MarkType.average));
            option.Series(s1, s2);

            var result = JsonTools.ObjectToJson2(option);
            return result;
        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("scatter2")]
        public string BufferScatter()
        {
            ChartOption option = new ChartOption();          
            option.ToolTip().Trigger(TriggerType.axis)
               .ShowDelay(0)
            .AxisPointer().Show(true).Type(AxisPointType.cross)
            .LineStyle().Type(LineStyleType.dashed).Width(1);

            option.Legend().Data("scatter1", "scatter2");

            Feature feature = new Feature();
            feature.Mark().Show(true);
            feature.DataZoom().Show(true);
            feature.DataView().Show(true).ReadOnly(false);
            feature.Restore().Show(true);
            feature.SaveAsImage().Show(true);

            option.ToolBox().Show(true).SetFeature(feature);
           

            var x = new ValueAxis();
            x.SplitNumber(4).Scale(true);
            option.XAxis(x);
            var y = new ValueAxis();
            y.SplitNumber(4).Scale(true);
            option.YAxis(y);
            var s1 = new Scatter("scatter1");
            s1.SymbolSize(new JRaw(@"function (value){
                return Math.round(value[2] / 5);
            }"));
            s1.data = new JRaw("randomDataArray()");

            var s2 = new Scatter("scatter2");
            s2.SymbolSize(new JRaw(@"function (value){
                return Math.round(value[2] / 5);
            }"));
            s2.data = new JRaw("randomDataArray()");
            option.Series(s1, s2);

            var result = JsonTools.ObjectToJson2(option);
            return result;
        }


        [AcceptVerbs("GET", "POST")]
        [ActionName("scatter3")]
        public string LargeScatter()
        {
            ChartOption option = new ChartOption();
            option.ToolTip().Trigger(TriggerType.axis)
               .ShowDelay(0)
            .AxisPointer().Show(true).Type(AxisPointType.cross)
            .LineStyle().Type(LineStyleType.dashed).Width(1);

            option.Legend().Data("sin", "cos");

            Feature feature = new Feature();
            feature.Mark().Show(true);
            feature.DataZoom().Show(true);
            feature.DataView().Show(true).ReadOnly(false);
            feature.Restore().Show(true);
            feature.SaveAsImage().Show(true);

            option.ToolBox().Show(true).SetFeature(feature);


            var x = new ValueAxis();
            x.SplitNumber(4).Scale(true);
            option.XAxis(x);
            var y = new ValueAxis();
            y.SplitNumber(4).Scale(true);
            option.YAxis(y);
            var s1 = new Scatter("sin");
            s1.Large(true);

            s1.data = new JRaw(@"(function () {
                var d = [];
                var len = 10000;
                var x = 0;
                while (len--) {
                    x = (Math.random() * 10).toFixed(3) - 0;
                    d.push([
                        x,
                        //Math.random() * 10
                        (Math.sin(x) - x * (len % 2 ? 0.1 : -0.1) * Math.random()).toFixed(3) - 0
                    ]);
                }
                //console.log(d)
                return d;
            })()");

            var s2 = new Scatter("cos");
            s2.Large(true);
            s2.data = new JRaw(@"(function () {
                var d = [];
                var len = 10000;
                var x = 0;
                while (len--) {
                    x = (Math.random() * 10).toFixed(3) - 0;
                    d.push([
                        x,
                        //Math.random() * 10
                        (Math.cos(x) - x * (len % 2 ? 0.1 : -0.1) * Math.random()).toFixed(3) - 0
                    ]);
                }
                //console.log(d)
                return d;
            })()");
            option.Series(s1, s2);

            var result = JsonTools.ObjectToJson2(option);
            return result;
        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("scatter4")]
        public string TimeScatter()
        {

            var timeline = new TimeLine();
            timeline.Data("2002-01-01", "2003-01-01", "2004-01-01", "2005-01-01", "2006-01-01",
            "2007-01-01", "2008-01-01", "2009-01-01", "2010-01-01", "2011-01-01")
            .AutoPlay(true).PlayInterval(1000);
            timeline.Label().Formatter(new JRaw(@"function(s) {
                return s.slice(0, 4);
            }"));

            ChartOption option = new ChartOption();
            option.timeline = timeline;

            ChartOption option1 = new ChartOption();
            option1.Title().Text("2002全国宏观经济关联分析（GDP vs 房地产）")
                .Subtext("数据来自国家统计局");
           
            option1.ToolTip().Trigger(TriggerType.axis)
               .ShowDelay(0)
            .AxisPointer().Show(true).Type(AxisPointType.cross)
            .LineStyle().Type(LineStyleType.dashed).Width(1);

            
            Feature feature = new Feature();
            feature.Mark().Show(true);
            feature.DataZoom().Show(true);
            feature.DataView().Show(true).ReadOnly(false);
            feature.Restore().Show(true);
            feature.SaveAsImage().Show(true);

            option1.ToolBox().Show(true).Orient(OrientType.vertical).X(HorizontalType.right)
                .Y(HorizontalType.center)
                .SetFeature(feature);

            option1.Grid().Y(80).Y2(100);

            var x = new ValueAxis();
            x.Name("房地产（亿元）").Max(3400);
            option1.XAxis(x);
            var y = new ValueAxis();
            y.Name("房地产（亿元）").Max(53500);
            option1.YAxis(y);

            var md1 = new MarkData("y平均值", MarkType.average);
            md1.ItemStyle().Normal().BorderColor("red");
            var md2 = new MarkData("x平均值", MarkType.average);
            md2.ValueIndex(0).ItemStyle().Normal().BorderColor("red");
            var ml = new MarkLine();
            ml.Data(md1, md2);
            
           
            var s1 = new Scatter("GDP");           
            s1.SymbolSize(5).ItemStyle().Normal().Label().Show(true).Formatter("{b}");
            s1.markLine = ml;
            s1.data = new JRaw("dataMap.dataGDP_Estate['2002']");
            option1.Series(s1);
            var provider = new List<string>() { "dataMap.dataGDP_Estate" };
            var data2 = ChartsUtil.EconDatas2(2003, provider);
            var option2= new ChartOption();
            option2.Title().Text("2003全国宏观经济关联分析（GDP vs 房地产）");
            option2.series = data2.Cast<object>().ToList();

            var option3 = new ChartOption();
            option3.Title().Text("2004全国宏观经济关联分析（GDP vs 房地产）");
            var data3 = ChartsUtil.EconDatas2(2004, provider);
            option3.series = data3.Cast<object>().ToList();

            var option4 = new ChartOption();
            option4.Title().Text("2005全国宏观经济关联分析（GDP vs 房地产）");
            var data4 = ChartsUtil.EconDatas2(2005, provider);
            option4.series = data4.Cast<object>().ToList();

            var option5 = new ChartOption();
            option5.Title().Text("2006全国宏观经济关联分析（GDP vs 房地产）");
             var data5 = ChartsUtil.EconDatas2(2006, provider);
            option5.series = data5.Cast<object>().ToList();

            var option6 = new ChartOption();
            option6.Title().Text("2007全国宏观经济关联分析（GDP vs 房地产）");
             var data6 = ChartsUtil.EconDatas2(2007, provider);
            option6.series = data6.Cast<object>().ToList();

            var option7 = new ChartOption();
            option7.Title().Text("2008全国宏观经济关联分析（GDP vs 房地产）");
            var data7 = ChartsUtil.EconDatas2(2008, provider);
            option7.series = data7.Cast<object>().ToList();

            var option8 = new ChartOption();
            option8.Title().Text("2009全国宏观经济关联分析（GDP vs 房地产）");
            var data8 = ChartsUtil.EconDatas2(2009, provider);
            option8.series = data8.Cast<object>().ToList();

            var option9 = new ChartOption();
            option9.Title().Text("2010全国宏观经济关联分析（GDP vs 房地产）");
          var data9 = ChartsUtil.EconDatas2(2010, provider);
            option9.series = data9.Cast<object>().ToList();

            var options = new List<ChartOption>() {
                 option1,option2,option3,option4,option5,option7,
                 option8,option9
            };

            option.options = options;

            var result = JsonTools.ObjectToJson2(option);
            return result;
        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("DataRange1")]
        public string RangeScatter()
        { 
            ChartOption option = new ChartOption();

            option.ToolTip().Trigger(TriggerType.item);               
            Feature feature = new Feature();
            feature.Mark().Show(true);
            feature.DataZoom().Show(true);
            feature.DataView().Show(true).ReadOnly(false);
            feature.Restore().Show(true);
            feature.SaveAsImage().Show(true);

            option.ToolBox().Show(true)
                .SetFeature(feature);

          

            option.Grid().Y(80).Y2(100);

            var x = new ValueAxis();
            x.Name("房地产（亿元）").Max(3400);
            option.XAxis(x);
            var y = new ValueAxis();
            y.Name("房地产（亿元）").Max(53500);
            option.YAxis(y);

           
 

            var result = JsonTools.ObjectToJson2(option);
            return result;
        }

        [AcceptVerbs("GET", "POST")]        
        public string Scatter()
        {
            ChartOption option = new ChartOption();
            option.ToolTip().Trigger(TriggerType.axis)            
            .AxisPointer().Show(true).Type(AxisPointType.cross)
            .LineStyle().Type(LineStyleType.dashed).Width(1);

            option.Legend().Data("catter1", "cos");

            Feature feature = new Feature();
            feature.Mark().Show(true);
            feature.DataZoom().Show(true);
            feature.DataView().Show(true).ReadOnly(false);
            feature.Restore().Show(true);
            feature.SaveAsImage().Show(true);

            option.ToolBox().Show(true).SetFeature(feature);

            var x = new ValueAxis();           
            option.XAxis(x);
            var y = new ValueAxis();            
            option.YAxis(y);
            var s1 = new Scatter("scatter1");
            s1.SymbolSize(new JRaw(@"function (value){
                if (value[0] < 2) {
                    return 2;
                }
                else if (value[0] < 8) {
                    return Math.round(value[2] * 3);
                }
                else {
                    return 20;
                }
            }"));
            var style = new ItemStyle();
            style.Normal().Color("lightblue").BorderWidth(4).Label().Show(true);
            style.Emphasis().Color("lightgreen");

            s1.data = new JRaw(@"(function () {
                var d = [];
                var len = 20;
                while (len--) {
                    d.push([
                        (Math.random()*10).toFixed(2) - 0,
                        (Math.random()*10).toFixed(2) - 0,
                        (Math.random()*10).toFixed(2) - 0
                    ]);
                }
                return d;
            })()");

            var md1 = new MarkData("y最大值",MarkType.max);
            var md2 = new MarkData("y最小值", MarkType.min);
            var md3 = new MarkData("x最大值", MarkType.max);
            md3.ValueIndex(0).Symbol("arrow")
                .ItemStyle().Normal().BorderColor("red");            
            var md4 = new MarkData("y最大值", MarkType.max);
            md4.ValueIndex(0).Symbol("arrow")
                .ItemStyle().Normal().BorderColor("red");
            s1.MarkPoint().Data(md1, md2, md3, md4);

            var md5 = new MarkData("y平均值", MarkType.average);
            var md6 = new MarkData("x平均值", MarkType.average);
            md6.ValueIndex(1).ItemStyle().Normal().BorderColor("red");
            s1.MarkLine().Data(md5, md6);

            var s2 = new Scatter("scatter2");
            s2.Symbol("image://../Content/img/icon/favicon.png")
                .SymbolSize(new JRaw(@"function (value){
                return Math.round(value[2] * 3);
            }")).ItemStyle().Emphasis().Label().Show(true);

            s2.data = new JRaw(@"(function () {
                var d = [];
                var len = 20;
                while (len--) {
                    d.push([
                        (Math.random()*10).toFixed(2) - 0,
                        (Math.random()*10).toFixed(2) - 0,
                        (Math.random()*10).toFixed(2) - 0
                    ]);
                }
                d.push({
                    value : [5,5,1000],
                    itemStyle: {
                        normal: {
                            borderWidth: 8,
                            color: 'orange'
                        },
                        emphasis: {
                            borderWidth: 10,
                            color: '#ff4500'
                        }
                    },
                    symbol: 'emptyTriangle',
                    symbolRotate:90,
                    symbolSize:30
                })
                return d;
            })()");
            var md7 = new MarkData("有个东西");
            md7.Value(1000).XAxis(5).YAxis(5).SymbolSize(80);
            var mp2 = new MarkPoint();
            
            s2.MarkPoint().Symbol("emptyCircle").Data(md7)
                .ItemStyle().Normal().Label().Position(StyleLabelTyle.top);

            option.Series(s1, s2);

            var result = JsonTools.ObjectToJson2(option);
            return result;
        }

        #endregion

        #region k data
        [AcceptVerbs("GET", "POST")]        
        public string K()
        {
            ChartOption option = new ChartOption();
            option.Title().Text("2013年上半年上证指数").X(HorizontalType.center);
            option.ToolTip().Trigger(TriggerType.axis)
                .Formatter(new JRaw(@"function (params) {
            var res = params[0].seriesName + ' ' + params[0].name;
            res += '<br/>  开盘 : ' + params[0].value[0] + '  最高 : ' + params[0].value[3];
            res += '<br/>  收盘 : ' + params[0].value[1] + '  最低 : ' + params[0].value[2];
            return res;
              }"));
            option.Legend().Data("上证指数");

            Feature feature = new Feature();
            feature.Mark().Show(true);
            feature.DataZoom().Show(true);
            feature.DataView().Show(true).ReadOnly(false);
            feature.Restore().Show(true);
            feature.SaveAsImage().Show(true);

            option.ToolBox().Show(true).SetFeature(feature);

            option.DataZoom().Show(true).Realtime(true).Start(0).End(50);

            var x = new CategoryAxis();
            x.BoundaryGap(true).AxisTick().OnGap(false);
            x.SplitLine().Show(false);
            x.Data("2013/1/24", "2013/1/25", "2013/1/28", "2013/1/29", "2013/1/30",
                "2013/1/31", "2013/2/1", "2013/2/4", "2013/2/5", "2013/2/6",
                "2013/2/7", "2013/2/8", "2013/2/18", "2013/2/19", "2013/2/20",
                "2013/2/21", "2013/2/22", "2013/2/25", "2013/2/26", "2013/2/27",
                "2013/2/28", "2013/3/1", "2013/3/4", "2013/3/5", "2013/3/6",
                "2013/3/7", "2013/3/8", "2013/3/11", "2013/3/12", "2013/3/13",
                "2013/3/14", "2013/3/15", "2013/3/18", "2013/3/19", "2013/3/20",
                "2013/3/21", "2013/3/22", "2013/3/25", "2013/3/26", "2013/3/27",
                "2013/3/28", "2013/3/29", "2013/4/1", "2013/4/2", "2013/4/3",
                "2013/4/8", "2013/4/9", "2013/4/10", "2013/4/11", "2013/4/12",
                "2013/4/15", "2013/4/16", "2013/4/17", "2013/4/18", "2013/4/19",
                "2013/4/22", "2013/4/23", "2013/4/24", "2013/4/25", "2013/4/26",
                "2013/5/2", "2013/5/3", "2013/5/6", "2013/5/7", "2013/5/8",
                "2013/5/9", "2013/5/10", "2013/5/13", "2013/5/14", "2013/5/15",
                "2013/5/16", "2013/5/17", "2013/5/20", "2013/5/21", "2013/5/22",
                "2013/5/23", "2013/5/24", "2013/5/27", "2013/5/28", "2013/5/29",
                "2013/5/30", "2013/5/31", "2013/6/3", "2013/6/4", "2013/6/5",
                "2013/6/6", "2013/6/7", "2013/6/13");
            option.XAxis(x);

            var y = new ValueAxis();
            y.Scale(true).BoundaryGap(0.01, 0.01);
            option.YAxis(y);

            var style = new ItemStyle();
            style.Normal().Color("red").Color0("lightgreen")
                .LineStyle().Width(2).Color("orange").Color0("green");
            style.Emphasis().Color("black").Color0("white");
            var mp = new MarkPoint();
            mp.Symbol("star").ItemStyle().Normal().Label().Position(StyleLabelTyle.top);
            mp.Data(new MarkData("最高") { value = 2444.8, xAxis = "2014/2/18", yAxis = 2466 });
            
            var k = new K("上证指数");
            k.SetItemStyle(style);
            k.BarMaxWidth(20);
            k.markPoint = mp;
            k.data = ChartsData.SSE;
            option.Series(k);
            var result = JsonTools.ObjectToJson2(option);
            return result;
        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("k1")]
        public string StdK()
        {
            ChartOption option = new ChartOption();
            option.Title().Text("2013年上半年上证指数").X(HorizontalType.center);
            option.ToolTip().Trigger(TriggerType.axis)
                .Formatter(new JRaw(@" function (params) {
            var res = params[0].seriesName + ' ' + params[0].name;
            res += '<br/>  开盘 : ' + params[0].value[0] + '  最高 : ' + params[0].value[3];
            res += '<br/>  收盘 : ' + params[0].value[1] + '  最低 : ' + params[0].value[2];
            return res;
            }"));
            option.Legend().Data("上证指数");

            Feature feature = new Feature();
            feature.Mark().Show(true);
            feature.DataZoom().Show(true);
            feature.DataView().Show(true).ReadOnly(false);
            feature.Restore().Show(true);
            feature.SaveAsImage().Show(true);

            option.ToolBox().Show(true).SetFeature(feature);

            option.DataZoom().Show(true).Realtime(true).Start(50).End(100);

            var x = new CategoryAxis();
            x.BoundaryGap(true).AxisTick().OnGap(false);
            x.SplitLine().Show(false);
            x.Data("2013/1/24", "2013/1/25", "2013/1/28", "2013/1/29", "2013/1/30",
                "2013/1/31", "2013/2/1", "2013/2/4", "2013/2/5", "2013/2/6",
                "2013/2/7", "2013/2/8", "2013/2/18", "2013/2/19", "2013/2/20",
                "2013/2/21", "2013/2/22", "2013/2/25", "2013/2/26", "2013/2/27",
                "2013/2/28", "2013/3/1", "2013/3/4", "2013/3/5", "2013/3/6",
                "2013/3/7", "2013/3/8", "2013/3/11", "2013/3/12", "2013/3/13",
                "2013/3/14", "2013/3/15", "2013/3/18", "2013/3/19", "2013/3/20",
                "2013/3/21", "2013/3/22", "2013/3/25", "2013/3/26", "2013/3/27",
                "2013/3/28", "2013/3/29", "2013/4/1", "2013/4/2", "2013/4/3",
                "2013/4/8", "2013/4/9", "2013/4/10", "2013/4/11", "2013/4/12",
                "2013/4/15", "2013/4/16", "2013/4/17", "2013/4/18", "2013/4/19",
                "2013/4/22", "2013/4/23", "2013/4/24", "2013/4/25", "2013/4/26",
                "2013/5/2", "2013/5/3", "2013/5/6", "2013/5/7", "2013/5/8",
                "2013/5/9", "2013/5/10", "2013/5/13", "2013/5/14", "2013/5/15",
                "2013/5/16", "2013/5/17", "2013/5/20", "2013/5/21", "2013/5/22",
                "2013/5/23", "2013/5/24", "2013/5/27", "2013/5/28", "2013/5/29",
                "2013/5/30", "2013/5/31", "2013/6/3", "2013/6/4", "2013/6/5",
                "2013/6/6", "2013/6/7", "2013/6/13");
            option.XAxis(x);

            var y = new ValueAxis();
            y.Scale(true).BoundaryGap(0.01, 0.01);
            option.YAxis(y);

            var k = new K("上证指数");
            k.data = ChartsData.SSE;
            option.Series(k);
            var result = JsonTools.ObjectToJson2(option);
            return result;
        }
        #endregion

        #region pie data
        [AcceptVerbs("GET", "POST")]
        [ActionName("pie1")]
        public string StdPie()
        {
            IList<string> ads = ChartsUtil.Ads();
           
            IList<int> data1 = ChartsUtil.Datas(7, 90, 240);
            IList<int> data2 = ChartsUtil.Datas(7, 190, 310);
            IList<int> data3 = ChartsUtil.Datas(7, 150, 410);
            IList<int> data4 = ChartsUtil.Datas(7, 300, 400);
             
            
            ChartOption option = new ChartOption();
            option.Title().Text("用户访问来源").SubText("虚构").X(HorizontalType.center);            
            option.ToolTip().Trigger(TriggerType.item).Formatter(new JRaw(@"{a} <br/>{b} : {c} ({d}%)").ToString());
            option.Legend().Orient(OrientType.vertical).X(HorizontalType.left).SetData(new List<object>(ads.ToList()));
            option.ToolBox(ToolBox(OrientType.vertical));
            option.ToolBox().X(HorizontalType.right).Y(HorizontalType.center);
            option.calculable = true;

            var pie = new Pie("访问来源");

            pie.Radius("55%").Center(new List<string>() { "50%", "60%" });
            pie.Data(new PieData<int>(345, ads[0]), new PieData<int>(310, ads[1]), new PieData<int>(234, ads[2]),
                new PieData<int>(135, ads[3]), new PieData<int>(1543, ads[4]));

            
            option.Series(pie);

            var result = JsonTools.ObjectToJson2(option);
            return result;

        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("pie2")]
        public string StdRing()
        {
            IList<string> ads = ChartsUtil.Ads();

            IList<int> data1 = ChartsUtil.Datas(7, 90, 240);
            IList<int> data2 = ChartsUtil.Datas(7, 190, 310);
            IList<int> data3 = ChartsUtil.Datas(7, 150, 410);
            IList<int> data4 = ChartsUtil.Datas(7, 300, 400);


            ChartOption option = new ChartOption();
            option.Title().Text("用户访问来源").SubText("虚构").X(HorizontalType.center);
            option.ToolTip().Trigger(TriggerType.item).Formatter(new JRaw(@"{a} <br/>{b} : {c} ({d}%)").ToString());
            option.Legend().Orient(OrientType.vertical).X(HorizontalType.left).SetData(new List<object>(ads.ToList()));
            option.ToolBox(ToolBox(OrientType.vertical));
            option.ToolBox().X(HorizontalType.right).Y(HorizontalType.center);
            option.calculable = true;

            Feature feature = new Feature();
            feature.Mark().Show(true);
            feature.DataZoom().Show(true);
            feature.DataView().Show(true).ReadOnly(false);
            feature.MagicType().Show(true).Type("pie", "funnel")
                .Option().Funnel().X("25%").Width("50%")
                .FunnelAlign(HorizontalType.center).Max(1548);                
            feature.Restore().Show(true);
            feature.SaveAsImage().Show(true);
            option.ToolBox().Show(true).SetFeature(feature);
            option.Calculable(true);

            var pie = new Pie("访问来源");

            pie.Radius(new List<string>() { "50%", "70%" });
            var style = new ItemStyle();
            style.Normal().Label().Show(true);
            style.Normal().LabelLine().Show(true);
            style.Emphasis().Label().Show(true).Position(StyleLabelTyle.center)
                .TextStyle().FontSize(30).FontWeight("bold");
            pie.SetItemStyle(style);
            pie.Data(new PieData<int>(345, ads[0]), new PieData<int>(310, ads[1]), new PieData<int>(234, ads[2]),
                new PieData<int>(135, ads[3]), new PieData<int>(1543, ads[4]));


            option.Series(pie);

            var result = JsonTools.ObjectToJson2(option);
            return result;

        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("pie3")]
        public string NestPie()
        {
            IList<string> ads = ChartsUtil.Ads();
            IList<string> ses = ChartsUtil.Ses();
            IList<int> data1 = ChartsUtil.Datas(7, 90, 240);
            IList<int> data2 = ChartsUtil.Datas(7, 190, 310);
            IList<int> data3 = ChartsUtil.Datas(7, 150, 410);
            IList<int> data4 = ChartsUtil.Datas(7, 300, 400);
            IList<int> data5 = ChartsUtil.Datas(7, 820, 1400);
            IList<int> data6 = ChartsUtil.Datas(7, 600, 1200);
            IList<int> data7 = ChartsUtil.Datas(7, 80, 400);
            IList<int> data8 = ChartsUtil.Datas(7, 100, 300);
            ads.ToList().AddRange(ses);

            ChartOption option = new ChartOption();          
            option.ToolTip().Trigger(TriggerType.item).Formatter(new JRaw(@"{a} <br/>{b} : {c} ({d}%)").ToString());
            option.Legend().Orient(OrientType.vertical).X(HorizontalType.left).SetData(new List<object>(ads.ToList()));

            Feature feature = new Feature();
            feature.Mark().Show(true);
            feature.DataZoom().Show(true);
            feature.DataView().Show(true).ReadOnly(false);
            feature.MagicType().Show(true).Type("pie", "funnel")
                .Option().Funnel().X("25%").Width("50%")
                .FunnelAlign(HorizontalType.center).Max(1548);
            feature.Restore().Show(true);
            feature.SaveAsImage().Show(true);
            option.ToolBox().Show(true).SetFeature(feature);
            option.Calculable(true);



            option.calculable = true;

            var pie = new Pie("访问来源");

            pie.SelectedMode(SelectedModeType.single).Radius(new List<string>() { "0", "70" })
               .X("20%").Width("40%").FunnelAlign(HorizontalType.right).Max(1548);
            var style = new ItemStyle();
            style.Normal().Label().Position(StyleLabelTyle.inner);
            style.Normal().LabelLine().Show(false);
            pie.SetItemStyle(style);
            pie.Data(new PieData<int>(335, "直达"), new PieData<int>(679, "营销广告"),
                new PieData<int>(1548, "搜索引擎"));

            var pie2 = new Pie("访问来源");

            pie2.SelectedMode(SelectedModeType.single).Radius(new List<string>() { "100", "140" })
               .X("60%").Width("35%").FunnelAlign(HorizontalType.left).Max(1048);
         
            pie2.Data(new PieData<int>(335, "直达"), new PieData<int>(679, "营销广告"),
                new PieData<int>(1548, "联盟广告"), new PieData<int>(1548, "视频广告"),
                new PieData<int>(1548, "百度"), new PieData<int>(1548, "谷歌"),
                new PieData<int>(1548, "必应"), new PieData<int>(1548, "其他"));


            option.Series(pie,pie2);

            var result = JsonTools.ObjectToJson2(option);
            return result;

        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("pie4")]
        public string NigRosePie()
        {
            var names = ChartsUtil.GenString("rose", 8);
            ChartOption option = new ChartOption();
            option.ToolTip().Trigger(TriggerType.item).Formatter(new JRaw(@"{a} <br/>{b} : {c} ({d}%)").ToString());
            option.Legend().Y(VerticalType.bottom).X(HorizontalType.center).SetData(new List<object>(names.ToList()));

            Feature feature = new Feature();
            feature.Mark().Show(true);
            feature.DataZoom().Show(true);
            feature.DataView().Show(true).ReadOnly(false);
            feature.MagicType().Show(true).Type("pie", "funnel")
                .Option().Funnel().X("25%").Width("50%")
                .FunnelAlign(HorizontalType.center).Max(1548);
            feature.Restore().Show(true);
            feature.SaveAsImage().Show(true);
            option.ToolBox().Show(true).SetFeature(feature);
            option.Calculable(true);            

            var pie = new Pie("半径模式");

            pie.SelectedMode(SelectedModeType.single).Radius(new List<string>() { "20", "110" })
                .Center(new List<string>() { "25%", "200" }).RoseType(NigRoseType.radius)
               .Width("40%").FunnelAlign(HorizontalType.right).Max(40);
            var style = new ItemStyle();
            style.Normal().Label().Show(false);
            style.Normal().LabelLine().Show(false);
            style.Emphasis().Label().Show(false);
            style.Emphasis().LabelLine().Show(false);

            pie.SetItemStyle(style);
            pie.Data(new PieData<int>(10, "rose1"), new PieData<int>(5, "rose2"),
                new PieData<int>(15, "rose3"),new PieData<int>(25,"roese4"),
                new PieData<int>(20, "roese5"), new PieData<int>(35, "roese6"),
                new PieData<int>(30, "roese7"), new PieData<int>(40, "roese8"));

            var pie2 = new Pie("面积模式");

            pie2.SelectedMode(SelectedModeType.single).Radius(new List<string>() { "30", "110" })
                .Center(new List<string>() { "75%", "200" }).RoseType(NigRoseType.area)
               .Width("50%").FunnelAlign(HorizontalType.right).Max(40);

            pie2.Data(new PieData<int>(10, "rose1"), new PieData<int>(5, "rose2"),
                new PieData<int>(15, "rose3"), new PieData<int>(25, "roese4"),
                new PieData<int>(20, "roese5"), new PieData<int>(35, "roese6"),
                new PieData<int>(30, "roese7"), new PieData<int>(40, "roese8"));


            option.Series(pie, pie2);

            var result = JsonTools.ObjectToJson2(option);
            return result;

        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("pie5")]
        public string Ring()
        {
            var labelTop = new ItemStyle();
            labelTop.Normal().Label().Show(true).Position(StyleLabelTyle.center)
                .Formatter("{b}").TextStyle().Baseline(VerticalType.bottom);

            var labelFormatter = new ItemStyle();
            labelFormatter.Normal().Label().Formatter(new JRaw(@" function (params){
                return 100 - params.value + '%'
            }")).TextStyle().Baseline(VerticalType.top);

            var labelBottom = new ItemStyle();
            labelBottom.Normal().Color("#ccc").Label().Show(true).Position(StyleLabelTyle.center);
            labelBottom.Normal().LabelLine().Show(false);
            labelBottom.Emphasis().Color("rgba(0,0,0,0)");
            
            ChartOption option = new ChartOption();
            option.Legend().X(HorizontalType.center).Y(HorizontalType.center).
                Data("GoogleMaps", "Facebook", "Youtube", "Google+", "Weixin",
            "Twitter", "Skype", "Messenger", "Whatsapp", "Instagram");

            option.Title().Text("The app world").Subtext("from global web index").X(HorizontalType.center);

            option.ToolTip().Trigger(TriggerType.item).Formatter(new JRaw(@"{a} <br/>{b} : {c} ({d}%)").ToString());

            var style = new ItemStyle();
            style.Normal().Label().Formatter(new JRaw(@" function (params){
                                        return 'other\n' + params.value + '%\n'
                                    }")).TextStyle().Baseline(VerticalType.middle);
            Feature feature = new Feature();
            feature.Mark().Show(true);
            feature.DataZoom().Show(true);
            feature.DataView().Show(true).ReadOnly(false);
            feature.MagicType().Show(true).Type("pie", "funnel")
                .Option().Funnel().Width("20%").Height("30%")
                .FunnelAlign(HorizontalType.center).Max(1548)
                .SetItemStyle(style) ;
            feature.Restore().Show(true);
            feature.SaveAsImage().Show(true);
            option.ToolBox().Show(true).SetFeature(feature);
            option.Calculable(true);

            var pie = new Pie();
            var pd1 = new PieData<int>(46, "other");
            pd1.itemStyle = labelBottom;
            var pd2 = new PieData<int>(54, "GoogleMaps");
            pd2.itemStyle = labelTop;

            pie.SelectedMode(SelectedModeType.single).Radius(new List<string>() { "40", "55" })
                .Center(new List<string>() { "10%", "30%" }).X("0%")
               .Data(pd1, pd2).SetItemStyle(labelFormatter);
                                    
            var pie2 = new Pie();
            var pd3 = new PieData<int>(56, "other");
            pd3.itemStyle = labelBottom;
            var pd4 = new PieData<int>(44, "Facebook");
            pd4.itemStyle = labelTop;

            pie2.SelectedMode(SelectedModeType.single).Radius(new List<string>() { "40", "55" })
                .Center(new List<string>() { "30%", "30%" }).X("20%")
               .Data(pd3, pd4).SetItemStyle(labelFormatter);

            var pie3 = new Pie();
            var pd5 = new PieData<int>(56, "other");
            pd5.itemStyle = labelBottom;
            var pd6 = new PieData<int>(35, "Youtube");
            pd6.itemStyle = labelTop;

            pie3.SelectedMode(SelectedModeType.single).Radius(new List<string>() { "40", "55" })
                .Center(new List<string>() { "50%", "30%" }).X("40%")
               .Data(pd5, pd6).SetItemStyle(labelFormatter);

            var pie4 = new Pie();
            var pd7 = new PieData<int>(70, "other");
            pd7.itemStyle = labelBottom;
            var pd8 = new PieData<int>(30, "Google+");
            pd8.itemStyle = labelTop;

            pie4.SelectedMode(SelectedModeType.single).Radius(new List<string>() { "40", "55" })
                .Center(new List<string>() { "70%", "30%" }).X("60%")
               .Data(pd7, pd8).SetItemStyle(labelFormatter);

            var pie5 = new Pie();
            var pd9 = new PieData<int>(73, "other");
            pd9.itemStyle = labelBottom;
            var pd10 = new PieData<int>(27, "Weixin");
            pd10.itemStyle = labelTop;

            pie5.SelectedMode(SelectedModeType.single).Radius(new List<string>() { "40", "55" })
                .Center(new List<string>() { "90%", "30%" }).X("80%")
               .Data(pd9, pd10).SetItemStyle(labelFormatter);

            var pie6 = new Pie();
            var pd11 = new PieData<int>(78, "other");
            pd11.itemStyle = labelBottom;
            var pd12 = new PieData<int>(22, "Twitter");
            pd12.itemStyle = labelTop;

            pie6.SelectedMode(SelectedModeType.single).Radius(new List<string>() { "40", "55" })
                .Center(new List<string>() { "10%", "70%" }).X("0%").Y("55%")
               .Data(pd11, pd12).SetItemStyle(labelFormatter);

            var pie7 = new Pie();
            var pd13 = new PieData<int>(78, "other");
            pd13.itemStyle = labelBottom;
            var pd14 = new PieData<int>(22, "Skype");
            pd14.itemStyle = labelTop;

            pie7.SelectedMode(SelectedModeType.single).Radius(new List<string>() { "40", "55" })
                .Center(new List<string>() { "30%", "70%" }).X("20%").Y("55%")
               .Data(pd13, pd14).SetItemStyle(labelFormatter);

            var pie8 = new Pie();
            var pd15 = new PieData<int>(78, "other");
            pd15.itemStyle = labelBottom;
            var pd16 = new PieData<int>(22, "Message");
            pd16.itemStyle = labelTop;

            pie8.SelectedMode(SelectedModeType.single).Radius(new List<string>() { "40", "55" })
                .Center(new List<string>() { "50%", "70%" }).X("40%").Y("55%")
               .Data(pd15, pd16).SetItemStyle(labelFormatter);

            var pie9 = new Pie();
            var pd17 = new PieData<int>(83, "other");
            pd17.itemStyle = labelBottom;
            var pd18 = new PieData<int>(17, "Whatsapp");
            pd18.itemStyle = labelTop;

            pie9.SelectedMode(SelectedModeType.single).Radius(new List<string>() { "40", "55" })
                .Center(new List<string>() { "70%", "70%" }).X("60%").Y("55%")
               .Data(pd17, pd18).SetItemStyle(labelFormatter);

            var pie10 = new Pie();
            var pd19 = new PieData<int>(89, "other");
            pd19.itemStyle = labelBottom;
            var pd20 = new PieData<int>(11, "Instagram");
            pd20.itemStyle = labelTop;

            pie10.SelectedMode(SelectedModeType.single).Radius(new List<string>() { "40", "55" })
                .Center(new List<string>() { "90%", "70%" }).X("80%").Y("55%")
               .Data(pd19, pd20).SetItemStyle(labelFormatter);

            option.Series(pie, pie2, pie3, pie4, pie5, pie6, pie7, pie8, pie9, pie10);

            var result = JsonTools.ObjectToJson2(option);
            return result;

        }


        [AcceptVerbs("GET", "POST")]
        [ActionName("pie6")]
        public string RingLike()
        {

            var dataStyle = new ItemStyle();
            dataStyle.Normal().Label().Show(true);
            dataStyle.Normal().LabelLine().Show(false);

            var placeHolderStyle = new ItemStyle();
            placeHolderStyle.Normal().Color("rgba(0,0,0,0)").Label().Show(false);
            placeHolderStyle.Normal().LabelLine().Show(false);
            placeHolderStyle.Emphasis().Color("rbga(0,0,0,0)");

            ChartOption option = new ChartOption();
            option.Title().Text("你幸福吗?").Subtext("From ExcelHome")
                .Sublink("http://e.weibo.com/1341556070/AhQXtjbqh")
                .X(HorizontalType.center).Y(HorizontalType.center)
                .ItemGap(20).TextStyle().Color("rgba(30,144,255,0.8)").FontFamily("微软雅黑")
                .FontSize(35).FontWeight("bolder");

            option.ToolTip().Show(true).Formatter(new JRaw(@"{a} <br/>{b} : {c} ({d}%)").ToString());
            option.Legend().Y(45).Orient(OrientType.vertical)
                .Data("68%的人表示过的不错", "29%的人表示生活压力很大", "3%的人表示“我姓曾”");
            option.Legend().x = new JRaw(@"document.getElementById('main').offsetWidth / 2");

            Feature feature = new Feature();
            feature.Mark().Show(true);
            feature.DataZoom().Show(true);
            feature.DataView().Show(true).ReadOnly(false);
            feature.MagicType().Show(true).Type("pie", "funnel")
                .Option().Funnel().X("25%").Width("50%")
                .FunnelAlign(HorizontalType.center).Max(1548);
            feature.Restore().Show(true);
            feature.SaveAsImage().Show(true);
            option.ToolBox().Show(true).SetFeature(feature);
            option.Calculable(true);

            var pd1 = new PieData<int>(68, "68%的人表示过的不错");
            var pd2 = new PieData<int>(32, "invisible", placeHolderStyle);
            
            var pie = new Pie("1");
            pie.ClockWise(false).Radius(new List<string>() { "125", "150" });
            pie.Data(pd1, pd2);
            pie.SetItemStyle(dataStyle);


            var pd3 = new PieData<int>(29, "29%的人表示生活压力很大");
            var pd4 = new PieData<int>(71, "invisible", placeHolderStyle);

            var pie2 = new Pie("2");
            pie2.ClockWise(false).Radius(new List<string>() { "100", "125" });
            pie2.Data(pd3, pd4);
            pie2.SetItemStyle(dataStyle);


            var pd5 = new PieData<int>(3, @"3%的人表示“我姓曾”");
            var pd6 = new PieData<int>(97, "invisible", placeHolderStyle);

            var pie3 = new Pie("3");
            pie3.ClockWise(false).Radius(new List<string>() { "75", "100" });
            pie3.Data(pd5, pd6);
            pie3.SetItemStyle(dataStyle);

            option.Series(pie, pie2,pie3);

            var result = JsonTools.ObjectToJson2(option);
            return result;

        }

        [AcceptVerbs("GET", "POST")]
        [ActionName("pie7")]
        public string TimeBar()
        {
            var timeline = new TimeLine();
            timeline.Data("2013-01-01", "2013-02-01", "2013-03-01", "2013-04-01", "2013-05-01",
            "2013-06-01", "2013-07-01", "2013-08-01", "2013-09-01", "2013-10-01", "2013-11-01",
             "2013-12-01")
                .Label().Formatter(new JRaw(@" function(s) {
                return s.slice(0, 7);
            }"));
            ChartOption option = new ChartOption();
            option.timeline = timeline;

            ChartOption option1 = new ChartOption();
            option1.Title().Text("浏览器占比变化").Subtext("纯属虚构");             
            option1.ToolTip().Show(true).Formatter(new JRaw(@"{a} <br/>{b} : {c} ({d}%)").ToString());
            option1.Legend().Data("Chrome", "Firefox", "Safari", "IE9+", "IE8-");
      
            Feature feature = new Feature();
            feature.Mark().Show(true);
            feature.DataZoom().Show(true);
            feature.DataView().Show(true).ReadOnly(false);
            feature.MagicType().Show(true).Type("pie", "funnel")
                .Option().Funnel().X("25%").Width("50%")
                .FunnelAlign(HorizontalType.center).Max(1700);
            feature.Restore().Show(true);
            feature.SaveAsImage().Show(true);
            option1.ToolBox().Show(true).SetFeature(feature);
            option1.Calculable(true);
            var pies = ChartsUtil.GetBrowsersData(10);
            pies[0].Center(new List<string>() { "50%", "45%" }).Radius("50%");
            option1.Series(pies[0]);

            ChartOption option2 = new ChartOption();
            option2.Series(pies[1]);

            ChartOption option3 = new ChartOption();
            option3.Series(pies[2]);

            ChartOption option4 = new ChartOption();
            option4.Series(pies[3]);

            ChartOption option5 = new ChartOption();
            option5.Series(pies[4]);

            ChartOption option6 = new ChartOption();
            option6.Series(pies[5]);

            ChartOption option7 = new ChartOption();
            option7.Series(pies[6]);

            ChartOption option8 = new ChartOption();
            option8.Series(pies[7]);

            ChartOption option9 = new ChartOption();
            option9.Series(pies[8]);

            ChartOption option10 = new ChartOption();
            option10.Series(pies[9]);
            var options = new List<ChartOption>() {
                option1,option2,option3,option4,option5,
                option6,option7,option8,option9,option10
            };
            option.options = options;

            var result = JsonTools.ObjectToJson2(option1);
            return result;

        }

        [AcceptVerbs("GET", "POST")]        
        public string Lasagna()
        {
            
            ChartOption option = new ChartOption();
            option.Title().Text("浏览器占比变化").Subtext("纯属虚构")
                .X(HorizontalType.right).Y(VerticalType.bottom);
                            
            option.ToolTip().Show(true).Formatter(new JRaw(@"{a} <br/>{b} : {c} ({d}%)").ToString());
            option.Legend().X(HorizontalType.left).Orient(OrientType.vertical)
                .Data("Chrome", "Firefox", "Safari", "IE9+", "IE8-");

            Feature feature = new Feature();
            feature.Mark().Show(true);
            feature.DataZoom().Show(true);
            feature.DataView().Show(true).ReadOnly(false);
            feature.MagicType().Show(true).Type("pie", "funnel")
                .Option().Funnel().X("25%").Width("50%")
                .FunnelAlign(HorizontalType.center).Max(1548);
            feature.Restore().Show(true);
            feature.SaveAsImage().Show(true);
            option.ToolBox().Show(true).SetFeature(feature);
            option.Calculable(false);
            option.series = new JRaw(@"(function (){
                var series = [];
                for (var i = 0; i < 30; i++) {
                    series.push({
                        name:'浏览器（数据纯属虚构）',
                        type:'pie',
                        itemStyle : {normal : {
                            label : {show : i > 28},
                            labelLine : {show : i > 28, length:20}
                        }},
                        radius : [i * 4 + 40, i * 4 + 43],
                        data:[
                            {value: i * 128 + 80,  name:'Chrome'},
                            {value: i * 64  + 160,  name:'Firefox'},
                            {value: i * 32  + 320,  name:'Safari'},
                            {value: i * 16  + 640,  name:'IE9+'},
                            {value: i * 8  + 1280, name:'IE8-'}
                        ]
                    })
                }
                series[0].markPoint = {
                    symbol:'emptyCircle',
                    symbolSize:series[0].radius[0],
                    effect:{show:true,scaleSize:12,color:'rgba(250,225,50,0.8)',shadowBlur:10,period:30},
                    data:[{x:'50%',y:'50%'}]
                };
                return series;
            })()");

            var result = JsonTools.ObjectToJson2(option);
            return result;

        }

        [AcceptVerbs("GET", "POST")]        
        public string Pie()
        {
            IList<string> ads = ChartsUtil.Ads();
            IList<string> ses = ChartsUtil.Ses();

            foreach (var se in ses)
            {
                ads.Add(se);
            }

            ChartOption option = new ChartOption();
           
            option.ToolTip().Formatter(new JRaw(@"{a} <br/>{b} : {c} ({d}%)").ToString());
            option.Legend().Orient(OrientType.vertical).X(HorizontalType.left).SetData(new List<object>(ads.ToList()));
            Feature feature = new Feature();
            feature.Mark().Show(true);            
            feature.DataView().Show(true).ReadOnly(false);          
            feature.Restore().Show(true);
            feature.SaveAsImage().Show(true);
            option.ToolBox().Show(true).SetFeature(feature);

            option.calculable = true;

            var style = new ItemStyle();
            style.Normal().Label().Position(StyleLabelTyle.inner).Formatter(new JRaw(@" function (params) {                         
                          return (params.percent - 0).toFixed(0) + '%'
                        }"));
            style.Normal().LabelLine().Show(false);
            style.Emphasis().Label().Show(true).Formatter("{b}\n{d}%");
            
            var pie = new Pie("访问来源");
            pie.Radius(new List<string>() {"110","140" }).Center(new List<string>() { "35%", "200" });
            pie.SetItemStyle(style);
            pie.Data(new PieData<int>(335, ads[0]), new PieData<int>(679, ads[1]), new PieData<int>(1548, ads[2]));

            var pieStyle1 = new ItemStyle();
            pieStyle1.Normal().Color(new JRaw(@"(function (){
                                var zrColor = require('zrender/tool/color');
                                return zrColor.getRadialGradient(
                                    300, 200, 110, 300, 200, 140,
                                    [[0, 'rgba(255,255,0,1)'],[1, 'rgba(30,144,250,1)']]
                                )
                            })()"))
                .Label().TextStyle().Color("rgba(30,144,255,0.8)").Align(HorizontalType.center)
                .Baseline(VerticalType.middle).FontFamily("微软雅黑")
                .FontSize(30).FontWeight("bolder");
            pieStyle1.Normal().LabelLine().Length(40).LineStyle()
                .Color("#f0f").Width(3).Type(LineStyleType.dotted);
            var pieStyle2 = new ItemStyle();
            pieStyle2.Normal().Label().Show(false);
            pieStyle2.Normal().LabelLine().Show(false);
            pieStyle2.Emphasis().Label().Show(false);
            pieStyle2.Emphasis().LabelLine().Show(false).Length(50);
            var pie2 = new Pie("访问来源");
            pie2.Radius(new List<string>() { "110", "140" }).Center(new List<string>() { "35%", "200" });
            pie2.Data(new PieData<int>(335, ads[0]), new PieData<int>(310, ads[1]), new PieData<int>(234, ads[2]),
                new PieData<int>(135, ads[3]), new PieData<int>(135, ads[4]), new PieData<int>(1048, ads[5], pieStyle1),
                new PieData<int>(102, ads[6], pieStyle2), new PieData<int>(147, ads[7]));

            var style2 = new ItemStyle();
            style2.Normal().Label().Show(false);
            style2.Normal().LabelLine().Show(false);
            style2.Emphasis().Color(new JRaw(@"(function (){
                        var zrColor = require('zrender/tool/color');
                        return zrColor.getRadialGradient(
                            650, 200, 80, 650, 200, 120,
                            [[0, 'rgba(255,255,0,1)'],[1, 'rgba(255,0,0,1)']]
                        )
                    })()")).Label().Show(true).Position(StyleLabelTyle.center).Formatter("{d}%")
                    .TextStyle().Color("red").FontSize(30).FontFamily("微软雅黑").FontWeight("bold");


            var pie3 = new Pie("访问来源");
            pie3.SetItemStyle(style2);
            pie3.Radius(new List<string>() { "80", "120" }).Center(new List<string>() { "75%", "200" })
                .StartAngle(135).ClockWise(true);
            pie3.Data(new PieData<int>(335, ads[0]), new PieData<int>(310, ads[1]), new PieData<int>(234, ads[2]),
                new PieData<int>(135, ads[3]), new PieData<int>(135, ads[4]));
            var md = new MarkData("最大");
            md.Value(1548).X("80%").Y(50).SymbolSize(32);
            pie3.MarkPoint().Symbol("star").Data(md);

            option.Series(pie, pie2, pie3);

            var result = JsonTools.ObjectToJson2(option);
            return result;

        }

        #endregion

        #region radar data
        [AcceptVerbs("GET", "POST")]
        [ActionName("radar1")]
        public string StdRadar()
        { 

            ChartOption option = new ChartOption();
            option.Title().Text("预算 vs 开销（Budget vs spending）").SubText("纯属虚构");
            option.ToolTip().Trigger(TriggerType.axis);
            option.Legend().Orient(OrientType.vertical).X(HorizontalType.right)
                .Y(VerticalType.bottom).Data("预算分配", "实际开销");
            option.ToolBox(ToolBox(OrientType.vertical));            
            option.calculable = true;
            var pd1 = new IndicatorData();
            pd1.Text("销售").Max(6000);
            var pd2 = new IndicatorData();
            pd2.Text("管理").Max(16000);
            var pd3 = new IndicatorData();
            pd3.Text("信息技术").Max(30000);
            var pd4 = new IndicatorData();
            pd4.Text("客服").Max(38000);
            var pd5 = new IndicatorData();
            pd5.Text("研发").Max(52000);
            var pd6 = new IndicatorData();
            pd6.Text("市场").Max(25000);
            var polar = new Polar();
            polar.Indicator(pd1, pd2, pd3, pd4, pd5, pd6);
            option.Polar(polar);
            var radar = new Radar("预算 vs 开销（Budget vs spending）");
            var pd7 = new PolarData("预算分配");
            pd7.Value(4300, 10000, 28000, 35000, 50000, 19000);
            var pd8 = new PolarData("实际开销");
            pd8.Value(5000, 14000, 28000, 31000, 42000, 21000);
            radar.Data(pd7, pd8);

            option.Series(radar);

            var result = JsonTools.ObjectToJson2(option);
            return result;

        }
        #endregion


        private ToolBox ToolBox(OrientType orient= OrientType.horizontal)
        {
            
            ToolBox tool = new ECharts.Entities.ToolBox();
            var feature = new Feature();
            feature.DataView().Show(true).ReadOnly(false);
            feature.Mark().Show(true);
            feature.Restore().Show(true);
            feature.MagicType().Show(true).Type("line", "bar", "stack", "tiled");
            feature.SaveAsImage().Show(true);
            tool.Show(true).SetFeature(feature);
            tool.Orient(orient);
            return tool;
        }

        [AcceptVerbs("GET", "POST")]
        public string Test()
        {
            IList<string> ads = ChartsUtil.Ads();

            IList<int> data1 = ChartsUtil.Datas(7, 90, 240);
            IList<int> data2 = ChartsUtil.Datas(7, 190, 310);
            IList<int> data3 = ChartsUtil.Datas(7, 150, 410);
            IList<int> data4 = ChartsUtil.Datas(7, 300, 400);


            ChartOption option = new ChartOption();
            option.Title().Text("用户访问来源").SubText("虚构").X(HorizontalType.center);
            option.ToolTip().Trigger(TriggerType.item).Formatter(new JRaw(@"{a} <br/>{b} : {c} ({d}%)").ToString());
            option.Legend().Orient(OrientType.vertical).X(HorizontalType.left).SetData(new List<object>(ads.ToList()));
            option.ToolBox(ToolBox(OrientType.vertical));
            option.ToolBox().X(HorizontalType.right).Y(HorizontalType.center);
            option.calculable = true;
  
           

            var pie = new Pie("访问来源");

            pie.Radius("55%").Center(new List<string>() { "50%", "60%" });
            pie.Data(new PieData<int>(345, ads[0]), new PieData<int>(310, ads[1]), new PieData<int>(234, ads[2]),
                new PieData<int>(135, ads[3]), new PieData<int>(1543, ads[4]));

            var pie1 = new Pie("访问来源");

          

            option.Series(pie);

            var result = JsonTools.ObjectToJson2(option);
            return result;

        }
    }
}
