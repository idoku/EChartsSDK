
var legendName = [];
for (var i = 0, l = eventRiver2Data.length; i < l; i++) {
    legendName.push(eventRiver2Data[i].name);
    eventRiver2Data[i].itemStyle = {
        normal: {
            label: {
                show: false
            }
        },
        emphasis: {
            label: {
                show: false
            }
        }
    }
}