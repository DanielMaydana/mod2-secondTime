import './style.css'
import React from 'react'
export default function Message({ position, content, navigation }) {
  const MESSAGE_WIDTH = 240
  const MESSAGE_HEIGHT = 78
  const WINDOW_WIDTH = window.innerWidth
  const WINDOW_HEIGHT = window.innerHeight
  const { top, left, width, height } = position
  const { onPrev, onNext } = navigation
  function adjustPosition() {
    const newLeft = (left + width + MESSAGE_WIDTH) < WINDOW_WIDTH ? (left + width) : (left - MESSAGE_WIDTH)
    const newTop = (top + MESSAGE_HEIGHT) < WINDOW_HEIGHT ? top : (top + height - MESSAGE_HEIGHT)
    return { top: `${newTop}px`, left: `${newLeft}px` }
  }
  return (
    <section className={'guideMessage'} style={adjustPosition()}>
      <section className="content">
        {content}
      </section>
      <section className="actions">
        <button onClick={onPrev}>&#8678;</button>
        <button onClick={onNext}>&#8680;</button>
      </section>
    </section>
  )
}