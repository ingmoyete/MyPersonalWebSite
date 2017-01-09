/// <reference path="jquery-1.12.0.min.js" />
var scrollButton = $('div.scrollUpButton');

// Ready event: hide summary section
$(function () {
    scrollButton.hide();
});

// Scroll event: when passing summary, button is shown

$(window).scroll(function () {
    if ($(document).scrollTop() > 700) {
        scrollButton.fadeIn();
    }
    if ($(document).scrollTop() < 700) {
        scrollButton.hide();
    }
});