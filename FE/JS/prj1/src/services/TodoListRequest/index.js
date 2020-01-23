import axios from 'axios';
// const REST_BASE_URL = process.env.DOG_CEO_URL;
const REST_BASE_URL = "https://dog.ceo/api/breeds"
const httpClient = axios.create({
  baseURL: REST_BASE_URL,
  headers: {
    'Content-Type': 'application/json'
  }
});
console.log("REST_BASE_URL", REST_BASE_URL);
httpClient.interceptors.response.use(
  function (response) {
    return response;
  },
  function (error) {
    if (error.response)
      return Promise.reject(error.response.data.value);
    else
      return Promise.reject(error.message);
  });

export default httpClient;