
// const myName = 'ASDASDAS';

// (function () {
//     const myName = 'IIFE';
//     console.log(myName)
// })();

// (() => {
//     console.log(myName)
// })();

function doggy() {
    function getDog() {
        return 'brian';
    }

    return getDog();

    function getDog() {
        return 'vinnie';
    }
}

console.log(doggy());