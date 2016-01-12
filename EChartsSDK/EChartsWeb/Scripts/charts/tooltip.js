$(function () {
    //设置图表路径
    require.config({
        paths: {
            echarts: '/Scripts/plugins/echarts'
        }
    });

    $('#btnSearch').click(function () {
        $.ajax({
            url: "/api/ChartsData/ToolTip",
            type: "POST",
            dataType: "json",
            success: function (data) {
                var option = eval('('+data+')');
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
            myChart.setOption(option,true);
        }
    );
            },
            error: function (msg) {
                alert("系统发生错误");
            }
        });
    })
})