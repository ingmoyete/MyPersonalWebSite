//1.- hold “SHIFT” + right click in project directory + open cmd here
//2.- Install node.js from https://nodejs.org
//    a.- make sure you have installed it by typing “node -v” in cmd
//b.- type “npm install -g grunt-cli” in cmd
//c.- type “grunt -V” to make sure it was installed correctly
//3.- Install purify css by typing “npm install grunt-purifycss --save-dev
//” in cmd
//4.- Create app.js in the project directory and paste this code (THIS FILE)
//5.- hold “SHIFT” + right click in project directory + open cmd here. Type “node app.js”


var purify = require('purify-css');
// Set urls
var content = ['C:\\Users\\David\\Documents\\Visual Studio 2015\\Projects\\PersonalWebDavid\\PersonalWebDavid\\Views\\Home\\*.cshtml',
                'C:\\Users\\David\\Documents\\Visual Studio 2015\\Projects\\PersonalWebDavid\\PersonalWebDavid\\Views\\ProjectItems\\*.cshtml',
               'C:\\Users\\David\\Documents\\Visual Studio 2015\\Projects\\PersonalWebDavid\\PersonalWebDavid\\Views\\Shared\\*.cshtml'];

var css = ['C:\\Users\\David\\Documents\\Visual Studio 2015\\Projects\\PersonalWebDavid\\PersonalWebDavid\\Content\\style(1).css',];
            'C:\\Users\\David\\Documents\\Visual Studio 2015\\Projects\\PersonalWebDavid\\PersonalWebDavid\\Content\\slatBlue.css',
            'C:\\Users\\David\\Documents\\Visual Studio 2015\\Projects\\PersonalWebDavid\\PersonalWebDavid\\Content\\responsive.css'
var options = {
    output: 'C:\\Users\\David\\Documents\\Visual Studio 2015\\Projects\\PersonalWebDavid\\PersonalWebDavid\\Content\\style(1)-StatBlue-responsive-Tiny.css',

    // Will minify CSS code in addition to purify.
    minify: false,
    info: true,
    // Logs out removed selectors.
    rejected: true
};

purify(content, css, options);