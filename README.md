## ECharts .Net类库
### 当前版本3.6.1 Echarts
java版:<https://github.com/abel533/ECharts>  
echart:<http://echarts.baidu.com/>  
演示地址:<http://echarts.idoku.cn/>  

本项目是一个.Net版的ECharts开发包,参考[@abel1533](https://github.com/abel533/ECharts)的java版本,主要目的是方便在.NET中构件Echarts中可能用的全部数据结构,完整的Option结构. ChartOption中的数据Series,包含Line-折线图,Bar-柱状图,Pie-饼图,Scatter-散点图等,支持Echarts中所有图表.支持所有Style类,如AreaStyle,ItemStyle,LineStyle等.支持多种Data数据类型,一个通用的Data数据,以及PieData,PolarData,TreeData等个性化数据结构.
你可以使用本项目直接构件一个Option对象,使用方法JsonTools.ObjectToJson2(option),(直接使用Json方式返回存在问题,因为function不是标准化的json格式,转换会报错).  

### 图表类型
图表类型3.x版本(2.x版本支持的图表不一样)
- Line  折线（面积）图  
- Bar  柱状（条形）图  
- Scatter  散点（气泡）图  
- K  K线图
- **Candlestick K线图**  
- Pie  饼（圆环）图
- Radar 雷达（面积）图
- Force 力导向布局图
- Map 地图
- Gauge 仪表盘
- Funnel 漏斗图
- Heatmap 热力图
- Treemap 矩形树图
- **EffectScatter - 涟漪效果散点图**
- **Boxplot - 箱线图** 
- **Graph - 关系图,可以实现force**
- **Parallel - 平行坐标系**
- **Sankey - 桑基图**
- **PictorialBar - 象形柱图**
- **ThemeRiver - 主题河流图**
- **Calendar - 日历图**
- **Map - 地图**

Echarts组件
- Axis  坐标轴
- Grid  网格
- Title  标题
- Tooltip  提示
- Legend  图例
- DataZoom  数据区域缩放
- DataRange  值域漫游
- Toolbox  工具箱
- Timeline  时间线
- **visualMap  视觉映射组件**

### 更新日志
**3.x版本相比2.x版本改动很大，除了部分图表不一样外，少数api也有改动，因此如果要从2.x升级3.x，一定要做好测试!**
3.6.1 2017.5.26
- 3.0版本去掉了k(改为candlestick),radar(雷达图),chord(和弦图),force(使用graph,layout=force替代),island(孤岛),eventRiver(事件河流图),venn(韦恩图),wordCloud(词云),Tree(树图)
- 3.0版本新增了lines(线图),effectScatter(涟漪效果散点图),candlestick(新的k线图),graph(关系图,可以实现force),boxplot(箱形图),parallel(平行坐标系),sankey(桑基图)
- 新增大量相关类，部分已有类增加大量属性

### Echarts网址
<http://echarts.baidu.com/>
 
#### ChartOption说明
1. ChartOption 是echarts的主要类.
2. 使用JsonTools.ObjectToJson2方法返回给前端时,需要使用eval('(' + data + ')')转换为JSON结构.
 
#### Function说明
由于json标准中不包含function类型,一般json库都不支持这种类型,处理这种类型最简单的方式是转换json字符串时,对字符串进行处理.
读者可以自行使用其他自定义方式实现,本项目使用的.net自带的JRaw()方式.不管是:
```C#
    "formatter": function(params) {
            // for text color
            var color = colorList[params[0].dataIndex];
            var res = '<div style="color:' + color + '">';
            res += '<strong>' + params[0].name + '消费（元）</strong>'
            for (var i = 0, l = params.length; i < l; i++) {
                res += '<br/>' + params[i].seriesName + ' : ' + params[i].value
            }
            res += '</div>';
            return res;
            },
```
和
```C#
"color": (function (){
                        var zrColor = require('zrender/tool/color');
                        return zrColor.getLinearGradient(
                            0, 400, 0, 300,
                            [[0, 'green'],[1, 'yellow']]
                        )
                    })(),
 ```
都可以利用JRaw来实现.
```C#
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
```
 和
```C#
            style.Emphasis().BarBorderColor("green").BarBorderWidth(5)
                .Color(new JRaw(@"(function (){
                        var zrColor = require('zrender/tool/color');
                        return zrColor.getLinearGradient(
                            0, 400, 0, 300,
                            [[0, 'red'],[1, 'orange']]
                        )
                    })()"))
                                                          
```
EchartsWeb
--------
本项目通过ASP.NET MVC和ASP.NET web api模拟了echarts官网网站中的全部示例,主要目的是方便大家参考使用和调整结构.
 
1.简单Line示例
#
演示地址: http://echarts.idoku.cn/home/example?api=line1
 
例子中给出的json结构.
```C#
{
  "calculable": true,
  "title": {
    "text": "未来一周天气变化",
    "subtext": "纯虚构数据",
    "show": true
  },
  "tooltip": {
    "trigger": "axis"
  },
  "legend": {
    "data": [
      "最高温度",
      "最低温度"
    ]
  },
  "xAxis": [
    {
      "data": [
        "周一",
        "周二",
        "周三",
        "周四",
        "周五",
        "周六",
        "周日"
      ],
      "boundaryGap": false,
      "type": "category"
    }
  ],
  "yAxis": [
    {
      "type": "value",
      "axisLabel": {
        "formatter": "{value} ℃"
      }
    }
  ],
  "series": [
    {
      "data": [
        13,
        10,
        12,
        10,
        13,
        13,
        14
      ],
      "type": "line",
      "name": "最高温度",
      "markPoint": {
        "data": [
          {
            "name": "最大值",
            "type": "max"
          },
          {
            "name": "最小值",
            "type": "min"
          }
        ]
      },
      "markLine": {
        "data": [
          {
            "name": "平均值",
            "type": "average"
          }
        ]
      }
    },
    {
      "data": [
        3,
        -1,
        1,
        -1,
        3,
        3,
        4
      ],
      "type": "line",
      "name": "最低温度",
      "markPoint": {
        "data": [
          {
            "name": "周最低",
            "value": -1,
            "xAxis": 1,
            "yAxis": -0.5
          }
        ]
      },
      "markLine": {
        "data": [
          {
            "name": "平均值",
            "type": "average"
          }
        ]
      }
    }
  ]
}
```
对应的源码:
```C#
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
 ```
3.         使用function的bar示例.
#
演示地址: http://echarts.idoku.cn/home/example?api=bar10#              
 
给出的json代码:
```C#
{
  "title": {
    "text": "温度计式图表",
    "subtext": "Form ExcelHome",
    "sublink": "http://e.weibo.com/1341556070/AizJXrAEa"
  },
  "toolbox": {
    "feature": {
      "mark": {
        "show": true
      },
      "dataView": {
        "show": true,
        "readOnly": false
      },
      "restore": {
        "show": true
      },
      "saveAsImage": {
        "show": true
      }
    },
    "show": true
  },
  "tooltip": {
    "trigger": "axis",
    "formatter": function (params){
            return params[0].name + '<br/>'
                   + params[0].seriesName + ' : ' + params[0].value + '<br/>'
                   + params[1].seriesName + ' : ' + (params[1].value + params[0].value);
            },
    "axisPointer": {
      "type": "shadow"
    }
  },
  "legend": {
    "data": [
      "Acutal",
      "Forecast"
    ]
  },
  "grid": {
    "y2": 30,
    "y": 80
  },
  "xAxis": [
    {
      "data": [
        "Cosco",
        "CMA",
        "APL",
        "OOCL",
        "Wanhai",
        "Zim"
      ],
      "type": "category"
    }
  ],
  "yAxis": [
    {
      "boundaryGap": [
        0.0,
        0.1
      ],
      "type": "value"
    }
  ],
  "series": [
    {
      "stack": "sum",
      "data": [
        260,
        200,
        220,
        120,
        100,
        80
      ],
      "type": "bar",
      "name": "Acutal",
      "itemStyle": {
        "normal": {
          "color": "tomato",
          "barBorderColor": "tomato",
          "barBorderRadius": 0,
          "barBorderWidth": 6,
          "label": {
            "show": true,
            "position": "insideTop"
          }
        }
      }
    },
    {
      "stack": "sum",
      "data": [
        40,
        80,
        50,
        80,
        80,
        70
      ],
      "type": "bar",
      "name": "Forecast",
      "itemStyle": {
        "normal": {
          "color": "#fff",
          "barBorderColor": "tomato",
          "barBorderRadius": 0,
          "barBorderWidth": 6,
          "label": {
            "show": true,
            "position": "top",
            "formatter": function (params) {
                            for (var i = 0, l = option.xAxis[0].data.length; i < l; i++) {
                                if (option.xAxis[0].data[i] == params.name) {
                                    return option.series[0].data[i] + params.value;
                                }
                            }
                        },
            "textStyle": {
              "color": "tomato"
            }
          }
        }
      }
    }
  ]
}
```

对应的源码:
```c#
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
```

