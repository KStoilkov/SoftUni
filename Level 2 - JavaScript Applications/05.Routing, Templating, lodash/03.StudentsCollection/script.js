$(document).ready(function () {
    var students = [
        {"gender":"Male","firstName":"Joe","lastName":"Riley","age":22,"country":"Russia"},
        {"gender":"Female","firstName":"Lois","lastName":"Morgan","age":41,"country":"Bulgaria"},
        {"gender":"Male","firstName":"Roy","lastName":"Wood","age":33,"country":"Russia"},
        {"gender":"Female","firstName":"Diana","lastName":"Freeman","age":40,"country":"Argentina"},
        {"gender":"Female","firstName":"Bonnie","lastName":"Hunter","age":23,"country":"Bulgaria"},
        {"gender":"Male","firstName":"Joe","lastName":"Young","age":16,"country":"Bulgaria"},
        {"gender":"Female","firstName":"Kathryn","lastName":"Murray","age":22,"country":"Indonesia"},
        {"gender":"Male","firstName":"Dennis","lastName":"Woods","age":37,"country":"Bulgaria"},
        {"gender":"Male","firstName":"Billy","lastName":"Patterson","age":24,"country":"Bulgaria"},
        {"gender":"Male","firstName":"Willie","lastName":"Gray","age":42,"country":"China"},
        {"gender":"Male","firstName":"Justin","lastName":"Lawson","age":38,"country":"Bulgaria"},
        {"gender":"Male","firstName":"Ryan","lastName":"Foster","age":24,"country":"Indonesia"},
        {"gender":"Male","firstName":"Eugene","lastName":"Morris","age":37,"country":"Bulgaria"},
        {"gender":"Male","firstName":"Eugene","lastName":"Rivera","age":45,"country":"Philippines"},
        {"gender":"Female","firstName":"Kathleen","lastName":"Hunter","age":28,"country":"Bulgaria"}
    ];

    findStudents1();
    findStudents2();
    findStudents3();
    findStudents4();
    findStudents5();

    // #1 Find and print students between 18 and 24
    function findStudents1(){
        console.log('#1');

        console.log(_.filter(students, function(s) {
            return s.age > 17 && s.age < 25;
        }));
    }

    // #2 Find and print students whose first name is
    // alphabetically before their last name
    function findStudents2() {
        console.log('#2');

        console.log(_.filter(students, function (s) {
            return s.firstName < s.lastName;
        }));
    }

    // #3 Find and print students only from Bulgaria
    function findStudents3() {
        console.log('#3');
        console.log(_.where(students, {'country': 'Bulgaria'}));
    }

    // #4 Find the last five students
    function findStudents4() {
        console.log('#4');

        console.log(_.slice(students, students.length - 5, students.length));
    }

    // #5 Find first 3 students who are not from Bulgaria and are male
    function findStudents5() {
        console.log('#5');

        console.log(_.slice(_.filter(students, function (s) {
            return s.country !== 'Bulgaria' && s.gender === 'Male';
        }), 0 , 3));
    }
});

