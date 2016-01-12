$(function () {

    $('#stdScatter').click(function () {
        bar("StdScatter");
    })
     
    
    
});

function bar(bar)
{
    $.ajax({
        url: "/api/ChartsData/" + bar,
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
        'echarts/chart/scatter',// 使用柱状图就加载bar模块，按需加载        
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