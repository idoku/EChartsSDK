var heatData = [];
for (var i = 0; i < 20; ++i) {
    heatData.push([
        400 + Math.random() * 300,
        5 + Math.random() * 10,
        Math.random()
    ]);
}
for (var i = 0; i < 100; ++i) {
    heatData.push([
        100 + Math.random() * 600,
        150 + Math.random() * 50,
        Math.random()
    ]);
}
for (var i = 0; i < 200; ++i) {
    heatData.push([
        Math.random() * 1000,
        Math.random() * 800,
        Math.random() * 0.5
    ]);
}