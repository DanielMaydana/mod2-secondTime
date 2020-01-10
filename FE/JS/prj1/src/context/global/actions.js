export const actionTypes = {
  UPDATE: 'UPDATE',
  CREATE: 'CREATE',
  DELETE: 'DELETE'
}
export default {
  UPDATE: (properties) => {
    return {
      type: actionTypes.UPDATE,
      payload: properties
    }
  },
  CREATE: (task) => {
    return {
      type: actionTypes.CREATE,
      payload: task
    }
  },
  DELETE: (id) => {
    return {
      type: actionTypes.DELETE,
      payload: id
    }
  }
}