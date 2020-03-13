/**
 * This is used in the reducer to replace the switch sentence.
 * Selects an action from the 'handler' depending on the 'action.type' and returns its evaluation. If not found, it returns the 'state'.
 * @param {Object} state - The state passed to the action through the 'dispatch' function.
 * @param {Object} action - The action being evaluated, in the format: { type, payload }
 * @param {Object} handlers - An object with the types of the supported actions as keys, and their respective functions as values. In the format: { ACTION_TYPE : implementation }
 * @returns {Object} The evaluation produced by the selected reducer.
 */
export default function (state, action, handlers) {
  if (Object.hasOwnProperty.call(handlers, action.type)) { return handlers[action.type](state, action.payload) } else { return state }
}
