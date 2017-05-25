var charts = [];
$(document).ready(function () {
    function t(t) {
        for (var n = "",
        a = 0,
        i = EXAMPLES.length; i > a; ++a) EXAMPLES[a].type === t && (n += '<li><a href="demo#' + EXAMPLES[a].id + '"><img src="' + GALLERY_THUMB_PATH + EXAMPLES[a].id + '.png"></a></li>');
        $("#nav-layer .chart-list").html(n)
    }
    function n(t, n) {
        var a = $(window).height(),
        i = a - n;
        return t >= i && (t = i),
        t
    }
    function a(t) {
        t ? (r.show(), l.show()) : (r.hide(), l.hide())
    }
    var i = $("#left-chart-nav ul"),
    o = location.pathname.match(/demo/);
    for (var e in CHART_TYPES) i.append($("<li>").append('<a class="left-chart-nav-link" id="left-chart-nav-' + e + '" ' + (o ? "" : 'href="#chart-type-' + e + '"') + '><div class="chart-icon"></div><div class="chart-name">' + CHART_TYPES[e] + "</div></a>"));
    var c = $("#left-chart-nav"),
    r = $("#nav-layer"),
    l = $("#nav-mask");
    c.on("mouseenter", "a",
    function () {
        var a = $(this),
        i = a.attr("id").split("-"),
        o = i[i.length - 1];
        t(o);
        var e = a.offset().top - $(document).scrollTop() - 9,
        c = r[0].offsetHeight;
        r.css("top", n(e, c))
    }),
    c.on("mouseover",
    function () {
        a(!0)
    }),
    r.on("click", ".iconfont",
    function () {
        a(!1)
    }).on("mouseover",
    function () {
        a(!0),
        Ps.update(r[0])
    }),
    l.on("mouseover",
    function () {
        setTimeout(function () {
            a(!1)
        },
        200)
    }),
    Ps.initialize(c[0]),
    Ps.initialize(r[0])
});


 