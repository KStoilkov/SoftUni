var btn = document.getElementById('btnHideOddRows');
var rows = document.getElementsByTagName('td');
var table = document.getElementsByTagName('table');
btn.addEventListener('click', hideOddRows);

function hideOddRows() {
    for (var i =0; i < rows.length; i++) {
        var currentRowNum = parseInt(rows[i].innerText.substring(rows[i].innerText.length - 1, rows[i].innerText.length));
        if (currentRowNum % 2 !== 0) {
            table[0].deleteRow(i);
        }
    }

}
