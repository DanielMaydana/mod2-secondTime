import React, { useEffect } from 'react'
export default function () {
  const clickHandler = function () {
    console.log('clicked')
  }
  useEffect(() => {
    document.body.addEventListener('click', clickHandler)
    return () => document.body.removeEventListener('click', clickHandler)
  }, [])

  return (
    <div>Memory leak</div>
  )
}