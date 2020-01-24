import ActionsCreator from './../../utilities/actionCreator.js'
export const actionTypes = {
  UPDATE: 'UPDATE',
  CREATE: 'CREATE',
  DELETE: 'DELETE',
}
export default ActionsCreator(actionTypes);