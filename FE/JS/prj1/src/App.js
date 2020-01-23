import './App.css';
import React, { useState, useEffect, useRef } from 'react';
import { subjectGrades, actions } from './dummy.js'
import ActionForm from './components/ActionForm';
import MemoryLeakTest from './components/MemoryLeakTest';
import Grades from './views/Grades';
import TodoList from '../src/components/TodoList';
import GlobalProvider from '../src/context/global/provider';
import View1 from './views/View1';
import View2 from './views/View2';
import View3 from './views/View3';
import ViewTodoList from './views/ViewTodoList'
import PortalLayout from './components/PortalLayout';
function App() {
  const [userPassword, setPassword] = useState('')
  const getPassword = (event) => { setPassword(event.target.value) }
  const [show, setShow] = useState(false)
  const toggle = function () { setShow(show => !show) }

  const viewArray = [
    {
      title: 'To View 1',
      path: '/view1',
      component: View1,
    },
    {
      title: 'To View 2',
      path: '/view2',
      component: View2,
    },
    {
      title: 'To View 3',
      path: '/view3',
      component: View3,
    },
    {
      title: 'Todo List',
      path: '/todoList',
      component: ViewTodoList
    }
  ]

  return (
    <div className="App">
      {/* <button onClick={toggle}>Memleak</button>
      {show && <MemoryLeakTest />} */}
      {/* <ActionForm actions={actions} >
        <input type="email" required></input>
        <input type="password" onChange={getPassword} required></input>
        <input type="password" pattern={userPassword} required></input>
      </ActionForm> */}
      {/* <GlobalProvider>
        <TodoList />
      </GlobalProvider> */}
      {/* <Grades subjectGrades={subjectGrades} /> */}
      <PortalLayout views={viewArray} />
    </div>
  );
}
export default App;