import React from 'react';
import './App.css';
function App() {

  function test(data){
    const arr = Array.from(data)
    const len = (arr.length - 1)
    const middle = Math.floor(len/2)
    return (len%2) ? `${arr[middle]}${arr[middle + 1]}` : arr[middle]
  }

  console.log(test('algo'))
  console.log(test('algoA'))

  return (
    <div className="App">
    </div>
  );
}

export default App;
