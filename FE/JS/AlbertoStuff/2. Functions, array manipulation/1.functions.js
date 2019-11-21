//A Function Declaration defines a named function
//variable without requiring variable assignment. 
function sayHello() {
  return 'Hello Word';
}
sayHello();

//A Function Expression defines a function
//as a part of a larger expression syntax
//(typically a variable assignment )
              //anonymous function
const sayGooDay = function (date) {
  return 'good Day' + date;
};
sayGooDay();

//Arrow function, ES6
//the principal difference in a arrow function of a ES5 function.
//use the value of this in the context in which it was defined 
const arrowFunction = () => {
  return 'goodDay';
};
const simpleArrowFunction = () => 'goodDay';
const simpleArrowFunctionB = date => 'goodDay';
const simpleArrowFunctionC = (date, age, man) => 'goodDay';

//Immediately Invoked Function Expression
//IIFE
//the variables inside the Grouping Operator () can't be
//accessed from outside, or parent scope
//in this case the global scope

(function () {
  console.log('I guys I am a IIFE');
  const myName = 'myName';

  function startCounters() {
  }

  function libraryAwesomeHelpers() {
  }
})();

console.log(myName);
startCounters();
libraryAwesomeHelpers();