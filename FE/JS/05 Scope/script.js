let text = "Hate the taste";

let myObj = {
    text: "Quiverdown syndorme",
    funcA: () => {
        console.log(this.text) // don't do this
    },
    funcB: function () {
        console.log(this.text)
    },
    time: 0,
    interval: 1000,
    start: function () {
        setInterval(() => { // when using an arrow function we bypass the start-function-object context
            this.time++; // this "this" is from the start-function-object
            console.log(this.time)
        }, this.interval)
    }
}

// myObj.funcA();
// myObj.funcB();
myObj.start();