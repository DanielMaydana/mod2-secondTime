// 1.
// Generate a new array with only the name and the loveliness.
// Change the name of the loveliness attribute to something more concise.
// Change the values of the loveliness attribute to string.

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

const conciseDogs = dogs.map(single => (
    {
        score: single.loveliness.toString(),
        name: single.name
    })
);

console.log(conciseDogs)


// 2.
// Generate a new array where each element is an object.
// Each space-separated-value should be a property of each new object. 

const formulaCodes = [
    "PN S9 V4",
    "DT C4 -B9",
    "ZL BY AK",
    "AK -2V -TC",
    "-DT H2 JH"
]

const arrangedFormula = formulaCodes.map((molecule, i) => {

    const singleAtoms = molecule.split(" ");

    return {
        id: i,
        atom1: singleAtoms[0],
        atom2: singleAtoms[1],
        atom3: singleAtoms[2]
    }
});

console.log(arrangedFormula);


// 3.
// Generate a new array from combining two arrays with the same length

const userIds = [
    434,
    431,
    424,
    713,
    230
]

const userNames = [
    "dan2zep",
    "tron738",
    "swagmaster420",
    "peachtrees",
    "gideon2002"
]

const completeUsers = userNames.map(function (singleName, i) {
    return {
        id: userIds[i],
        name: singleName
    }
});

console.log(completeUsers)