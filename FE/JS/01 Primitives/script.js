var doggies = [
    {
        name: "Snoop",
        pedigree: false,
        age: 3,
        race: "Mutt"
    },
    {
        name: "Snoopy",
        pedigree: true,
        age: 2.5,
        race: "Collie"
    },
    {
        name: "Scooby Doo",
        pedigree: true,
        age: 2,
        race: "Mutt"
    },
    {
        name: "Brian",
        pedigree: false,
        age: 5,
        race: "German shepherd"
    },
    {
        name: "Vinnie",
        pedigree: true,
        age: 2,
        race: "Wiener"
    },
    {
        name: "Borolas",
        pedigree: false,
        age: 10,
        race: "Saluki"
    },
    {
        name: "Bear",
        pedigree: true,
        age: 13,
        race: "Mutt"
    },
    {
        name: "Rex",
        pedigree: true,
        age: 3.5,
        race: "Mutt"
    },
    {
        name: "Osco",
        pedigree: true,
        age: 1.8,
        race: "English collie"
    }
]

function hasPedigree(dog) {
    return dog.pedigree;
}

function isTwoYearsOld(dog) {
    return dog.age === 2;
}

function hasNameWithFer(dog) {
    return dog.name.includes("fer");
}

function isYoung(dog) {
    return dog.age < 3;
}

var selection1 = doggies.filter(dog => hasPedigree(dog))

var selection2 = doggies.filter(dog => isTwoYearsOld(dog) && hasPedigree(dog))

var selection3 = doggies.filter(dog => hasNameWithFer(dog)).map(
    function (dog) {
        return { doggieName: dog.name, doggieAge: dog.age }
    })

var selection4 = doggies.filter(dog => isYoung(dog))

console.log('101' == 101)