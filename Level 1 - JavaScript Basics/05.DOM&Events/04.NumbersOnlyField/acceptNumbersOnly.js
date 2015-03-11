var text = document.getElementById('input');
var text2 = document.getElementById('input2');

function checkForWord(event) {
    text.style.backgroundColor = 'white';
    text.style.boxShadow = '0 0 0 #F00';
    var key = event.keyCode;
    key = String.fromCharCode(key);
    var regex = /[A-Za-z]/;
    if(!regex.test(key)) {
        event.returnValue = false;
        text.style.backgroundColor = 'red';
        text.style.boxShadow = '0 0 50px #F00';
    }
}

function checkForNum (event) {
    text2.style.backgroundColor = 'white';
    text2.style.boxShadow = '0 0 0 #F00';
    var key = event.keyCode;
    key = String.fromCharCode(key);
    var regex = /[0-9]|\./;
    if(!regex.test(key)) {
        event.returnValue = false;
        text2.style.backgroundColor = 'red';
        text2.style.boxShadow = '0 0 50px #F00';
    }
}