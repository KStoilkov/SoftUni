// Write a JavaScript function group(persons) that groups an array of persons by age,
// first or last name. Create a Person constructor to add every person in the person array.
// The group(persons) function must return an associative array, with keys – the groups
// (age, firstName and lastName) and values – arrays with persons in this group.
// Print on the console every entry of the returned associative array.
// Use function overloading (i.e. just one function). You may need to find how to use constructors.


function group(persons) {
    var groupThemBy = arguments[1];
    var result = {};

    for (var i = 0; i < persons.length; i++) {
        var grp = "Group ";

        switch (groupThemBy) {
            case 'firstname': grp += persons[i].firstName; break;
            case 'lastname': grp += persons[i].lastName; break;
            case 'age': grp += persons[i].age; break;
            default : return persons;
        }
        if (!result[grp]) {
            result[grp] = [];
        }
        result[grp].push(
            persons[i].firstName + " " +  persons[i].lastName + "(age " + persons[i].age + ")"
        );
    }

    return result;
}

function Person(firstName, lastName, age) {
    this.firstName = firstName || "";
    this.lastName = lastName || "";
    this.age = age || 0;
}

var people = [
new Person("Scott", "Guthrie", 38),
new Person("Scott", "Johns", 36),
new Person("Scott", "Hanselman", 39),
new Person("Jesse", "Liberty", 57),
new Person("Jon", "Skeet", 38)
];

console.log(group(people, 'age'));
console.log(group(people, 'firstname'));
console.log(group(people, 'lastname'));
