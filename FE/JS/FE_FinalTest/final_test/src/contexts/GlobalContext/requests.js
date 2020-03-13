import { postCredentials } from '../../restAPI/Services'
// import Cookie from 'js-cookie'

export default function GlobalRequests (state, dispatch, actions) {
  return function () {
    return {
      // POST_CREDENTIALS: async function (payload) {
      //   try {
      //     const response = await postCredentials(payload.credentials)
      //     payload.setCookie(response.data)
      //     payload.historyPush()
      //   } catch (error) {
      //     const { data, status } = error.response
      //     dispatch(actions.SET_INFORMATION({ error: { message: data, status: status } }))
      //     const TIME_TO_CLOSE_MESSAGE = 5000
      //     setTimeout(() => {
      //       dispatch(actions.SET_INFORMATION({ error: null }))
      //     }, TIME_TO_CLOSE_MESSAGE)
      //   }
      // },
      // GET_ACCOUNT_INFORMATION: async function () {
      //   const cookie = JSON.parse(Cookie.get('userInfo'))
      //   const newUserInfo = { ...cookie }
      //   dispatch(actions.SET_INFORMATION({ userInfo: newUserInfo }))
      //   return newUserInfo
      // },
      // LOGOUT: async function (payload) {
      //   await postLogout(payload)
      // }
    }
  }
}
