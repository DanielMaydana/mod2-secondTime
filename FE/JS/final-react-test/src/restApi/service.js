import httpClient from './request'

export function getCatsInfo () {
  return httpClient.get()
}
