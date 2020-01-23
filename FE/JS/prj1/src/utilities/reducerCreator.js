export default function (state, action, handlers) {
  if (Object.hasOwnProperty.call(handlers, action.type))
    return handlers[action.type](state, action.payload)
  else
    return state
}