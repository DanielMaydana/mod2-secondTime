import './style.css'
import classnames from 'classnames'
import React, { useState } from 'react'
export default function ActionButton({ text, funny, ...props }) {
  const [count, setCount] = useState(0)
  const [timer, setTimer] = useState(null)
  function onHover(target) {
    clearTimeout(timer)
    const time = setTimeout(() => {
      setCount(0)
    }, 3000)
    setTimer(time)
    if(count >= 3)
      return
    else
      setCount(n => n + 1)
  }
  const buttonClass = classnames({
    customButton: true,
    funnyFirst: funny && count == 1,
    funnySecond: funny && count == 2,
    funnyThird: funny && count == 3,
  })
  return (
    <button classname={buttonClass} {...props} onMouseEnter={onHover}>
      {text}
    </button>
  )
}