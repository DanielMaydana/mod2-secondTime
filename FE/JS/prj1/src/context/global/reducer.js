// REDUCER: receives an action and modifies the state
// 1 store = 1 context
import { actionTypes } from './actions'; // to know what actions do we support
import ReducerCreator from '../reducerCreator';
export const initialState = {
  user: {
    name: 'Rodolfo',
    age: 5
  },
  tasks: []
}
const updateTask = function (state, modifiedTask) {
  const updatedTasks = [...state.tasks];
  const taskToEdit = updatedTasks.find(single => single.name === modifiedTask.name);
  taskToEdit.name = modifiedTask.task.name;
  return { ...state, tasks: updatedTasks };
}
const createTask = function (state, task) {
  const updatedTasks = [...state.tasks, task];
  return { ...state, tasks: updatedTasks };
}
const deleteTask = function (state, name) {
  const updatedTasks = [...state.tasks];
  const index = updatedTasks.findIndex(task => task.name === name);
  updatedTasks.splice(index, 1);
  return { ...state, tasks: updatedTasks };
}
// export default function GlobalReducer(state, action) {
//   return ReducerCreator(initialState, {
//     [actionTypes.CREATE]: createTask
//   });
// }
export default function GlobalReducer(state, action) {
  const { payload } = action;
  switch (action.type) {
    case (actionTypes.CREATE): return createTask(state, payload);
    case (actionTypes.UPDATE): return updateTask(state, payload);
    case (actionTypes.DELETE): return deleteTask(state, payload);
    default: return state;
  }
}