import './App.css';
import React from 'react';
// import { subjectGrades, actions } from './dummy.js'
// import Grades from './views/Grades';
// import ActionForm from './components/ActionForm';
import TodoList from '../src/components/TodoList';
import GlobalProvider from '../src/context/global/provider';

function App() {
  return (
    <div className="App">
      {/* <ActionForm actions={actions} >
        <input type="text" required></input>
        <input type="text" required></input>
        <input type="text" required></input>
        <input type="text" required={true}></input>
      </ActionForm> */}
      <GlobalProvider>
        <TodoList />
      </GlobalProvider>
      {/* <Grades subjectGrades={subjectGrades} /> */}
    </div>
  );
}
export default App;