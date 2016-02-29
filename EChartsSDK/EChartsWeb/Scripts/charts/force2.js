var nodes = [];
var links = [];
var constMaxDepth = 2;
var constMaxChildren = 7;
var constMinChildren = 4;
var constMaxRadius = 10;
var constMinRadius = 2;

function rangeRandom(min, max) {
    return Math.random() * (max - min) + min;
}

function createRandomNode(depth) {
    var node = {
        name: 'NODE_' + nodes.length,
        value: rangeRandom(constMinRadius, constMaxRadius),
        // Custom properties
        id: nodes.length,
        depth: depth,
        category: depth === constMaxDepth ? 0 : 1
    }
    nodes.push(node);

    return node;
}

function forceMockThreeData() {
    var depth = 0;
    var rootNode = {
        name: 'ROOT',
        value: rangeRandom(constMinRadius, constMaxRadius),
        // Custom properties
        id: 0,
        depth: 0,
        category: 2
    }
    nodes.push(rootNode);

    function mock(parentNode, depth) {
        var nChildren = Math.round(rangeRandom(constMinChildren, constMaxChildren));

        for (var i = 0; i < nChildren; i++) {
            var childNode = createRandomNode(depth);
            links.push({
                source: parentNode.id,
                target: childNode.id,
                weight: 1
            });
            if (depth < constMaxDepth) {
                mock(childNode, depth + 1);
            }
        }
    }

    mock(rootNode, 0);
}

forceMockThreeData();