import React, { useReducer } from 'react'

import GlobalContext from './index'
import Reducer, { initialState } from './reducer'
import Request from './requests'
import actions from './actions'

export default function Provider ({ children }) {
  console.log(GlobalContext)
  const [state, dispatch] = useReducer(Reducer, initialState)
  const requests = Request(state, dispatch, actions)()
  return (
    <GlobalContext.Provider value={[requests, state, dispatch, actions]}>
      {children}
    </GlobalContext.Provider>
  )
}