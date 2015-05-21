app.controller('StudentPageController', function($scope) {
    var student = {
        name: "Pesho",
        photo: "http://i49.vbox7.com/o/5cf/5cf4d5a6170.jpg",
        grade: 12,
        school: "High School of Mathematics",
        teacher: "Penka Machkarova"
    };

    $scope.student = student;
});