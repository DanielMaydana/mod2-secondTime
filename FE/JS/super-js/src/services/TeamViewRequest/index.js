import axios from 'axios';

const REST_BASE_URL = "https://meremind.herokuapp.com";

const httpClient = axios.create({
  baseURL: REST_BASE_URL,
  headers: {
    'Content-Type': 'application/json'
  }
});

export default httpClient;