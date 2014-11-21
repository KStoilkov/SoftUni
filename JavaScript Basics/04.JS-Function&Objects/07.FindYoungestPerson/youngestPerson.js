function findYoungestPerson(persons) {
    var sorted = persons.sort(function (a, b) {
        return a.age - b.age;
    });
    return console.log('The youngest person is ' +
    sorted[0].firstname + ' ' + sorted[0].lastname);
}
var persons = [
    { firstname : 'George', lastname: 'Kolev', age: 32},
    { firstname : 'Bay', lastname: 'Ivan', age: 81},
    { firstname : 'Baba', lastname: 'Ginka', age: 40}
];
findYoungestPerson(persons);