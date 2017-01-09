/// <reference path="jquery-1.12.0.min.js" />
// Start global declaration
var allItems;
var numberOfItems;
var indexOfActiveItem;
var indexOfLastAI;
// End global declaration

// Method :  hide all items but the active
function setActiveItemAndHideSiblings(indexActive, indexLast) {

    // Hide last item (eq starts at 0) and show active item
    var lastItem = allItems.eq(indexLast - 1).hide()
    var activeItem = allItems.eq(indexActive - 1).fadeIn(500);
}

 // Ready Event
$(function () {
    // Get all items, count the total number of items, and get the index of the active item
    allItems = $('div.peopleItem');
    numberOfItems = allItems.length;

    // Set index of active items to 1, and hide all items / show first one
    indexOfActiveItem = 1;
    allItems.hide();
    allItems.first().show();

});

// Click Event: click previous button
$('#previousPeopleSlider').click(function (e) {
    e.preventDefault();/*Prevent to follow href*/

    // If there is a next item
    if (indexOfActiveItem > 1) {
        // Increase index of item
        indexOfLastAI = indexOfActiveItem;
        indexOfActiveItem = indexOfActiveItem - 1;

        setActiveItemAndHideSiblings(indexOfActiveItem, indexOfLastAI);
    }
});

// Click Event: click next button
$('#nextPeopleSlider').click(function (e) {
    e.preventDefault(); /*Prevent to follow href*/

    // If there is a next item
    if (indexOfActiveItem < numberOfItems) {

        // Increase index of item
        indexOfLastAI = indexOfActiveItem;
        indexOfActiveItem = indexOfActiveItem + 1;

        setActiveItemAndHideSiblings(indexOfActiveItem, indexOfLastAI);
    }
});

// Click event: view button
$('#view').click(function (e) {
    e.preventDefault();
    allItems.show();
    $('div.sliderButtons').hide();
});
