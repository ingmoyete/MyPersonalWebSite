/// <reference path="jquery-1.12.0.min.js" />

// Global variables and execute method. Get windows old height
var oldHeightSize;
var oldWidthSize;
// Method =========================================
function resizeHero() {
    // Get windows current height
    var win = $(this); //this = window
    var currentHeightSize = win.height();
    var currentWidthSize = win.width();

    //debugger;
    // Windonws height is set to 400 if less less than 400 px
    if (currentHeightSize < 400) 
    {
        currentHeightSize = 400;
    }
    // Set navigationHero height to the windows height
    var navigationHero = $('#navigationHeroId');
    navigationHero.attr('style', 'height:' + currentHeightSize + 'px;');

    // Set image height. Remove padding = 40px and Navbar = 76px
    var imageBoxHeight = currentHeightSize - 40 * 2 - 76;
    var paddings = 40;
    //$('#imageBox').height(imageBoxHeight);
    var imageBox = $('#imageBox');
    imageBox.attr('style', 'height:' + imageBoxHeight + 'px;');

    // Center vertically the two columns row
    var rowElement = $('#navigationHeroId').find('.row');
    rowElement.attr('style',
        'padding-top:' + paddings + 'px;' +
        'padding-bottom:' + paddings + 'px;');

    // Set font as a 7% of the image height
    var actualImageHeight = imageBox.height();
    var fontSize = actualImageHeight * 0.08;
    if (fontSize != 0) {
        navigationHero.attr('style', 'font-size:' + fontSize + 'px;');
    }

    // This css has been set already.
    //      #navigationHeroId{ **IT WILL HAS PADDING TOP FOR NAVBAR AND 550PX HEIGHT MINIMUM
    //        padding-top: 76px;
    //        padding-top: 120px;
    //        min-height: 400px;    
    //    }
    //    div.heroImagePortrait{ **WIDTH IS SET MAINTINING RATIO
    //        width: auto;
    //    }
    //    div.heroImagePortrait img{  **IMAGE GET SIZE OF THE PORTRAIT
    //        max-width: 100%;
    //        max-height: 100%;
    //    } 
}

// Events ==============================================

// Resize event
//$(window).on('resize', function () {
//    var currenHeight = $(window).height();
//    var currentWidth = $(window).width();

//    var sameWidthAndDifferentHeight = currenHeight != oldHeightSize && currentWidth == oldWidthSize;

//    // Check width to prevent resize event to be fired in android browsers
//    if (!sameWidthAndDifferentHeight) {
//        resizeHero();

//    }
//});

 //On ready event
$(function () {
    //oldHeightSize = $(window).height();
    //oldWidthSize = $(window).width();
    resizeHero();
});
