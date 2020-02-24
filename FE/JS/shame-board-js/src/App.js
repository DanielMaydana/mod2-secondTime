import './App.css';
import React, { useState } from 'react';
import LayoutView from './views/LayoutView';
import ComponentA from './components/ComponentA'
import ComponentB from './components/ComponentB'
function App() {
  const [dataA, setDataA] = useState({ count: 0 })
  const [dataB, setDataB] = useState({ count: 0 })

  function onClickA () {
    setDataA(obj => {
      return { count: obj.count + 1 }
    })
  }

  function onClickB () {
    setDataB(obj => {
      return { count: obj.count + 1 }
    })
  }

  return (
    <section className="App">
      <ComponentA data={dataA} onClick={onClickA} />
      <ComponentB data={dataB} onClick={onClickB} />
    </section>
  );
}

export default App;
