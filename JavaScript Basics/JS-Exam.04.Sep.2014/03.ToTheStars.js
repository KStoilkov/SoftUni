function stars(arr) {
    var firstLine = arr[0].split(/\s+/g);
    var secondLine = arr[1].split(/\s+/g);
    var thirdLine = arr[2].split(/\s+/g);
    var fourthLine = arr[3].split(/\s+/g);
    var fifthLine = arr[4].split(/\s+/g);

    var firstSystem = firstLine[0];
    var firstSystemX = parseFloat(firstLine[1]);
    var firstSystemY = parseFloat(firstLine[2]);

    var secondSystem = secondLine[0];
    var secondSystemX = parseFloat(secondLine[1]);
    var secondSystemY = parseFloat(secondLine[2]);

    var thirdSystem = thirdLine[0];
    var thirdSystemX = parseFloat(thirdLine[1]);
    var thirdSystemY = parseFloat(thirdLine[2]);

    var normandyX = parseFloat(fourthLine[0]);
    var normandyY = parseFloat(fourthLine[1]);

    var move = parseInt(fifthLine[0]);

    for (var i = 0; i <= move; i++) {
        if (normandyX <= firstSystemX + 1
            && normandyX >= firstSystemX - 1
            && normandyY >= firstSystemY - 1
            && normandyY <= firstSystemY + 1) {
            console.log(firstSystem.toLowerCase());
        }
        else if(normandyX <= secondSystemX + 1
            && normandyX >= secondSystemX - 1
            && normandyY >= secondSystemY - 1
            && normandyY <= secondSystemY + 1) {
            console.log(secondSystem.toLowerCase());
        }
        else if(normandyX <= thirdSystemX + 1
            && normandyX >= thirdSystemX - 1
            && normandyY >= thirdSystemY - 1
            && normandyY <= thirdSystemY + 1) {
            console.log(thirdSystem.toLowerCase());
        }
        else {
            console.log("space");
        }
        normandyY += 1;
    }
}
stars([ 'Sirius 3 7',
    'Alpha-Centauri 7 5',
    'Gamma-Cygni 10 10',
    '8 1',
    '6' ]);