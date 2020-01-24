import React, { useReducer } from 'react';
import reducer, { initialState } from './reducer';
import Global from './index';
import actions from './actions'
function Provider({ children }) {
  const [state, dispatch] = useReducer(reducer, initialState);
  return (
    <Global.Provider value={[state, dispatch, actions]}>
      {children}
    </Global.Provider>
  );
}
export default Provider;