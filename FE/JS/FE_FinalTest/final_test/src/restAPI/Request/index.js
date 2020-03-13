import axios from 'axios'
const REST_BASE_URL = 'ALBERTO_URL'
const httpClient = axios.create({
  baseURL: REST_BASE_URL,
  headers: { 'Content-Type': 'application/json' }
})
export default httpClient
