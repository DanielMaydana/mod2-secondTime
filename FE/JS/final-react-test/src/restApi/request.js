import axios from 'axios'
const REST_BASE_URL = 'https://cat-fact.herokuapp.com/facts'
const httpClient = axios.create({
  baseURL: REST_BASE_URL,
  headers: { 'Access-Control-Allow-Origin': '*' }

  // headers: { 'Content-Type': 'application/json' }
})
export default httpClient
