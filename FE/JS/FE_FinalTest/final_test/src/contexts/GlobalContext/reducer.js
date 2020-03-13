import ReducerCreator from '../../utilities/reducerCreator'
import { actionTypes } from './actions'
export const initialState = {
  title: 'Main view title' 
}

function updateState (state, payload) {
  return { ...state, ...payload }
}

export default function GlobalReducer (state, action) {
  const handlers = {
    [actionTypes.UPDATE_STATE]: updateState
  }
  return ReducerCreator(state, action, handlers)
}
