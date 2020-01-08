export default {
  UPDATE: (properties) => {
    return {
      type: 'UPDATE',
      payload: properties
    }
  },

  CREATE: (task) => {
    return {
      type: 'CREATE',
      payload: task
    }
  },

  DELETE: (id) => {
    return {
      type: 'DELETE',
      payload: id
    }
  }
}