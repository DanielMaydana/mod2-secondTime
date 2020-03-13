/**
 * This is custom hook used to make api request in the reducer to replace the switch sentence.
 * @param {requestCallback} - The api request to execute.
 * @returns {(Object|boolean|Object)} From first to last position on the array: The response of the request, the state of completion or not of the request, and the error if a bad request is received.
*/
import { useEffect, useState } from 'react'
export default function (callback) {
  const [loading, setLoading] = useState(false)
  const [response, setResponse] = useState(null)
  const [error, setError] = useState(null)
  useEffect(() => {
    executeRequest(callback)
  }, [])
  async function executeRequest (callback) {
    try {
      setLoading(true)
      const response = await callback()
      setResponse(response)
      setLoading(false)
    } catch (actualError) {
      setError(actualError)
      setLoading(false)
    }
  }
  return [response, loading, error]
}
