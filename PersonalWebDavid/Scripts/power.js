/// <reference path="../../../documents/visual studio 2015/projects/personalwebdavid/personalwebdavid/scripts/jquery-1.12.0.min.js" />
$(function ()
{
    $('.toggle-nav').click(function ()
    {
        $('body').toggleClass('show-nav');
       
        // Toggle between burger and close icon when menu is active-inactive
        $('.toggle-nav').toggleClass('menuIsActive');
        return false;
    });
});

$(document).keyup(function (e)
{
    if (e.keyCode == 27)
    {
        $('body').toggleClass('show-nav');
    }
});