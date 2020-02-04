import httpClient from '../ChatRequest'
export function postMessage(message) {
  return httpClient.post('/api/Message', message)
}
