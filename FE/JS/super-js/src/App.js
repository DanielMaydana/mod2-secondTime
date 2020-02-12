import './App.css';
import React, { useState, useEffect, useRef } from 'react';
import { subjectGrades, actions, viewArray } from './dummy.js'
import View1 from './views/View1';
import View2 from './views/View2';
import View3 from './views/View3';

// import Chat from './components/Chat'
// import ActionForm from './components/ActionForm';
// import ActionButton from './components/ActionButton';
// import GuideView from './views/GuideView';
// import MemoryLeakTest from './components/MemoryLeakTest';
// import Grades from './views/Grades';
// import LayoutView from './views/LayoutView';
// import TodoList from '../src/components/TodoList';
// import GlobalProvider from '../src/context/global/provider';
import PortalLayout from './components/PortalLayout';
// import SideNavbar from './components/SideNavbar';
// import SidenavOption from './components/SidenavOption';
// import Calendar from 'react-calendar';

function App() {
  const [userPassword, setPassword] = useState('')
  const getPassword = (event) => { setPassword(event.target.value) }
  const [show, setShow] = useState(false)
  const toggle = function () { setShow(show => !show) }

  function onChange(time) {
    console.log(time);
  }

  return (
    <div className="App">
      {/* <button onClick={toggle}>Memleak</button>
      {show && <MemoryLeakTest />} */}
      {/* <ActionForm actions={actions} >
        <input type="email" required></input>
        <input type="password" onChange={getPassword} required></input>
        <input type="password" pattern={userPassword} required></input>
      </ActionForm> */}
      {/* <GuideView />  */}
      {/* <Chat /> */}
      {/* <GlobalProvider>
        <TodoList />
      </GlobalProvider> */}
      {/* <LayoutView /> */}
      {/* <SideNavbar title={'My apps'}>
        <SidenavOption text={'Dashboard'} icon={'dashboard'} onClick={()=>console.log('Dashboard')} />
        <SidenavOption text={'Grades'} icon={'ballot'} onClick={()=>console.log('Grades')} />
        <SidenavOption text={'Tickets'} icon={'assignment_turned_in'} onClick={()=>console.log('Tickets')} />
        <SidenavOption text={'Tasks'} icon={'assignment'} onClick={()=>console.log('Tasks')} />
        <SidenavOption text={'Meetings'} icon={'group'} onClick={()=>console.log('Meetings')} />
      </SideNavbar> */}
      {/* <Grades subjectGrades={subjectGrades} /> */}
      <PortalLayout views={viewArray} />
      {/* <View2 /> */}
    </div>
  );
}
export default App;