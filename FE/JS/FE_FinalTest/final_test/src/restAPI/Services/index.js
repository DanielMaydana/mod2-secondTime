import httpClient from '../Request'

export function postCredentials (credentials) {
  return httpClient.post('/api/auth/', credentials)
}
