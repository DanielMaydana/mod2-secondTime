import View1 from './views/View1';
import View2 from './views/View2';
import View3 from './views/View3';
import ViewTodoList from './views/ViewTodoList'
export const subjectGrades = [
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

export const actions = [
  {
    title: "SEND",
    primary: true
  },
  {
    title: "PRINT",
    primary: false
  }
]

export const viewArray = [
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