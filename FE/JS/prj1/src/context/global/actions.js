import ActionsCreator from '../actionsCreator'
export const actionTypes = {
  UPDATE: 'UPDATE',
  CREATE: 'CREATE',
  DELETE: 'DELETE'
}
export default ActionsCreator(actionTypes);