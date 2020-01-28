import './style.css'
import React, { setState } from 'react'
export default function ActionButton({ isPrimary, onHover, title }) {
  // const [count, setCounter] = setState(0)
  return (
    <section className={`actionButtonCmpt ${isPrimary}`} onMouseEnter={onHover}>
      {title}
    </section>
  )
}