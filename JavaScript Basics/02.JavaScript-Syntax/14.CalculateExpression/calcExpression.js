// Write a HTML page (with text field, button, and paragraph).
// Write JS program calcExpression.js that calculates any expression put in the text
// field and prints it in the paragraph. Link the JS file to the HTML file.
// (100% accuracy is not required).

function calculate() {
    var input = document.getElementById('input').value.replace(/[^0-9+-/*]+/, "");
    var calc = eval(input);
    var result = document.getElementById('result');
    if (calc != undefined) {
        result.innerHTML = calc;
    }
    else {
        result.innerHTML = "Please enter expression!"
    }
}