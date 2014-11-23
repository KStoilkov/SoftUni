var area = document.getElementById('area');
var btn = document.getElementById('clear');
var date = new Date();
var mouse = {
    X: 0, Y: 0
};

document.onmousemove = function (e) {
    mouse.X = e.pageX;
    mouse.Y = e.pageY;
    area.innerHTML += 'X: ' + mouse.X + '; Y: ' + mouse.Y + " Time: " + date + '\n';
};
function clear() {
    area.innerHTML = '';
}
btn.addEventListener('click', clear);