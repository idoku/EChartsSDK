var timeTicket;
clearInterval(timeTicket);
timeTicket = setInterval(function () {
    option.series[0].data[0].value = (Math.random() * 100).toFixed(2) - 0;
    option.series[1].data[0].value = (Math.random() * 7).toFixed(2) - 0;
    option.series[2].data[0].value = (Math.random() * 2).toFixed(2) - 0;
    option.series[3].data[0].value = (Math.random() * 2).toFixed(2) - 0;
    myChart.setOption(option, true);
}, 2000)