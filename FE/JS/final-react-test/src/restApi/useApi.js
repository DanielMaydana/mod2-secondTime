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
