import { useEffect, useState } from 'react'

export default function useAPIRequest(url, body, method) {

  const [data, setData] = useState(null);
  const [error, setError] = useState(null);
  const [isDone, setDone] = useState(false);

  useEffect(() => {

    (async () => {
      const res = await fetch(url, {
        method: method,
        body: body
      });

      if (!res.ok) setError(await res.text())
      else setData(await res.json())

      setDone(true);
    })();

  }, [data, error, isDone]);

  return [data, error, isDone];
}