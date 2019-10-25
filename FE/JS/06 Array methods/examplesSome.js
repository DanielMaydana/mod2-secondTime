// 1.
// Find if there's someone with debt

const userMoneys = [
    {
        id: 234,
        balance: 32.00
    },
    {
        id: 232,
        balance: 12.30
    },
    {
        id: 323,
        balance: -3.3
    },
    {
        id: 431,
        balance: 0.0
    }
]

console.log(userMoneys.some(user => user.balance < 0))


// 2.
// Find if there's someone with repeated vowels in their names

let userNames = [
    {
        id: 237,
        name: "Joseph"
    },
    {
        id: 487,
        name: "Robert"
    },
    {
        id: 843,
        name: "Leah"
    },
    {
        id: 489,
        name: "Patrick"
    }
]

const hasRepeatedVowels = function (user) {

    const vowelRegex = "/[aeiou]/gi";
    const actualMatch = String(user).match(vowelRegex);

    return actualMatch === null ? false : true;
}

console.log(userNames.some(
    user => hasRepeatedVowels(user))
)

// 3.
// Find if there's more than one person with the same age

const usersByAge = [
    {
        id: 29,
        age: 32
    },
    {
        id: 32,
        age: 45
    },
    {
        id: 54,
        age: 43
    },
    {
        id: 23,
        age: 52
    },
    {
        id: 73,
        age: 45
    },
    {
        id: 10,
        age: 32
    },
]

// I know it wasn't necessary but I wanted to practice constructors and also some pattern:

class SingletonCounter {
    constructor() {

        if (!!SingletonCounter.instance) {
            return SingletonCounter.instance;
        }
        SingletonCounter.instance = this;

        return this;
    }
}

const count = new SingletonCounter();

// This function is so horrible, but I challenge myself to work inside of the .some method as
// if I was refactoring real code in the real world :P

console.log(
    usersByAge.some(

        user => {
            count[user.age] = (count[user.age] + 1) || 1;

            for (var prop in count) {
                if (Object.prototype.hasOwnProperty.call(count, prop)) {
                    if (count[prop] > 1) return true;
                }
            }

            return false;
        }
    )
)

