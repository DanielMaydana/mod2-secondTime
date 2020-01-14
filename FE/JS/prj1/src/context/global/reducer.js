// REDUCER: receives an action and modifies the state
// 1 store = 1 context
import ReducerCreator from '../reducerCreator'
import { actionTypes } from './actions' // to know what actions do we support
export const initialState = {
  user: {
    name: 'Rodolfo',
    age: 5
  },
  tasks: []
}
const createTask = (state, task) => {
  const updatedTasks = [...state.tasks, task];
  return { ...state, tasks: updatedTasks };
}
const updateTask = function (state, modifiedTask) {
  const updatedTasks = [...state.tasks];
  const taskToEdit = updatedTasks.find(single => single.name === modifiedTask.name);
  taskToEdit.name = modifiedTask.task.name;
  return { ...state, tasks: updatedTasks };
}
const deleteTask = function (state, name) {
  const updatedTasks = [...state.tasks];
  const index = updatedTasks.findIndex(task => task.name === name);
  updatedTasks.splice(index, 1);
  return { ...state, tasks: updatedTasks };
}
export default function GlobalReducer(state, action) {
  const handlers = {
    [actionTypes.CREATE]: createTask,
    [actionTypes.UPDATE]: updateTask,
    [actionTypes.DELETE]: deleteTask
  }
  return ReducerCreator(state, action, handlers)
}