var button = document.getElementById('likeButton');
function change() {
    if (button.innerText === 'Like') {
        button.innerText = 'Unlike';
    }
    else {
        button.innerText = 'Like';
    }
}