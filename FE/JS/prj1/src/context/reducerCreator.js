export default function (state, action, handlers) {
  if (handlers.hasOwnProperty(action.type))
    return handlers[action.type](state, action.payload)
  else
    return state
}