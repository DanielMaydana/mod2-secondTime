import React from 'react';
import './App.css';
import GlobalProvider from './contexts/GlobalContext/provider'
import MainView from './views/MainView'

function App() {
  return (
    <div className="App">
      {/* <GlobalProvider> */}
        <MainView />
      {/* </GlobalProvider> */}
    </div>
  );
}

export default App;
