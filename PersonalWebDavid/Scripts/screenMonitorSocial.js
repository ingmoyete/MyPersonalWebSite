/// <reference path="jquery-1.12.0.min.js" />
// Global variables. Get windows old heightw
var oldHeightSize;
var oldWidthSize;
// Method =================================================
function setIconsInScreen() {
    // Get width and height of elements. (As it the element is display:none, it nned to be shown and hidden)
    $('div.site-wrap').css({ position: "absolute", visibility: "hidden", display: "block" }); // Show site to get height or width

    var widthOfColumn = $('#monitorColumn').width();
    var monitorImage = $('#monitorImage');
    var widthOfImage = monitorImage.width();
    var heightColumn = monitorImage.height();

    $('div.site-wrap').css({ position: "", visibility: "", display: "" });

    // Percentage of width image
    var percentage = widthOfImage * 0.17;

    // Set absolute positioning
    var horizontal = (widthOfColumn - widthOfImage) / 2 + percentage;

    // Set vertical position depending on screen
    if ($(window).width() >= 306 && $(window).width() <= 768) { // 306 -768
        var vertical = heightColumn * 0.44;
    }
    else if ($(window).width() <= 306) { //<306
        var vertical = heightColumn * 0.40;
    }
    else if ($(window).width() >= 768 && $(window).width() <= 992) {
        var vertical = heightColumn * 0.56;
    }
    else  { // > 768
        var vertical = heightColumn * 0.52;
    }

    // If both horizontal and vertical have values
    if (horizontal != 0 || vertical != 0) {
        $('div.monitorWrapper').attr('style',
            'left:' + horizontal + 'px;' +
            'top:' + vertical + 'px;');

    }
}

// Events =================================================
 //When ready: 
$(function () { 
    //oldHeightSize = $(window).height();
    //oldWidthSize = $(window).width();
    setIconsInScreen();

});

// When resizing: 
//$(window).on('resize', function () {
//    var currenHeight = $(window).height();
//    var currentWidth = $(window).width();

//    var sameWidthAndDifferentHeight = currenHeight != oldHeightSize && currentWidth == oldWidthSize;

//    // Check width to prevent resize event to be fired in android browsers
//    if (!sameWidthAndDifferentHeight) {
//        setIconsInScreen();
//    }

//});

