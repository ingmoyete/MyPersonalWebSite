/// <reference path="jquery-1.12.0.min.js" />
// Global variables
var isBetweenAyB = false;
var isHigherB = false;

var phoneScreenSize = 768; //px

// On scroll : Do animations
$(window).scroll(function () {
    // Check width to prevent resize event to be fired in android browsers
    if ($(window).width() <= 768)
    {
        // Type of animation for in and out
        var animationIn = "animated slideInRight";
        var animationOut = "animated slideOutRight";

        // Element to animate and class to show animation
        var showAnimation = "scrollMessage";
        var scrollDiv = $('.scrollWrapper');

        // Points in pixels
        //var profileSumary = $('#profileSummary');
        var A = 600; //profileSumary.offset().top; //600;
        var B = 2.8 * A; //profileSumary.outerHeight();//1200;

        // 1.- Between point A and B
        if ($(document).scrollTop() > A && $(document).scrollTop() < B) {

            if (!isBetweenAyB) {
                isBetweenAyB = true;
                scrollDiv.addClass(animationIn + ' ' + showAnimation);
                scrollDiv.one('webkitAnimationEnd mozAnimationEnd MSAnimationEnd oanimationend animationend', function () {
                    scrollDiv.removeClass(animationIn);
                });
            }
        }

        // 2.- Higher than point B
        if ($(document).scrollTop() > B) {

            if (!isHigherB) {
                isHigherB = true;
                scrollDiv.addClass(animationOut);
                scrollDiv.one('webkitAnimationEnd mozAnimationEnd MSAnimationEnd oanimationend animationend', function () {
                    scrollDiv.removeClass(animationOut + ' ' + showAnimation);
                });
            }
        }

    }

});