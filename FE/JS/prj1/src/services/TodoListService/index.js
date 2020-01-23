import httpClient from '../TodoListRequest'
export default {
  getDoggyImage() {
    return httpClient.get('/image/random');
  }
}