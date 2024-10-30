// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

async function fetchInfo() {
    let userInput = document.getElementById("inputfld").value;
    let url = 'https://api.weather.gov/gridpoints/MPX/${userInput}/forcast'

    const response = await fetch(url);
    const data = await response.json();

    let weather = data.weather.period;

    let text = '<table class="table table-striped""><tr><th>Key</th><th>Value</th>'

    for (let key in weather) {
        text += '<tr><td>${key}</td><td>${weather[key]}</td></tr>'
    }

    text += '</table>'

    document.getElementById("output").innerHTML = text;

}
