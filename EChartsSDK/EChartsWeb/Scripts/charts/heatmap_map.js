var heatData = [];
for (var i = 0; i < 200; ++i) {
    heatData.push([
        100 + Math.random() * 20,
        24 + Math.random() * 16,
        Math.random()
    ]);
}
for (var j = 0; j < 10; ++j) {
    var x = 100 + Math.random() * 16;
    var y = 24 + Math.random() * 12;
    var cnt = 30 * Math.random();
    for (var i = 0; i < cnt; ++i) {
        heatData.push([
            x + Math.random() * 2,
            y + Math.random() * 2,
            Math.random()
        ]);
    }
}