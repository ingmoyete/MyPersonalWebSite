/// <reference path="jquery-1.12.0.min.js" />
var imageBox = null;
var monitorImage = null;

// Methods ================================================
// Remove preloader method
function removePreloader() {
    $('div.site-wrap').removeClass('loading');
    $('#containerPreloader').hide();
}

// Ready method
function readyMethod() {
    // Check if image are loaded
    if (imageBox != null && imageBox.images.length > 0) {
        resizeHero();
        removePreloader();
    }
    if (monitorImage != null && monitorImage.images.length > 0) {
        setIconsInScreen();
        removePreloader();
    }
    // Fallback if there is no image
    if (imageBox != null && monitorImage != null) {
        removePreloader();
    }
}

// Events ================================================
// When monitorScreenImage is loaded
$('#monitorColumn').imagesLoaded(function (instance) {
    monitorImage = instance;

    // If DOM ready and images exist in DOM, go to ready method
    if (jQuery.isReady) {        
        readyMethod();
    }

});

// When imageBox is loaded
$('#imageBox').imagesLoaded(function (instance) {
    imageBox = instance;

    if (jQuery.isReady) {       
        readyMethod();
    }

});


// When ready: remove preloader
$(function () {
    readyMethod();
});