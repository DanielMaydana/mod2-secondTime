// 1.
// Generate new array with the oldest and most lovely dogs

const dogs = [
    {
        name: 'Spook',
        months: 54,
        loveliness: 5
    }
    , {
        name: 'Cicero',
        months: 21,
        loveliness: 7
    },
    {
        name: 'Jeremy',
        months: 7,
        loveliness: 9
    },
    {
        name: 'Strud',
        months: 11,
        loveliness: 9
    }
]

const isOld = function (dog) {
    return dog.months > 10;
}

const isLovely = function (dog) {
    return dog.loveliness > 7;
}

const selectedDogs = dogs.filter(doggy => isOld(doggy) && isLovely(doggy));

console.log(selectedDogs);


// 2.
// Generate new array with sub arrays that have only multiples of a specific number

const weirdArray = [
    [1, 2, 4, 5],
    [4, 5, 3, 2],
    [21, 15, 27, 33],
    [3, 9, 12],
    [13, 13, 17],
    [5, 10, 10],
];

const hasOnlyMultiplesOf = function (multiple, subArray) {
    return subArray.every(num => num % multiple === 0);
}

const selection = weirdArray.filter(subArray => hasOnlyMultiplesOf(3, subArray));

console.log(selection);

// 3. 
// Generate a subarray with only the students with the average scores above 7

const students = [
    {
        id: 231,
        scores: [7, 3, 5]
    },
    {
        id: 541,
        scores: [3, 5, 6]
    },
    {
        id: 542,
        scores: [10, 9, 8]
    },
    {
        id: 168,
        scores: [8, 8, 7]
    },
    {
        id: 850,
        scores: [4, 7, 8]
    }
]

const scoreIsAboveAverage = function (student) {
    const averageScore = student.scores.reduce((sum, score) => sum + score);
    const size = student.scores.length;
    return averageScore / size > 5;
}

const honorStudents = students.filter((student, i) => scoreIsAboveAverage(student));

console.log(honorStudents);