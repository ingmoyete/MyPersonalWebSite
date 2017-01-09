/// <reference path="jquery-1.12.0.min.js" />
var navBar = $('.sa-header-nav-1.navbar-home');
var hasBeenRemoved = false;
var hasBeenShowed = false;

function showBottomNavbar() {
    // Add style to hide bottom bar when scroll is at the begining. 0 px top
    if (!hasBeenShowed && $(document).scrollTop() == 0)
    {        
        navBar.attr('style',
        'box-shadow: none;' +
        'webkit-box-shadow: none;');

        hasBeenShowed = true;
        hasBeenRemoved = false;
    }    
}

function hideBottomNavbar() {
    // Remove bottom bar when scrolling 50 px from top
    if (!hasBeenRemoved && $(document).scrollTop() > 80)
    {
        navBar.removeAttr('style');

        hasBeenRemoved = true;
        hasBeenShowed = false;
    }

}

// On scrolling up or down
function scrolling() {
    showBottomNavbar();
    hideBottomNavbar();
}

// On ready event
$(function () {
    // Hide bottom bar when ready
    showBottomNavbar();
});


// On scroll : Show or Hide bottom bar
$(window).scroll(function () {
        scrolling();
});
