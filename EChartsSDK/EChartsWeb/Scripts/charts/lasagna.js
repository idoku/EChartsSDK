setTimeout(function () {
    var _ZR = myChart.getZrender();
    var TextShape = require('zrender/shape/Text');
    // 补充千层饼
    _ZR.addShape(new TextShape({
        style: {
            x: _ZR.getWidth() / 2,
            y: _ZR.getHeight() / 2,
            color: '#666',
            text: '恶梦的过去',
            textAlign: 'center'
        }
    }));
    _ZR.addShape(new TextShape({
        style: {
            x: _ZR.getWidth() / 2 + 200,
            y: _ZR.getHeight() / 2,
            brushType: 'fill',
            color: 'orange',
            text: '美好的未来',
            textAlign: 'left',
            textFont: 'normal 20px 微软雅黑'
        }
    }));
    _ZR.refresh();
}, 2000);

