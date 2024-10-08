/*------------------------------------
  HT Parallax
--------------------------------------*/
!function(e) {
    e.fn.parallaxie = function(o) {
        o = e.extend({
            speed: .2,
            repeat: "no-repeat",
            size: "cover",
            pos_x: "center",
            offset: 0
        }, o);
        return this.each(function() {
            var a = e(this)
              , t = a.data("parallaxie");
            "object" != typeof t && (t = {}),
            t = e.extend({}, o, t);
            var s = a.data("image");
            if (void 0 === s) {
                if (!(s = a.css("background-image")))
                    return;
                var n = t.offset + (a.offset().top - e(window).scrollTop()) * (1 - t.speed);
                a.css({
                    "background-image": s,
                    "background-size": t.size,
                    "background-repeat": t.repeat,
                    "background-attachment": "fixed",
                    "background-position": t.pos_x + " " + n + "px"
                }),
                e(window).scroll(function() {
                    var o = t.offset + (a.offset().top - e(window).scrollTop()) * (1 - t.speed);
                    a.data("pos_y", o),
                    a.css("background-position", t.pos_x + " " + o + "px")
                })
            }
        }),
        this
    }
}(jQuery);


