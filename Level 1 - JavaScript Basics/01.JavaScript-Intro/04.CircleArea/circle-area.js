function calcCircleArea(r){
    r = r.value;
    var area = Math.PI * r * r;
    var printResults = document.getElementById('results');
    printResults.innerHTML += ("<h3>Radius = " + r + ", Area = " + area + "</h3>");
}
