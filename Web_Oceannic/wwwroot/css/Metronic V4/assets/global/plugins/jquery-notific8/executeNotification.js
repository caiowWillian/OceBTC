﻿var UINotific8 = function () {
    return {
        init: function () {
            $("#notific8_show").click(function (i) {
                var t = {
                    theme: $("#notific8_theme").val(),
                    sticky: $("#notific8_sticky").is(":checked"),
                    horizontalEdge: $("#notific8_pos_hor").val(),
                    verticalEdge: $("#notific8_pos_ver").val()
                },
                n = $(this); "" != $.trim($("#notific8_heading").val())
                && (t.heading = $.trim($("#notific8_heading").val())), t.sticky
                || (t.life = $("#notific8_life").val()),

                $.notific8("zindex", 11500),
                $.notific8($.trim($("#notific8_text").val()), t),
                n.attr("disabled", "disabled"),
                setTimeout(function () { n.removeAttr("disabled") }, 1e3)
            })
        }
    }
}(); jQuery(document).ready(function () { UINotific8.init() });

function alertWin8(theme, sticky, horizontal, vertical, message, title, timer) {
   
       var t = {
                theme: theme,
                sticky: sticky,
                horizontalEdge: horizontal,
                verticalEdge: vertical
            };
     
            n = $(this); "" != $.trim(title) && (t.heading = $.trim(title), t.sticky) || (t.life = timer),

            $.notific8("zindex", 11500),
            $.notific8(message, t),
            n.attr("disabled", "disabled"),
            setTimeout(function () { n.removeAttr("disabled") }, 1e3) 
}