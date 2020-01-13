export default function ReducerCreator(initialState, handlers) {
  return function reducer(state, action) {
    if (handlers.hasOwnProperty(action.type)) return handlers[action.type]
    else return state
  }
}