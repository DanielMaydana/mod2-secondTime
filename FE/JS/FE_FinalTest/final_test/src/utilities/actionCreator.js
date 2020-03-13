/**
 * This function creates actions based on the supported action types.
 * @param {Object} actionTypes - The types of the supported actions.
 * @returns {Object} A group of actions, each action as an object: { ACTION_TYPE : payload => { return { payload, type } } }
 */
export default function (actionTypes) {
  return Object.keys(actionTypes).reduce(function (result, type) {
    result[type] = (payload) => {
      return {
        payload,
        type
      }
    }
    return result
  }, {})
}
