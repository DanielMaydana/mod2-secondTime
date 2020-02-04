import axios from 'axios'
const REST_BASE_URL = process.env.REACT_APP_CHAT_SERVICE
const httpClient = axios.create({
  baseURL: REST_BASE_URL,
  headers: { 'Content-Type': 'application/json' }
})
export default httpClient
