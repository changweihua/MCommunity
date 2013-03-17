/// <reference path="jquery-1.9.0.js" />
/// <reference path="jquery-1.9.0.intellisense.js" />
$(function () {
    var href = location.href;
    var action = href.substring(href.lastIndexOf('/') + 1).toLowerCase();
    //alert(action);
    //alert($('.back-left a').length);
    $('.back-left li').each(function () {
        $(this).removeClass('active');
    });
    $('.back-left a').each(function () {
        var act = $(this).attr('href').substring($(this).attr('href').lastIndexOf('/') + 1).toLowerCase();
        if (act == action) {
            $(this).parent().addClass('active');
        } 
    });
});