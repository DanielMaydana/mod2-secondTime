// // 1.
// // Flattening of arrays

// const multipleArrays = [
//     [2, 3, 4],
//     [1, 4, 42, 10],
//     [-12, 32, -3],
//     [4, 2, -23],
//     [-41, 0, 89],
// ]

// const flattened = multipleArrays.reduce((overall, elem) => [...overall, ...elem], [])

// console.log(flattened);


// // 2.
// // Get a new object with the total count for each group

// const usersByAge = [
//     {
//         id: 29,
//         age: 32
//     },
//     {
//         id: 32,
//         age: 45
//     },
//     {
//         id: 54,
//         age: 43
//     },
//     {
//         id: 23,
//         age: 52
//     },
//     {
//         id: 73,
//         age: 45
//     },
//     {
//         id: 10,
//         age: 32
//     },
// ]

// const countByAge = usersByAge.reduce((overall, elem) => {
//     overall[elem.age] = (overall[elem.age] + 1) || 1;
//     return overall;
// }, {})

// console.log(countByAge);


// // 3.
// // Remove duplicates from array of numbers

// const multipleValues = [1, 2, 6, 5, 5, 6, 4, 2, 1];

// const reduced = multipleValues.reduce((overall, elem) => {
//     return overall.includes(elem) ? overall : [...overall, elem];
// }, []);


// 4.
// Return number of vowels in the string 

const word1 = "quiver syndrome";
const arrayified1 = word1.split('');

const isVowel = function (letter) {

    const vowels = ['a', 'e', 'i', 'o', 'u'];

    return vowels.includes(letter);
}

const vowelcount = arrayified1.reduce((acc, elem) => {
    if (isVowel(elem)) acc++;
    return acc;
}, 0)

console.log(vowelcount);

// 5.
// Return individual count of letters in an object

const word2 = "eucaliptus ornament";
const arrayified2 = word2.split('');

const letterIndividualCount = arrayified2.reduce((acc, elem) => {
    acc[elem] = (acc[elem] + 1) || 1;
    return acc;
}, {})

console.log(letterIndividualCount);

