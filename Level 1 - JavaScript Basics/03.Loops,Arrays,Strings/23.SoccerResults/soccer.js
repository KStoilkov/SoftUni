function soccer(arr) {
    var input = [];
    for (var i = 0; i < arr.length; i++) {
        input[i] = arr[i].split(/\s?[\/|:|-]\s?/g);
    }

    var result = {};
    for (i = 0; i < input.length; i++) {
        var homeTeam = input[i][0];
        var awayTeam = input[i][1];
        var homeTeamGoalScored = parseInt(input[i][2]);
        var awayTeamGoalScored = parseInt(input[i][3]);

        if (!result[homeTeam]) {
            result[homeTeam]= {};
        }
        if (!result[awayTeam]) {
            result[awayTeam]= {};
        }
        if (!result[homeTeam]['goalsScored']) {
            result[homeTeam]['goalsScored'] = 0;
        }
        result[homeTeam]['goalsScored'] += homeTeamGoalScored;
        if (!result[awayTeam]['goalsScored']) {
            result[awayTeam]['goalsScored'] = 0;
        }
        result[awayTeam]['goalsScored'] += awayTeamGoalScored;

        if (!result[homeTeam]['goalsConceded']) {
            result[homeTeam]['goalsConceded'] = findConcededGoals(homeTeam, input);
        }
        if (!result[awayTeam]['goalsConceded']) {
            result[awayTeam]['goalsConceded'] = findConcededGoals(awayTeam, input);
        }
        if(!result[homeTeam]['matchesPlayedWith']) {
            result[homeTeam]['matchesPlayedWith'] = [];
        }
        if(!result[awayTeam]['matchesPlayedWith']) {
            result[awayTeam]['matchesPlayedWith'] = [];
        }
        if(result[homeTeam]['matchesPlayedWith'].indexOf(awayTeam) === -1){
            result[homeTeam]['matchesPlayedWith'].push(awayTeam);
        }
        if(result[awayTeam]['matchesPlayedWith'].indexOf(homeTeam) === -1){
            result[awayTeam]['matchesPlayedWith'].push(homeTeam);
        }
        result[homeTeam]['matchesPlayedWith'].sort();
        result[awayTeam]['matchesPlayedWith'].sort();
    }
    var sorted = sortObject(result);
    var primaryResult = JSON.stringify(sorted);
    console.log(primaryResult);

    function findConcededGoals(team, allGames) {
        var conceded = 0;
        for (var i = 0; i < allGames.length; i++) {
            if (team === allGames[i][0]) {
                conceded += parseInt(allGames[i][3]);
            }
            else if (team === allGames[i][1]) {
                conceded += parseInt(allGames[i][2]);
            }
        }
        return conceded;
    }
    function sortObject(obj) {
        var keys = Object.keys(obj).sort();
        var sorted = {};

        for (var i = 0; i < keys.length; i++) {
            var key = keys[i];
            sorted[key] = obj[key];
        }

        return sorted;
    }
}

soccer(
    [ 'Germany / Argentina: 1-0',
        'Brazil / Netherlands: 0-3',
        'Netherlands / Argentina: 0-0',
        'Brazil / Germany: 1-7',
        'Argentina / Belgium: 1-0',
        'Netherlands / Costa Rica: 0-0',
        'France / Germany: 0-1',
        'Brazil / Colombia: 2-1' ]
);