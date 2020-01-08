// REDUCER: receives an action and modifies the state
// 1 store = 1 context
import actions from './actions'; // to know what actions do we support

export const initialState = {
  user: {
    name: 'Rodolfo',
    age: 5
  },
  tasks: []
}

function updateTask(state, modifiedTask) {
  const updatedTasks = [...state.tasks];
  const taskToEdit = updatedTasks.find(single => single.name == modifiedTask.name);
  taskToEdit.name = modifiedTask.task.name;
  return { ...state, tasks: updatedTasks };
}

function createTask(state, task) {
  const updatedTasks = [...state.tasks, task];
  return { ...state, tasks: updatedTasks };
}

function deleteTask(state, name) {
  const updatedTasks = [...state.tasks];
  const index = updatedTasks.findIndex(task => task.name == name);
  updatedTasks.splice(index, 1);
  return { ...state, tasks: updatedTasks };
}

export default function globalReducer(state, action) {

  const { payload } = action;

  switch (action.type) {
    case (actions.UPDATE().type): return updateTask(state, payload);
    case (actions.CREATE().type): return createTask(state, payload);
    case (actions.DELETE().type): return deleteTask(state, payload);
    default: return state;
  }
}