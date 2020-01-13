import './App.css';
import React from 'react';
import Grades from './views/Grades';
import TodoList from '../src/components/TodoList';
import GlobalProvider from '../src/context/global/provider';
import ActionForm from './components/ActionForm';

function App() {

  const subjectGrades = [
    {
      generalInfo: {
        title: "JavaScript",
        trainer: "Alberto Blacut",
        mainScore: "B+"
      },
      monthlyGrades: [
        {
          month: "January",
          grade: "B"
        },
        {
          month: "February",
          grade: "B-"
        },
        {
          month: "March",
          grade: "B+"
        },
        {
          month: "April",
          grade: "C+"
        },
        {
          month: "May",
          grade: "C+"
        },
        {
          month: "June",
          grade: "C-"
        },
        {
          month: "July",
          grade: "B"
        }
      ]
    },
    {
      generalInfo: {
        title: "C++",
        trainer: "Ernesto Bascon",
        mainScore: "C+"
      },
      monthlyGrades: [
        {
          month: "January",
          grade: "B"
        },
        {
          month: "February",
          grade: "B-"
        },
        {
          month: "March",
          grade: "C+"
        },
        {
          month: "April",
          grade: "C+"
        },
        {
          month: "May",
          grade: "D+"
        },
        {
          month: "June",
          grade: "B"
        },
        {
          month: "July",
          grade: "B"
        }
      ]
    },
    {
      generalInfo: {
        title: "Monitoring",
        trainer: "Jose Ecos",
        mainScore: "C"
      },
      monthlyGrades: [
        {
          month: "January",
          grade: "B-"
        },
        {
          month: "February",
          grade: "C-"
        },
        {
          month: "March",
          grade: "C"
        },
        {
          month: "April",
          grade: "B-"
        },
        {
          month: "May",
          grade: "B"
        },
        {
          month: "June",
          grade: "C-"
        },
        {
          month: "July",
          grade: "B-"
        }
      ]
    },
    {
      generalInfo: {
        title: "C#",
        trainer: "Jose Ecos",
        mainScore: "C"
      },
      monthlyGrades: [
        {
          month: "January",
          grade: "C-"
        },
        {
          month: "February",
          grade: "C-"
        },
        {
          month: "March",
          grade: "C-"
        },
        {
          month: "April",
          grade: "C-"
        },
        {
          month: "May",
          grade: "C-"
        },
        {
          month: "June",
          grade: "C+"
        },
        {
          month: "July",
          grade: "B-"
        }
      ]
    },
    {
      generalInfo: {
        title: "Design",
        trainer: "Rosario Vargas",
        mainScore: "A"
      },
      monthlyGrades: [
        {
          month: "January",
          grade: "A"
        },
        {
          month: "February",
          grade: "A-"
        },
        {
          month: "March",
          grade: "A+"
        },
        {
          month: "April",
          grade: "B+"
        },
        {
          month: "May",
          grade: "B-"
        },
        {
          month: "June",
          grade: "B+"
        },
        {
          month: "July",
          grade: "B"
        }
      ]
    },
    {
      generalInfo: {
        title: "Dev Practices",
        trainer: "Carlos Leigue",
        mainScore: "C+"
      },
      monthlyGrades: [
        {
          month: "January",
          grade: "C+"
        },
        {
          month: "February",
          grade: "C+"
        },
        {
          month: "March",
          grade: "C+"
        },
        {
          month: "April",
          grade: "C+"
        },
        {
          month: "May",
          grade: "C+"
        },
        {
          month: "June",
          grade: "C-"
        },
        {
          month: "July",
          grade: "B-"
        }
      ]
    }
  ]

  const actions = [
    {
      title: "SEND",
      primary: true
    },
    {
      title: "PRINT",
      primary: false
    }
  ]

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