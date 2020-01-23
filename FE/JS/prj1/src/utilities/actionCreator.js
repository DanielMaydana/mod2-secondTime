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
