$(function () {
    $('#line').click(function () {
        line("line");
    })

    $('#stdLine').click(function () {       
        line("stdLine");
    })


    $('#heapLine').click(function () {
        line("heapLine");
    })

    $('#stdArea').click(function () {
        line("stdArea");
    })

    $('#heapArea').click(function () {
        line("heapArea");
    })


    $('#stdLine2').click(function () {
        line("stdLine2");
    })

    $('#area').click(function () {
        line("area");
    })


    $('#unequalLine').click(function () {
        line("unequalLine");
    })
  

    $('#timeLine').click(function () {
        line("timeLine");
    })
  
    $('#logLine').click(function () {
        line("logLine");
    })
})

function line(line) {
    $.ajax({
        url: "/api/ChartsData/" + line,
        type: "POST",
        success: function (data) {
            var option = eval('(' + data + ')');          
            //设置图表路径
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
            require(
    [
       'echarts',
        'echarts/chart/bar',// 使用柱状图就加载bar模块，按需加载
        'echarts/chart/line' // 使用柱状图就加载bar模块，按需加载
    ],
    function (ec) {
        // 基于准备好的dom，初始化echarts图表
        var myChart = ec.init(document.getElementById('charts'));
        // 为echarts对象加载数据
        myChart.setOption(option);
    }
);
        },
        error: function (msg) {
            alert("系统发生错误");
        }
    });
}