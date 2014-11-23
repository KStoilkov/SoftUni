function calculateTip(arr){
    var bill = parseFloat(arr[0]);
    var mood = arr[1];
    var tip = 0;

    if (mood === 'happy') {
        tip = bill * 0.1;
    }
    else if (mood === 'married') {
        tip = bill * (0.05 / 100);
    }
    else if(mood === 'drunk') {
        tip = bill * 0.15;
        var toPow = tip;
        while (toPow >= 10) {
            toPow = toPow / 10;
            toPow = parseInt(toPow);
        }
        tip = Math.pow(tip, toPow);
    }
    else {
        tip = bill * 0.05;
    }
    console.log(tip.toFixed(2));
}

calculateTip(
    ['120.44','happy']
);
calculateTip(
    ['1230.83','drunk']
);
calculateTip(
    ['716','bored']
);
