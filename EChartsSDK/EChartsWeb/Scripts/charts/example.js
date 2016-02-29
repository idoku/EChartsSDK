var myChart;
var editor;
var domMain;
var domCode;
var domGraphic;
var iconResize;
var needRefresh = false;

var curTheme;
var hash = location.hash.replace('-en', '');
hash = hash.replace('#', '') || (needMap() ? 'default' : 'macarons');
var enVersion = location.hash.indexOf('-en') != -1;
hash += enVersion ? '-en' : '';
 


var curTheme;
function requireCallback(ec, defaultTheme) {
    curTheme = themeSelector ? defaultTheme : {};
    echarts = ec;
    refresh();
    window.onresize = myChart.resize;
}


$(function () {
    require.config({
        packages: [{
            name: 'echarts',
            location: '/Scripts/plugins/echarts',
            main: 'echarts',
        },
        {
            name: 'zrender',
            location: '/Scripts/plugins/zrender',
            main: 'zrender'
        }
        ]
    });
  
    var extJs = $('#hidExtJs').val();
    launchJs(extJs);

    var api = $('#hidApi').val();
    launch(api);

  
});


var themeSelector = $('#theme-select');
if (themeSelector) {
    themeSelector.html(
        '<option selected="true" name="macarons">macarons</option>'
        //+ '<option name="infographic">infographic</option>'
        //+ '<option name="shine">shine</option>'
        //+ '<option name="dark">dark</option>'
        //+ '<option name="blue">blue</option>'
        //+ '<option name="green">green</option>'
        //+ '<option name="red">red</option>'
        //+ '<option name="gray">gray</option>'
        //+ '<option name="helianthus">helianthus</option>'
        //+ '<option name="roma">roma</option>'
        //+ '<option name="mint">mint</option>'
        //+ '<option name="macarons2">macarons2</option>'
        //+ '<option name="sakura">sakura</option>'
        + '<option name="default">default</option>'
    );

    $(themeSelector).on('change', function () {
        selectChange($(this).val());
    });

    function selectChange(value) {
        var theme = value;
        myChart.showLoading();
        $(themeSelector).val(theme);
        if (theme != 'default') {
            window.location.hash = value + (enVersion ? '-en' : '');
            require(['theme/' + theme], function (tarTheme) {
                curTheme = tarTheme;
                setTimeout(refreshTheme, 500);
            })
        }
        else {
            window.location.hash = enVersion ? '-en' : '';
            curTheme = {};
            setTimeout(refreshTheme, 500);
        }
    }

    //function refreshTheme() {
    //    myChart.hideLoading();
    //    myChart.setTheme(curTheme);
    //}

    //if ($(themeSelector).val(hash.replace('-en', '')).val() != hash.replace('-en', '')) {
    //    $(themeSelector).val('macarons');
    //    hash = 'macarons' + enVersion ? '-en' : '';
    //    window.location.hash = hash;
    //}
}

function autoResize() {
    if ($(iconResize).hasClass('glyphicon-resize-full')) {
        focusCode();
        iconResize.className = 'glyphicon glyphicon-resize-small';
    }
    else {
        focusGraphic();
        iconResize.className = 'glyphicon glyphicon-resize-full';
    }
}

function focusCode() {
    domCode.className = 'col-md-8 ani';
    domGraphic.className = 'col-md-4 ani';
}

function focusGraphic() {
    domCode.className = 'col-md-4 ani';
    domGraphic.className = 'col-md-8 ani';
    if (needRefresh) {
        myChart.showLoading();
        setTimeout(refresh, 1000);
    }
}

function launch(api) {
    $.ajax({
        url: "/api/ChartsData/" + api,
        type: "POST",
        success: function (data) {             
              $('#code').val(data);
              editor = CodeMirror.fromTextArea(
                document.getElementById("code"),
                {
                    lineNumbers: true,
                    mode: "javascript"
                }
            );
              editor.setOption("theme", 'monokai');
              editor.on('change', function () { needRefresh = true; });
              domMain = document.getElementById('main');
              domCode = document.getElementById('sidebar-code');
              domGraphic = document.getElementById('graphic');
              iconResize = document.getElementById('icon-resize');
              launchExample();
              
        },
        error: function (msg) {
            alert("系统发生错误");
        }
    });
}

function needMap() {
    var href = location.href;
    return href.indexOf('map') != -1
           || href.indexOf('mix3') != -1
           || href.indexOf('mix5') != -1
           || href.indexOf('dataRange') != -1;

}

var option;
function refresh(isBtnRefresh) {
    if (isBtnRefresh) {
        needRefresh = true;
        focusGraphic();
        return;
    }
    needRefresh = false;
    if (myChart && myChart.dispose) {
        myChart.dispose();
    }
    myChart = echarts.init(domMain);
    window.onresize = myChart.resize;
    var data = editor.doc.getValue();
    option = eval('(' + data + ')');
    myChart.setOption(option)

    //

   // domMessage.innerHTML = '';
}

var isExampleLaunched;
function launchExample() {
    if (isExampleLaunched) {
        return;
    }

    // 按需加载
    isExampleLaunched = 1;
    require(
        [
            'echarts',
            'echarts/theme/' + hash.replace('-en', ''),
            'echarts/chart/line',
            'echarts/chart/bar',
            'echarts/chart/scatter',
            'echarts/chart/k',
            'echarts/chart/pie',
            'echarts/chart/radar',
            'echarts/chart/force',
            'echarts/chart/chord',
            'echarts/chart/gauge',
            'echarts/chart/funnel',
            'echarts/chart/eventRiver',
            'echarts/chart/venn',
            'echarts/chart/treemap',
            'echarts/chart/tree',
            'echarts/chart/wordCloud',
            'echarts/chart/heatmap',
            //needMap() ? 'echarts/chart/map' : 'echarts'
        ],
        requireCallback
    );
}

function launchJs(url)
{
    var script = document.createElement("script");
    script.type = "text/javascript";
    script.src = url;
    document.body.appendChild(script);
}
